using PositionAPI.Models;
using SKM.Shared.Dtos;

namespace PositionAPI.Services
{
	public interface IPositionService
	{
		public Task<IEnumerable<Position>> GetPositionListAsync();
		public Task<Position> GetPositionByIdAsync(int id);
		public Task<Position> AddPositionAsync(PositionDTO positionDTO);
		public Task<Position> UpdatePositionAsync(PositionDTO positionDTO);
		public Task<Position> DeletePositionAsync(int id);
	}
}

