using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.JobFormService
{
    public interface IJobFormService
    {
        public Task<List<JobFormVM>> JobFormList();
		public Task<JobFormVM> GetAccountById(int id);
        public Task<JobFormVM> Add(JobFormVM jobForm);
        public Task<JobFormVM> Update(string Id, JobFormVM newJobForm);
        public Task<JobFormVM> Delete(string Id);
    }
}
