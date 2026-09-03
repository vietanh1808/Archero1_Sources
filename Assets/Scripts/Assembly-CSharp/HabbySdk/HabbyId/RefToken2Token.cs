namespace HabbySdk.HabbyId
{
	public class RefToken2Token
	{
		public class Data
		{
			public string accessToken { get; set; }
		}

		public class Root
		{
			public int code { get; set; }

			public string message { get; set; }

			public Data data { get; set; }
		}
	}
}
