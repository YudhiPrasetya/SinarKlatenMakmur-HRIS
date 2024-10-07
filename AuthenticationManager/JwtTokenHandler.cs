using AuthenticationManager.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthenticationManager
{
	public class JwtTokenHandler
	{
		public const string JWT_SECURITY_KEY = "hthgjYUDHIu0987654321|+_)*(^&%$@#!FITRI";
		private const int JWT_TOKEN_VALIDITY_MINS = 60;
		private readonly List<UserAccount> _userAccountList;
		public JwtTokenHandler()
		{
			_userAccountList = new List<UserAccount>
			{
				new UserAccount
				{
					 UserId=1,
					 UserName="ROOT",
					 Password="ADMIN",
					 Role="Administrator",
					 IsActive=true,
					 IsSpv=true,
					 CreatedAt= DateTime.Parse("2014-08-19 09:34:21")
				},
				new UserAccount
				{
					 UserId=2,
					 UserName="USER",
					 Password="USER123",
					 Role="User",
					 IsActive=true,
					 IsSpv=false,
					 CreatedAt= DateTime.Parse("2018-01-12 16:09:13")
				}
			};
		}

		public AuthenticationResponse? GenerateJwtToken(AuthenticationRequest authenticationRequest)
		{
			if(string.IsNullOrWhiteSpace(authenticationRequest.UserName) || string.IsNullOrWhiteSpace(authenticationRequest.Password))
			{
				return null;
			}

			// Validation
			var userAccount = _userAccountList.Where(u => u.UserName == authenticationRequest.UserName && u.Password == authenticationRequest.Password).FirstOrDefault();
			if (userAccount == null) return null;

			var tokenExpiryTimeStamp = DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY_MINS);
			var tokenKey = Encoding.ASCII.GetBytes(JWT_SECURITY_KEY);
			var claimsIdentity = new ClaimsIdentity(new List<Claim>
			{
				new Claim(JwtRegisteredClaimNames.Name, userAccount.UserName),
				new Claim(ClaimTypes.Role, userAccount.Role)
				//new Claim("Role", userAccount.Role)
			});

			var signingCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature);
			var securityTokenDescriptor = new SecurityTokenDescriptor
			{
				Subject = claimsIdentity,
				Expires = tokenExpiryTimeStamp,
				SigningCredentials = signingCredentials
			};

			var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
			var securityToken = jwtSecurityTokenHandler.CreateToken(securityTokenDescriptor);
			var token = jwtSecurityTokenHandler.WriteToken(securityToken);

			return new AuthenticationResponse
			{
				UserId = userAccount.UserId,
				UserName = userAccount.UserName,
				JwtToken = token,
				ExpiresIn = (int)tokenExpiryTimeStamp.Subtract(DateTime.Now).TotalSeconds
			};

		}
	}
}
