using SKM.Shared.Dtos;
using UpahMinimumProvinsiAPI.Model;

namespace UpahMinimumProvinsiAPI.Conversions {
   public static class UMPConversions {
      public static IEnumerable<UpahMinimumProvinsiDTO> ConvertToDtO(this IEnumerable<UpahMinimumProvinsi> UMPs) {
         return (from ump in UMPs
                 select new UpahMinimumProvinsiDTO {
                    Id = ump.Id,
                    Keterangan = ump.Keterangan,
                    Tahun = ump.Tahun,
                    Jumlah = ump.Jumlah,
                    CreatedAt = ump.CreatedAt,
                    CreatedBy = ump.CreatedBy,
                    UpdatedAt = ump.UpdatedAt,
                    UpdatedBy = ump.UpdatedBy
                 }).ToList<UpahMinimumProvinsiDTO>();
      }

      public static UpahMinimumProvinsiDTO ConvertToDTO(this UpahMinimumProvinsi ump) {
         return new UpahMinimumProvinsiDTO {
            Id = ump.Id,
            Keterangan = ump.Keterangan,
            Tahun = ump.Tahun,
            Jumlah = ump.Jumlah,
            CreatedAt = ump.CreatedAt,
            CreatedBy = ump.CreatedBy,
            UpdatedAt = ump.UpdatedAt,
            UpdatedBy = ump.UpdatedBy
         };
      }

      public static IEnumerable<UpahMinimumProvinsi> ConvertToModel(this IEnumerable<UpahMinimumProvinsiDTO> umpDTOs) {
         return (from umpDTO in umpDTOs
                 select new UpahMinimumProvinsi {
                    Id = umpDTO.Id,
                    Keterangan = umpDTO.Keterangan,
                    Tahun = umpDTO.Tahun,
                    Jumlah = umpDTO.Jumlah,
                    CreatedAt = umpDTO.CreatedAt,
                    CreatedBy = umpDTO.CreatedBy,
                    UpdatedAt = umpDTO.UpdatedAt,
                    UpdatedBy = umpDTO.UpdatedBy
                 }).ToList();
      }

      public static UpahMinimumProvinsi ConvertToModel(this UpahMinimumProvinsiDTO umpDTO) {
         return new UpahMinimumProvinsi {
            Id = umpDTO.Id,
            Keterangan = umpDTO.Keterangan,
            Tahun = umpDTO.Tahun,
            Jumlah = umpDTO.Jumlah,
            CreatedAt = umpDTO.CreatedAt,
            CreatedBy = umpDTO.CreatedBy,
            UpdatedAt = umpDTO.UpdatedAt,
            UpdatedBy = umpDTO.UpdatedBy
         };
      }
   }
}
