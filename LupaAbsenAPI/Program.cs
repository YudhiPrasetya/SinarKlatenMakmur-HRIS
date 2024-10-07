using LupaAbsenAPI.Data;
using LupaAbsenAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => {
   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
// Add services to the container.
builder.Services.AddDbContext<LupaAbsenDbContext>();
builder.Services.AddScoped<ILupaAbsenService, LupaAbsenService>();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddControllers();

var app = builder.Build();
app.UseCors("CORSPolicy");
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//using (var scope = app.Services.CreateScope()) {
//   var db = scope.ServiceProvider.GetRequiredService<LupaAbsenDbContext>();
//   db.Database.Migrate();
//}

app.Run();
