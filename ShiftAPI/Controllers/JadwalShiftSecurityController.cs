using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiftAPI.Conversions;
using ShiftAPI.Services;
using SKM.Shared.Dtos;

namespace ShiftAPI.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class JadwalShiftSecurityController : ControllerBase {
		private readonly IJadwalShiftSecurityService jadwalShiftSecurityService;

		public JadwalShiftSecurityController(IJadwalShiftSecurityService jadwalShiftSecurityService) {
			this.jadwalShiftSecurityService = jadwalShiftSecurityService;
		}

		[HttpGet]
		public async Task<ActionResult<IEnumerable<JadwalShiftSecurityDTO>>> GetAsync() {
			try {
				var jadwal = await this.jadwalShiftSecurityService.GetJadwalShiftSecuritiesAsync();
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpGet("Inisial/{inisial}")]
		public async Task<ActionResult<JadwalShiftSecurityDTO>> GetByInisialAsync(string inisial) {
			try {
				var jadwal = await this.jadwalShiftSecurityService.GetByInisialAsync(inisial);
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPost]
		public async Task<ActionResult<JadwalShiftSecurityDTO>> PostAsync([FromBody] JadwalShiftSecurityDTO jadwalShiftSecurityDTO) {
			try {
				var jadwal = await jadwalShiftSecurityService.AddJadwalShiftSecurityAsync(jadwalShiftSecurityDTO);
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPut]
		public async Task<ActionResult<JadwalShiftSecurityDTO>> PutAsync(JadwalShiftSecurityDTO jadwalShiftSecurityDTO) {
			try {
				var jadwal = await jadwalShiftSecurityService.UpdateJadwalShiftSecurityAsync(jadwalShiftSecurityDTO);
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}
	}
}
