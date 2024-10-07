using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Net.Http.Headers;

namespace AuthAPI {
	public class JwtTokenValidateAttribute : Attribute, IAuthorizationFilter {
		public void OnAuthorization(AuthorizationFilterContext context) {
			//throw new NotImplementedException();
			string token = context.HttpContext.Request.Headers[HeaderNames.Authorization].ToString().Replace("Bearer ", "");
			if(string.IsNullOrWhiteSpace(token)) {
				context.Result = new UnauthorizedResult();
				return;
			}

            JwtTokenService? tokenManager = (JwtTokenService?)context.HttpContext.RequestServices.GetService(typeof(JwtTokenService));
			if(tokenManager != null && !tokenManager.IsTokenValid(token)) {
				context.Result = new UnauthorizedResult();
				return;
			}


		}
	}
}
