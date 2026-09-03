using System.Collections.Generic;
using XLua;

public class FishingRankingConfigData
{
	public int rewardIndex;

	public FishingRankingItemConfigData daySelfData;

	public List<FishingRankingItemConfigData> dayItemConfigData;

	public FishingRankingItemConfigData seasonSelfData;

	public List<FishingRankingSeasonItemConfigData> seasonItemConfigData;

	public List<FishingConfigRankConfigData> config;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_SyncS3ConfigData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static FishingRankingConfigData Create(int rewardIndex, FishingRankingItemConfigData daySelfData, List<FishingRankingItemConfigData> dayItemConfigData, FishingRankingItemConfigData seasonSelfData, List<FishingRankingSeasonItemConfigData> seasonItemConfigData)
	{
		return null;
	}

	public void SyncS3ConfigData(List<FishingConfigRankConfigData> config)
	{
	}
}
