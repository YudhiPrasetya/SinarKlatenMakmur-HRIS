using DocumentFormat.OpenXml.Wordprocessing;
using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using static MudBlazor.Icons.Custom;

namespace HRIS.Services {
   public class KehadiranService : IKehadiranService {
      private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public KehadiranService(HttpClient httpClient, ITokenService tokenService)
      {
         this.httpClient = httpClient;
			this.tokenService = tokenService;
		}

		public async Task<KehadiranDTO> AbsenPulang(KehadiranDTO kehadiranDTO) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PutAsJsonAsync("/Kehadiran/AbsenPulang", kehadiranDTO);
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<KehadiranDTO>();
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

      public async Task<int?> TambahIjin(List<JadwalKehadiranDTO> jadwalKehadiranDTOs) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.PostAsJsonAsync<List<JadwalKehadiranDTO>>("/Kehadiran/Ijin", jadwalKehadiranDTOs);

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<int>();
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

      public async Task ExportToExcel(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync($"/Kehadiran/ExportToExcel/{group}/{startDate}/{endDate}");
               if (response.IsSuccessStatusCode) {
                  //var stream = await response.Content.ReadAsStreamAsync();
                  //string path = @"D:\SKM\kehadiran.xlsx";
                  //using(var fileStream = File.Create(path)) {
                  //   await stream.CopyToAsync(fileStream);
                  //}

                  //Console.WriteLine("File downloaded successfully");
                  var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
                  if (!Directory.Exists(tempPath)) {
                     Directory.CreateDirectory(tempPath);
                  }
                  //Save Excel to Tem directory.  
                  var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", "Test", "xlsx"));
                  using (var newFile = File.Create(tempFilePath)) {
                     response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
                  }
                  //Open Excel to view.  
                  Process.Start(tempFilePath);
               }
               else {
                  Console.WriteLine("File download failed", response.ReasonPhrase);
               }
               //using var resultStream = await response.Content.ReadAsStreamAsync();
               //using var fileStream = File.Create("d:\\" + "kehadiran.xlsx");
               //resultStream.CopyTo(fileStream);
            }
         }
         catch (Exception) {

            throw;
         }
      }

      public async Task<List<KehadiranDTO>> GetByDateRange(string? startDate, string? endDate) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/Kehadiran/DateRange/{startDate}/{endDate}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<KehadiranDTO>>();
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

      public async Task<IEnumerable<KehadiranDTO>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync($"/Kehadiran/GroupAndDate/{group}/{startDate}/{endDate}");

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<List<KehadiranDTO>>();
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

      public async Task<KehadiranDTO> GetByNIKAndDate(string nik, string date) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync($"/Kehadiran/NIKAndDate/{nik}/{date}");

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<KehadiranDTO>();
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

      public async Task<List<KehadiranDTO>> ListKehadiran() {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.GetAsync("/Kehadiran");

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<List<KehadiranDTO>>();
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

		public async Task<KehadiranDTO> UbahJam(KehadiranDTO kehadiranDTO) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PutAsJsonAsync<KehadiranDTO>("/Kehadiran/UbahJam", kehadiranDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<KehadiranDTO>();
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

		public async Task<KehadiranDTO> UpdateAbsen(KehadiranDTO kehadiranDTO) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await this.httpClient.PutAsJsonAsync<KehadiranDTO>("/Kehadiran", kehadiranDTO);

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<KehadiranDTO>();
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

		//public async Task<List<JadwalKehadiranDTO>?> GetTerlambat(string startDate, string endDate) {
		//	//throw new NotImplementedException();
		//	try {
		//		var token = await tokenService.GetToken();
		//		if (token.Token != null) {
		//			this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
		//			var response = await this.httpClient.GetAsync($"/Kehadiran/Terlambat/{startDate}/{endDate}");

		//			if (response.IsSuccessStatusCode) {
		//				if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
		//					return default;
		//				}
		//				return await response.Content.ReadFromJsonAsync<List<JadwalKehadiranDTO>>();
		//			}
		//			else {
		//				var message = await response.Content.ReadAsStringAsync();
		//				throw new Exception($"Http status:{response.StatusCode} Message -{message}");
		//			}
		//		}
		//		return null;

		//	}
		//	catch (Exception) {

		//		throw;
		//	}
		//}

		//public async Task<JadwalKehadiranDTO?> AddKeterlambatan(JadwalKehadiranDTO terlambat) {
		//	//throw new NotImplementedException();
		//	try {
		//		var token = await tokenService.GetToken();
		//		if (token.Token != null) {
		//			this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
		//			var response = await this.httpClient.PostAsJsonAsync<JadwalKehadiranDTO>($"/Kehadiran/Terlambat/Add", terlambat);

		//			if (response.IsSuccessStatusCode) {
		//				if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
		//					return default;
		//				}
		//				return await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
		//			}
		//			else {
		//				var message = await response.Content.ReadAsStringAsync();
		//				throw new Exception($"Http status:{response.StatusCode} Message -{message}");
		//			}
		//		}
		//		return null;
		//	}
		//	catch (Exception) {

		//		throw;
		//	}
		//}

		//public async Task<JadwalKehadiranDTO?> UpdateKeterlambatan(JadwalKehadiranDTO terlambat) {
		//	//throw new NotImplementedException();
		//	try {
		//		var token = await tokenService.GetToken();
		//		if (token.Token != null) {
		//			this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
		//			var response = await this.httpClient.PutAsJsonAsync<JadwalKehadiranDTO>("/Kehadiran/Terlambat/UPdate", terlambat);

		//			if (response.IsSuccessStatusCode) {
		//				if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
		//					return default;
		//				}
		//				return await response.Content.ReadFromJsonAsync<JadwalKehadiranDTO>();
		//			}
		//			else {
		//				var message = await response.Content.ReadAsStringAsync();
		//				throw new Exception($"Http status:{response.StatusCode} Message -{message}");
		//			}
		//		}
		//		return null;
		//	}
		//	catch (Exception) {

		//		throw;
		//	}
		//}
	}
}
