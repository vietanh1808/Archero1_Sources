using System;

namespace Habby.Model
{
	[Serializable]
	public class GiftcodeClientData : ClientData
	{
		public string deviceId;

		public string socialId;

		public GiftcodeClientData(ClientData clientData)
		{
		}
	}
}
