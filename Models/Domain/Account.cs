using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace CVLookup_WebAPI.Models.Domain
{
    public class Account
    {

        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "{0} không được để trống")]
        [Display(Name = "Mật khẩu")]
        [MinLength(8, ErrorMessage = "{0} phải có từ {1} kí tự trở lên")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} không được để trống")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Yêu cầu nhập đúng email")]
        [Remote(action: "AccountEmailIsUsed", controller: "Account")]
        public string Email { get; set; }

        [Display(Name = "Trạng thái tài khoản")]
        public bool Status { get; set; } = false;

        [Display(Name = "Ngày tạo")]
        public DateTime IssuedAt { get; set; }

        [Display(Name = "Ngày kích hoạt tài khoản")]
        public DateTime ActivedAt { get; set; }

        [Display(Name = "Ngày cập nhật")]
        public DateTime UpdatedAt { get; set; }
		
	}
}
