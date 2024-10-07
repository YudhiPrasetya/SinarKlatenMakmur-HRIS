using MesinAbsenAPI.Models;
using SKM.Shared.Dtos;

namespace MesinAbsenAPI.Services {
	public interface ILogMesinAbsenService {
		Task<bool> AddLogMesinAbsenRange(ContentLogMesinDTO contentLogMesinDTO);

		Task<List<LogMesinAbsenDTO>> GetLogMesinAbsenByDate(DateTime startDate, DateTime endDate);
	}

}
