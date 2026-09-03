using System.Collections.Generic;
using TableTool;
using XLua;

public class CampAchievementItemData
{
	private static DelegateBridge __Hotfix0_get_ConfigData;

	private static DelegateBridge __Hotfix0_set_ConfigData;

	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Type;

	private static DelegateBridge __Hotfix0_get_Progress;

	private static DelegateBridge __Hotfix0_get_NeedProgress;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_get_Status;

	private static DelegateBridge __Hotfix0_get_ClaimedCount;

	private static DelegateBridge __Hotfix0_get_CanGetReward;

	private static DelegateBridge __Hotfix0_get_IsClaimedAll;

	private static DelegateBridge __Hotfix0_Create;

	private static DelegateBridge __Hotfix0_UpdateClaimedID;

	private static DelegateBridge __Hotfix0_GetID;

	private static DelegateBridge __Hotfix0_GetNeedProgress;

	private static DelegateBridge __Hotfix0_GetRewards;

	private static DelegateBridge __Hotfix0_GetStatus;

	private static DelegateBridge __Hotfix0_GetTargetModelData;

	private static DelegateBridge __Hotfix0_GetCurClaimedModelData;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampAchievementItemConfigData ConfigData { get; set; }

	public int ID => 0;

	public int Type => 0;

	public int Progress => 0;

	public int NeedProgress => 0;

	public List<Drop_DropModel.DropData> Rewards => null;

	public CampAchievementItemStatus Status => CampAchievementItemStatus.None;

	public int ClaimedCount => 0;

	public bool CanGetReward => false;

	public bool IsClaimedAll => false;

	public static CampAchievementItemData Create(CampAchievementItemConfigData configData)
	{
		return null;
	}

	public void UpdateClaimedID()
	{
	}

	private int GetID()
	{
		return 0;
	}

	private int GetNeedProgress()
	{
		return 0;
	}

	private List<Drop_DropModel.DropData> GetRewards()
	{
		return null;
	}

	private CampAchievementItemStatus GetStatus()
	{
		return CampAchievementItemStatus.None;
	}

	private SLG_SLGAchieve GetTargetModelData()
	{
		return null;
	}

	private SLG_SLGAchieve GetCurClaimedModelData()
	{
		return null;
	}
}
