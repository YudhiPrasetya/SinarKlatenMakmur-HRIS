namespace UserAPI.Model
{
	public class User
	{
		public int? UserId { get; set; }
		public string? UserName { get; set; }
		public string? Password { get; set; }
		public string? Role { get; set; }
		public bool? IsActive { get; set; }
		public int? CreatedBy { get; set; }
		public DateTime? Created_At { get; set; }
		public int? UpdatedBy { get; set;}
		public DateTime? Updated_At { get;set; }
	}
}
