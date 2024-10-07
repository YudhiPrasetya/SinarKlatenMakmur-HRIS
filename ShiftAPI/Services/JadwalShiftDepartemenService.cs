using Microsoft.EntityFrameworkCore;
using ShiftAPI.Conversions;
using ShiftAPI.Data;
using ShiftAPI.Models;
using SKM.Shared.Dtos;

namespace ShiftAPI.Services {
	public interface IJadwalShiftDepartemenService {
		Task<List<JadwalShiftDepartemen>> GetJadwalShiftDepartemenAsync();
		Task<JadwalShiftDepartemen> AddJadwalShiftDepartemenAsync(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO);
		Task<JadwalShiftDepartemen> AddRange(List<JadwalShiftDepartemenDTO> jadwalShiftDepartemenDTOs);
		Task<JadwalShiftDepartemen> UpdateJadwalShiftDepartemenAsync(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO);
	}

	public class JadwalShiftDepartemenService : IJadwalShiftDepartemenService {
			private readonly ShiftDbContext dbContext;

			public JadwalShiftDepartemenService(ShiftDbContext dbContext) {
				this.dbContext = dbContext;
			}
			public async Task<JadwalShiftDepartemen> AddJadwalShiftDepartemenAsync(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO) {
				//throw new NotImplementedException();
				var jadwalShiftDepartemen = await this.dbContext.JadwalShiftDepartemens.AddAsync(jadwalShiftDepartemenDTO.ConvertToModel());
				await this.dbContext.SaveChangesAsync();
				return jadwalShiftDepartemen.Entity;

			}

		public async Task<JadwalShiftDepartemen> AddRange(List<JadwalShiftDepartemenDTO> jadwalShiftDepartemenDTOs) {
			//throw new NotImplementedException();
			await this.dbContext.JadwalShiftDepartemens.AddRangeAsync(jadwalShiftDepartemenDTOs.ConvertToModel());
			await this.dbContext.SaveChangesAsync();

			return default;

		}

		public async Task<List<JadwalShiftDepartemen>> GetJadwalShiftDepartemenAsync() {
				//throw new NotImplementedException();
				return await dbContext.JadwalShiftDepartemens.ToListAsync();
			}

			public async Task<JadwalShiftDepartemen> UpdateJadwalShiftDepartemenAsync(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO) {
				//throw new NotImplementedException();
				var jadwal = dbContext.JadwalShiftDepartemens.Update(jadwalShiftDepartemenDTO.ConvertToModel());
				await dbContext.SaveChangesAsync();
				return jadwal.Entity;
			}
		}
}
