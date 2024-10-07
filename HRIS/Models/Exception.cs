namespace HRIS.Models {
   public class Exception {
      public int Id { get; set; }
      public string NIK { get; set; }
      public string Nama { get; set; }
      public int IdException { get; set; }
      public string ExceptionName { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public string Detail { get; set; }
      public DateTime CreatedAt { get; set; }
      public int CreatedBy { get; set; }
      public DateTime UpdatedAt { get; set; }
      public int UpdatedBy { get; set; }

   }
}
