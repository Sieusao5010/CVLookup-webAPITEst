using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.EmployerService
{
	public class EmployerService : IEmployerService
	{
		private readonly AppDBContext _dbContext;

		public EmployerService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<EmployerVM> Add(EmployerVM employer)
		{
			throw new NotImplementedException();
		}

		public Task<EmployerVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<List<EmployerVM>> EmployerList()
		{
			throw new NotImplementedException();
		}

		public Task<EmployerVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<EmployerVM> Update(string Id, EmployerVM newEmployer)
		{
			throw new NotImplementedException();
		}
	}
}
