using System.Collections.Generic;

public class FishingRankingRewardConfigData
{
	public int curGroup;

	public int totalFishingCount;

	public List<FishingRankingRewardGroupConfigData> groupConfigData;

	public static FishingRankingRewardConfigData Create(int curGroup, int totalFishingCount)
	{
		return null;
	}

	public void SyncS3ConfigData(List<FishingConfigRankConfigData> config)
	{
	}

	public void UpdateTotalFishingCount(int totalCount)
	{
	}

	public void UpdateCurGroup(int curGroup)
	{
	}
}
