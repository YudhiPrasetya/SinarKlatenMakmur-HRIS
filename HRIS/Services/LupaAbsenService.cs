using HRIS.Contracts;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class LupaAbsenService : ILupaAbsenService {
      private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

		public LupaAbsenService(HttpClient httpClient, ITokenService tokenService)
      {
         this.httpClient = httpClient;
			this.tokenService = tokenService;
		}

      public async Task<LupaAbsenDTO> AddLupaAbsenAsync(LupaAbsenDTO lupaAbsenDTO) {
         //throw new NotImplementedException();
         try {
            var token = await tokenService.GetToken();
            if(token.Token != null) {
               this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.PostAsJsonAsync<LupaAbsenDTO>("/LupaAbsen", lupaAbsenDTO);

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<LupaAbsenDTO>();
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

      public async Task<List<LupaAbsenDTO>> GetListLupaAbsenAsync() {
         //throw new NotImplementedException();
         try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync("/LupaAbsen");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<LupaAbsenDTO>)Enumerable.Empty<LupaAbsenDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<LupaAbsenDTO>>();
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

		public async Task<List<LupaAbsenDTO>> GetByGroupAndDate(string group, string startDate, string endDate) {
			//throw new NotImplementedException();
			try {
				var token = await tokenService.GetToken();
				if (token.Token != null) {
					this.httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await this.httpClient.GetAsync($"/LupaAbsen/GroupAndDate/{group}/{startDate}/{endDate}");

					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<List<LupaAbsenDTO>>();
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
               var response = await this.httpClient.GetAsync($"/LupaAbsen/ExportToExcel/{group}/{startDate}/{endDate}");
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
   }
}
