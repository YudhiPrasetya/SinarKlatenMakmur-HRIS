using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiftAPI.Conversions;
using ShiftAPI.Services;
using SKM.Shared.Dtos;

namespace ShiftAPI.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class JadwalShiftDepartemenController : ControllerBase {
		private readonly IJadwalShiftDepartemenService jadwalShiftDepartemenService;

		public JadwalShiftDepartemenController(IJadwalShiftDepartemenService jadwalShiftDepartemenService) {
			this.jadwalShiftDepartemenService = jadwalShiftDepartemenService;
		}

		[HttpGet]
		public async Task<ActionResult<List<JadwalShiftDepartemenDTO>>> Get() {
			try {
				var jadwal = await jadwalShiftDepartemenService.GetJadwalShiftDepartemenAsync();
				return Ok(jadwal);
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPost]
		public async Task<ActionResult<JadwalShiftDepartemenDTO>> Post([FromBody] JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO) {
			try {
				var jadwal = await jadwalShiftDepartemenService.AddJadwalShiftDepartemenAsync(jadwalShiftDepartemenDTO);
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPost("AddRange")]
		public async Task<ActionResult<JadwalShiftDepartemenDTO>> PostTange([FromBody] List<JadwalShiftDepartemenDTO> jadwalShiftDepartemenDTOs) {
			try {
				var jadwal = await jadwalShiftDepartemenService.AddRange(jadwalShiftDepartemenDTOs);
				return Ok(jadwal);
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPut]
		public async Task<ActionResult<JadwalShiftDepartemenDTO>> Put(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO) {
			try {
				var jadwal = await jadwalShiftDepartemenService.UpdateJadwalShiftDepartemenAsync(jadwalShiftDepartemenDTO);
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}
	}
}
