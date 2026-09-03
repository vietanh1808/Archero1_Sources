using System.Collections.Generic;

public class FishingRankingRewardData : RecycleData<FishingRankingRewardConfigData>
{
	public int TotalFishingCount => 0;

	public int CurRewardGroup => 0;

	public List<FishingRankingRewardGroupData> DailyGroupData => null;

	public void SyncS3ConfigData(List<FishingConfigRankConfigData> config)
	{
	}

	private int GetCurRewardGroup()
	{
		return 0;
	}

	public void UpdateTotalFishingCount(int totalCount)
	{
	}

	public void UpdateCurGroup(int curGroup)
	{
	}
}
