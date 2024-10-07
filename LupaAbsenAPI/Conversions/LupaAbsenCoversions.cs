using LupaAbsenAPI.Model;
using SKM.Shared.Dtos;

namespace LupaAbsenAPI.Conversions {
   public static class LupaAbsenCoversions {
      public static IEnumerable<LupaAbsenDTO> ConvertToDtO(this IEnumerable<LupaAbsen> lupaAbsens) {
         return (from la in lupaAbsens
                 select new LupaAbsenDTO {
                    Id = la.Id,
                    Tanggal = la.Tanggal,
                    NIK = la.NIK,
                    GrupKerja = la.GrupKerja,
                    NamaKaryawan = la.NamaKaryawan,
                    Absen = la.Absen,
                    Jam = la.Jam,
                    Keterangan = la.Keterangan,
                    CreatedBy = la.CreatedBy,
                    CreatedAt = la.CreatedAt,
                    UpdatedBy = la.UpdatedBy,
                    UpdatedAt = la.UpdatedAt
                 }).ToList<LupaAbsenDTO>();
      }

      public static LupaAbsenDTO ConvertToDTO(this LupaAbsen la) {
         return new LupaAbsenDTO {
            Id = la.Id,
            Tanggal = la.Tanggal,
            NIK = la.NIK,
            GrupKerja = la.GrupKerja,
            NamaKaryawan = la.NamaKaryawan,
            Absen = la.Absen,
            Jam = la.Jam,
            Keterangan = la.Keterangan,
            CreatedBy = la.CreatedBy,
            CreatedAt = la.CreatedAt,
            UpdatedBy = la.UpdatedBy,
            UpdatedAt = la.UpdatedAt
         };
      }

      public static IEnumerable<LupaAbsen> ConvertToModel(this IEnumerable<LupaAbsenDTO> LupaAbsenDTOs) {
         return (from la in LupaAbsenDTOs
                 select new LupaAbsen {
                    Id = la.Id,
                    Tanggal = la.Tanggal,
                    NIK = la.NIK,
                    GrupKerja = la.GrupKerja,
                    NamaKaryawan = la.NamaKaryawan,
                    Absen = la.Absen,
                    Jam = la.Jam,
                    Keterangan = la.Keterangan,
                    CreatedBy = la.CreatedBy,
                    CreatedAt = la.CreatedAt,
                    UpdatedBy = la.UpdatedBy,
                    UpdatedAt = la.UpdatedAt
                 }).ToList();
      }

      public static LupaAbsen ConvertToModel(this LupaAbsenDTO la) {
         return new LupaAbsen {
            Id = la.Id,
            Tanggal = la.Tanggal,
            NIK = la.NIK,
            GrupKerja = la.GrupKerja,
            NamaKaryawan = la.NamaKaryawan,
            Absen = la.Absen,
            Jam = la.Jam,
            Keterangan = la.Keterangan,
            CreatedBy = la.CreatedBy,
            CreatedAt = la.CreatedAt,
            UpdatedBy = la.UpdatedBy,
            UpdatedAt = la.UpdatedAt
         };
      }
   }
}
