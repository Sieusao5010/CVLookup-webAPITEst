using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.RecruitmentService
{
    public interface IRecruitmentService
    {
        public Task<List<RecruitmentVM>> RecruitmentList();
		public Task<RecruitmentVM> GetAccountById(int id);
        public Task<RecruitmentVM> Add(RecruitmentVM recruitment);
        public Task<RecruitmentVM> Update(string Id, RecruitmentVM newRecruitment);
        public Task<RecruitmentVM> Delete(string Id);
    }
}
