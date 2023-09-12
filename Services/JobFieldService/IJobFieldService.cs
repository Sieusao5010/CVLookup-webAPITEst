using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.JobFieldService
{
    public interface IJobFieldService
    {
        public Task<List<JobFieldVM>> JobFieldList();
		public Task<JobFieldVM> GetAccountById(int id);
        public Task<JobFieldVM> Add(JobFieldVM jobField);
        public Task<JobFieldVM> Update(string Id, JobFieldVM newJobField);
        public Task<JobFieldVM> Delete(string Id);
    }
}
