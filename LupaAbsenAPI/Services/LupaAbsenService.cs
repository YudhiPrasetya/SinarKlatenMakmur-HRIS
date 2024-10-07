using LupaAbsenAPI.Conversions;
using LupaAbsenAPI.Data;
using LupaAbsenAPI.Model;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace LupaAbsenAPI.Services {
   public class LupaAbsenService : ILupaAbsenService {
      private readonly LupaAbsenDbContext lupaAbsenDbContext;

      public LupaAbsenService(LupaAbsenDbContext lupaAbsenDbContext)
      {
         this.lupaAbsenDbContext = lupaAbsenDbContext;
      }
      public async Task<LupaAbsen> AddLupaAbsen(LupaAbsenDTO lupaAbsenDTO) {
         //throw new NotImplementedException();
         var lupaAbsen = await this.lupaAbsenDbContext.LupaAbsens.AddAsync(lupaAbsenDTO.ConvertToModel());
         await this.lupaAbsenDbContext.SaveChangesAsync();
         return lupaAbsen.Entity;
      }

      public  IEnumerable<LupaAbsen> GetAll() {
         //throw new NotImplementedException();
         return this.lupaAbsenDbContext.LupaAbsens.ToList();
      }

		public async Task<List<LupaAbsen>> GetByGroupAndDate(string group, string startDate, string endDate) {
			//throw new NotImplementedException();
			string strGroup = (group != "All" ? group.Replace("-", "/") : group);
			DateTime tgl1 = DateConversions.StringToDate(startDate);
			DateTime tgl2 = DateConversions.StringToDate(endDate);

			if (strGroup == "All") {
				return await this.lupaAbsenDbContext.LupaAbsens.Where(k => k.Tanggal.Value.Date >= tgl1.Date && k.Tanggal.Value.Date <= tgl2.Date).ToListAsync();
			}
			else {
				return await this.lupaAbsenDbContext.LupaAbsens.Where(k => k.GrupKerja == strGroup && k.Tanggal.Value.Date >= tgl1.Date && k.Tanggal.Value.Date <= tgl2.Date).ToListAsync();
			}

		}
	}
}
