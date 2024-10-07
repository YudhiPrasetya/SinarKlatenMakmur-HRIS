using Microsoft.EntityFrameworkCore;
using PositionAPI.Data;
using PositionAPI.Services;
//using JwtTokenAuthentication;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddScoped<IPositionService, PositionService>();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddDbContext<PositionDbContextClass>();
//builder.Services.AddStackExchangeRedisCache(options => { options.Configuration = configuration["RedisCacheUrl"]; });
builder.Services.AddControllers();
//builder.Services.AddJwtAuthentication();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//using (var scope = app.Services.CreateScope()) {
//   var db = scope.ServiceProvider.GetRequiredService<PositionDbContextClass>();
//   db.Database.Migrate();
//}

app.Run();
