using Microsoft.AspNetCore.SignalR;
using System.Runtime.CompilerServices;

namespace KehadiranHubAPI.Hub {
   public class NotifTop5KehadiranHub: Hub<INotifTop5KehadiranClient> {
      public override async Task OnConnectedAsync() {
         await Clients.Client(Context.ConnectionId).TerimaNotifikasi("");

         await base.OnConnectedAsync();
      }
   }

   public interface INotifTop5KehadiranClient {
      Task TerimaNotifikasi(string message);
   }
}
