using ExceptionAPI.Conversions;
using ExceptionAPI.Data;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace ExceptionAPI.Services {
   public class ExceptionService : IExceptionService {
      private readonly ExceptionDBContext _dbContext;

      public ExceptionService(ExceptionDBContext dbContext) {
         _dbContext = dbContext;
      }
      public async Task<Model.Exception> AddExceptionAsync(ExceptionDTO exceptionDTO) {
         //throw new NotImplementedException();
         var rst = await _dbContext.Exceptions.AddAsync(exceptionDTO.ConvertToModel());
         await _dbContext.SaveChangesAsync();
         return rst.Entity;
      }

      public async Task<Model.Exception> DeleteExceptionAsync(int id) {
         //throw new NotImplementedException();
         var rst = await _dbContext.Exceptions.FindAsync(id);
         if(rst != null) {
            _dbContext.Exceptions.Remove(rst);
            await _dbContext.SaveChangesAsync();
         }
         return rst;
      }

      public async Task<Model.Exception> GetExceptionByIdAsync(int id) {
         //throw new NotImplementedException();
         return await _dbContext.Exceptions.FindAsync(id);
      }

      public IEnumerable<Model.Exception> GetExceptionListAsync() {
         //throw new NotImplementedException();
         return  _dbContext.Exceptions.ToList();
      }

      public async Task<Model.Exception> UpdateExceptionAsync(ExceptionDTO exceptionDTO) {
         //throw new NotImplementedException();
         var rst = _dbContext.Exceptions.Update(exceptionDTO.ConvertToModel());
         await _dbContext.SaveChangesAsync();
         return rst.Entity;
      }

      public async Task<List<Model.Exception>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         string strGroup = (group != "All" ? group.Replace("-", "/") : group);
         DateTime tgl1 = DateConversions.StringToDate(startDate);
         DateTime tgl2 = DateConversions.StringToDate(endDate);

         if (strGroup == "All") {
            return await this._dbContext.Exceptions.Where(k => k.StartDate.Value.Date >= tgl1.Date && k.EndDate.Value.Date <= tgl2.Date).ToListAsync();
         }
         else {
            return await _dbContext.Exceptions.Where(k => k.GrupKerja == strGroup && k.StartDate.Value.Date >= tgl1.Date && k.EndDate.Value.Date <= tgl2.Date).ToListAsync();
         }

      }
   }
}
