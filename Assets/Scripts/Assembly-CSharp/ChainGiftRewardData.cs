using System.Collections.Generic;
using XLua;

public class ChainGiftRewardData
{
	private static DelegateBridge __Hotfix0_get_RewardData;

	private static DelegateBridge __Hotfix0_set_RewardData;

	private static DelegateBridge __Hotfix0_get_RewardProgress;

	private static DelegateBridge __Hotfix0_GetRewardItemData;

	private static DelegateBridge __Hotfix0_GetAllCanGetReward;

	private static DelegateBridge __Hotfix0_GetRewardConfigData;

	private static DelegateBridge __Hotfix0_SyncRemoteData;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ChainGiftRewardConfigData RewardData { get; set; }

	public int RewardProgress => 0;

	public List<ChainGiftRewardItemData> GetRewardItemData()
	{
		return null;
	}

	public List<ChainGiftRewardItemData> GetAllCanGetReward()
	{
		return null;
	}

	public ChainGiftRewardConfigData GetRewardConfigData()
	{
		return null;
	}

	public void SyncRemoteData(ChainGiftRewardConfigData rewardData)
	{
	}

	public void Clear()
	{
	}
}
