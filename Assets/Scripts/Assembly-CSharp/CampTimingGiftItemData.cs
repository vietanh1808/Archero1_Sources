using System.Collections.Generic;
using TableTool;
using XLua;

public class CampTimingGiftItemData
{
	private static DelegateBridge __Hotfix0_get_Config;

	private static DelegateBridge __Hotfix0_set_Config;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_ProductID;

	private static DelegateBridge __Hotfix0_get_Price;

	private static DelegateBridge __Hotfix0_get_Discount;

	private static DelegateBridge __Hotfix0_get_LeftCount;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_IsClaimedAll;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTimingGiftItemConfigData Config { get; set; }

	public int ID => 0;

	public string ProductID => null;

	public string Price => null;

	public int Discount => 0;

	public int LeftCount => 0;

	public long LeftTime => 0L;

	public bool IsClaimedAll => false;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static CampTimingGiftItemData Create(CampTimingGiftItemConfigData config)
	{
		return null;
	}

	public void AddBuyCount(int count)
	{
	}

	public void UpdateData(int count, long activeTime)
	{
	}
}
