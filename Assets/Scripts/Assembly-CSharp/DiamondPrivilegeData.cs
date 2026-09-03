using System.Collections.Generic;
using TableTool;

public class DiamondPrivilegeData : RecycleData<DiamondPrivilegeConfigData>
{
	private PrivilegeConfig Config => null;

	public bool IsOpen => false;

	public long StartTime => 0L;

	public long EndTime => 0L;

	public bool IsActive => false;

	public string ProductID => null;

	public int DiamondNum => 0;

	public bool IsDailyRewardGot => false;

	public int GotTimes => 0;

	public List<Drop_DropModel.DropData> RewardData => null;

	public List<Drop_DropModel.DropData> DailyRewardData => null;

	public List<PrivilegeItemData> ItemData => null;

	public void SyncActiveStatus(bool isActive, bool isDailyRewardGot)
	{
	}

	public void SyncGotTimes(int times)
	{
	}

	private List<PrivilegeItemData> GetItemData()
	{
		return null;
	}

	public override void Clear()
	{
	}
}
