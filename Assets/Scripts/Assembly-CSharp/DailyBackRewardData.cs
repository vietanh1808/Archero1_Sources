using System.Collections.Generic;

public class DailyBackRewardData
{
	private DailyBackRewardConfigData DailyBackRewardConfigData { get; set; }

	public List<DailyBackTabItemData> TabItemData => null;

	public List<DailyBackRewardItemData> AllRewardData => null;

	public void SyncRemoteData(DailyBackRewardConfigData dailyBackRewardConfigData)
	{
	}

	public void Clear()
	{
	}

	public void UpdateProgress(int rewardID, int day, int backCount)
	{
	}

	public void UpdateProgress(int rewardID, int backCount)
	{
	}

	public bool HaveData()
	{
		return false;
	}

	private List<DailyBackTabItemData> GetTabItemData()
	{
		return null;
	}

	private List<DailyBackRewardItemData> GetAllRewardItemData()
	{
		return null;
	}
}
