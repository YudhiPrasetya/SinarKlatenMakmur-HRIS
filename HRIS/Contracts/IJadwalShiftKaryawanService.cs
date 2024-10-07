using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IJadwalShiftKaryawanService {
		Task<List<JadwalShiftKaryawanDTO>> GetJadwalShiftKaryawan();
		Task<JadwalShiftKaryawanDTO> AddJadwalShiftKaryawan(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO);
		Task<JadwalShiftKaryawanDTO> UpdateJadwalShiftKaryawan(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO);
		Task<List<JadwalShiftKaryawanDTO>?> GetByLikeDeskripsi(string desc);
	}
}
