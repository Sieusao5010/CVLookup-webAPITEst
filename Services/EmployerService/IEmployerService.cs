using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Services.EmployerService
{
    public interface IEmployerService
    {
        public Task<List<EmployerVM>> EmployerList();
		public Task<EmployerVM> GetAccountById(int id);
        public Task<EmployerVM> Add(EmployerVM employer);
        public Task<EmployerVM> Update(string Id, EmployerVM newEmployer);
        public Task<EmployerVM> Delete(string Id);
    }
}
