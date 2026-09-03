using System;
using Habby.Net.Requests;

namespace Habby.Model
{
	[Serializable]
	public class ClientData
	{
		public enum kSupportedLanguages
		{

		}

		public string appVersion;

		public string osVersion;

		public string appLanguage;

		public string systemLanguage;

		public string appBundle;

		public string deviceModel;

		public string advertisementId;

		public string tgaDistinctId;

		public string tgaDeviceId;

		public string protocolVersion;

		public OSEnum os;
	}
}
