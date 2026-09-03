using System.Collections.Generic;
using XLua;

public class FishingShopData : RecycleData<FishingShopConfigData>
{
	private static DelegateBridge __Hotfix0_CurrencyItem;

	private static DelegateBridge __Hotfix0_ItemData;

	private static DelegateBridge __Hotfix0_get_ShopItemAData;

	private static DelegateBridge __Hotfix0_get_ShopItemBData;

	private static DelegateBridge __Hotfix0_GetCurrencyItem;

	private static DelegateBridge __Hotfix0_ResetBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public List<FishingShopItemData> ShopItemAData => null;

	public List<FishingShopItemData> ShopItemBData => null;

	public List<FishingShopCurrencyItemData> CurrencyItem(int index)
	{
		return null;
	}

	public List<FishingShopItemData> ItemData(int index)
	{
		return null;
	}

	private List<FishingShopCurrencyItemData> GetCurrencyItem(int index)
	{
		return null;
	}

	public void ResetBuyCount()
	{
	}
}
