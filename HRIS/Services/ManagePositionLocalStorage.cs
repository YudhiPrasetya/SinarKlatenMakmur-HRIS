using HRIS.Contracts;
using SKM.Shared.Dtos;

namespace HRIS.Services {
   public class ManagePositionLocalStorage : IManagePositionLocalStorage {
      private readonly ILocalStorageService _localStorageService;
      private readonly IPositionService _positionService;
      private const string positionKey = "PositionCollection";

      public ManagePositionLocalStorage(ILocalStorageService localStorageService, IPositionService positionService) {
         _localStorageService = localStorageService;
         _positionService = positionService;
      }
      public async Task<IEnumerable<PositionDTO>> GetPositionCollection() {
         //throw new NotImplementedException();
         var positionsCollection = await _positionService.GetListPositions();
         if (positionsCollection != null) {
            await _localStorageService.SetItemAsync(positionKey, positionsCollection);
         }
         return positionsCollection;

      }

      public async Task RemovePositionCollection() {
         await _localStorageService.RemoveItemAsync(positionKey);
      }
   }
}
