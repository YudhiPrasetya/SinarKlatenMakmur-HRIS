using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using PositionAPI.Models;
using PositionAPI.Services;
using PositionAPI.Conversions;
using SKM.Shared.Dtos;
using System.Text.Json;
using System.Text;

namespace PositionAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PositionsController : ControllerBase {
		private readonly IPositionService positionService;
		private readonly ICacheService _cacheService;

		//private readonly IDistributedCache _cache;

		public PositionsController(IPositionService _positionService, ICacheService cacheService) {
			positionService = _positionService;
			_cacheService = cacheService;
		}

		[HttpGet]
		//[Authorize]
		public async Task<ActionResult<IEnumerable<Position>>> GetPositionsAsync() {
			//var ListPosition = positionService.GetPositionListAsync();
			//return ListPosition;
			try {
				var cacheData = _cacheService.GetData<IEnumerable<Position>>("position");
				if (cacheData != null) {
					return StatusCode(StatusCodes.Status200OK, cacheData);
				}
				//lock (_lock) {
				var expirationTime = DateTimeOffset.Now.AddHours(2.0);
				cacheData = await positionService.GetPositionListAsync();
				_cacheService.SetData<IEnumerable<Position>>("position", (IEnumerable<Position>)cacheData, expirationTime);
				return StatusCode(StatusCodes.Status200OK, cacheData);
			}
			catch (Exception) {

				throw;
			}
		}

		[HttpGet("Positions/{id}")]
		//[Authorize]
		public async Task<ActionResult<Position>> GetPositionByIdAsync(int id) {
			//return positionService.GetDepartmentByIdAsync(id);
			Position position;
			var cacheData = _cacheService.GetData<IEnumerable<Position>>("position");
			if (cacheData != null) {
				position = cacheData.Where(p => p.PositionId == id).FirstOrDefault();
				return StatusCode(StatusCodes.Status200OK, position);
			}
			position = await positionService.GetPositionByIdAsync(id);
			return StatusCode(StatusCodes.Status200OK, position);
		}

		[HttpPost]
		//[Authorize(Roles = "Administrator")]
		public async Task<ActionResult<PositionDTO>> AddPositionAsync([FromBody]PositionDTO positionDTO)
		{
			//return positionService.AddPositionAsync(positionDTO);
			var newPosition = await positionService.AddPositionAsync(positionDTO);
         if (newPosition == null) {
            return NoContent();
         }
         _cacheService.RemoveData("position");
         return Ok(newPosition.ConvertToDTO());
      }

		[HttpPut]
		//[Authorize(Roles = "Administrator")]
		public async Task<Position> UpdatePositionAsync(PositionDTO positionDTO)
		{
			//return positionService.UpdatePositionAsync(positionDTO);
			Position position = await positionService.UpdatePositionAsync(positionDTO);
         _cacheService.RemoveData("position");
         return position;
      }

		[HttpDelete("{id}")]
		//[Authorize(Roles = "Administrator")]
		public async Task<ActionResult<Position>> DeletePositionAsync(int id)
		{
         //return positionService.DeletePositionAsync(id);
         Position position = await positionService.DeletePositionAsync(id);
         _cacheService.RemoveData("position");
			return position;
      }
	}
}
