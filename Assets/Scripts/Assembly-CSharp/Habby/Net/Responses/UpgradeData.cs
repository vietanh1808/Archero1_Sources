using System;

namespace Habby.Net.Responses
{
	[Serializable]
	public class UpgradeData
	{
		public bool isForce;

		public string upgradeURI;

		public string appVersion;

		public string upgradeDesc;
	}
}
