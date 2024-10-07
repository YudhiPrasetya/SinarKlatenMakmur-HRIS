using HRIS.Models;
using SKM.Shared.Dtos;

namespace HRIS.Contracts {
   public interface IAuthService {
      Task Login(User user);
      Task SetDeactiveUser(string userName);
   }
}
