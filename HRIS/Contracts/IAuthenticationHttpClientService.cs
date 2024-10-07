using HRIS.Models;

namespace HRIS.Contracts {
	public interface IAuthenticationHttpClientService {
		//Task<UserLoginResultDTO> LoginUser(UserLoginDTO userLoginDTO);
		//Task<string> LoginUser(UserLoginDTO userLoginDTO);

		//Task<TokenDTO> LoginUser(UserLoginDTO userLoginDTO);

		Task<HttpResponseMessage> LoginUser(UserLoginDTO userLoginDTO);
		Task LogoutUser(string userName);
	}
}
