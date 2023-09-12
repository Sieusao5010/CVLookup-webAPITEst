using System.ComponentModel.DataAnnotations;

namespace CVLookup_WebAPI.Models.Domain
{
	public class Recruitment
	{
		[Key]
		public string Id { get; set; }

		public User User { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Tiêu đề")]
		[StringLength(100, MinimumLength = 10, ErrorMessage = "{0} phải từ {2} đến {1} kí tự")]
		public string JobTitle { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		public string Salary { get; set; }

		public JobAddress JobAddress { get; set; }
		public JobCareer JobCareer { get; set; }
		public JobField JobField { get; set; }
		public JobForm JobForm { get; set; }
		public Experience Experience { get; set; }
		public JobPosition JobPosition { get; set; }

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Thời hạn ứng tuyển")]
		public DateTime ApplicationDeadline { get; set; }

		[Display(Name = "Ngày tạo")]
		public DateTime CreatedAt { get; set; }

		public bool IsExpired { get; set; } = false;

		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Mô tả công việc")]
		public string JobDescription { get; set; }
		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Yêu cẩu ứng viên")]
		public string JobRequirement { get; set; }
		[Required(ErrorMessage = "{0} không được để trống")]
		[Display(Name = "Phúc lợi")]
		public string Benefit { get; set; }
	}
}
