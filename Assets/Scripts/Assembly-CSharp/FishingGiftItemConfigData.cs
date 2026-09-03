using System;
using Newtonsoft.Json;
using XLua;

[Serializable]
public class FishingGiftItemConfigData
{
	public int ID;

	public string Price;

	public int Discount;

	[JsonIgnore]
	public int haveBuyCount;

	public int Quota;

	public int ShowCond;

	public int DailyReset;

	public int[][] Rewards;

	public int Position;

	private static DelegateBridge __Hotfix0_AddBuyCount;

	private static DelegateBridge __Hotfix0_UpdateBuyCount;

	private static DelegateBridge __Hotfix0_ResetBuyCount;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void AddBuyCount()
	{
	}

	public void UpdateBuyCount(int buyCount)
	{
	}

	public void ResetBuyCount()
	{
	}
}
