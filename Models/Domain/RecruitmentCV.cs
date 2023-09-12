namespace CVLookup_WebAPI.Models.Domain
{
	public class RecruitmentCV
	{
		public Recruitment Recruitment { get; set; }
		public CurriculumVitae CurriculumVitae { get; set; }
		public string RecruitmentId { get; set; }
		public string CurriculumVitaeId { get; set; }
	}
}
