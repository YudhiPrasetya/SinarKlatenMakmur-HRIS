using JadwalKerjaKaryawanAPI.Conversions;
using JadwalKerjaKaryawanAPI.Data;
using JadwalKerjaKaryawanAPI.Model;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace JadwalKerjaKaryawanAPI.Services {
   public class JadwalKerjaKaryawanService : IJadwalKerjaKaryawanService {
      private readonly JadwalKerjaKaryawanDbContext jadwalDbContext;

      public JadwalKerjaKaryawanService(JadwalKerjaKaryawanDbContext jadwalDbContext)
      {
         this.jadwalDbContext = jadwalDbContext;
      }
      public async Task<JadwalKerjaKaryawan> AddJadwalKerjaKaryawanRange(IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs) {
         //throw new NotImplementedException();
         await this.jadwalDbContext.JadwalKerjaKaryawans.AddRangeAsync(jadwalDTOs.ConvertToModel());
         await this.jadwalDbContext.SaveChangesAsync();
         return default;
      }

      public async Task<List<JadwalKerjaKaryawan>> GetByGroupName(string groupName) {
         //throw new NotImplementedException();
         string strGroupName = groupName.Replace("-", "/");
         return await this.jadwalDbContext.JadwalKerjaKaryawans.Where(j => j.GroupName == strGroupName).ToListAsync();
      }

      public async Task<JadwalKerjaKaryawan> GetById(int id) {
         //throw new NotImplementedException();
         return await this.jadwalDbContext.JadwalKerjaKaryawans.FindAsync(id);
      }

      public async Task<JadwalKerjaKaryawan> GetByNIK(string nik) {
         //throw new NotImplementedException();
         return await this.jadwalDbContext.JadwalKerjaKaryawans.Where(j => j.NIK == nik).FirstOrDefaultAsync();
		}

		public IEnumerable<JadwalKerjaKaryawan> GetJadwalKerjaKaryawansAsync() {
         //throw new NotImplementedException();
         //return this.jadwalDbContext.JadwalKerjaKaryawans.ToList().DistinctBy(j => j.GroupName);
         //return this.jadwalDbContext.JadwalKerjaKaryawans.OrderByDescending(j => j.Tgl.Value.Date).ToList();
         return this.jadwalDbContext.JadwalKerjaKaryawans.Where(j => j.Tgl.Value.Date.Month == DateTime.Now.Month && j.Tgl.Value.Date.Year == DateTime.Now.Year).ToList();         //return (IEnumerable<JadwalKerjaKaryawan>)this.jadwalDbContext.JadwalKerjaKaryawans.GroupBy(j => j.GroupName);
      }

		public async Task<JadwalKerjaKaryawan> UpdateJadwalKerja(JadwalKerjaKaryawanDTO jadwalKerjaKaryawanDTO) {
         //throw new NotImplementedException();
         //JadwalKerjaKaryawan jadwal = await this.jadwalDbContext.JadwalKerjaKaryawans.FindAsync(jadwalKerjaKaryawanDTO.Id);
         //jadwal.JamMasuk = jadwalKerjaKaryawanDTO.JamMasuk;
         //jadwal.JamPulang = jadwalKerjaKaryawanDTO.JamPulang;

         var jadwalUpdated = this.jadwalDbContext.JadwalKerjaKaryawans.Update(jadwalKerjaKaryawanDTO.ConvertToModel());

         await this.jadwalDbContext.SaveChangesAsync();

         return jadwalUpdated.Entity;
		}

		public async Task<JadwalKerjaKaryawan> UpdateJadwalKerjaKaryawanRange(IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs) {
         //throw new NotImplementedException();
         this.jadwalDbContext.JadwalKerjaKaryawans.UpdateRange(jadwalDTOs.ConvertToModel());
         await this.jadwalDbContext.SaveChangesAsync(true);
         return default;
      }

      public async Task<List<JadwalKerjaKaryawan>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         string strGroup = (group != "All" ? group.Replace("-", "/").Replace("_", " ") : group);
         //string strGroup = group.Replace("-", "/").Replace("_", " ");
         DateTime tgl1 = DateConversions.StringToDate(startDate);
         DateTime tgl2 = DateConversions.StringToDate(endDate);

         //return await jadwalDbContext.JadwalKerjaKaryawans.Where(j => j.GroupName == strGroup && j.Tgl.Value.Date >= tgl1.Date && j.Tgl.Value.Date <= tgl2.Date).ToListAsync();

         if (strGroup == "All") {
            return await jadwalDbContext.JadwalKerjaKaryawans.Where(j => j.Tgl.Value.Date >= tgl1.Date && j.Tgl.Value.Date <= tgl2.Date).ToListAsync();
         }
         else {
            return await jadwalDbContext.JadwalKerjaKaryawans.Where(j => j.GroupName == strGroup && j.Tgl.Value.Date >= tgl1.Date && j.Tgl.Value.Date <= tgl2.Date).ToListAsync();

         }
      }

      public async Task<JadwalKerjaKaryawan> DeleteJadwalKerjaKaryawanAsync(int id) {
         //throw new NotImplementedException();
         var jadwal = await jadwalDbContext.JadwalKerjaKaryawans.FindAsync(id);
         if (jadwal != null) {
            jadwalDbContext.JadwalKerjaKaryawans.Remove(jadwal);
            await jadwalDbContext.SaveChangesAsync();
         }

         return jadwal;
      }

		public async Task<JadwalKerjaKaryawan?> GetByNIKAndDate(string nik, DateTime date) {
         JadwalKerjaKaryawan? jadwal = await jadwalDbContext.JadwalKerjaKaryawans.SingleOrDefaultAsync(j => j.NIK == nik && j.Tgl.Value.Date == date.Date);

         return jadwal;
		}

      public async Task<List<JadwalKerjaKaryawan>>? GetByDate(DateTime date) {
         return await jadwalDbContext.JadwalKerjaKaryawans.Where(j => j.Tgl.Value.Date == date.Date ).ToListAsync();
      }
	}
}
