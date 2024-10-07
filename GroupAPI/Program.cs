using GroupAPI.Data;
using GroupAPI.Services;
using MassTransit;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMassTransit(x => {
   x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
      config.Host(new Uri("rabbitmq://localhost"), h => {
         h.Username("guest");
         h.Password("guest");
      });
   }));
});
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddCors(options => {
   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
// Add services to the container.

builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddDbContext<GroupDbContext>();
//builder.Services.AddStackExchangeRedisCache(options => { options.Configuration = configuration["RedisCacheUrl"]; });
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddControllers();

var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseCors("CORSPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//using (var scope = app.Services.CreateScope()) {
//   var db = scope.ServiceProvider.GetRequiredService<GroupDbContext>();
//   db.Database.Migrate();
//}

app.Run();
