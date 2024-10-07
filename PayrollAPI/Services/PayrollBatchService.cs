using MassTransit;
using Microsoft.EntityFrameworkCore;
using PayrollAPI.Data;
using PayrollAPI.Model;
using SKM.Shared.Dtos;
using SKM.Shared.Models;
using System.Text;

namespace PayrollAPI.Services {
   public class PayrollBatchService : IPayrollBatchService, IConsumer<Batch<GajiDanTunjanganCreated>> {
      private readonly DbContextClass _dbContextClass;

      public PayrollBatchService(DbContextClass dbContextClass)
      {
         _dbContextClass = dbContextClass;
      }
      public async Task Consume(ConsumeContext<Batch<GajiDanTunjanganCreated>> context) {
         //throw new NotImplementedException();
         List<GajiDanTunjanganCreated> msgData = new();
         for (int i=0; i < context.Message.Length; i++) {
            //builder.Append(context.Message[i].Message);
            ConsumeContext<GajiDanTunjanganCreated> msg = context.Message[i];
            msgData.Add(new GajiDanTunjanganCreated {
               Id = msg.Message.Id,
               GroupId = msg.Message.GroupId,
               GrupKerja = msg.Message.GrupKerja,
               NIK = msg.Message.NIK,
               NamaKaryawan = msg.Message.NamaKaryawan,
               Upah = msg.Message.Upah,
               PTKP = msg.Message.PTKP,
               PTKP_Jumlah = msg.Message.PTKP_Jumlah,
               TunjJabatan = msg.Message.TunjJabatan,
               TunjKeterampilan = msg.Message.TunjKeterampilan,
               TunjMasaKerja = msg.Message.TunjMasaKerja,
               TunjLain = msg.Message.TunjLain,
               PotonganKoperasi = msg.Message.PotonganKoperasi,
               PotonganLain = msg.Message.PotonganLain,
               Potong_BPJSTK = msg.Message.Potong_BPJSTK,
               Potong_BPJSKes = msg.Message.Potong_BPJSKes,
               BPJS_Ortu1 = msg.Message.BPJS_Ortu1,
               BPJS_Ortu2 = msg.Message.BPJS_Ortu2,
               BPJS_Ortu3 = msg.Message.BPJS_Ortu3,
               BPJS_Ortu4 = msg.Message.BPJS_Ortu4,
               EmployeeId = msg.Message.EmployeeId,
               DepartmentId = msg.Message.DepartmentId,
               DepartmentName = msg.Message.DepartmentName
            });
         }

         //Console.WriteLine(msgData);
         List<Payroll> payrolls = new();
         foreach(var m in msgData) {
            payrolls.Add(new Payroll {
               Bulan = 0,
               Tahun = 0,
               IdEmployee = m.EmployeeId,
               EmployeeName = m.NamaKaryawan,
               GroupName = m.GrupKerja,
               DepartmentName = m.DepartmentName,
               Upah = m.Upah,
               TotalMasuk = 0,
               TotalLembur = 0,
               Gaji = 0,
               CreatedAt = DateTime.Now,
               CreatedBy = 1,
               UpdatedAt = DateTime.Now,
               UpdatedBy = 1,
            });
         }
         _dbContextClass.Payrolls.AddRange(payrolls);
         await _dbContextClass.SaveChangesAsync();

         //return Task.CompletedTask;
         //var data = builder.ToString();
         //Console.WriteLine(data);
         //return Task.FromResult(builder.ToString());
      }

      public async Task<IEnumerable<Payroll>> GetPayrollBatchAsync() {
         //throw new NotImplementedException();
         return await _dbContextClass.Payrolls.ToListAsync();
      }
   }
}
