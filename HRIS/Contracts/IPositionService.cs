using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IPositionService {
      Task<List<PositionDTO>> GetListPositions();
      Task<PositionDTO> GetPosition(int id);
      Task<PositionDTO> AddPosition(PositionDTO positionDTO);
      Task<PositionDTO> DeletePosition(int id);
      Task<PositionDTO> UpdatePosition(PositionDTO positionDTO);
   }
}
