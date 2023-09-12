using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.AccountService
{
	public class AccountService : IAccountService
	{
		private readonly AppDBContext _dbContext;

		public AccountService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<List<AccountVM>> AccountList()
		{
			throw new NotImplementedException();
		}

		public async Task<AccountVM> Add(AccountVM account)
		{
			throw new NotImplementedException();
		}

		public Task<AccountVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public async Task<AccountVM> GetAccountByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public Task<AccountVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<AccountVM> Update(string Id, AccountVM newAccount)
		{
			throw new NotImplementedException();
		}
	}
}
