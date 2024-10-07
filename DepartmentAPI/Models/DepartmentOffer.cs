namespace DepartmentAPI.Models
{
	public class DepartmentOffer
	{
      public int DepartmentID { get; set; }
      public string DepartmentName { get; set; }
      public string DepartmentDescription { get; set; }
      public bool IsActive { get; set; }
      public DateTime? CreatedAt { get; set; }
      public int CreatedBy { get; set; }
      public DateTime? UpdatedAt { get; set; }
      public int UpdatedBy { get; set; }
   }
}
