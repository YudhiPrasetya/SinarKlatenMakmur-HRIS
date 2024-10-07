using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IExceptionService {
      Task<IEnumerable<ExceptionDTO>> GetListExceptionsAsync();
      Task<ExceptionDTO> GetExceptionAsync(int id);
      Task<ExceptionDTO> AddExceptionAsync(ExceptionDTO exceptionDTO);
      Task<ExceptionDTO> DeleteExceptionAsync(int id);
      Task<ExceptionDTO> UpdateExceptionAsync(ExceptionDTO exceptionDTO);
      Task<List<ExceptionDTO>> GetByGroupAndDate(string group, string startDate, string endDate);
      Task ExportToExcel(string group, string startDate, string endDate);
   }
}
