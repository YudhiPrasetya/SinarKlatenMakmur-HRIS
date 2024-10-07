using EmployeeAPI.Data;
using EmployeeAPI.Model;
using SKM.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using EmployeeAPI.Conversions;
using EmployeeAPI.Services;
using SKM.Shared.Models;
using MassTransit;
using System.Reflection.Metadata.Ecma335;
using SKM.Shared.Helpers;

namespace EmployeeAPI.Services
{
	public class EmployeeService : IEmployeeService, IConsumer<DepartmentCreated>
	{
		private readonly EmployeeDbContextClass _dbContext;

		public EmployeeService(EmployeeDbContextClass dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task<Employee> AddEmployeeAsync(Employee employee) {
			//throw new NotImplementedException();
			var rst = await _dbContext.Employees.AddAsync(employee);
			await _dbContext.SaveChangesAsync();

			return rst.Entity;
		}

      public async Task<Employee> DeleteEmployeeAsync(int id)
		{
			//throw new NotImplementedException();
			var employee = await _dbContext.Employees.FindAsync(id);
			var rst = _dbContext.Remove(employee);
			await _dbContext.SaveChangesAsync();

			return employee;
		}

		public async Task<Employee> GetEmployeeByIdAsync(int id)
		{
			//throw new NotImplementedException();
			return await _dbContext.Employees.FindAsync(id);
		}

		public IEnumerable<Employee>? GetEmployeeListAsync()
		{
			//throw new NotImplementedException();
			return _dbContext.Employees.Where(e => e.GroupName != "RESIGN" && e.IsActive == true).ToList();
		}

		public int CountActiveEmployee() {
			return _dbContext.Employees.Where(e => e.GroupName != "RESIGN" && !e.GroupName!.Contains("PKL") && e.IsActive == true).Count();
		}

		public int[] KomposisiKaryawan() {
			int totalLaki2 = _dbContext.Employees.Where(e => e.GroupName != "RESIGN" && !e.GroupName!.Contains("PKL") && e.IsActive == true && e.Gender == true).Count();

			int totalPerempuan = _dbContext.Employees.Where(e => e.GroupName != "RESIGN" && !e.GroupName!.Contains("PKL") && e.IsActive == true && e.Gender == false).Count();

			int[] kompKaryawan = new int[] { totalLaki2, totalPerempuan };

			return kompKaryawan;
		}

   //   public async Task<bool> UpdateBulkEmployee_DepartmentName(DepartmentCreated departmentCreated) {
			////throw new NotImplementedException();
			//var employees = _dbContext.Employees.Where(e => e.DepartmentId == departmentCreated.DepartmentID);
			//await employees.ForEachAsync(e => e.DepartmentName = departmentCreated.DepartmentName);
			//_dbContext.BulkUpdate(employees);
			//return true;
   //   }

      public async Task<Employee> UpdateEmployeeAsync(Employee employee)
		{
			//throw new NotImplementedException();
			var rst = _dbContext.Employees.Update(employee);
			await _dbContext.SaveChangesAsync();

			return rst.Entity;
		}

      public async Task Consume(ConsumeContext<DepartmentCreated> context) {
			//throw new NotImplementedException();
			var dataFromDepartmentProducer = context.Message;
			var employees = _dbContext.Employees.Where(e => e.DepartmentId == dataFromDepartmentProducer.DepartmentID).ToList();
			employees.ForEach(e => e.DepartmentName = dataFromDepartmentProducer.DepartmentName);
			//await _dbContext.BulkUpdateAsync(employees);
			_dbContext.UpdateRange(employees);
			await _dbContext.SaveChangesAsync();

      }

      public async Task<IEnumerable<Employee>> GetEmployeesByGroupId(int groupId) {
			//throw new NotImplementedException();
			return await _dbContext.Employees.Where(e => e.GroupID == groupId).ToListAsync();
      }

      public async Task<Employee?> GetEmployeeByNIKAsync(string nik) {
			//throw new NotImplementedException();
			return await _dbContext.Employees.Where(e => e.NIK == nik).FirstOrDefaultAsync();
      }

		public async Task<IEnumerable<Employee>> GetSecuritiesEmployeesAsync() {
			//throw new NotImplementedException();
			var employees = await _dbContext.Employees.Where(e => e.GroupName == "SECURITY PRIA" || e.GroupName == "SECURITY WANITA" && e.GroupName != "RESIGN").ToListAsync();

			return employees;

		}

      public async Task<List<Employee>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         string strGroup = (group != "All" ? group.Replace("-", "/") : group);
         DateTime tgl1 = DateConversions.StringToDate(startDate);
         DateTime tgl2 = DateConversions.StringToDate(endDate);

         if (strGroup == "All") {
            return await this._dbContext.Employees.Where(k => k.ContractEndDate.Value.Date >= tgl1.Date && k.ContractEndDate.Value.Date <= tgl2.Date).ToListAsync();
         }
         else {
            return await _dbContext.Employees.Where(k => k.GroupName == strGroup && k.ContractEndDate.Value.Date >= tgl1.Date && k.ContractEndDate.Value.Date <= tgl2.Date).ToListAsync();
         }

      }

		public async Task<List<Employee>> GetEmployeesBirthday() {
			return await _dbContext.Employees.Where(e => e.DateBirth!.Value.Month == DateTime.Now.Month && e.DateBirth.Value.Day == DateTime.Now.Day && e.GroupName != "RESIGN" && e.GroupName!.Contains("PKL") == false && e.GroupName.Contains("STAFF") == false && e.IsActive == true).ToListAsync();
		}

      public async Task<List<Employee>> GetStafsBirthday() {
         return await _dbContext.Employees.Where(e => e.DateBirth.Value.Month == DateTime.Now.Month && e.DateBirth.Value.Day == DateTime.Now.Day && e.GroupName != "RESIGN" && e.GroupName!.Contains("PKL") == false && e.GroupName.Contains("STAFF") == false && e.IsActive == true).ToListAsync();
      }

		public async Task<List<Employee>> GetByNameContains(string name) {
			return await _dbContext.Employees.Where(e => EF.Functions.Like(e.Name!, $"%{name}%")).ToListAsync();
		}

      public async Task<List<Employee>> GetByGroupName(string groupName) {
			return await _dbContext.Employees.Where(e => e.GroupName == groupName).ToListAsync();
      }

   }
}
