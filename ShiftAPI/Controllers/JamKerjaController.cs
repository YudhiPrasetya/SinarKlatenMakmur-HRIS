using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShiftAPI.Conversions;
using ShiftAPI.Services;
using SKM.Shared.Dtos;

namespace ShiftAPI.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class JamKerjaController : ControllerBase {
		private readonly IjamKerjaService jamKerjaService;

		public JamKerjaController(IjamKerjaService jamKerjaService) {
			this.jamKerjaService = jamKerjaService;
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<JamKerjaDTO>> Get(int id) {
			var jamKerja = await this.jamKerjaService.GetJamKerja(id);
			if(jamKerja == null) {
				return NoContent();
			}
			return Ok(jamKerja.ConvertToDTO());
		}

		[HttpPost]
		public async Task<ActionResult<JamKerjaDTO>> Post(JamKerjaDTO jamKerjaDTO) {
			var jamKerja = await this.jamKerjaService.AddJamkerja(jamKerjaDTO);
			return Ok(jamKerja.ConvertToDTO());
		}

		[HttpPut]
		public async Task<ActionResult<JamKerjaDTO>> Put(JamKerjaDTO jamKerjaDTO) {
			var jamKerja = await this.jamKerjaService.UpdateJamKerja(jamKerjaDTO);
			return Ok(jamKerja.ConvertToDTO());
		}
	}
}
