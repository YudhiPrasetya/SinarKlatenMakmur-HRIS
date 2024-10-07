using ExceptionsTypeAPI.Conversions;
using ExceptionsTypeAPI.Data;
using ExceptionsTypeAPI.Model;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;

namespace ExceptionsTypeAPI.Services {
   public class ExceptionTypeService : IExceptionTypeService {
      private readonly DbContextClass _dbContextClass;

      public ExceptionTypeService(DbContextClass dbContextClass) {
         _dbContextClass = dbContextClass;
      }
      public async Task<ExceptionType> AddExceptionType(ExceptionTypeDTO exceptionTypeDTO) {
         //throw new NotImplementedException();
         var rst = await _dbContextClass.AddAsync(exceptionTypeDTO.ConvertToModel());
         await _dbContextClass.SaveChangesAsync();
         return rst.Entity;
      }

      public async Task<ExceptionType> DeleteExceptionTypeAsync(int id) {
         //throw new NotImplementedException();
         var exceptionType = await _dbContextClass.ExceptionTypes.FindAsync(id);
         if(exceptionType != null) {
            _dbContextClass.ExceptionTypes.Remove(exceptionType);
            await _dbContextClass.SaveChangesAsync();
         }
         return exceptionType;
      }

      public async Task<ExceptionType> GetExceptionTypeByIdAsync(int id) {
         //throw new NotImplementedException();
         return await _dbContextClass.ExceptionTypes.FindAsync(id);
      }

      public async Task<List<ExceptionType>> GetExceptionTypeListAsync() {
         //throw new NotImplementedException();
         return await _dbContextClass.ExceptionTypes.ToListAsync();
      }

      public async Task<List<ExceptionType>> GetExceptionTypeListByValueAsync(string val) {
         //throw new NotImplementedException();
         return await _dbContextClass.ExceptionTypes.Where(e => e.ExceptionName.Contains(val)).ToListAsync();
      }

      public async Task<ExceptionType> UpdateExceptionTypeAsync(ExceptionTypeDTO exceptionTypeDTO) {
         //throw new NotImplementedException();
         var rst = _dbContextClass.ExceptionTypes.Update(exceptionTypeDTO.ConvertToModel());
         await _dbContextClass.SaveChangesAsync();

         return rst.Entity;
      }
   }
}
