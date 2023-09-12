using CVLookup_WebAPI.Models.ViewModel;
using FirstWebApi.Models.Database;

namespace CVLookup_WebAPI.Services.RecruitmentService
{
	public class RecruitmentService : IRecruitmentService
	{
		private readonly AppDBContext _dbContext;

		public RecruitmentService(AppDBContext dbContext)
		{
			_dbContext = dbContext;
		}

		public Task<RecruitmentVM> Add(RecruitmentVM recruitment)
		{
			throw new NotImplementedException();
		}

		public Task<RecruitmentVM> Delete(string Id)
		{
			throw new NotImplementedException();
		}

		public Task<RecruitmentVM> GetAccountById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<List<RecruitmentVM>> RecruitmentList()
		{
			throw new NotImplementedException();
		}

		public Task<RecruitmentVM> Update(string Id, RecruitmentVM newRecruitment)
		{
			throw new NotImplementedException();
		}
	}
}
