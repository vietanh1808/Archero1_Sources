using System;
using System.Collections.Generic;
using Habby.Model;

namespace Habby.Net.Responses
{
	[Serializable]
	public class MailRewardResponse : MailResponse
	{
		public const int CODE_SUCCESS = 20101;

		public const int CODE_EXPIRED = 20102;

		public const int CODE_NO_REWARD = 20103;

		public const int CODE_REPEATED = 20104;

		public List<MailReward> rewards;

		public string mailId;
	}
}
