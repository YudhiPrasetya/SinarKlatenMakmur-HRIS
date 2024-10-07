using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IJadwalKerjaKaryawanService {
      Task<IEnumerable<JadwalKerjaKaryawanDTO>> GetAllJadwalKerjaKaryawan();
      Task<JadwalKerjaKaryawanDTO> AddJadwalKerjaKaryawanRange(IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs);
      Task<JadwalKerjaKaryawanDTO> UpdateJadwalKerjaKaryawanRange(IEnumerable<JadwalKerjaKaryawanDTO?> jadwalDTOs);
		Task<JadwalKerjaKaryawanDTO> UpdateJadwalKerjaKaryawan(JadwalKerjaKaryawanDTO jadwalDTO);
		Task<JadwalKerjaKaryawanDTO> GetById(int id);
      Task<List<JadwalKerjaKaryawanDTO>> GetByGroupName(string groupName);
      Task<JadwalKerjaKaryawanDTO> GetByNIK(string nik);
      Task<List<JadwalKerjaKaryawanDTO>> GetByGroupAndDate(string group, string startDate, string endDate);

      Task<JadwalKerjaKaryawanDTO> DeleteJadwalKerjaKaryawan(int id);
      Task<List<JadwalKerjaKaryawanDTO>> GetByDate(DateTime date);

	}
}
