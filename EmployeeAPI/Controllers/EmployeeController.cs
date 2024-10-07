using AuthAPI;
using ClosedXML.Excel;
using EmployeeAPI.Conversions;
using EmployeeAPI.Model;
using EmployeeAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using SKM.Shared.Dtos;
using System.Text;
using System.Text.Json;

namespace EmployeeAPI.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    //[JwtTokenValidateAttribute]
    //[Authorize]
   public class EmployeeController : ControllerBase
	{
		private readonly IEmployeeService employeeService;
      private readonly ICacheService _cacheService;
      private static object _lock = new();
		//private readonly IDistributedCache _cache;

		public EmployeeController(IEmployeeService _employeeService, ICacheService cacheService)
		{
			employeeService = _employeeService;
         _cacheService = cacheService;
         //_cache = cache;
      }

		[HttpGet]
		//[Authorize]
		public IEnumerable<Employee>? EmployeeListAsync()
		{
         //var employeeList = await employeeService.GetEmployeeListAsync();
         //if (employeeList == null) {
         //   return StatusCode(StatusCodes.Status204NoContent, "Data karyawan tidak ada");
         //}
         //return StatusCode(StatusCodes.Status200OK, employeeList);

         //IEnumerable<Employee> employees = await employeeService.GetEmployeeListAsync();
         //return employees.ConvertToDtO();

         var cacheData = _cacheService.GetData<IEnumerable<Employee>>("employee");
         if (cacheData != null ) {
            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
         }
         lock (_lock) {
            var expirationTime = DateTimeOffset.Now.AddHours(2.0);
            cacheData = employeeService.GetEmployeeListAsync();
            _cacheService.SetData<IEnumerable<Employee>>("employee", cacheData, expirationTime);
            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
         }
      }

      [HttpGet]
      [Route("CountActiveEmployee")]
      public int CountActiveEmployee() {
         return employeeService.CountActiveEmployee();
      }

      [HttpGet]
      [Route("KomposisiKaryawan")]
      public int[] KomposisiKaryawan() {
         return employeeService.KomposisiKaryawan();
      }

      [HttpGet]
      [Route("GetEmployeesBirthday")]
      public async Task<List<Employee>> GetEmployeesBirthday() {
         return await employeeService.GetEmployeesBirthday();
      }

      [HttpGet]
      [Route("GetStafsBirthday")]
      public async Task<List<Employee>> GetStafsBirthday() {
         return await employeeService.GetStafsBirthday();
      }

      [HttpGet("{id}")]
		//[Authorize]
		public async Task<ActionResult<EmployeeDTO>> GetEmployeeByIdAsync(int id)
		{
         //return employeeService.GetEmployeeByIdAsync(id);
         Employee employee;
         var cacheData = _cacheService.GetData<IEnumerable<Employee>>("employee");
         if (cacheData != null) {
            employee = cacheData.Where(e => e.EmployeeId== id).FirstOrDefault();
            return StatusCode(StatusCodes.Status200OK, employee);
         }
         employee = await employeeService.GetEmployeeByIdAsync(id);
         return StatusCode(StatusCodes.Status200OK, employee);
      }

      [HttpGet("NIK/{nik}")]
      //[Authorize]
      public async Task<ActionResult<EmployeeDTO>> GetEmployeeByNIKAsync(string nik) {
         //return employeeService.GetEmployeeByIdAsync(id);
         Employee employee;
         var cacheData = _cacheService.GetData<IEnumerable<Employee>>("employee");
         if (cacheData != null) {
            employee = cacheData.Where(e => e.NIK == nik).FirstOrDefault();
            return StatusCode(StatusCodes.Status200OK, employee);
         }
         employee = await employeeService.GetEmployeeByNIKAsync(nik);
         return StatusCode(StatusCodes.Status200OK, employee);
      }

      [HttpGet("NIKForRTFingerPrint/{nik}")]
      public async Task<ActionResult<EmployeeDTO>> GetEmpForRTFingerPrint(string nik) {
         Employee? employee;
         var cacheData = _cacheService.GetData<IEnumerable<Employee>>("employee");
         if (cacheData != null) {
            employee = cacheData.Where(e => e.NIK == nik).FirstOrDefault();
            return StatusCode(StatusCodes.Status200OK, employee);
         }
         employee = await employeeService.GetEmployeeByNIKAsync(nik);
         return StatusCode(StatusCodes.Status200OK, employee);
      }

      [HttpGet("group/{groupId}")]
      //[Authorize]
      public async Task<ActionResult<List<EmployeeDTO>>> GetEmployeesByGroupIdAsync(int groupId) {
         //return employeeService.GetEmployeeByIdAsync(id);
         IEnumerable<Employee> employees;
         var cacheData = _cacheService.GetData<IEnumerable<Employee>>("employee");
         if (cacheData != null) {
            employees = cacheData.Where(e => e.GroupID == groupId).ToList();
            return StatusCode(StatusCodes.Status200OK, employees);
         }
         employees = await employeeService.GetEmployeesByGroupId(groupId);
         return StatusCode(StatusCodes.Status200OK, employees);
      }

      [HttpPost]
		//[Authorize(Roles = "Administrator")]
		public async Task<ActionResult<EmployeeDTO>> AddEmployeeAsync([FromBody]EmployeeDTO employeeDTO)
		{
         var newEmployee = await employeeService.AddEmployeeAsync(employeeDTO.ConvertToModel());
         if (newEmployee == null) {
            return NoContent();
         }
         _cacheService.RemoveData("employee");
         return Ok(newEmployee.ConvertToDTO());
      }

		[HttpPut]
		//[Authorize(Roles = "Administrator")]
		public async Task<ActionResult<EmployeeDTO>> UpdateEmployeeAsync(EmployeeDTO employeeDTO)
		{
         Employee employee = await employeeService.UpdateEmployeeAsync(employeeDTO.ConvertToModel());
         _cacheService.RemoveData("employee");
         return employee.ConvertToDTO();
      }

		[HttpDelete("{id}")]
		//[Authorize(Roles = "Admnistrator")]
		public async Task<ActionResult<EmployeeDTO>> DeleteEmployeeAsync(int id)
		{
         Employee employee = await employeeService.DeleteEmployeeAsync(id);
         _cacheService.RemoveData("employee");
         return employee.ConvertToDTO();
      }

      [HttpGet("GetSecurities")]
      //[Route("GetSecurities")]
      public async Task<ActionResult<EmployeeDTO>> GetSecurities() {
         var securities = await employeeService.GetSecuritiesEmployeesAsync();
         return Ok(securities.ConvertToDtO());
      }

      [HttpGet("GroupAndDate/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<EmployeeDTO>>> GetByGroupAndDateRange(string group, string? startDate, string? endDate) {
         try {
            var listException = await employeeService.GetByGroupAndDate(group, startDate, endDate);
            return Ok(listException);
         }
         catch (System.Exception) {
            throw;
         }
      }

      [HttpGet("ExportToExcel/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<EmployeeDTO>>> ExportToExcel(string group, string? startDate, string? endDate) {
         try {
            var listEmp = await employeeService.GetByGroupAndDate(group, startDate, endDate);

            using (var wb = new XLWorkbook()) {
               var ws = wb.Worksheets.Add("Sheet1");

               ws.Cell(1, 1).Value = "Grup Kerja";
               ws.Cell(1, 2).Value = "NIK";
               ws.Cell(1, 3).Value = "Nama";
               ws.Cell(1, 4).Value = "Awal Kontrak";
               ws.Cell(1, 5).Value = "Akhir Kontrak";
               ws.Cell(1, 6).Value = "Akhir(hari)";

               for (int r = 1; r <= listEmp.Count - 1; r++) {
                  ws.Cell(r + 1, 1).Value = listEmp[r].GroupName;
                  ws.Cell(r + 1, 2).Value = listEmp[r].NIK;
                  ws.Cell(r + 1, 3).Value = listEmp[r].Name;
                  ws.Cell(r + 1, 4).Value = listEmp[r].ContractStartDate.Value.Date.ToString("dd-MM-yyyy");
                  ws.Cell(r + 1, 5).Value = listEmp[r].ContractEndDate.Value.Date.ToString("dd-MM-yyyy");
                  ws.Cell(r + 1, 6).Value = DateTime.Now.Date - listEmp[r].ContractEndDate.Value.Date;
               }
               // MemoryStream XLSStream = new();
               // wb.SaveAs(XLSStream);

               using (var stream = new MemoryStream()) {
                  wb.SaveAs(stream);
                  var content = stream.ToArray();
                  return File(
                     content,
                     "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                     "KaryawanAkhirKontrak.xlsx"
                  );
               }

            }
            //return Ok(listAbsenMasuk);
         }
         catch (System.Exception) {
            throw;
         }
      }

		[HttpGet("NameContains/{name}")]
		//[Authorize]
		public async Task<ActionResult<List<EmployeeDTO>>> GetNameContains(string name) {
			IEnumerable<Employee> employees;
			employees = await employeeService.GetByNameContains(name);
			return StatusCode(StatusCodes.Status200OK, employees.ConvertToDtO());
		}

      [HttpGet("GroupName/{groupName}")]
      //[Authorize]
      public async Task<ActionResult<List<EmployeeDTO>?>> GetByGroupName(string groupName) {
         //return employeeService.GetEmployeeByIdAsync(id);
         List<Employee> employees;
         var cacheData = _cacheService.GetData<List<Employee>?>("employee");
         if (cacheData != null) {
            employees = cacheData.Where(e => e.GroupName == groupName).ToList();
            return StatusCode(StatusCodes.Status200OK, employees);
         }
         employees = await employeeService.GetByGroupName(groupName);
         return StatusCode(StatusCodes.Status200OK, employees.ConvertToDtO());
      }
   }
}
