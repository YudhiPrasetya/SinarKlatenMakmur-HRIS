using Microsoft.AspNetCore.SignalR;

namespace KehadiranHubAPI.Hub {
   public class NotifKehadiranHub: Hub<INotifKehadiranClient> {
      public override async Task OnConnectedAsync() {
         await Clients.Client(Context.ConnectionId).ReceiveNotification("");

         await base.OnConnectedAsync();
      }
   }

   public interface INotifKehadiranClient {
      Task ReceiveNotification(string message);
   }
}
