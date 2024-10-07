using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IKehadiranService {
      Task<List<KehadiranDTO>> ListKehadiran();
      Task<KehadiranDTO> UpdateAbsen(KehadiranDTO kehadiranDTO);
      Task<List<KehadiranDTO>> GetByDateRange(string? startDate, string? endDate);
      Task<KehadiranDTO> AbsenPulang(KehadiranDTO kehadiranDTO);
      Task<IEnumerable<KehadiranDTO>> GetByGroupAndDate(string group, string startDate, string endDate);
      Task ExportToExcel(string group, string startDate, string endDate);
      Task<KehadiranDTO> GetByNIKAndDate(string nik, string date);
      Task<KehadiranDTO> UbahJam(KehadiranDTO kehadiranDTO);

      //Task<int?> TambahIjin(List<KehadiranDTO> kehadiranDTOs);
      Task<int?> TambahIjin(List<JadwalKehadiranDTO> jadwalKehadiranDTOs);
      //Task<List<JadwalKehadiranDTO>?> GetTerlambat(string startDate, string endDate);
      //Task<JadwalKehadiranDTO> AddKeterlambatan(JadwalKehadiranDTO terlambat);
      //Task<JadwalKehadiranDTO> UpdateKeterlambatan(JadwalKehadiranDTO terlambat);

   }
}
