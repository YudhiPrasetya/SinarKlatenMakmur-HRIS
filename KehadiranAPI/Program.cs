using KehadiranAPI;
using KehadiranAPI.Data;
using KehadiranAPI.RabbitMQ;
using KehadiranAPI.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
//using MassTransit;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace KehadiranAPI {
   public static class KehadiranAPIServer {
      public static void Main(string[] args) {
         var builder = WebApplication.CreateBuilder(args);
         
         builder.Services.AddSingleton(
            new ConnectionFactory {
               HostName = builder.Configuration.GetConnectionString("MQServer")
            }
         );
         //builder.Services.AddSingleton<MQProducer>();
         builder.Services.AddSingleton<MQConsumer>();
         builder.Services.AddSingleton<LogMesinAbsenConsumer>();
         builder.Services.AddHostedService<BackgroundConsumerService>();
         builder.Services.AddHostedService<LogMesinAbsenConsumerBackgroundService>();
         //builder.Services.AddScoped<IKehadiranServices, KehadiranService>();
		   builder.Services.AddScoped<IJadwalKehadiranService, JadwalKehadiranService>();
		   builder.Services.AddDbContext<DbContextKehadiran>();
         builder.Services.AddControllers().AddNewtonsoftJson();

         //builder.Services.AddSwaggerGen();
         builder.Services.AddEndpointsApiExplorer();

			//builder.Services.AddAuthentication(options => {
			//	options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
			//	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			//}).AddJwtBearer();

			var app = builder.Build();

         app.UseAuthentication();
         //app.UseAuthorization();

         app.MapControllers();
         
         //app.UseSwagger();
         //app.UseSwaggerUI((options) =>
         //{
         //   options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
         //   options.RoutePrefix = string.Empty;
         //});

         app.Run();
      }
   }
}


//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddMassTransit(x => {
//   x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
//      config.Host(new Uri("rabbitmq://localhost"), h => {
//         h.Username("guest");
//         h.Password("guest");
//      });
//   }));
//});
//builder.Services.AddMassTransitHostedService();

//builder.Services.AddMassTransit(x => {
//   x.UsingRabbitMq((context, cfg) => {
//      cfg.Host("localhost", "/", h => {
//         h.Username("guest");
//         h.Password("guest");
//      });
//      cfg.ConfigureEndpoints(context);
//   });
//});


// Add services to the container.
//builder.Services.AddCors(options => {
//   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
//});
//builder.Services.AddDbContext<DbContextKehadiran>();
//builder.Services.AddSingleton<MQConsumer>();
//builder.Services.AddHostedService<BackgroundConsumerService>();
////builder.Services.AddScoped<IKehadiranServices, KehadiranService>();
////builder.Services.AddScoped<IJadwalKehadiranService, JadwalKehadiranService>();
////builder.Services.AddScoped<KehadiranNotifier>();

////builder.Services.AddScoped<AbsenPulangService, AbsenPulangService>();
////builder.Services.AddScoped<IAbsenRealTimeService, AbsenRealTimeService>();

//builder.Services.AddControllers();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//app.UseCors("CORSPolicy");
//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();
//app.UseFileServer();

////using (var scope = app.Services.CreateScope()) {
////   var db = scope.ServiceProvider.GetRequiredService<DbContextKehadiran>();
////   db.Database.Migrate();
////}

////var factory = new ConnectionFactory {
////   HostName = "localhost"
////};
////var connection = factory.CreateConnection();
////using var channel = connection.CreateModel();
////channel.QueueDeclare("absenRealTime", exclusive: false);
////var consumer = new EventingBasicConsumer(channel);
////consumer.Received += (model, args) => {
////   var body = args.Body.ToArray();
////   var message = Encoding.UTF8.GetString(body);
////   Console.WriteLine($"Absen Real Time received: {message}");
////};
////channel.BasicConsume(queue: "absenRealTime", autoAck: true, consumer: consumer);

//app.Run();
