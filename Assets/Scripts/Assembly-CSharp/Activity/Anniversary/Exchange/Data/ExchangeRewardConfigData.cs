using System.Collections.Generic;

namespace Activity.Anniversary.Exchange.Data
{
	public class ExchangeRewardConfigData
	{
		public List<ExchangeRewardItemConfigData> rewardItem;

		public int progress;

		public static ExchangeRewardConfigData Create(int progress, List<ExchangeRewardItemConfigData> rewardItem)
		{
			return null;
		}

		public void UpdateProgress(int rewardID, int leftGetCount)
		{
		}
	}
}
