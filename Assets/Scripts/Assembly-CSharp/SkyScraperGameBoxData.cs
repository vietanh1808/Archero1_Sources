using System;
using System.Collections.Generic;
using GameProtocol;

public class SkyScraperGameBoxData : ViewCellData
{
	public int ID;

	public int GridCount;

	public List<SkyScraperGameGridData> GridDatas;

	public Action OnShowReward;

	public bool isShowedReward => false;

	public SkyScraperGameBoxData(STActivityGiftTowerGridProtoData[] grids, int layer)
	{
	}

	public void ShowReward()
	{
	}
}
