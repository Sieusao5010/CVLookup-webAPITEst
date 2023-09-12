using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.JobPositionService
{
	public class JobPositionService : IJobPositionService
	{
		private readonly AppDBContext _dbContext;

		public JobPositionService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<JobPositionVM> Add(JobPositionVM jobPosition)
		{
			throw new NotImplementedException();
		}

		public Task<JobPositionVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<JobPositionVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<JobPositionVM>> JobPositionList()
		{
			throw new NotImplementedException();
		}

		public Task<JobPositionVM> Update(string Id, JobPositionVM newJobPosition)
		{
			throw new NotImplementedException();
		}
	}
}
