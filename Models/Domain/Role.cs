using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.Domain
{
    public class Role
    {
        [Key]
        public string Id { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
        [Display(Name = "Phân quyền")]
        public string RoleName { get; set; }
    }
}
