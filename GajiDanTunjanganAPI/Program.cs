using GajiDanTunjanganAPI.Data;
using GajiDanTunjanganAPI.Services;
//using MassTransit;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddMassTransit(x => {
//   x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
//      config.Host(new Uri("rabbitmq://localhost"), h => {
//         h.Username("guest");
//         h.Password("guest");
//      });
//   }));
//});

builder.Services.AddCors(options => {
   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
// Add services to the container.
builder.Services.AddScoped<IGajiDanTunjanganService, GajiDanTunjanganService>();
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("CORSPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
