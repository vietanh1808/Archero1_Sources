using System.Collections.Generic;

public class PVERankRewardDetailData
{
	public int CurArea => 0;

	public List<int> AllArea => null;

	public int CurAreaIndex => 0;

	public (int, int) RankCond(int selectArea)
	{
		return default;
	}

	public int ShowArea(int selectArea)
	{
		return 0;
	}

	public List<PVERankRewardDetailItemData> ItemData(int tabType, int selectArea)
	{
		return null;
	}

	public bool ShowSelf(int tabType, int selectArea)
	{
		return false;
	}

	public int SelfRanking(int tabType)
	{
		return 0;
	}

	public List<string> SelfReward(int tabType, int selectArea)
	{
		return null;
	}

	public PVERankItemData SelfData(int tabType)
	{
		return null;
	}

	private List<PVERankRewardDetailItemData> GetItemData(int tabType, int selectArea)
	{
		return null;
	}
}
