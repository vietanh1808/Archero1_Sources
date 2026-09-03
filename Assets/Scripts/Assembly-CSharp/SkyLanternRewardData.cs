using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class SkyLanternRewardData
{
	public int id;

	public int index;

	public Drop_DropModel.DropData dropData;

	public int curSelectIndex;

	public bool isEntanceBig;

	public List<Drop_DropModel.DropData> drops;

	public bool isReviced;

	public int ShowWight;

	public bool isShowExchange;

	public bool isBig;

	public int group;

	public int lanternIndex;

	public SkyLanternRewardData(STActivityLampWishRewardProtoData data, SkyLanternMgr.SkyLanternSamllPoolConfig config, int levelIndex)
	{
	}

	public SkyLanternRewardData(STActivityLampWishRewardProtoData data, SkyLanternMgr.SkyLanternBigPoolConfig config, int levelIndex)
	{
	}

	public SkyLanternRewardData(SkyLanternMgr.SkyLanternSamllPoolConfig config, int levelIndex)
	{
	}
}
