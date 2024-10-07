using ShiftAPI.Conversions;
using ShiftAPI.Data;
using ShiftAPI.Models;
using SKM.Shared.Dtos;

namespace ShiftAPI.Services {
	public interface IjamKerjaService {
		Task<JamKerja> GetJamKerja(int id);
		Task<JamKerja> UpdateJamKerja(JamKerjaDTO jamKerjaDTO);
		Task<JamKerja> AddJamkerja(JamKerjaDTO jamKerjaDTO);
	}

	public class JamKerjaService : IjamKerjaService {
		private readonly ShiftDbContext shiftDbContext;

		public JamKerjaService(ShiftDbContext shiftDbContext) {
			this.shiftDbContext = shiftDbContext;
		}
		public async Task<JamKerja> AddJamkerja(JamKerjaDTO jamKerjaDTO) {
			//throw new NotImplementedException();
			var jamKerja = await this.shiftDbContext.JamKerjas.AddAsync(jamKerjaDTO.ConvertToModel());
			await this.shiftDbContext.SaveChangesAsync();
			return jamKerja.Entity;
		}

		public async Task<JamKerja> UpdateJamKerja(JamKerjaDTO jamKerjaDTO) {
			var jamKerja = this.shiftDbContext.JamKerjas.Update(jamKerjaDTO.ConvertToModel());
			await this.shiftDbContext.SaveChangesAsync();
			return jamKerja.Entity;
		}

		public async Task<JamKerja?> GetJamKerja(int id) {
			return await this.shiftDbContext.JamKerjas.FindAsync(id);
		}
	}
}
