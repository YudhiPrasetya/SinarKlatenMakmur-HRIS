using HRIS.Contracts;
using Microsoft.EntityFrameworkCore.Internal;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http;
using System.Net.Http.Json;
using System.ServiceModel.Channels;

namespace HRIS.Services
{
  public class UserService : IUserService
  {
      private readonly HttpClient _httpClient;
	   private readonly ITokenService tokenService;

      public UserService(HttpClient httpClient, ITokenService tokenService)
      {
         _httpClient = httpClient;
			this.tokenService = tokenService;
      }
    public async Task<UserDTO> AddUser(UserDTO userDTO)
    {
         //throw new NotImplementedException();
      try {
            var response = await _httpClient.PostAsJsonAsync<UserDTO>("/Users", userDTO);
            if (response.IsSuccessStatusCode) {
               if(response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               return await response.Content.ReadFromJsonAsync<UserDTO>();
            }
            else {
               var msg = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http status:{response.StatusCode} Message -{msg}");
				}
               
      }
      catch (Exception) {

         throw;
      }
    }

    public Task<UserDTO> DeleteUser(int id)
    {
      throw new NotImplementedException();
    }

    public Task<UserDTO> GetUser(int id)
    {
      throw new NotImplementedException();
    }

   // public async Task<IEnumerable<UserDTO>> GetUsers()
   // {
   //   //throw new NotImplementedException();
   //   try
   //   {
   //      var tokenDTO = await tokenService.GetToken();
   //      if(tokenDTO.Token != null) {
   //         _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);

			//	var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Users");
			//	if (response.IsSuccessStatusCode) {
			//		if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
			//			return Enumerable.Empty<UserDTO>();
			//		}
			//		return await response.Content.ReadFromJsonAsync<IEnumerable<UserDTO>>();
			//	}
			//	else {
			//		var message = await response.Content.ReadAsStringAsync();
			//		throw new Exception($"Http status code: {response.StatusCode} message: {message}");
			//	}
			//}
   //      return null;
   //   }
   //   catch (Exception)
   //   {

   //      throw;
   //   }

   // }

   public async Task<HttpResponseMessage?> GetUsers() {
      var tokenDTO = await tokenService.GetToken();
      if(tokenDTO.Token != null) {
	      _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
		   var response = await this._httpClient.GetAsync("/Users");

         return response;
	   }
      return null;
   }
  }
}
