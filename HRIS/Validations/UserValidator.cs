using FluentValidation;
using SKM.Shared.Dtos;

namespace HRIS.Validations {
	public class UserValidator: AbstractValidator<UserDTO> {
		public UserValidator() {
			RuleFor(userDTO => userDTO.UserName).NotEmpty().WithMessage("User name cannot be empty!");
			RuleFor(userDTO => userDTO.Password).NotEmpty().WithMessage("Password cannot be empty!")
				.MinimumLength(6).WithMessage("Your password length must be at least 6 characters.")
				.Matches(@"[A-Z]+").WithMessage("Your password must containat at least one uppercase letter.")
				.Matches(@"[a-z]+").WithMessage("Your password must containat at least one lowercase letter.")
				.Matches(@"[0-9]+").WithMessage("Your password must containat at least one number.");
			RuleFor(userDTO => userDTO.Role).NotEmpty().WithMessage("Role cannot be empty!");

		}
	}
}
