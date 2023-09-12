namespace CVLookup_WebAPI.Utilities
{
	public class ExceptionReturn : Exception
	{
		public int Code { get; set; }
		public string Message { get; set; }

		public ExceptionReturn(int code, string message)
		{
			Code = code;
			Message = message;
		}
	}
}
