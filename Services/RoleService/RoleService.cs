using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.RoleService
{
	public class RoleService : IRoleService
	{
		private readonly AppDBContext _dbContext;

		public RoleService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}
		public Task<List<RoleVM>> RoleList()
		{
			throw new NotImplementedException();
		}

		public Task<RoleVM> Add(RoleVM role)
		{
			throw new NotImplementedException();
		}

		public Task<RoleVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<RoleVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<RoleVM> Update(string Id, RoleVM newAccount)
		{
			throw new NotImplementedException();
		}
	}
}
