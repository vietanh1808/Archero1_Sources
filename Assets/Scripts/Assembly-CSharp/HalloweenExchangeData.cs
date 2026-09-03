using System.Collections.Generic;
using GameProtocol;

public class HalloweenExchangeData : RecycleData<HalloweenExchageConfigData>
{
	public List<HalloweenExchangeItemData> ExcItemData => null;

	private List<HalloweenExchangeItemData> GetExcItemData()
	{
		return null;
	}

	public void SyncRemoteData(STMagicExchangeData[] excConfigData)
	{
	}
}
