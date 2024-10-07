using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Models {
   public class PayrollCreated {
      public int Id { get; set; }
      public int? Bulan { get; set; }
      public int? Tahun { get; set; }
      public int IdEmployee { get; set; }
      public string NIK { get; set; }
      public string EmployeeName { get; set; }
      public string GroupName { get; set; }
      public string DepartmentName { get; set; }
      public int Upah { get; set; }
      public int TotalMasuk { get; set; }
      public int TotalLembur { get; set; }
      public int Gaji { get; set; }
   }
}
