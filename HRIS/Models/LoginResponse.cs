namespace HRIS.Models
{
	public class LoginResponse
	{
		public int UserId { get; set; }
		public string UserName { get; set; }
		public string JwtToken { get; set; }
		public int ExpiresIn { get; set; }
	}
}
