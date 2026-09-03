using System;

namespace Habby.Net.Responses
{
	[Serializable]
	public class AppUpgradeResponse : Response
	{
		public static int CODE_SUCCESS;

		public static int CODE_FAIL;

		public UpgradeData data;

		public bool ShouldUpgrade()
		{
			return false;
		}
	}
}
