using Microsoft.EntityFrameworkCore;
using ShiftAPI.Conversions;
using ShiftAPI.Data;
using ShiftAPI.Models;
using SKM.Shared.Dtos;

namespace ShiftAPI.Services {

	public interface IJadwalShiftKaryawanService {
		Task<List<JadwalShiftKaryawan>> GetJadwalShiftKaryawanAsync();
		Task<JadwalShiftKaryawan> AddJadwalShiftKaryawanAsync(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO);
		Task<JadwalShiftKaryawan> UpdateJadwalShiftKaryawanAsync(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO);
		Task<List<JadwalShiftKaryawanDTO>?> GetByLikeDeskripsi(string desc);
	}
	public class JadwalShiftKaryawanService : IJadwalShiftKaryawanService {
		private readonly ShiftDbContext dbContext;

		public JadwalShiftKaryawanService(ShiftDbContext dbContext)
      {
		this.dbContext = dbContext;
		}
      public async Task<JadwalShiftKaryawan> AddJadwalShiftKaryawanAsync(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO){
			//throw new NotImplementedException();
			var jadwalShiftKaryawan = await this.dbContext.JadwalShiftKaryawans.AddAsync(jadwalShiftKaryawanDTO.ConvertToModel());
			await this.dbContext.SaveChangesAsync();
			return jadwalShiftKaryawan.Entity;

		}

      public async Task<List<JadwalShiftKaryawanDTO>?> GetByLikeDeskripsi(string desc) {
			var rst = await dbContext.JadwalShiftKaryawans.Where(j => EF.Functions.Like(j.Deskripsi!, $"%{desc}%")).ToListAsync();
			return (List<JadwalShiftKaryawanDTO>?)rst.ConvertToDTO();
      }

      public async Task<List<JadwalShiftKaryawan>> GetJadwalShiftKaryawanAsync() {
			//throw new NotImplementedException();
			return await dbContext.JadwalShiftKaryawans.ToListAsync();
		}

		public async Task<JadwalShiftKaryawan> UpdateJadwalShiftKaryawanAsync(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO) {
			//throw new NotImplementedException();
			var jadwal = dbContext.JadwalShiftKaryawans.Update(jadwalShiftKaryawanDTO.ConvertToModel());
			await dbContext.SaveChangesAsync();
			return jadwal.Entity;
		}
	}
}
