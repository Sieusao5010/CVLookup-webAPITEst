using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.RecruitmentCVService
{
    public interface IRecruitmentCVService
    {
        public Task<List<RecruitmentCVVM>> RecruitmentCVList();
		public Task<RecruitmentCVVM> GetAccountById(int id);
        public Task<RecruitmentCVVM> Add(RecruitmentCVVM recruitmentCV);
        public Task<RecruitmentCVVM> Update(string Id, RecruitmentCVVM newRecruitmentCV);
        public Task<RecruitmentCVVM> Delete(string Id);
    }
}
