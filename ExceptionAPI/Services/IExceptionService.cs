using ExceptionAPI.Model;
using SKM.Shared.Dtos;

namespace ExceptionAPI.Services {
   public interface IExceptionService {
      public IEnumerable<Model.Exception> GetExceptionListAsync();
      public Task<Model.Exception> GetExceptionByIdAsync(int id);
      public Task<Model.Exception> AddExceptionAsync(ExceptionDTO exceptionDTO);
      public Task<Model.Exception> UpdateExceptionAsync(ExceptionDTO exceptionDTO);
      public Task<Model.Exception> DeleteExceptionAsync(int id);
      Task<List<Model.Exception>> GetByGroupAndDate(string group, string startDate, string endDate);
   }
}
