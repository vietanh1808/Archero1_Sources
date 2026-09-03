using System.Collections.Generic;
using TableTool;

public class SkyScraperRewardItemData : ViewCellData
{
	public enum RewardStatus
	{
		None = 0,
		UnComplete = 1,
		Complete = 2,
		Claimed = 3
	}

	private SkyScraperMgr.SkyScraperAchievementConfig mConfig;

	public int level;

	public int Preview;

	public int PicBag;

	public List<Drop_DropModel.DropData> Rewards;

	public int ID => 0;

	public long NeedProgress => 0L;

	public RewardStatus Status => RewardStatus.None;

	public SkyScraperRewardItemData(SkyScraperMgr.SkyScraperAchievementConfig config, int level)
	{
	}
}
