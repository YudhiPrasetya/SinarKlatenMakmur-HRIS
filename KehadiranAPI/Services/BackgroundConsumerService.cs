using KehadiranAPI.Data;
using KehadiranAPI.Model;
using KehadiranAPI.RabbitMQ;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Text;

namespace KehadiranAPI.Services {
   public class BackgroundConsumerService : BackgroundService {
      private readonly IServiceScopeFactory factory;
      private readonly MQConsumer consumer;
      //private readonly DbContextKehadiran dbContextKehadiran;
      //private readonly IJadwalKehadiranService jadwalKehadiranService;
      
      public BackgroundConsumerService(IServiceScopeFactory factory, MQConsumer consumer) {
         this.factory = factory;
         this.consumer = consumer;
      }
      protected override Task ExecuteAsync(CancellationToken stoppingToken) {
         this.consumer.AddListener("absenRealTime", async(_, args) => {
            using (var scope = this.factory.CreateScope()) {
               var dbContextKehadiran = scope.ServiceProvider.GetService<DbContextKehadiran>();
               var body = args.Body.ToArray();
               var json = Encoding.UTF8.GetString(body);
               var dataAbsenRealTime = JsonConvert.DeserializeObject<AbsenRealTimeDTO>(json);

               JadwalKehadiran? jadwalMasuk = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == dataAbsenRealTime!.NIK && j.JadwalMasuk!.Value.Date == dataAbsenRealTime.Tanggal.Date && j.LockedMasuk == false).FirstOrDefaultAsync();
               if (jadwalMasuk != null) {
                  if (jadwalMasuk.JadwalMasuk!.Value.TimeOfDay > dataAbsenRealTime!.Tanggal.TimeOfDay || dataAbsenRealTime.Tanggal.TimeOfDay.Subtract(jadwalMasuk.JadwalMasuk!.Value.TimeOfDay).TotalMinutes <= 4 * 60) {
                     jadwalMasuk.JamMasuk = dataAbsenRealTime.Tanggal;
                     jadwalMasuk.LockedMasuk = true;
                     jadwalMasuk.Keterangan = jadwalMasuk.JadwalMasuk!.Value.TimeOfDay >= dataAbsenRealTime.Tanggal.TimeOfDay ? "Tepat Waktu" : "Terlambat";
                     jadwalMasuk.Terlambat = jadwalMasuk.JadwalMasuk!.Value.TimeOfDay >= dataAbsenRealTime.Tanggal.TimeOfDay ? TimeSpan.Parse("00:00:00") : dataAbsenRealTime.Tanggal.TimeOfDay.Subtract(jadwalMasuk.JadwalMasuk!.Value.TimeOfDay);
                     jadwalMasuk.Up = true;

                     dbContextKehadiran.JadwalKehadirans.Update(jadwalMasuk);
                     await dbContextKehadiran.SaveChangesAsync();
                  }
                  else if (dataAbsenRealTime.Tanggal.TimeOfDay.Subtract(jadwalMasuk.JadwalMasuk!.Value.TimeOfDay).TotalMinutes >= 8 * 60) {
                     jadwalMasuk!.JamPulang = dataAbsenRealTime.Tanggal;
                     jadwalMasuk!.LockedPulang = true;
                     dbContextKehadiran.JadwalKehadirans.Update(jadwalMasuk);
                     await dbContextKehadiran.SaveChangesAsync();
                  }
               }
               else {
                  JadwalKehadiran? jadwalPulang = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == dataAbsenRealTime!.NIK && j.JadwalPulang!.Value.Date == dataAbsenRealTime.Tanggal.Date && j.LockedPulang == false).FirstOrDefaultAsync();
                  if (jadwalPulang != null) {
                     jadwalPulang!.JamPulang = dataAbsenRealTime!.Tanggal;
                     jadwalPulang!.LockedPulang = true;
                     dbContextKehadiran.JadwalKehadirans.Update(jadwalPulang);
                     await dbContextKehadiran.SaveChangesAsync();
                  }
               }
            //JadwalKehadiran? cariJadwalKemarin = await dbContextKehadiran!.JadwalKehadirans.Where(j => j.NIK == dataAbsenRealTime!.NIK && j.JadwalMasuk!.Value.Date == dataAbsenRealTime.Tanggal.Date.AddDays(-1) && j.JamMasuk != null && j.JamPulang == null && j.LockedPulang == false).FirstOrDefaultAsync();
            //if (cariJadwalKemarin != null) {
            //   cariJadwalKemarin.JamPulang = dataAbsenRealTime!.Tanggal;
            //   cariJadwalKemarin.LockedPulang = true;
            //   dbContextKehadiran.JadwalKehadirans.Update(cariJadwalKemarin);
            //   await dbContextKehadiran.SaveChangesAsync();
            //}
            //else {
            //   JadwalKehadiran? cariJadwalHariIni = await dbContextKehadiran.JadwalKehadirans.Where(j => j.NIK == dataAbsenRealTime!.NIK && j.JadwalMasuk!.Value.Date == dataAbsenRealTime.Tanggal.Date && j.LockedPulang == false).FirstOrDefaultAsync();
            //   if (cariJadwalHariIni != null) {
            //      TimeSpan selisih = dataAbsenRealTime!.Tanggal.TimeOfDay.Subtract(cariJadwalHariIni.JadwalMasuk!.Value.TimeOfDay);
            //      if (cariJadwalHariIni.JamMasuk != null && dataAbsenRealTime!.Tanggal.TimeOfDay.Subtract(cariJadwalHariIni.JadwalMasuk!.Value.TimeOfDay).TotalMinutes >= 8 * 60 && cariJadwalHariIni.LockedPulang == false) {
            //         cariJadwalHariIni.JamPulang = dataAbsenRealTime!.Tanggal;
            //         cariJadwalHariIni.LockedPulang = true;
            //         dbContextKehadiran.JadwalKehadirans.Update(cariJadwalHariIni);
            //         await dbContextKehadiran.SaveChangesAsync();
            //      }
            //      else {
            //         if(cariJadwalHariIni.JadwalMasuk!.Value.Subtract(dataAbsenRealTime!.Tanggal).TotalMinutes <= 4 * 60 && cariJadwalHariIni.LockedMasuk == false) {
            //            cariJadwalHariIni.JamMasuk = dataAbsenRealTime!.Tanggal;
            //            cariJadwalHariIni.Status = (cariJadwalHariIni.JadwalMasuk!.Value.TimeOfDay < dataAbsenRealTime.Tanggal.TimeOfDay ? "Terlambat" : "Tepat Waktu");
            //            cariJadwalHariIni.Terlambat = (dataAbsenRealTime.Tanggal.TimeOfDay > cariJadwalHariIni.JadwalMasuk.Value.TimeOfDay ? dataAbsenRealTime.Tanggal.TimeOfDay.Subtract(cariJadwalHariIni.JadwalMasuk.Value.TimeOfDay) : TimeSpan.Parse("00:00:00"));
            //            cariJadwalHariIni.LockedMasuk = true;
            //            cariJadwalHariIni.Up = true;
            //            dbContextKehadiran.JadwalKehadirans.Update(cariJadwalHariIni);
            //            await dbContextKehadiran.SaveChangesAsync();
            //         }
            //      }
            //   }
            //}
         }
         });
         return Task.CompletedTask;
      }
   }
}
