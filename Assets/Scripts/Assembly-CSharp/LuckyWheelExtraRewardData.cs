using System.Collections.Generic;
using XLua;

public class LuckyWheelExtraRewardData : RecycleData<LuckyWheelExtraRewardConfigData>
{
	private static DelegateBridge __Hotfix0_get_Progress;

	private static DelegateBridge __Hotfix0_get_RewardProgress;

	private static DelegateBridge __Hotfix0_get_ItemData;

	private static DelegateBridge __Hotfix0_GetItemData;

	private static DelegateBridge __Hotfix0_UpdateProgress;

	private static DelegateBridge __Hotfix0_UpdateRewardProcess;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int Progress => 0;

	public ulong RewardProgress => 0uL;

	public List<LuckyWheelExtraRewardItemData> ItemData => null;

	private List<LuckyWheelExtraRewardItemData> GetItemData()
	{
		return null;
	}

	public void UpdateProgress(int progress)
	{
	}

	public void UpdateRewardProcess(ulong claimedRewardID)
	{
	}
}
