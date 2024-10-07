using HRIS.Models;
using HRIS.Services;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace HRIS
{
	public class CustomAuthStateProvider : AuthenticationStateProvider
	{
      //private readonly ITokenService tokenService;
      private readonly HttpClient _httpClient;
      private readonly ILocalStorageService _localStorage;

		//private ClaimsPrincipal AnonymousUser => new (new ClaimsIdentity(Array.Empty<Claim>()));

      //private readonly ILocalStorageService _localStorage;
      //private readonly HttpClient _http;

      //public CustomAuthStateProvider(ILocalStorageService localStorage, HttpClient http)
      //{
      //	_localStorage = localStorage;
      //	_http = http;
      //}

      public CustomAuthStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
      {
         //this.tokenService = tokenService;
         _httpClient = httpClient;
         _localStorage = localStorage;
      }

		public void StateChanged() {
			NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
		}

      public override async Task<AuthenticationState> GetAuthenticationStateAsync()
		{
			//var tokenDTO = await tokenService.GetToken();
			TokenDTO tokenDTO = await _localStorage.GetItemAsync<TokenDTO>("token");
			//var identity = string.IsNullOrEmpty(tokenDTO?.Token) || tokenDTO?.ExpiresIn < DateTime.Now
			//	 ? new ClaimsIdentity()
			//	 : new ClaimsIdentity(ParseClaimsFromJwt(tokenDTO!.Token), "jwt");
			var identity = tokenDTO == null || string.IsNullOrEmpty(tokenDTO.Token) || tokenDTO.ExpiresIn < DateTime.Now
					? new ClaimsIdentity() : new ClaimsIdentity(ParseClaimsFromJwt(tokenDTO.Token), "jwt");
					

			//return new AuthenticationState(new ClaimsPrincipal(identity));
			return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity)));


			//await Task.Delay(2000);
			//var anonymous = new ClaimsIdentity();
			//return await Task.FromResult(new AuthenticationState(new ClaimsPrincipal(anonymous)));

			//return await Task.FromResult(new AuthenticationState(AnonymousUser));
		}

		public static IEnumerable<Claim> ParseClaimsFromJwt(string jwt) { 
		//public static IEnumerable<Claim> ParseClaims(string jwt) {
			var payload = jwt.Split('.')[1];
			var jsonBytes = ParseBase64WithoutPadding(payload);
			var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);
			return keyValuePairs!.Select(kvp => new Claim(kvp.Key, kvp!.ToString()));
		}

		private static byte[] ParseBase64WithoutPadding(string base64)
		{
			switch (base64.Length % 4)
			{
				case 2: base64 += "=="; break;
				case 3: base64 += "="; break;
			}
			return Convert.FromBase64String(base64);
		}
	}
}
