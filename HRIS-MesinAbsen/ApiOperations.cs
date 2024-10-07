using Newtonsoft.Json;
using SKM.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HRIS_MesinAbsen {
	public class ApiOperations {
		private string baseUrl;

      public ApiOperations()
      {
         this.baseUrl = $"{BaseUrl.LocalBaseUrl}";
      }

      public User AuthenticateUser(string username, string password) {
         string endpoint = $"{this.baseUrl}/Auth";
         string method = "POST";
         string json = JsonConvert.SerializeObject(new {
				username,
				password
			});

         WebClient wc = new();
         wc.Headers["Content-Type"] = "application/json";
			try {
            string response = wc.UploadString(endpoint, method, json);
            return JsonConvert.DeserializeObject<User>(response);
			}
			catch (Exception) {

            //throw;
            return null;
			}
      }
   }
}
