using System.Collections.Generic;

public class DailyBackTabItemConfigData
{
	public long time;

	public int day;

	public List<DailyBackRewardItemConfigData> rewardItem;

	public static DailyBackTabItemConfigData Create(long time, int index, List<DailyBackRewardItemConfigData> rewardItem)
	{
		return null;
	}

	public void UpdateProgress(int rewardID, int backCount)
	{
	}

	public int UpdateProgressReturnLeft(int rewardID, int backCount)
	{
		return 0;
	}
}
