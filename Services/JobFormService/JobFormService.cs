using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.JobFormService
{
	public class JobFormService : IJobFormService
	{
		private readonly AppDBContext _dbContext;

		public JobFormService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<JobFormVM> Add(JobFormVM jobForm)
		{
			throw new NotImplementedException();
		}

		public Task<JobFormVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<JobFormVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<JobFormVM>> JobFormList()
		{
			throw new NotImplementedException();
		}

		public Task<JobFormVM> Update(string Id, JobFormVM newJobForm)
		{
			throw new NotImplementedException();
		}
	}
}
