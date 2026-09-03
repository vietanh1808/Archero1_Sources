using TableTool;

public class DailyBackRewardButtonItemData
{
	private DailyBackRewardButtonItemConfigData ButtonConfigData { get; set; }

	public int RewardID => 0;

	public Drop_DropModel.DropData CondData => null;

	public bool CanGetReward => false;

	public int LeftCount => 0;

	public string GetBackPercent => null;

	public int Day => 0;

	public int BackType => 0;

	public static DailyBackRewardButtonItemData Create(DailyBackRewardButtonItemConfigData buttonConfigData)
	{
		return null;
	}

	private Drop_DropModel.DropData GetCondData(string rewards)
	{
		return null;
	}

	private string GetPercent()
	{
		return null;
	}

	private int GetBackType()
	{
		return 0;
	}
}
