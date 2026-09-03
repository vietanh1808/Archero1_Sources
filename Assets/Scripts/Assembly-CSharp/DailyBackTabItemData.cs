using System.Collections.Generic;

public class DailyBackTabItemData
{
	private DailyBackTabItemConfigData DailyBackTabItemConfigData { get; set; }

	public long Date => 0L;

	public int Day => 0;

	public List<DailyBackRewardItemData> RewardItemData => null;

	public static DailyBackTabItemData Create(DailyBackTabItemConfigData dailyBackTabConfigData)
	{
		return null;
	}

	private List<DailyBackRewardItemData> GetRewardItemData()
	{
		return null;
	}
}
