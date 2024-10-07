using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PenghasilanTidakKenaPajakAPI.Conversions;
using PenghasilanTidakKenaPajakAPI.Model;
using PenghasilanTidakKenaPajakAPI.Services;
using SKM.Shared.Dtos;

namespace PenghasilanTidakKenaPajakAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]

   public class PTKPController : ControllerBase {
      private readonly IPTKPService _PTKPService;
      private readonly ICacheService _cacheService;
      private static object _lock = new();

      public PTKPController(IPTKPService PTKPService, ICacheService cacheService) {
         _PTKPService = PTKPService;
         _cacheService = cacheService;
      }

      [HttpGet]
      //[Authorize]
      //public async Task<ActionResult<IEnumerable<DepartmentDTO>>> DepartmentListAsync()
      public IEnumerable<PenghasilanTidakKenaPajak> GetPTKPListAsync() {
         try {
            var cacheData = _cacheService.GetData<IEnumerable<PenghasilanTidakKenaPajak>>("ptkp");
            if (cacheData != null) {
               //return StatusCode(StatusCodes.Status200OK, cacheData);
               return cacheData;
            }
            lock (_lock) {
               var expirationTime = DateTimeOffset.Now.AddHours(2.0);
               cacheData = (IEnumerable<PenghasilanTidakKenaPajak>?)_PTKPService.GetPTKPListAsync();
               _cacheService.SetData<IEnumerable<PenghasilanTidakKenaPajak>>("ptkp", cacheData, expirationTime);
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

      [HttpGet("{id}")]
      public async Task<ActionResult<PenghasilanTidakKenaPajak>> GetPTKPByIdAsync(int id) {
         try {
            PenghasilanTidakKenaPajak ptkp;
            var cacheData = _cacheService.GetData<IEnumerable<PenghasilanTidakKenaPajak>>("ptkp");
            if (cacheData != null) {
               ptkp = cacheData.Where(e => e.Id == id).FirstOrDefault();
               return StatusCode(StatusCodes.Status200OK, ptkp);
            }
            ptkp = await _PTKPService.GetPTKPByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, ptkp);
         }
         catch (Exception) {
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database");
         }
      }

      [HttpPost]
      public async Task<ActionResult<PenghasilanTidakKenaPajak>> AddPTKP([FromBody] PenghasilanTidakKenaPajakDTO ptkpDTO) {
         try {
            var newPTKP = await _PTKPService.AddPTKPAsync(ptkpDTO.ConvertToModel());
            if (newPTKP == null) {
               return NoContent();
            }
            _cacheService.RemoveData("ptkp");
            return Ok(newPTKP.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpPut()]
      public async Task<ActionResult<PenghasilanTidakKenaPajakDTO>> UpdatePTKPAsync(PenghasilanTidakKenaPajakDTO ptkpDTO) {
         PenghasilanTidakKenaPajak ptkp = await _PTKPService.UpdatePTKPAsync(ptkpDTO.ConvertToModel());
         _cacheService.RemoveData("ptkp");
         //rabbitMqProducer.SendDepartmentMessage(department);
         return ptkp.ConvertToDTO();
      }

      [HttpDelete("{id}")]
      //[Authorize(Roles = "Administrator")]
      public async Task<ActionResult<PenghasilanTidakKenaPajakDTO>> DeletePTKPAsync(int id) {
         //return departmentService.DeleteDepartmentAsync(id);
         PenghasilanTidakKenaPajak ptkp = await _PTKPService.DeletePTKPAsync(id);

         _cacheService.RemoveData("ptkp");
         return ptkp.ConvertToDTO();

      }
   }
}
