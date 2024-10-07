using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ExceptionsTypeAPI.Model {
   public class ExceptionType {
      [DefaultValue(0)]
      public int Id { get; set; }
      public string ExceptionName { get; set; }
   }
}
