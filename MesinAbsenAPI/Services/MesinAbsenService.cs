using MesinAbsenAPI.Data;
using MesinAbsenAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MesinAbsenAPI.Services
{
  public class MesinAbsenService : IMesinAbsenService
  {
    private readonly MesinAbsenDbContextClass _dbContextClass;

    public MesinAbsenService(MesinAbsenDbContextClass dbContextClass)
    {
      _dbContextClass = dbContextClass;
    }
    public async Task<MesinAbsen> AddMesinAbsenAsync(MesinAbsen mesinAbsen)
    {
      //throw new NotImplementedException();
      var rst = _dbContextClass.MesinAbsens.Add(mesinAbsen);
      await _dbContextClass.SaveChangesAsync();

      return rst.Entity;
    }

    public async Task<MesinAbsen> DeleteMesinAbsenAsync(int id)
    {
      //throw new NotImplementedException();
      MesinAbsen mesinAbsen = await _dbContextClass.MesinAbsens.FindAsync(id);
      var rst = _dbContextClass.MesinAbsens.Remove(mesinAbsen);
      await _dbContextClass.SaveChangesAsync();
      //return rst != null ? true: false;
      return rst.Entity;

    }

    public async Task<MesinAbsen> GetMesinAbsenByIdAsync(int id)
    {
      //throw new NotImplementedException();
      return await _dbContextClass.MesinAbsens.Where(m => m.DeviceID == id).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<MesinAbsen>> GetMesinAbsenListAsync()
    {
      //throw new NotImplementedException();
      return await _dbContextClass.MesinAbsens.ToListAsync();
    }

    public async Task<MesinAbsen> UpdateMesinAbsenAsync(MesinAbsen mesinAbsen)
    {
      //throw new NotImplementedException();
      var rst = _dbContextClass.MesinAbsens.Update(mesinAbsen);
      await _dbContextClass.SaveChangesAsync();

      return rst.Entity;
    }
  }
}
