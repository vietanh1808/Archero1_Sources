using System.Collections.Generic;
using XLua;

public class CampNormalGiftData : RecycleData<CampNormalGiftConfigData>
{
	private static DelegateBridge __Hotfix0_get_CampGiftType;

	private static DelegateBridge __Hotfix0_get_LeftTime;

	private static DelegateBridge __Hotfix0_get_ItemData;

	private static DelegateBridge __Hotfix0_get_ExistCanBuyGift;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateData;

	private static DelegateBridge __Hotfix0_UpdateAllData;

	private static DelegateBridge __Hotfix0_ResetDailyBuyCount;

	private static DelegateBridge __Hotfix0_GetItemData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public CampGiftType CampGiftType => CampGiftType.None;

	public long LeftTime => 0L;

	public List<CampNormalGiftItemData> ItemData => null;

	public bool ExistCanBuyGift => false;

	public void AddBuyCount(int id, int count)
	{
	}

	public void UpdateData(int id, int buyCount)
	{
	}

	public void UpdateAllData(Dictionary<string, int> data)
	{
	}

	public void ResetDailyBuyCount()
	{
	}

	private List<CampNormalGiftItemData> GetItemData()
	{
		return null;
	}
}
