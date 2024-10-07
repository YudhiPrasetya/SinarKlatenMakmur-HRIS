using PayrollAPI.Model;
using SKM.Shared.Dtos;

namespace PayrollAPI.Conversions {
   public static class PayrollConversions {
      public static IEnumerable<PayrollDTO> ConvertToDTO(this IEnumerable<Payroll> payrolls) {
         return (from p in payrolls
                 select new PayrollDTO {
                    Id = p.Id,
                    Bulan = p.Bulan,
                    Tahun = p.Tahun,
                    Tgl = p.Tgl,
                    IdEmployee = p.IdEmployee,
                    NIK = p.NIK,
                    EmployeeName = p.EmployeeName,
                    GroupName = p.GroupName,
                    DepartmentName = p.DepartmentName,
                    Upah = p.Upah,
                    TotalMasuk = p.TotalMasuk,
                    TotalLembur = p.TotalLembur,
                    Gaji = p.Gaji,
                    CreatedBy = p.CreatedBy,
                    CreatedAt = p.CreatedAt,
                    UpdatedBy = p.UpdatedBy,
                    UpdatedAt = p.UpdatedAt
                 }).ToList();
      }

      public static PayrollDTO ConvertToDTO (this Payroll p) {
         return new PayrollDTO {
            Id = p.Id,
            Bulan = p.Bulan,
            Tahun = p.Tahun,
            Tgl = p.Tgl,
            IdEmployee = p.IdEmployee,
            NIK = p.NIK,
            EmployeeName = p.EmployeeName,
            GroupName = p.GroupName,
            DepartmentName = p.DepartmentName,
            Upah = p.Upah,
            TotalMasuk = p.TotalMasuk,
            TotalLembur = p.TotalLembur,
            Gaji = p.Gaji,
            CreatedBy = p.CreatedBy,
            CreatedAt = p.CreatedAt,
            UpdatedBy = p.UpdatedBy,
            UpdatedAt = p.UpdatedAt
         };
      }

      public static IEnumerable<Payroll> ConvertToModel(this IEnumerable<PayrollDTO> payrollDTOs) {
         return (from p in payrollDTOs
                 select new Payroll {
                    Id = p.Id,
                    Bulan = p.Bulan,
                    Tahun = p.Tahun,
                    Tgl = p.Tgl,
                    IdEmployee = p.IdEmployee,
                    NIK = p.NIK,
                    EmployeeName = p.EmployeeName,
                    GroupName = p.GroupName,
                    DepartmentName = p.DepartmentName,
                    Upah = p.Upah,
                    TotalMasuk = p.TotalMasuk,
                    TotalLembur = p.TotalLembur,
                    Gaji = p.Gaji,
                    CreatedBy = p.CreatedBy,
                    CreatedAt = p.CreatedAt,
                    UpdatedBy = p.UpdatedBy,
                    UpdatedAt = p.UpdatedAt
                 }).ToList();
      }

      public static Payroll ConvertToModel(this PayrollDTO p) {
         return new Payroll {
            Id = p.Id,
            Bulan = p.Bulan,
            Tahun = p.Tahun,
            Tgl = p.Tgl,
            IdEmployee = p.IdEmployee,
            NIK = p.NIK,
            EmployeeName = p.EmployeeName,
            GroupName = p.GroupName,
            DepartmentName = p.DepartmentName,
            Upah = p.Upah,
            TotalMasuk = p.TotalMasuk,
            TotalLembur = p.TotalLembur,
            Gaji = p.Gaji,
            CreatedBy = p.CreatedBy,
            CreatedAt = p.CreatedAt,
            UpdatedBy = p.UpdatedBy,
            UpdatedAt = p.UpdatedAt
         };
      }
   }
}
