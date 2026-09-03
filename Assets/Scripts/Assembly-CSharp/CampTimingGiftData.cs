using System.Collections.Generic;
using XLua;

public class CampTimingGiftData : RecycleData<CampTimingGiftConfigData>
{
	private static DelegateBridge __Hotfix0_get_IsOpen;

	private static DelegateBridge __Hotfix0_get_GiftMaxCount;

	private static DelegateBridge __Hotfix0_get_GiftMinCount;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_ItemData;

	private static DelegateBridge __Hotfix0_get_ExistCanBuyGift;

	private static DelegateBridge __Hotfix0_get_CanBuyItemData;

	private static DelegateBridge __Hotfix0_ShowOpen;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateAllData;

	private static DelegateBridge __Hotfix0_GetItemData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsOpen => false;

	public int GiftMaxCount => 0;

	public int GiftMinCount => 0;

	public long LeftTime => 0L;

	public List<CampTimingGiftItemData> ItemData => null;

	public bool ExistCanBuyGift => false;

	public List<CampTimingGiftItemData> CanBuyItemData => null;

	private bool ShowOpen()
	{
		return false;
	}

	public void AddBuyCount(int id, int count)
	{
	}

	public void UpdateAllData(List<CampGiftBuyItemConfigData> data)
	{
	}

	private List<CampTimingGiftItemData> GetItemData()
	{
		return null;
	}
}
