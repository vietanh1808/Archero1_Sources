using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;

public class SailingManager : CInstance<SailingManager>
{
	public enum SeasonInfoType
	{
		StaminaBuy = 2,
		StaminaGainAd = 3,
		GainBossPreviewReward = 4,
		ReqMediumViewMap = 5
	}

	public enum SailingLogType
	{
		Title = 0,
		CommonText = 1
	}

	public enum SailingLogActionType
	{
		None = 0,
		Text = 1,
		TravelMilesChange = 2,
		GetResources = 3,
		Gift = 4,
		Battle = 5,
		BattleWin = 6,
		BattleLose = 7,
		BagBattle = 8,
		BagBattleWin = 9,
		BagBattleLose = 10,
		InBattleJoin = 11,
		InactiveLogin = 12,
		TimePoint = 13
	}

	public class SailingLogItemData
	{
		public SailingLogType Type;

		public uint EventId;

		public int ActionId;

		public uint Ret;

		public int LanIndex;

		public ulong eventRefreshTime;

		public List<DropData> DropList;

		public int bpDis;

		public int talentDis;

		public SailingLogItemData Clone()
		{
			return null;
		}
	}

	public class DropData
	{
		public int type;

		public int id;

		public int count;
	}

	public List<SailingAchievementItemData> achievementDataList;

	public Dictionary<int, bool> achievementBoxDict;

	private int ArenaNoBattleTime;

	public bool ArenaRewardBoxCanGet;

	public SailingArenaItemData myRankItemData;

	public List<SailingArenaItemData> rankDataList;

	public List<SailingArenaItemData> vsDataList;

	public long ArenaFreshVSClickTime;

	public long OpenUIVSTime_Arena;

	public List<SailingArenaItemData> noteDataList;

	public SailingArenaBoxData boxArenaData;

	public List<SailingArenaRewardItemData> todayRewardPreviewList;

	public List<SailingArenaRewardItemData> seasonRewardPreviewList;

	public Dictionary<int, CommonQuickBuyItemData> quickBuyDataDict;

	private bool isHavePullData;

	public List<SailingBasicData> sailingBasicDataList;

	private SailingData sailingData;

	public string strRewardPreview;

	private List<Drop_DropModel.DropData> dropList;

	private uint preEventId;

	private uint curEventId;

	private ulong curEventRefreshTime;

	private uint curActionId;

	private uint preActionId;

	public bool NeedReOpenSailing;

	private int curShipLogParam;

	public bool IsAutoSailEvent;

	private int bagMaxDifficulty;

	private List<int> giftIdList;

	private int sailDistanceAfterAdd;

	private float preLogRetTime;

	private bool isGetResources;

	public RankType OpenShowType;

	public SailingRankingData sailingRankingData;

	private long lastReqMedMapTime;

	private ushort? m_nRewardBits;

	private int _militaryRank;

	private List<SailingGiftItemData> giftNormalItemDataList;

	private List<SailingGiftItemData> giftTimingItemDataList;

	private List<SailingGiftItemData> giftEventItemDataList;

	public List<int> currentTimingGiftList;

	public List<SailingMapItemData> mapDataList;

	public int Pre_ActivePoint;

	public string Pre_RewardPreview;

	public long Pre_RewardFlag;

	public List<SailingPreSignItemData> callDataList;

	public List<SailingShopItemData> shopADataList;

	public List<SailingShopItemData> shopBDataList;

	public int PropIdShopA;

	public int PropIdShopB;

	public int currentAchievementLevel => 0;

	public int AchievementLevelMax => 0;

	public int AchievementLevelCurrent => 0;

	public (int, int, int) GetAchievementValueCurrent => default;

	public int ArenaOpenNeedTime => 0;

	public long ArenaTimeLeft_Today => 0L;

	private long NextTimeZero => 0L;

	private int ArenaVSFreshNeedTime => 0;

	private int FreshVSLeftTime_Arena => 0;

	public bool checkCanClickFresh_Arena => false;

	public bool checkOpenUISameDay_Arena => false;

	public long ArenaRewardGetLastTime => 0L;

	public long ArenaRewardGetLastRank => 0L;

	public List<string> yesterdayRewardList => null;

	public List<string> passRewardList => null;

	public int MyRank_Arena => 0;

	public string MyMilitary_Arena => null;

	public bool IsHaveData => false;

	public bool haveS3Data => false;

	public int CurrentTag_Local => 0;

	public int Season => 0;

	public int Distance => 0;

	public int Speed => 0;

	public float SpeedAdd => 0f;

	public CShipBattleRank[] MapShips => null;

	public ulong StaminaRankEndTime => 0uL;

	public ulong StaminaRankEndShowTime => 0uL;

	public int StaminaStage => 0;

	public long BanTime => 0L;

	public int CampCurrent => 0;

	public SailingData sailActData => null;

	public SailingSeasonStage CurrentSeasonStage => SailingSeasonStage.Unknown;

	public SailingWarStage CurrentWarStage => SailingWarStage.Unknown;

	public SailingWarEventType CurrentWarEventType => SailingWarEventType.None;

	public long TimeLeft => 0L;

	public long WarBeginTime => 0L;

	public int WarDayCurrent => 0;

	public long TimeLeft_Sign => 0L;

	public long TimeLeft_War => 0L;

	public long TimeLeft_WarStage => 0L;

	public long TimeLeft_Reward => 0L;

	public bool isSeasonStage_War => false;

	public bool isSeasonStage_Reward => false;

	public bool IsStageWar => false;

	public int StaminaPurchasedCount => 0;

	public int AdWatchedCount => 0;

	public int CurStamina => 0;

	public int StaminaMax => 0;

	public int StaminaAddPerPurchase => 0;

	public int StaminaPurchaseTimesMax => 0;

	public int StaminaAddPerAd => 0;

	public int StaminaWatchAdTimesMax => 0;

	public int StaminaNeededPerBattle => 0;

	public List<Drop_DropModel.DropData> DropList => null;

	public uint PreEventId => 0u;

	public uint CurEventId => 0u;

	public int CurActionType => 0;

	public int CurEventType => 0;

	public ulong CurEventRefreshTime => 0uL;

	public uint CurActionId => 0u;

	public uint PreActionId => 0u;

	public int CurBagDifficultyId => 0;

	public int SailingDisAdd => 0;

	public int BagMaxDifficulty => 0;

	public List<int> GiftIdList => null;

	public int SailDistanceAfterAdd => 0;

	public float PreLogRetTime => 0f;

	public bool IsGetResources => false;

	public bool HaveRewardData => false;

	public int MilitaryRank => 0;

	public int MilitaryRankExp => 0;

	public bool IsMilitaryRankMax => false;

	public int Zone => 0;

	public int SubZone => 0;

	public string MilitaryRankName => null;

	public Sprite MilitaryRankIcon => null;

	public Sprite MilitarySubRankIcon => null;

	public SailingAttribute SailingAttribute => null;

	private int myCamp => 0;

	private int CampChangeValue => 0;

	public SailingMapItemData GetMapItemData_Me => null;

	public void requestAchievementInfo(Action<CRespShipBattleSeasonAchieve, int> action = null)
	{
	}

	public void requestAchievementGet(int achid, Action<CRespShipBattleSeasonAchieve, int> action = null)
	{
	}

	public void requestAchievementBoxGet(int level, Action<CRespShipBattleSeasonAchieve, int> action = null)
	{
	}

	public List<SailingAchievementItemData> GetAchievementShowList()
	{
		return null;
	}

	private void parseAchievementData(CRespShipBattleSeasonAchieve data)
	{
	}

	private void parseAchievementBoxDict(CRespShipBattleSeasonAchieve data)
	{
	}

	private int GetAchievementTypeByID(int achid)
	{
		return 0;
	}

	private SailingAchievementItemData GetAchievementItemData(int type)
	{
		return null;
	}

	private List<ShipBattle_ShipAchieve> GetAchieveDataListByType(int type)
	{
		return null;
	}

	public (int, int, int) GetAchievementValue(int count)
	{
		return default;
	}

	public List<SailingAchievementBoxItemData> GetAchiBoxDataList()
	{
		return null;
	}

	public bool isAchiBoxHaveGet(int level)
	{
		return false;
	}

	public bool isAchiBoxCanGet(int level)
	{
		return false;
	}

	public bool isHaveAchiTaskCanGet()
	{
		return false;
	}

	public bool isHaveAchiBoxCanGet()
	{
		return false;
	}

	public bool isShowRedPoint_Achi()
	{
		return false;
	}

	public bool checkArenaPower()
	{
		return false;
	}

	public bool checkArenaOpenTime()
	{
		return false;
	}

	public bool isOpenArena()
	{
		return false;
	}

	public bool isArenaSameDay()
	{
		return false;
	}

	public bool checkArenaNoBattleTime()
	{
		return false;
	}

	public void requestArenaInfo(Action<CRespShipBattleSeasonArena, int> action = null)
	{
	}

	private void parseArenaBasicData(CRespShipBattleSeasonArena data)
	{
	}

	private void parseArenaRankData(CRespShipBattleSeasonArena data)
	{
	}

	public List<SailingArenaItemData> GetArenaRankTopList()
	{
		return null;
	}

	public List<SailingArenaItemData> GetArenaRankBottomList()
	{
		return null;
	}

	public void requestArenaVS(Action<CRespShipBattleSeasonArena, int> action = null)
	{
	}

	private void parseArenaVSData(CRespShipBattleSeasonArena data)
	{
	}

	public void requestArenaNote(Action<CRespShipBattleSeasonArena, int> action = null)
	{
	}

	private void parseArenaNoteData(CRespShipBattleSeasonArena data)
	{
	}

	public void requestArenaIsRewardBox(Action<CRespShipBattleSeasonArena, int> action = null)
	{
	}

	public void requestArenaBox(Action<CRespShipBattleSeasonArena, int> action = null)
	{
	}

	private void parseArenaBoxData(CRespShipBattleSeasonArena data)
	{
	}

	private void parseArenaRewardPreviewData(CRespShipBattleSeasonArena data)
	{
	}

	public void requestArenaQuickBuy(int count, Action<CRespShipBattleSeasonArena, int> action = null)
	{
	}

	private void parseQuickBuyData(CRespShipBattleSeasonArena data)
	{
	}

	public CommonQuickBuyItemData GetArenaQuickItemData()
	{
		return null;
	}

	public void beginBattle_Arena(ulong enemyID)
	{
	}

	public void endBattle_Arena()
	{
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	private void OnCurrencyChanged(CurrencyType type, int old, int current)
	{
	}

	public void ReqS3()
	{
	}

	public void parseJsonBasicData()
	{
	}

	private List<SailingBasicData> getBasicDataList()
	{
		return null;
	}

	public SailingBasicData GetBasicDataOne(int tag)
	{
		return null;
	}

	public bool isOpenAct()
	{
		return false;
	}

	public bool checkIconCanShow()
	{
		return false;
	}

	public bool checkIconShow()
	{
		return false;
	}

	public bool checkOpen_Level()
	{
		return false;
	}

	public bool checkOpen_ToServer()
	{
		return false;
	}

	public long GetSailingWarStageEndTime(SailingWarStage stage)
	{
		return 0L;
	}

	public long GetRankShowTime(SailingWarStage stage, int type, int timeType)
	{
		return 0L;
	}

	public int GetStageByType(RankType type)
	{
		return 0;
	}

	public long GetMeterEventTime(int timeType, int activityType)
	{
		return 0L;
	}

	public void RequestSeasonInfo(int type, Action<bool> action = null)
	{
	}

	public int GetStaminaPurchasePrice(int hasBuyTimes)
	{
		return 0;
	}

	public string GetSailLogDropInfo()
	{
		return null;
	}

	public void BagBattleEnd(ushort type)
	{
	}

	public void ReqPreLog()
	{
	}

	public void StartSailing()
	{
	}

	public void TriggerEvent(ushort type, uint m_nEventID, uint actionId, Action action = null)
	{
	}

	public void ResetSailingLogData()
	{
	}

	public void RequestRankInfo(Action<SailingRankingData, int> action = null, RankType type = RankType.Stamina)
	{
	}

	private SailingRankingData ParseRankingData(CRespShipBattleSeasonRank data)
	{
		return null;
	}

	public void enterGame(Action<bool> action = null)
	{
	}

	public void enterUISign(Action<bool> action)
	{
	}

	public void enterUIMain(Action<bool> action)
	{
	}

	public void ReqMedMapInfo(Action reqSuccess = null, Action reqFailure = null)
	{
	}

	public void requestSeasonInfo(Action<CRespShipBattleSeasonInfo, int> action = null)
	{
	}

	public bool Claimed(int id)
	{
		return false;
	}

	public void RequestTreasureMap(Action callback, bool force = false)
	{
	}

	public void ClaimTreasureMapReward(int id, Action<bool, int> callback)
	{
	}

	public string GetMilitaryRankNameById(int peerId)
	{
		return null;
	}

	public void UpgradeMilitaryRank(Action<int> callback)
	{
	}

	public GameObject GetSailingMapObj()
	{
		return null;
	}

	public bool IsRegisterAndInBattle()
	{
		return false;
	}

	public bool isOpenSailing()
	{
		return false;
	}

	public bool checkSailingOpen_Level()
	{
		return false;
	}

	public int GetResourceCount(CurrencyType type)
	{
		return 0;
	}

	public void SetResourceCount(CurrencyType type, int count)
	{
	}

	public void changeResourceCount(CurrencyType type, int offset)
	{
	}

	private void InitDropList(uint[][] arr)
	{
	}

	private void showRewardWindow(STCommonData stcd, string title = "")
	{
	}

	public void RequestBagBattle(int id, int type, Action gotoBattle)
	{
	}

	public void SendGameOverBagBattle(ushort resultType, int difficultId, int battleType, List<Drop_DropModel.DropData> list = null, CEquipmentItem[] arrayEquipItems = null)
	{
	}

	public void showPlayerInfoWindow(ulong userid)
	{
	}

	public int GetAllPower()
	{
		return 0;
	}

	public void requestGiftInfo(Action<CRespShipBattleSeasonGift, int> action = null)
	{
	}

	public void requestGiftBuy(int type, int gid, Action<CRespShipBattleSeasonGift, int> action = null)
	{
	}

	public void requestGiftTrigger(int gid, Action<CRespShipBattleSeasonGift, int> action = null)
	{
	}

	private void parseGiftListData(CRespShipBattleSeasonGift data, int type)
	{
	}

	public void openGiftEventWindow(List<int> list)
	{
	}

	public List<SailingGiftItemData> GetGiftEventShowList(List<int> list, bool checkCount = false)
	{
		return null;
	}

	public List<SailingGiftItemData> GetGiftNormalShowList(int stype)
	{
		return null;
	}

	public List<SailingGiftItemData> GetGiftTimingShowList(List<int> list, bool checkCount = false)
	{
		return null;
	}

	public void checkGiftPushForTime()
	{
	}

	public void checkGiftPushForShip(int ship, int level)
	{
	}

	public void checkGiftPushForBattle(int power)
	{
	}

	public void checkGiftPushForMilitary(int level)
	{
	}

	private int GetShowCamp(int camp)
	{
		return 0;
	}

	public Vector2Int GetPlayerPosition(SailingMapItemData data, int from, int to, int fromr, int tor)
	{
		return default;
	}

	public SailingMapItemData GetMapItemDataOne(ulong userid)
	{
		return null;
	}

	public int GetWarStepArrived(SailingWarStage stage)
	{
		return 0;
	}

	public void requestMapPreviewInfo(Action<CRespShipBattleSeasonRank, int> action = null)
	{
	}

	private void parseRankData(CRespShipBattleSeasonRank data)
	{
	}

	public void requestSignUp(Action<CRespShipBattleSeasonInfo, int> action = null)
	{
	}

	public void requestPreRewardData(Action<CRespShipBattleSeasonPreReward, int> action = null)
	{
	}

	public void requestPreRewardGet(int rid, Action<CRespShipBattleSeasonPreReward, int> action = null)
	{
	}

	public void requestPreActivePointBuy(int rid, Action<CRespShipBattleSeasonPreReward, int> action = null)
	{
	}

	public bool checkBoxGetReward(int id)
	{
		return false;
	}

	private bool checkBoxGetReward(long flag, int index)
	{
		return false;
	}

	public SailingPreSignItemData GetPreCallData(int level)
	{
		return null;
	}

	public int GetPreHaveUnlockID()
	{
		return 0;
	}

	public int GetActionLevel()
	{
		return 0;
	}

	public (int, int, int) GetActivePointCurrentValue()
	{
		return default;
	}

	public bool canHaveRewardGet_Pre()
	{
		return false;
	}

	public void requestShopInfo(Action<CRespShipBattleSeasonStore, int> action = null)
	{
	}

	private void parseShopData(CRespShipBattleSeasonStore data, int type)
	{
	}

	public void requestShopItemBuy(int type, int sid, int count, Action<CRespShipBattleSeasonStore, int> action = null)
	{
	}

	public SailingShopItemData GetShopDataItemData(int type, int sid)
	{
		return null;
	}

	public bool CanExchange_Shop(int type)
	{
		return false;
	}
}
