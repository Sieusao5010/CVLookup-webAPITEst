using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CVLookup_WebAPI.Models.ViewModel
{
	public class JobFormVM
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();

		public string Form { get; set; }
	}
}
