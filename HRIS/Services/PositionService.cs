using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class PositionService: IPositionService {
      private readonly HttpClient _httpClient;
      private readonly ITokenService tokenService;

      public PositionService(HttpClient httpClient, ITokenService tokenService) {
         _httpClient = httpClient;
         this.tokenService = tokenService;
      }

      public async Task<PositionDTO> AddPosition(PositionDTO positionDTO) {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await this.tokenService.GetToken();
            if(tokenDTO.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);

               var response = await _httpClient.PostAsJsonAsync<PositionDTO>("/Positions", positionDTO);

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default(PositionDTO);
                  }
                  return await response.Content.ReadFromJsonAsync<PositionDTO>();
               }
               else {
                  var message = await response.Content.ReadAsStringAsync();
                  throw new Exception($"Http status:{response.StatusCode} Message -{message}");
               }
            }
            return null;


         }
         catch (Exception) {

            throw;
         }
      }

      public async Task<PositionDTO> DeletePosition(int id) {
         var token = await this.tokenService.GetToken();
         if(token.Token != null) {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            var response = await _httpClient.DeleteAsync($"/Positions/{id}");

            if (response.IsSuccessStatusCode) {
               return await response.Content.ReadFromJsonAsync<PositionDTO>();
            }
            return default;
         }
         return null;

      }

      public async Task<PositionDTO> GetPosition(int id) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await _httpClient.GetAsync($"/Positions/{id}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<PositionDTO>();
               }
               else {
                  var message = await response.Content.ReadAsStringAsync();
                  throw new Exception($"Http status code: {response.StatusCode} message: {message}");
               }
            }
            return null;
         }
         catch (Exception) {

            throw;
         }
      }

      public async Task<List<PositionDTO>> GetListPositions() {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               var response = await _httpClient.GetAsync("/Positions");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return (List<PositionDTO>)Enumerable.Empty<PositionDTO>();
                  }
                  return await response.Content.ReadFromJsonAsync<List<PositionDTO>>();
               }
               else {
                  var message = await response.Content.ReadAsStringAsync();
                  throw new Exception($"Http status code: {response.StatusCode} message: {message}");
               }
            }
            return null;
         }
         catch (Exception) {
            throw;
         }
      }

      public async Task<PositionDTO> UpdatePosition(PositionDTO positionDTO) {
         //throw new NotImplementedException();
         try {
            var response = await _httpClient.PutAsJsonAsync<PositionDTO>("/Positions", positionDTO);

            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default(PositionDTO);
               }

               return await response.Content.ReadFromJsonAsync<PositionDTO>();
            }
            else {
               var message = await response.Content.ReadAsStringAsync();
               throw new Exception($"Http status:{response.StatusCode} Message -{message}");
            }

         }
         catch (Exception) {

            throw;
         }
      }
   }
}
