using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.ExperienceService
{
	public class ExperienceService : IExperienceService
	{
		private readonly AppDBContext _dbContext;

		public ExperienceService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<ExperienceVM> Add(ExperienceVM experience)
		{
			throw new NotImplementedException();
		}

		public Task<ExperienceVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<List<ExperienceVM>> ExperienceList()
		{
			throw new NotImplementedException();
		}

		public Task<ExperienceVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<ExperienceVM> Update(string Id, ExperienceVM newExperience)
		{
			throw new NotImplementedException();
		}
	}
}
