using System.Collections.Generic;
using Newtonsoft.Json;

public class UserExtraInfo : CInstance<UserExtraInfo>
{
	private class CPurchaseRewardData
	{
		public int have_any_iap;

		public int first_iap_status;

		public long start_time;

		public int[][] rewards;

		public WatchAdData adData;

		[JsonIgnore]
		public RewardState mState;

		public bool is_start()
		{
			return false;
		}
	}

	public class WatchAdData
	{
		public int ad_open;

		public int reward_id;

		public int reward_cnt;

		public Dictionary<string, int> counts;
	}

	public bool WatchAdIsOpen;

	private CPurchaseRewardData mPurchaseRewardData;

	public void DeInit()
	{
	}

	public int[][] getFirstRewardData()
	{
		return null;
	}

	public RewardState GetPurchaseRewardState()
	{
		return RewardState.eCanReward;
	}

	public bool GetPurchaseRewardShow()
	{
		return false;
	}

	public void SetPurchaseRewardState(RewardState state)
	{
	}

	public void Purchase2Reward()
	{
	}

	public bool isHaveReward()
	{
		return false;
	}

	public WatchAdData GetWatchAdData()
	{
		return null;
	}

	public int GetCurWatchAdAllCount()
	{
		return 0;
	}

	public RewardState GetWatchAdRewardState()
	{
		return RewardState.eCanReward;
	}

	public void send_purchasereward()
	{
	}

	public void GetWatchAdReward()
	{
	}
}
