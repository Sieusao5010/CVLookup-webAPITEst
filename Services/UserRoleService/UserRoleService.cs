using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.UserRoleService
{
	public class UserRoleService : IUserRoleService
	{
		private readonly AppDBContext _dbContext;

		public UserRoleService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<UserRoleVM> Add(UserRoleVM userRole)
		{
			throw new NotImplementedException();
		}

		public Task<UserRoleVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<UserRoleVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<UserRoleVM> Update(string Id, UserRoleVM newUserRole)
		{
			throw new NotImplementedException();
		}

		public Task<List<UserRoleVM>> UserRoleList()
		{
			throw new NotImplementedException();
		}
	}
}
