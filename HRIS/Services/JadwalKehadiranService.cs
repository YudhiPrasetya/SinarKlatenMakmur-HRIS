using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using HRIS.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Newtonsoft.Json;
using SKM.Shared.Dtos;
using System.Net.Http.Json;
using System.Text;

namespace HRIS.Services {
	public class JadwalKehadiranService : IJadwalKehadiranService {
		private readonly ITokenService tokenService;
		private readonly HttpClient httpClient;

		public JadwalKehadiranService(ITokenService tokenService, HttpClient httpClient) {
			this.tokenService = tokenService;
			this.httpClient = httpClient;
		}
		public async Task<JadwalKehadiranDTO?> AddJadwalKehadiranRange(List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
			var token = await this.tokenService.GetToken();
			if (token.Token is not null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				await this.httpClient.PostAsJsonAsync("/JadwalKehadiran", jadwalKehadiranDTOs);
			}
			return default;
		}

      public async Task<List<JadwalKehadiranDTO>?> GetByGroupAndRangePeriode(string group, int month, int year) {
         var token = await this.tokenService.GetToken();
         if (token.Token is not null) {
            this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				string strGroup = group.Replace(" ", "_").Replace("/", "-");
            var response = await this.httpClient.GetAsync($"/JadwalKehadiran/GetByGroupAndRangePeriode/{strGroup}/{month}/{year}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               List<JadwalKehadiranDTO>? result = await response.Content.ReadFromJsonAsync<List<JadwalKehadiranDTO>>();
               return result;
            }
         }
         return default;
      }

		public async Task<JadwalKehadiranDTO?> GetByNamaAndDate(string? nama, string strDate) {
			var token = await this.tokenService.GetToken();
			if (token.Token is not null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var response = await this.httpClient.GetAsync($"/JadwalKehadiran/GetByNamaAndDate/{nama}/{strDate}");
				if (response.IsSuccessStatusCode) {
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
						return default;
					}
					JadwalKehadiranDTO? result = await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
					return result;
				}
			}
			return default;
		}

		public async Task<JadwalKehadiranDTO?> GetByNIKAndDate(string nik, string tgl) {
			var token = await this.tokenService.GetToken();
			if (token.Token is not null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var response = await this.httpClient.GetAsync($"/JadwalKehadiran/GetByNIKAndDate/{nik}/{tgl}");
				if (response.IsSuccessStatusCode) {
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
						return default;
					}
					JadwalKehadiranDTO? result = await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
					return result;
				}
			}
			return default;
		}

      public async Task<List<int>?> GetByNIkAndYearMonth(string nik, int year, int month) {
         var token = await this.tokenService.GetToken();
         if (token.Token is not null) {
            this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            var response = await this.httpClient.GetAsync($"/JadwalKehadiran/GetByNIKAndYearMonth/{nik}/{year}/{month}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               List<int>? result = await response.Content.ReadFromJsonAsync<List<int>>();
               return result;
            }
         }
         return default;
      }

      public async Task<List<JadwalKehadiranDTO>?> GetListJadwalKehadiranAsync() {
			var token = await this.tokenService.GetToken();
			if (token.Token is not null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync("/JadwalKehadiran");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						List<JadwalKehadiranDTO>? result = await response.Content.ReadFromJsonAsync<List<JadwalKehadiranDTO>>();
						return result;
					}
			}
			return default;
		}

		public async Task<JadwalKehadiranDTO?> UpdateJadwal(JadwalKehadiranDTO jadwalKehadiranDTO) {
			var token = await tokenService.GetToken();
			if (token.Token is not null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var response = await this.httpClient.PutAsJsonAsync("/JadwalKehadiran/Update", jadwalKehadiranDTO);
				if (response.IsSuccessStatusCode) {
					JadwalKehadiranDTO? rst = await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
					return rst;
				}
				
			}
			return default;
		}

		public async Task<JadwalKehadiranDTO?> UpdateJadwalKehadiran(JadwalKehadiranDTO jadwalKehadiranDTO) {
			var token = await tokenService.GetToken();
			if(token?.Token is not null) {
            this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            var response = await this.httpClient.PutAsJsonAsync("/JadwalKehadiran", jadwalKehadiranDTO);
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               JadwalKehadiranDTO? result = await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
               return result;
            }
         }
			return default;
      }

      public async Task<JadwalKehadiranDTO?> UpdateJadwalKehadiranRange(List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         var token = await tokenService.GetToken();
         if (token!.Token is not null) {
            this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            await this.httpClient.PutAsJsonAsync("/JadwalKehadiran/UpdateRange", jadwalKehadiranDTOs);
         }
         return default;
      }


		public async Task<List<JadwalKehadiranDTO>?> GetTerlambat(string startDate, string endDate) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/JadwalKehadiran/Terlambat/{startDate}/{endDate}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						List<JadwalKehadiranDTO>? result = await response.Content.ReadFromJsonAsync<List<JadwalKehadiranDTO>>();
						return result;
					}
				}
				return default;
			}
			catch (Exception) {

				throw;
			}
		}

		public async Task<JadwalKehadiranDTO?> AddKeterlambatan(JadwalKehadiranDTO terlambat) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PostAsJsonAsync<JadwalKehadiranDTO>($"/JadwalKehadiran/Terlambat/Add", terlambat);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
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

		public async Task<JadwalKehadiranDTO?> UpdateKeterlambatan(JadwalKehadiranDTO terlambat) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PutAsJsonAsync<JadwalKehadiranDTO>("/JadwalKehadiran/Terlambat/Update", terlambat);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
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

		public async Task<JadwalKehadiranDTO?> PatchTerlambat(int id, JadwalKehadiranDTO jadwalKehadiranDTO) {
			var token = await tokenService.GetToken();
			if (token.Token is not null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var content = new StringContent(JsonConvert.SerializeObject(jadwalKehadiranDTO), Encoding.UTF8, "application/json");
				var response = await this.httpClient.PatchAsync($"JadwalKehadiran/PatchTerlambat/{id}", content);
				if (response.IsSuccessStatusCode) {
					return default;
				}
			}
			return default;
		}

		public async Task<List<JadwalKehadiranDTO>?> GetByDateRange(string startDate, string endDate) {
			var token = await tokenService.GetToken();
			if (token.Token != null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var response = await this.httpClient.GetAsync($"/JadwalKehadiran/GetByDateRange/{startDate}/{endDate}");

				if (response.IsSuccessStatusCode) {
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
						return default;
					}
					return await response.Content.ReadFromJsonAsync<List<JadwalKehadiranDTO>>();
				}
				else {
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http status:{response.StatusCode} Message -{message}");
				}
			}
			return null;
		}

		public async Task<List<JadwalKehadiranDTO>?> GetByGroupAndDateRange(string group, string startDate, string endDate) {
			var token = await tokenService.GetToken();
			if (token.Token != null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var response = await this.httpClient.GetAsync($"/JadwalKehadiran/GetByGroupAndDateRange/{group}/{startDate}/{endDate}");

				if (response.IsSuccessStatusCode) {
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
						return default;
					}
					return await response.Content.ReadFromJsonAsync<List<JadwalKehadiranDTO>>();
				}
				else {
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http status:{response.StatusCode} Message -{message}");
				}
			}
			return null;
		}

		public async Task<JadwalKehadiranDTO?> UbahJam(JadwalKehadiranDTO jadwalKehadiranDTO) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PutAsJsonAsync<JadwalKehadiranDTO>("/JadwalKehadiran/UbahJam", jadwalKehadiranDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
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

		public async Task<List<JadwalKehadiranDTO>?> PatchMultiKeterlambatan(List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
			var token = await tokenService.GetToken();
			if (token.Token is not null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var content = new StringContent(JsonConvert.SerializeObject(jadwalKehadiranDTOs), Encoding.UTF8, "application/json");
				var response = await this.httpClient.PatchAsync($"JadwalKehadiran/PatchMultiKeterlambatan", content);
				if (response.IsSuccessStatusCode) {
					return default;
				}
			}
			return default;
		}

		public async Task<List<JadwalKehadiranDTO>?> GetByPeriode(int bulan, int tahun) {
			var token = await tokenService.GetToken();
			if (token.Token != null) {
				this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				var response = await this.httpClient.GetAsync($"/JadwalKehadiran/GetByPeriode/{bulan}/{tahun}");

				if (response.IsSuccessStatusCode) {
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
						return default;
					}
					return await response.Content.ReadFromJsonAsync<List<JadwalKehadiranDTO>>();
				}
				else {
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http status:{response.StatusCode} Message -{message}");
				}
			}
			return null;
		}
	}
}
