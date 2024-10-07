using SKM.Shared.Dtos;
using ExceptionAPI.Model;
using System;

namespace ExceptionAPI.Conversions {
   public static class ExceptionConversions {
      public static IEnumerable<ExceptionDTO> ConvertToDtO(this IEnumerable<Model.Exception> exceptions) {
         return (from exception in exceptions
                 select new ExceptionDTO {
                    Id = exception.Id,
                    GrupKerja = exception.GrupKerja,
                    NIK = exception.NIK,
                    Nama = exception.Nama,
                    //IdException= exception.IdException,
                    ExceptionName= exception.ExceptionName,
                    StartDate= exception.StartDate,
                    EndDate = exception.EndDate,
                    Detail = exception.Detail,
                    CreatedAt = exception.CreatedAt,
                    CreatedBy = exception.CreatedBy,
                    UpdatedAt= exception.UpdatedAt,
                    UpdatedBy= exception.UpdatedBy
                 }).ToList<ExceptionDTO>();
      }

      public static ExceptionDTO ConvertToDTO(this Model.Exception exception) {
         return new ExceptionDTO {
            Id = exception.Id,
            GrupKerja= exception.GrupKerja,
            NIK = exception.NIK,
            Nama = exception.Nama,
            //IdException = exception.IdException,
            ExceptionName = exception.ExceptionName,
            StartDate = exception.StartDate,
            EndDate = exception.EndDate,
            Detail = exception.Detail,
            CreatedAt = exception.CreatedAt,
            CreatedBy = exception.CreatedBy,
            UpdatedAt = exception.UpdatedAt,
            UpdatedBy = exception.UpdatedBy
         };
      }

      public static IEnumerable<Model.Exception> ConvertToModel(this IEnumerable<ExceptionDTO> exceptionDTOs) {
         return (from exceptionDTO in exceptionDTOs
                 select new Model.Exception {
                    Id = exceptionDTO.Id,
                    GrupKerja = exceptionDTO.GrupKerja,
                    NIK = exceptionDTO.NIK,
                    Nama = exceptionDTO.Nama,
                    //IdException = exceptionDTO.IdException,
                    ExceptionName = exceptionDTO.ExceptionName,
                    StartDate = exceptionDTO.StartDate,
                    EndDate = exceptionDTO.EndDate,
                    Detail = exceptionDTO.Detail,
                    CreatedAt = exceptionDTO.CreatedAt,
                    CreatedBy = exceptionDTO.CreatedBy,
                    UpdatedAt = exceptionDTO.UpdatedAt,
                    UpdatedBy = exceptionDTO.UpdatedBy
                 }).ToList();
      }

      public static Model.Exception ConvertToModel(this ExceptionDTO exceptionDTO) {
         return new Model.Exception {
            Id = exceptionDTO.Id,
            GrupKerja = exceptionDTO.GrupKerja,
            NIK = exceptionDTO.NIK,
            Nama = exceptionDTO.Nama,
            //IdException = exceptionDTO.IdException,
            ExceptionName = exceptionDTO.ExceptionName,
            StartDate = exceptionDTO.StartDate,
            EndDate = exceptionDTO.EndDate,
            Detail = exceptionDTO.Detail,
            CreatedAt = exceptionDTO.CreatedAt,
            CreatedBy = exceptionDTO.CreatedBy,
            UpdatedAt = exceptionDTO.UpdatedAt,
            UpdatedBy = exceptionDTO.UpdatedBy
         };
      }
   }
}
