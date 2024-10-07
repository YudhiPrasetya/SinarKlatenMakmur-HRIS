using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IMesinAbsenService {
      Task<List<MesinAbsenDTO>> GetListMesinAbsenAsync();
      Task<MesinAbsenDTO> GetMesinAbsenAsync(int id);
      Task<MesinAbsenDTO> AddMesinAbsenAsync(MesinAbsenDTO mesinAbsenDTO);
      Task<MesinAbsenDTO> DeleteMesinAbsenAsync(int id);
      Task<MesinAbsenDTO> UpdateMesinAbsenAsync(MesinAbsenDTO mesinAbsenDTO);
   }
}
