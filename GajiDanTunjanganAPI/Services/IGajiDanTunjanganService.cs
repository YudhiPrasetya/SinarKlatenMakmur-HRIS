using GajiDanTunjanganAPI.Model;
using SKM.Shared.Dtos;

namespace GajiDanTunjanganAPI.Services {
   public interface IGajiDanTunjanganService {
      public IEnumerable<GajiDanTunjangan> GetGajiDanTunjanganListAsync();

      public Task<IEnumerable<GajiDanTunjangan>> GetGajiDanTunjanganByIdGroupAsync(int groupId);
      public Task<GajiDanTunjangan> GetGajiDanTunjanganByIdAsync(int id);
      public Task<GajiDanTunjangan> AddGajiDanTunjanganAsync(GajiDanTunjanganAPI.Model.GajiDanTunjangan gaji);
      public Task<GajiDanTunjangan> AddGajiDanTunjanganRangeAsync(IEnumerable<GajiDanTunjanganDTO> gajiDTOs);
      public Task<GajiDanTunjangan> UpdateGajiDanTunjanganAsync(GajiDanTunjanganAPI.Model.GajiDanTunjangan gaji);
      public Task<GajiDanTunjangan> DeleteGajiDanTunjanganAsync(int id);

      public Task<GajiDanTunjangan> GetGajiByNIKAsync(string nik);
      public Task<IEnumerable<GajiDanTunjangan>> GetByGroupName(string groupName);
   }
}
