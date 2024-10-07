using ExceptionsTypeAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System.Text.Json;
using System.Text;
using ExceptionsTypeAPI.Model;
using SKM.Shared.Dtos;
using ExceptionsTypeAPI.Conversions;

namespace ExceptionsTypeAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class ExceptionTypeController : ControllerBase {
      private readonly IExceptionTypeService exceptionTypeService;
      private readonly ICacheService _cacheService;
      //private readonly IDistributedCache _cache;

      public ExceptionTypeController(IExceptionTypeService ExceptionTypeService, ICacheService cacheService) {
         exceptionTypeService = ExceptionTypeService;
         _cacheService = cacheService;
         //_cache = cache;
      }

      [HttpGet]
      public async Task<ActionResult> GetAllAsync() {
         try {
            //List<ExceptionType> exceptionTypes = new();
            //string cacheKey = "GetAllExceptionTypeRedis";
            //byte[] cachedData = await _cache.GetAsync(cacheKey);
            //if (cachedData != null) {
            //   var cachedDataString = Encoding.UTF8.GetString(cachedData);
            //   exceptionTypes = JsonSerializer.Deserialize<List<ExceptionType>>(cachedDataString);
            //}
            //else {
            //   exceptionTypes = await exceptionTypeService.GetExceptionTypeListAsync();
            //   if (exceptionTypes == null) {
            //      return StatusCode(StatusCodes.Status204NoContent, "Data kosong.");
            //   }
            //   else {
            //      string cachedDataString = JsonSerializer.Serialize(exceptionTypes);
            //      var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);
            //      DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
            //         .SetAbsoluteExpiration(DateTime.Now.AddDays(2))
            //         .SetSlidingExpiration(TimeSpan.FromHours(2));
            //      await _cache.SetAsync(cacheKey, dataToCache, options);
            //   }
            //}
            //return StatusCode(StatusCodes.Status200OK, exceptionTypes);

            var cacheData = _cacheService.GetData<IEnumerable<ExceptionType>>("exceptionType");
            if (cacheData != null) {
               return StatusCode(StatusCodes.Status200OK, cacheData);
            }
            //lock (_lock) {
            var expirationTime = DateTimeOffset.Now.AddHours(2.0);
            cacheData = await exceptionTypeService.GetExceptionTypeListAsync();
            _cacheService.SetData<IEnumerable<ExceptionType>>("exceptionType", (IEnumerable<ExceptionType>)cacheData, expirationTime);
            //}

            return StatusCode(StatusCodes.Status200OK, cacheData);

         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database!");
         }
      }

      [HttpGet("{id}")]
      //[Authorize]
      public async Task<ActionResult<ExceptionTypeDTO>> GetExceptionTypeByIdAsync(int id) {
         //return employeeService.GetEmployeeByIdAsync(id);
         //var exception = await _exceptionService.GetExceptionByIdAsync(id);
         //if (exception == null) {
         //   return BadRequest();
         //}
         //return Ok(exception.ConvertToDTO());

         ExceptionType exceptionType;
         var cacheData = _cacheService.GetData<IEnumerable<ExceptionType>>("exceptionType");
         if (cacheData != null) {
            exceptionType = cacheData.Where(e => e.Id == id).FirstOrDefault();
            return StatusCode(StatusCodes.Status200OK, exceptionType);
         }
         exceptionType = await exceptionTypeService.GetExceptionTypeByIdAsync(id);
         return StatusCode(StatusCodes.Status200OK, exceptionType);
      }

      [HttpPost]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<ExceptionTypeDTO>> AddExceptionAsync([FromBody] ExceptionTypeDTO exceptionTypeDTO) {
         ExceptionType newExceptionType = await exceptionTypeService.AddExceptionType(exceptionTypeDTO);
         if (newExceptionType == null) {
            return NoContent();
         }
         _cacheService.RemoveData("exceptionType");
         return Ok(newExceptionType.ConvertToDTO());
      }

      [HttpPut]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<ExceptionTypeDTO>> UpdateExceptionTypeAsync(ExceptionTypeDTO exceptionTypeDTO) {
         ExceptionType exceptionType = await exceptionTypeService.UpdateExceptionTypeAsync(exceptionTypeDTO);
         _cacheService.RemoveData("exceptionType");
         return exceptionType.ConvertToDTO();
      }

      [HttpDelete("{id}")]
      //[Authorize(Roles = "Admnistrator")]
      public async Task<ActionResult<ExceptionTypeDTO>> DeleteExceptionTypeAsync(int id) {
         ExceptionType exceptionType = await exceptionTypeService.DeleteExceptionTypeAsync(id);
         _cacheService.RemoveData("exceptionType");
         return exceptionType.ConvertToDTO();
      }

      [HttpGet("ExceptionName/{val}")]
      public async Task<ActionResult<List<ExceptionTypeDTO>>> GetByVal(string val) {
         List<ExceptionType> exceptionTypes = await exceptionTypeService.GetExceptionTypeListByValueAsync(val);
         _cacheService.RemoveData("exceptionType");
         return Ok(exceptionTypes.ConvertToDtO());

      }

   }
}
