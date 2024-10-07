using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollAPI.Model {
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

      public int CreatedBy { get; set; } = 1;
      public DateTime? CreatedAt { get; set; } = DateTime.Now;
      public int UpdatedBy { get; set; } = 1;
      public DateTime? UpdatedAt { get; set; } = DateTime.Now;

    }
}
