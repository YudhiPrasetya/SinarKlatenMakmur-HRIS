using MesinAbsenAPI.Model;
using SKM.Shared.Dtos;

namespace MesinAbsenAPI.Conversions {
   public static class AbsenRealTimeConversions {
      public static IEnumerable<AbsenRealTimeDTO> ConvertToDTO(this IEnumerable<AbsenRealTime> absenRealTimes) {
         return (
            from a in absenRealTimes
            select new AbsenRealTimeDTO {
               Id = a.Id,
               NIK = a.NIK,
               Nama = a.Nama,
               Gender = a.Gender,
               GroupKerja = a.GroupKerja,
               Tanggal = a.Tanggal,
               IpMesin = a.IpMesin,
               Port = a.Port,
               NoMesin = a.NoMesin
            }
         ).ToList();
      }

      public static AbsenRealTimeDTO ConvertToDTO(this AbsenRealTime a) {
         return new AbsenRealTimeDTO {
            Id = a.Id,
            NIK = a.NIK,
            Nama = a.Nama,
            Gender = a.Gender,
            GroupKerja = a.GroupKerja,
            Tanggal = a.Tanggal,
            IpMesin = a.IpMesin,
            Port = a.Port,
            NoMesin = a.NoMesin
         };
      }

      public static IEnumerable<AbsenRealTime> ConvertToModel(this IEnumerable<AbsenRealTimeDTO> absenMasukDTOs) {
         return (
            from a in absenMasukDTOs
            select new AbsenRealTime {
               Id = a.Id,
               NIK = a.NIK,
               Nama = a.Nama,
               Gender = a.Gender,
               GroupKerja = a.GroupKerja,
               Tanggal = a.Tanggal,
               IpMesin = a.IpMesin,
               Port = a.Port,
               NoMesin = a.NoMesin
            }
         ).ToList();
      }

      public static AbsenRealTime ConvertToModel(this AbsenRealTimeDTO a) {
         return new AbsenRealTime {
            Id = a.Id,
            NIK = a.NIK,
            Nama = a.Nama,
            Gender = a.Gender,
            GroupKerja = a.GroupKerja,
            Tanggal = a.Tanggal,
            IpMesin = a.IpMesin,
            Port = a.Port,
            NoMesin = a.NoMesin
         };
      }
   }
}
