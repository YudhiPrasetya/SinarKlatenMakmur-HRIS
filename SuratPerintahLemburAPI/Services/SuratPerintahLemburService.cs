using MassTransit.Internals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using SuratperintahLemburAPI.Conversions;
using SuratperintahLemburAPI.Data;
using SuratperintahLemburAPI.Models;
//using SuratPerintahLemburAPI.Models;
using System.Globalization;

namespace SuratperintahLemburAPI.Services {
   public class SuratPerintahLemburService : ISuratPerintahLemburService {
      private readonly DbContextClass _dbContextClass;

      public SuratPerintahLemburService(DbContextClass dbContextClass)
        {
         _dbContextClass = dbContextClass;
      }
      public async Task<SuratPerintahLembur> AddSPL(SuratPerintahLemburDTO splDTO) {
         string? jnsLembur = splDTO.OTType;
         int? TotalJamOT = splDTO.OTTotal;
			decimal gaji = splDTO.Upah.Value;
			int totalTunjangan = splDTO.TunjMasaKerja.Value + splDTO.TunjLain.Value + splDTO.TunjJabatan.Value + splDTO.TunjKeterampilan.Value;
         //decimal upah1Jam = Math.Round((gaji + totalTunjangan) / 173);
         //decimal NominalOT1 = upah1Jam * 1.5M;
         decimal NominalOT1 = Math.Round((gaji + totalTunjangan) / 173 * 1.5M);
         //decimal NominalOT2 = upah1Jam * 2M;
         decimal NominalOT2 = Math.Round((gaji + totalTunjangan) / 173 * 2M);
         //decimal NominalOT3 = upah1Jam * 3M;
         decimal NominalOT3 = Math.Round((gaji + totalTunjangan) / 173 * 3M);
         //decimal NominalOT4 = upah1Jam * 4M;
         decimal NominalOT4 = Math.Round((gaji + totalTunjangan) / 173 * 4M);

         if (jnsLembur != "Lembur Hari Libur") {
            splDTO.NominalOT1 = NominalOT1;
            splDTO.NominalOT2 = NominalOT2 * (TotalJamOT - 1);
            splDTO.NominalOT3 = 0;
            splDTO.NominalOT4 = 0;
            splDTO.NominalOTTotal = Math.Round((decimal)(NominalOT1 + (NominalOT2 * (TotalJamOT - 1))));
            splDTO.OTP1 = 1;
            splDTO.OTPNominal1 = NominalOT1;
            splDTO.OTP2 = TotalJamOT - 1;
            //splDTO.OTPNominal2 = NominalOT2 * (TotalJamOT - 1);
            splDTO.OTPNominal2 = NominalOT2;
            splDTO.OTP3 = 0;
            splDTO.OTPNominal3 = NominalOT3;
            splDTO.OTP4 = 0;
            splDTO.OTPNominal4 = NominalOT4;
         }
         else {
				switch (TotalJamOT) {
               case < 8:
                  splDTO.NominalOT1 = 0;
                  splDTO.NominalOT2 = NominalOT2 * TotalJamOT;
                  splDTO.NominalOT3 = 0;
                  splDTO.NominalOT4 = 0;
                  splDTO.NominalOTTotal = Math.Round((decimal)(NominalOT2 * TotalJamOT), 2);
                  splDTO.OTP1 = 0;
                  splDTO.OTPNominal1 = NominalOT1;
                  splDTO.OTP2 = TotalJamOT;
                  splDTO.OTPNominal2 = NominalOT2;
                  splDTO.OTP3 = 0;
                  splDTO.OTPNominal3 = NominalOT3;
                  splDTO.OTP4 = 0;
                  splDTO.OTPNominal4 = NominalOT4;
               break;
               case 8:
					   splDTO.NominalOT1 = 0;
					   splDTO.NominalOT2 = NominalOT2 * 7;
					   splDTO.NominalOT3 = NominalOT3;
                  splDTO.NominalOT4 = 0;
                  splDTO.NominalOTTotal = Math.Round((decimal)((NominalOT2 * 7) + NominalOT3), 2);
                  splDTO.OTP1 = 0;
                  splDTO.OTPNominal1 = NominalOT1;
                  splDTO.OTP2 = 7;
                  splDTO.OTPNominal2 = NominalOT2;
                  splDTO.OTP3 = 1;
                  splDTO.OTPNominal3 = NominalOT3;
                  splDTO.OTP4 = 0;
                  splDTO.OTPNominal4 = NominalOT4;
               break;
               case > 8:
					   splDTO.NominalOT1 = 0;
					   splDTO.NominalOT2 = NominalOT2 * 7;
					   splDTO.NominalOT3 = NominalOT3;
					   splDTO.NominalOT4 = NominalOT4 * (TotalJamOT - 8);
                  splDTO.NominalOTTotal = Math.Round((decimal)((NominalOT2 * 7) + NominalOT3 + (NominalOT4 * (TotalJamOT - 8))), 2);
                  splDTO.OTP1 = 0;
                  splDTO.OTPNominal1 = NominalOT1;
                  splDTO.OTP2 = 7;
                  splDTO.OTPNominal2 = NominalOT2;
                  splDTO.OTP3 = 1;
                  splDTO.OTPNominal3 = NominalOT3;
                  splDTO.OTP4 = TotalJamOT - 8;
                  splDTO.OTPNominal4 = NominalOT4;
               break;
				}
         }

         SuratPerintahLembur SPL = new() {
            Id = splDTO.Id,
            GroupId = splDTO.GroupId,
            GroupName = splDTO.GroupName,
            DepartmentId = splDTO.DepartmentId,
            DepartmentName = splDTO.DepartmentName,
            EmployeeId = splDTO.EmployeeId,
            EmployeeName = splDTO.EmployeeName,
            NIK = splDTO.NIK,
            Upah = splDTO.Upah,
            Style = splDTO.Style,
            Description = splDTO.Description,
            OTType = splDTO.OTType,
            OTDate = splDTO.OTDate,
            OT1 = splDTO.OT1,
            NominalOT1 = splDTO.NominalOT1,
            OT2 = splDTO.OT2,
            NominalOT2 = splDTO.NominalOT2,
            NominalOT3 = splDTO.NominalOT3,
            NominalOT4 = splDTO.NominalOT4,
            OTBreak = splDTO.OTBreak,
            OTTotal = splDTO.OTTotal,
            NominalOTTotal = splDTO.NominalOTTotal,
            TunjJabatan = splDTO.TunjJabatan,
            TunjMasaKerja = splDTO.TunjMasaKerja,
            TunjKeterampilan = splDTO.TunjKeterampilan,
            TunjLain = splDTO.TunjLain,
            OTP1 = splDTO.OTP1,
            OTPNominal1 = splDTO.OTPNominal1,
            OTP2 = splDTO.OTP2,
            OTPNominal2 = splDTO.OTPNominal2,
            OTP3 = splDTO.OTP3,
            OTPNominal3 = splDTO.OTPNominal3,
            OTP4 = splDTO.OTP4,
            OTPNominal4 = splDTO.OTPNominal4,
            CreatedBy = 1,
            CreatedAt = DateTime.Now.Date,
            UpdatedBy = 1,
            UpdatedAT = DateTime.Now.Date,
            //SPLDetails = listSPLDetail
         };

         //SPL.SPLDetails = listSPLDetail;
         var spl = await _dbContextClass.SuratPerintahLemburs.AddAsync(SPL);
         await _dbContextClass.SaveChangesAsync();

         return spl.Entity;
      }

      public async Task<SuratPerintahLembur> AddSPLRange(IEnumerable<SuratPerintahLemburDTO> splDTOs) {
         //throw new NotImplementedException();
         await _dbContextClass.SuratPerintahLemburs.AddRangeAsync(splDTOs.ConvertToModel());
         await _dbContextClass.SaveChangesAsync();
         return default ;
      }

      public async Task<SuratPerintahLembur> DeleteSPLAsync(int id) {
         //throw new NotImplementedException();
         var spl = await _dbContextClass.SuratPerintahLemburs.FindAsync(id);
         if(spl != null) {
            _dbContextClass.SuratPerintahLemburs.Remove(spl);
            await _dbContextClass.SaveChangesAsync();
         }
         return spl;
      }

      public async Task<IEnumerable<SuratPerintahLembur>> GetSPLByGroupId_OTDate(int groupId, int intOTDate) {
         //throw new NotImplementedException();
         DateTime dtOTDate = DateConversions.IntToDateTime(intOTDate);
         var spls = from spl in _dbContextClass.SuratPerintahLemburs where 
                    spl.OTDate.Value.Day == dtOTDate.Day 
                    && spl.OTDate.Value.Day == dtOTDate.Month 
                    && spl.OTDate.Value.Day == dtOTDate.Year 
                    select spl;

         //var spls = await _dbContextClass.SuratPerintahLemburs.Where(s=> s.GroupId == groupId && s.OTDate == dateOnly).ToListAsync();
         return (IEnumerable<SuratPerintahLembur>)spls;
      }

      public IEnumerable<SuratPerintahLembur> GetSPLByIdAsync(int id) {
         //throw new NotImplementedException();
         return _dbContextClass.SuratPerintahLemburs.Where(spl => spl.Id == id).ToList();
      }

      public IEnumerable<SuratPerintahLemburDTO> GetSPLListAsync() {
         //throw new NotImplementedException();
         return _dbContextClass.SuratPerintahLemburs.ToList().ConvertToDTO().DistinctBy(sp => sp.GroupId).DistinctBy(sp => sp.OTDate);
         //return _dbContextClass.SuratPerintahLemburs.ToList().DistinctBy(sp => sp.OTDate.ToShortDateString());
         //return _dbContextClass.SuratPerintahLemburs.Include(spl => spl.SPLDetails).ConvertToDTO();
         return default;
      }

      public async Task<SuratPerintahLembur> UpdateSPLAsync(SuratPerintahLemburDTO splDTO) {
         //throw new NotImplementedException();
         var rst = _dbContextClass.SuratPerintahLemburs.Update(splDTO.ConvertToModel());
         await _dbContextClass.SaveChangesAsync();
         return rst.Entity;
      }

      public async Task<List<SuratPerintahLembur>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         string strGroup = (group != "All" ? group.Replace("-", "/").Replace("_", " ") : group);
         DateTime tgl1 = DateConversions.StringToDate(startDate);
         DateTime tgl2 = DateConversions.StringToDate(endDate);

         if (strGroup == "All") {
            return await _dbContextClass.SuratPerintahLemburs.Where(k => k.OTDate.Value.Date >= tgl1.Date && k.OTDate.Value.Date <= tgl2.Date).ToListAsync();

            //return await _dbContextClass.SuratPerintahLemburs.Include(spl => spl.SPLDetails).Where(k => k.OTDate.Value.Date >= tgl1.Date && k.OTDate.Value.Date <= tgl2.Date).ToListAsync();
         }
         else {
            return await _dbContextClass.SuratPerintahLemburs.Where(k => k.OTDate.Value.Date >= tgl1.Date && k.OTDate.Value.Date <= tgl2.Date && k.GroupName == strGroup).ToListAsync();

            //return await _dbContextClass.SuratPerintahLemburs.Include(spl => spl.SPLDetails).Where(k => k.GroupName == strGroup && k.OTDate.Value.Date >= tgl1.Date && k.OTDate.Value.Date <= tgl2.Date).ToListAsync();

         }
         //return default;
      }

      public async Task<List<SuratPerintahLemburDTO>?> GetByDateRange(string startDate, string endDate) {
         DateTime sDate = DateConversions.StringToDate(startDate);
         DateTime eDate = DateConversions.StringToDate(endDate);

         var result = await _dbContextClass.SuratPerintahLemburs.Where(s => s.OTDate!.Value.Date >= sDate && s.OTDate!.Value.Date <= eDate).ToListAsync();
         return (List<SuratPerintahLemburDTO>?)result.ConvertToDTO();
      }
   }

}
