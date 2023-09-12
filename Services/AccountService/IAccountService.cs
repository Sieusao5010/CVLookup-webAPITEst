using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.AccountService
{
    public interface IAccountService
    {
        public Task<List<AccountVM>> AccountList();
        public Task<AccountVM> GetAccountById(int id);
        public Task<AccountVM> GetAccountByEmail(string email);
        public Task<AccountVM> Add(AccountVM account);
        public Task<AccountVM> Update(string Id, AccountVM newAccount);
        public Task<AccountVM> Delete(string Id);
    }
}
