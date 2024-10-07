using KehadiranAPI.Model;
using SKM.Shared.Dtos;

namespace KehadiranAPI.Services {
   public interface IKehadiranServices {
      Task<List<Kehadiran>> GetAllAsync();
      Task<Kehadiran?> Absen(KehadiranDTO kehadiranDTO);
      Task<Kehadiran> GetByNIKAndDate(string nik,  string strDate);
      Task<Kehadiran?> UpdateAbsenMasuk(KehadiranDTO kehadiranDTO);
      Task<List<Kehadiran>?> GetByRangeDate(string? dateStart, string? dateEnd);
      Task<Kehadiran> AbsenPulang(KehadiranDTO kehadiranDTO);
      Task<List<Kehadiran>> GetByGroupAndDate(string group, string startDate, string endDate);
      Task<Kehadiran> UbahJam(KehadiranDTO kehadiranDTO);
      
      Task<int> TambahIjin(List<JadwalKehadiran> list);
      Task<int[]> GetKehadiran();
      Task<List<JadwalKehadiran>> GetTerlambat(string startDate, string endDate);
      Task<JadwalKehadiran> AddKeterlambatan(JadwalKehadiranDTO terlambat);
      Task<JadwalKehadiran> UpdateKeterlambatan(JadwalKehadiranDTO terlambat);
      Task<int[]> CountEmpByGender();

   }
}
