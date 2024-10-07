using DocumentFormat.OpenXml.Wordprocessing;
using HRIS.Contracts;
using Newtonsoft.Json.Linq;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Xml.Linq;

namespace HRIS.Services {
    public class EmployeeService : IEmployeeService {
      private readonly HttpClient _httpClient;
      private readonly ITokenService tokenService;
      private readonly ILocalStorageService localStorage;

      public EmployeeService(HttpClient httpClient, ITokenService tokenService, ILocalStorageService localStorage) {
         _httpClient = httpClient;
         this.tokenService = tokenService;
         this.localStorage = localStorage;
      }
      public async Task<EmployeeDTO> AddEmployeeAsync(EmployeeDTO employeeDTO) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
               //var response = await _httpClient.PostAsJsonAsync<EmployeeDTO>($"{BaseUrl.LocalBaseUrl}/Employees", employeeDTO);
					var response = await _httpClient.PostAsJsonAsync<EmployeeDTO>("/Employees", employeeDTO);
					if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<EmployeeDTO>();
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

        public async Task<EmployeeDTO> DeleteEmployeeAsync(int id) {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               //var response = await _httpClient.DeleteAsync($"{BaseUrl.LocalBaseUrl}/Employees/{id}");
					var response = await _httpClient.DeleteAsync($"/Employees/{id}");

					if (response.IsSuccessStatusCode) {
                  return await response.Content.ReadFromJsonAsync<EmployeeDTO>();
               }
               return default;
            }
            return null;

         }
         catch (Exception) {

            throw;
         }
        }

        public async Task<EmployeeDTO> GetEmployeeAsync(int id) {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if (tokenDTO.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               //var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Employees/{id}");
					var response = await _httpClient.GetAsync($"/Employees/{id}");
					if (response.IsSuccessStatusCode) {
                  return await response.Content.ReadFromJsonAsync<EmployeeDTO>();
               }
               return default;
            }
            return null;
         }
         catch (Exception) {

            throw;
         }
        }

        public async Task<List<EmployeeDTO>> GetListEmployeesAsync() {
         //throw new NotImplementedException();
            try {
               var token = await tokenService.GetToken();
               if(token.Token != null) {
                  _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",token.Token);
                  //var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Employees");
					   var response = await _httpClient.GetAsync("/Employees");
					if (response.IsSuccessStatusCode) {
                     if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                        return (List<EmployeeDTO>)Enumerable.Empty<EmployeeDTO>();
                     }
                     return await response.Content.ReadFromJsonAsync<List<EmployeeDTO>>();
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

      public async Task<List<EmployeeDTO>> GetListEmployeesByGroupIdAsync(int groupId) {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               //var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Employees/Group/{groupId}");
					var response = await _httpClient.GetAsync($"/Employees/Group/{groupId}");
					if (response.IsSuccessStatusCode) {
                  return await response.Content.ReadFromJsonAsync<List<EmployeeDTO>>();
               }
               return default;
            }
            return null;
         }
         catch (Exception) {

            throw;
         }
      }

		public async Task<List<EmployeeDTO>> GetSecurities() {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					_httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
					//var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Employees/GetSecurities");
					var response = await _httpClient.GetAsync("/Employees/GetSecurities");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<EmployeeDTO>)Enumerable.Empty<EmployeeDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<EmployeeDTO>>();
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

		public async Task<EmployeeDTO> UpdateEmployeeAsync(EmployeeDTO employeeDTO) {
         //throw new NotImplementedException();
         try {
            var tokenDTO = await tokenService.GetToken();
            if(tokenDTO.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", tokenDTO.Token);
               //var response = await _httpClient.PutAsJsonAsync<EmployeeDTO>($"{BaseUrl.LocalBaseUrl}/Employees", employeeDTO);
					var response = await _httpClient.PutAsJsonAsync<EmployeeDTO>("/Employees", employeeDTO);
					if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }

                  return await response.Content.ReadFromJsonAsync<EmployeeDTO>();
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
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               //var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Employees/ExportToExcel/{group}/{startDate}/{endDate}");
					var response = await _httpClient.GetAsync($"/Employees/ExportToExcel/{group}/{startDate}/{endDate}");
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

      public async Task<List<EmployeeDTO>> GetByGroupAndDate(string group, string startDate, string endDate) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if (token.Token != null) {
               _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
               //var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Employees/GroupAndDate/{group}/{startDate}/{endDate}");
					var response = await _httpClient.GetAsync($"/Employees/GroupAndDate/{group}/{startDate}/{endDate}");
					if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<List<EmployeeDTO>>();
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

		public async Task<List<EmployeeDTO>?> GetByNameContains(string name) {
			var token = await tokenService.GetToken();
			if (token.Token != null) {
				_httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
				//var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Employees/GroupAndDate/{group}/{startDate}/{endDate}");
				var response = await _httpClient.GetAsync($"/Employees/NameContains/{name}");
				if (response.IsSuccessStatusCode) {
					if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
						return default;
					}
					return await response.Content.ReadFromJsonAsync<List<EmployeeDTO>>();
				}
				else {
					var message = await response.Content.ReadAsStringAsync();
					throw new Exception($"Http status:{response.StatusCode} Message -{message}");
				}
			}
         return default;
		}

      public async Task<List<EmployeeDTO>?> GetByGroupName(string? groupName) {
         var token = await tokenService.GetToken();
         if (token.Token != null) {
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
            //var response = await _httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Employees/GroupAndDate/{group}/{startDate}/{endDate}");
            var response = await _httpClient.GetAsync($"/Employees/GroupName/{groupName}");
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               return await response.Content.ReadFromJsonAsync<List<EmployeeDTO>>();
            }
            else {
               var message = await response.Content.ReadAsStringAsync();
               throw new Exception($"Http status:{response.StatusCode} Message -{message}");
            }
         }
         return default;
      }
   }
}
