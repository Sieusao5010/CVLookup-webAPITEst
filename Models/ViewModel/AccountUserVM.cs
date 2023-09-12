namespace CVLookup_WebAPI.Models.ViewModel
{
	public class AccountUserVM
	{
		public UserVM User { get; set; }
		public AccountVM Account { get; set; }
		public string AccountID { get; set; }
		public string UserId { get; set; }
	}
}
