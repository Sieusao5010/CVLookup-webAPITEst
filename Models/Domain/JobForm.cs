using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CVLookup_WebAPI.Models.Domain
{
	public class JobForm
	{
		[Key]
		public string Id { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Hình thức công việc")]
		public string Form { get; set; }
	}
}
