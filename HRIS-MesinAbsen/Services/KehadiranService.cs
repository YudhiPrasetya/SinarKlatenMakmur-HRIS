using HRIS_MesinAbsen.Contracts;
using SKM.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_MesinAbsen.Services {
   public class KehadiranService : IKehadiranServicecs {
      private readonly HttpClient httpClient;

      public KehadiranService(HttpClient httpClient)
        {
         this.httpClient = httpClient;
      }
        public async Task<bool> AddKehadiranAsync(AbsenMasukDTO absenMasukDTO) {
         //throw new NotImplementedException();
         try {
            var response = await this.httpClient.PostAsJsonAsync<AbsenMasukDTO>("https://localhost:7023/Kehadiran", absenMasukDTO);
            if (response.IsSuccessStatusCode) {
               if (response.StatusCode == System.Net.HttpStatusCode.NoContent) {
                  return default;
               }
               return await response.Content.ReadFromJsonAsync<bool>();
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
