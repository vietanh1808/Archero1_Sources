using System;

public class DailyBackRewardButtonItemConfigData
{
	public int rewardID;

	public string needCond;

	public Func<int> leftCount;

	public int day;

	public static DailyBackRewardButtonItemConfigData Create(int rewardID, Func<int> leftCount, int day, string needCond)
	{
		return null;
	}
}
