using ExceptionAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using SKM.Shared.Dtos;
using System.Text.Json;
using System.Text;
using ExceptionAPI.Conversions;
using ExceptionAPI.Model;
using ClosedXML.Excel;

namespace ExceptionAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class ExceptionController : ControllerBase {
      private readonly IExceptionService _exceptionService;
      private readonly ICacheService _chacheService;
      private static object _lock = new object();
      //private readonly IDistributedCache _cache;

      //public ExceptionController(IExceptionService exceptionService, IDistributedCache cache) {
      //   _exceptionService = exceptionService;
      //   _cache = cache;
      //}

      public ExceptionController(IExceptionService exceptionService, ICacheService chacheService) {
         _chacheService = chacheService;
         _exceptionService = exceptionService;
      }

      [HttpGet]
      //[Authorize]
      public IEnumerable<Model.Exception> ExceptionListAsync() {
         //var employeeList = await employeeService.GetEmployeeListAsync();
         //if(employeeList == null) {
         //	return StatusCode(StatusCodes.Status204NoContent, "Data karyawan tidak ada");
         //}
         //return StatusCode(StatusCodes.Status200OK, employeeList);

         //IEnumerable<Employee> employees = await employeeService.GetEmployeeListAsync();
         //return employees.ConvertToDtO();

         //List<Model.Exception> exceptions = new();
         //string cacheKey = "GetAllExceptionRedis";
         //byte[] cachedData = await _cache.GetAsync(cacheKey);
         //if (cachedData != null) {
         //   var cachedDataString = Encoding.UTF8.GetString(cachedData);
         //   exceptions = JsonSerializer.Deserialize<List<Model.Exception>>(cachedDataString);
         //}
         //else {
         //   exceptions = (List<Model.Exception>)await _exceptionService.GetExceptionListAsync();
         //   if (exceptions == null) {
         //      return StatusCode(StatusCodes.Status204NoContent, "Data kosong");
         //   }
         //   else {
         //      string cachedDataString = JsonSerializer.Serialize(exceptions);
         //      var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);
         //      DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
         //         .SetAbsoluteExpiration(DateTime.Now.AddDays(2))
         //         .SetSlidingExpiration(TimeSpan.FromHours(2));
         //      await _cache.SetAsync(cacheKey, dataToCache, options);
         //   }
         //}
         //return StatusCode(StatusCodes.Status200OK, exceptions);

         var cacheData = _chacheService.GetData<IEnumerable<Model.Exception>>("exception");
         if(cacheData != null) {
            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
         }
         lock (_lock) {
            var expirationTime = DateTimeOffset.Now.AddHours(2.0);
            cacheData = _exceptionService.GetExceptionListAsync();
            _chacheService.SetData<IEnumerable<Model.Exception>>("exception", cacheData, expirationTime);
         }
         return cacheData;
         //return StatusCode(StatusCodes.Status200OK, cacheData);
      }

      [HttpGet("{id}")]
      //[Authorize]
      public async Task<ActionResult<ExceptionDTO>> GetExceptionByIdAsync(int id) {
         //return employeeService.GetEmployeeByIdAsync(id);
         //var exception = await _exceptionService.GetExceptionByIdAsync(id);
         //if (exception == null) {
         //   return BadRequest();
         //}
         //return Ok(exception.ConvertToDTO());

         Model.Exception exception;
         var cacheData = _chacheService.GetData<IEnumerable<Model.Exception>>("exception");
         if(cacheData != null) {
            exception = cacheData.Where(e => e.Id == id).FirstOrDefault();
            return StatusCode(StatusCodes.Status200OK, exception);
         }
         exception = await _exceptionService.GetExceptionByIdAsync(id);
         return StatusCode(StatusCodes.Status200OK, exception);
      }

      [HttpGet("GroupAndDate/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<ExceptionDTO>>> GetByGroupAndDateRange(string group, string? startDate, string? endDate) {
         try {
            var listException = await _exceptionService.GetByGroupAndDate(group, startDate, endDate);
            return Ok(listException);
         }
         catch (System.Exception) {
            throw;
         }
      }

      [HttpPost]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<ExceptionDTO>> AddExceptionAsync([FromBody] ExceptionDTO exceptionDTO) {
         var newException = await _exceptionService.AddExceptionAsync(exceptionDTO);
         if (newException == null) {
            return NoContent();
         }
         _chacheService.RemoveData("exception");
         return Ok(newException.ConvertToDTO());
      }

      [HttpPut]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<ExceptionDTO>> UpdateExceptionAsync(ExceptionDTO exceptionDTO) {
         Model.Exception exception = await _exceptionService.UpdateExceptionAsync(exceptionDTO);
         _chacheService.RemoveData("exception");
         return exception.ConvertToDTO();
      }

      [HttpDelete("{id}")]
      //[Authorize(Roles = "Admnistrator")]
      public async Task<ActionResult<ExceptionDTO>> DeleteExceptionAsync(int id) {
         Model.Exception exception = await _exceptionService.DeleteExceptionAsync(id);
         _chacheService.RemoveData("exception");
         return exception.ConvertToDTO();
      }

      [HttpGet("ExportToExcel/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<AbsenMasukDTO>>> ExportToExcel(string group, string? startDate, string? endDate) {
         try {
            var listTidakHadir = await _exceptionService.GetByGroupAndDate(group, startDate, endDate);

            using (var wb = new XLWorkbook()) {
               var ws = wb.Worksheets.Add("Sheet1");

               ws.Cell(1, 1).Value = "Grup Kerja";
               ws.Cell(1, 2).Value = "NIK";
               ws.Cell(1, 3).Value = "Nama";
               ws.Cell(1, 4).Value = "Keterangan Tidak Masuk";
               ws.Cell(1, 5).Value = "Dari";
               ws.Cell(1, 6).Value = "Sampai";

               for (int r = 1; r <= listTidakHadir.Count - 1; r++) {
                  ws.Cell(r + 1, 1).Value = listTidakHadir[r].GrupKerja;
                  ws.Cell(r + 1, 2).Value = listTidakHadir[r].NIK;
                  ws.Cell(r + 1, 3).Value = listTidakHadir[r].Nama;
                  ws.Cell(r + 1, 4).Value = listTidakHadir[r].ExceptionName;
                  ws.Cell(r + 1, 5).Value = listTidakHadir[r].StartDate.Value.Date.ToString("dd-MM-yyyy");
                  ws.Cell(r + 1, 6).Value = listTidakHadir[r].EndDate.Value.Date.ToString("dd-MM-yyyy");
               }
               // MemoryStream XLSStream = new();
               // wb.SaveAs(XLSStream);

               using (var stream = new MemoryStream()) {
                  wb.SaveAs(stream);
                  var content = stream.ToArray();
                  return File(
                     content,
                     "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                     "KaryawanTidakHadir.xlsx"
                  );
               }

            }
            //return Ok(listAbsenMasuk);
         }
         catch (System.Exception) {
            throw;
         }
      }

   }
}
