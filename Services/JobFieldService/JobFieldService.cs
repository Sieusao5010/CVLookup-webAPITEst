using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.JobFieldService
{
	public class JobFieldService : IJobFieldService
	{
		private readonly AppDBContext _dbContext;

		public JobFieldService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<JobFieldVM> Add(JobFieldVM jobField)
		{
			throw new NotImplementedException();
		}

		public Task<JobFieldVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<JobFieldVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<JobFieldVM>> JobFieldList()
		{
			throw new NotImplementedException();
		}

		public Task<JobFieldVM> Update(string Id, JobFieldVM newJobField)
		{
			throw new NotImplementedException();
		}
	}
}
