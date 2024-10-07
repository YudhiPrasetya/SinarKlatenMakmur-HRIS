using ExceptionAPI.Data;
using ExceptionAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
ConfigurationManager configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddDbContext<ExceptionDBContext>();
builder.Services.AddScoped<IExceptionService, ExceptionService>();
//builder.Services.AddStackExchangeRedisCache(options => { options.Configuration = configuration["RedisCacheUrl"]; });
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//using (var scope = app.Services.CreateScope()) {
//   var db = scope.ServiceProvider.GetRequiredService<ExceptionDBContext>();
//   db.Database.Migrate();
//}

app.Run();
