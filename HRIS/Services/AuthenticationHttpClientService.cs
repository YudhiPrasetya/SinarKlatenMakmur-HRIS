using HRIS.Contracts;
using HRIS.Models;
using System.Net.Http.Json;
using SKM.Shared.Helpers;

namespace HRIS.Services {
	public class AuthenticationHttpClientService : IAuthenticationHttpClientService {
		private readonly ILogger<AuthenticationHttpClientService> logger;
		private readonly HttpClient httpClient;
      private readonly ILocalStorageService localStorage;
      private readonly CustomAuthStateProvider customAuthStateProvider;
      //private readonly ITokenService tokenService;

      public AuthenticationHttpClientService(ILogger<AuthenticationHttpClientService> logger, HttpClient httpClient, ILocalStorageService localStorage, CustomAuthStateProvider customAuthStateProvider)
      {
			this.logger = logger;
			this.httpClient = httpClient;
			this.localStorage = localStorage;
			this.customAuthStateProvider = customAuthStateProvider;
			//this.tokenService = tokenService;
      }

		public async Task<HttpResponseMessage> LoginUser(UserLoginDTO userLoginDTO) {
			var response = await this.httpClient.PostAsJsonAsync("/Auth", userLoginDTO);
			if (response.IsSuccessStatusCode) {
				customAuthStateProvider.StateChanged();
			}
			return response;
		}

      //public async Task<UserLoginResultDTO?> LoginUser(UserLoginDTO userLoginDTO) {
  //    public async Task<TokenDTO?> LoginUser(UserLoginDTO userLoginDTO) {
		//	//throw new NotImplementedException();
		//	try {
		//		var response = await this.httpClient.PostAsJsonAsync($"{BaseUrl.LocalBaseUrl}/Auth", userLoginDTO);
		//		//var result = await response.Content.ReadFromJsonAsync<UserLoginResultDTO>();
		//		var result = await response.Content.ReadFromJsonAsync<TokenDTO>();
		//		//var result = await response.Content.ReadAsStringAsync();

		//		//await this.localStorage.SetItemAsStringAsync("token", result.Token.Token);
		//		//await this.localStorage.SetItemAsStringAsync("token",result);
		//		await tokenService.SetToken(result);
		//		//customAuthStateProvider.StateChanged();
		//		return result;
		//	}
		//	catch (System.Exception ex) {
		//		logger.LogError(ex.Message);
		//		//return new UserLoginResultDTO {
		//		//	Succeeded = false,
		//		//	Message = "Login failed!"
		//		//};
		//		throw;
		//	}
		//}

      public async Task LogoutUser(string userName) {
			//throw new NotImplementedException();
			//var tokenUser = await tokenService.GetToken();
			var response = await httpClient.PostAsJsonAsync("/Auth/DeactiveUser", userName);
			if (response.IsSuccessStatusCode) {
				//await tokenService.RemoveToken();
				await localStorage.RemoveItemAsync("token");
				customAuthStateProvider.StateChanged();
			}

		}
   }
}
