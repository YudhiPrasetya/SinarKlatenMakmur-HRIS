namespace AuthAPI.Models
{
	public record AuthenticationToken(string UserName, string Role, string Scopes, string Token, DateTime ExpiresIn);
}
