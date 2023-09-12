namespace CVLookup_WebAPI.Models.Domain
{
	public class AccountUser
	{
		public User User { get; set; }
		public Account Account { get; set; }
		public string AccountID { get; set; }
		public string UserId { get; set; }
	}
}
