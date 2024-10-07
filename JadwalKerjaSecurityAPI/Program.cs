using JadwalKerjaSecurityAPI.Data;
using JadwalKerjaSecurityAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<JadwalKerjaSecurityDbContext>();
builder.Services.AddScoped<IJadwalKerjaSecurityService, JadwalKerjaSecurityService>();

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
