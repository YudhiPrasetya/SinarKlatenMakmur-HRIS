using SKM.Shared.Dtos;

namespace AuthAPI.Services {
	public interface IAuthService {
		public Task<UserDTO?> GetByUserName(string? userName);

		public Task<UserDTO?> SetUserActive(UserDTO userDTO);
		public Task<UserDTO?> SetDeactiveUser(string userName);
	}
}
