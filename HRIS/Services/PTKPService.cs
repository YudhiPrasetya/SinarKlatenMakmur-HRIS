using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
	public class PTKPService : IPTKPService {
		private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public PTKPService(HttpClient httpClient, ITokenService tokenService)
      {
			this.httpClient = httpClient;
			this.tokenService = tokenService;
		}
      public async Task<IEnumerable<PenghasilanTidakKenaPajakDTO>> GetPTKPAsync() {
			try {
				var tokenDTO = await tokenService.GetToken();
				if(tokenDTO.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
					var response = await this.httpClient.GetAsync("/PTKP");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<PenghasilanTidakKenaPajakDTO>)Enumerable.Empty<PenghasilanTidakKenaPajakDTO>();
						}
						return await response.Content.ReadFromJsonAsync<IEnumerable<PenghasilanTidakKenaPajakDTO>>();
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
	}
}
