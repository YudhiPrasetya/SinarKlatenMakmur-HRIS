using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Models {
   public class SuratPerintahLemburCreated {
      public int Id { get; set; }
      public string GroupName { get; set; }
      public string DepartmentName { get; set; }
      public int EmployeeId { get; set; }
      public string EmployeeName { get; set; }
      public string NIK { get; set; }
      public DateTime OTDate { get; set; }
      public decimal Upah { get; set; }
      public decimal UpahLembur { get; set; }
   }
}
