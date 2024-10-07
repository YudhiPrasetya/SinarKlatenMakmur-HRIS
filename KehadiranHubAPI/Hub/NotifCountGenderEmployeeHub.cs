using Microsoft.AspNetCore.SignalR;

namespace KehadiranHubAPI.Hub {
   public class NotifCountGenderEmployeeHub: Hub<INotifCountGenderEmployee> {
      public override async Task OnConnectedAsync() {
         await Clients.Client(Context.ConnectionId).ReceiveNotification("");
         await base.OnConnectedAsync();  
      }
   }

   public interface INotifCountGenderEmployee {
      Task ReceiveNotification(string message);
   }
}
