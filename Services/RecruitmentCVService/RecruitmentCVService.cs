using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.RecruitmentCVService
{
	public class RecruitmentCVService : IRecruitmentCVService
	{
		private readonly AppDBContext _dbContext;

		public RecruitmentCVService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<RecruitmentCVVM> Add(RecruitmentCVVM recruitmentCV)
		{
			throw new NotImplementedException();
		}

		public Task<RecruitmentCVVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<RecruitmentCVVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<RecruitmentCVVM>> RecruitmentCVList()
		{
			throw new NotImplementedException();
		}

		public Task<RecruitmentCVVM> Update(string Id, RecruitmentCVVM newRecruitmentCV)
		{
			throw new NotImplementedException();
		}
	}
}
