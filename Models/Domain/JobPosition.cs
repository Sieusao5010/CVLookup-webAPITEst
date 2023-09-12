using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CVLookup_WebAPI.Models.Domain
{
	public class JobPosition
	{
		[Key]
		public string Id { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Vị trí công việc")]
		public string Position { get; set; }
	}
}
