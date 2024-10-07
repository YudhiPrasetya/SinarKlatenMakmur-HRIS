using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class GajiDanTunjanganService : IGajiDanTunjanganService {
		private readonly HttpClient httpClient;
      private readonly ITokenService tokenService;

      public GajiDanTunjanganService(HttpClient httpClient, ITokenService tokenService)
        {
			this.httpClient = httpClient;
         this.tokenService = tokenService;
      }

      public async Task<GajiDanTunjanganDTO> AddGajiAsync(GajiDanTunjanganDTO gajiDTO) {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               var response = await httpClient.PostAsJsonAsync<GajiDanTunjanganDTO>("/Gaji", gajiDTO);

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<GajiDanTunjanganDTO>();
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

      public async Task<GajiDanTunjanganDTO> DeleteGajiAsync(int id) {
			//throw new NotImplementedException();
			try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               var response = await httpClient.DeleteAsync($"/Gaji/{id}");

               if (response.IsSuccessStatusCode) {
                  return await response.Content.ReadFromJsonAsync<GajiDanTunjanganDTO>();
               }
               return default;
            }
            return null;

				//return false;
			}
			catch (Exception) {
				//Log exception
				throw;
			}
		}

      public async Task<List<GajiDanTunjanganDTO>> GetGajiListAsync() {
			//throw new NotImplementedException();
			try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync("/Gaji");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<List<GajiDanTunjanganDTO>>();
               }
               else {
                  var message = await response.Content.ReadAsStringAsync();
                  throw new Exception($"Http status code: {response.StatusCode} message: {message}");
               }
            }
            return null;

			}
			catch (Exception) {
				//Console.WriteLine(ex.Message);
				throw;
			}
		}

      public Task<GajiDanTunjanganDTO> GetGajiAsync(int id) {
         throw new NotImplementedException();
      }

      public async Task<GajiDanTunjanganDTO> UpdateGajiAsync(GajiDanTunjanganDTO gajiDTO) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await httpClient.PutAsJsonAsync<GajiDanTunjanganDTO>("/Gaji", gajiDTO);

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }

                  return await response.Content.ReadFromJsonAsync<GajiDanTunjanganDTO>();
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

      public async Task<GajiDanTunjanganDTO> AddGajiRangeAsync(IEnumerable<GajiDanTunjanganDTO> gajiDTOs) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await httpClient.PostAsJsonAsync("/Gaji/AddGajiRange", gajiDTOs);
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<GajiDanTunjanganDTO>();
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

      public async Task<List<GajiDanTunjanganDTO>> GetGajiByGroupIdAsync(int groupId) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync($"/Gaji/Group/{groupId}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<List<GajiDanTunjanganDTO>>();
               }
               else {
                  var message = await response.Content.ReadAsStringAsync();
                  throw new Exception($"Http status code: {response.StatusCode} message: {message}");
               }
            }
            return null;
         }
         catch (Exception) {
            //Console.WriteLine(ex.Message);
            throw;
         }
      }

      public async Task<IEnumerable<GajiDanTunjanganDTO>> GetByGroupName(string groupName) {
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync($"/Gaji/GroupName/{groupName}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<List<GajiDanTunjanganDTO>>();
               }
               else {
                  var message = await response.Content.ReadAsStringAsync();
                  throw new Exception($"Http status code: {response.StatusCode} message: {message}");
               }
            }
            return null;

         }
         catch (Exception) {
            //Console.WriteLine(ex.Message);
            throw;
         }
      }

      public async Task<GajiDanTunjanganDTO?> GetByNIK(string nik) {
         var token = await tokenService.GetToken();
         if (token!.Token != null) {
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            var response = await this.httpClient.GetAsync($"/Gaji/NIK/{nik}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               return await response.Content.ReadFromJsonAsync<GajiDanTunjanganDTO>();
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
