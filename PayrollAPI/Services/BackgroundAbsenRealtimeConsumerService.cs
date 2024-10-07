using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using PayrollAPI.Conversions;
using PayrollAPI.Data;
using PayrollAPI.RabbitMQConsumer;
using SKM.Shared.Dtos;
using System.Text;

namespace PayrollAPI.Services {
   public class BackgroundAbsenRealtimeConsumerService : BackgroundService {
      private readonly IServiceScopeFactory factory;
      private readonly AbsenRealtimeConsumer consumer;

      public BackgroundAbsenRealtimeConsumerService(IServiceScopeFactory factory, AbsenRealtimeConsumer consumer) {
         this.factory = factory;
         this.consumer = consumer;
      }

      protected override Task ExecuteAsync(CancellationToken stoppingToken) {
         this.consumer.AddListener("absenRealTimeToPayroll", async (_, args) => {
            using (var scope = this.factory.CreateScope()) {
               var dbContextPayroll = scope.ServiceProvider.GetService<DbContextClass>();
               var body = args.Body.ToArray();
               var json = Encoding.UTF8.GetString(body);
               var dataPayrol = JsonConvert.DeserializeObject<PayrollDTO>(json);
               Console.WriteLine($"dataPayroll.Id: {dataPayrol.Id}");
               Console.WriteLine($"dataPayroll.NIK: {dataPayrol.NIK}");
               Console.WriteLine($"dataPayroll.Upah: {dataPayrol.Upah}");
               Console.WriteLine($"dataPayroll.Tgl: {dataPayrol.Tgl}");
               Console.WriteLine($"dataPayroll.GroupName: {dataPayrol.GroupName}");
               Console.WriteLine($"dataPayroll.Bulan: {dataPayrol.Bulan}");
               Console.WriteLine($"dataPayroll.Tahun: {dataPayrol.Tahun}");
               Console.WriteLine($"dataPayroll.Gaji: {dataPayrol.Gaji}");
               Console.WriteLine($"dataPayroll.EmployeeName: {dataPayrol.EmployeeName}");
               Console.WriteLine($"dataPayroll.DepartmentName: {dataPayrol.DepartmentName}");
               Console.WriteLine($"dataPayroll.TotalMasuk: {dataPayrol.TotalMasuk}");
               Console.WriteLine($"dataPayroll.TotalLembur: {dataPayrol.TotalLembur}");
               var payroll = await dbContextPayroll!.Payrolls.Where(p => p.NIK == dataPayrol!.NIK && p.Bulan == dataPayrol.Bulan && p.Tahun == dataPayrol.Tahun).FirstOrDefaultAsync();

               if (payroll == null) {
                  var p = await dbContextPayroll.Payrolls.AddAsync(dataPayrol.ConvertToModel());
                  await dbContextPayroll.SaveChangesAsync();
               }
               else {
                  if(payroll.Tgl?.Date != DateTime.Now.Date) {
                     int totalMasuk = payroll.TotalMasuk + dataPayrol!.TotalMasuk;
                     decimal upahHarian = Math.Round((decimal)payroll.Upah / 21, 2);
                     decimal gaji = Math.Round((decimal)(upahHarian * totalMasuk) + payroll.TotalLembur, 2);
                     payroll.Tgl = DateTime.Now;
                     payroll.TotalMasuk = totalMasuk;
                     payroll.Gaji = gaji;
                     payroll.UpdatedAt = DateTime.Now;
                     var p = dbContextPayroll.Payrolls.Update(payroll);
                     await dbContextPayroll.SaveChangesAsync();
                  }
               }
            }
         });
         return Task.CompletedTask;
      }
   }
}
