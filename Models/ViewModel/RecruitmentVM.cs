using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.ViewModel
{
	public class RecruitmentVM
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();

		public UserVM User { get; set; }

		public string JobTitle { get; set; }

		public string Salary { get; set; }

		public JobAddressVM JobAddress { get; set; }
		public JobCareerVM JobCareer { get; set; }
		public JobFieldVM JobField { get; set; }
		public JobFormVM JobForm { get; set; }
		public ExperienceVM Experience { get; set; }
		public JobPositionVM JobPosition { get; set; }

		public DateTime ApplicationDeadline { get; set; }

		public DateTime CreatedAt { get; set; }

		public bool IsExpired { get; set; } = false;

		public string JobDescription { get; set; }
		
		public string JobRequirement { get; set; }
		
		public string Benefit { get; set; }
	}
}
