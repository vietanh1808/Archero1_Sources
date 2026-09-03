using System;
using Habby.Net.Responses;

namespace Habby
{
	public class HabbyCloudConfigManager
	{
		public static HabbyCloudConfigManager Instance;

		public HabbyCloudConfigData CloudData { get; private set; }

		public bool IsOpenHabbyIM => false;

		static HabbyCloudConfigManager()
		{
		}

		public void RequestCloudConfig(ulong userId, Action<HabbyCloudConfigData> onCallback = null, int requestedCount = 0)
		{
		}
	}
}
