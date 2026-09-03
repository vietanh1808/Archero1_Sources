using System.Collections.Generic;
using TableTool;

public class DailyBackRewardItemData
{
	private DailyBackRewardItemConfigData DailyBackRewardItemConfigData { get; set; }

	public int RewardID => 0;

	public int LeftCount => 0;

	public List<Drop_DropModel.DropData> ShowRewardData => null;

	public List<DailyBackRewardButtonItemData> RewardButtonData => null;

	public int Day => 0;

	public static DailyBackRewardItemData Create(DailyBackRewardItemConfigData dailyBackRewardItemConfigData)
	{
		return null;
	}

	private List<Drop_DropModel.DropData> GetRewardData(string[] rewards)
	{
		return null;
	}

	private List<DailyBackRewardButtonItemData> GetButtonData(string[] buttonData)
	{
		return null;
	}

	private List<string> GetRewardDataStr(int[][] rewards)
	{
		return null;
	}

	public void AddLeftCount(int leftCount)
	{
	}
}
