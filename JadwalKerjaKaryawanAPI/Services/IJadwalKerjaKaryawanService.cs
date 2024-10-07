using JadwalKerjaKaryawanAPI.Model;
using SKM.Shared.Dtos;

namespace JadwalKerjaKaryawanAPI.Services {
   public interface IJadwalKerjaKaryawanService {
      IEnumerable<JadwalKerjaKaryawan> GetJadwalKerjaKaryawansAsync();
      Task<JadwalKerjaKaryawan> AddJadwalKerjaKaryawanRange(IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs);
      Task<JadwalKerjaKaryawan> UpdateJadwalKerjaKaryawanRange(IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs);
      Task<JadwalKerjaKaryawan> UpdateJadwalKerja(JadwalKerjaKaryawanDTO jadwalKerjaKaryawanDTO);
      Task<JadwalKerjaKaryawan> GetByNIK(string nik);
      Task<JadwalKerjaKaryawan> GetById(int id);
      Task<List<JadwalKerjaKaryawan>> GetByGroupName(string groupName);
      Task<List<JadwalKerjaKaryawan>> GetByGroupAndDate(string group, string startDate, string endDate);
      Task<JadwalKerjaKaryawan?> GetByNIKAndDate(string nik, DateTime date);

      Task<JadwalKerjaKaryawan> DeleteJadwalKerjaKaryawanAsync(int id);

      Task<List<JadwalKerjaKaryawan>>? GetByDate(DateTime date);

	}
}
