namespace Habby.Mail
{
	public class HabbyMailInitializer : HabbySDKInitializer
	{
		public class HabbyMailConfig
		{
			public string url;

			public string netVersion;

			public string storeChannel;
		}

		protected override string[] eventList => null;

		protected override void ReceiveEventMessage(string pKey, object pData)
		{
		}

		private void InitMail()
		{
		}
	}
}
