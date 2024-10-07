using AuthAPI.Models;
using AuthAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;

namespace AuthAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase
	{
		private readonly IAuthService authService;
		private readonly JwtTokenService _jwtTokenService;
		
		public AuthController(JwtTokenService jwtTokenService, IAuthService _authService)
		{
			authService = _authService;
			_jwtTokenService = jwtTokenService;
		}

		[HttpPost]
		public async Task<IActionResult> LoginAsync([FromBody] UserDTO? user)
		{
			UserDTO? userExist = await authService.GetByUserName(user?.UserName);
			if (userExist?.UserId == null) {
				return NotFound("User name not found!");
			}
			else if(userExist.IsActive == true){
				return Unauthorized("User sedang aktif!");
			}
			else {
				string pswFromDB = userExist.Password!;
				string encPsw = EncryptDecryptString.EncryptSHA256Hash(user?.Password);
				if(pswFromDB != encPsw) {
					return Unauthorized("Incorect password!");
				}
				else {
					await authService.SetUserActive(userExist);
					var loginRst = _jwtTokenService.GenerateAuthToken(userExist);
					//return loginRst is null ? Unauthorized("Not authorized!") : Ok(loginRst);
					return Ok(loginRst);
				}
			}

		}

		[HttpPost("deactiveuser")]
		public async Task<IActionResult> DeactiveUser([FromBody] string userName) {
			var result = await authService.SetDeactiveUser(userName);
			return Ok(result);
		}
	}
}
