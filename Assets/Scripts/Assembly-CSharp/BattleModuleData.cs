using System;
using System.Collections.Generic;
using CampBattle;
using CodeStage.AntiCheat.ObscuredTypes;
using GameProtocol;
using TableTool;
using UnityEngine;

public class BattleModuleData
{
	public enum UseRebornType
	{
		None = 0,
		Free = 1,
		Diamond = 2,
		Ad = 3,
		AFuReviveSkill = 4,
		Locket = 5,
		Evil = 6,
		SphereFlash = 7,
		Relics = 8,
		TigerPVP = 9,
		PinkCat = 10,
		PhoenixSkill = 11,
		LanceShieldSkin = 12
	}

	public class DailyType
	{
		public const int NewPlay120 = 120;
	}

	public class CheatData
	{
		public string attr;

		public int cheat_type;

		public float value_ok;

		public float value_cheat;
	}

	public class KillMonsterData
	{
		public int id;

		public int num;
	}

	public enum CD_TIME_TYPE
	{
		CdTime_None = 0,
		CdTime_Strenth_Hero = 1,
		CdTime_Strenth_Monster = 2,
		CdTime_KillAll = 3
	}

	public enum TryPlayMode
	{
		None = 0,
		Hero = 1,
		Wing = 2,
		Artifact = 3
	}

	public class MagicianData
	{
		public uint[] m_vecGridEvents;

		public uint[][] m_vecProducts;

		public uint m_nFloorPer;

		public uint[][] m_vecSpend;

		public uint[][] m_vecDiscountSpend;

		public uint[][][] m_vecPreviewProducts;

		public bool _HasEnter;

		public bool _HasShownInThisStage;
	}

	public enum EventPowerDiffculty
	{
		Lv1 = 1,
		Lv2 = 2,
		Lv3 = 3,
		Lv4 = 4,
		Lv5 = 5,
		Lv6 = 6,
		Lv7 = 7
	}

	public const int FETTER_BADGE_ID = 31002;

	public UseRebornType BattleUseRebornType;

	public int BattleUseRebornCount;

	private DxxInt layer;

	private DxxLong exp;

	private DxxLong diamond;

	private DxxLong large_diamond_item;

	private DxxLong normal_diamond_item;

	private DxxLong m_nDragonBoxItem;

	private int mLevel_CurrentStage;

	private int mLevel_CurrentStageHero;

	private int mLevel_CurrentStageHell;

	private int stageui_normal;

	private int stageui_hero;

	private int stageui_hell;

	protected ObscuredInt _battle_stage;

	private int _line;

	private int mRebornCount;

	private bool m_bRivedSkillUsed;

	private float m_fAddBabyAttackPercent;

	private DxxFloat gold;

	private float m_fTotalAddedHpMax;

	private ObscuredInt HPDropCount;

	private ObscuredInt killMonsterCount;

	public Dictionary<int, int> killMonsterDict;

	public Dictionary<string, CheatData> m_dicCheatDatas;

	public Dictionary<int, int> m_dicKilledMonsters;

	private CRespGameTowerInfo m_towerInfo;

	private int m_nTowerStrenthInterval;

	public int m_nTimes;

	private CD_TIME_TYPE m_emCdTimeType;

	private Dictionary<int, List<int>> m_dicDropedEequips;

	private List<int> m_listShouldDropEquips;

	private List<int> m_listHasDropedEquips;

	private int? m_nDropWave;

	private List<int> m_listMustDrops;

	private List<LocalSave.EquipOne> mEquips;

	private LocalSave.EquipOne coinItem;

	private int battle_ad_use_count;

	private TurnTableType mRewardType;

	private int reward_layer;

	private long BossMaxHP;

	private long BossCurrentHP;

	private Dictionary<int, int> hittedcounts;

	private Dictionary<int, int> killmonsters;

	private Dictionary<int, int> killboss;

	private float game_starttime;

	private GameMode _mode;

	private int mDailyId;

	private int mTowerId;

	private int mLearnSkillByEnergyNum;

	public int tryPlayCID;

	public int tryPlaySelected;

	public int tryPlaySkinId;

	public TryPlayMode tryPlayMode;

	public int tryPlayArtifactID;

	public int tryPlayArtifactStar;

	public int tryPlayWingID;

	public int tryPlayWingStar;

	private int m_nOperateType;

	private bool m_bUseBigMap;

	private bool m_bUseRadomSkill;

	private Dictionary<int, EntityBase> m_dicMonopolizedBullets;

	private Dictionary<int, int> m_dicPartUpperLimits;

	private Dictionary<int, int> m_dicMazeNpcTimes;

	private int m_nBabyId;

	public MagicianData _MagicianData;

	private List<int> m_listNpcs;

	private int m_nIndex;

	private List<GoodsBase> m_listNpcTowers;

	private int m_nMaxConsecutiveHits;

	private int m_nConsecutiveHits;

	private float m_fHitTime;

	private int m_nKillMonsterNum;

	private long m_lMaxHit;

	private long m_lTotalHit;

	private long m_lTotalRecoverLife;

	private float m_fGotoNextRoomTime;

	private float m_fPassLevelTime;

	private float m_fPassStageTime;

	private int m_nElkCount;

	private int m_nKillBossCntByEquip_1020508;

	private int _MazeLine;

	private float m_fBloodStoneRate;

	private List<int> m_listDungeonBuffs;

	private int m_nTotalIntegral;

	private float m_fAssistCdTime;

	private float m_fAssistTime;

	private int m_nAssistanterId;

	private int[] m_aryAssistanterSkills;

	private int m_nAssistanterIndex;

	public Dictionary<int, List<int>> m_dicArtifactSkills;

	private int activeid;

	private string m_BattleType;

	private int FinishedSLGRound;

	private long SLGTalent;

	private long SLGCampTalent;

	private int SLGTileId;

	private int SLGTileIndex;

	private int SLGZoneId;

	private int SLGTileLevel;

	private int SLGStageId;

	private SLGTileVO curSLGTileVO;

	private ChallengeModeBase mChallenge;

	private ulong lastHpNumber;

	private int _addHpScore;

	private int mEventTowerStrenthInterval;

	private CRespPlayTowerInfo mEventTowerInfo;

	private int mEventTowerDifficulty;

	private int mEventTowerId;

	private bool m_isInitMode;

	private GameMode _mainuimode;

	private GameMode _pveuimode;

	private bool bWin;

	private long lastAtk;

	private long lastHpMax;

	private int _sailingBagBattleType;

	private int _sailingBagBattleStageId;

	public List<int> CommonItemList;

	public bool InitNPCFinished;

	public List<int> InitWeaponIds;

	public Dictionary<int, bool> DiyCompNewDict;

	public const int SANTA_EQUIP_ID = 4002;

	public const int SANTA_COMP_ID = 4003;

	private const int INIT_DIY_EQUIP_COUNT = 3;

	public DIYEquipVO Santa2023DIYWeaponVO;

	private List<DIYEquipVO> diyDropWeaponVOs;

	private List<DIYEquipVO> diyDropCompVOs;

	private List<DIYEquipVO> curEquippedDiyCompVOs;

	private Dictionary<int, DIYEquipVO> diyEquipDict;

	private float diyMonsterDropRate;

	private float diyBossDropRate;

	private List<bool> mFirstShopBuy;

	private int CurTDCoin;

	private int curTDLevelId;

	public long DragonBoxItem => 0L;

	public int Level_CurrentStage
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool IsCooperationMode => false;

	public bool IsPvpMode => false;

	public int Stage_UI
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int StageChaperID_Battle => 0;

	public int BattleStage => 0;

	public int CurrentLine
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool RivedSkillUsed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float AddBabyAttackPercent
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public CRespGameTowerInfo TowerInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int TowerStrenthInterval
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int Times
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public CD_TIME_TYPE CdTimeType => CD_TIME_TYPE.CdTime_None;

	public bool UseRebornSkill { get; set; }

	public bool DropByServer { get; private set; }

	public List<int> MustDrops => null;

	public bool HasMustDrop => false;

	private GameMode mMode
	{
		get
		{
			return (GameMode)0;
		}
		set
		{
		}
	}

	public int DailyId => 0;

	public int OperateType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool UseBigMap => false;

	public BattleSource mEnterSource { get; private set; }

	public GameModeBase mModeData { get; private set; }

	public bool IsSailingBagBattleMode => false;

	public bool IsDailyEndless => false;

	public bool IsDailyMaze => false;

	public bool IsDailyGuild => false;

	public bool IsDailyChristmasID_2021 => false;

	public bool IsCooperationPVP => false;

	public bool IsDailyValentine => false;

	public bool IsDailyChristmas => false;

	public bool IsDailyTowerDefence => false;

	public bool IsDailyRoleReversal => false;

	public bool IsDailyDungeon => false;

	public bool IsDaily3rdAnniversary => false;

	public bool IsDailyChristmas2022 => false;

	public bool IsDailyNewPlay120 => false;

	public bool IsDailyNewPlay121 => false;

	public bool IsDailyNewPlay122 => false;

	public bool IsDailyNewPlay124 => false;

	public bool IsDailyNewPlay126 => false;

	public bool IsDailyNewPlay127 => false;

	public bool IsDailyPlay128 => false;

	public bool IsDailyPlay129 => false;

	public bool IsDailySurvival => false;

	public bool IsDailySpringFestival_2023 => false;

	public bool IsDailyBulletFly => false;

	public bool IsDailyNearbyDangerous => false;

	public bool IsDaily125 => false;

	public bool IsDaily129 => false;

	public bool IsDaily130 => false;

	public int BabyId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public uint[] VecShowIds { get; private set; }

	public int ElkCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int KillBossCntByEquip_1020508
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MazeLine
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float Reward_Exp_Rate => 0f;

	public float Reward_Gold_Rate => 0f;

	public float Reward_Equip_Rate => 0f;

	public float Reward_Loupe_Rate => 0f;

	public float Reward_Cookie_Rate => 0f;

	public float Reward_BloodStone_Rate => 0f;

	public List<int> DungeonBuffIds => null;

	public int TotalIntegral => 0;

	public float AssistCdTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float AssistTime
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int AssistanterId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int[] AssistanterSkills
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int AssistanterIndex
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float Reward_WishCoin_Rate => 0f;

	public float Reward_Gem_Rate => 0f;

	public int Reward_Gem_MaxTotal => 0;

	public bool SuperSkillEnabled { get; set; }

	public int SoulPoint { get; private set; }

	public int ActiveID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public Stage_Level_activity ActiveData => null;

	public Stage_Level_activitylevel ActiveLevelData => null;

	protected int monsterKillScore { get; private set; }

	protected int skillScore { get; private set; }

	public int addHpScore => 0;

	public int CooperationScore => 0;

	public int EventTowerStrenthInterval
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public CRespPlayTowerInfo EventTowerInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private GameMode m_MainUIMode
	{
		get
		{
			return (GameMode)0;
		}
		set
		{
		}
	}

	public bool IsTowerHeroMode => false;

	private GameMode m_PveUIMode
	{
		get
		{
			return (GameMode)0;
		}
		set
		{
		}
	}

	public bool Win => false;

	private List<int> DIYDropWeaponIds => null;

	public List<DIYEquipVO> DIYDropWeaponVOs => null;

	public List<DIYEquipVO> DIYDropCompVOs => null;

	public List<DIYEquipVO> CurEquippedDiyCompVOs => null;

	public List<DIYEquipVO> UnEquippedDIYDropCompVOs => null;

	public void SetUseRebornType(UseRebornType _type)
	{
	}

	public void IncreaseBattleUseRebornCount()
	{
	}

	public void SetLayer(int layer)
	{
	}

	public int GetLayer()
	{
		return 0;
	}

	public int GetAllLayter()
	{
		return 0;
	}

	public void AddUserExp(long value)
	{
	}

	public long GetUserExp()
	{
		return 0L;
	}

	public void AddDiamond(long value)
	{
	}

	public long GetDiamond()
	{
		return 0L;
	}

	public void AddLargeDiamondItem(long value)
	{
	}

	public long GetLargeDiamondItem()
	{
		return 0L;
	}

	public void AddNormalDiamondItem(long value)
	{
	}

	public long GetNormalDiamondItem()
	{
		return 0L;
	}

	private void ResetDragonBoxItem()
	{
	}

	public bool IsTowerMode()
	{
		return false;
	}

	public bool IsEventTowerMode()
	{
		return false;
	}

	public bool IsTDWrapper()
	{
		return false;
	}

	public bool IsSeasonMode()
	{
		return false;
	}

	public bool IsSeasonHardMode()
	{
		return false;
	}

	public bool IsCampBattleMode()
	{
		return false;
	}

	public bool IsTowerDefense2023Mode()
	{
		return false;
	}

	public bool IsDailyTDMode()
	{
		return false;
	}

	public bool IsTryPlayMode()
	{
		return false;
	}

	public bool IsManorTrainMode()
	{
		return false;
	}

	public bool IsMeadowBattleMode()
	{
		return false;
	}

	public void SetBattleStage(int stage)
	{
	}

	public void InitState(GameMode mode)
	{
	}

	public void RemoveStageLocal()
	{
	}

	public void SetRebornCount(int value)
	{
	}

	public int GetRebornCount()
	{
		return 0;
	}

	public bool GetCanReborn()
	{
		return false;
	}

	public void UseReborn()
	{
	}

	public void ResetBabyAddAttackPercent()
	{
	}

	public void AddGold(float value)
	{
	}

	public void AddGold(int value)
	{
	}

	private void UpdateGoldUI()
	{
	}

	public float GetGold()
	{
		return 0f;
	}

	private void ResetGold()
	{
	}

	public void SetTDCoin()
	{
	}

	public void UpdateTotalAddedHpMax(float value)
	{
	}

	public float GetTotalAddedHpMax()
	{
		return 0f;
	}

	public void ResetTotalAddedHpMax()
	{
	}

	private void ResetUserExp()
	{
	}

	private void ResetDiamond()
	{
	}

	private void ResetLargeDiamondItem()
	{
	}

	private void ResetNormalDiamondItem()
	{
	}

	private void ResetEquips()
	{
	}

	public void OnMonsterDead(int charId)
	{
	}

	public void IncreaseHPDrop()
	{
	}

	public int GetKillMonster()
	{
		return 0;
	}

	public int GetHPDrop()
	{
		return 0;
	}

	public Dictionary<int, int> GetKillMonsterDict()
	{
		return null;
	}

	public string GetKillMonsterJson()
	{
		return null;
	}

	public void ResetKillMonster()
	{
	}

	public void ResetHPDrop()
	{
	}

	public void InitCheatData()
	{
	}

	public void AddCheatInitialData(string name, int cheatType, float value)
	{
	}

	public void AddCheatFinalData()
	{
	}

	public void AddCheatFinalData(string name, int type, float value)
	{
	}

	public string BuildCheatData()
	{
		return null;
	}

	public int GetPveSeasonHpData()
	{
		return 0;
	}

	public int GetPveSeasonAttackData()
	{
		return 0;
	}

	public string GetPveSeasonCheatData2()
	{
		return null;
	}

	public void KillMonster(int charid, EntityBase entity = null)
	{
	}

	private void onMonsterDeadInTD(int charid)
	{
	}

	public int GetRewardScoreInNewPlay122()
	{
		return 0;
	}

	private void SaveKillMonstersInSeason()
	{
	}

	private void ResetKilledMonsters()
	{
	}

	public string KillMonsterToJsonForPveSeason()
	{
		return null;
	}

	public void SaveTowerInfo()
	{
	}

	public void StrenthHero()
	{
	}

	public void StrenthMonster()
	{
	}

	public void KillAll()
	{
	}

	public void ResetStrenthType()
	{
	}

	private void ResetDropEquips()
	{
	}

	public static void LOG(string log)
	{
	}

	public void OnResponseDropEquips(string json)
	{
	}

	private void ResetDropEquipByServer()
	{
	}

	private void CheckDailyDropEquipByServer()
	{
	}

	public void CheckDivideMonsterDrop(int guid, List<EntityBase> entities)
	{
	}

	public void GetDropEquipsByGuid(int guid, out List<int> equips)
	{
		equips = null;
	}

	public void CheckUnDropedEquipsWhenOpenDoor()
	{
	}

	private void checkUnDropedEquips()
	{
	}

	private void RandomEquipDropWave()
	{
	}

	private void OnCurrentWaveCreateEnd(int nCurWave)
	{
	}

	private void AssignDropEquips(List<EntityBase> list, List<int> ids)
	{
	}

	private void updateBody(EntityBase entity, int equipid)
	{
	}

	private void recoverBody(EntityBase entity)
	{
	}

	public void MustDrop(int source, int id)
	{
	}

	public void RemoveMustDrop(int id)
	{
	}

	public void AddEquip(LocalSave.EquipOne one)
	{
	}

	public bool CanAddEquip(LocalSave.EquipOne one, out int currentCount)
	{
		currentCount = default;
		return false;
	}

	public void GetAddedEquipCount(Dictionary<int, int> dic)
	{
	}

	public void GetAddedEquipCount(out int equip, out int scroll, out int stone, out int activityPropCount, out int book, out int runeStone, out int cookie, out int soulStone, out int adventureCoin, out int honorStone, out int gemc, out int loupec, out int bone, out int horn, out int bloodStone, out int magicstone, out int starlightStone, out int wishcoin, out int relicFragCount, out int dragonCointCount, out int fetterBadgeCount, out int Act4thItemsCount, out int Act4thExchangeItemsCount, out int tdItemCount, out int skillStoneCount, out int modstoneCount, out int commonItemCount, out int equipQuintessenceCount, out int petLevelUpItemsCount, out int petExchangeItemsCount, out int act5thDonateItemsCount, out int newPlay125BagCoinCount, out int imprintLevelUpItemCount, out int imprintExchangeItemCount, out int imprintStoneItemCount, out int TotalWingLevelUpItemsCount)
	{
		equip = default;
		scroll = default;
		stone = default;
		activityPropCount = default;
		book = default;
		runeStone = default;
		cookie = default;
		soulStone = default;
		adventureCoin = default;
		honorStone = default;
		gemc = default;
		loupec = default;
		bone = default;
		horn = default;
		bloodStone = default;
		magicstone = default;
		starlightStone = default;
		wishcoin = default;
		relicFragCount = default;
		dragonCointCount = default;
		fetterBadgeCount = default;
		Act4thItemsCount = default;
		Act4thExchangeItemsCount = default;
		tdItemCount = default;
		skillStoneCount = default;
		modstoneCount = default;
		commonItemCount = default;
		equipQuintessenceCount = default;
		petLevelUpItemsCount = default;
		petExchangeItemsCount = default;
		act5thDonateItemsCount = default;
		newPlay125BagCoinCount = default;
		imprintLevelUpItemCount = default;
		imprintExchangeItemCount = default;
		imprintStoneItemCount = default;
		TotalWingLevelUpItemsCount = default;
	}

	public void SaveTDEquip()
	{
	}

	public LocalSave.EquipOne AddEquipInternal(LocalSave.EquipOne one)
	{
		return null;
	}

	public List<LocalSave.EquipOne> GetEquips()
	{
		return null;
	}

	public LocalSave.EquipOne GetEquipOne(int equipId)
	{
		return null;
	}

	public int GetEquipCountById(int equipId)
	{
		return 0;
	}

	public int UpdateEquipCountById(int equipId, int deltaCount)
	{
		return 0;
	}

	public int GetEquipsCnt()
	{
		return 0;
	}

	private void RefMazeCoin(LocalSave.EquipOne one)
	{
	}

	public int GetMazeCoin()
	{
		return 0;
	}

	public int GetBattleInMazeCoin()
	{
		return 0;
	}

	public void CostMazeCoin(int price)
	{
	}

	public T GetRandomData<T>(ref IList<T> pList, Func<T, int> weightFun, bool removeSelect = true, Func<T, bool> canGetCond = null)
	{
		return default;
	}

	public void AddFoodItem(int pid, int pcount)
	{
	}

	public bool IsHaveFood(int pid)
	{
		return false;
	}

	public bool CanShowMazeFoodShop()
	{
		return false;
	}

	public void AddMazeItem(int pid, LocalSave.BattleInBase.MazeItemType ptype, int pos, int pcount)
	{
	}

	public int GetMazeEquipPositionCount(int pPos)
	{
		return 0;
	}

	public bool CanShowSmithyShop()
	{
		return false;
	}

	public void Battle_ad_use()
	{
	}

	public int GetRewardLayer()
	{
		return 0;
	}

	public void SetRewardType(TurnTableType type)
	{
	}

	public TurnTableType GetRewardType()
	{
		return TurnTableType.eInvalid;
	}

	private void reset_reward()
	{
	}

	public void AddBossMaxHP(long hp)
	{
	}

	public void BossChangeHP(long hp, EntityBase boss)
	{
	}

	private float GetBossHPPercent()
	{
		return 0f;
	}

	public void BossHPClear()
	{
	}

	public void AddHittedCount(int roomid)
	{
	}

	public int GetHittedCount(int layer)
	{
		return 0;
	}

	public int GetHittedCount()
	{
		return 0;
	}

	public void AddKillMonsters(int entityid)
	{
	}

	public int GetKillMonsters(int entityid)
	{
		return 0;
	}

	public int GetKillMonsters()
	{
		return 0;
	}

	public void AddKillBoss(int entityid)
	{
	}

	public int GetKillBoss(int entityid)
	{
		return 0;
	}

	public int GetKillBoss()
	{
		return 0;
	}

	public int GetGameTime()
	{
		return 0;
	}

	public void ResetTryPlayMode(TryPlayMode tMode)
	{
	}

	private void ResetBigMap()
	{
	}

	public void ResetOperateType()
	{
	}

	public bool isEnterSourceMain()
	{
		return false;
	}

	public bool isEnterSourceSeason()
	{
		return false;
	}

	public bool isEnterSourceMatch()
	{
		return false;
	}

	public bool isEnterSourceChallenge()
	{
		return false;
	}

	public GameMode GetMode()
	{
		return (GameMode)0;
	}

	public void SetTowerId(int nTowerId)
	{
	}

	public int GetTowerId()
	{
		return 0;
	}

	public void AddLearnSkillNumByEnergy()
	{
	}

	public int GetLearnSkillNumByEnergy()
	{
		return 0;
	}

	public void ResetLearnSkillNumByEnergy()
	{
	}

	public void UseRadomSkill()
	{
	}

	public bool IsUsedRandomSkill()
	{
		return false;
	}

	public void ResetUseRandomSkill()
	{
	}

	public string GetResourceGroupByTowerId(int towerId = -1)
	{
		return null;
	}

	public int GetDailyId()
	{
		return 0;
	}

	public void SetMode(GameMode mode, BattleSource source)
	{
	}

	public void SetDailyId(int dailyId)
	{
	}

	public bool IsDaily()
	{
		return false;
	}

	public bool Endless_IsHeroUsed(int heroid)
	{
		return false;
	}

	public bool CanChangeHeroInEndlessMode()
	{
		return false;
	}

	private void init_modedata()
	{
	}

	public bool CanAddBullet(int id, EntityBase entity)
	{
		return false;
	}

	public void RemoveBullet(int id, EntityBase entity)
	{
	}

	public void AddPart(int id, int num = 1)
	{
	}

	public void RemovePart(int id)
	{
	}

	public int GetPartNumById(int id)
	{
		return 0;
	}

	public void ClearPartUpperLimits()
	{
	}

	public void AddMazeNpcTimes(int id)
	{
	}

	public int GetMazeNpcTimes(int id)
	{
		return 0;
	}

	public Dictionary<int, int> GetAllMazeNpcTimes()
	{
		return null;
	}

	public void ResetMazeNpcTimes()
	{
	}

	public void SetMysticShopIds(uint[] ids)
	{
	}

	public void ResetShopIds()
	{
	}

	public void ResetMagician()
	{
	}

	public void SetNpcTower(GoodsBase tower)
	{
	}

	public void SetNpcs(List<int> ids)
	{
	}

	public void ResetNpcs()
	{
	}

	public List<int> GetNpcs()
	{
		return null;
	}

	public int GetNpc()
	{
		return 0;
	}

	public List<string> GetNpcAttributes(int id)
	{
		return null;
	}

	public void OnGotoNextDoorAfter()
	{
	}

	public List<Vector3> GetNpcPositions()
	{
		return null;
	}

	public void OnHitEnemy(HitStruct hs, HittedData data)
	{
	}

	private bool IsEquipIcon(int equipIconID)
	{
		return false;
	}

	public void OnKillEnemy(EntityBase entity)
	{
	}

	public void OnHpChanged(EntityBase entity, long value)
	{
	}

	public void OnRecover(EntityBase entity, long value)
	{
	}

	public void OnOpenDoor()
	{
	}

	public void RecordTotalDmg(bool isOpen)
	{
	}

	public (float, int, int, long, long, long) GetBattleStatistic()
	{
		return default;
	}

	public void OnCreateMonster(EntityBase entity)
	{
	}

	public void ResetBattleStatistic()
	{
	}

	public void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ResetElkCount()
	{
	}

	private void ResetKillBossCntByEquip_1020508()
	{
	}

	public void Reset()
	{
	}

	private void ResetBloodStone()
	{
	}

	public void AddDungeonBuffId(int id)
	{
	}

	public void AddIntegral(int charId)
	{
	}

	public void SaveIntergral()
	{
	}

	public void ResetIntergral()
	{
	}

	public void SaveAssistCdTime(float time)
	{
	}

	public void SaveAssistDatas()
	{
	}

	public void SaveAssistIndex()
	{
	}

	private void ResetAssistDatas()
	{
	}

	public void AddArtifactActivitySkill(int id, int skillId)
	{
	}

	public void ResetSoulPoint()
	{
	}

	public void AddSoulPoint(int cnt)
	{
	}

	public string GetActiveLayer()
	{
		return null;
	}

	private string GetActiveLayer(int layerid)
	{
		return null;
	}

	public string GetActiveLayer(string stagelevel, int layerid)
	{
		return null;
	}

	public Stage_Level_activitylevel GetActiveLevelData(int layer)
	{
		return null;
	}

	public string GetBattleType()
	{
		return null;
	}

	public void SetBattleType(string _type)
	{
	}

	public string GetBattleTypeInCNStr()
	{
		return null;
	}

	public BattleType GetBattleTypeInEnum()
	{
		return BattleType.None;
	}

	public void SetSLGTileVO(SLGTileVO vo)
	{
	}

	public SLGTileVO GetSLGTileVO()
	{
		return null;
	}

	public void SetSLGTalent(long value)
	{
	}

	public void UpdateSLGTalent(long delta)
	{
	}

	public long GetSLGTalent()
	{
		return 0L;
	}

	private void clampSLGTalent()
	{
	}

	public void ResetSLGTalent()
	{
	}

	public bool IsMaxSLGTalent()
	{
		return false;
	}

	public void SetSLGCampTalent(long value)
	{
	}

	public void UpdateSLGCampTalent(long delta)
	{
	}

	public bool IsMaxSLGCampTalent()
	{
		return false;
	}

	private void clampSLGCampTalent()
	{
	}

	public long GetSLGCampTalent()
	{
		return 0L;
	}

	public void ResetSLGCampTalent()
	{
	}

	public void SetFinishedSLGRound(int _round)
	{
	}

	public int GetFinishedSLGRound()
	{
		return 0;
	}

	public void SetSLGTileId(int id)
	{
	}

	public int GetSLGTileId()
	{
		return 0;
	}

	public void SetSLGTileIndex(int idx)
	{
	}

	public int GetSLGTileIndex()
	{
		return 0;
	}

	public void SetSLGZoneId(int id)
	{
	}

	public int GetSLGZoneId()
	{
		return 0;
	}

	public void SetSLGTileLevel(int _level)
	{
	}

	public int GetSLGTileLevel()
	{
		return 0;
	}

	public void SetSLGStageId(int _stageId)
	{
	}

	public int GetSLGStageId()
	{
		return 0;
	}

	private void RandomEquipDropWave_SLG(RoundVO roundVO)
	{
	}

	public void OnCurrentWaveCreateEnd_SLG(RoundVO roundVO, int nCurWave)
	{
	}

	public void OnGotoNextDoorAfter_SLG(RoundVO roundVO)
	{
	}

	public int GetTotalSLGCoins()
	{
		return 0;
	}

	public void UpdateTotalSLGCoins(int delta)
	{
	}

	public void RefreshTotalSLGCoins(int curCount)
	{
	}

	public void Challenge_Init(int id)
	{
	}

	public void Challenge_UpdateMode(int id)
	{
	}

	public void Challenge_UpdateMode(int id, BattleSource source)
	{
	}

	public void Challenge_MainUpdateMode(int id)
	{
	}

	public bool Challenge_ismainchallenge()
	{
		return false;
	}

	public void Challenge_Start()
	{
	}

	public void Challenge_SetUIParent(Transform parent)
	{
	}

	public void Challenge_SendEvent(string eventname, object body = null)
	{
	}

	public object Challenge_GetEvent(string eventname)
	{
		return null;
	}

	public string Challenge_GetSuccessString()
	{
		return null;
	}

	public List<string> Challenge_GetConditions()
	{
		return null;
	}

	public bool Challenge_RecoverHP()
	{
		return false;
	}

	public bool Challenge_DropExp()
	{
		return false;
	}

	public bool Challenge_AttackEnable()
	{
		return false;
	}

	public bool Challenge_BombermanEnable()
	{
		return false;
	}

	public float Challenge_BombermanTime()
	{
		return 0f;
	}

	public void Challenge_MonsterDead()
	{
	}

	public bool Challenge_MonsterHide()
	{
		return false;
	}

	public float Challenge_MonsterHideRange()
	{
		return 0f;
	}

	public void Challenge_GetRewards()
	{
	}

	public void Challenge_DeInit()
	{
	}

	public void OneMonsterDead(EntityBase source, EntityBase target)
	{
	}

	public void AddOneSkill(EntityBase entity, int skillid)
	{
	}

	public void ClearCooperationScore()
	{
	}

	public void SetEventTowerId(int id)
	{
	}

	public int GetEventTowerId()
	{
		return 0;
	}

	public void SetEventTowerDifficulty(int difficulty)
	{
	}

	public int GetEventTowerDifficuty()
	{
		return 0;
	}

	public int GetEventTowerRoomId()
	{
		return 0;
	}

	public int GetEventTowerSymbol()
	{
		return 0;
	}

	public void SaveEventTowerInfo()
	{
	}

	public int GetRewardCurrencyInEventTower(bool isWin, CurrencyType currencyType)
	{
		return 0;
	}

	public List<LocalSave.EquipOne> GetRewardEquipsInEventTower(bool isWin)
	{
		return null;
	}

	public List<string> GetRewardStrList(bool isWin)
	{
		return null;
	}

	public bool IsHeroMode()
	{
		return false;
	}

	public bool IsNormalMode()
	{
		return false;
	}

	public bool IsHellMode()
	{
		return false;
	}

	public bool IsUIHeroMode()
	{
		return false;
	}

	public bool IsUINormalMode()
	{
		return false;
	}

	public bool IsUIHellMode()
	{
		return false;
	}

	public bool IsDailyActivityMode()
	{
		return false;
	}

	public void SetUIHeroMode()
	{
	}

	public void SetUINormalMode()
	{
	}

	public void SetUIHellMode()
	{
	}

	public void ChangeUIMode(GameMode mode)
	{
	}

	public GameMode GetUIMode()
	{
		return (GameMode)0;
	}

	public GameMode GetPveMainUIMode()
	{
		return (GameMode)0;
	}

	public bool IsPveMainUIHardMode()
	{
		return false;
	}

	public void ChangePveUIMode(GameMode mode)
	{
	}

	private void RandomEquipDropWave_NewPlay125(int curWave, int totalSubWavesOfCurWave)
	{
	}

	public void OnCurrentWaveCreateEnd_NewPlay125(int curWave, int curSubWave)
	{
	}

	public void OnGotoNextDoorAfter_NewPlay125(int curWave, int totalSubWavesOfCurWave)
	{
	}

	public void SetWin(bool value)
	{
	}

	public void SetLastAtk(long atk)
	{
	}

	public void SetLastHpMax(long hpmax)
	{
	}

	public long GetLastAtk()
	{
		return 0L;
	}

	public long GetLastHpMax()
	{
		return 0L;
	}

	public void SetSailingBagBattleType(int _type)
	{
	}

	public int GetSailingBagBattleType()
	{
		return 0;
	}

	public void SetSailingBagBattle(int stageId)
	{
	}

	public int GetSailingBagBattleId()
	{
		return 0;
	}

	public void Add2CommonItemList(int id)
	{
	}

	public void RemoveFromCommonItemList(int id)
	{
	}

	public void ResetCommonItemList()
	{
	}

	public void InitSanta2023()
	{
	}

	public void ResetSanta2023DropRate()
	{
	}

	public int GetDiyCompGrids(DIYEquipVO vo)
	{
		return 0;
	}

	public float GetDiyDropRate(bool isBoss)
	{
		return 0f;
	}

	public void ChangeSanta2023Weapon(int diyWeaponId)
	{
	}

	private void updateWeaponAttr(string sign)
	{
	}

	private void updateAllCompAttr(List<DIYEquipVO> diyComps, string sign)
	{
	}

	public List<DIYEquipVO> GetNewCurEquippedCompVOs()
	{
		return null;
	}

	public void UpdateDiyCompAttr(List<DIYEquipVO> oldList, List<DIYEquipVO> newList)
	{
	}

	public List<DIYEquipVO> ExceptWithCounts(List<DIYEquipVO> first, List<DIYEquipVO> second)
	{
		return null;
	}

	public void ResetSanta2023()
	{
	}

	public void CreateSantaFoodDrop(FoodType foodType, int diyId, Vector3 center, int radius)
	{
	}

	public List<DIYEquipVO> GetMockWeaponList()
	{
		return null;
	}

	public Dictionary<int, DIYEquipVO> GetSantaEquips()
	{
		return null;
	}

	public List<int> GetInitWeaponIds()
	{
		return null;
	}

	public List<DIYEquipVO> GetInitDIYEquips()
	{
		return null;
	}

	public DIYEquipVO PickInitDIYEquip(Dictionary<int, DIYEquipVO> diyDict)
	{
		return null;
	}

	public DIYEquipVO PickDIYEquip(bool isBoss)
	{
		return null;
	}

	public void Add2DiyCompNewDict(int diyId)
	{
	}

	public void UpdateDiyCompNewDict(int diyId, bool isNew)
	{
	}

	public bool IsDiyCompNew(int diyId)
	{
		return false;
	}

	public void Add2DiyWeaponVOs(int diyId)
	{
	}

	public void RemoveFromDiyWeaponVOs(int diyId)
	{
	}

	public void Add2DiyCompVOs(int diyId)
	{
	}

	public void RemoveFromDiyCompVOs(int diyId)
	{
	}

	public void ResetCurEquippedDiyCompVOs(List<DIYEquipVO> list)
	{
	}

	public void Add2CurEquippedDiyCompVOs(int diyId)
	{
	}

	public void RemoveFromCurEquippedDiyCompVOs(int diyId)
	{
	}

	public List<DIYEquipVO> SortDiyList(List<DIYEquipVO> list)
	{
		return null;
	}

	public void SyncDiyComps()
	{
	}

	public void SyncDiyWeapons()
	{
	}

	public void SyncCurEquippedComps()
	{
	}

	public void SyncDiyCompNewDict()
	{
	}

	public bool HasBetterDiyWeapon()
	{
		return false;
	}

	private void InitShop()
	{
	}

	private void InitFirstShop()
	{
	}

	public bool GetFirstShopBuy(int index)
	{
		return false;
	}

	public void SetFirstShopBuy(int index)
	{
	}

	public int GetMonsterTDCoin(int charId)
	{
		return 0;
	}

	public void UpdateTDCoin(int delta)
	{
	}

	public int GetTDCoin()
	{
		return 0;
	}

	public void SetTDCoin(int value)
	{
	}

	public void SetCurTDLevelId(int levelId)
	{
	}

	public int GetCurTDLevelId()
	{
		return 0;
	}
}
