using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IManagePositionLocalStorage {
      Task<IEnumerable<PositionDTO>> GetPositionCollection();
      Task RemovePositionCollection();
   }
}
