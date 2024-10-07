using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class SuratPerintahLemburService : ISuratPerintahLemburService {
      private readonly HttpClient _httpClient;
		private readonly ITokenService tokenService;

		public SuratPerintahLemburService(HttpClient httpClient, ITokenService tokenService)
        {
         _httpClient = httpClient;
			this.tokenService = tokenService;
		}
      public async Task<SuratPerintahLemburDTO> AddSPLAsync(SuratPerintahLemburDTO splDTO) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.PostAsJsonAsync<SuratPerintahLemburDTO>("/SPL", splDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<SuratPerintahLemburDTO>();
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

      public async Task<SuratPerintahLemburDTO> AddSPLRangeAsync(List<SuratPerintahLemburDTO> splDTOs) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.PostAsJsonAsync<List<SuratPerintahLemburDTO>>("/SPL/AddSPLRange", splDTOs);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<SuratPerintahLemburDTO>();
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

      public async Task<SuratPerintahLemburDTO> DeleteSPLAsync(int id) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.DeleteAsync($"/SPL/{id}");

					if (response.IsSuccessStatusCode) {
						return await response.Content.ReadFromJsonAsync<SuratPerintahLemburDTO>();
					}
					return default;
				}
            return null;

            //return false;
         }
         catch (Exception) {
            //Log exception
            throw;
         }
      }

      public async Task<List<SuratPerintahLemburDTO>?> GetByDateRange(string startDate, string endDate) {
         var token = await tokenService.GetToken();
         if (token.Token != null) {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            var response = await _httpClient.DeleteAsync($"/SPL/GetByDateRange{startDate}/{endDate}");

            if (response.IsSuccessStatusCode) {
               return await response.Content.ReadFromJsonAsync<List<SuratPerintahLemburDTO>>();
            }
            return default;
         }
         return default;
      }

      public async Task<List<SuratPerintahLemburDTO>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await _httpClient.GetAsync($"/SPL/GroupAndDate/{group}/{startDate}/{endDate}");
               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							//return (List<SuratPerintahLemburDTO>)Enumerable.Empty<SuratPerintahLemburDTO>();
							return default;
                  }
                  //var rst = await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
                  //List<DepartmentDTO>? departmentList = rst;
                  //return departmentList;
                  return await response.Content.ReadFromJsonAsync<List<SuratPerintahLemburDTO>>();
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

      public async Task<IEnumerable<SuratPerintahLemburDTO>> GetListSPLsAsync() {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.GetAsync("/SPL");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<SuratPerintahLemburDTO>)Enumerable.Empty<SuratPerintahLemburDTO>();
						}
						//var rst = await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
						//List<DepartmentDTO>? departmentList = rst;
						//return departmentList;
						return await response.Content.ReadFromJsonAsync<List<SuratPerintahLemburDTO>>();
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

      public async Task<List<SuratPerintahLemburDTO>?> GetSPLAsync(int id) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.GetAsync($"/SPL/{id}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<SuratPerintahLemburDTO>>();
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

      public async Task<List<SuratPerintahLemburDTO>> GetSPLByGroupId_OTDateAsync(int groupId, int otDate) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.GetAsync($"/SPL/{groupId}/{otDate}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<SuratPerintahLemburDTO>>();
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

		public async Task LapLemburAll() {
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.GetAsync("/SPL/Report/All");
					//if (response.IsSuccessStatusCode) {
					//	//var stream = await response.Content.ReadAsStreamAsync();
					//	//string path = @"D:\SKM\kehadiran.xlsx";
					//	//using(var fileStream = File.Create(path)) {
					//	//   await stream.CopyToAsync(fileStream);
					//	//}

					//	//Console.WriteLine("File downloaded successfully");
					//	var tempPath = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
					//	if (!Directory.Exists(tempPath)) {
					//		Directory.CreateDirectory(tempPath);
					//	}
					//	//Save Excel to Tem directory.  
					//	var tempFilePath = Path.Combine(tempPath, string.Format("{0}.{1}", "Test", "xlsx"));
					//	using (var newFile = File.Create(tempFilePath)) {
					//		response.Content.ReadAsStreamAsync().Result.CopyTo(newFile);
					//	}
					//	//Open Excel to view.  
					//	Process.Start(tempFilePath);
					//}
					//else {
					//	Console.WriteLine("File download failed", response.ReasonPhrase);
					//}
					//using var resultStream = await response.Content.ReadAsStreamAsync();
					//using var fileStream = File.Create("d:\\" + "kehadiran.xlsx");
					//resultStream.CopyTo(fileStream);
				}
			}
			catch (Exception) {

				throw;
			}
		}

      public async Task ReportRekapLembur(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               var response = await _httpClient.GetAsync($"/SPL/ReportRekapLembur/{group}/{startDate}/{endDate}");

            }
         }
         catch (Exception) {

            throw;
         }
      }

      public async Task<SuratPerintahLemburDTO?> UpdateSPLAsync(SuratPerintahLemburDTO splDTO) {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await _httpClient.PutAsJsonAsync<SuratPerintahLemburDTO>("/SPL", splDTO);
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}

						return await response.Content.ReadFromJsonAsync<SuratPerintahLemburDTO>();
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
