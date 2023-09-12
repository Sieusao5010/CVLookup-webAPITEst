using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CVLookup_WebAPI.Models.ViewModel
{
	public class JobAddressVM
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();

		public string Address { get; set; }
	}
}
