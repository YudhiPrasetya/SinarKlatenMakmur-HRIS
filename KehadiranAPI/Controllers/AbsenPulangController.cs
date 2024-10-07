using KehadiranAPI.Conversions;
using KehadiranAPI.Model;
using KehadiranAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;

namespace KehadiranAPI.Controllers {
   [Route("api/[controller]")]
   [ApiController]
   public class AbsenPulangController : ControllerBase {
      private readonly AbsenPulangService absenPulangService;

      public AbsenPulangController(AbsenPulangService absenPulangService)
      {
         this.absenPulangService = absenPulangService;
      }

      [HttpPost]
      public async Task<ActionResult<AbsenPulangDTO?>> AddAbsenPulang([FromBody] AbsenPulangDTO absenPulangDTO) {
         try {
            AbsenPulang absenPulang = await this.absenPulangService.AddAbsenPulang(absenPulangDTO);
            return Ok(absenPulang?.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpGet]
      [Route("NIK/{nik}")]
      public async Task<ActionResult<AbsenPulangDTO?>> GetByNIKTgl(string nik) {
         try {
            var absenPulang = await this.absenPulangService.GetByNIKTgl(nik);
            return Ok(absenPulang?.ConvertToDTO());
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpGet("DateRange/{startDate}/{endDate}")]
      public async Task<ActionResult<List<AbsenPulangDTO>>> GetDateRange(string? startDate, string? endDate) {
         try {
            var listAbsenPulang = await this.absenPulangService.GetByRangeDate(startDate, endDate);
            return Ok(listAbsenPulang.ConvertToDTO());
			}
         catch (Exception) {

            throw;
         }
      }

   }
}
