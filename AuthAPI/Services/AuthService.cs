using SKM.Shared.Dtos;
using Microsoft.EntityFrameworkCore;

using System.Reflection.Metadata.Ecma335;
//using UserAPI.Conversions;
using AuthAPI.Data;
using AuthAPI.Models;
using AuthAPI.Conversions;

namespace AuthAPI.Services {
	public class AuthService : IAuthService {
		private readonly AuthDbContextClass authDbContextClass;
      public AuthService(AuthDbContextClass _authDbContextClass)
      {
			authDbContextClass = _authDbContextClass;
		}

      public async Task<UserDTO?> GetByUserName(string? userName){
			User? user = await authDbContextClass.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync();

			return user.ConvertToDTO();
		}

      public async Task<UserDTO?> SetUserActive(UserDTO userDTO) {
         User? user = authDbContextClass.Users.Where(u => u.UserName == userDTO.UserName).FirstOrDefault();
         user!.IsActive = true;
         authDbContextClass.Users.Update(user);
         await authDbContextClass.SaveChangesAsync();

         return user.ConvertToDTO();

      }

      public async Task<UserDTO?> SetDeactiveUser(string? userName) {
         
         User? user = await authDbContextClass.Users.Where(u => u.UserName == userName).FirstOrDefaultAsync();
         user!.IsActive = false;
         authDbContextClass.Users.Update(user);
         await authDbContextClass.SaveChangesAsync();

         return user.ConvertToDTO();

      }
   }
}
