using KehadiranHubAPI.Hub;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace KehadiranHubAPI.Services {
   public class Top5KehadiranNotifier : BackgroundService {
      private readonly ILogger<Top5KehadiranNotifier> logger;
      private readonly IHubContext<NotifTop5KehadiranHub, INotifTop5KehadiranClient> context;
      private readonly IKehadiranService kehadiranService;
      private static readonly TimeSpan Period = TimeSpan.FromSeconds(3);

      public Top5KehadiranNotifier(ILogger<Top5KehadiranNotifier> _logger, IHubContext<NotifTop5KehadiranHub, INotifTop5KehadiranClient> _context, IServiceScopeFactory factory) {
         logger = _logger;
         context = _context;
         kehadiranService = factory.CreateScope().ServiceProvider.GetRequiredService<IKehadiranService>();
      }

      protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
         using var timer = new PeriodicTimer(Period);
         while(!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken)) {
            var dateTime = DateTime.Now;
            logger.LogInformation("Executing {Service} {Time}", nameof(Top5KehadiranNotifier), dateTime);

            var result = await kehadiranService.GetTop5KaryawanRajin();
            string msg = JsonConvert.SerializeObject(result);

            await context.Clients.All.TerimaNotifikasi(msg);
         }
      }
   }
}
