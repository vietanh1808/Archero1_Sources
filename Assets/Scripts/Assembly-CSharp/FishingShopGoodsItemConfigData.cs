using System.Collections.Generic;
using TableTool;
using XLua;

public class FishingShopGoodsItemConfigData
{
	public int id;

	public int pos;

	public int discount;

	public int unlockWeight;

	public int leftBuyCount;

	public int maxBuyCount;

	public int isDailyReset;

	public Drop_DropModel.DropData needItem;

	public List<Drop_DropModel.DropData> targetItem;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_ResetBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static FishingShopGoodsItemConfigData Create(int id, int pos, int isDailyReset, int discount, int unlockWeight, int leftBuyCount, int maxBuyCount, Drop_DropModel.DropData needItem, List<Drop_DropModel.DropData> targetItem)
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
