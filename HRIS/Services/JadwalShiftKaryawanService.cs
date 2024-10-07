using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
	public class JadwalShiftKaryawanService : IJadwalShiftKaryawanService {
		private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public JadwalShiftKaryawanService(HttpClient httpClient, ITokenService tokenService)
      {
			this.httpClient = httpClient;
			this.tokenService = tokenService;
		}
      public async Task<JadwalShiftKaryawanDTO> AddJadwalShiftKaryawan(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if(token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PostAsJsonAsync("/JadwalShiftKaryawan", jadwalShiftKaryawanDTO);
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalShiftKaryawanDTO>();
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

      public async Task<List<JadwalShiftKaryawanDTO>?> GetByLikeDeskripsi(string desc) {
         var token = await tokenService.GetToken();
         if (token.Token != null) {
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            var response = await this.httpClient.GetAsync($"/JadwalShiftKaryawan/GetByLikeDeskripsi/{desc}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               return await response.Content.ReadFromJsonAsync<List<JadwalShiftKaryawanDTO>>();
            }
            else {
               var message = await response.Content.ReadAsStringAsync();
               throw new Exception($"Http status code: {response.StatusCode} message: {message}");
            }
         }
         return null;
      }

      public async Task<List<JadwalShiftKaryawanDTO>> GetJadwalShiftKaryawan() {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync("/JadwalShiftKaryawan");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalShiftKaryawanDTO>>();
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

		public async Task<JadwalShiftKaryawanDTO> UpdateJadwalShiftKaryawan(JadwalShiftKaryawanDTO jadwalShiftKaryawanDTO){
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await httpClient.PutAsJsonAsync<JadwalShiftKaryawanDTO>("/JadwalShiftKaryawan", jadwalShiftKaryawanDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}

						return await response.Content.ReadFromJsonAsync<JadwalShiftKaryawanDTO>();
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
