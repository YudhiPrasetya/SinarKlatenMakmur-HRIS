using JadwalKerjaSecurityAPI.Conversions;
using JadwalKerjaSecurityAPI.Data;
using JadwalKerjaSecurityAPI.Model;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace JadwalKerjaSecurityAPI.Services {
	public class JadwalKerjaSecurityService : IJadwalKerjaSecurityService {
		private readonly JadwalKerjaSecurityDbContext jadwalKerjaSecurityDbContext;

		public JadwalKerjaSecurityService(JadwalKerjaSecurityDbContext jadwalKerjaSecurityDbContext)
      {
			this.jadwalKerjaSecurityDbContext = jadwalKerjaSecurityDbContext;
		}
      public async Task<JadwalKerjaSecurity> AddJadwalKerjaSecurityAsync(JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO)
		{
			//throw new NotImplementedException();
			var jadwal = await jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.AddAsync(jadwalKerjaSecurityDTO.ConvertToModel());
			await jadwalKerjaSecurityDbContext.SaveChangesAsync();
			return jadwal.Entity;
		}

      public async Task<JadwalKerjaSecurity> AddRange(IEnumerable<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs) {
			//throw new NotImplementedException();
			await jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.AddRangeAsync(jadwalKerjaSecurityDTOs.ConvertToModel());
			await jadwalKerjaSecurityDbContext.SaveChangesAsync();

			return default;
      }

      public async Task<JadwalKerjaSecurity> GetByDateAndNameAsync(string tgl, string name) {
			//throw new NotImplementedException();
			var arrTgl = tgl.Split("-");

			var date = new DateTime(int.Parse(arrTgl[0]), int.Parse(arrTgl[1]), int.Parse(arrTgl[2]));
			string strDate = date.ToString("yyyy-MM-dd");
			var jadwal = await jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.Where(j => j.Nama.Equals(name) && j.Tgl.Date.Equals(date.Date)).SingleOrDefaultAsync();
			return jadwal;
		}

      public async Task<List<JadwalKerjaSecurity>> GetByDateRange(string startDate, string endDate) {
			DateTime sDate = DateConversions.StringToDate(startDate);
			DateTime eDate = DateConversions.StringToDate(endDate);

			return await jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.Where(j => j.Tgl >= sDate && j.Tgl <= eDate).ToListAsync();
      }

		public async Task<JadwalKerjaSecurity?> GetByNIKAndDate(string nik, DateTime date) {
			JadwalKerjaSecurity? jadwalSecurity = await jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.SingleOrDefaultAsync(j => j.NIK == nik && j.Tgl.Date == date.Date);

			return jadwalSecurity;
		}

		public async Task<List<int>?> GetByNIKAndMonth(string nik, int year, int month) {
         //throw new NotImplementedException();
			var listJadwal = await jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.Where(j => j.NIK.Equals(nik) && j.Tgl.Month.Equals(month) && j.Tgl.Year.Equals(year)).ToListAsync();
			List<int> listTgl = new();
			if(listJadwal != null) {
				for (int x = 0; x <= listJadwal.Count - 1; x++) {
					listTgl.Add(listJadwal[x].Tgl.Day);
				}
				return listTgl;
			}
			return null;
      }

      public async Task<List<JadwalKerjaSecurity>> GetJadwalKerjaSecuritiesAsync() {
			//throw new NotImplementedException();
			return await jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.ToListAsync();
		}

		public async Task<List<JadwalKerjaSecurity>> GetJadwalSecuritiesByMonthYearAsync(int month, int year) {
			//throw new NotImplementedException();
			return await jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.Where(j => j.Tgl.Month == month && j.Tgl.Year == year).ToListAsync();

		}

		public async Task<JadwalKerjaSecurity> UpdateAsync(JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO) {
			//throw new NotImplementedException();
			var jadwalUpdated = jadwalKerjaSecurityDbContext.JadwalKerjaSecurities.Update(jadwalKerjaSecurityDTO.ConvertToModel());
			await jadwalKerjaSecurityDbContext.SaveChangesAsync();
			return jadwalUpdated.Entity;
		}
	}
}
