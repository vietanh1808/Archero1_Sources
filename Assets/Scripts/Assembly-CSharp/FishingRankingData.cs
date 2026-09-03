using System.Collections.Generic;
using XLua;

public class FishingRankingData : RecycleData<FishingRankingConfigData>
{
	private static DelegateBridge __Hotfix0_get_RewardIndex;

	private static DelegateBridge __Hotfix0_get_Config;

	private static DelegateBridge __Hotfix0_SelfData;

	private static DelegateBridge __Hotfix0_get_DaySelfData;

	private static DelegateBridge __Hotfix0_get_DayItemData;

	private static DelegateBridge __Hotfix0_get_SeasonSelfData;

	private static DelegateBridge __Hotfix0_get_SeasonItemData;

	private static DelegateBridge __Hotfix0_GetRankCount;

	private static DelegateBridge __Hotfix0_IsUnlock;

	private static DelegateBridge __Hotfix0_SyncS3ConfigData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int RewardIndex => 0;

	public List<FishingConfigRankConfigData> Config => null;

	private FishingRankingItemData DaySelfData => null;

	public List<FishingRankingItemData> DayItemData => null;

	private FishingRankingItemData SeasonSelfData => null;

	public List<FishingRankingSeasonItemData> SeasonItemData => null;

	public FishingRankingItemData SelfData(int index)
	{
		return null;
	}

	public int GetRankCount(int index)
	{
		return 0;
	}

	public bool IsUnlock(int index)
	{
		return false;
	}

	public void SyncS3ConfigData(List<FishingConfigRankConfigData> config)
	{
	}
}
