using Microsoft.EntityFrameworkCore;
using SKM.Shared.Dtos;
using UserAPI.Conversions;
using UserAPI.Data;
using UserAPI.Model;

namespace UserAPI.Services
{
	public class UserService : IUserService
	{
		private readonly UserDbContextClass _dbContextClass;

		public UserService(UserDbContextClass dbContextClass)
		{
			_dbContextClass = dbContextClass;
		}
		public async Task<User> AddUserAsync(UserDTO userDTO)
		{
			//throw new NotImplementedException();
			var rst = _dbContextClass.Users.Add(userDTO.ConvertToModel());
			await _dbContextClass.SaveChangesAsync();

			return rst.Entity;
		}

		public async Task<User> DeleteUserAsync(int id)
		{
			//throw new NotImplementedException();
			var user = await _dbContextClass.Users.FindAsync(id);
			if(user != null) {
				var deletedUser = _dbContextClass.Remove(user);
				await _dbContextClass.SaveChangesAsync();
				return deletedUser.Entity;
			}
			return default;

		}

		public async Task<User> GetUserByIdAsync(int id)
		{
			//throw new NotImplementedException();
			return await _dbContextClass.Users.FindAsync(id);
		}

		public async Task<IEnumerable<UserDTO>> GetUserListAsync()
		{
			//throw new NotImplementedException();
			IEnumerable<User> users = await _dbContextClass.Users.ToListAsync();

			return users.ConvertToDTO();
		}

		public async Task<User> UpdateUserAsync(UserDTO userDTO)
		{
			//throw new NotImplementedException();
			var rst = _dbContextClass.Users.Update(userDTO.ConvertToModel());
			await _dbContextClass.SaveChangesAsync();

			return rst.Entity;
		}
	}
}
