using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.Domain
{
	public class UserRole
	{
		public Role Role { get; set; }
		public User User { get; set; }
		public string RoleId { get; set; }
		public string UserId { get; set; }
	}
}
