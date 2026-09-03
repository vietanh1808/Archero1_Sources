using System.Collections.Generic;

public class HalloweenShopData : RecycleData<HalloweenShopConfigData>
{
	public long SyncDataTime => 0L;

	public List<HalloweenShopItemData> ShopItemData => null;

	public List<HalloweenShopItemData> GetShopItemData()
	{
		return null;
	}

	public void UpdateBuyData(int id, int haveBuyCount)
	{
	}

	public void UpdateAllData(Dictionary<string, int> data)
	{
	}

	public void PassDay(long passDayTime)
	{
	}
}
