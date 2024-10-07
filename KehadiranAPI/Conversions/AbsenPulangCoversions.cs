using KehadiranAPI.Model;
using SKM.Shared.Dtos;

namespace KehadiranAPI.Conversions {
   public static class AbsenPulangCoversions {
      public static IEnumerable<AbsenPulangDTO> ConvertToDTO(this IEnumerable<AbsenPulang> absenPulangs) {
         return (from p in absenPulangs
                 select new AbsenPulangDTO {
                    Id = p.Id,
                    NIK = p.NIK,
                    Tanggal = p.Tanggal,
                    JamPulang = p.JamPulang,
                    JadwalPulang = p.JadwalPulang,
                 }).ToList();
      }

      public static AbsenPulangDTO ConvertToDTO(this AbsenPulang p) {
         return new AbsenPulangDTO {
            Id = p.Id,
            NIK = p.NIK,
            Tanggal = p.Tanggal,
            JamPulang = p.JamPulang,
            JadwalPulang = p.JadwalPulang,
         };
      }

      public static IEnumerable<AbsenPulang> ConvertToModel(this IEnumerable<AbsenPulangDTO> absenPulangDTOs) {
         return (from absenPulangDTO in absenPulangDTOs
                 select new AbsenPulang {
                    Id = absenPulangDTO.Id,
                    NIK = absenPulangDTO.NIK,
                    Tanggal = absenPulangDTO.Tanggal,
                    JamPulang = absenPulangDTO.JamPulang,
                    JadwalPulang = absenPulangDTO.JadwalPulang
                 }).ToList();
      }

      public static AbsenPulang ConvertToModel(this AbsenPulangDTO absenPulangDTO) {
         return new AbsenPulang {
            Id = absenPulangDTO.Id,
            NIK = absenPulangDTO.NIK,
            Tanggal = absenPulangDTO.Tanggal,
            JamPulang = absenPulangDTO.JamPulang,
            JadwalPulang = absenPulangDTO.JadwalPulang
         };
      }
   }
}
