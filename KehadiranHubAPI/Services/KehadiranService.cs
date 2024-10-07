using KehadiranHubAPI.Data;
using KehadiranHubAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace KehadiranHubAPI.Services {
   public class KehadiranService : IKehadiranService {
      private readonly KehadiranHubDbContext dbcontext;

      public KehadiranService(KehadiranHubDbContext _dbcontext) {
         dbcontext = _dbcontext;
      }

      public async Task<int[]> GetKehadiran() {
         //var kehadiran = await dbcontext.Kehadirans.Where(k => k.Tanggal.Value.Date == DateTime.Now.Date).ToListAsync();

         //int tepatWaktu = kehadiran.Count(k => k.JamMasuk <= k.JadwalMasuk);
         //int terlambat = kehadiran.Count(k => k.JamMasuk > k.JadwalMasuk);

         TimeSpan? selisih = new TimeSpan(0, 1, 59);

         int tepatWaktu = dbcontext.JadwalKehadirans.Where(jk => jk.JadwalMasuk!.Value >= jk.JamMasuk!.Value && jk.JadwalMasuk!.Value.Date == DateTime.Now.Date).Count();

         var hadir = await dbcontext.JadwalKehadirans.Where(k => k.JamMasuk!.Value.Date == DateTime.Now.Date).ToListAsync();

         //int terlambat = dbcontext.Kehadirans.Where(k => k.Tanggal.Value.Date == DateTime.Now.Date && k.JamMasuk-k.JadwalMasuk >= selisih).ToList().Count();

         int terlambat = hadir.Where(h => h.JamMasuk - h.JadwalMasuk >= selisih).ToList().Count();

         int[] arrKehadiran = new int[] { tepatWaktu, terlambat };

         //var result = hadir.Where(h => h.JamMasuk - h.JadwalMasuk >= selisih).OrderByDescending(h => h.JamMasuk).Take(5).ToList();

         return arrKehadiran;
      }

      public async Task<List<JadwalKehadiran>> GetTop10KaryawanRajin() {
         var result = await dbcontext.JadwalKehadirans.Where(k => k.JamMasuk!.Value <= k.JadwalMasuk!.Value && k.JadwalMasuk!.Value.Date == DateTime.Now.Date).OrderBy(k => k.JamMasuk!.Value).Take(10).ToListAsync();

         return result;
      }

      public async Task<List<JadwalKehadiran>> GetKaryawanTerlambat() {
         var result = await dbcontext.JadwalKehadirans.Where(k => k.JamMasuk!.Value > k.JadwalMasuk!.Value && k.AlasanTerlambat == null && k.JadwalMasuk!.Value.Date == DateTime.Now.Date).OrderByDescending(k => k.JamMasuk).Take(10).ToListAsync();

         return result;
      }

      public async Task<List<JadwalKehadiran>> GetTop5KaryawanRajin() {
         TimeSpan? selisih = new TimeSpan(1, 1, 0);

         //var result = await dbcontext.Kehadirans.Where(k => k.Tanggal.Value.Date == DateTime.Now.Date && EF.Functions.DateDiffSecond(k.JadwalMasuk,k.JamMasuk).Value <= 3600).OrderBy(k => k.JamMasuk).Take(5).ToListAsync();
         
         List<JadwalKehadiran> hadir = await dbcontext.JadwalKehadirans.Where(k => k.JamMasuk!.Value.Date == DateTime.Now.Date).ToListAsync();

         var result = hadir.Where(h => h.JadwalMasuk - h.JamMasuk <= selisih).Take(5).ToList();

         return result;
      }

      public async Task<List<JadwalKehadiran>> GetTop5KaryawanTerlambat() {
         TimeSpan? selisih = new TimeSpan(0, 1, 59);

         List<JadwalKehadiran> hadir = await dbcontext.JadwalKehadirans.Where(k => k.JamMasuk!.Value.Date == DateTime.Now.Date).ToListAsync();

         //var result = await dbcontext.Kehadirans.Where(k => k.Tanggal.Value.Date == DateTime.Now.Date && k.JamMasuk > k.JadwalMasuk && k.AlasanTerlambat == null).OrderByDescending(k => k.JamMasuk).Take(5).ToListAsync();
         var result = hadir.Where(h => h.JamMasuk - h.JadwalMasuk >= selisih).OrderByDescending(h => h.JamMasuk).Take(5).ToList();

         return result;
      }

      public async Task<int[]> GetEmployessByGender() {
         int femaleEmp = await dbcontext.JadwalKehadirans.Where(k => k.JamMasuk!.Value == DateTime.Now.Date && k.Gender == false).CountAsync();

         int maleEmp = await dbcontext.JadwalKehadirans.Where(k => k.JamMasuk!.Value == DateTime.Now.Date && k.Gender == true).CountAsync();

         int[] arrEmpGender = new int[] { femaleEmp, maleEmp };

         return arrEmpGender;
      }
   }
}
