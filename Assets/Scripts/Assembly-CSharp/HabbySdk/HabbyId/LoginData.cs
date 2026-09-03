namespace HabbySdk.HabbyId
{
	public class LoginData
	{
		public class Data
		{
			public string refreshToken { get; set; }

			public string accessToken { get; set; }

			public string authCode { get; set; }

			public string habbyId { get; set; }
		}

		public class Root
		{
			public int code { get; set; }

			public string message { get; set; }

			public Data data { get; set; }
		}
	}
}
