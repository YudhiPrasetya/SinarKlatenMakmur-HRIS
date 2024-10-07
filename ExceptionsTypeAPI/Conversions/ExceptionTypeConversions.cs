using ExceptionsTypeAPI.Model;
using SKM.Shared.Dtos;

namespace ExceptionsTypeAPI.Conversions {
   public static class ExceptionTypeConversions {
      public static IEnumerable<ExceptionTypeDTO> ConvertToDtO(this IEnumerable<ExceptionType> exceptionTypes) {
         return (from et in exceptionTypes
                 select new ExceptionTypeDTO{
                    Id= et.Id,
                    ExceptionName = et.ExceptionName
                 }).ToList<ExceptionTypeDTO>();
      }

      public static ExceptionTypeDTO ConvertToDTO(this ExceptionType exceptionType) {
         return new ExceptionTypeDTO {
            Id = exceptionType.Id,
            ExceptionName = exceptionType.ExceptionName
         };
      }

      public static IEnumerable<ExceptionType> ConvertToModel(this IEnumerable<ExceptionTypeDTO> exceptionTypeDTOs) {
         return (from exceptionTypeDTO in exceptionTypeDTOs
                 select new ExceptionType {
                    Id= exceptionTypeDTO.Id,
                    ExceptionName = exceptionTypeDTO.ExceptionName
                 }).ToList();
      }

      public static ExceptionType ConvertToModel(this ExceptionTypeDTO exceptionTypeDTO) {
         return new ExceptionType {
            Id= exceptionTypeDTO.Id,
            ExceptionName = exceptionTypeDTO.ExceptionName
         };
      }

   }
}
