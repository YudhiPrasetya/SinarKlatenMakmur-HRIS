using ShiftAPI.Data;
using ShiftAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ShiftDbContext>();
builder.Services.AddScoped<IjamKerjaService, JamKerjaService>();
builder.Services.AddScoped<IJadwalShiftKaryawanService, JadwalShiftKaryawanService>();
builder.Services.AddScoped<IJadwalShiftSecurityService, JadwalShiftSecurityService>();
builder.Services.AddScoped<IJadwalShiftDepartemenService, JadwalShiftDepartemenService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
