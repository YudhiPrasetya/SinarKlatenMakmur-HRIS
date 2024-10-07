using ClosedXML.Excel;
using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http.Json;

namespace HRIS.Services {
	public class JadwalKerjaSecurityService : IJadwalKerjaSecurityService {
		private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public JadwalKerjaSecurityService(HttpClient httpClient, ITokenService tokenService)
      {
			this.httpClient = httpClient;
			this.tokenService = tokenService;
		}
      public async Task<JadwalKerjaSecurityDTO> AddJadwalKerjaSecurityAsync(JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PostAsJsonAsync("/JadwalKerjaSecurity", jadwalKerjaSecurityDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalKerjaSecurityDTO>();
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

      public async Task<JadwalKerjaKaryawanDTO> AddRange(IEnumerable<JadwalKerjaSecurityDTO> jadwalKerjaSecurityDTOs) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.PostAsJsonAsync("/JadwalKerjaSecurity/AddJadwalSecurityRange", jadwalKerjaSecurityDTOs);

               if (response.IsSuccessStatusCode) {
						return default;
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

      public async Task<JadwalKerjaSecurityDTO> GetByDateAndName(string tgl, string name) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/JadwalKerjaSecurity/Jadwal/{tgl}/{name}");

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalKerjaSecurityDTO>();
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

      public async Task<List<JadwalKerjaSecurityDTO>> GetByDateRange(string startDate, string endDate) {
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync($"/JadwalKerjaSecurity/JKS/{startDate}/{endDate}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							//return (List<JadwalKerjaSecurityDTO>)Enumerable.Empty<JadwalKerjaSecurityDTO>();
							return default;
                  }
                  return await response.Content.ReadFromJsonAsync<List<JadwalKerjaSecurityDTO>>();

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

      public async Task<List<int>> GetByNIKAndMonthYear(string nik, int tahun, int bulan) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync($"/JadwalKerjaSecurity/JKS/{nik}/{tahun}/{bulan}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return (List<int>)Enumerable.Empty<int>();
                  }
                  return await response.Content.ReadFromJsonAsync<List<int>>();

                  //var jadwalKerjaSecurityDTOs = await response.Content.ReadFromJsonAsync<List<JadwalKerjaSecurityDTO>>();

                  //var jadwalKerjaSecurityFiltered = jadwalKerjaSecurityDTOs.ToPivotTable(
                  //    item => item.Nama,
                  //    item => item.Tgl.Day,
                  //    items => items.Any() ? items.First().Inisial_Shift : null);
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

      public async Task<IEnumerable<JadwalKerjaSecurityDTO>> GetJadwalKerjaSecuritiesAsync() {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if(token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync("/JadwalKerjaSecurity");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<JadwalKerjaSecurityDTO>)Enumerable.Empty<JadwalKerjaSecurityDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalKerjaSecurityDTO>>();

						//var jadwalKerjaSecurityDTOs = await response.Content.ReadFromJsonAsync<List<JadwalKerjaSecurityDTO>>();

                        //var jadwalKerjaSecurityFiltered = jadwalKerjaSecurityDTOs.ToPivotTable(
                        //    item => item.Nama,
                        //    item => item.Tgl.Day,
                        //    items => items.Any() ? items.First().Inisial_Shift : null);
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

		public async Task<IEnumerable<JadwalKerjaSecurityDTO>> GetJadwalKerjaSecuritiesByMonthYearAsync(int month, int year) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/JadwalKerjaSecurity/{month}/{year}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<JadwalKerjaSecurityDTO>)Enumerable.Empty<JadwalKerjaSecurityDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalKerjaSecurityDTO>>();

						//var jadwalKerjaSecurityDTOs = await response.Content.ReadFromJsonAsync<List<JadwalKerjaSecurityDTO>>();

						//var jadwalKerjaSecurityFiltered = jadwalKerjaSecurityDTOs.ToPivotTable(
						//    item => item.Nama,
						//    item => item.Tgl.Day,
						//    items => items.Any() ? items.First().Inisial_Shift : null);
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

		public async Task<JadwalKerjaSecurityDTO> UpdateJadwalKerjaSecurityAsync(JadwalKerjaSecurityDTO jadwalKerjaSecurityDTO) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PutAsJsonAsync("/JadwalKerjaSecurity", jadwalKerjaSecurityDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalKerjaSecurityDTO>();
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
