using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
	public class JadwalShiftSecurityService : IJadwalShiftSecurityServicecs {
		private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public JadwalShiftSecurityService(HttpClient httpClient, ITokenService tokenService) {
			this.httpClient = httpClient;
			this.tokenService = tokenService;
		}
		public async Task<JadwalShiftSecurityDTO> AddJadwalShiftSecurity(JadwalShiftSecurityDTO dto) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PostAsJsonAsync("/JadwalShiftSecurity", dto);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalShiftSecurityDTO>();
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

		public async Task<JadwalShiftSecurityDTO?> GetByInisialAsync(string inisial) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/JadwalShiftSecurity/Inisial/{inisial}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalShiftSecurityDTO>();
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

		public async Task<List<JadwalShiftSecurityDTO>> GetJadwalShiftSecurityAsync() {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync("/JadwalShiftSecurity");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<JadwalShiftSecurityDTO>)Enumerable.Empty<JadwalShiftSecurityDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalShiftSecurityDTO>>();
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

		public async Task<JadwalShiftSecurityDTO> UpdateJadwalShiftSecurity(JadwalShiftSecurityDTO dto) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await httpClient.PutAsJsonAsync("/JadwalShiftSecurity", dto);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default(JadwalShiftSecurityDTO);
						}

						return await response.Content.ReadFromJsonAsync<JadwalShiftSecurityDTO>();
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
