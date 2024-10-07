using JadwalKerjaSecurityAPI.Model;
using SKM.Shared.Dtos;

namespace JadwalKerjaSecurityAPI.Services {
   public interface IJadwalKerjaSecurityService {
      Task<List<JadwalKerjaSecurity>> GetJadwalKerjaSecuritiesAsync();

      Task<List<JadwalKerjaSecurity>> GetJadwalSecuritiesByMonthYearAsync(int month, int year);

      Task<JadwalKerjaSecurity> AddJadwalKerjaSecurityAsync(JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO);

      Task<JadwalKerjaSecurity> AddRange(IEnumerable<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs);

      Task<JadwalKerjaSecurity> GetByDateAndNameAsync(string date, string name);

      Task<JadwalKerjaSecurity> UpdateAsync(JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO);

      Task<List<int>?> GetByNIKAndMonth(string nik, int year, int month);

      Task<List<JadwalKerjaSecurity>> GetByDateRange(string startDate, string endDate);

      Task<JadwalKerjaSecurity?> GetByNIKAndDate(string nik, DateTime date);
   }
}
