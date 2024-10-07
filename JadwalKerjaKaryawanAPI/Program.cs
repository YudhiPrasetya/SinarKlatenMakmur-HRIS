using JadwalKerjaKaryawanAPI.Data;
using JadwalKerjaKaryawanAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => {
   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
// Add services to the container.
builder.Services.AddDbContext<JadwalKerjaKaryawanDbContext>();
builder.Services.AddScoped<IJadwalKerjaKaryawanService, JadwalKerjaKaryawanService>();
builder.Services.AddScoped<ICacheService, CacheService>();

builder.Services.AddControllers();

var app = builder.Build();
app.UseCors("CORSPolicy");
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
