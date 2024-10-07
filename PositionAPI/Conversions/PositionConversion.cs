using PositionAPI.Models;
using SKM.Shared.Dtos;

namespace PositionAPI.Conversions {
   public static class PositionConversion {
      public static IEnumerable<PositionDTO> ConvertToDtO(this IEnumerable<Position> positions) {
         return (from position in positions
                 select new PositionDTO {
                    PositionId= position.PositionId,
                    PositionDesc= position.PositionDesc,
                    IsActive= position.IsActive,
                    CreatedAt= position.CreatedAt,
                    CreatedBy= position.CreatedBy
                 }).ToList<PositionDTO>();
      }

      public static PositionDTO ConvertToDTO(this Position position) {
         return new PositionDTO {
            PositionId= position.PositionId,
            PositionDesc= position.PositionDesc,
            IsActive = position.IsActive,
            CreatedAt= position.CreatedAt,
            CreatedBy= position.CreatedBy
         };
      }

      public static IEnumerable<Position> ConvertToModel(this IEnumerable<PositionDTO> positionDTOs) {
         return (from positionDTO in positionDTOs
                 select new Position {
                     PositionId = positionDTO.PositionId,
                     PositionDesc= positionDTO.PositionDesc,
                     IsActive= positionDTO.IsActive,
                     CreatedAt= positionDTO.CreatedAt,
                     CreatedBy= positionDTO.CreatedBy
                 }).ToList();
      }

      public static Position ConvertToModel(this PositionDTO positionDTO) {
         return new Position {
            PositionId= positionDTO.PositionId,
            PositionDesc= positionDTO.PositionDesc,
            IsActive= positionDTO.IsActive,
            CreatedAt= positionDTO.CreatedAt,
            CreatedBy= positionDTO.CreatedBy
         };
      }
   }
}
