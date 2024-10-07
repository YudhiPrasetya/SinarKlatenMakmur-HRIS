using System.ComponentModel.DataAnnotations;

namespace HRIS.Models
{
	public class User
	{
		[Required(ErrorMessage = "User name is required!")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Password is required!")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		public string Token { get; set; }

		public int ExpiresIn { get; set; }
	}
}
