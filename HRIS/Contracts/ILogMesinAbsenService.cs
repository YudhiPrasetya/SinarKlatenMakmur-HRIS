using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface ILogMesinAbsenService {
      Task<List<LogMesinAbsenDTO>> GetListLogMesinByDate(string startDate, string endDate);
   }
}
