using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiftAPI.Conversions;
using ShiftAPI.Services;
using SKM.Shared.Dtos;

namespace ShiftAPI.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class JadwalShiftKaryawanController : ControllerBase {
		private readonly IJadwalShiftKaryawanService jadwalShiftKaryawanService;

		public JadwalShiftKaryawanController(IJadwalShiftKaryawanService jadwalShiftKaryawanService)
      {
			this.jadwalShiftKaryawanService = jadwalShiftKaryawanService;
		}

		[HttpGet]
		public async Task<ActionResult<List<JadwalShiftKaryawanDTO>>> Get() {
			try {
				var jadwal = await jadwalShiftKaryawanService.GetJadwalShiftKaryawanAsync();
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPost]
		public async Task<ActionResult<JadwalShiftKaryawanDTO>> Post([FromBody] JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO) {
			try {
				var jadwal = await jadwalShiftKaryawanService.AddJadwalShiftKaryawanAsync(jadwalShiftKaryawanDTO);
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpPut]
		public async Task<ActionResult<JadwalShiftKaryawanDTO>> Put(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO) {
			try {
				var jadwal = await jadwalShiftKaryawanService.UpdateJadwalShiftKaryawanAsync(jadwalShiftKaryawanDTO);
				return Ok(jadwal.ConvertToDTO());
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpGet("GetByLikeDeskripsi/{desc}")]
		public async Task<ActionResult<List<JadwalShiftKaryawanDTO>>> GetByLikeDeskripsi(string desc) {
			var shifts = await jadwalShiftKaryawanService.GetByLikeDeskripsi(desc);
			return Ok(shifts);

      }
   }
}
