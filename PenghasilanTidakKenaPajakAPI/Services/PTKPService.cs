using Microsoft.EntityFrameworkCore;
using PenghasilanTidakKenaPajakAPI.Conversions;
using PenghasilanTidakKenaPajakAPI.Data;
using PenghasilanTidakKenaPajakAPI.Model;

namespace PenghasilanTidakKenaPajakAPI.Services {
   public class PTKPService : IPTKPService {
      private readonly DbContextClass _dbContextClass;

      public PTKPService(DbContextClass dbContextClass)
        {
         _dbContextClass = dbContextClass;
      }
      public async Task<PenghasilanTidakKenaPajak> AddPTKPAsync(PenghasilanTidakKenaPajak penghasilanTidakKenaPajak) {
         //throw new NotImplementedException();
         var rst = await _dbContextClass.PTKPs.AddAsync(penghasilanTidakKenaPajak);
         await _dbContextClass.SaveChangesAsync();
         return rst.Entity;
      }

      public async Task<PenghasilanTidakKenaPajak> DeletePTKPAsync(int id) {
         //throw new NotImplementedException();
         var rst = await _dbContextClass.PTKPs.FindAsync(id);
         _dbContextClass.PTKPs.Remove(rst);
         return rst;
      }

      public async Task<PenghasilanTidakKenaPajak> GetPTKPByIdAsync(int id) {
         //throw new NotImplementedException();
         return await _dbContextClass.PTKPs.FindAsync(id);
      }

      public IEnumerable<PenghasilanTidakKenaPajak> GetPTKPListAsync() {
         //throw new NotImplementedException();
         return  _dbContextClass.PTKPs.ToList();
      }

      public async Task<PenghasilanTidakKenaPajak> UpdatePTKPAsync(PenghasilanTidakKenaPajak penghasianlTidakKenaPajak) {
         //throw new NotImplementedException();
         var rst = _dbContextClass.PTKPs.Update(penghasianlTidakKenaPajak);
         await _dbContextClass.SaveChangesAsync();
         return rst.Entity;
      }
   }
}
