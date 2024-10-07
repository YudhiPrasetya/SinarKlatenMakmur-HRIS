using PenghasilanTidakKenaPajakAPI.Model;
using SKM.Shared.Dtos;

namespace PenghasilanTidakKenaPajakAPI.Conversions {
   public static class PTKPConversions {
      public static IEnumerable<PenghasilanTidakKenaPajakDTO> ConvertToDtO(this IEnumerable<PenghasilanTidakKenaPajak> ptkps) {
         return (from ptkp in ptkps
                 select new PenghasilanTidakKenaPajakDTO {
                    Id = ptkp.Id,
                    Keterangan = ptkp.Keterangan,
                    Jumlah = ptkp.Jumlah,
                    CreatedAt = ptkp.CreatedAt,
                    CreatedBy = ptkp.CreatedBy,
                    UpdatedAt = ptkp.UpdatedAt,
                    UpdatedBy = ptkp.UpdatedBy
                 }).ToList<PenghasilanTidakKenaPajakDTO>();
      }

      public static PenghasilanTidakKenaPajakDTO ConvertToDTO(this PenghasilanTidakKenaPajak ptkp) {
         return new PenghasilanTidakKenaPajakDTO {
            Id = ptkp.Id,
            Keterangan = ptkp.Keterangan,
            Jumlah = ptkp.Jumlah,
            CreatedAt = ptkp.CreatedAt,
            CreatedBy = ptkp.CreatedBy,
            UpdatedAt = ptkp.UpdatedAt,
            UpdatedBy = ptkp.UpdatedBy
         };
      }

      public static IEnumerable<PenghasilanTidakKenaPajak> ConvertToModel(this IEnumerable<PenghasilanTidakKenaPajakDTO> ptkpDTOs) {
         return (from ptkpDTO in ptkpDTOs
                 select new PenghasilanTidakKenaPajak {
                    Id = ptkpDTO.Id,
                    Keterangan = ptkpDTO.Keterangan,
                    Jumlah = ptkpDTO.Jumlah,
                    CreatedAt = ptkpDTO.CreatedAt,
                    CreatedBy = ptkpDTO.CreatedBy,
                    UpdatedAt = ptkpDTO.UpdatedAt,
                    UpdatedBy = ptkpDTO.UpdatedBy
                 }).ToList();
      }

      public static PenghasilanTidakKenaPajak ConvertToModel(this PenghasilanTidakKenaPajakDTO ptkpDTO) {
         return new PenghasilanTidakKenaPajak {
            Id = ptkpDTO.Id,
            Keterangan = ptkpDTO.Keterangan,
            Jumlah = ptkpDTO.Jumlah,
            CreatedAt = ptkpDTO.CreatedAt,
            CreatedBy = ptkpDTO.CreatedBy,
            UpdatedAt = ptkpDTO.UpdatedAt,
            UpdatedBy = ptkpDTO.UpdatedBy
         };
      }
   }
}
