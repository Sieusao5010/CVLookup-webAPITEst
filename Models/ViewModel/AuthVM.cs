namespace CVLookup_WebAPI.Models.ViewModel
{
	public class AuthVM
	{
		public string UserId { get; set; } = Guid.NewGuid().ToString();
		public string AccountId { get; set; }
		public string RoleId { get; set; }
		public string AccessToken { get; set; }
		public string RefreshToken { get; set; }
	}
}
