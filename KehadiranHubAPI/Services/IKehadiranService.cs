using KehadiranHubAPI.Model;

namespace KehadiranHubAPI.Services {
   public interface IKehadiranService {
      Task<int[]> GetKehadiran();
      Task<List<JadwalKehadiran>> GetTop10KaryawanRajin();
      Task<List<JadwalKehadiran>> GetTop5KaryawanRajin();
      Task<List<JadwalKehadiran>> GetKaryawanTerlambat();
      Task<List<JadwalKehadiran>> GetTop5KaryawanTerlambat();
      Task<int[]> GetEmployessByGender();
   }
}
