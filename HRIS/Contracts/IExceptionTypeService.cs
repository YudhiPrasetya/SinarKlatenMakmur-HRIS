using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IExceptionTypeService {
      Task<List<ExceptionTypeDTO>> GetListExceptionsTypeAsync();
      Task<ExceptionTypeDTO> GetExceptioTypeAsync(int id);
      Task<ExceptionTypeDTO> AddExceptionTypeAsync(ExceptionTypeDTO exceptionTypeDTO);
      Task<ExceptionTypeDTO> DeleteExceptionTypeAsync(int id);
      Task<ExceptionTypeDTO> UpdateExceptionTypeAsync(ExceptionTypeDTO exceptionTypeDTO);
      Task<List<ExceptionTypeDTO>> GetListExceptionTypeByValAsync(string val);
   }
}
