using System;
using System.Collections.Generic;
using GameProtocol;
using XLua;

public class CampTileManager : CInstance<CampTileManager>
{
	public const float ArrowCountClickWaitTime = 0.2f;

	public const float ArrowCountChangeMaxTime = 0.4f;

	public const float ArrowCountChangeMaxSpeed = 7f;

	public const int ArrowBuyOneCount = 1;

	public const int ArrowBuyMoreCount = 10;

	public const int ArrowDamageDataConfigID = 3244;

	public const int ArrowBPAddDamageTypeID = 7;

	public const int ArrowBPGatherAllResourceID = 9;

	public const float BossFinalBoxScale = 1.7f;

	public const float BossProgressMinSize = 0.12f;

	public const float BattleProgressMinSize = 0.3f;

	public const float BossProgressRewardIntervalValue = 0.25f;

	public const int BossProgressAverageCount = 4;

	public const int BossProgressBannerCount = 3;

	public const int BossRankMaxNum = 3;

	public const int BossDefenderHeadIconConfigID = 3278;

	public const int BossDefenderNeedValueConfigID = 3279;

	public const int BossFinalChestYOffset = 55;

	public const int BossFinalChestXOffset = 20;

	public const float CampTileContributeDiffWidth = 60f;

	public const string BossDefenderIsAttackingIconBgName = "CampTile_Boss_MonsterAttackBg";

	public const string BossDefenderNormalIconBgName = "CampTile_Boss_MonsterNormalBg";

	public const string BossRankCampIconName = "CampTile_Boss_Camp";

	public const string CampTileRankIconStyle = "CampTile_RankIcon_Style";

	public const string BossNormalChestName = "CampTile_Boss_Box";

	public const string BossNormalChestClaimedName = "CampTile_Boss_BoxClaimed";

	public const string BossFinalChestName = "CampTile_Boss_FinalBox";

	public const string BossFinalChestClaimedName = "CampTile_Boss_FinalBoxClaimed";

	public const string BossIdleAniName = "monster_Idle";

	public const string BossDeathAniName = "monster_Death";

	public const string BossDeathIdleAniName = "monster_Death_Idle";

	public const string BtnArrowBg = "Yellow_Bt";

	public const string BtnBattleBg = "Green_Bt";

	public const string BtnSweepBg = "Blue_Bt";

	public const float AniProgressWidthTime = 0.5f;

	public const float AniRollNumTime = 0.5f;

	public const float AniFlyNumTime = 0.5f;

	public const float AniFlyNumHeight = 50f;

	public const float AniProgressAllTime = 1f;

	public const float AniShakeTargetStrength = 14f;

	public const float AniShakeTargetTime = 1.2f;

	public const float AniArrowFlyTime = 0.55f;

	public const float AniArrowSendInterval = 0.2f;

	public const float AniArrowFlyXStrength = 120f;

	public const float AniArrowFlyYStrength = 30f;

	public const int MaxShowReturnCount = 20;

	public const string ProgressNamePrefix = "CampTile_Camp";

	public const string ProgressIconNamePrefix = "CampTile_OccupyType_";

	public const string HeroDispatchCurResourceIcon = "CampTile_DispatchCurrent";

	public const string HeroDispatchOtherResourceIcon = "CampTile_DispatchOther";

	public const string CampFlagName = "camp_rank_flag";

	public const float RewardScale = 0.8f;

	private static DelegateBridge __Hotfix0_get_ArrowCriticalProb;

	private static DelegateBridge __Hotfix0_ArrowRangeAddDamage;

	private static DelegateBridge __Hotfix0_get_BPAddArrowDamagePercent;

	private static DelegateBridge __Hotfix0_ArrowDamage;

	private static DelegateBridge __Hotfix0_ArrowRangeDamage;

	private static DelegateBridge __Hotfix0_get_ArrowBaseDamage;

	private static DelegateBridge __Hotfix0_ArrowBaseDamageAdd;

	private static DelegateBridge __Hotfix0_ArrowShowDamage;

	private static DelegateBridge __Hotfix0_get_TalentAddArrowDamage;

	private static DelegateBridge __Hotfix0_get_TalentAddArrowDamagePercent;

	private static DelegateBridge __Hotfix0_TileAddArrowDamagePercent;

	private static DelegateBridge __Hotfix0_get_OneIronArrowDiamondPrice;

	private static DelegateBridge __Hotfix0_get_CanBuyIronArrowMaxCount;

	private static DelegateBridge __Hotfix0_get_SendArrowMaxCountOnce;

	private static DelegateBridge __Hotfix0_get_OneIronArrowDiamondPriceAfterGod;

	private static DelegateBridge __Hotfix0_get_CanBuyIronArrowMaxCountAfterGod;

	private static DelegateBridge __Hotfix0_get_BattleNeedActionPower;

	private static DelegateBridge __Hotfix0_get_MonsterLairMaxAttackCount;

	private static DelegateBridge __Hotfix0_get_HolyLandBattleTime;

	private static DelegateBridge __Hotfix0_get_HolyLandOccupiedTime;

	private static DelegateBridge __Hotfix0_get_ResourceMinGatherTime;

	private static DelegateBridge __Hotfix0_get_ResourceMaxGatherTime;

	private static DelegateBridge __Hotfix0_get_HeroDispatchMaxCount;

	private static DelegateBridge __Hotfix0_get_TileModelData;

	private static DelegateBridge __Hotfix0_set_TileModelData;

	private static DelegateBridge __Hotfix0_get_ArrowHaveBuyCount;

	private static DelegateBridge __Hotfix0_set_ArrowHaveBuyCount;

	private static DelegateBridge __Hotfix0_get_ArrowLastBuyTime;

	private static DelegateBridge __Hotfix0_set_ArrowLastBuyTime;

	private static DelegateBridge __Hotfix0_get_HaveSyncHeroDispatchData;

	private static DelegateBridge __Hotfix0_set_HaveSyncHeroDispatchData;

	private static DelegateBridge __Hotfix0_get_HaveSyncResourceData;

	private static DelegateBridge __Hotfix0_set_HaveSyncResourceData;

	private static DelegateBridge __Hotfix0_get_HaveSyncArrowData;

	private static DelegateBridge __Hotfix0_set_HaveSyncArrowData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Clear;

	private static DelegateBridge __Hotfix0_GetTileModelData;

	private static DelegateBridge __Hotfix1_GetTileModelData;

	private static DelegateBridge __Hotfix2_GetTileModelData;

	private static DelegateBridge __Hotfix0_GetOutputTypeByResourceType;

	private static DelegateBridge __Hotfix0_BattleTime;

	private static DelegateBridge __Hotfix0_IsCampBattleOpen;

	private static DelegateBridge __Hotfix0_IsOpenTime;

	private static DelegateBridge __Hotfix0_LeftUnOpenTime;

	private static DelegateBridge __Hotfix0_IsCloseTime;

	private static DelegateBridge __Hotfix0_IsSelfCampReachUnlockCond;

	private static DelegateBridge __Hotfix0_IsTileOccupied;

	private static DelegateBridge __Hotfix0_IsTileHaveOccupyReward;

	private static DelegateBridge __Hotfix0_IsResourceTileCanGather;

	private static DelegateBridge __Hotfix0_IsResourceTileCanGatherShowTip;

	private static DelegateBridge __Hotfix0_GetResourceTileProgress;

	private static DelegateBridge __Hotfix0_ResourceTileProgress;

	private static DelegateBridge __Hotfix0_HaveResourceNotReachMaxStore;

	private static DelegateBridge __Hotfix1_HaveResourceNotReachMaxStore;

	private static DelegateBridge __Hotfix0_IsResourceNotReachMaxStore;

	private static DelegateBridge __Hotfix1_IsResourceNotReachMaxStore;

	private static DelegateBridge __Hotfix0_GetResourceStoreMaxCount;

	private static DelegateBridge __Hotfix0_GetResourceTileOutputRewards;

	private static DelegateBridge __Hotfix0_ShowTileWindow;

	private static DelegateBridge __Hotfix0_GetArrowDamageData;

	private static DelegateBridge __Hotfix0_GetArrowHaveBuyCount;

	private static DelegateBridge __Hotfix0_GetArrowLastBuyTime;

	private static DelegateBridge __Hotfix0_UpdateArrowData;

	private static DelegateBridge __Hotfix0_SendAttackDataWithRefresh;

	private static DelegateBridge __Hotfix0_SendAttackDataWithoutRefresh;

	private static DelegateBridge __Hotfix0_GetHeadIconID;

	private static DelegateBridge __Hotfix0_RefreshCampData;

	private static DelegateBridge __Hotfix0_GetBattleInfo;

	private static DelegateBridge __Hotfix0_GetHeroDispatchStatus;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_GetReturnArrowData;

	private static DelegateBridge __Hotfix0_SendPlayAni;

	private static DelegateBridge __Hotfix0_GetTileBattleStatus;

	private static DelegateBridge __Hotfix0_GetBattleLeftTime;

	private static DelegateBridge __Hotfix0_GetOccupiedLeftTime;

	private static DelegateBridge __Hotfix0_GetTileOpenStatus;

	private static DelegateBridge __Hotfix0_GetTileChineseName;

	private static DelegateBridge __Hotfix0_GetResourceChineseName;

	private static DelegateBridge __Hotfix0_GetCampTileArrowDamageData;

	private static DelegateBridge __Hotfix0_GetArrowAttackDamage;

	private static DelegateBridge __Hotfix0_GetArrowStatusCount;

	private static DelegateBridge __Hotfix0_GetArrowCriticalProb;

	private static DelegateBridge __Hotfix0_GetArrowCriticalRangeDamage;

	private static DelegateBridge __Hotfix0_GetArrowUnCriticalRangeDamage;

	private static DelegateBridge __Hotfix0_GetArrowShowDamage;

	private static DelegateBridge __Hotfix0_GetArrowDamage;

	private static DelegateBridge __Hotfix0_GetArrowRangeDamage;

	private static DelegateBridge __Hotfix0_GetArrowMinDamage;

	private static DelegateBridge __Hotfix0_GetArrowMaxDamage;

	private static DelegateBridge __Hotfix0_GetTileAddArrowDamagePercent;

	private static DelegateBridge __Hotfix0_RequestTileInfo;

	private static DelegateBridge __Hotfix0_RequestDispatchHero;

	private static DelegateBridge __Hotfix0_RequestUnDispatchHero;

	private static DelegateBridge __Hotfix0_RequestResourceGather;

	private static DelegateBridge __Hotfix0_RequestSendArrow;

	private static DelegateBridge __Hotfix0_RequestBuyArrow;

	private static DelegateBridge __Hotfix0_RequestArrowData;

	private static DelegateBridge __Hotfix0_RequestHeroDispatch;

	private static DelegateBridge __Hotfix0_RequestResourceData;

	private static DelegateBridge __Hotfix0_RequestSweep;

	private static DelegateBridge __Hotfix0_RequestBattle;

	private static DelegateBridge __Hotfix0_RequestBossProgressReward;

	private static DelegateBridge __Hotfix0_GetTileType;

	private static DelegateBridge __Hotfix0_GetTileRestriction;

	private static DelegateBridge __Hotfix0_GetTileOperationType;

	private static DelegateBridge __Hotfix0_GetTileOccupyAttackType;

	private static DelegateBridge __Hotfix0_GetTileResourceType;

	private static DelegateBridge __Hotfix0_GetCampTileOpenCond;

	private static DelegateBridge __Hotfix0_GetBossBattleStatus;

	private static DelegateBridge _c__Hotfix0_ctor;

	public (float, float) ArrowCriticalProb => default;

	public float BPAddArrowDamagePercent => 0f;

	public float ArrowBaseDamage => 0f;

	public float TalentAddArrowDamage => 0f;

	public float TalentAddArrowDamagePercent => 0f;

	public float OneIronArrowDiamondPrice => 0f;

	public float CanBuyIronArrowMaxCount => 0f;

	public float SendArrowMaxCountOnce => 0f;

	public float OneIronArrowDiamondPriceAfterGod => 0f;

	public float CanBuyIronArrowMaxCountAfterGod => 0f;

	public int BattleNeedActionPower => 0;

	public int MonsterLairMaxAttackCount => 0;

	public long HolyLandBattleTime => 0L;

	public long HolyLandOccupiedTime => 0L;

	public long ResourceMinGatherTime => 0L;

	public long ResourceMaxGatherTime => 0L;

	public int HeroDispatchMaxCount => 0;

	private Dictionary<int, CampTileModelData> TileModelData { get; set; }

	private int ArrowHaveBuyCount { get; set; }

	private long ArrowLastBuyTime { get; set; }

	private bool HaveSyncHeroDispatchData { get; set; }

	private bool HaveSyncResourceData { get; set; }

	private bool HaveSyncArrowData { get; set; }

	public (float, float) ArrowRangeAddDamage(bool isCritical)
	{
		return default;
	}

	public float ArrowDamage(CampTileArrowType type, bool isCritical, CampTileType tileType, CampTileResourceType resourceType)
	{
		return 0f;
	}

	public (float, float) ArrowRangeDamage(CampTileArrowType type, bool isCritical, CampTileType tileType, CampTileResourceType resourceType)
	{
		return default;
	}

	public float ArrowBaseDamageAdd(CampTileArrowType type)
	{
		return 0f;
	}

	public float ArrowShowDamage(CampTileArrowType type)
	{
		return 0f;
	}

	public float TileAddArrowDamagePercent(CampTileType tileType, CampTileResourceType resourceType)
	{
		return 0f;
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public CampTileModelData GetTileModelData(int xPos, int yPos)
	{
		return null;
	}

	public CampTileModelData GetTileModelData((int, int) posData)
	{
		return null;
	}

	public CampTileModelData GetTileModelData(int tileID)
	{
		return null;
	}

	public CampTileOutputResourceType GetOutputTypeByResourceType(CampTileResourceType tileResourceType)
	{
		return CampTileOutputResourceType.None;
	}

	public long BattleTime()
	{
		return 0L;
	}

	public bool IsCampBattleOpen()
	{
		return false;
	}

	public bool IsOpenTime(int openTime, int xPos, int yPos)
	{
		return false;
	}

	public long LeftUnOpenTime(int openTime)
	{
		return 0L;
	}

	public bool IsCloseTime(int closeTime)
	{
		return false;
	}

	public bool IsSelfCampReachUnlockCond(int xPos, int yPos)
	{
		return false;
	}

	public bool IsTileOccupied(int x, int y)
	{
		return false;
	}

	public bool IsTileHaveOccupyReward(int xPos, int yPos)
	{
		return false;
	}

	public bool IsResourceTileCanGather(int xPos, int yPos)
	{
		return false;
	}

	public bool IsResourceTileCanGatherShowTip(int xPos, int yPos)
	{
		return false;
	}

	public int GetResourceTileProgress(int xPos, int yPos)
	{
		return 0;
	}

	public (float, float) ResourceTileProgress(int xPos, int yPos)
	{
		return default;
	}

	public (CurrencyType, bool) HaveResourceNotReachMaxStore(int xPos, int yPos)
	{
		return default;
	}

	public (CurrencyType, bool) HaveResourceNotReachMaxStore(CampTileResourceType resourceType)
	{
		return default;
	}

	private (CurrencyType, bool) IsResourceNotReachMaxStore(CampTileResourceType resourceType)
	{
		return default;
	}

	public (CurrencyType, bool) IsResourceNotReachMaxStore(CurrencyType currencyType)
	{
		return default;
	}

	public int GetResourceStoreMaxCount(CurrencyType type)
	{
		return 0;
	}

	public (CampTileOutputResourceType, float) GetResourceTileOutputRewards(CampTileResourceType resourceType, int xPos, int yPos)
	{
		return default;
	}

	public void ShowTileWindow(CampTileType tileType, CampTileParseData parseData, CRespCampBlock response)
	{
	}

	public List<CampTileArrowDamageData> GetArrowDamageData(List<CampTileArrowDamageData> arrowDamageData, int realIronArrowCount, int realGoldArrowCount, int serverTotalDamage, CampTileType tileType, CampTileResourceType resourceType)
	{
		return null;
	}

	public int GetArrowHaveBuyCount()
	{
		return 0;
	}

	public long GetArrowLastBuyTime()
	{
		return 0L;
	}

	public void UpdateArrowData(int haveBuyCount, long buyTime)
	{
	}

	public void SendAttackDataWithRefresh((int, int) position, CampID occupyCamp, bool needRefreshResetTime, uint[] occupyValue, int addAttackCount, int recordBossStage, int[] recordBossMonsterOccupyValue, int[] recordBossCampRank, int[] recordBossCampScore, long bossDeadTime)
	{
	}

	public void SendAttackDataWithoutRefresh((int, int) position, CampID occupyCamp, bool needRefreshResetTime, uint[] occupyValue, int addAttackCount, int bossStage, int[] bossMonsterOccupyValue, int[] bossCampRank, int[] bossCampScore, long bossDeadTime)
	{
	}

	public int GetHeadIconID(LocalSave.CharacterOne dispatchHeroData)
	{
		return 0;
	}

	public void RefreshCampData(CampID occupyCampID, bool needRefresh, int xPos, int yPos)
	{
	}

	public (BattleType, int) GetBattleInfo(int xPos, int yPos, CampID attackBossDefenderCamp)
	{
		return default;
	}

	public HeroDispatchStatus GetHeroDispatchStatus(int heroID)
	{
		return HeroDispatchStatus.None;
	}

	public void PlayAni(CRespCampBlock response, int totalDamage, int[] recordOccupyValue, CampID recordOccupyCamp, int needValue, bool haveOccupied, int oldLevel, (int, int) position, bool calcAttackNum, List<CampTileArrowDamageData> damageData, CampTileOccupyAttackType attackType, int returnIronArrow, int returnGoldArrow, int recordBossStage, int[] recordBossMonsterOccupyValue, int attackMonsterCampID, int[] recordBossCampRank, int[] recordBossCampScore)
	{
	}

	public List<CampTileReturnArrowData> GetReturnArrowData(int returnCount, bool isisGoldArrow)
	{
		return null;
	}

	private void SendPlayAni(CRespCampBlock response, int oldLevel, List<CampTileArrowDamageData> damageData, CampTileOccupyAttackType attackType, int returnIronArrow, int returnGoldArrow, CampID recordOccupyCamp, int attackMonsterCampID)
	{
	}

	public CampTileBattleStatus GetTileBattleStatus(int xPos, int yPos, bool filterSelfCamp)
	{
		return CampTileBattleStatus.None;
	}

	public long GetBattleLeftTime(int xPos, int yPos)
	{
		return 0L;
	}

	public long GetOccupiedLeftTime(int xPos, int yPos)
	{
		return 0L;
	}

	public CampTileStatus GetTileOpenStatus(int xPos, int yPos)
	{
		return CampTileStatus.None;
	}

	public string GetTileChineseName(CampTileType tileType, CampTileResourceType resourceType)
	{
		return null;
	}

	public string GetResourceChineseName(CampTileResourceType resourceType)
	{
		return null;
	}

	private List<CampTileArrowDamageData> GetCampTileArrowDamageData(CampTileArrowType arrowType, (int, int) arrowCount, (int, int) arrowAllDamage, int diffDamage, CampTileType tileType, CampTileResourceType resourceType)
	{
		return null;
	}

	private (int, int) GetArrowAttackDamage(CampTileArrowType arrowType, (int, int) statusCount, CampTileType tileType, CampTileResourceType resourceType)
	{
		return default;
	}

	private (int, int) GetArrowStatusCount(int curArrowTypeAllCount)
	{
		return default;
	}

	private (float, float) GetArrowCriticalProb()
	{
		return default;
	}

	private (float, float) GetArrowCriticalRangeDamage()
	{
		return default;
	}

	private (float, float) GetArrowUnCriticalRangeDamage()
	{
		return default;
	}

	private float GetArrowShowDamage(CampTileArrowType type)
	{
		return 0f;
	}

	private float GetArrowDamage(CampTileArrowType type, bool isCritical, CampTileType tileType, CampTileResourceType resourceType)
	{
		return 0f;
	}

	private (float, float) GetArrowRangeDamage(CampTileArrowType type, bool isCritical, CampTileType tileType, CampTileResourceType resourceType)
	{
		return default;
	}

	private float GetArrowMinDamage(CampTileArrowType type, bool isCritical, CampTileType tileType, CampTileResourceType resourceType)
	{
		return 0f;
	}

	private float GetArrowMaxDamage(CampTileArrowType type, bool isCritical, CampTileType tileType, CampTileResourceType resourceType)
	{
		return 0f;
	}

	private float GetTileAddArrowDamagePercent(CampTileType tileType, CampTileResourceType resourceType)
	{
		return 0f;
	}

	public void RequestTileInfo(int xPos, int yPos, CampTileType campTileType, Action<CRespCampBlock> success = null, Action<CRespCampBlock> failure = null)
	{
	}

	public void RequestDispatchHero(int xPos, int yPos, int heroID, Action<CRespCampBlock> success = null, Action failure = null)
	{
	}

	public void RequestUnDispatchHero(int xPos, int yPos, int heroID, Action<CRespCampBlock> success = null, Action failure = null)
	{
	}

	public void RequestResourceGather(int xPos, int yPos, Action<CRespCampBlock> success = null, Action<CRespCampBlock> failure = null)
	{
	}

	public void RequestSendArrow(int xPos, int yPos, int ironArrowCount, int goldArrowCount, Action<CRespCampBlock> success = null, Action<CRespCampBlock> failure = null)
	{
	}

	public void RequestBuyArrow(int buyIronArrowCount, Action success = null, Action failure = null)
	{
	}

	public void RequestArrowData(Action success = null, Action failure = null)
	{
	}

	public void RequestHeroDispatch(Action success = null, Action failure = null)
	{
	}

	public void RequestResourceData(Action success = null, Action failure = null)
	{
	}

	public void RequestSweep(int xPos, int yPos, Action<CRespCampBlock> success = null, Action<CRespCampBlock> failure = null)
	{
	}

	public void RequestBattle(uint battleTransID, int tileIndex, Action<CRespCampSeasonBattle> success = null, Action<CRespCampSeasonBattle> failure = null)
	{
	}

	public void RequestBossProgressReward(int id, (int, int) position, Action<CRespCampBlock> success = null, Action failure = null)
	{
	}

	private CampTileType GetTileType(int buildingType)
	{
		return CampTileType.None;
	}

	private (CampTileOperationRestriction, CampTileOccupyRestriction) GetTileRestriction(int buildingType)
	{
		return default;
	}

	private CampTileOperationType GetTileOperationType(int buildingType)
	{
		return CampTileOperationType.None;
	}

	private CampTileOccupyAttackType GetTileOccupyAttackType(int[] battleType)
	{
		return CampTileOccupyAttackType.None;
	}

	private CampTileResourceType GetTileResourceType(int buildingType)
	{
		return CampTileResourceType.None;
	}

	private CampTileOpenCond GetCampTileOpenCond(int buildingType)
	{
		return CampTileOpenCond.None;
	}

	public BossBattleStatus GetBossBattleStatus(int bossBattleState)
	{
		return BossBattleStatus.None;
	}
}
