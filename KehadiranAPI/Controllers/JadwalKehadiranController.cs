using AuthAPI;
using KehadiranAPI.Conversions;
using KehadiranAPI.Model;
using KehadiranAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;

namespace KehadiranAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
   //[JwtTokenValidateAttribute]
   //[Authorize]
   public class JadwalKehadiranController : ControllerBase {
      private readonly IJadwalKehadiranService jadwalKehadiranService;

      public JadwalKehadiranController(IJadwalKehadiranService jadwalKehadiranService) {
         this.jadwalKehadiranService = jadwalKehadiranService;
      }

      [HttpGet]
      public async Task<ActionResult<List<JadwalKehadiranDTO>>> Get() {
         var result = await jadwalKehadiranService.GetJadwalKehadiran();
         return Ok(result);
      }

      [HttpPost]
      public async Task<IActionResult> AddRange([FromBody] List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         var result = await jadwalKehadiranService.AddJadwalKehadiranRange(jadwalKehadiranDTOs);
         return Ok(result);
      }

      [HttpPut]
      public async Task<IActionResult> Update(JadwalKehadiranDTO jadwalKehadiranDTO) {
         var rst = await jadwalKehadiranService.UpdateJadwalKehadiran(jadwalKehadiranDTO);
         return Ok(rst);
      }

      [HttpPut("updaterange")]
      public async Task<IActionResult> UpdateRange(List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         var rst = await jadwalKehadiranService.UpdateJadwalKehadiranRange(jadwalKehadiranDTOs);
         return Ok(rst);
      }

      [HttpGet("get_by_group_and_range_periode/{group}/{month}/{year}")]
      public async Task<ActionResult<List<JadwalKehadiranDTO>>> GetByGroupAndRangePeriode(string group, int month, int year) {
         var rst = await jadwalKehadiranService.GetByGroupAndRangePeriode(group, month, year);
         return Ok(rst);
      }
      [HttpGet("GetByNIKAndDate/{nik}/{tgl}")]
      public async Task<ActionResult<JadwalKehadiranDTO>> GetByNIKAndDate(string nik, string tgl) {
         var rst = await jadwalKehadiranService.GetByNIKAndDate(nik, tgl);
         return Ok(rst);
      }

      [HttpPut("Update")]
      public async Task<ActionResult<JadwalKehadiranDTO>> UpdateJadwal(JadwalKehadiranDTO jadwalKehadiranDTO) {
         var rst = await jadwalKehadiranService.Update(jadwalKehadiranDTO);
         return Ok(rst);
      }

      [HttpGet("GetByNIKAndYearMonth/{nik}/{year}/{month}")]
      public async Task<ActionResult<List<int>>> GetByNIKAndMonthYear(string nik, int year, int month) {
         var rst = await jadwalKehadiranService.GetByNIKAndMonthYear(nik, year, month);
         return Ok(rst);
      }

      [HttpGet("GetByNamaAndDate/{nama}/{strDate}")]
      public async Task<ActionResult<JadwalKehadiranDTO?>> GetByNamaAndDate(string nama, string strDate) {
         var rst = await jadwalKehadiranService.GetByNamaAndDate(nama, strDate);
         return Ok(rst);
      }

      [HttpGet("Terlambat/{startDate}/{endDate}")]
      public async Task<ActionResult<List<JadwalKehadiranDTO>?>> GetTerlambatByDateRange(string startDate, string endDate) {
         var rst = await jadwalKehadiranService.GetTerlambat(startDate, endDate);
         return rst == null ? Ok(default) : Ok(rst);
         //return Ok(rst);
      }

      [HttpPost("Terlambat/Add")]
      public async Task<ActionResult<JadwalKehadiranDTO>> AddTerlambat([FromBody]JadwalKehadiranDTO jadwalKehadiranDTO) {
         var rst = await jadwalKehadiranService.AddKeterlambatan(jadwalKehadiranDTO);
         return Ok(rst);
      }

		[HttpPut("Terlambat/Update")]
		public async Task<ActionResult<JadwalKehadiranDTO>> UpdateTerlambat(JadwalKehadiranDTO jadwalKehadiranDTO) {
			var rst = await jadwalKehadiranService.UpdateKeterlambatan(jadwalKehadiranDTO);
			return Ok(rst);
		}

      [HttpPatch("PatchTerlambat/{id}")]
      public async Task<ActionResult<JadwalKehadiranDTO?>> PatchTerlambat([FromRoute]int id, [FromBody] JadwalKehadiranDTO dataTerlambat) {
         var rst = await jadwalKehadiranService.PatchKeterlambatan(id, dataTerlambat); 
         return Ok(rst);
      }

      [HttpGet("GetByDateRange/{startDate}/{endDate}")]
      public async Task<ActionResult<List<JadwalKehadiranDTO>>> GetByDateRange(string startDate, string endDate) {
         var rst = await jadwalKehadiranService.GetByDateRange(startDate, endDate);
         return Ok(rst);
      }

      [HttpGet("GetByGroupAndDateRange/{group}/{startDate}/{endDate}")]
      public async Task<ActionResult<List<JadwalKehadiranDTO>>> GetByGroupAndDateRange(string group, string startDate, string endDate) {
         var rst = await jadwalKehadiranService.GetByGroupAndDateRange(group, startDate, endDate);
         return Ok(rst);
      }

		[HttpPut("UbahJam")]
		public async Task<ActionResult<JadwalKehadiranDTO>> UbahJam(JadwalKehadiranDTO jadwalKehadiranDTO) {
			try {
				var hadir = await jadwalKehadiranService.UbahJam(jadwalKehadiranDTO);
				return Ok(hadir!);
			}
			catch (Exception) {

				throw;
			}
		}

      [HttpPatch("PatchMultiKeterlambatan")]
      public async Task<ActionResult<List<JadwalKehadiranDTO>?>> PatchMultiKeterlambatan([FromBody]List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         try {
            var result = await jadwalKehadiranService.PatchMultiKeterlambatan(jadwalKehadiranDTOs);
            return Ok(result);
         }
         catch (Exception) {

            throw;
         }
      }

      [HttpGet("GetByPeriode/{bulan}/{tahun}")]
      public async Task<ActionResult<List<JadwalKehadiranDTO>?>> GetByPeriode(int bulan, int tahun) {
         var rst = await jadwalKehadiranService.GetByPeriode(bulan, tahun);
         return Ok(rst);
      }
	}
}
