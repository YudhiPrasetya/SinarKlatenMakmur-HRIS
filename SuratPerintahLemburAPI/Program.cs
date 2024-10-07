using FastReport.Data;
using MassTransit;
using Microsoft.EntityFrameworkCore;
using SuratperintahLemburAPI.Data;
using SuratperintahLemburAPI.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMassTransit(x => {
   x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
      config.Host(new Uri("rabbitmq://localhost"), h => {
         h.Username("guest");
         h.Password("guest");
      });
   }));
});

//builder.Services.AddMassTransitHostedService();
// Add services to the container.
builder.Services.AddCors(options => {
   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});
builder.Services.AddControllers();
builder.Services.AddScoped<ICacheService, CacheService>();

FastReport.Utils.RegisteredObjects.AddConnection(typeof(MsSqlDataConnection));
builder.Services.AddDbContext<DbContextClass>();
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<ISuratPerintahLemburService, SuratPerintahLemburService>();

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
app.UseFastReport();
app.UseDefaultFiles();
app.UseStaticFiles();
app.Run();
