using KehadiranAPI.Conversions;
using KehadiranAPI.Data;
using KehadiranAPI.Model;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace KehadiranAPI.Services {
   public class AbsenPulangService : IAbsenPulangService {
      private readonly DbContextKehadiran dbContextKehadiran;

      public AbsenPulangService(DbContextKehadiran dbContextKehadiran)
      {
         this.dbContextKehadiran = dbContextKehadiran;
      }
      public async Task<AbsenPulang?> AddAbsenPulang(AbsenPulangDTO absenPulangDTO) {
      //throw new NotImplementedException();
      int Hari = absenPulangDTO.Tanggal.Day;
      int Bulan = absenPulangDTO.Tanggal.Month;
      int Tahun = absenPulangDTO.Tanggal.Year;

      AbsenPulang absenPulang = await this.dbContextKehadiran.AbsenPulangs.Where(p => p.NIK == absenPulangDTO.NIK && p.Tanggal.Year == Tahun && p.Tanggal.Month == Bulan && p.Tanggal.Day == Hari).FirstOrDefaultAsync();
      if (absenPulang == null) {
         var ap = await dbContextKehadiran.AbsenPulangs.AddAsync(absenPulangDTO.ConvertToModel());
         await dbContextKehadiran.SaveChangesAsync();
         return ap.Entity;
      }
      return default;

   }

		public async Task<List<AbsenPulang>?> GetByRangeDate(string? startDate, string? endDate) {
         //throw new NotImplementedException();
         var dateStart = DateConversions.StringToDate(startDate);
         var dateEnd = DateConversions.StringToDate(endDate);

         return await this.dbContextKehadiran.AbsenPulangs.Where(p => p.Tanggal.Date >= dateStart.Date && p.Tanggal.Date <= dateEnd.Date).ToListAsync();
		}

		public async Task<AbsenPulang?> GetByNIKTgl(string nik) {
         //throw new NotImplementedException();
         DateTime dateNow = DateTime.Now.Date;
         return await this.dbContextKehadiran.AbsenPulangs.Where(p => p.NIK == nik && p.Tanggal.Date == dateNow.Date).FirstOrDefaultAsync();
      }

		public Task<AbsenPulang?> GetByNIKTgl(string nik, DateTime? tgl) {
			throw new NotImplementedException();
		}
	}
}
