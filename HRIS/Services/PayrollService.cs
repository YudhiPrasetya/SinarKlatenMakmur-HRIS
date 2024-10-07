using HRIS.Contracts;
using SKM.Shared.Dtos;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace HRIS.Services {
   public class PayrollService : IPayrollService {
      private readonly HttpClient _httpClient;
      private readonly ITokenService _tokenService;

      public PayrollService(HttpClient httpClient, ITokenService tokenService) {
         _httpClient = httpClient;
         _tokenService = tokenService;
      }

      public async Task<PayrollDTO>? AddPayroll(PayrollDTO payrollDTO) {
         try {
            var token = await _tokenService.GetToken();
            if(token?.Token is not null) {
               _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
               var response = await _httpClient.PostAsJsonAsync<PayrollDTO>("/Payroll", payrollDTO);

               if (response.IsSuccessStatusCode) {
                  if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                     return default;
                  }
                  return await response.Content.ReadFromJsonAsync<PayrollDTO>();
               }
               else {
                  var message = await response.Content.ReadAsStringAsync();
                  throw new Exception($"Http status:{response.StatusCode} Message -{message}");
               }
            }
            return default;
         }
         catch (Exception) {
            throw;
         }
      }

      public async Task<bool> PostPayrollRange(List<PayrollDTO> payrollDTOs) {
         var token = await _tokenService.GetToken();
         if (token?.Token is not null) {
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.Token);
            var response = await _httpClient.PostAsJsonAsync("/Payroll/PostPayrollRange", payrollDTOs);

            if (response.IsSuccessStatusCode) {
               return await response.Content.ReadFromJsonAsync<bool>();
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
