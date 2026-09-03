using System;

namespace HabbySdk.HabbyStore
{
	[Serializable]
	public class AppStoreInfo
	{
		public string identifier;

		public string countryCode;

		public bool isAvailable;

		public string errorMessage;

		public override string ToString()
		{
			return null;
		}
	}
}
