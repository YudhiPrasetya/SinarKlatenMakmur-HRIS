using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace JwtTokenAuthentication;
public static class JwtExtensions
{
	public const string SecurityKey = "Yudhi_Fitri_Azlan_ 1234567890!0@#$^%&*()";

	public static void AddJwtAuthentication(this IServiceCollection services)
	{
		services.AddAuthentication(opt => {
			opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
			opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
		})
		.AddJwtBearer(options =>
		{
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidIssuer = "https://localhost:5002",
				//ValidIssuer = "http://localhost:9003",
				//ValidIssuer = "http://localhost:9002",
				ValidateAudience = false,
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey))
			};
		});
	}

}