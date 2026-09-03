using System;

namespace Habby.Net.Requests
{
	[Serializable]
	public class AppUpgradeRequest : Request
	{
		public string appVersion;

		public string appLanguage;
	}
}
