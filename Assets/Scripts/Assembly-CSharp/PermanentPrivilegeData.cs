using System.Collections.Generic;
using TableTool;

public class PermanentPrivilegeData : RecycleData<PermanentPrivilegeConfigData>
{
	private PrivilegeConfig Config => null;

	public bool IsOpen => false;

	public long StartTime => 0L;

	public long EndTime => 0L;

	public bool IsActive => false;

	public string ProductID => null;

	public int DiamondNum => 0;

	public List<Drop_DropModel.DropData> RewardData => null;

	public List<PrivilegeItemData> ItemData => null;

	public void SyncActiveStatus(bool isActive)
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
