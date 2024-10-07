using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKM.Shared.Helpers {
   public static class TokenValidation {
      public static bool IsValidToken(string token) {
         JwtSecurityToken jwtSecurityToken;
			try {
            jwtSecurityToken = new JwtSecurityToken(token);
			}
			catch (Exception) {
            return false;
			}
         Console.WriteLine(DateTime.UtcNow);
         return jwtSecurityToken.ValidTo > DateTime.UtcNow;
      }
   }
}
