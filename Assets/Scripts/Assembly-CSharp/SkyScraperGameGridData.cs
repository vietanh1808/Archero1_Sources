using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class SkyScraperGameGridData
{
	public int Id;

	public int Quality;

	public List<Drop_DropModel.DropData> Rewards;

	public bool isHaveReward;

	public SkyScraperGameGridData(STActivityGiftTowerGridProtoData data, int layer)
	{
	}
}
