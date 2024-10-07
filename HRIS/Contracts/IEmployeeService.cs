using SKM.Shared.Dtos;

namespace HRIS.Contracts {
    public interface IEmployeeService {
      Task<List<EmployeeDTO>> GetListEmployeesAsync();
      Task<List<EmployeeDTO>> GetListEmployeesByGroupIdAsync(int groupId);
      Task<EmployeeDTO> GetEmployeeAsync(int id);
      Task<EmployeeDTO> AddEmployeeAsync(EmployeeDTO positionDTO);
      Task<EmployeeDTO> DeleteEmployeeAsync(int id);
      Task<EmployeeDTO> UpdateEmployeeAsync(EmployeeDTO positionDTO);
      Task<List<EmployeeDTO>> GetSecurities();
      Task<List<EmployeeDTO>> GetByGroupAndDate(string group, string startDate, string endDate);
      Task ExportToExcel(string group, string startDate, string endDate);
      Task<List<EmployeeDTO>?> GetByNameContains(string name);
      Task<List<EmployeeDTO>?> GetByGroupName(string? groupName);
   }
}
