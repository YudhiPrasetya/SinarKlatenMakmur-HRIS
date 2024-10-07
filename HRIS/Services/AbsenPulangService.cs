using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
	public class AbsenPulangService : IAbsenPulangService {
		private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public AbsenPulangService(HttpClient httpClient, ITokenService tokenService) {
			this.httpClient = httpClient;
			this.tokenService = tokenService;
		}
		public async Task<List<AbsenPulangDTO>> GetByDateRange(string? startDate, string? endDate) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					//var response = await this.httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/AbsenPulang/DateRange/{startDate}/{endDate}");
					var response = await this.httpClient.GetAsync($"/AbsenPulang/DateRange/{startDate}/{endDate}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<AbsenPulangDTO>>();
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
