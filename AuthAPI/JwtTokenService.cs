using AuthAPI.Models;
using JwtTokenAuthentication;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.IdentityModel.Tokens;
using SKM.Shared.Dtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthAPI
{
	public class JwtTokenService
	{
		public AuthenticationToken? GenerateAuthToken(UserDTO user)
		{
			var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtExtensions.SecurityKey));
			var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

			var expirationTimeStamp = DateTime.Now.AddMinutes(120);

			List<Claim> claims = new ()
			{
				//new Claim(ClaimTypes.Name, user.UserName!),
				//new Claim(ClaimTypes.Role, user.Role!)
				new Claim(JwtRegisteredClaimNames.Name, user!.UserName!.ToString()),
				//new Claim(JwtRegisteredClaimNames.Name, "admin"),
				new Claim("Role", user.Role!),
				new Claim("scope", string.Join("; ", user!.Scopes!)),
				//new Claim("Role", user.Role),
				//new Claim("Role", "Administrator"),
				//new Claim("scope", string.Join(" ", user.Scopes))
			};

			var tokenOptions = new JwtSecurityToken(
					issuer: "https://localhost:5002",
					//issuer: "http://localhost:9003",
					//issuer: "http://localhost:9002",
					claims: claims,
					expires: expirationTimeStamp,
					signingCredentials: signingCredentials
					
			);

			var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
			//JwtSecurityToken securityToken = new JwtSecurityToken(tokenString);

			return new AuthenticationToken(user.UserName!, user.Role!, user.Scopes!, tokenString, expirationTimeStamp);
		}

        public bool IsTokenValid(string token) {
			JwtSecurityToken jwtSecurityToken;
			try {
				jwtSecurityToken = new JwtSecurityToken(token);
			}
			catch (Exception) {
				return false;
			}
			//return jwtSecurityToken.ValidTo > DateTime.UtcNow;
            return jwtSecurityToken.ValidTo > DateTime.Now;
        }	
	}
}
