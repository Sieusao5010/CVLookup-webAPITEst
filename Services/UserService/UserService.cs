using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace CVLookup_WebAPI.Services.UserService
{
	public class UserService : IUserService
	{
		private readonly AppDBContext _dbContext;

		public UserService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<UserVM> Add(UserVM user)
		{
			throw new NotImplementedException();
		}

		public Task<UserVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<UserVM> GetAccountByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public Task<UserVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<UserVM> Update(string Id, UserVM newUser)
		{
			throw new NotImplementedException();
		}

		public Task<List<UserVM>> UserList()
		{
			throw new NotImplementedException();
		}
	}
}
