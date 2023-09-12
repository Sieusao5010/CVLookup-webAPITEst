using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.AccountUserService
{
    public interface IAccountUserService
    {
        public Task<List<AccountUserVM>> AccountUserList();
        public Task<AccountUserVM> GetAccountById(int id);
        public Task<AccountUserVM> Add(RoleVM role);
        public Task<AccountUserVM> Update(string Id, RoleVM newAccount);
        public Task<AccountUserVM> Delete(string accountId, string userId);
    }
}
