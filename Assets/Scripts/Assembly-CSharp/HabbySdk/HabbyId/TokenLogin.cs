namespace HabbySdk.HabbyId
{
	public class TokenLogin
	{
		public class Data
		{
			public string email { get; set; }

			public string habbyId { get; set; }

			public int gameUpdatesAndNews { get; set; }

			public int eventsAndBonus { get; set; }

			public int communityInteraction { get; set; }

			public int shopSpecialOffer { get; set; }

			public int newsForHabby { get; set; }
		}

		public class Root
		{
			public int code { get; set; }

			public string message { get; set; }

			public Data data { get; set; }
		}
	}
}
