using System;
using System.Collections.Generic;
using Dxx.Net;
using GameProtocol;
using UnityEngine;
using XLua;

public class FishingManager : SingletonNet<FishingManager, CReqGameFishing, CRespGameFishing>
{
	public const float InstrumentRotateMaxAngle = -33f;

	public const float InstrumentRotateMinAngle = 33f;

	public const float InstrumentGoodMaxAngle1 = -12.5f;

	public const float InstrumentGoodMinAngle1 = 12.5f;

	public const float InstrumentPerfectMaxAngle1 = -3f;

	public const float InstrumentPerfectMinAngle1 = 3f;

	public const float InstrumentGoodMaxAngle2 = -9.5f;

	public const float InstrumentGoodMinAngle2 = 9.5f;

	public const float InstrumentPerfectMaxAngle2 = -2f;

	public const float InstrumentPerfectMinAngle2 = 2f;

	public const float InstrumentGoodMaxAngle3 = -8f;

	public const float InstrumentGoodMinAngle3 = 8f;

	public const float InstrumentPerfectMaxAngle3 = -1.5f;

	public const float InstrumentPerfectMinAngle3 = 1.5f;

	public const float InstrumentGoodMaxAngle4 = -6f;

	public const float InstrumentGoodMinAngle4 = 6f;

	public const float InstrumentPerfectMaxAngle4 = -1f;

	public const float InstrumentPerfectMinAngle4 = 1f;

	public const float InstrumentSelectedWaitTime = 0.5f;

	public const float InstrumentArrowSwingDuration = 1f;

	public const float FailTime = 0.5f;

	public const float FishingStartMoveTime = 0.4f;

	public const float DialStartFishingAlpha = 0.6f;

	public const float DialArrowRotateTime = 1f;

	public const float DialArrowRotateAngel = 1080f;

	public const float DialShakeOnceTime = 0.25f;

	public const float DialShakeOnceStrength = 5f;

	public const float DialArrowRotateSpeedScale = 50f;

	public const float FishSizeScale = 0.003f;

	public const float FishSizeMinScale = 0.2f;

	public const float FishPosScale = 0.35f;

	public const float FishingResultWeightBgOriginScale = 6f;

	public const float FishingResultWeightOriginScale = 6f;

	public const float FishingResultAniTime = 0.2f;

	public const float FishingResultAniInterval = 0.2f;

	public const float FishingResultJellyInterval = 0.05f;

	public const float FishingResultJellyTime = 0.2f;

	public const float FishingResultJellyScale = 1.15f;

	public const float FishingTipMoveTargetY = 70f;

	public const float FishingTipMoveTargetTime = 1f;

	public const float FishingTipWaitTime = 0.5f;

	public const float FishingTipFadeTime = 0.5f;

	public const string FishingLureSelectBg = "Fishing_Lure_CountBg";

	public const string FishingBestiaryBg = "Fishing_Bestiary_Bg";

	public const string FishingBestiarySubBg = "Fishing_Bestiary_SubBg";

	public const string FishingResultWeightBg = "Fishing_Result_WeightBg";

	public const string FishingRankingCup = "Fishing_Ranking_Cup";

	public const string FishingSceneArea = "Fishing_Scene_Area";

	public const string FishingFishStatus = "Fishing_FishStatus";

	public const string FishingSelect = "Fishing_Select";

	public const string FishingFishQuality = "Fishing_FishQuality";

	public const string FishingRodQuality = "Fishing_Rod_Quality";

	public const string FishingRod = "Fishing_Rod";

	public const string FishingRankingRewardIcon = "Fishing_Ranking_RewardIcon";

	public const int FishingCastSoundID = 6000001;

	public const int FishingRiseSoundID = 6000002;

	public const int FishingFallSoundID = 6000003;

	public const int FishingFishOutSoundID = 6000004;

	public const float FishingRiseTime = 0.94f;

	public const float FishingFallTime = 0.83f;

	public const float RankingChestPropScale = 0.65f;

	public const float BestiaryBoxDoneScale = 1.2f;

	public const float ShopItemRewardScale = 0.62f;

	public const float WelfarePropScale = 0.62f;

	public const float RankingRewardPropScale = 0.62f;

	public const float ResultPropScale = 0.7f;

	public const int WelfareScrollMinCount = 4;

	public const int RankingRewardScrollMinCount = 4;

	public const int ShopScrollMinCount = 2;

	public const int LureBuyOneCount = 1;

	public const int LureBuyTenCount = 10;

	public const int FishingFailureIndex = 0;

	public const int FishingSuccessDistance = 1;

	public const int FishingDescTextSize = 26;

	public const float FishingRankingDailySize = 670f;

	public const float FishingRankingSeasonSize = 787f;

	private static DelegateBridge __Hotfix0_get_Name;

	private static DelegateBridge __Hotfix0_get_FishingHookDelayTime;

	private static DelegateBridge __Hotfix0_get_FishingS3ConfigData;

	private static DelegateBridge __Hotfix0_set_FishingS3ConfigData;

	private static DelegateBridge __Hotfix0_get_PropLureID;

	private static DelegateBridge __Hotfix0_get_PropFishingScoreID;

	private static DelegateBridge __Hotfix0_get_PropFishLineID;

	private static DelegateBridge __Hotfix0_get_PropFishKingScaleID;

	private static DelegateBridge __Hotfix0_get_FishingData;

	private static DelegateBridge __Hotfix0_set_FishingData;

	private static DelegateBridge __Hotfix0_get_FishingRodData;

	private static DelegateBridge __Hotfix0_set_FishingRodData;

	private static DelegateBridge __Hotfix0_get_FishingSceneData;

	private static DelegateBridge __Hotfix0_set_FishingSceneData;

	private static DelegateBridge __Hotfix0_get_FishingRankingData;

	private static DelegateBridge __Hotfix0_set_FishingRankingData;

	private static DelegateBridge __Hotfix0_get_FishingRankingRewardData;

	private static DelegateBridge __Hotfix0_set_FishingRankingRewardData;

	private static DelegateBridge __Hotfix0_get_FishingBestiaryData;

	private static DelegateBridge __Hotfix0_set_FishingBestiaryData;

	private static DelegateBridge __Hotfix0_get_FishingRodBestiaryData;

	private static DelegateBridge __Hotfix0_set_FishingRodBestiaryData;

	private static DelegateBridge __Hotfix0_get_FishingLureData;

	private static DelegateBridge __Hotfix0_set_FishingLureData;

	private static DelegateBridge __Hotfix0_get_FishingGiftData;

	private static DelegateBridge __Hotfix0_set_FishingGiftData;

	private static DelegateBridge __Hotfix0_get_FishingTaskData;

	private static DelegateBridge __Hotfix0_set_FishingTaskData;

	private static DelegateBridge __Hotfix0_get_FishingShopData;

	private static DelegateBridge __Hotfix0_set_FishingShopData;

	private static DelegateBridge __Hotfix0_get_HaveSyncData;

	private static DelegateBridge __Hotfix0_set_HaveSyncData;

	private static DelegateBridge __Hotfix0_get_HaveSyncConfigData;

	private static DelegateBridge __Hotfix0_set_HaveSyncConfigData;

	private static DelegateBridge __Hotfix0_get_SyncDataTime;

	private static DelegateBridge __Hotfix0_set_SyncDataTime;

	private static DelegateBridge __Hotfix0_get_SyncLureDataTime;

	private static DelegateBridge __Hotfix0_set_SyncLureDataTime;

	private static DelegateBridge __Hotfix0_get_SyncGiftDataTime;

	private static DelegateBridge __Hotfix0_set_SyncGiftDataTime;

	private static DelegateBridge __Hotfix0_get_SyncShopDataTime;

	private static DelegateBridge __Hotfix0_set_SyncShopDataTime;

	private static DelegateBridge __Hotfix0_get_NeedClearRodProp;

	private static DelegateBridge __Hotfix0_set_NeedClearRodProp;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_RequestPacket;

	private static DelegateBridge __Hotfix0_RequestTime;

	private static DelegateBridge __Hotfix0_AllowBurstRequest;

	private static DelegateBridge __Hotfix0_RequestCond;

	private static DelegateBridge __Hotfix0_Response;

	private static DelegateBridge __Hotfix0_ParseConfigData;

	private static DelegateBridge __Hotfix0_SyncConfigData;

	private static DelegateBridge __Hotfix0_IsOpen;

	private static DelegateBridge __Hotfix0_IsFishingOpen;

	private static DelegateBridge __Hotfix0_IsShoppingOpen;

	private static DelegateBridge __Hotfix0_HaveRed;

	private static DelegateBridge __Hotfix0_HaveBestiaryRed;

	private static DelegateBridge __Hotfix0_HaveLureRed;

	private static DelegateBridge __Hotfix0_HaveWelfareRed;

	private static DelegateBridge __Hotfix0_HaveGiftRed;

	private static DelegateBridge __Hotfix0_HaveTaskRed;

	private static DelegateBridge __Hotfix0_HaveShopRed;

	private static DelegateBridge __Hotfix0_HaveShopARed;

	private static DelegateBridge __Hotfix0_HaveShopBRed;

	private static DelegateBridge __Hotfix0_IsReachOpenCond;

	private static DelegateBridge __Hotfix0_GetTag;

	private static DelegateBridge __Hotfix0_GetFishingTotalWeight;

	private static DelegateBridge __Hotfix0_GetSyncDataStatus;

	private static DelegateBridge __Hotfix0_GetSyncDataTime;

	private static DelegateBridge __Hotfix0_GetSyncLureDataTime;

	private static DelegateBridge __Hotfix0_GetSyncGiftDataTime;

	private static DelegateBridge __Hotfix0_GetSyncShopDataTime;

	private static DelegateBridge __Hotfix0_GetFishingAniData;

	private static DelegateBridge __Hotfix1_GetFishingAniData;

	private static DelegateBridge __Hotfix0_GetFishingRodSkinName;

	private static DelegateBridge __Hotfix0_GetTipColor;

	private static DelegateBridge __Hotfix0_GetColor;

	private static DelegateBridge __Hotfix0_GetColorValue;

	private static DelegateBridge __Hotfix0_GetColorQuality;

	private static DelegateBridge __Hotfix0_GetFishQuality;

	private static DelegateBridge __Hotfix0_UpdateRankingData;

	private static DelegateBridge __Hotfix0_UpdateLureData;

	private static DelegateBridge __Hotfix0_UpdateTaskData;

	private static DelegateBridge __Hotfix0_UpdateGiftData;

	private static DelegateBridge __Hotfix1_UpdateGiftData;

	private static DelegateBridge __Hotfix0_UpdateShopData;

	private static DelegateBridge __Hotfix1_UpdateShopData;

	private static DelegateBridge __Hotfix0_UpdateNeedClearRodProp;

	private static DelegateBridge __Hotfix0_UpdateRelicsAddLureProp;

	private static DelegateBridge __Hotfix0_GetFishingS3ConfigData;

	private static DelegateBridge __Hotfix0_GetFishingData;

	private static DelegateBridge __Hotfix0_GetFishingRodData;

	private static DelegateBridge __Hotfix0_GetFishingSceneData;

	private static DelegateBridge __Hotfix0_GetFishingRankingData;

	private static DelegateBridge __Hotfix0_GetFishingRankingRewardData;

	private static DelegateBridge __Hotfix0_GetFishingRodBestiaryData;

	private static DelegateBridge __Hotfix0_GetFishingBestiaryData;

	private static DelegateBridge __Hotfix0_GetFishingLureData;

	private static DelegateBridge __Hotfix0_GetFishingGiftData;

	private static DelegateBridge __Hotfix0_GetFishingTaskData;

	private static DelegateBridge __Hotfix0_GetFishingShopData;

	private static DelegateBridge __Hotfix0_RequestFishingStatus;

	private static DelegateBridge __Hotfix0_RequestFishingStart;

	private static DelegateBridge __Hotfix0_RequestFishingEnd;

	private static DelegateBridge __Hotfix0_RequestParseFishingResult;

	private static DelegateBridge __Hotfix0_RequestGiftReward;

	private static DelegateBridge __Hotfix0_RequestWelfareData;

	private static DelegateBridge __Hotfix0_RequestTaskReward;

	private static DelegateBridge __Hotfix0_RequestBoxReward;

	private static DelegateBridge __Hotfix0_RequestBuyLure;

	private static DelegateBridge __Hotfix0_RequestExchangeReward;

	private static DelegateBridge __Hotfix0_RequestRankingData;

	private static DelegateBridge __Hotfix0_RequestGiftAndShopData;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override string Name { get; }

	public float FishingHookDelayTime => 0f;

	private FishingS3ConfigData FishingS3ConfigData { get; set; }

	public int PropLureID => 0;

	public int PropFishingScoreID => 0;

	public int PropFishLineID => 0;

	public int PropFishKingScaleID => 0;

	private FishingData FishingData { get; set; }

	private FishingRodData FishingRodData { get; set; }

	private FishingSceneData FishingSceneData { get; set; }

	private FishingRankingData FishingRankingData { get; set; }

	private FishingRankingRewardData FishingRankingRewardData { get; set; }

	private FishingBestiaryData FishingBestiaryData { get; set; }

	private FishingRodBestiaryData FishingRodBestiaryData { get; set; }

	private FishingLureData FishingLureData { get; set; }

	private FishingGiftData FishingGiftData { get; set; }

	private FishingTaskData FishingTaskData { get; set; }

	private FishingShopData FishingShopData { get; set; }

	private bool HaveSyncData { get; set; }

	private bool HaveSyncConfigData { get; set; }

	private long SyncDataTime { get; set; }

	private long SyncLureDataTime { get; set; }

	private long SyncGiftDataTime { get; set; }

	private long SyncShopDataTime { get; set; }

	private bool NeedClearRodProp { get; set; }

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqGameFishing RequestPacket()
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

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, CRespGameFishing data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public void ParseConfigData()
	{
	}

	public void SyncConfigData()
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public bool IsFishingOpen()
	{
		return false;
	}

	public bool IsShoppingOpen()
	{
		return false;
	}

	public bool HaveRed()
	{
		return false;
	}

	public bool HaveBestiaryRed()
	{
		return false;
	}

	public bool HaveLureRed()
	{
		return false;
	}

	public bool HaveWelfareRed()
	{
		return false;
	}

	public bool HaveGiftRed()
	{
		return false;
	}

	public bool HaveTaskRed()
	{
		return false;
	}

	public bool HaveShopRed()
	{
		return false;
	}

	public bool HaveShopARed()
	{
		return false;
	}

	public bool HaveShopBRed()
	{
		return false;
	}

	private bool IsReachOpenCond()
	{
		return false;
	}

	public int GetTag()
	{
		return 0;
	}

	public long GetFishingTotalWeight()
	{
		return 0L;
	}

	public (bool, bool) GetSyncDataStatus()
	{
		return default;
	}

	public long GetSyncDataTime()
	{
		return 0L;
	}

	public long GetSyncLureDataTime()
	{
		return 0L;
	}

	public long GetSyncGiftDataTime()
	{
		return 0L;
	}

	public long GetSyncShopDataTime()
	{
		return 0L;
	}

	public (string, bool) GetFishingAniData(FishingRodAniStatus rodStatus)
	{
		return default;
	}

	public (string, bool) GetFishingAniData(FishingFishAniStatus fishStatus)
	{
		return default;
	}

	public string GetFishingRodSkinName(FishingRodType fishRodType)
	{
		return null;
	}

	public Color GetTipColor(int quality)
	{
		return default;
	}

	public Color GetColor(int quality)
	{
		return default;
	}

	public string GetColorValue(int quality)
	{
		return null;
	}

	public int GetColorQuality(int quality)
	{
		return 0;
	}

	public int GetFishQuality(int quality)
	{
		return 0;
	}

	public void UpdateRankingData(int curGroup, STGameFishingRank rankData)
	{
	}

	public void UpdateLureData()
	{
	}

	public void UpdateTaskData(CRespGameFishing data)
	{
	}

	public void UpdateGiftData(CRespGameFishing data)
	{
	}

	public void UpdateGiftData()
	{
	}

	public void UpdateShopData(CRespGameFishing data)
	{
	}

	public void UpdateShopData()
	{
	}

	public void UpdateNeedClearRodProp(bool needClear)
	{
	}

	public void UpdateRelicsAddLureProp(Dictionary<uint, ushort> relicsInitItem)
	{
	}

	public FishingS3ConfigData GetFishingS3ConfigData()
	{
		return null;
	}

	public FishingData GetFishingData()
	{
		return null;
	}

	public FishingRodData GetFishingRodData()
	{
		return null;
	}

	public FishingSceneData GetFishingSceneData()
	{
		return null;
	}

	public FishingRankingData GetFishingRankingData()
	{
		return null;
	}

	public FishingRankingRewardData GetFishingRankingRewardData()
	{
		return null;
	}

	public FishingRodBestiaryData GetFishingRodBestiaryData()
	{
		return null;
	}

	public FishingBestiaryData GetFishingBestiaryData()
	{
		return null;
	}

	public FishingLureData GetFishingLureData()
	{
		return null;
	}

	public FishingGiftData GetFishingGiftData()
	{
		return null;
	}

	public FishingTaskData GetFishingTaskData()
	{
		return null;
	}

	public FishingShopData GetFishingShopData()
	{
		return null;
	}

	public void RequestFishingStatus(Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestFishingStart(int lureCount, uint transID, int improveIndex, int areaID, Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestFishingEnd(int rodID, int improveIndex, uint startTransID, int areaID, Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestParseFishingResult(int lureCount, int selectLure, FishingResult result, CRespGameFishing response)
	{
	}

	public void RequestGiftReward(int rewardID, Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestWelfareData(bool isNeedMask, Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestTaskReward(int rewardID, Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestBoxReward(int rewardID, Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestBuyLure(int buyCount, Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestExchangeReward(int rewardID, int count, Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestRankingData(Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}

	public void RequestGiftAndShopData(Action<CRespGameFishing> success = null, Action<CRespGameFishing> failure = null)
	{
	}
}
