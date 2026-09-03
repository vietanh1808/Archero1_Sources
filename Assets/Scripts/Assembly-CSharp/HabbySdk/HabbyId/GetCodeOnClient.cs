namespace HabbySdk.HabbyId
{
	public class GetCodeOnClient
	{
		public class Data
		{
			public string emailCode { get; set; }

			public string receiveEmail { get; set; }
		}

		public class Root
		{
			public int code { get; set; }

			public string message { get; set; }

			public Data data { get; set; }
		}
	}
}
