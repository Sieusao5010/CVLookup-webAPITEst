using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.UserRoleService
{
    public interface IUserRoleService
    {
        public Task<List<UserRoleVM>> UserRoleList();
		public Task<UserRoleVM> GetAccountById(int id);
        public Task<UserRoleVM> Add(UserRoleVM userRole);
        public Task<UserRoleVM> Update(string Id, UserRoleVM newUserRole);
        public Task<UserRoleVM> Delete(string Id);
    }
}
