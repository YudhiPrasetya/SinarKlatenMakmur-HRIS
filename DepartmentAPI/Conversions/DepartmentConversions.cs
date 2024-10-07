using DepartmentAPI.Models;
using SKM.Shared.Dtos;
using System.Runtime.CompilerServices;

namespace DepartmentAPI.Conversions {
   public static class DepartmentConversions {
      public static IEnumerable<DepartmentDTO> ConvertToDtO(this IEnumerable<Models.Department> departments) {
         return (from department in departments
                 select new DepartmentDTO {
                    DepartmentID = department.DepartmentID,
                    DepartmentName = department.DepartmentName,
                    DepartmentDescription = department.DepartmentDescription,
                    Budget = department.Budget,
                    IsActive= department.IsActive,
                    CreatedAt = department.CreatedAt,
                    CreatedBy = department.CreatedBy,
                    UpdatedAt = department.UpdatedAt,
                    UpdatedBy = department.UpdatedBy
                 }).ToList<DepartmentDTO>();
      }

      public static DepartmentDTO ConvertToDTO(this Models.Department department) {
         return new DepartmentDTO {
            DepartmentID = department.DepartmentID,
            DepartmentName = department.DepartmentName,
            DepartmentDescription = department.DepartmentDescription,
            Budget = department.Budget,
            IsActive = department.IsActive,
            CreatedAt = department.CreatedAt,
            CreatedBy = department.CreatedBy,
            UpdatedAt= department.UpdatedAt,
            UpdatedBy=department.UpdatedBy
         };
      }

      public static IEnumerable<Department> ConvertToModel(this IEnumerable<DepartmentDTO> departmentDTOs) {
         return (from departmentDTO in departmentDTOs
                 select new Department {
                    DepartmentID = departmentDTO.DepartmentID,
                    DepartmentName = departmentDTO.DepartmentName,
                    DepartmentDescription = departmentDTO.DepartmentDescription,
                    Budget = departmentDTO.Budget,
                    IsActive = departmentDTO.IsActive,
                    CreatedAt = departmentDTO.CreatedAt,
                    CreatedBy= departmentDTO.CreatedBy,
                    UpdatedAt = departmentDTO.UpdatedAt,
                    UpdatedBy = departmentDTO.UpdatedBy
                 }).ToList();
      }

      public static Department ConvertToModel(this DepartmentDTO departmentDTO) {
         return new Department {
            DepartmentID = departmentDTO.DepartmentID,
            DepartmentName = departmentDTO.DepartmentName,
            DepartmentDescription = departmentDTO.DepartmentDescription,
            Budget = departmentDTO.Budget,
            IsActive = departmentDTO.IsActive,
            CreatedAt = departmentDTO.CreatedAt,
            CreatedBy = departmentDTO.CreatedBy,
            UpdatedAt= departmentDTO.UpdatedAt,
            UpdatedBy= departmentDTO.UpdatedBy
         };
      }
   }
}