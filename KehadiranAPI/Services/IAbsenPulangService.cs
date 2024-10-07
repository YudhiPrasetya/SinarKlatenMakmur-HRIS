using KehadiranAPI.Model;
using SKM.Shared.Dtos;

namespace KehadiranAPI.Services {
   public interface IAbsenPulangService {
      Task<AbsenPulang?> AddAbsenPulang(AbsenPulangDTO absenPulangDTO);
      Task<AbsenPulang?> GetByNIKTgl(string nik, DateTime? tgl);
      Task<List<AbsenPulang>?> GetByRangeDate(string? startDate, string? endDate);
   }
}
