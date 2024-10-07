using System.ComponentModel.DataAnnotations;

namespace HRIS.Models {
	public class UserLoginDTO {
		[Required]
		public string? UserName { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string? Password { get; set; }

		public string? Role { get; set; }

		public string? Scopes { get; set; }
	}
}
