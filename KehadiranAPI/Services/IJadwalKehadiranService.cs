using KehadiranAPI.Model;
using Microsoft.AspNetCore.JsonPatch;
using SKM.Shared.Dtos;

namespace KehadiranAPI.Services {
   public interface IJadwalKehadiranService {
      Task<List<JadwalKehadiranDTO>?> GetJadwalKehadiran(); 
      Task<JadwalKehadiranDTO?> AddJadwalKehadiranRange(List<JadwalKehadiranDTO> jadwalDTOs);
      Task<JadwalKehadiranDTO> UpdateJadwalKehadiran(JadwalKehadiranDTO jadwalKehadiran);
      Task<JadwalKehadiranDTO?> UpdateJadwalKehadiranRange(List<JadwalKehadiranDTO> jadwalKehadiranDTOs);
      Task<JadwalKehadiranDTO?> GetByNIKAndDate(string nik, string strDate);
      Task<JadwalKehadiranDTO?> UpdateJamMasukJamPulang(JadwalKehadiranDTO jadwalKehadiranDTO);
      Task<List<JadwalKehadiranDTO>?> GetByGroupAndRangePeriode(string group, int month, int year);
      Task<JadwalKehadiranDTO?> Update(JadwalKehadiranDTO jadwalKehadiranDTO);
      Task<List<int>?> GetByNIKAndMonthYear(string nik, int year, int month);
      Task<JadwalKehadiranDTO?> GetByNamaAndDate(string nama, string strDate);
		Task<List<JadwalKehadiranDTO>?> GetTerlambat(string startDate, string endDate);
		Task<JadwalKehadiranDTO?> AddKeterlambatan(JadwalKehadiranDTO terlambat);
		Task<JadwalKehadiranDTO?> UpdateKeterlambatan(JadwalKehadiranDTO terlambat);
      Task<JadwalKehadiranDTO?> PatchKeterlambatan(int id, JadwalKehadiranDTO dataTerlambat);
      Task<List<JadwalKehadiranDTO>?> GetByDateRange(string startDate, string endDate);
      Task<List<JadwalKehadiranDTO>?> GetByGroupAndDateRange(string group, string startDate, string endDate);
      Task<JadwalKehadiranDTO?> UbahJam(JadwalKehadiranDTO jadwalKehadiranDTO);
      Task<List<JadwalKehadiranDTO>?> PatchMultiKeterlambatan(List<JadwalKehadiranDTO> jadwalKehadiranDTOs);
      Task<List<JadwalKehadiranDTO>?> GetByPeriode(int bulan, int tahun);
	}
}
