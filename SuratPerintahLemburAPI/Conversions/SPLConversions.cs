using SKM.Shared.Dtos;
using SuratperintahLemburAPI.Models;
//using SuratPerintahLemburAPI.Models;

namespace SuratperintahLemburAPI.Conversions {
   public static class SPLConversions {
      public static IEnumerable<SuratPerintahLemburDTO> ConvertToDTO(this IEnumerable<SuratPerintahLembur> SPLs) {
         return (from spl in SPLs
         select new SuratPerintahLemburDTO {
            Id = spl.Id,
            GroupId = spl.GroupId,
            GroupName = spl.GroupName,
            DepartmentId = spl.DepartmentId,
            DepartmentName = spl.DepartmentName,
            EmployeeId = spl.EmployeeId,
            EmployeeName = spl.EmployeeName,
            NIK = spl.NIK,
            Description = spl.Description,
            Style = spl.Style,
            OTType = spl.OTType,
            OTDate = spl.OTDate.Value.Date,
            OT1 = spl.OT1,
            OT2 = spl.OT2,
            NominalOT1 = spl.NominalOT1.Value,
            NominalOT2 = spl.NominalOT2,
            NominalOT3 = spl.NominalOT3,
            NominalOT4 = spl.NominalOT4,
            NominalOTTotal = spl.NominalOTTotal,
            OTBreak = spl.OTBreak,
            OTTotal = spl.OTTotal,
            Upah = spl.Upah,
            TunjJabatan = spl.TunjJabatan,
            TunjKeterampilan = spl.TunjKeterampilan,
            TunjMasaKerja = spl.TunjMasaKerja,
            TunjLain = spl.TunjLain,
            OTP1 = spl.OTP1,
            OTP2 = spl.OTP2,
            OTP3 = spl.OTP3,
            OTP4 = spl.OTP4,
            OTPNominal1 = spl.OTPNominal1,
            OTPNominal2 = spl.OTPNominal2,
            OTPNominal3 = spl.OTPNominal3,
            OTPNominal4 = spl.OTPNominal4,
            CreatedAt = spl.CreatedAt,
            CreatedBy = spl.CreatedBy,
            UpdatedBy = spl.UpdatedBy,
            UpdatedAT = spl.UpdatedAT,
            //SPLDetailDTOs = (from splDetail in spl.SPLDetails select new SPLDetailDTO {
            //   Id = splDetail.Id,
            //   SPLId = splDetail.SPLId,
            //   SuratPerintahLemburId = splDetail.SuratPerintahLemburId,
            //   LemburKe = splDetail.LemburKe,
            //   NominalLembur = splDetail.NominalLembur
            //}).ToList()
         }).ToList<SuratPerintahLemburDTO>();
      }

      public static SuratPerintahLemburDTO ConvertToDTO(this SuratPerintahLembur spl) {
         return new SuratPerintahLemburDTO {
            Id = spl.Id,
            GroupId = spl.GroupId,
            GroupName = spl.GroupName,
            DepartmentId = spl.DepartmentId,
            DepartmentName = spl.DepartmentName,
            EmployeeId = spl.EmployeeId,
            EmployeeName = spl.EmployeeName,
            NIK = spl.NIK,
            Description = spl.Description,
            Style = spl.Style,
            OTType = spl.OTType,
            OTDate = spl.OTDate.Value.Date,
            OT1 = spl.OT1,
            OT2 = spl.OT2,
            NominalOT1 = spl.NominalOT1,
            NominalOT2 = spl.NominalOT2,
            NominalOT3 = spl.NominalOT3,
            NominalOT4 = spl.NominalOT4,
            NominalOTTotal = spl.NominalOTTotal,
            OTBreak = spl.OTBreak,
            OTTotal = spl.OTTotal,
            Upah = spl.Upah,
            TunjJabatan = spl.TunjJabatan,
            TunjKeterampilan = spl.TunjKeterampilan,
            TunjMasaKerja = spl.TunjMasaKerja,
            TunjLain = spl.TunjLain,
            OTP1 = spl.OTP1,
            OTP2 = spl.OTP2,
            OTP3 = spl.OTP3,
            OTP4 = spl.OTP4,
            OTPNominal1 = spl.OTPNominal1,
            OTPNominal2 = spl.OTPNominal2,
            OTPNominal3 = spl.OTPNominal3,
            OTPNominal4 = spl.OTPNominal4,
            CreatedAt = spl.CreatedAt,
            CreatedBy = spl.CreatedBy,
            UpdatedBy = spl.UpdatedBy,
            UpdatedAT = spl.UpdatedAT,
         //   SPLDetailDTOs = (from splDetail in spl.SPLDetails
         //                    select new SPLDetailDTO {
         //                       Id = splDetail.Id,
         //                       SPLId = splDetail.SPLId,
         //                       SuratPerintahLemburId = splDetail.SuratPerintahLemburId,
         //                       LemburKe = splDetail.LemburKe,
         //                       NominalLembur = splDetail.NominalLembur
         //                    }).ToList()
         };
      }

      public static IEnumerable<SuratPerintahLembur> ConvertToModel(this IEnumerable<SuratPerintahLemburDTO> splDTOs) {
         return (from splDTO in splDTOs
                 select new SuratPerintahLembur {
                     Id = splDTO.Id,
                     GroupId = splDTO.GroupId,
                     GroupName = splDTO.GroupName,
                     DepartmentId = splDTO.DepartmentId,
                     DepartmentName = splDTO.DepartmentName,
                     EmployeeId = splDTO.EmployeeId,
                     EmployeeName = splDTO.EmployeeName,
                     NIK = splDTO.NIK,
                     Description = splDTO.Description,
                     Style = splDTO.Style,
                     OTType = splDTO.OTType,
                     OTDate = splDTO.OTDate.Value.Date,
                     OT1 = splDTO.OT1,
                     OT2 = splDTO.OT2,
                     NominalOT1 = splDTO.NominalOT1,
                     NominalOT2 = splDTO.NominalOT2,
                     NominalOT3 = splDTO.NominalOT3,
                     NominalOT4 = splDTO.NominalOT4,
                     NominalOTTotal = splDTO.NominalOTTotal,
                     OTBreak = splDTO.OTBreak,
                     OTTotal = splDTO.OTTotal,
                     Upah = splDTO.Upah,
                     TunjJabatan = splDTO.TunjJabatan,
                     TunjKeterampilan = splDTO.TunjKeterampilan,
                     TunjMasaKerja = splDTO.TunjMasaKerja,
                     TunjLain = splDTO.TunjLain,
                    OTP1 = splDTO.OTP1,
                    OTP2 = splDTO.OTP2,
                    OTP3 = splDTO.OTP3,
                    OTP4 = splDTO.OTP4,
                    OTPNominal1 = splDTO.OTPNominal1,
                    OTPNominal2 = splDTO.OTPNominal2,
                    OTPNominal3 = splDTO.OTPNominal3,
                    OTPNominal4 = splDTO.OTPNominal4,
                    CreatedBy = splDTO.CreatedBy,
                     UpdatedBy = splDTO.UpdatedBy,
                     UpdatedAT = splDTO.UpdatedAT,
                     CreatedAt = splDTO.CreatedAt,
                     //SPLDetails = (from detail in splDTO.SPLDetailDTOs select new SPLDetail {
                     //    Id = detail.Id,
                     //    LemburKe = detail.LemburKe,
                     //    NominalLembur = detail.NominalLembur,
                     //    SPLId = detail.SPLId,
                     //    SuratPerintahLemburId = detail.SuratPerintahLemburId
                     //}).ToList()
                 }).ToList();
      }

      public static SuratPerintahLembur ConvertToModel(this SuratPerintahLemburDTO splDTO) {
         return new SuratPerintahLembur {
            Id = splDTO.Id,
            GroupId = splDTO.GroupId,
            GroupName = splDTO.GroupName,
            DepartmentId = splDTO.DepartmentId,
            DepartmentName = splDTO.DepartmentName,
            EmployeeId = splDTO.EmployeeId,
            EmployeeName = splDTO.EmployeeName,
            NIK = splDTO.NIK,
            Description = splDTO.Description,
            Style = splDTO.Style,
            OTType = splDTO.OTType,
            OTDate = splDTO.OTDate.Value.Date,
            OT1 = splDTO.OT1,
            NominalOT1 = splDTO.NominalOT1,
            OT2 = splDTO.OT2,
            NominalOT2 = splDTO.NominalOT2,
            NominalOT3 = splDTO.NominalOT3,
            NominalOT4 = splDTO.NominalOT4,
            OTBreak = splDTO.OTBreak,
            OTTotal = splDTO.OTTotal,
            NominalOTTotal = splDTO.NominalOTTotal,
            Upah = splDTO.Upah,
            TunjJabatan = splDTO.TunjJabatan,
            TunjKeterampilan = splDTO.TunjKeterampilan,
            TunjMasaKerja = splDTO.TunjMasaKerja,
            TunjLain = splDTO.TunjLain,
            OTP1 = splDTO.OTP1,
            OTP2 = splDTO.OTP2,
            OTP3 = splDTO.OTP3,
            OTP4 = splDTO.OTP4,
            OTPNominal1 = splDTO.OTPNominal1,
            OTPNominal2 = splDTO.OTPNominal2,
            OTPNominal3 = splDTO.OTPNominal3,
            OTPNominal4 = splDTO.OTPNominal4,
            CreatedBy = splDTO.CreatedBy,
            UpdatedBy = splDTO.UpdatedBy,
            UpdatedAT = splDTO.UpdatedAT,
            CreatedAt = splDTO.CreatedAt,
            //SPLDetails = (from detail in splDTO.SPLDetailDTOs
            //              select new SPLDetail {
            //                 Id = detail.Id,
            //                 LemburKe = detail.LemburKe,
            //                 NominalLembur = detail.NominalLembur,
            //                 SPLId = detail.SPLId,
            //                 SuratPerintahLemburId = detail.SuratPerintahLemburId
            //              }).ToList()
         };
      }
   }
}
