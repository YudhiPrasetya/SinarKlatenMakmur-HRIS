using MassTransit;
using Microsoft.EntityFrameworkCore;
using PayrollAPI.Data;
using PayrollAPI.Model;
using SKM.Shared.Models;

namespace PayrollAPI.Services {
   public class Payroll_LemburService : IPayroll_LemburService, IConsumer<Batch<SuratPerintahLemburCreated>> {
      private readonly DbContextClass _dbContextClass;

      public Payroll_LemburService(DbContextClass dbContextClass)
        {
         _dbContextClass = dbContextClass;
      }
      public async Task Consume(ConsumeContext<Batch<SuratPerintahLemburCreated>> context) {
         //throw new NotImplementedException();
         List<SuratPerintahLemburCreated> msgData = new();
         for(int i = 0; i < context.Message.Length; i++) {
            ConsumeContext<SuratPerintahLemburCreated> msg = context.Message[i];
            msgData.Add(new SuratPerintahLemburCreated {
               EmployeeId = msg.Message.EmployeeId,
               NIK = msg.Message.NIK,
               EmployeeName = msg.Message.EmployeeName,
               GroupName = msg.Message.GroupName,
               DepartmentName = msg.Message.DepartmentName,
               OTDate = msg.Message.OTDate,
               UpahLembur = msg.Message.UpahLembur
            });
         }
         foreach(var msg in msgData) {
            int bulan = msg.OTDate.Month;
            int tahun = msg.OTDate.Year;
            var payroll = await GetByIdEmployeeMonthYear(msg.EmployeeId, bulan, tahun);
            if(payroll != null) {
               int upah = HitungUpah(payroll.Upah, payroll.TotalMasuk);
               decimal totalLembur = msg.UpahLembur + payroll.TotalLembur;
               decimal gaji = upah + totalLembur;
               payroll.TotalLembur = totalLembur;
               payroll.Gaji = gaji;
               _dbContextClass.Payrolls.Update(payroll);
               await _dbContextClass.SaveChangesAsync();
            }
         }
      }

      private int HitungUpah(decimal upah, int aktifKerja) {
         int upahHarian = (int)Math.Round((decimal)(upah / 21) * aktifKerja);
         return upahHarian;
      }

      private async Task<Payroll> GetByIdEmployeeMonthYear(int id, int month, int year) {
         //throw new NotImplementedException();
         return await _dbContextClass.Payrolls.Where(p => p.IdEmployee == id && p.Bulan == month && p.Tahun == year).FirstOrDefaultAsync();

      }

      public Task<IEnumerable<Payroll>> GetPayrolls_Lembur() {
         throw new NotImplementedException();
      }
   }
}
