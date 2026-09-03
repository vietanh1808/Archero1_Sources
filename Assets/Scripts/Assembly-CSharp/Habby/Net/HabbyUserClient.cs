using System;
using Habby.AssetExpress.Util;
using Habby.Net.Responses;

namespace Habby.Net
{
	public class HabbyUserClient : SingletonScript<HabbyUserClient>
	{
		private const string CLOUD_CONFIG = "cloudconfig";

		public override void Awake()
		{
		}

		public void ReqCloudData(ulong userId, Action<CloudConfigResponse> response, Action<string> error)
		{
		}
	}
}
