using SKM.Shared.Dtos;

namespace HRIS.Contracts {
	public interface IJadwalKerjaSecurityService {
		Task<IEnumerable<JadwalKerjaSecurityDTO>> GetJadwalKerjaSecuritiesAsync();
		Task<JadwalKerjaSecurityDTO> AddJadwalKerjaSecurityAsync(JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO);
		Task<IEnumerable<JadwalKerjaSecurityDTO>> GetJadwalKerjaSecuritiesByMonthYearAsync(int month, int year);
		Task<List<JadwalKerjaSecurityDTO>> GetByDateRange(string startDate, string endDate);
		Task<JadwalKerjaSecurityDTO> UpdateJadwalKerjaSecurityAsync(JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO);
		Task<JadwalKerjaSecurityDTO> GetByDateAndName(string tgl,  string name);
		Task<JadwalKerjaKaryawanDTO> AddRange(IEnumerable<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs);

		Task<List<int>> GetByNIKAndMonthYear(string nik, int tahun, int bulan);
	}
}
