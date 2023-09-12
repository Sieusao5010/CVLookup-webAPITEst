using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.JobCareerService
{
    public interface IJobCareerService
    {
        public Task<List<JobCareerVM>> JobCareerList();
		public Task<JobCareerVM> GetAccountById(int id);
        public Task<JobCareerVM> Add(JobCareerVM jobCareer);
        public Task<JobCareerVM> Update(string Id, JobCareerVM newJobCareer);
        public Task<JobCareerVM> Delete(string Id);
    }
}
