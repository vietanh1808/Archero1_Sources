using System.Collections.Generic;

public abstract class SailingRankRewardDetailData
{
	public int CurArea;

	public List<int> AllArea;

	public int CurAreaIndex => 0;

	public abstract (int, int) RankCond(int selectArea);

	public abstract int ShowArea(int selectArea);

	public abstract List<SailingRankRewardDetailItemData> ItemData(int selectArea);
}
