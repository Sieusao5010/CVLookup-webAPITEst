using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.JobCareerService
{
	public class JobCareerService : IJobCareerService
	{
		private readonly AppDBContext _dbContext;

		public JobCareerService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<JobCareerVM> Add(JobCareerVM jobCareer)
		{
			throw new NotImplementedException();
		}

		public Task<JobCareerVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<JobCareerVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<JobCareerVM>> JobCareerList()
		{
			throw new NotImplementedException();
		}

		public Task<JobCareerVM> Update(string Id, JobCareerVM newJobCareer)
		{
			throw new NotImplementedException();
		}
	}
}
