using HRIS.Models;
using HRIS.Contracts;
using Microsoft.AspNetCore.Components;

namespace HRIS.Services {
   public interface ITokenService {
      Task<TokenDTO?> GetToken();
      Task RemoveToken();
      Task SetToken(TokenDTO tokenDTO);
      Task<bool> IsTokenNotExpired();
   }

   public class TokenService : ITokenService {
      private readonly ILocalStorageService localStorageService;
      private readonly IAuthenticationHttpClientService authenticationHttpClientService;
		private readonly NavigationManager _navigationManager;

		public TokenService(ILocalStorageService localStorageService, IAuthenticationHttpClientService authenticationHttpClientService, NavigationManager navigationManager)
        {
            this.localStorageService = localStorageService;
            this.authenticationHttpClientService = authenticationHttpClientService;
			   _navigationManager = navigationManager;
		}
      public async Task<TokenDTO?> GetToken() {
         //throw new NotImplementedException();
         TokenDTO tokenDTO = await localStorageService.GetItemAsync<TokenDTO>("token");
         if(tokenDTO != null) {
            DateTime? tokenExpire = tokenDTO.ExpiresIn;
            if(tokenExpire < DateTime.Now) {
                await authenticationHttpClientService.LogoutUser(tokenDTO.UserName!);
               _navigationManager.NavigateTo("/login", true);
            }
            return tokenDTO;
         }
         //if(await this.localStorageService.ContainKeyAsync("token")) {
         //   return await localStorageService.GetItemAsync<TokenDTO>("token");
         //}
         return default;
      }

      public async Task<bool> IsTokenNotExpired() {
         //throw new NotImplementedException();
         TokenDTO token = await localStorageService.GetItemAsync<TokenDTO>("token");
         return token.ExpiresIn!.Value >= DateTime.Now;

      }

      public async Task RemoveToken() {
         //throw new NotImplementedException();
         await localStorageService.RemoveItemAsync("token");
      }

      public async Task SetToken(TokenDTO tokenDTO) {
         //throw new NotImplementedException();
         await localStorageService.SetItemAsync("token", tokenDTO);
      }
   }
}
