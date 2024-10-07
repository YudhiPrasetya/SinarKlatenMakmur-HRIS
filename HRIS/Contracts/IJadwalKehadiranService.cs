using Microsoft.AspNetCore.JsonPatch;
using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IJadwalKehadiranService {
		Task<List<JadwalKehadiranDTO>?> GetListJadwalKehadiranAsync();
		Task<JadwalKehadiranDTO?> AddJadwalKehadiranRange(List<JadwalKehadiranDTO> jadwalKehadiranDTOs);
		Task<JadwalKehadiranDTO?> UpdateJadwalKehadiran(JadwalKehadiranDTO jadwalKehadiranDTO);
		Task<JadwalKehadiranDTO?> UpdateJadwalKehadiranRange(List<JadwalKehadiranDTO> jadwalKehadiranDTOs);
		Task<List<JadwalKehadiranDTO>?> GetByGroupAndRangePeriode(string group, int month, int year);
		Task<JadwalKehadiranDTO?> GetByNIKAndDate(string nik, string tgl);
		Task<JadwalKehadiranDTO?> UpdateJadwal(JadwalKehadiranDTO jadwalKehadiranDTO);
		Task<List<int>?> GetByNIkAndYearMonth(string nik, int year, int month);
		Task<JadwalKehadiranDTO?> GetByNamaAndDate(string? nama, string strDate);
		Task<List<JadwalKehadiranDTO>?> GetTerlambat(string startDate, string endDate);
		Task<JadwalKehadiranDTO?> AddKeterlambatan(JadwalKehadiranDTO terlambat);
		Task<JadwalKehadiranDTO?> UpdateKeterlambatan(JadwalKehadiranDTO terlambat);
		Task<JadwalKehadiranDTO?> PatchTerlambat(int id, JadwalKehadiranDTO patchTerlambat);
		Task<List<JadwalKehadiranDTO>?> GetByDateRange(string startDate, string endDate);
		Task<List<JadwalKehadiranDTO>?> GetByGroupAndDateRange(string group, string startDate, string endDate);
		Task<JadwalKehadiranDTO?> UbahJam(JadwalKehadiranDTO jadwalKehadiranDTO);
		Task<List<JadwalKehadiranDTO>?> PatchMultiKeterlambatan(List<JadwalKehadiranDTO> jadwalKehadiranDTOs);
		Task<List<JadwalKehadiranDTO>?> GetByPeriode(int bulan, int tahun);
	}
}
