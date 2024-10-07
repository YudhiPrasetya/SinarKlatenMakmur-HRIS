//using AuthenticationManager;
//using JwtTokenAuthentication;
using APIGateway;
using JwtTokenAuthentication;
using Microsoft.Extensions.Hosting.Internal;
using Ocelot.Authorization;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.IdentityModel.Tokens;
using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using System.Linq;
using System.Security.Claims;
using System.Text.RegularExpressions;
//using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddJwtAuthentication();
	
// Add services to the container.
builder.Services.AddCors(options =>
{
	options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
}); // added

//builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Configuration.AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", false, true); // added
Console.WriteLine($"EnvironmentName: {builder.Environment.EnvironmentName}");
//IConfiguration ocelotConfig1 = new ConfigurationBuilder().AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", false, true).Build();

builder.Services.AddControllers();
builder.Services.AddOcelot();

//builder.Services.AddOcelot(builder.Configuration).AddCacheManager(o => {o.WithDictionaryHandle();});
//builder.Services.AddCustomJwtAuthentication(); // added
//builder.Services.AddJwtAuthentication();

//builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//	.AddJwtBearer(options => {
//		options.TokenValidationParameters = new TokenValidationParameters {
//			ValidateIssuer = true,
//			ValidateAudience = true,
//			ValidateLifetime = true,
//			ValidateIssuerSigningKey = true,
//			ValidIssuer = builder.Configuration["JwtSettings:Issuer"],
//			ValidAudience = builder.Configuration["JwtSettings:Audience"],
//			IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JwtSettings:Key"]))
//		};

//		options.Events = new JwtBearerEvents {
//			OnAuthenticationFailed = async (context) => {

//			},
//			OnChallenge = async (context) => {

//			}
//		};
//	});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseCors("CORSPolicy");

app.UseHttpsRedirection();

var ocelotPipelineConfig = new OcelotPipelineConfiguration {
	AuthorizationMiddleware = async (ctx, next) => {
		if (OcelotJWTMiddleware.Authorize(ctx)) {
			await next.Invoke();
		}
		else {
			ctx.Items.SetError(new UnauthorizedError($"Fail to authorize"));
		}
	}
};

app.UseOcelot(ocelotPipelineConfig).Wait();

app.UseAuthentication(); // added
app.UseAuthorization();

app.MapControllers();


app.Run();
