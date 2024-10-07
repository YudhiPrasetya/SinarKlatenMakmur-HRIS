using AuthenticationManager;
using AuthenticationManager.Models;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationWebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AccountController : ControllerBase
	{
		private readonly JwtTokenHandler _jwtTokenHandler;
		public AccountController(JwtTokenHandler jwtTokenHandler)
		{
			_jwtTokenHandler = jwtTokenHandler;
		}

		[HttpPost]
		public ActionResult<AuthenticationResponse?> Authenticat([FromBody] AuthenticationRequest authenticationRequest) { 
			var authenticationResponse = _jwtTokenHandler.GenerateJwtToken(authenticationRequest);
			if(authenticationResponse == null) return Unauthorized();
			return authenticationResponse;
		}
	}
}
