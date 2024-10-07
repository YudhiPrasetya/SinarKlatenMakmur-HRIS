using SKM.Shared.Dtos;
using UpahMinimumProvinsiAPI.Data;
using UpahMinimumProvinsiAPI.Model;
using UpahMinimumProvinsiAPI.Conversions;
using Microsoft.EntityFrameworkCore;

namespace UpahMinimumProvinsiAPI.Services {
   public class UMPService : IUMPService {
      private readonly DbContextClass _dbContextClass;

      public UMPService(DbContextClass dbContextClass)
      {
         _dbContextClass = dbContextClass;
      }
      public async Task<UpahMinimumProvinsi> AddUMP(UpahMinimumProvinsiDTO umpDTO) {
         //throw new NotImplementedException();
         var rst = await _dbContextClass.UMPs.AddAsync(umpDTO.ConvertToModel());
         await _dbContextClass.SaveChangesAsync();
         return rst.Entity;
      }

      //public Task<UpahMinimumProvinsi> AddUMPRange(IEnumerable<UpahMinimumProvinsiDTO> umpDTOs) {
      //   //throw new NotImplementedException();

      //}

      public async Task<UpahMinimumProvinsi> DeleteUMPAsync(int id) {
         //throw new NotImplementedException();
         var rst = await _dbContextClass.UMPs.FindAsync(id);
         _dbContextClass.UMPs.Remove(rst);
         await _dbContextClass.SaveChangesAsync();
         return rst;
      }

      public IEnumerable<UpahMinimumProvinsi> GetUMPListAsync() {
         //throw new NotImplementedException();
         return _dbContextClass.UMPs.OrderByDescending(u => u.Id).ToList();
      }

      public async Task<UpahMinimumProvinsi> GetUMPByIdAsync(int id) {
         //throw new NotImplementedException()
         return await _dbContextClass.UMPs.FindAsync(id);
      }

      public async Task<UpahMinimumProvinsi> UpdateUMPAsync(UpahMinimumProvinsiDTO umpDTO) {
         //throw new NotImplementedException();
         var rst = _dbContextClass.UMPs.Update(umpDTO.ConvertToModel());
         await _dbContextClass.SaveChangesAsync();
         return rst.Entity;
      }


   }
}
