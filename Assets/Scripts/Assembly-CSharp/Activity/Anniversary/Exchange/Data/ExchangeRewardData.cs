using System.Collections.Generic;

namespace Activity.Anniversary.Exchange.Data
{
	public class ExchangeRewardData
	{
		private ExchangeRewardConfigData RewardConfigData { get; set; }

		public List<ExchangeRewardItemData> RewardItemData => null;

		public int RewardProgress => 0;

		public bool HaveData => false;

		public bool IsReachMaxProgress => false;

		public int NormalRewardCount => 0;

		public void SyncRemoteData(ExchangeRewardConfigData rewardConfigData)
		{
		}

		public void UpdateProgress(int rewardID, int leftGetCount)
		{
		}

		private List<ExchangeRewardItemData> GetRewardItemData()
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
