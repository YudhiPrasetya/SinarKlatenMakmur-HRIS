using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface ISuratPerintahLemburService {
      Task<IEnumerable<SuratPerintahLemburDTO>> GetListSPLsAsync();
      Task<List<SuratPerintahLemburDTO>> GetSPLAsync(int id);
      Task<List<SuratPerintahLemburDTO>> GetSPLByGroupId_OTDateAsync(int groupId, int intOTDate);
      Task<SuratPerintahLemburDTO> AddSPLAsync(SuratPerintahLemburDTO splDTO);
      Task<SuratPerintahLemburDTO> AddSPLRangeAsync(List<SuratPerintahLemburDTO> splDTOs);
      Task<SuratPerintahLemburDTO> DeleteSPLAsync(int id);
      Task<SuratPerintahLemburDTO> UpdateSPLAsync(SuratPerintahLemburDTO splDTO);
      Task<List<SuratPerintahLemburDTO>> GetByGroupAndDate(string group, string startDate, string endDate);

      Task LapLemburAll();
      Task ReportRekapLembur(string group, string startDate, string endDate);
      Task<List<SuratPerintahLemburDTO>?> GetByDateRange(string startDate, string endDate);
   }
}
