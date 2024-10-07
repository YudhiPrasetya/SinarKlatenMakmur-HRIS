using SKM.Shared.Dtos;
using SuratperintahLemburAPI.Models;

namespace SuratperintahLemburAPI.Services {
   public interface ISuratPerintahLemburService {
      public IEnumerable<SuratPerintahLemburDTO> GetSPLListAsync();
      public IEnumerable<SuratPerintahLembur> GetSPLByIdAsync(int id);
      public Task<IEnumerable<SuratPerintahLembur>> GetSPLByGroupId_OTDate(int groupId, int intOTDate);
      public Task<SuratPerintahLembur> AddSPL(SuratPerintahLemburDTO splDTO);
      public Task<SuratPerintahLembur> AddSPLRange(IEnumerable<SuratPerintahLemburDTO> splDTOs);
      public Task<SuratPerintahLembur> UpdateSPLAsync(SuratPerintahLemburDTO splDTO);
      public Task<SuratPerintahLembur> DeleteSPLAsync(int id);
      public Task<List<SuratPerintahLembur>> GetByGroupAndDate(string group, string startDate, string endDate);
      public Task<List<SuratPerintahLemburDTO>?> GetByDateRange(string startDate, string endDate);
   }
}
