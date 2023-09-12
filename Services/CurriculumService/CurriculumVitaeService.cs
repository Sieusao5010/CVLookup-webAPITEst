using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.CurriculumService
{
	public class CurriculumVitaeService : ICurriculumViateService
	{
		private AppDBContext _dbContext;

		public CurriculumVitaeService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<CurriculumVitaeVM> Add(CurriculumVitaeVM curriculumVitae)
		{
			throw new NotImplementedException();
		}

		public Task<List<CurriculumVitaeVM>> CurriculumVitaeList()
		{
			throw new NotImplementedException();
		}

		public Task<CurriculumVitaeVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<CurriculumVitaeVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<CurriculumVitaeVM> Update(string Id, CurriculumVitaeVM newCurriculumVitae)
		{
			throw new NotImplementedException();
		}
	}
}
