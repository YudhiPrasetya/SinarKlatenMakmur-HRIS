using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
	public class UMPService : IUMPService {
		private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public UMPService(HttpClient httpClient, ITokenService tokenService)
      {
			this.httpClient = httpClient;
			this.tokenService = tokenService;
		}
      public async Task<IEnumerable<UpahMinimumProvinsiDTO>> GetUMP() {
			//throw new NotImplementedException();
			try {
				var tokenDTO = await tokenService.GetToken();
				if(tokenDTO.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
					var response = await this.httpClient.GetAsync("/UMP");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<UpahMinimumProvinsiDTO>)Enumerable.Empty<UpahMinimumProvinsiDTO>();
						}
						return await response.Content.ReadFromJsonAsync<IEnumerable<UpahMinimumProvinsiDTO>>();
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
