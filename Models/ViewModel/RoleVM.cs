using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.ViewModel
{
    public class RoleVM
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

		public string RoleName { get; set; }
    }
}
