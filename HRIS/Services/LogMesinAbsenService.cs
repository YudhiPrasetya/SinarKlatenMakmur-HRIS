using HRIS.Contracts;
using SKM.Shared.Dtos;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class LogMesinAbsenService : ILogMesinAbsenService {
      private readonly HttpClient httpClient;
      private readonly ITokenService tokenService;

      public LogMesinAbsenService(HttpClient httpClient, ITokenService tokenService) {
         this.httpClient = httpClient;
         this.tokenService = tokenService;
      }
      public async Task<List<LogMesinAbsenDTO>> GetListLogMesinByDate(string startDate, string endDate) {
         var tokenDTO = await tokenService.GetToken();
         if (tokenDTO.Token != null) {
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
            var response = await httpClient.GetAsync($"/MesinAbsens/Log/{startDate}/{endDate}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return (List<LogMesinAbsenDTO>)Enumerable.Empty<LogMesinAbsenDTO>();
               }
               return await response.Content.ReadFromJsonAsync<List<LogMesinAbsenDTO>>();
            }
            else {
               var message = await response.Content.ReadAsStringAsync();
               throw new Exception($"Http status code: {response.StatusCode} message: {message}");
            }
         }
         return null;
      }
   }
}
