using System;
using Habby.Model;

namespace Habby.Net.Responses
{
	[Serializable]
	public class GiftcodeMailCreateResponse : GiftcodeResponse
	{
		public const int CODE_GIFTCODE_INVALID = 20401;

		public const int CODE_GIFTCODE_REDEEMED = 20402;

		public const int CODE_GIFTCODE_EXPIRED = 20403;

		public const int CODE_GIFTCODE_CLAIMED = 20407;

		public GiftcodeMailData data;
	}
}
