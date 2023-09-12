using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.RoleService
{
    public interface IRoleService
    {
        public Task<List<RoleVM>> RoleList();
		public Task<RoleVM> GetAccountById(int id);
        public Task<RoleVM> Add(RoleVM role);
        public Task<RoleVM> Update(string Id, RoleVM newAccount);
        public Task<RoleVM> Delete(string Id);
    }
}
