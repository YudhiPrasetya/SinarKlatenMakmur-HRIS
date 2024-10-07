using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;
using UpahMinimumProvinsiAPI.Conversions;
using UpahMinimumProvinsiAPI.Model;
using UpahMinimumProvinsiAPI.Services;

namespace UpahMinimumProvinsiAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class UMPController : ControllerBase {
      private readonly IUMPService _uMPService;
      private readonly ICacheService _cacheService;
      private static object _lock = new();

      public UMPController(IUMPService uMPService, ICacheService cacheService)
        {
         _uMPService = uMPService;
         _cacheService = cacheService;
      }

      [HttpGet]
      //[Authorize]
      //public async Task<ActionResult<IEnumerable<DepartmentDTO>>> DepartmentListAsync()
      public IEnumerable<UpahMinimumProvinsi> GetUMPListAsync() {
         try {
            var cacheData = _cacheService.GetData<IEnumerable<UpahMinimumProvinsi>>("ump");
            if (cacheData != null) {
               //return StatusCode(StatusCodes.Status200OK, cacheData);
               return cacheData;
            }
            lock (_lock) {
               var expirationTime = DateTimeOffset.Now.AddHours(2.0);
               cacheData = (IEnumerable<UpahMinimumProvinsi>?)_uMPService.GetUMPListAsync();
               _cacheService.SetData<IEnumerable<UpahMinimumProvinsi>>("ump", cacheData, expirationTime);
            }

            //return StatusCode(StatusCodes.Status200OK, cacheData);
            return cacheData;
            //lock (_lock) {

         }
         catch (Exception) {
            //return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database!");
            throw;
         }
      }

      [HttpGet("{id:int}")]
      //[Authorize]
      public async Task<ActionResult<UpahMinimumProvinsi>> GetUMPByIdAsync(int id) {
         try {
            UpahMinimumProvinsi ump;
            var cacheData = _cacheService.GetData<IEnumerable<UpahMinimumProvinsi>>("ump");
            if (cacheData != null) {
               ump = cacheData.Where(e => e.Id == id).FirstOrDefault();
               return StatusCode(StatusCodes.Status200OK, ump);
            }
            ump = await _uMPService.GetUMPByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, ump);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpPost()]
      public async Task<ActionResult<UpahMinimumProvinsiDTO>> AddUMP([FromBody] UpahMinimumProvinsiDTO umpDTO) {
         try {
            var newUMP = await _uMPService.AddUMP(umpDTO);
            if (newUMP == null) {
               return NoContent();
            }
            _cacheService.RemoveData("ump");
            return Ok(newUMP.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPut()]
      public async Task<ActionResult<UpahMinimumProvinsiDTO>> UpdateUMPAsync(UpahMinimumProvinsiDTO umpDTO) {
         UpahMinimumProvinsi ump = await _uMPService.UpdateUMPAsync(umpDTO);
          _cacheService.RemoveData("ump");
         //rabbitMqProducer.SendDepartmentMessage(department);
         return ump.ConvertToDTO();
      }

      [HttpDelete("{id}")]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<UpahMinimumProvinsiDTO>> DeleteUMPAsync(int id) {
         //return departmentService.DeleteDepartmentAsync(id);
         UpahMinimumProvinsi ump = await _uMPService.DeleteUMPAsync(id);

         _cacheService.RemoveData("ump");
         return ump.ConvertToDTO();

      }

   }
}
