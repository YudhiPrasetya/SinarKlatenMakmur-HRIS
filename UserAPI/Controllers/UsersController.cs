using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;
using UserAPI.Conversions;
using UserAPI.Model;
using UserAPI.RabbitMQ;
using UserAPI.Services;

namespace UserAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IUserService userService;
		private readonly IRabbitMqProducer? rabbitMqProducer;

   public UsersController(IUserService _userService)
	{
		userService = _userService;
      //rabbitMqProducer = _rabbitMqProducer;
   }

		[HttpGet]
		//public Task<IEnumerable<UserDTO>> UserListAsync()
		//{
		//	var users = userService.GetUserListAsync();
		//	return users;
		//}
		public async Task<IEnumerable<UserDTO>> UserListAsync() {
			var users = await userService.GetUserListAsync();
			return users;

		}

		//[HttpGet("userListTriggered")]
		//public Task<IEnumerable<User>> UserListTriggerd()
		//{
		//	var userList = userService.GetUserListAsync();
		//	rabbitMqProducer.SendUserMessage(userList);
		//	return userList;
		//}

		[HttpGet("{id}")]
		public async Task<User> GetUserByIdAsync(int id)
		{
			return await userService.GetUserByIdAsync(id);
		}

		[HttpPost]
		//[Authorize(Roles = "Administrator")]
		//[Authorize]
		public async Task<UserDTO> AddUserAsync(UserDTO userDTO)
		{
			var user = await userService.AddUserAsync(userDTO);
			return user.ConvertToDTO();
		}

		[HttpPut]
		public async Task<UserDTO> UpdateUserAsync(UserDTO userDTO)
		{
			var user = await userService.UpdateUserAsync(userDTO);
			return user.ConvertToDTO();
		}

		[HttpDelete("{id}")]
		public async Task<UserDTO> DeleteUserAsync(int id)
		{
			var user = await userService.DeleteUserAsync(id);
			return user.ConvertToDTO();
		}
	}
}
