using KehadiranAPI.Conversions;
using KehadiranAPI.Data;
using KehadiranAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Text.Json.Serialization;

namespace KehadiranAPI.Services {
   public class KehadiranService : IKehadiranServices {
      private readonly DbContextKehadiran dbContextKehadiran;

      public KehadiranService(DbContextKehadiran dbContextKehadiran)
      {
         this.dbContextKehadiran = dbContextKehadiran;
      }

		public async Task<Kehadiran> AbsenPulang(KehadiranDTO kehadiranDTO) {
         //throw new NotImplementedException();
         string nik = kehadiranDTO.NIK;
         DateTime Tgl = kehadiranDTO.Tanggal.Value.Date;
         var hadir = await this.dbContextKehadiran.Kehadirans.SingleOrDefaultAsync(h => h.NIK == nik && h.Tanggal.Value.Date == Tgl.Date);

         EntityEntry h;
         if (hadir != null && hadir.JamPulang.Value == null) {
            hadir.JamPulang = kehadiranDTO.JamPulang.Value;
            h = this.dbContextKehadiran.Kehadirans.Update(hadir);
         }
         else {
            h = await this.dbContextKehadiran.Kehadirans.AddAsync(kehadiranDTO.ConvertToModel());
         }
         await this.dbContextKehadiran.SaveChangesAsync();
         return (Kehadiran)h.Entity;
         //var hadir = this.dbContextKehadiran.Kehadirans.Update(kehadiranDTO.ConvertToModel());
         //await this.dbContextKehadiran.SaveChangesAsync();

         //return hadir.Entity;
		}

      private async Task<Kehadiran?> CariAbsenMasukHariIni(string? nik) {
         Kehadiran? hadir = await dbContextKehadiran.Kehadirans.Where(k => k.NIK == nik && k.Tanggal!.Value.Date == DateTime.Now.Date).FirstOrDefaultAsync();

         return hadir;
      }

      private async Task<Kehadiran?> CariAbsenMasukKamarin(string? nik) {
         Kehadiran? hadir = await dbContextKehadiran.Kehadirans.Where(k => k.NIK == nik && k.Tanggal!.Value.Date == DateTime.Now.AddDays(-1).Date && k.JamPulang == null).FirstOrDefaultAsync();

         return hadir;
      }

      private async Task<Kehadiran?> CariKehadiran(string? nik) {
         Kehadiran? kehadiran = await dbContextKehadiran.Kehadirans.Where(k => k.NIK == nik && (k.Tanggal!.Value.Date == DateTime.Now.Date || k.Tanggal!.Value.Date == DateTime.Now.AddDays(-1).Date)).FirstOrDefaultAsync();

         return kehadiran;
      }

		public async Task<Kehadiran?> Absen(KehadiranDTO kehadiranDTO) {
         TimeSpan? jamSekarang = DateTime.Now.TimeOfDay;

         //Kehadiran? kehadiran = await dbContextKehadiran.Kehadirans.FirstOrDefaultAsync(k => k.NIK == kehadiranDTO.NIK && k.Tanggal.Value.Date == DateTime.Now.Date || (k.NIK == kehadiranDTO.NIK && k.Tanggal.Value.Date == DateTime.Now.AddDays(-1).Date && k.JamPulang == null));

         //var absenMasukHariIniTask = CariAbsenMasukHariIni(kehadiranDTO.NIK);
         //var absenMasukKemarinTask = CariAbsenMasukKamarin(kehadiranDTO.NIK);

         //await Task.WhenAll(absenMasukHariIniTask, absenMasukKemarinTask);

         //var absenMasukHariIniTaskResult = await absenMasukHariIniTask;
         //var absenMasukKemarinTaskResult = await absenMasukKemarinTask;

         //EntityEntry<Kehadiran> hadir;

         //Console.WriteLine($"absenMasukHariIniTaskResult.IsNull: {absenMasukHariIniTaskResult == null}");
         //Console.WriteLine($"absenMasukKemarinTaskResult.IsNull: {absenMasukKemarinTaskResult == null}");

         //jika masukhariini dan masuk kemarin null
         //if(absenMasukHariIniTaskResult == null && absenMasukKemarinTaskResult == null) {
         //   //maka absen masuk
         //   hadir = await dbContextKehadiran.Kehadirans.AddAsync(kehadiranDTO.ConvertToModel());
         //   await dbContextKehadiran.SaveChangesAsync();
         //   return hadir.Entity;
         //}

         ////jika masukhariini atau masuk kemarin tidak null
         //if (absenMasukHariIniTaskResult != null || absenMasukKemarinTaskResult != null) {
         //   if (jamSekarang.Value >= kehadiranDTO.JadwalPulang || jamSekarang.Value.Subtract(kehadiranDTO.JamMasuk.Value).TotalMinutes >= 480) {
         //      kehadiranDTO.JamPulang = jamSekarang.Value;

         //      hadir = dbContextKehadiran.Kehadirans.Update(kehadiranDTO.ConvertToModel());
         //      await dbContextKehadiran.SaveChangesAsync();
         //      return hadir.Entity;
         //   }
         //}

         Kehadiran? cariHadir = await CariKehadiran(kehadiranDTO.NIK);
         if(cariHadir == null) {
            var hadir = await dbContextKehadiran.Kehadirans.AddAsync(kehadiranDTO.ConvertToModel());
            await dbContextKehadiran.SaveChangesAsync();
            return hadir.Entity;
         }
         else {
            if(jamSekarang.Value.Subtract(kehadiranDTO.JamMasuk!.Value).TotalMinutes >= 480) {
               //kehadiranDTO.JamPulang = jamSekarang.Value;
               cariHadir.JamPulang = jamSekarang.Value;

               var hadir = dbContextKehadiran.Kehadirans.Update(cariHadir);
               await dbContextKehadiran.SaveChangesAsync();
               return hadir.Entity;
            }
         }

         return default;

     //    Kehadiran? kehadiran = await dbContextKehadiran.Kehadirans.FirstOrDefaultAsync(k => k.NIK == kehadiranDTO.NIK && k.Tanggal.Value.Date == DateTime.Now.Date);
     //    if (kehadiran == null) {
     //       //absen Masuk
     //       if (jamSekarang.Value <= kehadiranDTO?.JadwalMasuk) {
					//kehadiranDTO.Keterangan = "Tepat Waktu";
     //       } else if (jamSekarang.Value >= kehadiranDTO?.JadwalMasuk && (jamSekarang.Value <= kehadiranDTO.JadwalMasuk.Value.Add(TimeSpan.FromMinutes(60)))) {
					//kehadiranDTO.Keterangan = "Terlambat";
     //          kehadiranDTO.Terlambat = jamSekarang.Value - kehadiranDTO.JadwalMasuk.Value;
     //       }else if(jamSekarang.Value >= kehadiranDTO?.JadwalMasuk && (jamSekarang.Value <= kehadiranDTO.JadwalMasuk.Value.Add(TimeSpan.FromMinutes(125)))) {
					//kehadiranDTO.Keterangan = "Sangat Terlambat!";
     //          kehadiranDTO.Terlambat = jamSekarang.Value - kehadiranDTO.JadwalMasuk;
     //       }else if(jamSekarang.Value > kehadiranDTO?.JadwalMasuk && (jamSekarang.Value > kehadiranDTO.JadwalMasuk.Value.Add(TimeSpan.FromMinutes(125)))) {
					//kehadiranDTO.Keterangan = "Sangat Terlambat Sekali!!";
     //          kehadiranDTO.Terlambat = jamSekarang.Value - kehadiranDTO.JadwalMasuk;
     //       }
     //       var hdr = await dbContextKehadiran.Kehadirans.AddAsync(kehadiranDTO.ConvertToModel());
     //       await dbContextKehadiran.SaveChangesAsync();
     //       return hdr.Entity;
     //    }
     //    else {
     //       //absen pulang
     //       if(jamSekarang.Value >= kehadiran.JadwalPulang || jamSekarang.Value.Subtract(kehadiran.JamMasuk.Value).TotalMinutes >= 480 || kehadiran.AlasanTerlambat != null) {
     //          kehadiran.JamPulang = jamSekarang.Value;

     //          dbContextKehadiran.Update(kehadiran);
     //          await dbContextKehadiran.SaveChangesAsync();

     //       }
     //    }

     //    return null;
      }

      public async Task<List<Kehadiran>?> GetAllAsync() {
         //throw new NotImplementedException();
         return await this.dbContextKehadiran.Kehadirans.ToListAsync();
      }

      public async Task<List<Kehadiran>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         string strGroup = (group != "All" ? group.Replace("-", "/").Replace("_", " ") : group);
         //string strGroup = group.Replace("-", "/").Replace("_", " ");
         DateTime tgl1 = DateConversions.StringToDate(startDate);
         DateTime tgl2 = DateConversions.StringToDate(endDate);

         if (strGroup == "All") {
            return await this.dbContextKehadiran.Kehadirans.Where(k => k.Tanggal.Value.Date >= tgl1.Date && k.Tanggal.Value.Date <= tgl2.Date).ToListAsync();
         }
         else {
            return await this.dbContextKehadiran.Kehadirans.Where(k => k.GrupKerja == strGroup && k.Tanggal.Value.Date >= tgl1.Date && k.Tanggal.Value.Date <= tgl2.Date).ToListAsync();
         }

      }

      public async Task<Kehadiran?> GetByNIKAndDate(string nik, string strDate) {
         //throw new NotImplementedException();
         var tgl = DateConversions.StringToDate(strDate);
         return await this.dbContextKehadiran.Kehadirans.Where(k => k.NIK == nik && k.Tanggal.Value.Date == tgl.Date).FirstOrDefaultAsync();
      }

		public async Task<List<Kehadiran>?> GetByRangeDate(string? dateStart, string? dateEnd) {
         //throw new NotImplementedException();
         var startDate = DateConversions.StringToDate(dateStart!);
         var endDate = DateConversions.StringToDate(dateEnd!);

         return await this.dbContextKehadiran.Kehadirans.Where(m => m.Tanggal.Value.Date >= startDate.Date && m.Tanggal.Value.Date <= endDate.Date).ToListAsync();
		}

      public async Task<int> TambahIjin(List<JadwalKehadiran> list) {
         //throw new NotImplementedException();
         foreach(JadwalKehadiran jadwalKehadiran in list) {
            JadwalKehadiran? jadwalWillUpdate = await dbContextKehadiran.JadwalKehadirans.Where(j => j.NIK == jadwalKehadiran.NIK && j.JadwalMasuk == jadwalKehadiran.JadwalMasuk).FirstOrDefaultAsync();
            if(jadwalWillUpdate != null) {
               jadwalWillUpdate.Keterangan = jadwalKehadiran.Keterangan;
               jadwalWillUpdate.Up = true;
               dbContextKehadiran.JadwalKehadirans.Update(jadwalWillUpdate);
            }
         }
         //int Id =  dbContextKehadiran.AddRangeAsync(list).Id;
         var rst = await dbContextKehadiran.SaveChangesAsync();
         return rst;
      }

      public async Task<Kehadiran> UbahJam(KehadiranDTO kehadiranDTO) {
         var hadir = await this.dbContextKehadiran.Kehadirans.FindAsync(kehadiranDTO.Id);
         if(hadir != null) {
            //hadir.Id = kehadiranDTO.Id;
            //hadir.GrupKerja = kehadiranDTO.GrupKerja;
            //hadir.Tanggal = kehadiranDTO.Tanggal.Value.Date;
            //hadir.NIK = kehadiranDTO.NIK;
            //hadir.Nama = kehadiranDTO.Nama;
            //hadir.JadwalMasuk = kehadiranDTO.JadwalMasuk;
            hadir.JamMasuk = kehadiranDTO.JamMasuk;
            //hadir.JadwalPulang = kehadiranDTO.JadwalPulang;
            hadir.JamPulang = kehadiranDTO.JamPulang;
            //hadir.Terlambat = kehadiranDTO.Terlambat;
            //hadir.Keterangan = kehadiranDTO.Keterangan;

            var updatedHadir = this.dbContextKehadiran.Kehadirans.Update(hadir);
            await this.dbContextKehadiran.SaveChangesAsync();
            return updatedHadir.Entity;
         }
         return default;
		}

		public async Task<Kehadiran?> UpdateAbsenMasuk(KehadiranDTO kehadiranDTO) {
			//throw new NotImplementedException();

			Kehadiran kehadiran = await this.dbContextKehadiran.Kehadirans.Where(k => k.NIK == kehadiranDTO.NIK && k.Tanggal.Value == kehadiranDTO.Tanggal.Value).FirstOrDefaultAsync();
			if (kehadiran != null) {
            kehadiranDTO.Id = kehadiranDTO.Id;
				var hadir = dbContextKehadiran.Kehadirans.Update(kehadiranDTO.ConvertToModel());
				await dbContextKehadiran.SaveChangesAsync();
				return hadir.Entity;
			}

         return default;
		}

      public async Task<int[]> GetKehadiran() {
         var kehadiran = await dbContextKehadiran.Kehadirans.Where(k => k.Tanggal.Value.Date == DateTime.Now.Date).ToListAsync();

         int tepatWaktu = kehadiran.Count(k => k.JamMasuk <= k.JadwalMasuk);
         int terlambat = kehadiran.Count(k => k.JamMasuk > k.JadwalMasuk && k.AlasanTerlambat.IsNullOrEmpty());

         int[] arrKehadiran = new int[] { tepatWaktu, terlambat };

         return arrKehadiran;
      }

      public async Task<List<JadwalKehadiran>> GetTerlambat(string startDate, string endDate) {
         DateTime sDate = DateConversions.StringToDate(startDate);
         DateTime eDate = DateConversions.StringToDate(endDate);

         return await this.dbContextKehadiran.JadwalKehadirans.Where(k => k.JadwalMasuk!.Value.Date >= sDate.Date && k.JadwalMasuk!.Value.Date <= eDate.Date && k.JamMasuk > k.JadwalMasuk).OrderByDescending(k => k.JadwalMasuk).ToListAsync();
      }

      public async Task<JadwalKehadiran> AddKeterlambatan(JadwalKehadiranDTO terlambat) {
         var ent = await this.dbContextKehadiran.JadwalKehadirans.AddAsync(terlambat.ConvertToModel());
         await this.dbContextKehadiran.SaveChangesAsync();

         return ent.Entity;
      }

      public async Task<JadwalKehadiran> UpdateKeterlambatan(JadwalKehadiranDTO terlambat) {
         var ent = this.dbContextKehadiran.JadwalKehadirans.Update(terlambat.ConvertToModel());
         await this.dbContextKehadiran.SaveChangesAsync();

         return ent.Entity;
      }

      public async Task<int[]> CountEmpByGender() {
         int empPria = 0;
         int empWanita = 0;
         int[] arrEmpGender;

         //var rst = await dbContextKehadiran.Kehadirans.Where(k => k.Tanggal.Value.Date == DateTime.Now.Date).ToListAsync();

         empPria = await dbContextKehadiran.Kehadirans.Where(k => k.Tanggal.Value.Date == DateTime.Now.Date && k.Gender == true).CountAsync();

         Console.WriteLine($"empPria: {empPria}");
         Console.WriteLine($"empWanita: {empWanita}");

         empWanita = await dbContextKehadiran.Kehadirans.Where(k => k.Tanggal.Value.Date == DateTime.Now.Date && k.Gender == false).CountAsync();

         //empPria = rst.Count(k => k.Gender == true);
         //empWanita = rst.Count(k => k.Gender == false);

         arrEmpGender = new int[] { empPria, empWanita };

         return arrEmpGender;

      }
   }
}
