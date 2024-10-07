namespace HRIS.Models {
	public class TokenDTO {
		public string? UserName { get; set; }
		public string? Token { get; set; }
		public string? Role { get; set; }
		public string? Scopes { get; set; }
		public DateTime? ExpiresIn { get; set; }
	}
}
