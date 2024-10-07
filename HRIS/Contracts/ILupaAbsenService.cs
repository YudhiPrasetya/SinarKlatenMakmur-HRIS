using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface ILupaAbsenService {
      Task<List<LupaAbsenDTO>> GetListLupaAbsenAsync();
      Task<LupaAbsenDTO> AddLupaAbsenAsync(LupaAbsenDTO lupaAbsenDTO);
		Task<List<LupaAbsenDTO>> GetByGroupAndDate(string group, string startDate, string endDate);
      Task ExportToExcel(string group, string startDate, string endDate);
   }
}
