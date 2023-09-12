using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.UserService
{
    public interface IUserService
    {
        public Task<List<UserVM>> UserList();
		public Task<UserVM> GetAccountById(int id);
		public Task<UserVM> GetAccountByEmail(string email);
        public Task<UserVM> Add(UserVM user);
        public Task<UserVM> Update(string Id, UserVM newUser);
        public Task<UserVM> Delete(string Id);
    }
}
