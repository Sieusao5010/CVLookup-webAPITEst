using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CVLookup_WebAPI.Models.ViewModel
{
	public class JobCareerVM
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();

		public string Career { get; set; }
	}
}
