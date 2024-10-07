using MesinAbsenAPI.Models;

namespace MesinAbsenAPI.Services
{
  public interface IMesinAbsenService
  {
    public Task<IEnumerable<MesinAbsen>> GetMesinAbsenListAsync();
    public Task<MesinAbsen> GetMesinAbsenByIdAsync(int id);
    public Task<MesinAbsen> AddMesinAbsenAsync(MesinAbsen mesinAbsen);
    public Task<MesinAbsen> UpdateMesinAbsenAsync(MesinAbsen mesinAbsen);
    public Task<MesinAbsen> DeleteMesinAbsenAsync(int id);
  }
}
