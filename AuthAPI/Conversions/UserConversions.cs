using SKM.Shared.Dtos;
using AuthAPI.Models;

namespace AuthAPI.Conversions {
	public static class UserConversions {
		public static IEnumerable<UserDTO> ConvertToDTO(this IEnumerable<User> Users) {
			return (from user in Users select new UserDTO {
				UserId = user.UserId,
				UserName = user.UserName,
				Password = user.Password,
				Role = user.Role,
				IsActive = user.IsActive,
				Scopes = user.Scopes,
				CreatedBy = user.CreatedBy,
				Created_At = user.Created_At,
				UpdatedBy = user.UpdatedBy,
				Updated_At = user.Updated_At,
				RefreshToken = user.RefreshToken,
				RefreshTokenExpiryTime = user.RefreshTokenExpiryTime,
			}).ToList();
		}

		public static UserDTO? ConvertToDTO(this User? user) {
			return new UserDTO {
				UserId = user?.UserId,
				UserName = user?.UserName,
				Password = user?.Password,
				Role = user?.Role,
				IsActive = user?.IsActive,
				Scopes = user?.Scopes,
				CreatedBy = user?.CreatedBy,
				Created_At = user?.Created_At,
				UpdatedBy = user?.UpdatedBy,
				Updated_At = user?.Updated_At,
            RefreshToken = user.RefreshToken,
            RefreshTokenExpiryTime = user.RefreshTokenExpiryTime,
         };
		}

		public static IEnumerable<User> ConvertToModel(this IEnumerable<UserDTO> userDTOs) {
			return (from user in userDTOs select new User {
				UserId= user.UserId,
				UserName = user.UserName,
				Role = user.Role,
				Password = user.Password,
				IsActive = user.IsActive,
				Scopes	= user.Scopes,
				CreatedBy = user.CreatedBy,
				Created_At= user.Created_At,
				UpdatedBy= user.UpdatedBy,
				Updated_At= user.Updated_At,
            RefreshToken = user.RefreshToken,
            RefreshTokenExpiryTime = user.RefreshTokenExpiryTime,
         }).ToList();
		}

		public static User ConvertToModel(this UserDTO userDTO) {
			return new User {
				UserId = userDTO.UserId,
				UserName = userDTO.UserName,
				Password= userDTO.Password,
				Role= userDTO.Role,
				IsActive = userDTO.IsActive,
				Scopes= userDTO.Scopes,
				CreatedBy = userDTO.CreatedBy,
				Created_At = userDTO.Created_At,
				UpdatedBy = userDTO.UpdatedBy,
				Updated_At = userDTO.Updated_At,
            RefreshToken = userDTO.RefreshToken,
            RefreshTokenExpiryTime = userDTO.RefreshTokenExpiryTime,
         };
		}

	}
}
