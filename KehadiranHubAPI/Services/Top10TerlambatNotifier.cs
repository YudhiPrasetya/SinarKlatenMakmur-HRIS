using KehadiranHubAPI.Hub;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace KehadiranHubAPI.Services {
   public class Top10TerlambatNotifier: BackgroundService {
      private readonly ILogger<Top10TerlambatNotifier> logger;
      private readonly IHubContext<NotifTop10Terlambat, INotifTop10TerlambatClient> context;
      private readonly IKehadiranService kehadiranService;
      private static readonly TimeSpan Period = TimeSpan.FromSeconds(3);

      public Top10TerlambatNotifier(ILogger<Top10TerlambatNotifier> _logger, IHubContext<NotifTop10Terlambat, INotifTop10TerlambatClient> _context, IServiceScopeFactory factory) {
         logger = _logger;
         context = _context;
         kehadiranService = factory.CreateScope().ServiceProvider.GetRequiredService<IKehadiranService>();
      }

      protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
         using var timer = new PeriodicTimer(Period);
         while(!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken)) {
            var dateTime = DateTime.Now;
            logger.LogInformation("Executing {Service} {Time}", nameof(Top10KehadiranNotifier), dateTime);

            var result = await kehadiranService.GetKaryawanTerlambat();
            string msg = JsonConvert.SerializeObject(result);

            await context.Clients.All.TerimaNotifikasi(msg);
         }
      }
   }
}
