using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.Domain
{
	public abstract class User
	{
		[Key]
		public string Id { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Email")]
		[DataType(DataType.EmailAddress, ErrorMessage = "Yêu cầu nhập đúng email")]
		[Remote(action: "UserEmailIsUsed", controller: "Validation")]
		public string Email { get; set; }

		[Display(Name = "Số điện thoại")]
		[DataType(DataType.PhoneNumber, ErrorMessage = "Yêu cầu nhập đúng số điện thoại")]
		public string PhoneNumber { get; set; }

		[Display(Name = "Ảnh đại diện")]
		public string Avatar { get; set; }

	}
}
