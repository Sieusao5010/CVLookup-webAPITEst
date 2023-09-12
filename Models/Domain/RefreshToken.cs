using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.Domain
{
	public class RefreshToken
	{
		public User User { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		public string Token { get; set; }

		[Display(Name = "Ngày tạo")]
		public DateTime CreateAt { get; set; }

		[Display(Name = "Ngày hết hạn")]
		public DateTime ExpiredAt { get; set; }
	}
}
