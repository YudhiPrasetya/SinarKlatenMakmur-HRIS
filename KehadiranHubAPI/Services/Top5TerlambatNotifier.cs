using KehadiranHubAPI.Hub;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace KehadiranHubAPI.Services {
   public class Top5TerlambatNotifier : BackgroundService {
      private readonly ILogger<Top5TerlambatNotifier> logger;
      private readonly IHubContext<NotifTop5TerlambatHub, INotifTop5TerlambatClient> context;
      private readonly IKehadiranService kehadiranService;
      private static readonly TimeSpan Period = TimeSpan.FromSeconds(3);

      public Top5TerlambatNotifier(ILogger<Top5TerlambatNotifier> _logger, IHubContext<NotifTop5TerlambatHub, INotifTop5TerlambatClient> _context, IServiceScopeFactory factory) {
         logger = _logger;
         context = _context;
         kehadiranService = factory.CreateScope().ServiceProvider.GetRequiredService<IKehadiranService>();
      }

      protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
         using var timer = new PeriodicTimer(Period);
         while(!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken)) {
            var dateTime = DateTime.Now;
            logger.LogInformation("Executing {service} {Time}", nameof(Top5TerlambatNotifier), dateTime);

            var result = await kehadiranService.GetTop5KaryawanTerlambat();
            string msg = JsonConvert.SerializeObject(result);

            await context.Clients.All.TerimaNotifikasi(msg);
         }
      }
   }
}
