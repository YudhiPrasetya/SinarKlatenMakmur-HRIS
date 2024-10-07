using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PositionAPI.Conversions;
using PositionAPI.Data;
using PositionAPI.Models;
using SKM.Shared.Dtos;

namespace PositionAPI.Services
{
	public class PositionService : IPositionService
	{
		private readonly PositionDbContextClass dbContextClass;

		public PositionService(PositionDbContextClass _dbContextClass)
		{
			dbContextClass = _dbContextClass;
		}
		public async Task<Position> AddPositionAsync(PositionDTO positionDTO)
		{
			//throw new NotImplementedException();
			var rst = dbContextClass.Positions.Add(positionDTO.ConvertToModel());
			await dbContextClass.SaveChangesAsync();

			return rst.Entity;
		}

		public async Task<Position> DeletePositionAsync(int id)
		{
			//throw new NotImplementedException();
			Position position = await dbContextClass.Positions.FindAsync(id);
			var rst = dbContextClass.Positions.Remove(position);
			await dbContextClass.SaveChangesAsync();

			return position;
		}

		public async Task<Position> GetPositionByIdAsync(int id)
		{
			//throw new NotImplementedException();
			Position positiion = await dbContextClass.Positions.FindAsync(id);

			return positiion;
		}

		public async Task<IEnumerable<Position>> GetPositionListAsync()
		{
         //throw new NotImplementedException();
         //List<Position> positions = await dbContextClass.Positions.ToListAsync();
         //if(positions == null) {
         //	return NoContent();
         //}
         //return positions;

         return await dbContextClass.Positions.ToListAsync();
      }

		public async Task<Position> UpdatePositionAsync(PositionDTO positionDTO)
		{
			//throw new NotImplementedException();
			var rst = dbContextClass.Positions.Update(positionDTO.ConvertToModel());
			await dbContextClass.SaveChangesAsync();
			return rst.Entity;
		}
	}
}
