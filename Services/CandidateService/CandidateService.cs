using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.CandidateService
{
	public class CandidateService : ICandidateService
	{
		private readonly AppDBContext _dbContext;

		public CandidateService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<CandidateVM> Add(CandidateVM candidate)
		{
			throw new NotImplementedException();
		}

		public Task<List<CandidateVM>> CandidateList()
		{
			throw new NotImplementedException();
		}

		public Task<CandidateVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<CandidateVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<CandidateVM> Update(string Id, CandidateVM newCandidate)
		{
			throw new NotImplementedException();
		}
	}
}
