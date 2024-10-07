using PenghasilanTidakKenaPajakAPI.Model;

namespace PenghasilanTidakKenaPajakAPI.Services {
   public interface IPTKPService {
      public IEnumerable<PenghasilanTidakKenaPajak> GetPTKPListAsync();
      public Task<PenghasilanTidakKenaPajak> GetPTKPByIdAsync(int id);
      public Task<PenghasilanTidakKenaPajak> AddPTKPAsync(PenghasilanTidakKenaPajak penghasilanTidakKenaPajak);
      public Task<PenghasilanTidakKenaPajak> UpdatePTKPAsync(PenghasilanTidakKenaPajak penghasianlTidakKenaPajak);
      public Task<PenghasilanTidakKenaPajak> DeletePTKPAsync(int id);
   }
}
