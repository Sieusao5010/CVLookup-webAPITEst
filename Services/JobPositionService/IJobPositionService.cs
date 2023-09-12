using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.JobPositionService
{
    public interface IJobPositionService
    {
        public Task<List<JobPositionVM>> JobPositionList();
		public Task<JobPositionVM> GetAccountById(int id);
        public Task<JobPositionVM> Add(JobPositionVM jobPosition);
        public Task<JobPositionVM> Update(string Id, JobPositionVM newJobPosition);
        public Task<JobPositionVM> Delete(string Id);
    }
}
