using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using XLua;

public class CampTalentManager : SingletonNet<CampTalentManager, CReqCampTalent, CRespCampTalent>
{
	public const float PerPersonalProgressItemHeight = 170f;

	public const int PerRowPersonalProgressItemCount = 5;

	public const string FrameType1Unlock = "CampTalent_Personal_Item1Upgrade";

	public const string FrameType1MaxLevel = "CampTalent_Personal_Item1Max";

	public const string FrameType2Unlock = "CampTalent_Personal_Item2Upgrade";

	public const string FrameType2MaxLevel = "CampTalent_Personal_Item2Max";

	public const string FrameType1Circle = "CampTalent_Personal_Item1LevelBg";

	public const string FrameType2Circle = "CampTalent_Personal_Item2LevelBg";

	public const float ScrollBottomOffset = 130f;

	public const float ScrollTopOffset = 20f;

	public const float ScrollItemHeight = 190f;

	public const float ScrollTopBgHeight = 80f;

	public const float SpecialStartValue = 0.77f;

	public const float SpecialEndValue = 0.91f;

	public const string ReachProgressItemBg = "CampTalent_Team_ItemReach";

	public const string UnReachProgressItemBg = "CampTalent_Team_ItemUnReach";

	public const string ReachProgressItemLevelBg = "CampTalent_Team_LevelReach";

	public const string UnReachProgressItemLevelBg = "CampTalent_Team_LevelUnReach";

	public const string TaskRewardNormalBg = "CampTalent_Task_RewardNormalBg";

	public const string TaskRewardNormalSubBg = "CampTalent_Task_RewardNormalSubBg";

	public const string TaskRewardCompleteBg = "CampTalent_Task_RewardCompleteBg";

	public const string TaskRewardCompleteSubBg = "CampTalent_Task_RewardCompleteSubBg";

	public const float TaskItemScaleSize = 0.52f;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_CampTalentPersonalData;

	private static DelegateBridge __Hotfix0_set_CampTalentPersonalData;

	private static DelegateBridge __Hotfix0_get_CampTalentPersonalProgressData;

	private static DelegateBridge __Hotfix0_set_CampTalentPersonalProgressData;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamData;

	private static DelegateBridge __Hotfix0_set_CampTalentTeamData;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamProgressData;

	private static DelegateBridge __Hotfix0_set_CampTalentTeamProgressData;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamTaskData;

	private static DelegateBridge __Hotfix0_set_CampTalentTeamTaskData;

	private static DelegateBridge __Hotfix0_get_CampTalentTeamTaskProgressData;

	private static DelegateBridge __Hotfix0_set_CampTalentTeamTaskProgressData;

	private static DelegateBridge __Hotfix0_get_HaveSyncData;

	private static DelegateBridge __Hotfix0_set_HaveSyncData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_IsSyncData;

	private static DelegateBridge __Hotfix0_GetCampTalentPersonalData;

	private static DelegateBridge __Hotfix0_GetCampTalentPersonalProgressData;

	private static DelegateBridge __Hotfix0_GetCampTalentTeamData;

	private static DelegateBridge __Hotfix0_GetCampTalentTeamProgressData;

	private static DelegateBridge __Hotfix0_GetCampTalentTeamTaskData;

	private static DelegateBridge __Hotfix0_GetCampTalentTeamTaskProgressData;

	private static DelegateBridge __Hotfix0_GetAllUpgradePersonalTalentData;

	private static DelegateBridge __Hotfix0_GetAllUpgradeTeamTalentData;

	private static DelegateBridge __Hotfix0_IsOpen;

	private static DelegateBridge __Hotfix0_IsCampActivityOpen;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge __Hotfix0_HavePersonalRed;

	private static DelegateBridge __Hotfix0_HaveTeamRed;

	private static DelegateBridge __Hotfix0_HaveTeamTaskRed;

	private static DelegateBridge __Hotfix0_HaveTeamProgressRed;

	private static DelegateBridge __Hotfix0_GetPersonalAttributeWithNext;

	private static DelegateBridge __Hotfix0_GetTeamAttribute;

	private static DelegateBridge __Hotfix0_GetPersonalReachAttribute;

	private static DelegateBridge __Hotfix0_GetTeamReachAttribute;

	private static DelegateBridge __Hotfix0_RequestTalentData;

	private static DelegateBridge __Hotfix0_RequestPersonalUpgrade;

	private static DelegateBridge __Hotfix0_RequestTeamDonate;

	private static DelegateBridge __Hotfix0_RequestTeamTaskReward;

	private static DelegateBridge __Hotfix0_SetData;

	private static DelegateBridge __Hotfix0_SaveData;

	private static DelegateBridge __Hotfix0_SavePersonalData;

	private static DelegateBridge __Hotfix0_SaveTeamData;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override string Name { get; }

	private CampTalentPersonalData CampTalentPersonalData { get; set; }

	private CampTalentPersonalProgressData CampTalentPersonalProgressData { get; set; }

	private CampTalentTeamData CampTalentTeamData { get; set; }

	private CampTalentTeamProgressData CampTalentTeamProgressData { get; set; }

	private CampTalentTeamTaskData CampTalentTeamTaskData { get; set; }

	private CampTalentTeamTaskProgressData CampTalentTeamTaskProgressData { get; set; }

	private bool HaveSyncData { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqCampTalent RequestPacket()
	{
		return null;
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	protected override void Response(NetResponse response, CRespCampTalent data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	protected override bool RequestCond()
	{
		return false;
	}

	public bool IsSyncData()
	{
		return false;
	}

	public CampTalentPersonalData GetCampTalentPersonalData()
	{
		return null;
	}

	public CampTalentPersonalProgressData GetCampTalentPersonalProgressData()
	{
		return null;
	}

	public CampTalentTeamData GetCampTalentTeamData()
	{
		return null;
	}

	public CampTalentTeamProgressData GetCampTalentTeamProgressData()
	{
		return null;
	}

	public CampTalentTeamTaskData GetCampTalentTeamTaskData()
	{
		return null;
	}

	public CampTalentTeamTaskProgressData GetCampTalentTeamTaskProgressData()
	{
		return null;
	}

	public List<CampTalentPersonalProgressItemData> GetAllUpgradePersonalTalentData()
	{
		return null;
	}

	public List<CampTalentTeamProgressItemData> GetAllUpgradeTeamTalentData()
	{
		return null;
	}

	public bool IsOpen()
	{
		return false;
	}

	public bool IsCampActivityOpen()
	{
		return false;
	}

	public bool HaveRed()
	{
		return false;
	}

	public bool HavePersonalRed()
	{
		return false;
	}

	public bool HaveTeamRed()
	{
		return false;
	}

	public bool HaveTeamTaskRed()
	{
		return false;
	}

	public bool HaveTeamProgressRed()
	{
		return false;
	}

	public string GetPersonalAttributeWithNext(int talentID, int level)
	{
		return null;
	}

	public string GetTeamAttribute(int talentID)
	{
		return null;
	}

	public string GetPersonalReachAttribute(bool isSpecial)
	{
		return null;
	}

	public string GetTeamReachAttribute(bool isSpecial)
	{
		return null;
	}

	public void RequestTalentData()
	{
	}

	public void RequestPersonalUpgrade(int talentID, Action<CCommonRespMsg> success = null, Action<CRespCampTalent> failure = null)
	{
	}

	public void RequestTeamDonate(int count, Action<CRespCampTalent> success = null, Action failure = null)
	{
	}

	public void RequestTeamTaskReward(int taskID, Action<CCommonRespMsg> success = null, Action failure = null)
	{
	}

	private void SetData(CCampTalent[] personalTalentData, int teamTalentScore, int personalTalentDonateScore, int taskClaimedRewardID)
	{
	}

	private void SaveData(CCampTalent[] campTalent, int teamTalentPoint, int donateTeamPoint, int rewardID)
	{
	}

	public void SavePersonalData(int id, int level)
	{
	}

	public void SaveTeamData(int teamTalentPoint)
	{
	}
}
