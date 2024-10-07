using MesinAbsenAPI.Models;
using SKM.Shared.Dtos;

namespace MesinAbsenAPI.Conversions {
   public static class MesinAbsenConversion {
      public static IEnumerable<MesinAbsenDTO> ConvertToDtO(this IEnumerable<MesinAbsen> mesinabsens) {
         return (from ma in mesinabsens
                 select new MesinAbsenDTO {
                     DeviceID = ma.DeviceID,
                     DeviceNo = ma.DeviceNo,
                     DeviceDesc = ma.DeviceDesc,
                     DeviceIP = ma.DeviceIP,
                     Port = ma.Port,
                     IsActive= ma.IsActive,
                     CreatedBy= ma.CreatedBy,
                     CreatedAt= ma.CreatedAt,
                     UpdatedBy= ma.UpdatedBy,
                     UpdatedAt= ma.UpdatedAt
                 }).ToList<MesinAbsenDTO>();
      }

      public static MesinAbsenDTO ConvertToDTO(this MesinAbsen mesinabsen) {
         return new MesinAbsenDTO {
            DeviceID= mesinabsen.DeviceID,
            DeviceNo= mesinabsen.DeviceNo,
            DeviceDesc= mesinabsen.DeviceDesc,
            DeviceIP= mesinabsen.DeviceIP,
            Port= mesinabsen.Port,
            IsActive= mesinabsen.IsActive,
            CreatedBy = mesinabsen.CreatedBy,
            CreatedAt= mesinabsen.CreatedAt,
            UpdatedBy= mesinabsen.UpdatedBy,
            UpdatedAt= mesinabsen.UpdatedAt
         };
      }

      public static IEnumerable<MesinAbsen> ConvertToModel(this IEnumerable<MesinAbsenDTO> mesinabsenDTOs) {
         return (from positionDTO in mesinabsenDTOs
                 select new MesinAbsen {
                    DeviceID = positionDTO.DeviceID,
                    DeviceNo= positionDTO.DeviceNo,
                    DeviceDesc= positionDTO.DeviceDesc,
                    DeviceIP= positionDTO.DeviceIP,
                    Port= positionDTO.Port,
                    CreatedBy= positionDTO.CreatedBy,
                    CreatedAt= positionDTO.CreatedAt,
                    UpdatedBy= positionDTO.UpdatedBy,
                    UpdatedAt= positionDTO.UpdatedAt
                 }).ToList();
      }

      public static MesinAbsen ConvertToModel(this MesinAbsenDTO mesinabsenDTO) {
         return new MesinAbsen {
            DeviceIP = mesinabsenDTO.DeviceIP,
            Port = mesinabsenDTO.Port,
            DeviceDesc= mesinabsenDTO.DeviceDesc,
            DeviceID= mesinabsenDTO.DeviceID,
            DeviceNo = mesinabsenDTO.DeviceNo,
            CreatedBy = mesinabsenDTO.CreatedBy,
            CreatedAt = mesinabsenDTO.CreatedAt,
            UpdatedBy  = mesinabsenDTO.UpdatedBy,
            UpdatedAt = mesinabsenDTO.UpdatedAt
         };
      }

   }
}
