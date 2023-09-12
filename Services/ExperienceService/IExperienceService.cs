using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.ExperienceService
{
    public interface IExperienceService
    {
        public Task<List<ExperienceVM>> ExperienceList();
		public Task<ExperienceVM> GetAccountById(int id);
        public Task<ExperienceVM> Add(ExperienceVM experience);
        public Task<ExperienceVM> Update(string Id, ExperienceVM newExperience);
        public Task<ExperienceVM> Delete(string Id);

    }
}
