using SKM.Shared.Dtos;

namespace HRIS.Contracts
{
    public interface IGajiDanTunjanganService
    {
      Task<List<GajiDanTunjanganDTO>> GetGajiListAsync();
      Task<List<GajiDanTunjanganDTO>> GetGajiByGroupIdAsync(int groupId);
      Task<GajiDanTunjanganDTO> GetGajiAsync(int id);
      Task<GajiDanTunjanganDTO> AddGajiAsync(GajiDanTunjanganDTO gajiDTO);
      Task<GajiDanTunjanganDTO> AddGajiRangeAsync(IEnumerable<GajiDanTunjanganDTO> gajiDTOs);
      Task<GajiDanTunjanganDTO> DeleteGajiAsync(int id);
      Task<GajiDanTunjanganDTO> UpdateGajiAsync(GajiDanTunjanganDTO gajiDTO);
      Task<IEnumerable<GajiDanTunjanganDTO>> GetByGroupName(string groupName);
      Task<GajiDanTunjanganDTO?> GetByNIK(string nik);
   }
}
