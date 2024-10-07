using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Dtos {
   public class ExceptionDTO {
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

      public int CreatedBy { get; set; }

      public DateTime? UpdatedAt { get; set; } = DateTime.Now;

      public int UpdatedBy { get; set; }
   }
}
