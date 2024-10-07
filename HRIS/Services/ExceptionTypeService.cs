using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class ExceptionTypeService : IExceptionTypeService {
      private readonly HttpClient _httpClient;
		private readonly ITokenService tokenService;

		public ExceptionTypeService(HttpClient httpClient, ITokenService tokenService) {
         _httpClient = httpClient;
			this.tokenService = tokenService;
		}
      public async Task<ExceptionTypeDTO> AddExceptionTypeAsync(ExceptionTypeDTO exceptionTypeDTO) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.PostAsJsonAsync<ExceptionTypeDTO>("/TipeTidakHadir", exceptionTypeDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default(ExceptionTypeDTO);
						}
						return await response.Content.ReadFromJsonAsync<ExceptionTypeDTO>();
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

      public async Task<ExceptionTypeDTO> DeleteExceptionTypeAsync(int id) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.DeleteAsync($"/TipeTidakHadir/{id}");
					if (response.IsSuccessStatusCode) {
						return await response.Content.ReadFromJsonAsync<ExceptionTypeDTO>();
					}
					return default;
				}
            return null;
         }
         catch (Exception) {

            throw;
         }
      }

      public async Task<ExceptionTypeDTO> GetExceptioTypeAsync(int id) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.GetAsync($"/TipeTidakHadir/{id}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<ExceptionTypeDTO>();
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

      public async Task<List<ExceptionTypeDTO>> GetListExceptionsTypeAsync() {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
            if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.GetAsync("/TipeTidakHadir");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<ExceptionTypeDTO>)Enumerable.Empty<ExceptionTypeDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<ExceptionTypeDTO>>();
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

      public async Task<List<ExceptionTypeDTO>> GetListExceptionTypeByValAsync(string val) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
            if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.GetAsync($"/TipeTidakHadir/Alasan/{val}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<ExceptionTypeDTO>>();
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

      public async Task<ExceptionTypeDTO> UpdateExceptionTypeAsync(ExceptionTypeDTO exceptionTypeDTO) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.PutAsJsonAsync<ExceptionTypeDTO>("/TipeTidakHadir", exceptionTypeDTO);
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<ExceptionTypeDTO>();
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
   }
}
