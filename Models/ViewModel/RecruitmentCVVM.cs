namespace CVLookup_WebAPI.Models.ViewModel
{
	public class RecruitmentCVVM
	{
		public RecruitmentVM Recruitment { get; set; }
		public CurriculumVitaeVM CurriculumVitae { get; set; }
		public string RecruitmentId { get; set; }
		public string CurriculumVitaeId { get; set; }
	}
}
