using ExceptionsTypeAPI.Model;
using SKM.Shared.Dtos;

namespace ExceptionsTypeAPI.Services {
   public interface IExceptionTypeService {
      public Task<List<ExceptionType>> GetExceptionTypeListAsync();
      public Task<ExceptionType> GetExceptionTypeByIdAsync(int id);
      public Task<ExceptionType> AddExceptionType(ExceptionTypeDTO exceptionTypeDTO);
      public Task<ExceptionType> UpdateExceptionTypeAsync(ExceptionTypeDTO exceptionTypeDTO);
      public Task<ExceptionType> DeleteExceptionTypeAsync(int id);

      public Task<List<ExceptionType>> GetExceptionTypeListByValueAsync(string val);
   }
}
