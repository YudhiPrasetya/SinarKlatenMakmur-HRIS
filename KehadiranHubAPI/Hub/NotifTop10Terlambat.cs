using Microsoft.AspNetCore.SignalR;

namespace KehadiranHubAPI.Hub {
   public class NotifTop10Terlambat:Hub<INotifTop10TerlambatClient> {
      public override async Task OnConnectedAsync() {
         await Clients.Client(Context.ConnectionId).TerimaNotifikasi("");
         await base.OnConnectedAsync();
      }
   }
   public interface INotifTop10TerlambatClient {
      Task TerimaNotifikasi(string message);
   }
}
