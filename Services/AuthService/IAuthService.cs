using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.AuthService
{
	public interface IAuthService
	{
		public Task<AuthVM> Login(string email, string password);
		public Task<AccountUserVM> Register(UserVM user, AccountVM account, string role);
	}
}
