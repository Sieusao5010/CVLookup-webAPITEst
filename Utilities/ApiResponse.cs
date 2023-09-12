namespace CVLookup_WebAPI.Utilities
{
	public class ApiResponse
	{
		public bool Success { get; set; }
		public int Code { get; set; }
		public object Data { get; set; }
		public object Message { get; set; }
	}
}
