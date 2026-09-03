using System.Collections.Generic;

public class HalloweenShopConfigData
{
	public long syncDataTime;

	public List<HalloweenShopItemConfigData> shopItemConfigData;

	public static HalloweenShopConfigData Create(long syncDataTime, List<HalloweenShopItemConfigData> shopItemConfigData)
	{
		return null;
	}

	public void UpdateSyncDataTime(long syncDataTime)
	{
	}
}
