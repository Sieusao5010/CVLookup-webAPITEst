using AutoMapper;
using CVLookup_WebAPI.Models.Domain;
using CVLookup_WebAPI.Models.ViewModel;

namespace CVLookup_WebAPI.Models.Mapper
{
	public class MappingProflie : Profile
	{
		public MappingProflie()
		{
			CreateMap<Account, AccountVM>().ReverseMap();
			CreateMap<User, UserVM>().ReverseMap();
			CreateMap<JobAddress, JobAddressVM>().ReverseMap();
			CreateMap<JobField, JobFieldVM>().ReverseMap();
			CreateMap<JobCareer, JobCareerVM>().ReverseMap();
			CreateMap<JobPosition, JobPositionVM>().ReverseMap();
			CreateMap<Employer, EmployerVM>().ReverseMap();
			CreateMap<Candidate, CandidateVM>().ReverseMap();
			CreateMap<Recruitment, RecruitmentVM>().ReverseMap();
			CreateMap<CurriculumVitae, CurriculumVitaeVM>().ReverseMap();
			CreateMap<Role, RoleVM>().ReverseMap();
			CreateMap<JobForm, JobFormVM>().ReverseMap();
			CreateMap<JobAddress, JobAddressVM>().ReverseMap();
		}
	}
}
