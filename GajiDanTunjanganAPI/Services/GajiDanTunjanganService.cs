using GajiDanTunjanganAPI.Conversions;
using GajiDanTunjanganAPI.Data;
using GajiDanTunjanganAPI.Model;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;

namespace GajiDanTunjanganAPI.Services {
   public class GajiDanTunjanganService : IGajiDanTunjanganService {
      private readonly DbContextClass dbContextClass;

      public GajiDanTunjanganService(DbContextClass dbContextClass)
      {
         this.dbContextClass = dbContextClass;
      }
      public async Task<Model.GajiDanTunjangan> AddGajiDanTunjanganAsync(Model.GajiDanTunjangan gaji) {
         //throw new NotImplementedException();
         var rst = await this.dbContextClass.GajiDanTunjangans.AddAsync(gaji);
         await this.dbContextClass.SaveChangesAsync();
         return rst.Entity;

      }

      public async Task<Model.GajiDanTunjangan> AddGajiDanTunjanganRangeAsync(IEnumerable<GajiDanTunjanganDTO> gajiDTOs) {
         //throw new NotImplementedException();
         await dbContextClass.GajiDanTunjangans.AddRangeAsync(gajiDTOs.ConvertToModel());
         await dbContextClass.SaveChangesAsync();
         return default;
      }

      public async Task<Model.GajiDanTunjangan> DeleteGajiDanTunjanganAsync(int id) {
         //throw new NotImplementedException();
         var rst = await this.dbContextClass.GajiDanTunjangans.FindAsync(id);
         this.dbContextClass.GajiDanTunjangans.Remove(rst);
         await this.dbContextClass.SaveChangesAsync();
         return rst;
      }

      public async Task<IEnumerable<GajiDanTunjangan>> GetByGroupName(string groupName) {
         //throw new NotImplementedException();
         string strGroup = groupName.Replace("_", " ").Replace("-", "/");
         return await this.dbContextClass.GajiDanTunjangans.Where(g => g.GrupKerja == strGroup).ToListAsync();
      }

      public async Task<Model.GajiDanTunjangan> GetGajiByNIKAsync(string nik) {
         //throw new NotImplementedException();
         return await this.dbContextClass.GajiDanTunjangans.Where(g => g.NIK == nik).FirstOrDefaultAsync();
      }

      public async Task<Model.GajiDanTunjangan> GetGajiDanTunjanganByIdAsync(int id) {
         //throw new NotImplementedException();
         return await this.dbContextClass.GajiDanTunjangans.FindAsync(id);
      }

      public async Task<IEnumerable<Model.GajiDanTunjangan>> GetGajiDanTunjanganByIdGroupAsync(int groupId) {
         //throw new NotImplementedException();
         return await this.dbContextClass.GajiDanTunjangans.Where(g => g.GroupId == groupId).ToListAsync();
      }

      public IEnumerable<Model.GajiDanTunjangan>? GetGajiDanTunjanganListAsync() {
         //throw new NotImplementedException();
         return this.dbContextClass.GajiDanTunjangans.ToList();
      }

      public async Task<Model.GajiDanTunjangan> UpdateGajiDanTunjanganAsync(Model.GajiDanTunjangan gaji) {
         //throw new NotImplementedException();
         var rst = this.dbContextClass.GajiDanTunjangans.Update(gaji);
         await this.dbContextClass.SaveChangesAsync();
         return rst.Entity;
      }
   }
}
