using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class MesinAbsenService : IMesinAbsenService {
      private readonly HttpClient httpClient;
      private readonly ITokenService tokenService;

      public MesinAbsenService(HttpClient httpClient, ITokenService tokenService)
        {
         this.httpClient = httpClient;
         this.tokenService = tokenService;
      }
      public async Task<MesinAbsenDTO> AddMesinAbsenAsync(MesinAbsenDTO mesinAbsenDTO) {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               var response = await this.httpClient.PostAsJsonAsync<MesinAbsenDTO>("/MesinAbsens", mesinAbsenDTO);

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default(MesinAbsenDTO);
                  }
                  return await response.Content.ReadFromJsonAsync<MesinAbsenDTO>();
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

      public async Task<MesinAbsenDTO> DeleteMesinAbsenAsync(int id) {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               var response = await httpClient.DeleteAsync($"/MesinAbsens/{id}");

               if (response.IsSuccessStatusCode) {
                  return await response.Content.ReadFromJsonAsync<MesinAbsenDTO>();
               }
               return default;
               //return false;
            }
            return null;
         }

         catch (Exception) {
            //Log exception
            throw;
         }
      }

      public async Task<List<MesinAbsenDTO>> GetListMesinAbsenAsync() {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               var response = await httpClient.GetAsync("/MesinAbsens");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return (List<MesinAbsenDTO>)Enumerable.Empty<MesinAbsenDTO>();
                  }
                  //var rst = await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
                  //List<DepartmentDTO>? departmentList = rst;
                  //return departmentList;
                  return await response.Content.ReadFromJsonAsync<List<MesinAbsenDTO>>();
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

      public async Task<MesinAbsenDTO?> GetMesinAbsenAsync(int id) {
         //throw new NotImplementedException();
         try {
            var response = await httpClient.GetAsync($"/MesinAbsens/{id}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               return await response.Content.ReadFromJsonAsync<MesinAbsenDTO>();
            }
            else {
               var message = await response.Content.ReadAsStringAsync();
               throw new Exception($"Http status code: {response.StatusCode} message: {message}");
            }
         }
         catch (Exception) {

            throw;
         }
      }

      public async Task<MesinAbsenDTO> UpdateMesinAbsenAsync(MesinAbsenDTO mesinAbsenDTO) {
         //throw new NotImplementedException();
         try {
            var response = await httpClient.PutAsJsonAsync<MesinAbsenDTO>("/MesinAbsens", mesinAbsenDTO);

            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default(MesinAbsenDTO);
               }

               return await response.Content.ReadFromJsonAsync<MesinAbsenDTO>();
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
