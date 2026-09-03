using System.Collections.Generic;
using TableTool;
using XLua;

public class CampAchievementData : RecycleData<CampAchievementConfigData>
{
	private static DelegateBridge __Hotfix0_get_ID;

	private static DelegateBridge __Hotfix0_get_Progress;

	private static DelegateBridge __Hotfix0_get_NeedProgress;

	private static DelegateBridge __Hotfix0_get_ClaimedNeedProgress;

	private static DelegateBridge __Hotfix0_get_PreClaimedNeedProgress;

	private static DelegateBridge __Hotfix0_get_Rewards;

	private static DelegateBridge __Hotfix0_get_Status;

	private static DelegateBridge __Hotfix0_get_ItemData;

	private static DelegateBridge __Hotfix0_get_CanGetReward;

	private static DelegateBridge __Hotfix0_get_IsClaimedAll;

	private static DelegateBridge __Hotfix0_UpdateClaimedID;

	private static DelegateBridge __Hotfix0_GetStatus;

	private static DelegateBridge __Hotfix0_GetProgress;

	private static DelegateBridge __Hotfix0_GetNeedProgress;

	private static DelegateBridge __Hotfix0_GetClaimedNeedProgress;

	private static DelegateBridge __Hotfix0_GetPreClaimedNeedProgress;

	private static DelegateBridge __Hotfix0_GetRewards;

	private static DelegateBridge __Hotfix0_GetID;

	private static DelegateBridge __Hotfix0_GetTargetModelData;

	private static DelegateBridge __Hotfix0_GetCurClaimedModelData;

	private static DelegateBridge __Hotfix0_GetPreClaimedModelData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int ID => 0;

	public int Progress => 0;

	public int NeedProgress => 0;

	public int ClaimedNeedProgress => 0;

	public int PreClaimedNeedProgress => 0;

	public List<Drop_DropModel.DropData> Rewards => null;

	public CampAchievementItemStatus Status => CampAchievementItemStatus.None;

	public List<CampAchievementItemData> ItemData => null;

	public bool CanGetReward => false;

	public bool IsClaimedAll => false;

	public void UpdateClaimedID()
	{
	}

	private CampAchievementItemStatus GetStatus()
	{
		return CampAchievementItemStatus.None;
	}

	private int GetProgress()
	{
		return 0;
	}

	private int GetNeedProgress()
	{
		return 0;
	}

	private int GetClaimedNeedProgress()
	{
		return 0;
	}

	private int GetPreClaimedNeedProgress()
	{
		return 0;
	}

	private List<Drop_DropModel.DropData> GetRewards()
	{
		return null;
	}

	private int GetID()
	{
		return 0;
	}

	private SLG_SLGAchieveReward GetTargetModelData()
	{
		return null;
	}

	private SLG_SLGAchieveReward GetCurClaimedModelData()
	{
		return null;
	}

	private SLG_SLGAchieveReward GetPreClaimedModelData()
	{
		return null;
	}
}
