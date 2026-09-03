using System.Collections.Generic;
using TableTool;

public class HalloweenShopItemData
{
	private HalloweenShopItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int Position => 0;

	public int LeftCount => 0;

	public int AllCount => 0;

	public int Discount => 0;

	public bool IsDailyReset => false;

	public bool IsAdvertising => false;

	public bool IsReachShowCond => false;

	public string ProductID => null;

	public List<Drop_DropModel.DropData> Rewards => null;

	public static HalloweenShopItemData Create(HalloweenShopItemConfigData configData)
	{
		return null;
	}

	public void UpdateBuyData(int haveBuyCount)
	{
	}

	public void AddBuyCount(int buyCount)
	{
	}

	public void PassDay()
	{
	}
}
