using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.CandidateService
{
    public interface ICandidateService
    {
        public Task<List<CandidateVM>> CandidateList();
        public Task<CandidateVM> GetAccountById(int id);
        public Task<CandidateVM> Add(CandidateVM candidate);
        public Task<CandidateVM> Update(string Id, CandidateVM newCandidate);
        public Task<CandidateVM> Delete(string Id);
    }
}
