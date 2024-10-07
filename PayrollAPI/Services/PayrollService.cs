using MassTransit;
using Microsoft.EntityFrameworkCore;
using PayrollAPI.Conversions;
using PayrollAPI.Data;
using PayrollAPI.Model;
using SKM.Shared.Dtos;
using SKM.Shared.Models;

namespace PayrollAPI.Services {
   public class PayrollService: IPayrollService, IConsumer<GajiDanTunjanganCreated> {
      private readonly DbContextClass _dbContext;

      public PayrollService(DbContextClass dbContext)
      {
         _dbContext = dbContext;
      }

      public async Task<Payroll> AddPayroll(Payroll newPayroll) {
         //throw new NotImplementedException();
         var payroll = await _dbContext.Payrolls.Where(p => p.NIK == newPayroll.NIK && p.Bulan == newPayroll.Bulan && p.Tahun == newPayroll.Tahun).FirstOrDefaultAsync();

         if (payroll == null) {
            var p = await _dbContext.Payrolls.AddAsync(newPayroll);
            await _dbContext.SaveChangesAsync();
            return p.Entity;
         }
         else {
            int totalMasuk = payroll.TotalMasuk + newPayroll.TotalMasuk;
            decimal upahHarian = Math.Round((decimal)payroll.Upah / 21, 2);
            decimal gaji = Math.Round((decimal)(upahHarian * totalMasuk) + payroll.TotalLembur, 2);
            payroll.TotalMasuk = totalMasuk;
            payroll.Gaji = gaji;
            payroll.UpdatedAt = DateTime.Now;
            var p = _dbContext.Payrolls.Update(payroll);
            await _dbContext.SaveChangesAsync();
            return p.Entity;
         }
      }

      public async Task Consume(ConsumeContext<GajiDanTunjanganCreated> context) {
         var dataFromProducer = context.Message;
         Payroll payroll = new() {
            Bulan = 0,
            Tahun = 0,
            IdEmployee = dataFromProducer.EmployeeId,
            EmployeeName = dataFromProducer.NamaKaryawan,
            GroupName = dataFromProducer.GrupKerja,
            DepartmentName = dataFromProducer.DepartmentName,
            Upah = dataFromProducer.Upah,
            TotalMasuk = 0,
            TotalLembur = 0,
            Gaji = 0,
            CreatedBy = 1,
            CreatedAt = DateTime.Now,
            UpdatedBy = 1,
            UpdatedAt = DateTime.Now
         };
      }

      public Task<IEnumerable<Payroll>> GetPayrollsAsync() {
         throw new NotImplementedException();
      }

      public async Task<bool> PostPayrollRange(List<PayrollDTO> listPayrolls) {
         foreach(Payroll payroll in listPayrolls.ConvertToModel()) {
            Payroll? py = await _dbContext.Payrolls.Where(p => p.NIK == payroll.NIK && p.Bulan == payroll.Bulan && p.Tahun == payroll.Tahun).FirstOrDefaultAsync();

            if (py == null) {
               await _dbContext.Payrolls.AddAsync(payroll);
               await _dbContext.SaveChangesAsync();
            }
            else {
               int totalMasuk = py.TotalMasuk + payroll.TotalMasuk;
               decimal upahHarian = Math.Round((decimal)py.Upah / 21, 2);
               decimal gaji = Math.Round((decimal)(upahHarian * totalMasuk) + py.TotalLembur, 2);
               py.TotalMasuk = totalMasuk;
               py.Gaji = gaji;
               py.UpdatedAt = DateTime.Now;
               _dbContext.Payrolls.Update(py);
               await _dbContext.SaveChangesAsync();
            }
         }
         return true;
      }
   }
}
