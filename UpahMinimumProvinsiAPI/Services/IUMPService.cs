using SKM.Shared.Dtos;
using UpahMinimumProvinsiAPI.Model;

namespace UpahMinimumProvinsiAPI.Services {
   public interface IUMPService {
      public IEnumerable<UpahMinimumProvinsi> GetUMPListAsync();
      public Task<UpahMinimumProvinsi> GetUMPByIdAsync(int id);
      public Task<UpahMinimumProvinsi> AddUMP(UpahMinimumProvinsiDTO umpDTO);
      //public Task<UpahMinimumProvinsi> AddUMPRange(IEnumerable<UpahMinimumProvinsiDTO> umpDTOs);
      public Task<UpahMinimumProvinsi> UpdateUMPAsync(UpahMinimumProvinsiDTO umpDTO);
      public Task<UpahMinimumProvinsi> DeleteUMPAsync(int id);
   }
}
