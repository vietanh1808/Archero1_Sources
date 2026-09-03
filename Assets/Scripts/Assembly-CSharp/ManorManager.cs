using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using XLua;

public class ManorManager : CInstance<ManorManager>
{
	public int StealOneKeyPercent;

	public string VisitSerialKey;

	public const float Manor_Scale = 1f;

	public CRespManorStore shopData;

	public bool isHavePullMyData;

	public List<ManorRecordItemData> recordDataList;

	public int ExchOrderMaxToday;

	private bool isPullFarmMonsterData;

	private bool isPullFarmEventData;

	public bool isme;

	private static DelegateBridge __Hotfix0_get_IsHaveRed;

	private static DelegateBridge __Hotfix0_ShowBagRed;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_isOpen;

	private static DelegateBridge __Hotfix0_isOpenBox;

	private static DelegateBridge __Hotfix0_GetBuildingPic;

	private static DelegateBridge __Hotfix0_GetRepairBuildId;

	private static DelegateBridge __Hotfix0_GetMatRepairList;

	private static DelegateBridge __Hotfix0_GetManorUpgradeOne;

	private static DelegateBridge __Hotfix0_IsLevelUpBreak;

	private static DelegateBridge __Hotfix0_GetMatLevelUp;

	private static DelegateBridge __Hotfix0_GetMatStarUp;

	private static DelegateBridge __Hotfix0_GetExchOrderMat;

	private static DelegateBridge __Hotfix0_isHaveBuildLevelUp;

	private static DelegateBridge __Hotfix0_isCanBuildLevelUp;

	private static DelegateBridge __Hotfix0_isHaveBuildStarUp;

	private static DelegateBridge __Hotfix0_isCanBuildStarUp;

	private static DelegateBridge __Hotfix0_GetStarLevel;

	private static DelegateBridge __Hotfix0_GetStarId;

	private static DelegateBridge __Hotfix0_GetBuildMaxStarIndex;

	private static DelegateBridge __Hotfix0_isStarMaxArrived;

	private static DelegateBridge __Hotfix0_GetBuildMaxLevel;

	private static DelegateBridge __Hotfix0_GetBuildMaxStar;

	private static DelegateBridge __Hotfix0_GetEffectList_Build;

	private static DelegateBridge __Hotfix0_GetEffectList_Worker;

	private static DelegateBridge __Hotfix0_GetWorkerEffectList_StarUp;

	private static DelegateBridge __Hotfix0_GetBuildEffectList_LevelUp;

	private static DelegateBridge __Hotfix0_GetBuildEffectList_StarUp;

	private static DelegateBridge __Hotfix0_GetWorkerPutCount;

	private static DelegateBridge __Hotfix0_get_SpringCurrentLevel;

	private static DelegateBridge __Hotfix0_GetStarPicIndex;

	private static DelegateBridge __Hotfix0_get_myData;

	private static DelegateBridge __Hotfix0_get_visitData;

	private static DelegateBridge __Hotfix0_get_manorData;

	private static DelegateBridge __Hotfix0_requestManorInfo;

	private static DelegateBridge __Hotfix0_requestOneClick;

	private static DelegateBridge __Hotfix0_requestWorkerInfo;

	private static DelegateBridge __Hotfix0_requestBuildingInfo;

	private static DelegateBridge __Hotfix0_requestShopInfo;

	private static DelegateBridge __Hotfix0_ReduceUsedMaterial;

	private static DelegateBridge __Hotfix0_parseOrderList;

	private static DelegateBridge __Hotfix0_setManorCoinNum;

	private static DelegateBridge __Hotfix0_GetWorkerDataOne;

	private static DelegateBridge __Hotfix0_GetWorkerDataOne_EquipId;

	private static DelegateBridge __Hotfix0_GetBuildingDataOne;

	private static DelegateBridge __Hotfix1_GetBuildingDataOne;

	private static DelegateBridge __Hotfix0_GetExchDataOne;

	private static DelegateBridge __Hotfix0_GetWorkerInBuildId;

	private static DelegateBridge __Hotfix0_GetShopDatas;

	private static DelegateBridge __Hotfix0_ClearShopData;

	private static DelegateBridge __Hotfix0_GetShopDataById;

	private static DelegateBridge __Hotfix0_GetWorkerDataByFragmentID;

	private static DelegateBridge __Hotfix0_get_ManorUpgradesQuery;

	private static DelegateBridge __Hotfix0_get_ManorStarPlanQuery;

	private static DelegateBridge __Hotfix0_get_ManorStarQuery;

	private static DelegateBridge __Hotfix0_GetBuildingAttrs;

	private static DelegateBridge __Hotfix0_GetBuildingSkills;

	private static DelegateBridge __Hotfix0_GetWorkerAllAttr;

	private static DelegateBridge __Hotfix0_GetWorkerInBuildAttrs;

	private static DelegateBridge __Hotfix0_GetWorkerSkillIds;

	private static DelegateBridge __Hotfix0_GetBuildGiveResId;

	private static DelegateBridge __Hotfix0_GetBuildMinTime;

	private static DelegateBridge __Hotfix0_GetBuildMaxTime;

	private static DelegateBridge __Hotfix0_GetBuildResSpeed;

	private static DelegateBridge __Hotfix0_WorkerOpenNum;

	private static DelegateBridge __Hotfix0_GetExchOrderMaxToday;

	private static DelegateBridge __Hotfix0_GetAbilityList;

	private static DelegateBridge __Hotfix0_AbilityTypeValue;

	private static DelegateBridge __Hotfix0_GetAbilityList_Type1;

	private static DelegateBridge __Hotfix0_GetAbilityRecoverTime_Type1;

	private static DelegateBridge __Hotfix0_SetAbilityRecoverTime;

	private static DelegateBridge __Hotfix0_GetAbilityUsedTimes_Type1;

	private static DelegateBridge __Hotfix0_SetAbilityUsedTimes;

	private static DelegateBridge __Hotfix0_isUnlockOneKeyRes;

	private static DelegateBridge __Hotfix0_addWorkerOne;

	private static DelegateBridge __Hotfix0_addWorkers;

	private static DelegateBridge __Hotfix0_get_isShowOneKeyGetRes;

	private static DelegateBridge __Hotfix0_isHaveAbilityType1_CanUse;

	private static DelegateBridge __Hotfix0_isHaveBuildGetRes;

	private static DelegateBridge __Hotfix0_isHaveBuildBubble;

	private static DelegateBridge __Hotfix0_isCanSpringWish;

	private static DelegateBridge __Hotfix0_isCanFinishExchOrder;

	private static DelegateBridge __Hotfix0_isCanFinishExchOne;

	private static DelegateBridge __Hotfix0_pullFarmData_OpenManor;

	private static DelegateBridge __Hotfix0_resetPullFarm_CloseManor;

	private static DelegateBridge __Hotfix0_openFarmUI;

	private static DelegateBridge __Hotfix0_setIsMe;

	private static DelegateBridge __Hotfix0_get_ManorVersion;

	private static DelegateBridge __Hotfix0_handleManorTips;

	private static DelegateBridge __Hotfix0_get_StealMaxToday;

	private static DelegateBridge __Hotfix0_get_StealRatioBasic;

	private static DelegateBridge __Hotfix0_StealRatioReduce;

	private static DelegateBridge __Hotfix0_StealRatio;

	private static DelegateBridge __Hotfix0_StealBuildRoundMax;

	private static DelegateBridge __Hotfix0_get_StealRestoreTimeOne;

	private static DelegateBridge __Hotfix0_GetStealResCount;

	private static DelegateBridge __Hotfix0_isStealBuildOne;

	private static DelegateBridge __Hotfix0_isStealChanceForBuild;

	private static DelegateBridge __Hotfix0_isStealChanceForMe;

	private static DelegateBridge __Hotfix0_isCanStealBuild;

	private static DelegateBridge __Hotfix0_GetStealItemData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool IsHaveRed => false;

	public int SpringCurrentLevel => 0;

	public ManorData myData => null;

	public ManorData visitData => null;

	public ManorData manorData => null;

	private IEnumerable<Manor_Upgrade> ManorUpgradesQuery => null;

	private IEnumerable<string[]> ManorStarPlanQuery => null;

	private IEnumerable<(Manor_Worker, int)> ManorStarQuery => null;

	public bool isShowOneKeyGetRes => false;

	public int ManorVersion => 0;

	public int StealMaxToday => 0;

	public int StealRatioBasic => 0;

	public int StealRestoreTimeOne => 0;

	public bool ShowBagRed()
	{
		return false;
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public bool isOpen()
	{
		return false;
	}

	public bool isOpenBox()
	{
		return false;
	}

	public string GetBuildingPic(int mode, int buildId, int level)
	{
		return null;
	}

	public int GetRepairBuildId()
	{
		return 0;
	}

	public List<ManorMatDataShow> GetMatRepairList(int buildId)
	{
		return null;
	}

	public Manor_Upgrade GetManorUpgradeOne(int buildId, int level)
	{
		return null;
	}

	public bool IsLevelUpBreak(int buildId, int level)
	{
		return false;
	}

	public List<ManorMatDataShow> GetMatLevelUp(int buildId, int level)
	{
		return null;
	}

	public List<ManorMatDataShow> GetMatStarUp(int starid)
	{
		return null;
	}

	public List<ManorMatDataShow> GetExchOrderMat(int exchid)
	{
		return null;
	}

	public bool isHaveBuildLevelUp()
	{
		return false;
	}

	public bool isCanBuildLevelUp(int buildId)
	{
		return false;
	}

	public bool isHaveBuildStarUp()
	{
		return false;
	}

	public bool isCanBuildStarUp(int buildId)
	{
		return false;
	}

	public int GetStarLevel(int starid)
	{
		return 0;
	}

	public int GetStarId(int buildId, int starIndex)
	{
		return 0;
	}

	public int GetBuildMaxStarIndex(int buildId)
	{
		return 0;
	}

	public bool isStarMaxArrived(int buildId, int starIndex)
	{
		return false;
	}

	public int GetBuildMaxLevel(int buildId)
	{
		return 0;
	}

	public int GetBuildMaxStar(int buildId)
	{
		return 0;
	}

	public List<ManorTextData> GetEffectList_Build(int buildId, int level, int starIndex)
	{
		return null;
	}

	public List<ManorTextData> GetEffectList_Worker(int wid, int star)
	{
		return null;
	}

	public List<ManorTextData> GetWorkerEffectList_StarUp(int wid, int star)
	{
		return null;
	}

	public List<ManorTextData> GetBuildEffectList_LevelUp(int buildId, int level)
	{
		return null;
	}

	public List<ManorTextData> GetBuildEffectList_StarUp(int buildId, int starIndex)
	{
		return null;
	}

	public int GetWorkerPutCount(int buildId)
	{
		return 0;
	}

	public int GetStarPicIndex(int star)
	{
		return 0;
	}

	public void requestManorInfo(int type, ulong userid = 0uL, int value = 0, bool isClick = false, Action<bool> action = null)
	{
	}

	public void requestOneClick(Action action = null)
	{
	}

	public void requestWorkerInfo(int type, ulong rowId, int mid, Action<bool> action = null)
	{
	}

	public void requestBuildingInfo(int type, int mid, int count, Action<bool> action = null)
	{
	}

	public void requestShopInfo(int type = 0, int num = 1, ushort id = 0, Action<bool> action = null, int cost = 0)
	{
	}

	private void ReduceUsedMaterial(List<ManorMatDataShow> list)
	{
	}

	private void parseOrderList(string jsons)
	{
	}

	public void setManorCoinNum(int coin)
	{
	}

	public ManorWorkerData GetWorkerDataOne(ManorData mdata, ulong rowid)
	{
		return null;
	}

	public ManorWorkerData GetWorkerDataOne_EquipId(ManorData mdata, int equipid)
	{
		return null;
	}

	public ManorBuildingData GetBuildingDataOne(ManorData mdata, int buildId)
	{
		return null;
	}

	public ManorBuildingData GetBuildingDataOne(int buildId)
	{
		return null;
	}

	public ManorExchData GetExchDataOne(int exchid)
	{
		return null;
	}

	public int GetWorkerInBuildId(ulong rid)
	{
		return 0;
	}

	public CManorExchangeData[] GetShopDatas()
	{
		return null;
	}

	public void ClearShopData()
	{
	}

	public CManorExchangeData GetShopDataById(int id)
	{
		return null;
	}

	public Manor_Worker GetWorkerDataByFragmentID(int id)
	{
		return null;
	}

	public List<string> GetBuildingAttrs()
	{
		return null;
	}

	public List<int> GetBuildingSkills()
	{
		return null;
	}

	public List<string> GetWorkerAllAttr()
	{
		return null;
	}

	public List<string> GetWorkerInBuildAttrs()
	{
		return null;
	}

	public List<int> GetWorkerSkillIds()
	{
		return null;
	}

	public int GetBuildGiveResId(int buildId)
	{
		return 0;
	}

	public int GetBuildMinTime(int buildId)
	{
		return 0;
	}

	public int GetBuildMaxTime(int buildId)
	{
		return 0;
	}

	public float GetBuildResSpeed(int buildId, int level)
	{
		return 0f;
	}

	public int WorkerOpenNum(int buildId)
	{
		return 0;
	}

	private int GetExchOrderMaxToday()
	{
		return 0;
	}

	private List<int> GetAbilityList(ManorData mdata, int buildId)
	{
		return null;
	}

	private int AbilityTypeValue(ManorData mdata, int buildId, int type)
	{
		return 0;
	}

	public List<int> GetAbilityList_Type1(int buildId)
	{
		return null;
	}

	public ulong GetAbilityRecoverTime_Type1(ManorData mdata, int buildId, int abi)
	{
		return 0uL;
	}

	public void SetAbilityRecoverTime(ManorData mdata, int buildId, int type, ulong time)
	{
	}

	public int GetAbilityUsedTimes_Type1(ManorData mdata, int buildId, int abi)
	{
		return 0;
	}

	public void SetAbilityUsedTimes(ManorData mdata, int buildId, int type)
	{
	}

	public bool isUnlockOneKeyRes()
	{
		return false;
	}

	public void addWorkerOne(CManorWoker item)
	{
	}

	public void addWorkers(CManorWoker[] items)
	{
	}

	public bool isHaveAbilityType1_CanUse()
	{
		return false;
	}

	public bool isHaveBuildGetRes()
	{
		return false;
	}

	public bool isHaveBuildBubble(int buildId)
	{
		return false;
	}

	public bool isCanSpringWish()
	{
		return false;
	}

	public bool isCanFinishExchOrder()
	{
		return false;
	}

	public bool isCanFinishExchOne(int exchid)
	{
		return false;
	}

	public void pullFarmData_OpenManor()
	{
	}

	public void resetPullFarm_CloseManor()
	{
	}

	public void openFarmUI(Action callback)
	{
	}

	public void setIsMe(bool isme)
	{
	}

	public void handleManorTips(int code)
	{
	}

	public int StealRatioReduce(int v, int m)
	{
		return 0;
	}

	public int StealRatio(int v, int m)
	{
		return 0;
	}

	public int StealBuildRoundMax(int buildId)
	{
		return 0;
	}

	public int GetStealResCount(int buildId)
	{
		return 0;
	}

	public bool isStealBuildOne(int buildId)
	{
		return false;
	}

	public bool isStealChanceForBuild(int buildId)
	{
		return false;
	}

	public bool isStealChanceForMe()
	{
		return false;
	}

	public bool isCanStealBuild(int buildId)
	{
		return false;
	}

	public ManorStealItemData GetStealItemData(int buildId)
	{
		return null;
	}
}
