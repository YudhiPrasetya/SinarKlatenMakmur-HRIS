using HRIS.Contracts;
using SKM.Shared.Dtos;

namespace HRIS.Services {
   public class ManageDepartmentsLocalStorage: IManageDepartmentsLocalStorage {
      private readonly ILocalStorageService _localStorageService;
      private readonly IDepartmentService _departmentService;
      private const string departmentKey = "DepartmentCollection";

      public ManageDepartmentsLocalStorage(ILocalStorageService localStorageService, IDepartmentService departmentService) {
         _localStorageService = localStorageService;
         _departmentService = departmentService;
      }
      public async Task<IEnumerable<DepartmentDTO>> GetDepartmentCollection() {
         //throw new NotImplementedException();
         await RemoveDepartmentCollection();
         //return await _localStorageService.GetItemAsync<IEnumerable<DepartmentDTO>>(key) ?? await AddCollection();
         return await AddDepartmentCollection();
      }

      public async Task RemoveDepartmentCollection() {
         await _localStorageService.RemoveItemAsync(departmentKey);
      }

      public async Task<IEnumerable<DepartmentDTO>?> AddDepartmentCollection() {
         //throw new NotImplementedException();
         var departmentsCollection = await _departmentService.GetListDepartmentsAsync();
         if (departmentsCollection != null) {
            await _localStorageService.SetItemAsync(departmentKey, departmentsCollection);
         }
         return departmentsCollection;
      }
   }
}
