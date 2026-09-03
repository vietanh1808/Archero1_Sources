using System.Collections.Generic;

public class Act5thHuntingRankingRewardData : RecycleData<Act5thHuntingRankingRewardSourceData>
{
	public int TotalHuntingScore => 0;

	public int CurRewardGroup => 0;

	public List<Act5thHuntingRankingRewardGroupData> DailyGroupData => null;

	private int GetCurRewardGroup()
	{
		return 0;
	}

	public void UpdateCurGroup(int curGroup)
	{
	}
}
