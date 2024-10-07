using SKM.Shared.Dtos;

namespace HRIS.Contracts {
    public interface IManageEmployeeLocalStorage {
      Task<IEnumerable<EmployeeDTO>> GetEmployeeCollection();
      Task RemoveEmployeeCollection();
   }
}
