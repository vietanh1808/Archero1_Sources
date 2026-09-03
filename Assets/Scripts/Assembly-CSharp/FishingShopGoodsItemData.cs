using System.Collections.Generic;
using TableTool;
using XLua;

public class FishingShopGoodsItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_RewardID;

	private static DelegateBridge __Hotfix0_get_NeedFishingWeight;

	private static DelegateBridge __Hotfix0_get_LeftBuyCount;

	private static DelegateBridge __Hotfix0_get_IsUnlock;

	private static DelegateBridge __Hotfix0_get_Discount;

	private static DelegateBridge __Hotfix0_get_Position;

	private static DelegateBridge __Hotfix0_get_NeedItem;

	private static DelegateBridge __Hotfix0_get_Reward;

	private static DelegateBridge __Hotfix0_get_HaveEnoughCurrency;

	private static DelegateBridge __Hotfix0_get_IsDailyReset;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_ResetBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingShopGoodsItemConfigData ConfigData { get; set; }

	public int RewardID => 0;

	public int NeedFishingWeight => 0;

	public int LeftBuyCount => 0;

	public bool IsUnlock => false;

	public int Discount => 0;

	public int Position => 0;

	public Drop_DropModel.DropData NeedItem => null;

	public List<Drop_DropModel.DropData> Reward => null;

	public bool HaveEnoughCurrency => false;

	public bool IsDailyReset => false;

	public static FishingShopGoodsItemData Create(FishingShopGoodsItemConfigData configData)
	{
		return null;
	}

	public void AddBuyCount(int count)
	{
	}

	public void ResetBuyCount()
	{
	}
}
