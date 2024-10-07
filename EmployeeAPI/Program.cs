//using AuthenticationManager;
using EmployeeAPI;
using EmployeeAPI.Data;
using EmployeeAPI.Services;
using MassTransit;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
//using JwtTokenAuthentication;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMassTransit(x => {
   x.AddConsumer<EmployeeService>();
   x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
      config.Host(new Uri("rabbitmq://localhost"), h => {
         h.Username("guest");
         h.Password("guest");
      });
      config.ReceiveEndpoint("department", ep => {
         ep.PrefetchCount = 16;
         ep.UseMessageRetry(r => r.Interval(2, 100));
         ep.ConfigureConsumer<EmployeeService>(provider);
      });
   }));
});
//builder.Services.AddMassTransitHostedService();
//ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddDbContext<EmployeeDbContextClass>();

//builder.Services.AddStackExchangeRedisCache(options => {
//   options.Configuration = configuration["RedisCacheUrl"];
//});
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddControllers();

//builder.Services.AddCustomJwtAuthentication();

//builder.Services.AddAuthentication(options => {
//   options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
//   options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
//}).AddJwtBearer(x => {
//   x.Authority = ""
//});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//	app.UseSwagger();
//	app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthentication();
//app.UseAuthorization();

app.MapControllers();

//using (var scope = app.Services.CreateScope()) {
//   var db = scope.ServiceProvider.GetRequiredService<EmployeeDbContextClass>();
//   db.Database.Migrate();
//}

app.Run();
