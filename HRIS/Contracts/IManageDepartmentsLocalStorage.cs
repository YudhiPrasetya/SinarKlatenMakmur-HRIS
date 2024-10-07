using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IManageDepartmentsLocalStorage {
      Task<IEnumerable<DepartmentDTO>> GetDepartmentCollection();
      Task RemoveDepartmentCollection();
   }
}
