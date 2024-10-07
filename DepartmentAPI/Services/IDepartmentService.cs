using DepartmentAPI.Models;
using SKM.Shared.Dtos;

namespace DepartmentAPI.Services {
   public interface IDepartmentService {
      public IEnumerable<Department> GetDepartmentListAsync();
      public Task<Department> GetDepartmentByIdAsync(int id);
      public Task<Department> AddDepartment(DepartmentDTO departmentDTO);
      public Task<Department> UpdateDepartmentAsync(DepartmentDTO departmentDTO);
      public Task<Department> DeleteDepartmentAsync(int id);

      public bool SendDepartmentOffer(DepartmentOffer departmentOffer);
   }
}
