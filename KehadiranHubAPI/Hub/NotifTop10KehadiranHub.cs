using Microsoft.AspNetCore.SignalR;

namespace KehadiranHubAPI.Hub {
   public class NotifTop10KehadiranHub: Hub<INotifTop10KehadiranClient> {
      public override async Task OnConnectedAsync() {
         await Clients.Client(Context.ConnectionId).TerimaNotifikasi("");

         await base.OnConnectedAsync();
      }
   }

   public interface INotifTop10KehadiranClient {
      Task TerimaNotifikasi(string message);
   }
}
