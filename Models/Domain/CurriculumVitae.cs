using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.Domain
{
	public class CurriculumVitae
	{
		[Key]
		public string Id { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Họ và tên")]
		public string FullName { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Số điện thoại")]
		[DataType(DataType.PhoneNumber)]
		public string PhoneNumber { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Email")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[Required(ErrorMessage = "CV không được để trống")]
		public string CVPath { get; set; }

		public string Introdution { get; set; }

		public User User { get; set; }

	}
}
