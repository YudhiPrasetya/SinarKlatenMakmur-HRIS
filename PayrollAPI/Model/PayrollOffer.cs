namespace PayrollAPI.Model {
   public class PayrollOffer {
      public int Id { get; set; }
      public int? Bulan { get; set; }
      public int? Tahun { get; set; }
      public int IdEmployee { get; set; }
      public string EmployeeName { get; set; }
      public string GroupName { get; set; }
      public string DepartmentName { get; set; }
      public int Upah { get; set; }
      public int TotalMasuk { get; set; }
      public int TotalLembur { get; set; }
      public int Gaji { get; set; }
   }
}
