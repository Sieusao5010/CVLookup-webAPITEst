using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.AccountUserService
{
    public class AccountUserService : IAccountUserService
    {
        private readonly AppDBContext _dbContext;

        public AccountUserService(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<AccountUserVM>> AccountUserList()
        {
            throw new NotImplementedException();
        }

        public Task<AccountUserVM> Add(RoleVM role)
        {
            throw new NotImplementedException();
        }

        public Task<AccountUserVM> Delete(string accountId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<AccountUserVM> GetAccountById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<AccountUserVM> Update(string Id, RoleVM newAccount)
        {
            throw new NotImplementedException();
        }
    }
}
