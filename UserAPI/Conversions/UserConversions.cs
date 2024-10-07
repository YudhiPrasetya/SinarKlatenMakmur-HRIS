using SKM.Shared.Dtos;
using UserAPI.Model;

namespace UserAPI.Conversions {
	public static class UserConversions {
		public static IEnumerable<UserDTO> ConvertToDTO(this IEnumerable<User> Users) {
			return (from user in Users select new UserDTO {
				UserId = user.UserId,
				UserName = user.UserName,
				Password = user.Password,
				Role = user.Role,
				IsActive = user.IsActive,
				CreatedBy = user.CreatedBy,
				Created_At = user.Created_At,
				UpdatedBy = user.UpdatedBy,
				Updated_At = user.Updated_At
			}).ToList();
		}

		public static UserDTO ConvertToDTO(this User user) {
			return new UserDTO {
				UserId = user.UserId,
				UserName = user.UserName,
				Password = user.Password,
				Role = user.Role,
				IsActive = user.IsActive,
				CreatedBy = user.CreatedBy,
				Created_At = user.Created_At,
				UpdatedBy = user.UpdatedBy,
				Updated_At = user.Updated_At
			};
		}

		public static IEnumerable<User> ConvertToModel(this IEnumerable<UserDTO?> userDTOs) {
			return (from user in userDTOs select new User {
				UserId= user.UserId,
				UserName = user?.UserName,
				Role = user?.Role,
				Password = user?.Password,
				IsActive = user?.IsActive,
				CreatedBy = user?.CreatedBy,
				Created_At= user?.Created_At,
				UpdatedBy= user?.UpdatedBy,
				Updated_At= user?.Updated_At
			}).ToList();
		}

		public static User ConvertToModel(this UserDTO userDTO) {
			return new User {
				UserId = userDTO.UserId,
				UserName = userDTO.UserName,
				Password= userDTO.Password,
				Role= userDTO.Role,
				IsActive = userDTO.IsActive,
				CreatedBy = userDTO.CreatedBy,
				Created_At = userDTO.Created_At,
				UpdatedBy = userDTO.UpdatedBy,
				Updated_At = userDTO.Updated_At
			};
		}

	}
}
