using SKM.Shared.Dtos;
using UserAPI.Model;

namespace UserAPI.Services
{
	public interface IUserService
	{
		public Task<IEnumerable<UserDTO>> GetUserListAsync();
		public Task<User> GetUserByIdAsync(int id);
		public Task<User> AddUserAsync(UserDTO userDTO);
		public Task<User> UpdateUserAsync(UserDTO userDTO);
		public Task<User> DeleteUserAsync(int id);
	}
}
