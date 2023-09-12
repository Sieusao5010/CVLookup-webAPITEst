using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.ViewModel
{
	public class ExperienceVM
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();

		public string Exp { get; set; }
	}
}
