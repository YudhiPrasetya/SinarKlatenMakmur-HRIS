using EmployeeAPI.Model;
using SKM.Shared.Dtos;
using SKM.Shared.Models;

namespace EmployeeAPI.Services
{
	public interface IEmployeeService
	{
		public IEnumerable<Employee> GetEmployeeListAsync();
		public Task<IEnumerable<Employee>> GetEmployeesByGroupId(int groupId);
		public Task<Employee> GetEmployeeByIdAsync(int id);
		public Task<Employee?> GetEmployeeByNIKAsync(string nik);
		public Task<Employee> AddEmployeeAsync(Employee employee);
		public Task<Employee> UpdateEmployeeAsync(Employee employee);
		public Task<Employee> DeleteEmployeeAsync(int id);
		public Task<IEnumerable<Employee>> GetSecuritiesEmployeesAsync();

      //public Task<bool> UpdateBulkEmployee_DepartmentName(DepartmentCreated departmentCreated);
      Task<List<Employee>> GetByGroupAndDate(string group, string startDate, string endDate);
		public int CountActiveEmployee();

		public int[] KomposisiKaryawan();
		public Task<List<Employee>> GetEmployeesBirthday();
		public Task<List<Employee>> GetStafsBirthday();
		public Task<List<Employee>> GetByNameContains(string name);
		public Task<List<Employee>> GetByGroupName(string groupName);

	}
}
