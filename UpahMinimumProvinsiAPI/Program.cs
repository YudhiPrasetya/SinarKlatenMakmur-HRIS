using Microsoft.EntityFrameworkCore;
using UpahMinimumProvinsiAPI.Data;
using UpahMinimumProvinsiAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => {
   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<IUMPService, UMPService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("CORSPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//using (var scope = app.Services.CreateScope()) {
//   var db = scope.ServiceProvider.GetRequiredService<DbContextClass>();
//   db.Database.Migrate();
//}

app.Run();
