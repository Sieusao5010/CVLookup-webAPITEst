using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.ViewModel
{
	public class UserRoleVM
	{
		public RoleVM Role { get; set; }
		public UserVM User { get; set; }
		public string RoleId { get; set; }
		public string UserId { get; set; }
	}
}
