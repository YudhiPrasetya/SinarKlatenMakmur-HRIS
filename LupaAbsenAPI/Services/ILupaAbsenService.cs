using LupaAbsenAPI.Model;
using SKM.Shared.Dtos;

namespace LupaAbsenAPI.Services {
   public interface ILupaAbsenService {

      IEnumerable<LupaAbsen> GetAll(); 
      Task<LupaAbsen> AddLupaAbsen(LupaAbsenDTO lupaAbsenDTO);
		Task<List<LupaAbsen>> GetByGroupAndDate(string group, string startDate, string endDate);
	}
}
