using System.Collections.Generic;
using XLua;

public class LuckyWheelRewardData : RecycleData<LuckyWheelRewardConfigData>
{
	private static DelegateBridge __Hotfix0_get_SuperRewardPosition;

	private static DelegateBridge __Hotfix0_get_ItemData;

	private static DelegateBridge __Hotfix0_GetItemData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int SuperRewardPosition => 0;

	public List<LuckyWheelRewardItemData> ItemData => null;

	private List<LuckyWheelRewardItemData> GetItemData()
	{
		return null;
	}
}
