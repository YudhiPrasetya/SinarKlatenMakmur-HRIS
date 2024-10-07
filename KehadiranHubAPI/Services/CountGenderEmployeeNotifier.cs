using KehadiranHubAPI.Hub;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace KehadiranHubAPI.Services {
   public class CountGenderEmployeeNotifier : BackgroundService {
      private static readonly TimeSpan Period = TimeSpan.FromSeconds(3);
      private readonly ILogger<CountGenderEmployeeNotifier> logger;
      private readonly IHubContext<NotifCountGenderEmployeeHub, INotifCountGenderEmployee> context;
      private readonly IKehadiranService kehadiranService;

      public CountGenderEmployeeNotifier(ILogger<CountGenderEmployeeNotifier> _logger, IHubContext<NotifCountGenderEmployeeHub, INotifCountGenderEmployee> _context, IServiceScopeFactory factory) {
         logger = _logger;
         context = _context;
         kehadiranService = factory.CreateScope().ServiceProvider.GetRequiredService<IKehadiranService>();
      }
      protected override async Task ExecuteAsync(CancellationToken stoppingToken) {
         using var timer = new PeriodicTimer(Period);
         while(!stoppingToken.IsCancellationRequested && await timer.WaitForNextTickAsync(stoppingToken)) {
            var dateTime = DateTime.Now;
            logger.LogInformation("Executing {Service} {Time}", nameof(CountGenderEmployeeNotifier), dateTime);

            var result = await kehadiranService.GetEmployessByGender();
            string msg = JsonConvert.SerializeObject(result);

            await context.Clients.All.ReceiveNotification(msg);

         }
      }
   }
}
