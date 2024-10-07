using MesinAbsenAPI.Conversions;
using MesinAbsenAPI.Model;
using MesinAbsenAPI.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using SKM.Shared.Dtos;

namespace MesinAbsenAPI.Services {
   public class AbsenRealTimeService : IAbsenRealTimeService {
      private readonly MesinAbsenDbContextClass mesinAbsenDbContextClass;

      public AbsenRealTimeService(MesinAbsenDbContextClass mesinAbsenDbContextClass){
         this.mesinAbsenDbContextClass = mesinAbsenDbContextClass;
      }
      public async Task<AbsenRealTimeDTO> Add(AbsenRealTimeDTO absenRealTimeDTO) {
         EntityEntry<AbsenRealTime> result = await mesinAbsenDbContextClass.AbsenRealTimes.AddAsync(absenRealTimeDTO.ConvertToModel());
         await mesinAbsenDbContextClass.SaveChangesAsync();

         return result.Entity.ConvertToDTO();
      }
   }
}
