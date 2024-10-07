using MesinAbsenAPI.Conversions;
using MesinAbsenAPI.Data;
using MesinAbsenAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace MesinAbsenAPI.Services {
	public class LogMesinAbsenService : ILogMesinAbsenService {
		private readonly MesinAbsenDbContextClass _mesinAbsenDbContextClass;

		public LogMesinAbsenService(MesinAbsenDbContextClass mesinAbsenDbContextClass) {
			_mesinAbsenDbContextClass = mesinAbsenDbContextClass;
		}
		public async Task<bool> AddLogMesinAbsenRange(ContentLogMesinDTO contentLogMesinDTO) {
			DateTime startDate = contentLogMesinDTO.StartDate;
			DateTime endDate = contentLogMesinDTO.EndDate;
			string? IpAddress = contentLogMesinDTO.IpAddress;

			List<LogMesinAbsen> listLogMesinAbsen = await _mesinAbsenDbContextClass.LogMesinAbsen.Where(l => l.Tgl!.Value.Date >= startDate.Date && l.Tgl!.Value.Date <= endDate && l.IPMesin == IpAddress).ToListAsync();

			if (listLogMesinAbsen.Count > 0) {
				_mesinAbsenDbContextClass.LogMesinAbsen.RemoveRange(listLogMesinAbsen);
				await _mesinAbsenDbContextClass.SaveChangesAsync();
			}

			await _mesinAbsenDbContextClass.LogMesinAbsen.AddRangeAsync(contentLogMesinDTO.ListLogMesinAbsen!.ConvertToModel());
			await _mesinAbsenDbContextClass.SaveChangesAsync();
			return default;
		}

      public async Task<List<LogMesinAbsenDTO>> GetLogMesinAbsenByDate(DateTime startDate, DateTime endDate) {
         List<LogMesinAbsen> listLogMesinAbsen = await _mesinAbsenDbContextClass.LogMesinAbsen.Where(ma => ma.Tgl!.Value.Date >= startDate.Date && ma.Tgl!.Value.Date <= endDate.Date).ToListAsync();

			return (List<LogMesinAbsenDTO>)listLogMesinAbsen.ConvertToDTO();
      }
   }
}
