using System.Collections.Generic;
using GameProtocol;
using XLua;

public static class FishingUtils
{
	private static DelegateBridge __Hotfix0_ParseFishingConfigData;

	private static DelegateBridge __Hotfix0_ParseFishingRodConfigData;

	private static DelegateBridge __Hotfix0_ParseFishingSceneConfigData;

	private static DelegateBridge __Hotfix0_ParseFishingRankingConfigData;

	private static DelegateBridge __Hotfix0_ParseFishingRankingRewardConfigData;

	private static DelegateBridge __Hotfix0_ParseBestiaryConfigData;

	private static DelegateBridge __Hotfix0_ParseRodBestiaryConfigData;

	private static DelegateBridge __Hotfix0_ParseFishingLureConfigData;

	private static DelegateBridge __Hotfix0_ParseFishingGiftConfigData;

	private static DelegateBridge __Hotfix0_ParseFishingTaskConfigData;

	private static DelegateBridge __Hotfix0_ParseFishingShopConfigData;

	public static FishingConfigData ParseFishingConfigData(int tag, long startTime, long endTime, long fishingEndTime, long shoppingEndTime, long fishingTotalWeight)
	{
		return null;
	}

	public static FishingRodConfigData ParseFishingRodConfigData(int[] possessRod)
	{
		return null;
	}

	public static FishingSceneConfigData ParseFishingSceneConfigData(int maxUnlockAreaId)
	{
		return null;
	}

	public static FishingRankingConfigData ParseFishingRankingConfigData(int rewardIndex, STGameFishingRank rankData)
	{
		return null;
	}

	public static FishingRankingRewardConfigData ParseFishingRankingRewardConfigData(int curGroup, int totalFishingCount)
	{
		return null;
	}

	public static FishingBestiaryConfigData ParseBestiaryConfigData(uint[] allCatalog, uint rewardBit)
	{
		return null;
	}

	public static FishingRodBestiaryConfigData ParseRodBestiaryConfigData()
	{
		return null;
	}

	public static FishingLureConfigData ParseFishingLureConfigData(int haveBuyCount, int originCount)
	{
		return null;
	}

	public static FishingGiftConfigData ParseFishingGiftConfigData(Dictionary<uint, uint> buyTimes, string giftConfig)
	{
		return null;
	}

	public static FishingTaskConfigData ParseFishingTaskConfigData(string taskProgress, string taskConfig)
	{
		return null;
	}

	public static FishingShopConfigData ParseFishingShopConfigData(CFishingExchangeData[] exchangeDataA, CFishingExchangeData[] exchangeDataB)
	{
		return null;
	}
}
