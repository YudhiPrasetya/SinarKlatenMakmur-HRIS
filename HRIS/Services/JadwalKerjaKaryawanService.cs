using DocumentFormat.OpenXml.Wordprocessing;
using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Net.Http;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class JadwalKerjaKaryawanService : IJadwalKerjaKaryawanService {
      private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public JadwalKerjaKaryawanService(HttpClient httpClient, ITokenService tokenService)
      {
         this.httpClient = httpClient;
			this.tokenService = tokenService;
		}

      public async Task<JadwalKerjaKaryawanDTO> AddJadwalKerjaKaryawanRange(IEnumerable<JadwalKerjaKaryawanDTO> jadwalDTOs) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PostAsJsonAsync("/JadwalKerjaKaryawan/AddRange", jadwalDTOs);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalKerjaKaryawanDTO>();
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

      public async Task<IEnumerable<JadwalKerjaKaryawanDTO>> GetAllJadwalKerjaKaryawan() {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync("/JadwalKerjaKaryawan");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<JadwalKerjaKaryawanDTO>)Enumerable.Empty<JadwalKerjaKaryawanDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalKerjaKaryawanDTO>>();
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

      public async Task<List<JadwalKerjaKaryawanDTO>> GetByGroupName(string groupName) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/JadwalKerjaKaryawan/GroupName/{groupName}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalKerjaKaryawanDTO>>();
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

      public async Task<JadwalKerjaKaryawanDTO> GetById(int id) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/JadwalKerjaKaryawan/{id}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<JadwalKerjaKaryawanDTO>();
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

      public async Task<JadwalKerjaKaryawanDTO> GetByNIK(string nik) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				}
				var response = await this.httpClient.GetAsync($"/JadwalKerjaKaryawan/NIK/{nik}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               return await response.Content.ReadFromJsonAsync<JadwalKerjaKaryawanDTO>();
            }
            else {
               var message = await response.Content.ReadAsStringAsync();
               throw new Exception($"Http status code: {response.StatusCode} message: {message}");
            }
         }
         catch (Exception) {

            throw;
         }

      }

		public async Task<JadwalKerjaKaryawanDTO> UpdateJadwalKerjaKaryawan(JadwalKerjaKaryawanDTO jadwalDTO) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await httpClient.PutAsJsonAsync("/JadwalKerjaKaryawan/UpdateSingle", jadwalDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}

						return await response.Content.ReadFromJsonAsync<JadwalKerjaKaryawanDTO>();
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

		public async Task<JadwalKerjaKaryawanDTO> UpdateJadwalKerjaKaryawanRange(IEnumerable<JadwalKerjaKaryawanDTO?> jadwalDTOs) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await httpClient.PutAsJsonAsync("/JadwalKerjaKaryawan/UpdateRange", jadwalDTOs);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}

						return await response.Content.ReadFromJsonAsync<JadwalKerjaKaryawanDTO>();
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

      public async Task<List<JadwalKerjaKaryawanDTO>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync($"/JadwalKerjaKaryawan/GroupAndDate/ {group}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     //return (List<JadwalKerjaKaryawanDTO>)Enumerable.Empty<JadwalKerjaKaryawanDTO>();
                     return default;
                  }
                  //var rst = await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
                  //List<DepartmentDTO>? departmentList = rst;
                  //return departmentList;
                  return await response.Content.ReadFromJsonAsync<List<JadwalKerjaKaryawanDTO>>();
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

		public async Task<List<JadwalKerjaKaryawanDTO>> GetByDate(DateTime date) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/JadwalKerjaKaryawan/GetByDate/{date}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<JadwalKerjaKaryawanDTO>>();
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

		public async Task<JadwalKerjaKaryawanDTO> DeleteJadwalKerjaKaryawan(int id) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.DeleteAsync($"/JadwalKerjaKaryawan/{id}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  //var rst = await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
                  //List<DepartmentDTO>? departmentList = rst;
                  //return departmentList;
                  return await response.Content.ReadFromJsonAsync<JadwalKerjaKaryawanDTO>();
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
