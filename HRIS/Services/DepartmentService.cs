using HRIS.Components;
using HRIS.Contracts;
using HRIS.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using SKM.Shared.Dtos;
using SKM.Shared.Helpers;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Net.Http.Json;


namespace HRIS.Services
{
	public class DepartmentService : IDepartmentService
	{
		private readonly HttpClient httpClient;
		private readonly ITokenService tokenService;

      public DepartmentService(HttpClient _httpClient, ITokenService tokenService)
		{
			httpClient = _httpClient;
			this.tokenService = tokenService;
		}

		public async Task<List<DepartmentDTO>> GetListDepartmentsAsync()
		{
			//throw new NotImplementedException();
			//try {
			//	var tokenDTO = await this.tokenService.GetToken();
			//	if(tokenDTO.Token != null && TokenValidation.IsValidToken(tokenDTO.Token)) {
			//		httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenDTO.Token);
			//		var response = await httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Departments");
			//		if (response.IsSuccessStatusCode) {
			//			if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
			//				return (List<DepartmentDTO>)Enumerable.Empty<DepartmentDTO>();
			//			}
			//			return await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
			//		}else{
			//			var message = await response.Content.ReadAsStringAsync();
			//			throw new Exception($"Http status code: {response.StatusCode} message: {message}");
			//		}
			//	}
			//	//else {
			//	//	Exception e = new();
			//	//	await MainLayout.HandleException(e);
			//	//	return null;
			//	//}
			//	return null; ;
			//}catch (Exception e) {
			//	//throw;
			//	await MainLayout.HandleException(e);
			//	return null;
			//}

			try {
				var token = await this.tokenService.GetToken();
				if(token.Token is not null) {
					Console.WriteLine($"token: {token.Token}");
					httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					//var response = await httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Departments");
					var response = await httpClient.GetAsync("/Departments");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return (List<DepartmentDTO>)Enumerable.Empty<DepartmentDTO>();
						}
						return await response.Content.ReadFromJsonAsync<List<DepartmentDTO>>();
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

		public async Task<DepartmentDTO> GetDepartmentAsync(int id)
		{
			try
			{
				var token = await this.tokenService.GetToken();
				if(token.Token is not null) {
					httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					//var response = await httpClient.GetAsync($"{BaseUrl.LocalBaseUrl}/Departments/{id}");
					var response = await httpClient.GetAsync("/Departments/{id}");
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<DepartmentDTO>();
					}
					else {
						var message = await response.Content.ReadAsStringAsync();
						throw new Exception($"Http status code: {response.StatusCode} message: {message}");
					}
				}
					return null;

			}
			catch (Exception)
			{

				throw;
			}
		}

		public async Task<DepartmentDTO> AddDepartmentAsync(DepartmentDTO departmentDTO)
		{
			try
			{
				var token = await this.tokenService.GetToken();
				if(token.Token is not null) {
					httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					//var response = await httpClient.PostAsJsonAsync<DepartmentDTO>($"{BaseUrl.LocalBaseUrl}/Departments", departmentDTO);
					var response = await httpClient.PostAsJsonAsync<DepartmentDTO>("/Departments", departmentDTO);
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}
						return await response.Content.ReadFromJsonAsync<DepartmentDTO>();
					}
					else {
						var message = await response.Content.ReadAsStringAsync();
						throw new Exception($"Http status:{response.StatusCode} Message -{message}");
					}

				}
				return null;
			}
			catch (Exception)
			{
				throw;
			}
		}

		public async Task<DepartmentDTO> UpdateDepartmentAsync(DepartmentDTO departmentDTO)
		{
			try
			{
				var token = await this.tokenService.GetToken();
				if(token is not null) {
					httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					//var response = await httpClient.PutAsJsonAsync<DepartmentDTO>($"{BaseUrl.LocalBaseUrl}/Departments", departmentDTO);
					var response = await httpClient.PutAsJsonAsync<DepartmentDTO>($"/Departments", departmentDTO);
					if (response.IsSuccessStatusCode) {
						if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
							return default;
						}

						return await response.Content.ReadFromJsonAsync<DepartmentDTO>();
					}
					else {
						var message = await response.Content.ReadAsStringAsync();
						throw new Exception($"Http status:{response.StatusCode} Message -{message}");
					}
				}
				return null;

			}
			catch (Exception)
			{

			  throw;
			}
		}

		public async Task<DepartmentDTO?> DeleteDepartmentAsync(int id)
		{
			try
			{
				var token = await this.tokenService.GetToken();
				if(token.Token != null) {
					httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.Token);
					var response = await httpClient.DeleteAsync("/Departments/{id}");

					if (response.IsSuccessStatusCode) {
						return await response.Content.ReadFromJsonAsync<DepartmentDTO>();
					}
					return default;
				}
				return null;
			}
			catch (Exception)
			{
				//Log exception
				throw;
			}
		}

      public async Task<bool> SendDepartmentOffer(DepartmentDTO departmentDTO) {
         //throw new NotImplementedException();
         try {
            //var response = await httpClient.PostAsJsonAsync<DepartmentDTO>($"{BaseUrl.LocalBaseUrl}/Departments/sendoffer", departmentDTO);
				var response = await httpClient.PostAsJsonAsync<DepartmentDTO>("/Departments/sendoffer", departmentDTO);
				if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return false;
               }
               return true;
            }
            else {
               var message = await response.Content.ReadAsStringAsync();
               throw new Exception($"Http status:{response.StatusCode} Message -{message}");
            }

         }
         catch (Exception) {
            throw;
         }
      }
   }
}
