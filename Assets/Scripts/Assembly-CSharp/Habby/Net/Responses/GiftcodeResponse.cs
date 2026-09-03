using System;

namespace Habby.Net.Responses
{
	[Serializable]
	public class GiftcodeResponse : Response
	{
		public const int CODE_SUCCESS = 0;

		public const int CODE_INVALID_ARGS = 20001;
	}
}
