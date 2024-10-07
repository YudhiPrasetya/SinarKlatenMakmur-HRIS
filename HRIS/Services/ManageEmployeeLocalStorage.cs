using HRIS.Contracts;
using SKM.Shared.Dtos;

namespace HRIS.Services {
    public class ManageEmployeeLocalStorage : IManageEmployeeLocalStorage {
        private readonly ILocalStorageService _localStorageService;
        private readonly IEmployeeService _employeeService;
        private const string employeeKey = "EmployeeCollection";

      public ManageEmployeeLocalStorage(ILocalStorageService localStorageService, IEmployeeService employeeService) {
            _localStorageService = localStorageService;
            _employeeService = employeeService;
        }
        public async Task<IEnumerable<EmployeeDTO>> GetEmployeeCollection() {
         //throw new NotImplementedException();
         var employeesCollection = await _employeeService.GetListEmployeesAsync();
         if (employeesCollection != null) {
            await _localStorageService.SetItemAsync(employeeKey, employeesCollection);
         }
         return employeesCollection;
      }

        public async Task RemoveEmployeeCollection() {
         await _localStorageService.RemoveItemAsync(employeeKey);
      }
    }
}
