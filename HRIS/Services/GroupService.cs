using DocumentFormat.OpenXml.Office2010.Excel;
using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class GroupService : IGroupService {
      private readonly HttpClient _httpClient;
      private readonly ITokenService tokenService;

      public GroupService(HttpClient httpClient, ITokenService tokenService) {
         _httpClient = httpClient;
         this.tokenService = tokenService;
      }
      public Task<GroupDTO> AddGroupAsync(GroupDTO groupDTO) {
         throw new NotImplementedException();

      }

      public Task<GroupDTO> DeleteGroupAsync(int id) {
         throw new NotImplementedException();
      }

		public async Task<List<GroupDTO>?> GetByGroupName(string groupName) {
			var token = await this.tokenService.GetToken();
			if (token.Token != null) {
            string strGroup = groupName.Replace(" ", "_").Replace("/", "-");
				_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var response = await _httpClient.GetAsync($"/Groups/GroupName/{strGroup}");
				if (response.IsSuccessStatusCode) {
					if (response.StatusCode == System.Net.HttpStatusCode.NotFound) {
						return default;
					}
					return await response.Content.ReadFromJsonAsync<List<GroupDTO>>();
				}
				else {
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http status code: {response.StatusCode} message: {message}");
				}
			}
         return default;
		}

		public async Task<GroupDTO> GetGroupAsync(int id) {
         //throw new NotImplementedException();
         try {
            var token = await this.tokenService.GetToken();
            if(token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await _httpClient.GetAsync($"/Groups/{id}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NotFound) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<GroupDTO>();
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

      public async Task<List<GroupDTO>> GetListGroupsAsync() {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await _httpClient.GetAsync("/Groups");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return (List<GroupDTO>)Enumerable.Empty<GroupDTO>();
                  }
                  List<GroupDTO>? groups = await response.Content.ReadFromJsonAsync<List<GroupDTO>>();

                  //return await response.Content.ReadFromJsonAsync<List<GroupDTO>>();
                  return groups.OrderBy(g => g.GroupDesc).ToList();
               }
               else {
                  var message = await response.Content.ReadAsStringAsync();
                  throw new Exception($"http status code: {response.StatusCode} message: {message}");
               }
            }
            return null;
         }
         catch (Exception) {

            throw;
         }
      }

      public async Task<GroupDTO> UpdateGroup(GroupDTO groupDTO) {
         throw new NotImplementedException();

      }
   }
}
