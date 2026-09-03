using System.Collections.Generic;
using TableTool;

public class HalloweenExchangeItemData
{
	private HalloweenExchageItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int Position => 0;

	public List<Drop_DropModel.DropData> Need => null;

	public int Count => 0;

	public List<Drop_DropModel.DropData> Reward => null;

	public bool isCanExc => false;

	public int Rate => 0;

	public static HalloweenExchangeItemData Create(HalloweenExchageItemConfigData configData)
	{
		return null;
	}

	public void UpdateCount(int count)
	{
	}
}
