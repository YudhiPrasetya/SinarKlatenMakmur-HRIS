using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace ExceptionAPI.Model {
   public class Exception {
      public int Id { get; set; }
      public string GrupKerja { get; set; }
      public string NIK { get; set; }
      public string Nama { get; set; }
      //public int? IdException { get; set; }
      public string? ExceptionName { get; set; }
      public DateTime? StartDate { get; set; }
      public DateTime? EndDate { get; set; }

      public string? Detail { get; set; }
      public DateTime? CreatedAt { get; set; } = DateTime.Now;
      public int CreatedBy { get; set; } = 1;
      public DateTime? UpdatedAt { get; set; } = DateTime.Now;
      public int UpdatedBy { get; set; } = 1;

   }
}
