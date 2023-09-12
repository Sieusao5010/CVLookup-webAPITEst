using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.CurriculumService
{
    public interface ICurriculumViateService
    {
        public Task<List<CurriculumVitaeVM>> CurriculumVitaeList();
		public Task<CurriculumVitaeVM> GetAccountById(int id);
        public Task<CurriculumVitaeVM> Add(CurriculumVitaeVM curriculumVitae);
        public Task<CurriculumVitaeVM> Update(string Id, CurriculumVitaeVM newCurriculumVitae);
        public Task<CurriculumVitaeVM> Delete(string Id);
    }
}
