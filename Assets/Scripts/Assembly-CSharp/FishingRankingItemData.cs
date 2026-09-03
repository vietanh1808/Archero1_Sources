using System.Collections.Generic;
using TableTool;
using XLua;

public class FishingRankingItemData : RecycleData<FishingRankingItemConfigData>
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_UserID;

	private static DelegateBridge __Hotfix0_ListRanking;

	private static DelegateBridge __Hotfix0_ShowRanking;

	private static DelegateBridge __Hotfix0_get_RealRanking;

	private static DelegateBridge __Hotfix0_get_Score;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_HeadID;

	private static DelegateBridge __Hotfix0_get_HeadFrame;

	private static DelegateBridge __Hotfix0_get_HeadFrameTime;

	private static DelegateBridge __Hotfix0_get_VIPLevel;

	private static DelegateBridge __Hotfix0_get_MedalData;

	private static DelegateBridge __Hotfix0_Reward;

	private static DelegateBridge __Hotfix0_BoxIconName;

	private static DelegateBridge __Hotfix0_get_GroupIndex;

	private static DelegateBridge __Hotfix0_PercentageRanking;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_GetFishingRankingItemConfig;

	private static DelegateBridge __Hotfix0_GetPercentageRanking;

	private static DelegateBridge __Hotfix0_GetReward;

	private static DelegateBridge __Hotfix0_GetBoxIconName;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingRankingItemConfigData ConfigData { get; set; }

	public ulong UserID => 0uL;

	public int RealRanking => 0;

	public long Score => 0L;

	public string Name => null;

	public int HeadID => 0;

	public int HeadFrame => 0;

	public long HeadFrameTime => 0L;

	public int VIPLevel => 0;

	public List<int> MedalData => null;

	public int GroupIndex => 0;

	public int ListRanking(int index)
	{
		return 0;
	}

	public float ShowRanking(int index)
	{
		return 0f;
	}

	public List<Drop_DropModel.DropData> Reward(int index)
	{
		return null;
	}

	public string BoxIconName(int index)
	{
		return null;
	}

	public float PercentageRanking(int index)
	{
		return 0f;
	}

	public static FishingRankingItemData Create(FishingRankingItemConfigData configData)
	{
		return null;
	}

	private FishingConfigRankConfigData GetFishingRankingItemConfig(int index)
	{
		return null;
	}

	private float GetPercentageRanking(int index)
	{
		return 0f;
	}

	private List<Drop_DropModel.DropData> GetReward(int index)
	{
		return null;
	}

	private string GetBoxIconName(int index)
	{
		return null;
	}
}
