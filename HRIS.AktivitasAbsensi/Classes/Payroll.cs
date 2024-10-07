using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.AktivitasAbsensi.Classes {
   public class Payroll {
      public int Id { get; set; }
      public int? Bulan { get; set; }
      public int? Tahun { get; set; }
      public DateTime? Tgl { get; set; }
      public int IdEmployee { get; set; }
      public string NIK { get; set; }
      public string EmployeeName { get; set; }
      public string GroupName { get; set; }
      public string DepartmentName { get; set; }
      public decimal Upah { get; set; }
      public int TotalMasuk { get; set; }
      public decimal TotalLembur { get; set; }
      public decimal Gaji { get; set; }
      public int CreatedBy { get; set; }
      public DateTime? CreatedAt { get; set; }
      public int UpdatedBy { get; set; }
      public DateTime? UpdatedAt { get; set; }
   }
}
