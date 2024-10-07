using Microsoft.AspNetCore.SignalR;

namespace KehadiranHubAPI.Hub {
   public class NotifTop5TerlambatHub: Hub<INotifTop5TerlambatClient> {
      public override async Task OnConnectedAsync() {
         await Clients.Client(Context.ConnectionId).TerimaNotifikasi("");
         await base.OnConnectedAsync();
      }
   }

   public interface INotifTop5TerlambatClient {
      Task TerimaNotifikasi(string message);
   }
}
