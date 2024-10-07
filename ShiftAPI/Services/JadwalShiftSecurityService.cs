using Microsoft.EntityFrameworkCore;
using ShiftAPI.Conversions;
using ShiftAPI.Data;
using ShiftAPI.Models;
using SKM.Shared.Dtos;

namespace ShiftAPI.Services {
	public interface IJadwalShiftSecurityService {
		Task<List<JadwalShiftSecurity>> GetJadwalShiftSecuritiesAsync();
		Task<JadwalShiftSecurity> AddJadwalShiftSecurityAsync(JadwalShiftSecurityDTO jadwalShiftSecurityDTO);

		Task<JadwalShiftSecurity> UpdateJadwalShiftSecurityAsync(JadwalShiftSecurityDTO jadwalShiftSecurityDTO);

		Task<JadwalShiftSecurity> GetByInisialAsync(string inisial);

	}
	public class JadwalShiftSecurityService : IJadwalShiftSecurityService {
		private readonly ShiftDbContext shiftDbContext;

		public JadwalShiftSecurityService(ShiftDbContext shiftDbContext) {
			this.shiftDbContext = shiftDbContext;
		}
		public async Task<JadwalShiftSecurity> AddJadwalShiftSecurityAsync(JadwalShiftSecurityDTO jadwalShiftSecurityDTO) {
			//throw new NotImplementedException();
			var jadwal = await this.shiftDbContext.JadwalShiftSecurities.AddAsync(jadwalShiftSecurityDTO.ConvertToModel());
			await this.shiftDbContext.SaveChangesAsync();

			return jadwal.Entity;
		}

		public async Task<JadwalShiftSecurity> GetByInisialAsync(string inisial) {
			//throw new NotImplementedException();
			var jadwal = await this.shiftDbContext.JadwalShiftSecurities.Where(s => s.Initial == inisial).FirstOrDefaultAsync();
			return jadwal;
		}

		public async Task<List<JadwalShiftSecurity>> GetJadwalShiftSecuritiesAsync() {
			//throw new NotImplementedException();
			return await this.shiftDbContext.JadwalShiftSecurities.ToListAsync();
		}

		public async Task<JadwalShiftSecurity> UpdateJadwalShiftSecurityAsync(JadwalShiftSecurityDTO jadwalShiftSecurityDTO) {
			//throw new NotImplementedException();
			var jadwal = this.shiftDbContext.JadwalShiftSecurities.Update(jadwalShiftSecurityDTO.ConvertToModel());
			await this.shiftDbContext.SaveChangesAsync();

			return jadwal.Entity;
		}
	}
}
