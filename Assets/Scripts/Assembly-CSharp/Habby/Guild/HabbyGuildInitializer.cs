namespace Habby.Guild
{
	public class HabbyGuildInitializer : HabbySDKInitializer
	{
		public class HabbyGuildConfig
		{
			public string url;

			public long IMAppID;

			public string netVersion;
		}

		protected override string[] eventList => null;

		protected override void ReceiveEventMessage(string pKey, object pData)
		{
		}

		private void InitGuild()
		{
		}
	}
}
