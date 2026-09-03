using System.Collections.Generic;
using XLua;

public class CampShopData : RecycleData<CampShopConfigData>
{
	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_ItemData;

	private static DelegateBridge __Hotfix0_get_ItemAData;

	private static DelegateBridge __Hotfix0_get_ItemBData;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge _c__Hotfix0_ctor;

	public long LeftTime => 0L;

	private List<CampShopItemData> ItemAData => null;

	private List<CampShopItemData> ItemBData => null;

	public List<CampShopItemData> ItemData(CurrencyType type)
	{
		return null;
	}

	public void UpdateData(CurrencyType type, int id, int leftCount, int claimedCount)
	{
	}

	public override void Clear()
	{
	}
}
