using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class WorkGroupService : IWorkGroupService {
      private readonly HttpClient httpClient;
      private readonly ITokenService tokenService;

      public WorkGroupService(HttpClient _httpClient, ITokenService tokenService)
        {
         httpClient = _httpClient;
         this.tokenService = tokenService;
      }
        public async Task<GroupDTO> AddWorkGroupAsync(GroupDTO groupDTO) {
         //throw new NotImplementedException();
         try {
            var response = await httpClient.PostAsJsonAsync<GroupDTO>("/Groups", groupDTO);

            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default(GroupDTO);
               }
               return await response.Content.ReadFromJsonAsync<GroupDTO>();
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

      public async Task<GroupDTO> DeleteWorkGroupAsync(int id) {
         //throw new NotImplementedException();
         try {
            var response = await httpClient.DeleteAsync($"/Groups/{id}");

            if (response.IsSuccessStatusCode) {
               return await response.Content.ReadFromJsonAsync<GroupDTO>();
            }
            return default;
            //return false;
         }
         catch (Exception) {
            //Log exception
            throw;
         }
      }

      public async Task<List<GroupDTO>> GetListWorkGroupAsync() {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await this.tokenService.GetToken();
            if(tokenDTO.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               var response = await httpClient.GetAsync("/Groups");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return (List<GroupDTO>)Enumerable.Empty<GroupDTO>();
                  }
                  //var rst = await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
                  //List<DepartmentDTO>? departmentList = rst;
                  //return departmentList;
                  return await response.Content.ReadFromJsonAsync<List<GroupDTO>>();
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

      public async Task<GroupDTO> GetWorkGroupAsync(int id) {
         //throw new NotImplementedException();
         try {
            var response = await httpClient.GetAsync($"/Groups/{id}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default(GroupDTO);
               }
               return await response.Content.ReadFromJsonAsync<GroupDTO>();
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

      public async Task<GroupDTO> UpdateWorkGroupAsync(GroupDTO groupDTO) {
         //throw new NotImplementedException();
         try {
            var response = await httpClient.PutAsJsonAsync<GroupDTO>("/Groups", groupDTO);

            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }

               return await response.Content.ReadFromJsonAsync<GroupDTO>();
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
