using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
	public class JadwalShiftDepartemenService : IJadwalShiftDepartemenService {
		private readonly ITokenService tokenService;
		private readonly HttpClient httpClient;

		public JadwalShiftDepartemenService(ITokenService tokenService, HttpClient httpClient) {
			this.tokenService = tokenService;
			this.httpClient = httpClient;
		}

		public async Task<JadwalShiftDepartemenDTO> AddJadwalShiftDepartemen(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PostAsJsonAsync($"/JadwalShiftDepartemen", jadwalShiftDepartemenDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalShiftDepartemenDTO>();
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

		public async Task<JadwalShiftDepartemenDTO> AddRange(List<JadwalShiftDepartemenDTO> jadwalShiftDepartemenDTOs) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PostAsJsonAsync("/JadwalShiftDepartemen/AddRange", jadwalShiftDepartemenDTOs);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalShiftDepartemenDTO>();
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

		public async Task<List<JadwalShiftDepartemenDTO>> GetJadwalShiftDepartemen() {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync("/JadwalShiftDepartemen");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<JadwalShiftDepartemenDTO>)Enumerable.Empty<JadwalShiftDepartemenDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalShiftDepartemenDTO>>();
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

		public async Task<JadwalShiftDepartemenDTO> UpdateJadwalShiftDepartemen(JadwalShiftDepartemenDTO jadwalShiftDepartemenDTO) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await httpClient.PutAsJsonAsync("/JadwalShiftDepartemen", jadwalShiftDepartemenDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default(JadwalShiftDepartemenDTO);
						}

						return await response.Content.ReadFromJsonAsync<JadwalShiftDepartemenDTO>();
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
