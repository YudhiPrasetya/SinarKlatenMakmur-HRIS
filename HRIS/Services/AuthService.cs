using HRIS.Contracts;
using HRIS.Models;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class AuthService : IAuthService {
      private readonly HttpClient httpClient;
		//private readonly CustomAuthStateProvider customAuthStateProvider;

		public AuthService(HttpClient httpClient)
      {
         this.httpClient = httpClient;
			//this.customAuthStateProvider = customAuthStateProvider;
		}

      public async Task Login(User user) {
         //throw new NotImplementedException();
         //var response = await this.httpClient.PostAsJsonAsync<User>($"{BaseUrl.LocalBaseUrl}/Auth", user);
			var response = await this.httpClient.PostAsJsonAsync<User>("/Auth", user);
			if (response.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new System.Exception(await response.Content.ReadAsStringAsync());
         response.EnsureSuccessStatusCode();
         //customAuthStateProvider.StateChanged();

      }

		public async Task SetDeactiveUser(string userName) {
			var response = await this.httpClient.PostAsJsonAsync($"/Auth/DeactiveUser", userName);
			if (response.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new System.Exception(await response.Content.ReadAsStringAsync());
			response.EnsureSuccessStatusCode();
		}
	}
}
