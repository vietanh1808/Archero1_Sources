using System.Collections.Generic;
using XLua;

public class FishingShopItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_IsUnlock;

	private static DelegateBridge __Hotfix0_get_UnlockWeight;

	private static DelegateBridge __Hotfix0_get_ShopGoodsItem;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingShopItemConfigData ConfigData { get; set; }

	public bool IsUnlock => false;

	public int UnlockWeight => 0;

	public List<FishingShopGoodsItemData> ShopGoodsItem => null;

	public static FishingShopItemData Create(FishingShopItemConfigData configData)
	{
		return null;
	}
}
