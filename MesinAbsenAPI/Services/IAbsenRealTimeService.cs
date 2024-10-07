using SKM.Shared.Dtos;

namespace MesinAbsenAPI.Services {
   public interface IAbsenRealTimeService {
      Task<AbsenRealTimeDTO> Add(AbsenRealTimeDTO absenRealTimeDTO);
   }
}
