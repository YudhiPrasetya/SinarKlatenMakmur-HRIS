//using JwtTokenAuthentication;
using MesinAbsenAPI.Data;
using MesinAbsenAPI.RabbitMQ;
using MesinAbsenAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
  options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
builder.Services.AddScoped<IMesinAbsenService, MesinAbsenService>();
builder.Services.AddScoped<ILogMesinAbsenService, LogMesinAbsenService>();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddScoped<IAbsenRealTimeService, AbsenRealTimeService>();
builder.Services.AddScoped<IRabbitMQProducer, RabbitMQProducer>();
builder.Services.AddDbContext<MesinAbsenDbContextClass>();
//builder.Services.AddJwtAuthentication();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("CORSPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllers();
//using (var scope = app.Services.CreateScope()) {
//   var db = scope.ServiceProvider.GetRequiredService<MesinAbsenDbContextClass>();
//   db.Database.Migrate();
//}
app.Run();
