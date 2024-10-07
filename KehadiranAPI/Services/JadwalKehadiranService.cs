using DocumentFormat.OpenXml.Bibliography;
using KehadiranAPI.Conversions;
using KehadiranAPI.Data;
using KehadiranAPI.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.ComponentModel;
using System.Globalization;

namespace KehadiranAPI.Services {
   public class JadwalKehadiranService : IJadwalKehadiranService {
      private readonly DbContextKehadiran dbContextKehadiran;

      public JadwalKehadiranService(DbContextKehadiran dbContextKehadiran) {
         this.dbContextKehadiran = dbContextKehadiran;
      }
      public async Task<JadwalKehadiranDTO?> AddJadwalKehadiranRange(List<JadwalKehadiranDTO> jadwalDTOs) {
         await dbContextKehadiran.JadwalKehadirans.AddRangeAsync(jadwalDTOs.ConvertToModel());
         await dbContextKehadiran.SaveChangesAsync();
         return default;
      }

      public async Task<List<JadwalKehadiranDTO>?> GetByGroupAndRangePeriode(string group, int month, int year) {
         string g = group.Replace("_", " ").Replace("-", "/");
         var rst = await dbContextKehadiran.JadwalKehadirans.Where(k => k.GrupKerja == g && k.JadwalMasuk!.Value.Month == month && k.JadwalMasuk.Value.Year == year).ToListAsync();
         return rst?.ConvertToDTO();
      }

      public async Task<JadwalKehadiranDTO?> GetByNIKAndDate(string nik, string strDate) {
         DateTime date = DateConversions.StringToDate(strDate);
         var result = await dbContextKehadiran.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date == date).FirstOrDefaultAsync();

         return result?.ConvertToDTO();
      }

      public async Task<List<JadwalKehadiranDTO>?> GetJadwalKehadiran() {
         var result = await dbContextKehadiran.JadwalKehadirans.Where(k => k.JadwalMasuk!.Value.Month == DateTime.Now.Month && k.JadwalMasuk!.Value.Year == DateTime.Now.Year).ToListAsync();

         return result.ConvertToDTO();
		}

		public async Task<JadwalKehadiranDTO?> Update(JadwalKehadiranDTO jadwalKehadiranDTO) {
         var rst = dbContextKehadiran.JadwalKehadirans.Update(jadwalKehadiranDTO.ConvertToModel());
         await dbContextKehadiran.SaveChangesAsync();

         return rst.Entity.ConvertToDTO();
		}

		public async Task<JadwalKehadiranDTO> UpdateJadwalKehadiran(JadwalKehadiranDTO jadwalKehadiran) {
         var result = dbContextKehadiran.JadwalKehadirans.Update(jadwalKehadiran.ConvertToModel());
         await dbContextKehadiran.SaveChangesAsync();

         return result.Entity.ConvertToDTO();
      }

      public async Task<JadwalKehadiranDTO?> UpdateJadwalKehadiranRange(List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         dbContextKehadiran.JadwalKehadirans.UpdateRange(jadwalKehadiranDTOs.ConvertToModel());
         //dbContextKehadiran.UpdateRange(jadwalKehadiranDTOs.ConvertToModel());
         await dbContextKehadiran.SaveChangesAsync();
         return default;
      }

      public async Task<JadwalKehadiranDTO?> UpdateJamMasukJamPulang(JadwalKehadiranDTO jadwalKehadiranDTO) {
         dbContextKehadiran.JadwalKehadirans.Update(jadwalKehadiranDTO.ConvertToModel());
         await dbContextKehadiran.SaveChangesAsync();
         return default;
      }

      public async Task<List<int>?> GetByNIKAndMonthYear(string nik, int year, int month) {
         var listJadwal = await dbContextKehadiran.JadwalKehadirans.Where(j => j.NIK == nik && j.JadwalMasuk!.Value.Date.Year == year && j.JadwalMasuk!.Value.Date.Month == month).ToListAsync();

         List<int> listTgl = new();
         if(listJadwal is not null) {
            for(int i = 0; i < listJadwal.Count; i++) {
               listTgl.Add(listJadwal[i].JadwalMasuk!.Value.Date.Day);
            }
            return listTgl;
         }

         return null;
      }

		public async Task<JadwalKehadiranDTO?> GetByNamaAndDate(string nama, string strDate) {
         DateTime dtDate = DateConversions.StringToDate(strDate);
			var rst = await dbContextKehadiran.JadwalKehadirans.Where(j => j.Nama == nama && j.JadwalMasuk!.Value.Date == dtDate).FirstOrDefaultAsync();
         return rst!.ConvertToDTO();
		}

		public async Task<List<JadwalKehadiranDTO>?> GetTerlambat(string startDate, string endDate) {
         var sDate = DateConversions.StringToDate(startDate);
         var eDate = DateConversions.StringToDate(endDate);

         List<JadwalKehadiran> rst  = await dbContextKehadiran.JadwalKehadirans.Where(jk => jk.JadwalMasuk!.Value.Date >= sDate && jk.JadwalMasuk!.Value.Date <= eDate.Date && jk.JadwalMasuk!.Value < jk.JamMasuk!.Value).ToListAsync();

         return rst?.ConvertToDTO();
		}

		public async Task<JadwalKehadiranDTO?> AddKeterlambatan(JadwalKehadiranDTO terlambat) {
         var rst = await dbContextKehadiran.JadwalKehadirans.AddAsync(terlambat.ConvertToModel());
         await dbContextKehadiran.SaveChangesAsync();

         return rst.Entity.ConvertToDTO();
		}

		public async Task<JadwalKehadiranDTO?> UpdateKeterlambatan(JadwalKehadiranDTO terlambat) {
         var rst = dbContextKehadiran.JadwalKehadirans.Update(terlambat.ConvertToModel());
         await dbContextKehadiran.SaveChangesAsync();

         return rst.Entity.ConvertToDTO();
		}

		public async Task<JadwalKehadiranDTO?> PatchKeterlambatan(int id, JadwalKehadiranDTO dataTerlambat) {
         JadwalKehadiran? terlambat = await dbContextKehadiran.JadwalKehadirans.FindAsync(id);
         JsonPatchDocument<JadwalKehadiran> terlambatPatchDocument = new();
         terlambatPatchDocument.Replace(t => t.JamMasuk, dataTerlambat.JamMasuk);
         terlambatPatchDocument.Replace(t => t.AlasanTerlambat, dataTerlambat.AlasanTerlambat);
         terlambatPatchDocument.Replace(t => t.LockedMasuk, dataTerlambat.LockedMasuk);

         terlambatPatchDocument.ApplyTo(terlambat!);
         await dbContextKehadiran.SaveChangesAsync();
         return default;
		}

      public async Task<List<JadwalKehadiranDTO>?> PatchMultiKeterlambatan(List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         List<JadwalKehadiran> jadwalKehadirans = jadwalKehadiranDTOs.ConvertToModel();

         foreach(JadwalKehadiran jk in jadwalKehadirans) {
            JadwalKehadiran? dataTerlambat = await dbContextKehadiran.JadwalKehadirans.Where(j => j.NIK == jk.NIK && j.JadwalMasuk!.Value.Date == jk.JadwalMasuk!.Value.Date).FirstOrDefaultAsync();
            if(dataTerlambat != null) {
               JsonPatchDocument<JadwalKehadiran> terlambatPatchDocument = new();
               terlambatPatchDocument.Replace(t => t.AlasanTerlambat, jk.AlasanTerlambat);
               //terlambatPatchDocument.Replace(t => t.JamMasuk!.Value, dataTerlambat.JadwalMasuk!.Value.AddMinutes(-15));
               //terlambatPatchDocument.Replace(t => t.Up, true);
               terlambatPatchDocument.ApplyTo(dataTerlambat);
               await dbContextKehadiran.SaveChangesAsync();
            }
            return default;
         }
         return default;
      }

      public async Task<List<JadwalKehadiranDTO>?> GetByGroupAndDateRange(string group, string startDate, string endDate) {
         DateTime sDate = DateConversions.StringToDate(startDate);
         DateTime eDate = DateConversions.StringToDate(endDate);

         List<JadwalKehadiran>? jadwalKehadirans = await dbContextKehadiran.JadwalKehadirans.Where(j => j.GrupKerja == group && j.JadwalMasuk >= sDate && j.JadwalMasuk <= eDate).ToListAsync();
         return jadwalKehadirans.ConvertToDTO();
      }

      public async Task<List<JadwalKehadiranDTO>?> GetByDateRange(string startDate, string endDate) {
         DateTime sDate = DateConversions.StringToDate(startDate);
         DateTime eDate = DateConversions.StringToDate(endDate);

         List<JadwalKehadiran>? jadwalKehadirans = await dbContextKehadiran.JadwalKehadirans.Where(j => j.JadwalMasuk >= sDate && j.JadwalMasuk <= eDate).ToListAsync();
         return jadwalKehadirans.ConvertToDTO();
      }

		public async Task<JadwalKehadiranDTO?> UbahJam(JadwalKehadiranDTO jadwalKehadiranDTO) {
			var hadir = await this.dbContextKehadiran.JadwalKehadirans.FindAsync(jadwalKehadiranDTO.Id);
			if (hadir != null) {
				hadir.JamMasuk = jadwalKehadiranDTO.JadwalMasuk;
				hadir.JamPulang = jadwalKehadiranDTO.JadwalPulang;

				var updatedHadir = this.dbContextKehadiran.JadwalKehadirans.Update(hadir);
				await this.dbContextKehadiran.SaveChangesAsync();
				return updatedHadir.Entity.ConvertToDTO();
			}
			return default;
		}

		public async Task<List<JadwalKehadiranDTO>?> GetByPeriode(int bulan, int tahun) {
			var rst = await this.dbContextKehadiran.JadwalKehadirans.Where(j => j.JadwalMasuk!.Value.Date.Month == bulan && j.JadwalMasuk!.Value.Date.Year == tahun).ToListAsync();

         return rst.ConvertToDTO();
		}
	}
}
