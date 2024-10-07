namespace DepartmentAPI.Models {
   public class Department {
      public int DepartmentID { get; set; } = 0;
      public string DepartmentName { get; set; }
      public string DepartmentDescription { get; set; }
      public int Budget { get; set; } = 0;
      public bool IsActive { get; set; } = true;
      public DateTime? CreatedAt { get; set; } = DateTime.Now;
      public int CreatedBy { get; set; } = 1;
      public DateTime? UpdatedAt { get; set; } = DateTime.Now;
      public int UpdatedBy { get; set; } = 1;
   }
}
