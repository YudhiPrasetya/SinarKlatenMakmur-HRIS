using MassTransit;
using Microsoft.EntityFrameworkCore;
using PayrollAPI.Data;
using PayrollAPI.Model;
using PayrollAPI.RabbitMQConsumer;
using PayrollAPI.Services;
using RabbitMQ.Client;
using SKM.Shared.Models;

namespace PayrollAPI {
   public static class PayrollApiServer {
      public static void Main(string[] args) {
         var builder = WebApplication.CreateBuilder(args);

         builder.Services.AddMassTransit(x => {
            x.AddConsumer<Payroll_LemburService>();
            x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
               config.Host(new Uri("rabbitmq://localhost"), h => {
                  h.Username("guest");
                  h.Password("guest");
               });
               config.ReceiveEndpoint("spl_range", ep => {
                  ep.PrefetchCount = 200;
                  ep.Batch<SuratPerintahLemburCreated>(b => {
                     b.MessageLimit = 100;
                     b.TimeLimit = TimeSpan.FromSeconds(1);
                     //b.Consumer(() => new PayrollBatchService());
                  });
                  ep.UseMessageRetry(r => r.Interval(2, 100));
                  ep.ConfigureConsumer<Payroll_LemburService>(provider);
               });
            }));
         });

         builder.Services.AddSingleton(
            new ConnectionFactory {
               HostName = builder.Configuration.GetConnectionString("MQServer")
            }
         );
         builder.Services.AddSingleton<AbsenRealtimeConsumer>();

         builder.Services.AddHostedService<BackgroundAbsenRealtimeConsumerService>();

         builder.Services.AddScoped<IPayrollBatchService, PayrollBatchService>();
         builder.Services.AddScoped<IPayrollService, PayrollService>();
         builder.Services.AddScoped<IPayroll_LemburService, Payroll_LemburService>();

         builder.Services.AddDbContext<DbContextClass>();
         builder.Services.AddControllers().AddNewtonsoftJson();

         //builder.Services.AddSwaggerGen();
         builder.Services.AddEndpointsApiExplorer();
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
//   x.AddConsumer<Payroll_LemburService>();
//   x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
//      config.Host(new Uri("rabbitmq://localhost"), h => {
//         h.Username("guest");
//         h.Password("guest");
//      });
//      config.ReceiveEndpoint("spl_range", ep => {
//         ep.PrefetchCount = 200;
//         ep.Batch<SuratPerintahLemburCreated>(b => {
//            b.MessageLimit = 100;
//            b.TimeLimit = TimeSpan.FromSeconds(1);
//            //b.Consumer(() => new PayrollBatchService());
//         });
//         ep.UseMessageRetry(r => r.Interval(2, 100));
//         ep.ConfigureConsumer<Payroll_LemburService>(provider);
//      });
//   }));
//});

////builder.Services.AddMassTransit<ISecondBus>(x => {
////   x.AddConsumer<Payroll_LemburService>();
////   x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
////      config.Host(new Uri("rabbitmq://localhost"), h => {
////         h.Username("guest");
////         h.Password("guest");
////      });
////      config.ReceiveEndpoint("spl_range", ep => {
////         ep.PrefetchCount = 200;
////         ep.Batch<GajiDanTunjanganCreated>(b => {
////            b.MessageLimit = 100;
////            b.TimeLimit = TimeSpan.FromSeconds(1);
////            //b.Consumer(() => new PayrollBatchService());
////         });
////         ep.UseMessageRetry(r => r.Interval(2, 100));
////         ep.ConfigureConsumer<Payroll_LemburService>(provider);
////      });
////   }));
////});
//builder.Services.AddSingleton<AbsenRealtimeConsumer>();
//builder.Services.AddHostedService<BackgroundAbsenRealtimeConsumerService>();

//builder.Services.AddScoped<IPayrollBatchService, PayrollBatchService>();
//builder.Services.AddScoped<IPayrollService, PayrollService>();
//builder.Services.AddScoped<IPayroll_LemburService, Payroll_LemburService>();

//builder.Services.AddDbContext<DbContextClass>();
////builder.Services.AddMassTransit(x => {
////   x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config => {
////      config.Host(new Uri("rabbitmq://localhost"), h => {
////         h.Username("guest");
////         h.Password("guest");
////      });
////   }));
////});

//// Add services to the container.
//builder.Services.AddCors(options => {
//   options.AddPolicy("CORSPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
//});
//builder.Services.AddControllers();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//app.UseCors("CORSPolicy");
//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

////using (var scope = app.Services.CreateScope()) {
////   var db = scope.ServiceProvider.GetRequiredService<DbContextClass>();
////   db.Database.Migrate();
////}
////app.UseFastReport();
////app.UseDefaultFiles();
////app.UseStaticFiles();

//app.Run();
