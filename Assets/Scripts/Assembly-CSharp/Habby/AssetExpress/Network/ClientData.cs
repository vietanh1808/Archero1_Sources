using System;

namespace Habby.AssetExpress.Network
{
	[Serializable]
	public struct ClientData
	{
		public string appVersion;

		public string osVersion;

		public string appLanguage;

		public string systemLanguage;

		public string appBundle;

		public string deviceModel;

		public string deviceId;

		public static ClientData Create()
		{
			return default;
		}
	}
}
