using KehadiranHubAPI.Hub;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace KehadiranHubAPI.Services {
   public class KehadiranNotifier: BackgroundService {
      private static readonly IServiceScopeFactory? serviceScopeFactory;

      private static readonly TimeSpan Period = TimeSpan.FromSeconds(3);
      private readonly ILogger<KehadiranNotifier> logger;
      private readonly IHubContext<NotifKehadiranHub, INotifKehadiranClient> context;
      private readonly IKehadiranService kehadiranServices;

      public KehadiranNotifier(ILogger<KehadiranNotifier> _logger, IHubContext<NotifKehadiranHub, INotifKehadiranClient> _context, IServiceScopeFactory factory) {
         logger = _logger;
         context = _context;
         kehadiranServices = factory.CreateScope().ServiceProvider.GetRequiredService<IKehadiranService>();
      }

      protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
         using var timer = new PeriodicTimer(Period);
         while (!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken)) {
            var dateTime = DateTime.Now;
            logger.LogInformation("Executing {Service} {Time}", nameof(KehadiranNotifier), dateTime);

            var result = await kehadiranServices.GetKehadiran();
            string msg = JsonConvert.SerializeObject(result);

            await context.Clients.All.ReceiveNotification(msg);

         }
      }
   }
}
