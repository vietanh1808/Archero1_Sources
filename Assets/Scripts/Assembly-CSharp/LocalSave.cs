using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using CodeStage.AntiCheat.ObscuredTypes;
using Dxx.Net;
using GameProtocol;
using Habby.Guild.Data;
using MeadowBattle;
using NewPlay125;
using Newtonsoft.Json;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class LocalSave : LocalSaveBase
{
	[Serializable]
	public class LocalSaveBelief : LocalSaveBase
	{
		public List<BeliefTalentData> beliefTaletDatas;

		private int crtUnlockStage;

		[JsonIgnore]
		public int MaxRowCount;

		[JsonIgnore]
		public int MaxColCount;

		protected override string filename => null;

		[JsonIgnore]
		public BeliefSkillData SkillShowData => null;

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public int GetCrtUnlockStage()
		{
			return 0;
		}

		public void SetCrtUnlockStage(int stage)
		{
		}

		public void Clear()
		{
		}

		public void RefreshBeliefTalent(List<BeliefTalentData> beliefDatas)
		{
		}

		public void SetBeliefTabletData(int id, int status)
		{
		}

		public int GetBeliefStatusByID(int id)
		{
			return 0;
		}

		public bool IsBeliefHaveRed()
		{
			return false;
		}

		public BeliefSkillData SetSkillShowData()
		{
			return null;
		}

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}
	}

	[Serializable]
	public class LocalSaveImprint : LocalSaveBase
	{
		public static int CanRigOutRare;

		public List<ImprintOne> imprints;

		public int BeliefLevel;

		public int WarIndexUnLock;

		[JsonIgnore]
		public SelfAttributeData attributeData;

		[CompilerGenerated]
		private Action m_OnImprintUnLock;

		[CompilerGenerated]
		private Action m_OnImprintLevelUp;

		[CompilerGenerated]
		private Action<int, int> m_OnUpWar;

		[CompilerGenerated]
		private Action<int> m_OnDownWar;

		[CompilerGenerated]
		private Action<int> m_OnReadySeat;

		[JsonIgnore]
		public int CurReadySeatIndex;

		[CompilerGenerated]
		private Action<int> m_OnReadyImprint;

		[JsonIgnore]
		public int CurReadyImprintId;

		public int lastBeliefLevel;

		public int lastBlessPoint;

		public int lastBeliefExp;

		protected override string filename => null;

		[JsonIgnore]
		public int BeliefExp => 0;

		[JsonIgnore]
		public int BlessExp => 0;

		[JsonIgnore]
		public int NextBeliefLevelExp => 0;

		[JsonIgnore]
		public int MaxBeliefLevel => 0;

		[JsonIgnore]
		public bool BeliefLevelIsMax => false;

		[JsonIgnore]
		public bool isOpen => false;

		[JsonIgnore]
		public bool isSystemOpen => false;

		[JsonIgnore]
		public int G_BeliefLevel
		{
			set
			{
			}
		}

		[JsonIgnore]
		public bool isPlayBelifLevelUp => false;

		[JsonIgnore]
		public bool isPlayBelifExpUp => false;

		public event Action OnImprintUnLock
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnImprintLevelUp
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int, int> OnUpWar
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnDownWar
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnReadySeat
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<int> OnReadyImprint
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}

		public ImprintOne GetImprintOne(int imprintId)
		{
			return null;
		}

		public ImprintOne GetImprintOneByRowId(long imprintRowId)
		{
			return null;
		}

		public void UnLockImprint(int imprintId, long rowId)
		{
		}

		public void UpGradeImprint(int imprintId, int deltaLevel = 1)
		{
		}

		public void RefreshImprints(CImprintInfo[] infos)
		{
		}

		public void RefreshImprint(CImprintInfo info)
		{
		}

		public ImprintOne GetImprintOneByWarIndex(int warindex)
		{
			return null;
		}

		public List<ImprintOne> GetHasImprints()
		{
			return null;
		}

		public ImprintOne[] GetUpWarImprint()
		{
			return null;
		}

		public ImprintOne GetUpWarImprintByIndex(int warIndex)
		{
			return null;
		}

		public bool ImprintTabEntanceHasRed()
		{
			return false;
		}

		public bool ImprintEntanceHasRed()
		{
			return false;
		}

		private bool GetHaveCanUnLockImprint()
		{
			return false;
		}

		private bool GetHaveCanLevelUpImprint()
		{
			return false;
		}

		public Sprite GetBelirfLevelBg(int level)
		{
			return null;
		}

		public IEnumerable<ImprintOne> GetImprintsByRare(int rare)
		{
			return null;
		}

		public IEnumerable<int> GetListShowRare()
		{
			return null;
		}

		public bool GetUnLockByRare(int rare)
		{
			return false;
		}

		public bool GetWarIndexUnLock(int warindex)
		{
			return false;
		}

		public Dictionary<string, Goods_goods.GoodData> GetAllAttribute(SelfAttributeData _attributeData)
		{
			return null;
		}

		public void InitAttribute()
		{
		}

		public void UpWar(int ImprintId, int warId)
		{
		}

		public void DownWar(int warId)
		{
		}

		public void ReadySeat(int seatIndex)
		{
		}

		public void ReadyImprint(int imprintId)
		{
		}

		public void OnBeliefPointChange(CurrencyType currencyType, int old, int cur)
		{
		}

		public bool IsHaveCanRigOut()
		{
			return false;
		}

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}
	}

	[Serializable]
	public class ImprintOne
	{
		public int ID;

		public int Level;

		public long rowId;

		public int WarIndex;

		[CompilerGenerated]
		private Action m_OnUnLock;

		[CompilerGenerated]
		private Action m_OnLevelChange;

		[JsonIgnore]
		public bool IsUnLock => false;

		[JsonIgnore]
		public string BriefInfo => null;

		[JsonIgnore]
		public Imprint_Imprint Config => null;

		[JsonIgnore]
		public int LevelMax => 0;

		[JsonIgnore]
		public bool isMaxLevel => false;

		[JsonIgnore]
		public ImprintWarState WarState => ImprintWarState.Idle;

		[JsonIgnore]
		public bool IsUpWar => false;

		[JsonIgnore]
		public int FragmentId => 0;

		[JsonIgnore]
		public int NeedFragmentNum => 0;

		[JsonIgnore]
		public int FragmentNum => 0;

		[JsonIgnore]
		public string Name => null;

		[JsonIgnore]
		public string NameCByRare => null;

		[JsonIgnore]
		public Sprite Icon => null;

		[JsonIgnore]
		public Sprite BgIcon => null;

		[JsonIgnore]
		public int Rare => 0;

		[JsonIgnore]
		public string RareName => null;

		[JsonIgnore]
		public string SkillDesc => null;

		[JsonIgnore]
		public string Desc => null;

		[JsonIgnore]
		public bool IsCanRigOut => false;

		[JsonIgnore]
		public int IsVisual => 0;

		[JsonIgnore]
		public bool IsShowInList => false;

		[JsonIgnore]
		public int[] WithImprint => null;

		[JsonIgnore]
		public int UnlockCondition => 0;

		[JsonIgnore]
		public int[] MainSkills => null;

		[JsonIgnore]
		public float[] NextLevelMainAttriAdd => null;

		[JsonIgnore]
		public Goods_goods.GoodData[] BreakAttributes => null;

		[JsonIgnore]
		public float[] NextLevelBreakAttriAdd => null;

		[JsonIgnore]
		public List<(int, int)> UpLevelNeed => null;

		[JsonIgnore]
		public int UpLevelNeedGold => 0;

		[JsonIgnore]
		public bool isCanLevelUp => false;

		public event Action OnUnLock
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnLevelChange
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public ImprintOne Clone()
		{
			return null;
		}

		public Goods_goods.GoodData[] MainAttributes(SelfAttributeData attributeData)
		{
			return null;
		}

		public bool GetIsCanUnLock()
		{
			return false;
		}

		public void UnLock(long _rowId)
		{
		}

		public void UpGrade(int deltaLevel = 1)
		{
		}

		public (int, int) GetLayerAndCount()
		{
			return default;
		}

		public (int, int) GetLayerAndCount(int _level)
		{
			return default;
		}

		public int GetBelifeByLevel(int _level)
		{
			return 0;
		}
	}

	public class ImprintBoxGuideData : GuideDataBase
	{
		protected override ushort guideId => 0;

		protected override int stepCount => 0;

		protected override List<Func<bool>> stepCondition => null;

		public override void OnStartGuideStep()
		{
		}
	}

	public class ImprintGuideData : GuideDataBase
	{
		protected override ushort guideId => 0;

		protected override int stepCount => 0;

		protected override List<Func<bool>> stepCondition => null;

		public override void OnStartGuideStep()
		{
		}
	}

	[Serializable]
	public class Act5thHuntingKillAnimalVO
	{
		public List<Act5thHuntingKillAnimalData> killAnimalData;

		public int arrowCount;

		public int animalCount;

		public void UpdateAnimalCount(int animalCount)
		{
		}

		public int GetAnimalCount()
		{
			return 0;
		}

		public void UpdateArrowCount(int arrowCount)
		{
		}

		public void RemoveOneArrow()
		{
		}

		public int GetArrowCount()
		{
			return 0;
		}

		public void AddKillAnimalData(Act5thHuntingAnimalData animalData)
		{
		}

		public List<Act5thHuntingKillAnimalData> GetKillAnimalData()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Act5thHuntingKillAnimalData
	{
		public int animalUniqueID;

		public int animalID;

		public float maxHp;

		public float leftHp;

		public static Act5thHuntingKillAnimalData Create(Act5thHuntingAnimalData killAnimalData)
		{
			return null;
		}
	}

	[Serializable]
	public class ActiveOne
	{
		public int Index;

		public int Count;
	}

	[Serializable]
	public class ActiveData : LocalSaveBase
	{
		public List<ActiveOne> list;

		public List<int> m_listContractIds;

		private EntityAttributeBase.ValueFloatBase m_MonsterToEliteRate;

		private List<string> _MonsterAttributes;

		private List<int> _MonsterSkillIds;

		private List<string> _NpcAttributes;

		private List<int> _NpcSkillIds;

		private List<string> _HeroAttributes;

		private List<int> _HeroSkillIds;

		private int _ContractLevel;

		private float _Reward_Gold_Rate;

		private float _Reward_Exp_Rate;

		private float _Reward_Equip_Rate;

		private float _Reward_Loupe_Rate;

		private float _Reward_Cookie_Rate;

		private float _Reward_Gem_Rate;

		[JsonIgnore]
		public List<int> ContractIds => null;

		[JsonIgnore]
		public float MonsterToEliteRate => 0f;

		[JsonIgnore]
		public List<string> MonsterAttributes => null;

		[JsonIgnore]
		public List<int> MonsterSkillIds => null;

		[JsonIgnore]
		public List<string> NpcAttributes => null;

		[JsonIgnore]
		public List<int> NpcSkillIds => null;

		[JsonIgnore]
		public List<string> HeroAttributes => null;

		[JsonIgnore]
		public List<int> HeroSkillIds => null;

		[JsonIgnore]
		public int ContractLevel => 0;

		[JsonIgnore]
		public float Reward_Gold_Rate => 0f;

		[JsonIgnore]
		public float Reward_Exp_Rate => 0f;

		[JsonIgnore]
		public float Reward_Equip_Rate => 0f;

		[JsonIgnore]
		public float Reward_Loupe_Rate => 0f;

		[JsonIgnore]
		public float Reward_Cookie_Rate => 0f;

		[JsonIgnore]
		public float Reward_Gem_Rate => 0f;

		public void SetContractIds(List<int> ids)
		{
		}

		private void InitTowerDefenceChange()
		{
		}

		private void ResetTowerDefenceChange()
		{
		}

		protected override void OnRefresh()
		{
		}

		public void Init()
		{
		}
	}

	[Serializable]
	public class ArtifactOne
	{
		public ulong RowID;

		public int ID;

		public int starID;

		public bool unLock;

		public int position;

		[JsonIgnore]
		public int Star => 0;

		[JsonIgnore]
		public bool isWear => false;

		[JsonIgnore]
		public Artifact_Artifact config => null;

		[JsonIgnore]
		public int Quality => 0;

		[JsonIgnore]
		public int skiIdBegin => 0;

		[JsonIgnore]
		public int skiIdEnd => 0;

		[JsonIgnore]
		public int FragmentId => 0;

		[JsonIgnore]
		public int FragmentNum => 0;

		[JsonIgnore]
		public int Rarity => 0;

		[JsonIgnore]
		public string Name => null;

		[JsonIgnore]
		public Sprite PropBgIcon => null;

		[JsonIgnore]
		public Sprite PropIcon => null;

		[JsonIgnore]
		public Sprite RatityIcon => null;

		[JsonIgnore]
		public bool canUnlock => false;

		[JsonIgnore]
		public bool canStarUp => false;

		[JsonIgnore]
		public int StarMax => 0;

		[JsonIgnore]
		public string[] AttributeBasicStr => null;

		[JsonIgnore]
		public int ATKBasic => 0;

		[JsonIgnore]
		public int HPBasic => 0;

		[JsonIgnore]
		public int ATKTotal => 0;

		[JsonIgnore]
		public int HPTotal => 0;

		[JsonIgnore]
		public int BattleArtifactID => 0;

		[JsonIgnore]
		public string BattleModelID => null;

		[JsonIgnore]
		public int BattleSkillID => 0;

		public ArtifactOne Clone()
		{
			return null;
		}

		public List<ArtifactAttrItemData> GetAttrShowList()
		{
			return null;
		}

		public ArtifactAttrItemData GetAttrItemDataOne(int star)
		{
			return null;
		}

		public List<Drop_DropModel.DropData> GetStarNeedMaterials(int starId)
		{
			return null;
		}

		public int ATKStarUp(int starId)
		{
			return 0;
		}

		public int HPStarUp(int starId)
		{
			return 0;
		}
	}

	[Serializable]
	public class ArtifactData : LocalSaveBase
	{
		public List<ArtifactOne> artifactList;

		public bool isShowItem;

		[JsonIgnore]
		public const int MatId = 31013;

		protected override string filename => null;

		[JsonIgnore]
		public int configOpenLevel => 0;

		[JsonIgnore]
		public bool isOpen => false;

		[JsonIgnore]
		public int starIDMax => 0;

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}

		public ArtifactOne GetArtifactOne(int artid)
		{
			return null;
		}

		public ArtifactOne GetNewArtifactOne(int artid, int starid = 0)
		{
			return null;
		}

		private ArtifactOne ArtifactOne(int artid)
		{
			return null;
		}

		public ArtifactOne GetArtifactOneByFragment(int fid)
		{
			return null;
		}

		public void initList()
		{
		}

		public void unLock(int artid)
		{
		}

		public void starUp(int artid)
		{
		}

		public void updateData(ulong rowid, int artid, int star, bool unlock)
		{
		}

		public void updateData(ulong rowid, int artid, int star, int pos, bool unlock)
		{
		}

		public List<ArtifactOne> GetCanSelectList()
		{
			return null;
		}

		public List<int> GetUsedIDList()
		{
			return null;
		}

		public List<ArtifactOne> GetUsedList()
		{
			return null;
		}

		public List<string> GetBattleAttributes()
		{
			return null;
		}

		public List<ArtifactOne> GetBattleTryPlayData(int aID, int aStar)
		{
			return null;
		}

		public List<string> GetBattleTryPlayAttributes(int aID, int aStar)
		{
			return null;
		}

		public List<string> GetBattleAttributes(List<ArtifactOne> artiList)
		{
			return null;
		}

		public List<ArtifactItemData> GetGameArtifactItemData()
		{
			return null;
		}

		public List<ArtifactItemData> GetGameTryPlayArtifactItemData(List<ArtifactOne> aList)
		{
			return null;
		}

		public List<ArtifactOne> GetGameArtifactOneData()
		{
			return null;
		}

		public List<ArtifactOne> GetGameArtifactTryPlayOneData()
		{
			return null;
		}

		public List<int> GetUsedIDInPos()
		{
			return null;
		}

		public void SetUsedIDInPos(List<int> list)
		{
		}

		public List<ArtifactOne> GetShowList()
		{
			return null;
		}

		public int GetPosUnlockLevel(int position)
		{
			return 0;
		}

		public bool isHaveUnlockPos(int position)
		{
			return false;
		}

		public ArtifactOne GetArtifactOneByPos(int pos)
		{
			return null;
		}

		public int GetEmptyOnePos()
		{
			return 0;
		}

		public void putOneTop(int pos, int atid)
		{
		}

		public void updateData(CArtifact art)
		{
		}

		public void updateData(CArtifact[] art)
		{
		}

		public Artifact_UpStar GetStarUpData(int starId)
		{
			return null;
		}

		public bool isShowEntranceRed()
		{
			return false;
		}

		public bool canPutInPosition(int position)
		{
			return false;
		}

		public bool canWearOne()
		{
			return false;
		}

		public bool canWearOneInPosition()
		{
			return false;
		}

		public bool canUnlockOne()
		{
			return false;
		}

		public bool canStarUp()
		{
			return false;
		}

		public void requestGetOne(int artid, Action<CRespEquipArtifact, int> action = null)
		{
		}

		public void requestStar(ulong rowid, int artid, Action<CRespEquipArtifact, int> action = null)
		{
		}

		private void showRewardWindow(STCommonData stcd)
		{
		}

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}
	}

	[Serializable]
	public class RefineWeapon : ICloneable<RefineWeapon>
	{
		public int KillCountInSkillAlone1387;

		public void Clear()
		{
		}

		public void Clone(RefineWeapon source)
		{
		}
	}

	[Serializable]
	public class BattleInBase : LocalSaveBase
	{
		public class EndlessDrop
		{
			public int id;

			public int count;

			public EndlessDrop Clone()
			{
				return null;
			}
		}

		[Serializable]
		public class PartnerSave
		{
			public int id;

			public long hp;

			public long energy;

			public bool dead;

			public PartnerSave Clone()
			{
				return null;
			}
		}

		public class ServerDrop
		{
			public ServerDropEquip[] drops;

			public bool hasToxicfog;

			public bool hasVisionMist;
		}

		public class ServerDropEquip
		{
			public int layer;

			public int itemId;
		}

		public class ServerDropEquips
		{
			public uint transid;

			public long time;

			public ServerDropEquip[] equips;

			public ServerDropEquips Clone()
			{
				return null;
			}
		}

		public class MazeItemData
		{
			public int id;

			public MazeItemType type;

			public int count;

			public int pos;

			public MazeItemData Clone()
			{
				return null;
			}
		}

		public class MazeEquip
		{
			public int position;

			public int count;

			public MazeEquip Clone()
			{
				return null;
			}
		}

		public enum MazeItemType
		{
			none = 0,
			equip = 1,
			food = 2
		}

		public class MazeEquip2
		{
			public int id;

			public int lv;

			public string unique_id;

			public MazeEquip2 Clone()
			{
				return null;
			}
		}

		public RefineWeapon refineWeapon;

		public Dictionary<string, float> IncreasedValueByReducedValue2Dict;

		public Dictionary<string, float> ReducedValueByIncreasedValue2Dict;

		public Dictionary<string, int> LowerHPDict;

		public Dictionary<string, int> PersistentBuffDict;

		public Dictionary<string, List<int>> PersistentBuffListDict;

		public Dictionary<string, float> CumulatedAttrDict;

		public Dictionary<string, float> PersistentValueDict;

		public Dictionary<string, bool> BoolDict;

		public int RelicRebornCount;

		public bool bHaveBattle;

		public uint transid;

		public ulong serveruserid;

		public int level;

		public float exp;

		public long user_exp;

		public float gold;

		public long diamond;

		public int soulPoint;

		public long large_diamond_item;

		public long normal_diamond_item;

		public long m_nDragonBoxItem;

		public List<int> skillids;

		public List<int> goodids;

		public List<EquipOne> equips;

		public long hp;

		public long energy;

		public long charge;

		public long anger;

		public float boxingSuperSkillTime;

		public float flashSuperSkillTime;

		public float TotalAddedHpMax;

		public int RoomID;

		public int MaxRoomID;

		public int ResourcesID;

		public string TmxID;

		public string NextTmxID;

		public const int DEFAULT_GAME_TYPE = -1;

		public int GameType;

		public int DailyId;

		public int DailyLevel;

		public int DailyScore;

		public float CurMagicPoints;

		public int CurMPNum;

		public float CumulatedDeltaHPMaxPercent;

		public long CumulatedDeltaHP;

		public float MaxCumulatedDeltaHPMaxPercent;

		public float FoodHP2HPMaxPower;

		public float CurEnergizedHPDropCount;

		public int LearnSkillByEnergyNum;

		public bool UsedRandomSkill;

		public float nohitted_addvalue;

		public Dictionary<string, float> nohittedDict;

		public int reborn_skill_count;

		public int reborn_ui_count;

		public int leveluptype;

		public int slotCnt;

		public List<int> levelupskills;

		public List<int> learnskills;

		public bool bGoldTurn;

		public int stage;

		public int SailingBagBattleStageId;

		public int SailingBagBattleType;

		public List<bool> firstshopbuy;

		public List<int> potions;

		public List<string> deadBabyUniqueEquipIds;

		public List<string> resistedBabyUniqueEquipIds;

		public long ReducedHPInSkillAlone1318;

		public long MaxHPInInSkillAlone1318;

		public long SkillAlone1657TotalAdded;

		public int SkillAlone1664KillCnt;

		public bool SkillAlone1655Flag;

		public long SkillAlone1671RecoverHpTotal;

		public int SkillAlone1675HpFoodCnt;

		public int SkillAlone1675AngelCnt;

		public float SuperSkillCDTime;

		public float ExtraSuperSkillCDTime;

		public float WuKongSuperSkillCDTime;

		public int SkillAlone2075HpFoodCnt;

		public long SkillAlone2301ConvertedMaxHp;

		public long SkillAlone2301ConvertMaxHp;

		public long SkillAlone2308ShieldValue;

		public long SkillAlone2308ShieldCap;

		public bool ShouldShowAngelOfJudgmentFlag;

		public bool AngelOfJudgmentFlag;

		public bool ShouldShowAngelOfLightFlag;

		public bool AngelOfLightFlag;

		public long DemonKingShieldValue;

		public bool SkillAlone2156UsedFlag;

		public bool SkillAlone2165UsedFlag;

		public bool SkillAlone2191UsedFlag;

		public bool hasUsedLanceShieldSkinReborn;

		public int athenaFlashConsumeBuffCount;

		[JsonIgnore]
		public ObscuredInt _HPDrop;

		public Dictionary<int, int> killMonsterDict;

		[JsonIgnore]
		public ObscuredInt _killMonster;

		public bool ReviveSkill_Type401_Used;

		public bool ReviveSkill_PinkCat_Used;

		public float AddBabyAttackPercent;

		public float yuanzhijing_skill_addvalue;

		public float endless_skill_addvalue;

		public List<int> endless_use_hero_list;

		public int endless_magic_refresh_count;

		public bool endless_magic_used;

		public int endless_magic_buffid;

		public bool daily_108_get_hero_skill;

		public int daily_108_hero_id;

		public List<string> mUsedMaps;

		public bool used_1136_buff_flag;

		public Dictionary<int, List<EndlessDrop>> m_dicEndlessNextRoomDrops;

		public bool mShowEventTowerSkillPoolUI;

		public int mCurEventTowerId;

		public int mCurEventTowerDifficulty;

		public bool m_bShowSkillPoolUI;

		public int m_nCurTowerId;

		public int m_nTowerSkillCnt;

		public List<int> m_listTowerSkillPool;

		public bool isHeroDead;

		public bool isWatchingAD;

		public const int AVAILABLE_FRESH_SKILL_CARD_COUNT = 3;

		public int CurFreshSkillCardCount;

		public int noobSkillCount;

		public bool isFirstPlay;

		public Dictionary<int, Dictionary<string, float>> m_dicSkillAddtions;

		public List<int> m_listSkillRemoveSet;

		public bool UsedAFuReviveFlag;

		public int KillMonsterCnt;

		public int KillBossCnt;

		public List<uint> m_vecShowIds;

		public bool m_bHasShowMysticShop;

		public bool m_bIsWingOfDemonSkill4Effect;

		public float m_fBloodLossTotal;

		public int m_nHpFoodTotal;

		public int recordSkillIndex;

		public int recordSkillID;

		public bool curBattleHaveRecord;

		public int m_nHpFoodTotal2;

		public int GuGuFoeverBuffTims;

		public float m_fTotalAddByKillEnemy;

		public int m_nBulletCnt;

		public int m_nChargeValue;

		public int CurSakuraCount;

		public int CurMonkeyHairCount;

		public int CurWuKongCoreEnergy;

		public int CurWuKongMonsterKilledCount;

		public int StarSkillIdForHammer;

		public int StartSkillIdForKatana;

		public int m_nFengRenBoxCnt;

		public bool m_bUseBigMap;

		public Dictionary<int, PartnerSave> m_dicPartners;

		public Dictionary<int, bool> m_dicPartnerGoodsUsed;

		public List<int> m_listGains;

		public float m_fAssistCdTime;

		public float m_fAssistTime;

		public int m_nAssistanterId;

		public int[] m_aryAssistanterSkills;

		public long m_lAssistHpMax;

		public int m_nAssistIndex;

		public long m_lTotalVampire;

		public long m_lTotalLoseHp;

		public int m_nTotalAbsorbHp;

		public int m_nShieldCount;

		public int m_nRelics700001CD;

		public float m_fTotalAddRatio;

		public Dictionary<int, List<int>> m_dicArtifactSkills;

		public int m_nCalArtifactSkillUIShowTimes;

		public int Play128CurLevelId;

		public long Daily130AccumulatedDamage;

		public long Daily130SettlementDamage;

		public int Daily130BattleId;

		public bool Daily130IsTryPlay;

		public int m_nAct7thAnniversaryBattleHeroId;

		public float m_fCritRateAddTotal;

		public Dictionary<int, int> m_lstFogRooms;

		public Dictionary<int, bool> m_lstVisionMistRooms;

		public bool m_bHasToxicfog;

		public bool m_bHasVisionMist;

		public Dictionary<uint, ServerDropEquips> m_dicDropEquipDatas;

		public Dictionary<int, List<int>> m_dicDropEequips;

		public uint m_nDropEquipTransId;

		public Dictionary<int, int> m_dicKilledMonsters;

		public int m_nMulanRotateSwordCnt;

		public bool m_bMulanDropHpUsed;

		public Dictionary<int, int> m_dicMazeNpcTimes;

		public int MazeNpcId;

		public List<int> m_listMazeEquips;

		public Dictionary<int, MazeEquip2> m_listMazeEquips2;

		public int Maze_CurrentLine;

		public int Maze_LastLine;

		private Dictionary<int, MazeItemData> _mazeFoodDic;

		private Dictionary<int, MazeEquip> _mazeEquipPostions;

		private List<MazeItemData> _mazeItemList;

		public int m_nOperateType;

		public int m_nValentineBabyId;

		public bool m_bHasGetValentineBaby;

		public List<int> m_listNpcSkills;

		public int m_nValentineSkinId;

		public List<int> m_listNpcs;

		public Dictionary<int, List<string>> m_dicNpcs;

		public Dictionary<int, int> m_dicNpcWeapons;

		public Dictionary<int, List<int>> m_dicNpcSkills;

		public Dictionary<int, List<int>> m_dicNpcSlotSkills;

		public int m_nMaxConsecutiveHits;

		public int m_nKillMonsterNum;

		public long m_lMaxHit;

		public long m_lTotalHit;

		public long m_lTotalRecoverLife;

		public float m_fPassStageTime;

		public Dictionary<string, List<int>> m_dicBabySkills;

		public int RoleReversaId;

		public int ElkCount;

		public bool HasMeetSanta;

		public bool HasExchangeSantaGift;

		public int m_nKillBossCntByEquip_1020508;

		[NonSerialized]
		private int m_nRefreshDungeonSlotinCnt;

		public List<int> m_listDungeonBuffs;

		public int m_nPveSeasonSelectedHero;

		public int m_nPveSeasonWeekTopic;

		public long m_nPveSeasonStartTime;

		public long m_nPveSeasonEndTime;

		public List<int> m_listTreasuresSkills;

		public List<int> m_listCullSkills;

		public int m_nTotalIntegral;

		public float m_fTotalAddedAttackSpeedPercent;

		public float m_fTotalAddedMoveSpeedPercent;

		public int m_nUsedFreshSkillCardCount;

		public NewPlay120VO newPlay120;

		public NewPlay121VO newPlay121;

		public HeroAssistVO heroAssistVO;

		public TowerDefenseVO towerDefenseVO;

		public CampBattleVO campBattleVO;

		public WeaponSkinsVO weaponSkinsVO;

		public Skill1722VO skill1722VO;

		public Santa2023VO santa2023VO;

		public Skill1744VO skill1744VO;

		public Skill1770VO skill1770VO;

		public Skill1780VO skill1780VO;

		public Skill1782VO skill1782VO;

		public Skill1784VO skill1784VO;

		public Skill1810VO skill1810VO;

		public Skill1971VO skill1971VO;

		public Skill1974VO skill1974VO;

		public DragonVO dragonVO;

		public SphereFlashVO sphereFlashVO;

		public HammerSkillVO hammerSkillVO;

		public AthenaFlashVO athenaFlashVO;

		public HammerPassiveV0 hammerPassiveV0;

		public LancePassiveV0 lancePassiveV0;

		public TridentDivinityV0 tridentDivinityV0;

		public HeroSkinVO heroSkinVO;

		public PetsVO petsVO;

		public DailyRoleReversalSkillVO dailyRoleReversalSkillVO;

		public Skill2184VO skill2184VO;

		public SkillAlone1800 skill1800VO;

		public Skill2186VO skill2186VO;

		public ArtifactGameSkillData artifactGameSkillData;

		public Skill2230VO skill2230VO;

		public Skill2236VO skill2236VO;

		public ArtifactInGameData artifactInGameData;

		public Skill2250VO skill2250VO;

		public List<string> currentRewardIfWinList;

		public List<int> EventTowerAlternativeSkills;

		public Daily129BattleData daily129BattleData;

		public LocalNewPlay125VO NewPlay125VO;

		public LocalNewPlay126VO NewPlay126VO;

		public int killMonster
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int HPDrop
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float TotalAddByKillEnemy
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public float BloodLossTotal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Dictionary<int, MazeItemData> MazeFoodDic => null;

		public Dictionary<int, MazeEquip> MazeEquipPostions => null;

		public List<MazeItemData> MazeItemList => null;

		public int RefreshDungeonSlotinCnt
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override string filename => null;

		public BattleInBase()
		{
		}

		public BattleInBase(ulong serveruserid)
		{
		}

		public static string GetFileName(ulong serveruserid)
		{
			return null;
		}

		private void ResetSailing()
		{
		}

		private void ResetAngelOfLight()
		{
		}

		private void ResetSkillAlone1499()
		{
		}

		private void ResetCurSakuraCount()
		{
		}

		private void ResetCurMonkeyHairCount()
		{
		}

		private void ClearDaily118Save()
		{
		}

		private void ResetAssistData()
		{
		}

		private void ResetColorEquipSkillSave()
		{
		}

		public void ResetRelics()
		{
		}

		public void ResetWeaponSkinSkill()
		{
		}

		public void ClearArtifactStar()
		{
		}

		public void Clear7thAnniversaryBattleStage()
		{
		}

		public void Set7thAnniversaryBattleStage(int stage)
		{
		}

		public void SaveAct7thAnniversaryBattleHeroId(int id)
		{
		}

		public void AddDeadBabyUniqueEquipId(string uniqueId)
		{
		}

		public bool ContainDeadBabyUniqueEquipId(string uniqueId)
		{
			return false;
		}

		public void AddResistBabyUniqueEquipId(string uniqueId)
		{
		}

		public bool ContainResistBabyUniqueEquipId(string uniqueId)
		{
			return false;
		}

		public void AddCumulatedDeltaHPMaxPercent(float value)
		{
		}

		public void AddCumulatedDeltaHP(long value)
		{
		}

		public void ClearCumulatedDeltaHPMaxPercent()
		{
		}

		public void ClearCumulatedDeltaHP()
		{
		}

		public void UpdateReducedHPInSkillAlone1318(long deltaValue)
		{
		}

		public void ClearReducedHPInSkillAlone1318()
		{
		}

		public void UpdateBoolDict(string key, bool value)
		{
		}

		public bool GetBool(string key)
		{
			return false;
		}

		public void ClearBoolDict()
		{
		}

		public void UpdateCumulatedAttrDict(string key, float value)
		{
		}

		public void SetCumulatedAttrDict(string key, float value)
		{
		}

		public void ClearCumulatedAttrDict()
		{
		}

		public float GetCumulatedAttrValue(string key)
		{
			return 0f;
		}

		public float GetMaxCumulatedDeltaHPMaxPercent()
		{
			return 0f;
		}

		public void UpdateCurMagicPoints(float deltaMagicPoints)
		{
		}

		public void UpdateLowerHPDict(string valueKey, int buffId)
		{
		}

		public bool HasBuffIdInLowerHPDict(string valueKey)
		{
			return false;
		}

		public int GetBuffIdInLowerHPDict(string valueKey)
		{
			return 0;
		}

		public void UpdatePersistentValueDict(string key, float value)
		{
		}

		public bool HasPersistenValue(string key)
		{
			return false;
		}

		public float GetPersistenValue(string key)
		{
			return 0f;
		}

		public void UpdatePersistentBuffDict(string valueKey, int buffId)
		{
		}

		public bool HasBuffIdInPersistentBuffDict(string valueKey)
		{
			return false;
		}

		public int GetBuffIdInPersistentBuffDict(string valueKey)
		{
			return 0;
		}

		public void UpdatePersistentBuffListDict(string valueKey, int buffId)
		{
		}

		public bool HasBuffIdInPersistentBuffListDict(string valueKey)
		{
			return false;
		}

		public List<int> GetBuffIdInPersistentBuffListDict(string valueKey)
		{
			return null;
		}

		public void Add2IncreasedValueByReducedValue2Dict(string key, float deltaValue)
		{
		}

		public void Add2ReducedValueByIncreasedValue2Dict(string key, float deltaValue)
		{
		}

		public float GetReducedValueByIncreasedValue2(string key)
		{
			return 0f;
		}

		public float GetIncreasedValueByReducedValue2(string key)
		{
			return 0f;
		}

		public void IncreaseMPNum()
		{
		}

		public void ResetMPNum()
		{
		}

		public void InitCurMagicPoints(float value)
		{
		}

		public void ClearMagicPoints()
		{
		}

		public void ClearDeadBabyList()
		{
		}

		public void ClearResistedBabyList()
		{
		}

		public void SaveCritRateAddTotal(float value)
		{
		}

		public bool SetDropEquips(string json)
		{
			return false;
		}

		public List<int> GetDropEquipIds(int levelId)
		{
			return null;
		}

		public bool CanDropEquip(int levelId)
		{
			return false;
		}

		public bool DropEquipByServer()
		{
			return false;
		}

		public ServerDropEquips GetDropEquipDataByTransId(uint transId)
		{
			return null;
		}

		public void KillMonsterInSeason(Dictionary<int, int> dic)
		{
		}

		public float getProcessedDeltaHPMax(float deltaMaxHP, long HPMax)
		{
			return 0f;
		}

		public void AddHPMaxInSkillAlone1331(EntityBase entity, long deltaHP)
		{
		}

		public void IncreaseCurEnergizedHPDropCount()
		{
		}

		public void ClearCurEnergizedHPDropCount()
		{
		}

		private void ResetMulan()
		{
		}

		private void ClearMazeItem()
		{
		}

		public MazeItemData AddFoodItem(int pid, int pcount)
		{
			return null;
		}

		public bool IsHaveFood(int pid)
		{
			return false;
		}

		public bool CanShowMazeFoodShop()
		{
			return false;
		}

		public void AddMazeItem(int pid, MazeItemType ptype, int pos, int pcount)
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

		public void AddEquipInMaze(EquipOne one)
		{
		}

		public MazeEquip2[] GetEquipsInMaze()
		{
			return null;
		}

		public List<int> GetMazeEquipSkills()
		{
			return null;
		}

		public List<int> GetMazeEquipIds()
		{
			return null;
		}

		public bool HasChooseNpc()
		{
			return false;
		}

		public void SetNpcs(List<int> ids)
		{
		}

		public int[] GetNpcIds()
		{
			return null;
		}

		public List<string> GetNpcAttrbute(int id)
		{
			return null;
		}

		public void SetNpcWeapon(int nNpcId, int nWeaponId)
		{
		}

		public int GetNpcWeapon(int nNpcId)
		{
			return 0;
		}

		public void SetNpcSkill(int nNpcId, int nSkillId)
		{
		}

		public List<int> GetNpcSkills(int nNpcId)
		{
			return null;
		}

		public bool NpcCanLevelUp()
		{
			return false;
		}

		public void SaveNpcSlotSkills(int id, List<int> list)
		{
		}

		public List<int> GetNpcSlotSkills(int id)
		{
			return null;
		}

		public void SaveBattleStatistic(int nMaxConsecutiveHits, int nKillMonsterNum, long lMaxHit, long lTotalHit, long lTotalRecoverLife, float fPassLevelTime)
		{
		}

		public void SaveTotalRecoverLife(long lTotalRecoverLife)
		{
		}

		public (int, int, long, long, long, float) GetBattleStatistic()
		{
			return default;
		}

		public float GetPassStageTime()
		{
			return 0f;
		}

		public void AddEndlessDrop(int roomId, int id, int cnt)
		{
		}

		public void ClearEndlessDropByRoomId(int roomId)
		{
		}

		public void ClearEndlessDrop()
		{
		}

		public List<EndlessDrop> GetEndlessDropByRoomId(int roomId)
		{
			return null;
		}

		public void AddBabySkill(string key, int skillId)
		{
		}

		public List<int> GetBabySkill(string key)
		{
			return null;
		}

		public bool IsHasChooseRole()
		{
			return false;
		}

		public int GetRoleReversaId()
		{
			return 0;
		}

		public void SetRoleReversaId(int id)
		{
		}

		public void SaveEquip1020508KillBossCnt(int value)
		{
		}

		public int GetEquip1020508KillBossCnt()
		{
			return 0;
		}

		public int GetDunGeonBuffEffect()
		{
			return 0;
		}

		public void AddDungeonBuffId(int id)
		{
		}

		public void AddTreasuresSkill(int id)
		{
		}

		public void AddCullSkill(int group)
		{
		}

		public void ResetPveSeason()
		{
		}

		public void ResetCrossbowSkill()
		{
		}

		public void ResetImPrintSkillLocalData()
		{
		}

		public void UpdateUsedFreshSkillCard()
		{
		}

		public int GetSkillCardsPerFresh()
		{
			return 0;
		}

		protected override void OnRefresh()
		{
		}

		public void SetDirtyWrapper()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void StartANewBattle()
		{
		}

		public void DeInit(DeInitSourceType sourceType = DeInitSourceType.None)
		{
		}

		protected virtual void OnDeInit()
		{
		}

		public uint GetTransID(bool newtransid)
		{
			return 0u;
		}

		public void ClearTransID()
		{
		}

		public void AddRebornSkill()
		{
		}

		public void AddRebornUI()
		{
		}

		public void UpdateEquip(EquipOne one)
		{
		}

		public void AddUsedTmx(string tmxid)
		{
		}

		public void ClearUsedTmx()
		{
		}

		public List<string> GetUsedTmx()
		{
			return null;
		}

		public void LevelInit()
		{
		}

		public void AddPotion(int id)
		{
		}

		public bool GetHaveBattle()
		{
			return false;
		}

		public void SetHaveBattle(bool value)
		{
		}

		public bool CheckDifferentID()
		{
			return false;
		}

		protected override void OnDeserialized(StreamingContext context)
		{
		}

		public static BattleInBase Get()
		{
			return null;
		}

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		private void ResetDaily129()
		{
		}

		public void SetDaily129FinishedWave(uint wave)
		{
		}

		public int GetDaily129SuperSkillId()
		{
			return 0;
		}

		public void SaveDaily129SuperSkillId(int id)
		{
		}
	}

	public enum NewBpBelongType
	{
		None = 0,
		Main = 1,
		UserBack = 2
	}

	[Serializable]
	public class BattlePassConfigAllData
	{
		public BattlePassConfigData[] dataArray;
	}

	[Serializable]
	public class BattlePassConfigData
	{
		public long startTime;

		public long endTime;

		public int tag;

		public int eventId;

		public int rate;

		public BattlePassConfigData_Unit[] dataArray;

		public BattlePassConfigData_Extra extra_reward;

		public bool isGain;

		public int conditionType;

		public int sweepCntAdd;

		public int sweepCoinAdd;

		public bool isNew;

		public int dropRelicsAdd;

		public int harvestQuickAdd;

		public int dropBossEggAdd;
	}

	[Serializable]
	public class BattlePassConfigData_Unit
	{
		public int id;

		public string reward_pass;

		public string reward_pass_big;

		public string reward_free;

		public int conditionParam;
	}

	[Serializable]
	public class BattlePassConfigData_Extra
	{
		public int cnt;

		public string reward;

		public string rewardBig;

		public int conditionParam;
	}

	public class BattlePassData : LocalSaveBase
	{
		public bool isActive;

		private bool isPremiumActive;

		private ulong killCount;

		private uint curBattlePassTag;

		private byte[] rewardState;

		private long lastKillCount;

		private ushort extraRewardState;

		private bool isPermanentActive;

		private bool isPremiumPermanentActive;

		public bool isSync { get; private set; }

		public void Clear()
		{
		}

		protected override void OnRefresh()
		{
		}

		public uint GetServerBattlePassTag()
		{
			return 0u;
		}

		public void Init(CRespBattlepassReward data)
		{
		}

		public void setRewardState(CRespBattlepassReward data)
		{
		}

		public void AddKillMonster(uint count)
		{
		}

		public void UpdateKillMonster(uint count)
		{
		}

		public int GetLastKillMonsterNum()
		{
			return 0;
		}

		public int GetKillMonsterNum()
		{
			return 0;
		}

		public int GetExtraRewardCount()
		{
			return 0;
		}

		public void ClearLastKillCount()
		{
		}

		public bool isAllReadyGet(int id, int index)
		{
			return false;
		}

		public void OnGetReward(int id, int index)
		{
		}

		public void OnGetExtraReward()
		{
		}

		public long GetLastTime()
		{
			return 0L;
		}

		public long GetPastTime()
		{
			return 0L;
		}

		public bool IsPremiumActive()
		{
			return false;
		}

		public void SetPremium(bool active)
		{
		}

		public bool isNormalActive()
		{
			return false;
		}

		public bool IsNormalPermanentActive()
		{
			return false;
		}

		public bool IsPremiumPermanentActive()
		{
			return false;
		}
	}

	public enum NewBpType
	{
		None = 0,
		Main = 1,
		Equip = 2,
		Pet = 3,
		Dragon = 4,
		Imprint = 5,
		Manor = 6,
		UserBack = 7,
		Totem = 8
	}

	[Serializable]
	public class BattlePassNewItemConfig
	{
		public int tag;

		public int starTime;

		public int endTime;

		public int minversion;

		public int maxversion;

		public int conditionType;

		public int eventId;

		public string[] productid;

		public int rate;

		public int minLayer;

		public int[] layer;

		public int cnt;

		public int conditionParam;

		public string[][] reward;

		public string[][] bigreward;

		public int kvhero;

		public string kvboximage;

		public string[][] battlePassPower;

		public string[][] bigBattlePassPower;
	}

	public class BattlePassNewData
	{
		public int Tag;

		public long StartTime;

		public long EndTime;

		public int EventId;

		public List<BattlePassNewItemData> LineItem;

		public Drop_DropModel.DropData ExtraReward;

		public Drop_DropModel.DropData ExtraBigReward;

		public int ExtraGotCnt;

		public int ScoreBuyCost;

		public int TotalScore;

		public bool IsNormalActive;

		public bool IsPremiumActive;

		public NewBpType BpType;

		public NewBpBelongType BpBelongType;
	}

	public class BattlePassNewItemData
	{
		public int ID;

		public int Target;

		public BattlePassNewItemRewardData Reward;

		public bool IsGot;

		public bool IsNormalGot;

		public bool IsPremiumGot;

		public bool IsActive;

		public bool IsNormalActive;

		public bool IsPremiumActive;

		public NewBpType BpType;

		public int Tag;
	}

	public class BattlePassNewItemRewardData
	{
		public Drop_DropModel.DropData FreeReward;

		public Drop_DropModel.DropData NormalReward;

		public Drop_DropModel.DropData PremiumReward;
	}

	public class NewBpPrivilegeItemData
	{
		public int PowerType;

		public int PowerValue;
	}

	public class BPBuyItemData
	{
		public NewBpType type;

		public string productId;

		public bool active;

		public int bp;
	}

	[Serializable]
	public class LocalPetVO
	{
		public float curEnergy;

		public int curReleaseTime;
	}

	[Serializable]
	public class PetsVO
	{
		public Dictionary<int, LocalPetVO> PetDict;

		public void Clone(PetsVO source)
		{
		}

		public void SyncPetReleaseTimes(int petId, int curReleaseTime)
		{
		}

		public int GetPetReleaseTimes(int petId)
		{
			return 0;
		}

		public void SyncPetEnergy(int petId, float curEnergy)
		{
		}

		public float GetPetEnergy(int petId)
		{
			return 0f;
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class HeroSkinVO
	{
		public int CurLightedFlags;

		public float CurMaxHealthRiseRate;

		public void Clone(HeroSkinVO source)
		{
		}

		public void SyncCurLightedFlags(int value)
		{
		}

		public void SyncCurMaxHealthRiseRate(float value)
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class HammerSkillVO
	{
		public long initialHP;

		public void Clone(HammerSkillVO source)
		{
		}

		public void SyncInitialHP(long _value)
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class SphereFlashVO
	{
		public float CurGodStateCDTime;

		public int CurSphereFlashGrids;

		public bool IsSphereFlashRebornUsed;

		public void Clone(SphereFlashVO source)
		{
		}

		public void SyncCurGodStateCDTime(float _value)
		{
		}

		public void SyncIsSphereFlashRebornUsed(bool _value)
		{
		}

		public void SyncCurSphereFlashGrids(int _value)
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class AthenaFlashVO
	{
		public float FlashEnergyCurrent;

		public int FlashLayerCurrent;

		public void Clone(AthenaFlashVO source)
		{
		}

		public void SyncFlashEnergy(float energy, int layer)
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class DragonVO
	{
		public float CurMissRatePercent;

		public bool HasAddBulletHit;

		public int CallEmeraldDragonTimes;

		public void Clone(DragonVO source)
		{
		}

		public void Clear()
		{
		}

		public void SyncHasAddBulletHit(bool _value)
		{
		}

		public void SyncCurMissRatePercent(float _value)
		{
		}

		public void SyncCallEmeraldDragonTimes(int _value)
		{
		}
	}

	[Serializable]
	public class Santa2023VO
	{
		public List<int> DIYDropWeaponIds;

		public List<int> DiyDropCompIds;

		public bool InitNPCFinished;

		public List<int> InitWeaponIds;

		public int CurDIYWeaponId;

		public List<int> CurEquippedDiyComIds;

		public Dictionary<int, bool> DiyCompNewDict;

		public Santa2023VO Clone(Santa2023VO source)
		{
			return null;
		}

		public void Clear()
		{
		}

		public void SyncDiyCompNewDict(Dictionary<int, bool> dict)
		{
		}

		public void SyncCurEquippedDiyComIds(List<int> list)
		{
		}

		public void SyncDIYDropWeaponIds(List<int> list)
		{
		}

		public void SyncDiyDropCompIds(List<int> list)
		{
		}

		public void SyncCurDIYWeaponId(int _weaponId)
		{
		}

		public void SyncInitNPCFinished(bool _value)
		{
		}

		public void SyncInitWeaponIds(List<int> _weaponIds)
		{
		}
	}

	[Serializable]
	public class CampBattleVO
	{
		public int TileId;

		public int SLGTileIndex;

		public int SLGZoneId;

		public int SLGTileLevel;

		public int SLGStageId;

		public int FinishedRound;

		public long SLGTalent;

		public long SLGCampTalent;

		public SLGTileVO slgTileVO;

		public string camp_type;

		public void Clone(CampBattleVO source)
		{
		}

		public void SyncCampType(string _type)
		{
		}

		public void SyncSlgTileVO(SLGTileVO _vo)
		{
		}

		public void SyncSLGTalent(long _value)
		{
		}

		public void SyncSLGCampTalent(long _value)
		{
		}

		public void SyncFinishedRound(int _value)
		{
		}

		public void SyncTileId(int _value)
		{
		}

		public void SyncTileIndex(int _value)
		{
		}

		public void SyncSLGZoneId(int _value)
		{
		}

		public void SyncTileLevel(int _value)
		{
		}

		public void SyncStageId(int _value)
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class TowerDefenseVO
	{
		[Serializable]
		public class TDVO
		{
			public int TowerId;

			public int CurTowerLevel;

			public int Col;

			public int Row;

			public List<int> LearnedSkillIds;

			public List<int> NextLevelSkillIds;

			public string PrintInfo()
			{
				return null;
			}

			public TDVO Clone()
			{
				return null;
			}
		}

		public bool IsGameWin;

		public bool AllMonsterCreated;

		public int CurTDLevelId;

		public int FinishedTDWaveId;

		public int CurTDCoin;

		public long CurTDBaseHP;

		public List<TDVO> tdVOList;

		public List<int> DailyAlternativeTowerIds;

		public int TD_HurtNum;

		public long TD_MaxHP;

		public long TD_MaxAtk;

		public long TD_MaxToken;

		public long TD_CostToken;

		public void Clone(TowerDefenseVO source)
		{
		}

		public void SyncDailyAlternativeTowerIds(List<int> _DailyAlternativeTowerIds)
		{
		}

		public void SaveGameWin()
		{
		}

		public TDVO FindTDVO(EntityTD2023Base entityTower)
		{
			return null;
		}

		public List<int> GetTowerNextLevelSkillIds(EntityTD2023Base entityTower)
		{
			return null;
		}

		public void OnOpenLevelUp(EntityTD2023Base entityTower, List<int> _nextLevelSkillIds)
		{
		}

		public TDVO OnCreateTower(EntityTD2023Base entityTower)
		{
			return null;
		}

		public void OnLevelUpSuccess(EntityTD2023Base entityTower)
		{
		}

		public void SaveCurTDBaseHP(long _value)
		{
		}

		public void SaveCurTDLevelId(int levelId)
		{
		}

		public void SaveFinishedTDWaveId(int waveId)
		{
		}

		public void SaveCurTDCoin(int _tdCoin)
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class HeroAssistVO
	{
		public bool CanDropHPInSkillAlone1639;

		public int OpheliaAbsorbSoulCount { get; set; }

		public int DropCountInSkillAlone1640 { get; set; }

		public bool IsAttrInSkillAlone1641Added { get; set; }

		public void IncreaseOpheliaAbsorbSoulCount()
		{
		}

		public void Clear()
		{
		}

		public void SetCanDropHPInSkillAlone1639(bool _value)
		{
		}

		public void SetDropCountInSkillAlone1640(int _value)
		{
		}

		public void Clone(HeroAssistVO source)
		{
		}
	}

	[Serializable]
	public class NewPlay121VO
	{
		public bool FirstSkillOpened;

		public List<int> LearnedSkillIds;

		public List<int> CacheFirstSkills;

		public void SetCacheFirstSkills(List<int> skillIds)
		{
		}

		public void Add2LearnedSkillIds(int skillId)
		{
		}

		public bool HasLearnedSkill(int skillId)
		{
			return false;
		}

		public void ClearLearnedSkillIds()
		{
		}

		public void Clear()
		{
		}

		public void Clone(NewPlay121VO source)
		{
		}
	}

	public interface ICloneable<T>
	{
		void Clone(T source);
	}

	[Serializable]
	public class NewPlay120VO : ICloneable<NewPlay120VO>
	{
		public int NPCRoomId;

		public List<int> NPCSkillIds;

		public bool NPCUsed;

		public void Clear()
		{
		}

		public void OnNPCExit()
		{
		}

		public void ResetNPCSkillIds()
		{
		}

		public void AddNPCSkillId(int skillId)
		{
		}

		public void SetNPCRoomId(int roomId)
		{
		}

		public void Clone(NewPlay120VO source)
		{
		}
	}

	[Serializable]
	public class WeaponSkinsVO : ICloneable<WeaponSkinsVO>
	{
		public int killNormalMonsterCount;

		public int killBossMonsterCount;

		public void Clone(WeaponSkinsVO source)
		{
		}

		public void AddKillNormalMonsterCount(int killNormalMonsterCount)
		{
		}

		public void AddKillBossMonsterCount(int killBossMonsterCount)
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class HammerPassiveV0 : ICloneable<HammerPassiveV0>
	{
		public int FlashPoint;

		public int HammerPoint;

		public void Clone(HammerPassiveV0 source)
		{
		}

		public void AddFlashPoint(int count)
		{
		}

		public void ReduceFlashPoint(int count)
		{
		}

		public void AddHammerPoint(EntityBase entity, int count, bool isChangeLocal)
		{
		}

		public void ReduceHammerPoint(EntityBase entity, int count, bool isChangeLocal)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class LancePassiveV0 : ICloneable<LancePassiveV0>
	{
		public float DarkEnergy;

		public float DarkEnergyLimit;

		public void Clone(LancePassiveV0 source)
		{
		}

		public void SetLimit(float limit)
		{
		}

		public void AddEnergyPoint(float count)
		{
		}

		public void ReduceEnergyPoint(float count)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class TridentDivinityV0 : ICloneable<TridentDivinityV0>
	{
		public float DivinityValue;

		public float DivinityValueLimit;

		public float DivinityThreshold;

		public void Clone(TridentDivinityV0 source)
		{
		}

		public void SetLimit(float limit)
		{
		}

		public void SetThreshold(float threshold)
		{
		}

		public void AddDivinity(float count)
		{
		}

		public void ReduceDivinity(float count)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill1974VO : ICloneable<Skill1974VO>
	{
		public float haveAddCritRate;

		public void Clone(Skill1974VO source)
		{
		}

		public void AddCritRate(float addCount)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill1971VO : ICloneable<Skill1971VO>
	{
		public bool haveAddBuff;

		public void Clone(Skill1971VO source)
		{
		}

		public void SetHaveAddBuff(bool haveAdd)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill1810VO : ICloneable<Skill1810VO>
	{
		public Dictionary<int, float> enemyData;

		public void Clone(Skill1810VO source)
		{
		}

		public void AddEnemyData(int enemyGuid, float curTime)
		{
		}

		public bool CanAddHammerPoint(int enemyGuid, float cd, float curTime)
		{
			return false;
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill1784VO : ICloneable<Skill1784VO>
	{
		public bool needCheckAddLightingShield;

		public void Clone(Skill1784VO source)
		{
		}

		public void NeedCheckAddLightingShield(bool need)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill1782VO : ICloneable<Skill1782VO>
	{
		public List<float> timeLeft;

		public void Clone(Skill1782VO source)
		{
		}

		public void AddTimeLeft(float time)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill1780VO : ICloneable<Skill1780VO>
	{
		public int addBuffCount;

		public void Clone(Skill1780VO source)
		{
		}

		public void SetBuffCount(int count)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill1770VO : ICloneable<Skill1770VO>
	{
		public Dictionary<int, bool> OpenGachaEggDict;

		public int OpenGachaEggCount;

		public void Clone(Skill1770VO source)
		{
		}

		public void SyncOpenGachaEgg(int roomId, bool opened)
		{
		}

		public bool GetOpenGachaEggByRoomId(int roomId)
		{
			return false;
		}

		public void SyncGachaEggCount(int value)
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class Skill1722VO : ICloneable<Skill1722VO>
	{
		public int eatChickenLegCount;

		public List<Skill1722Data> data;

		public void Clone(Skill1722VO source)
		{
		}

		public void AddEatChickenLegCount()
		{
		}

		public void AddHitEnemyCreateCount(int enemyID)
		{
		}

		public void RemoveEnemyCreateCount(int enemyID)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill1744VO : ICloneable<Skill1744VO>
	{
		public int createStarCount;

		public float coolingTime;

		public void Clone(Skill1744VO source)
		{
		}

		public void AddCreateStarCount()
		{
		}

		public void ClearCreateStarCount()
		{
		}

		public void SetCoolingTime(float time)
		{
		}

		public void ReduceCoolingTime(float time)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class DailyRoleReversalSkillVO : ICloneable<DailyRoleReversalSkillVO>
	{
		public float accumulativeTime;

		public void Clone(DailyRoleReversalSkillVO source)
		{
		}

		public void RefreshTime(float accumulativeTime)
		{
		}

		public void ClearTime()
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill2184VO : ICloneable<Skill2184VO>
	{
		public Dictionary<int, (float, float, float)> createFirePanData;

		public void Clone(Skill2184VO source)
		{
		}

		public void AddFirePanData(int roomID, Vector3 createPos)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class SkillAlone1800 : ICloneable<SkillAlone1800>
	{
		public int needAddBuff;

		public void Clone(SkillAlone1800 source)
		{
		}

		public void SetNeedAddBuff(int needAddBuff)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill2186VO : ICloneable<Skill2186VO>
	{
		public int createThunderCloudRoomID;

		public void Clone(Skill2186VO source)
		{
		}

		public void SetThunderCloudData(int roomID)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class ArtifactGameSkillData : ICloneable<ArtifactGameSkillData>
	{
		public List<ArtifactGameSkillItemData> skillItemDatas;

		public int haveRandomNum;

		[JsonIgnore]
		public List<ArtifactGameSkillItemData> NoReachMaxSkillItemDatas => null;

		[JsonIgnore]
		public List<ArtifactOne> AllEquipArtifact => null;

		[JsonIgnore]
		public int MaxLearnSkillCount => 0;

		[JsonIgnore]
		public int NoReachMaxSkillMaxLearnSkillCount => 0;

		[JsonIgnore]
		public int HaveLearnSkillCount => 0;

		public void Clone(ArtifactGameSkillData source)
		{
		}

		public ArtifactGameSkillItemData RandomArtifactGameSkill()
		{
			return null;
		}

		public bool CanArtifactLearnSkill(int artifactID)
		{
			return false;
		}

		public ArtifactGameSkillItemData ArtifactLearnSkill(int artifactID)
		{
			return null;
		}

		public void AddRandomCount(int addCount = 1)
		{
		}

		public void ClearRandomCount()
		{
		}

		public string GetArtifactGameSkillRecordData()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class ArtifactGameSkillItemData : ICloneable<ArtifactGameSkillItemData>
	{
		public int artifactID;

		public List<int> learnSkillIDList;

		public int newestLearnSkillID;

		[JsonIgnore]
		public int LearnSkillCount => 0;

		[JsonIgnore]
		public List<int> AllCanLearnSkillList => null;

		[JsonIgnore]
		public bool IsMax => false;

		public void AddSkill(int leanSkillID)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}

		public static ArtifactGameSkillItemData Create(int artifactID)
		{
			return null;
		}

		public void Clone(ArtifactGameSkillItemData source)
		{
		}

		public ArtifactGameSkillItemData Clone()
		{
			return null;
		}
	}

	[Serializable]
	public class Skill2230VO : ICloneable<Skill2230VO>
	{
		public long storeDeltaHP;

		public long accumulatedHeal;

		public void Clone(Skill2230VO source)
		{
		}

		public void SetStoreDeltaHP(long storeHP)
		{
		}

		public void AddAccumulatedHeal(long heal)
		{
		}

		public long ConsumeAccumulatedHeal()
		{
			return 0L;
		}

		public bool HasPendingRestoreData()
		{
			return false;
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill2236VO : ICloneable<Skill2236VO>
	{
		public int haveAddDmgCount;

		public int haveAddSkillLastCount;

		public void Clone(Skill2236VO source)
		{
		}

		public void AddDmgCount(int addCount)
		{
		}

		public void AddSkillLastCount(int addCount)
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class ArtifactInGameData : ICloneable<ArtifactInGameData>
	{
		public List<ArtifactOne> equipArtifactInGame;

		public void Clone(ArtifactInGameData source)
		{
		}

		public void SetGameEquipArtifact(List<ArtifactOne> equipArtifactInGame)
		{
		}

		public bool IsHaveData()
		{
			return false;
		}

		public string GetArtifactRecordData()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class Skill2250VO : ICloneable<Skill2250VO>
	{
		public bool haveTriggerReborn;

		public int layerCount;

		public float curLoseHpPercent;

		public void Clone(Skill2250VO source)
		{
		}

		public void SetHaveTriggerRebornStatus(bool trigger)
		{
		}

		public void AddLayerCountData(int addLayerCount)
		{
		}

		public void AddLoseHpPercent(float percent)
		{
		}

		public void ResetLoseHpPercent()
		{
		}

		public void Clear()
		{
		}

		public void ClearImmediately()
		{
		}
	}

	[Serializable]
	public class DropCard : LocalSaveBase
	{
		public int count;

		public int dropid;

		protected override void OnRefresh()
		{
		}

		public void InitCount(int allcount)
		{
		}

		public Drop_DropModel.DropData GetRandom()
		{
			return null;
		}

		public void GetSucceed()
		{
		}
	}

	[Serializable]
	public class CampData : LocalSaveBase
	{
		public LocalCampTalentData talentData;

		public CampTownSkinLocalData townSkinData;

		public Dictionary<int, int> campBoxTipsDict;

		public Dictionary<ulong, long> campTeamInviteTime;

		public long campTeamInviteLastDay;

		public int campTeamInviteCount;

		protected override string filename => null;

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void ClearCampTownSKinData()
		{
		}

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}
	}

	[Serializable]
	public class CardOne
	{
		public int HaveCount;

		[JsonIgnore]
		private ObscuredInt _CardID;

		[JsonIgnore]
		private ObscuredInt _level;

		[JsonIgnore]
		private Skill_slotout _data;

		public int CardID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int Priority => 0;

		[JsonIgnore]
		public Skill_slotout data => null;

		[JsonIgnore]
		public bool Unlock => false;

		[JsonIgnore]
		public bool IsMaxLevel => false;

		public CardOne()
		{
		}

		public CardOne(int cardid, int level, int count)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string GetValue(string value)
		{
			return null;
		}

		public string GetTypeName(int index)
		{
			return null;
		}

		public string GetLastAttribute(int index)
		{
			return null;
		}

		public string GetCurrentAttribute(int index)
		{
			return null;
		}

		public string GetNextAttribute(int index)
		{
			return null;
		}

		private string GetAttribute(int index, int addlevel)
		{
			return null;
		}
	}

	[Serializable]
	public class CardData : LocalSaveBase
	{
		public static readonly int CardIdMin;

		public static readonly int CardIdMax;

		public Dictionary<int, CardOne> mList;

		public AltarData altarData;

		public bool haveUnlockPanel;

		protected override void OnRefresh()
		{
		}

		public void Init()
		{
		}

		private bool IsEmpty()
		{
			return false;
		}

		public int GetCount()
		{
			return 0;
		}

		public CardOne AddOne(int cardid, int count)
		{
			return null;
		}

		public void SetOne(int cardid, int level)
		{
		}

		public Dictionary<int, CardOne> GetCards()
		{
			return null;
		}

		public CardOne GetCardByID(int id)
		{
			return null;
		}

		public bool HaveCard(int id)
		{
			return false;
		}

		private int GetIndex(CardOne one)
		{
			return 0;
		}

		public bool GetAllMax()
		{
			return false;
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class CargoShipInfo
	{
		public long PayExileStartTime;

		public long PayExileTime;

		public void Init()
		{
		}

		public void SyncPayExileTime(long timestamp)
		{
		}

		public void SyncPayExileStartTime(long timestamp)
		{
		}
	}

	[Serializable]
	public class ChallengeData : LocalSaveBase
	{
		public int ChallengeID;

		public bool bFirstIn;

		public bool isinit;

		protected override void OnRefresh()
		{
		}
	}

	[Serializable]
	public class ChallengeMode : LocalSaveBase
	{
		public int CurrentID;

		public bool bCanReward;

		protected override void OnRefresh()
		{
		}

		public int GetChallengeID()
		{
			return 0;
		}

		public int GetCurrentID()
		{
			return 0;
		}

		public void CurrentEnd()
		{
		}

		public void GetReward()
		{
		}

		public bool CanReward()
		{
			return false;
		}

		public int GetCurrentKey()
		{
			return 0;
		}
	}

	[Serializable]
	public class CharacterData : LocalSaveBase
	{
		public class LockEffectData
		{
			public int unlocklevel;

			public string goodtype;

			public int value;

			private bool is_all_heroes_init;

			private bool is_all_heroes;

			private string _goodtypebase;

			public bool IsAllHeroes => false;

			public string goodtypebase => null;
		}

		public Dictionary<int, CharacterOne> characterDic;

		public Dictionary<int, List<int>> heroAssistDict;

		private ObscuredInt _curCharacter;

		public int curCharacter
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Clear()
		{
		}

		public void SetData(List<CEquipmentItem> list, CHeroItem[] arrayHeroStars)
		{
		}

		protected override void OnRefresh()
		{
		}

		public int GetCurCharacterId()
		{
			return 0;
		}

		public bool SelectCharacter(int id)
		{
			return false;
		}

		public void SyncCharacterByServer(int id)
		{
		}

		public void AddNewCharacter(PlayerCharacter_Character data)
		{
		}

		public void AddNewCharacter(CEquipmentItem data)
		{
		}

		public bool HasCharacter(int id)
		{
			return false;
		}

		public CharacterOne GetCharacter(int id)
		{
			return null;
		}

		public int GetCanUpgradeMaxLevel()
		{
			return 0;
		}

		public CharacterOne GetCurCharacter()
		{
			return null;
		}

		public bool IsCurCharacterCanLevelUp()
		{
			return false;
		}

		public void UpdateCharacterLevel(int charid, int level)
		{
		}

		public void UpdateCharStarId(int charid, int level)
		{
		}

		public List<LockEffectData> GetAllHeroesAttributes()
		{
			return null;
		}

		public bool is_any_character_upgraded()
		{
			return false;
		}
	}

	[Serializable]
	public class CharacterOne
	{
		private ObscuredInt _id;

		private ObscuredInt _level;

		[JsonIgnore]
		private List<CharacterData.LockEffectData> _lockeffects;

		[JsonIgnore]
		private int trainid;

		public int AssistLevel;

		public int id
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public PlayerCharacter_Character Data => null;

		[JsonIgnore]
		public int MaterialID => 0;

		[JsonIgnore]
		public string NameString => null;

		[JsonIgnore]
		public string InfoString => null;

		[JsonIgnore]
		public bool IsMaxLevel => false;

		[JsonIgnore]
		public bool CanUpgrade => false;

		[JsonIgnore]
		public int ATKLevel => 0;

		[JsonIgnore]
		public int ATKUp => 0;

		[JsonIgnore]
		public string ATKInfoString => null;

		[JsonIgnore]
		public int HPMaxLevel => 0;

		[JsonIgnore]
		public int HPMaxUp => 0;

		[JsonIgnore]
		public string HPMaxInfoString => null;

		[JsonIgnore]
		public int UpgradeCount => 0;

		[JsonIgnore]
		public int HaveCount => 0;

		[JsonIgnore]
		public int UpgradeGold => 0;

		[JsonIgnore]
		public bool GoldEnough => false;

		[JsonIgnore]
		public List<CharacterData.LockEffectData> lockeffects => null;

		[JsonIgnore]
		public List<CharacterData.LockEffectData> unlock_attributes => null;

		public int Trainid
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int TrainMaxStar => 0;

		[JsonIgnore]
		public List<int> AssistUseList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int Assist_ATKBasic => 0;

		[JsonIgnore]
		public int Assist_HPBasic => 0;

		[JsonIgnore]
		public int Assist_ATKTotalOut => 0;

		[JsonIgnore]
		public int Assist_HPTotalOut => 0;

		public CharacterOne(int Id, int Level)
		{
		}

		public int currentTrainAttack()
		{
			return 0;
		}

		public int currentTrainHp()
		{
			return 0;
		}

		public int nextTrainAttack()
		{
			return 0;
		}

		public int nextTrainHp()
		{
			return 0;
		}

		public void LevelUp()
		{
		}

		public int Assist_UnlockNeedLevel(int position)
		{
			return 0;
		}

		public bool isUnlockPosition_Assist(int position)
		{
			return false;
		}

		public int Assist_Index(int level, ref bool arrive)
		{
			return 0;
		}

		public int Assist_ATKUp(int level)
		{
			return 0;
		}

		public int Assist_HPUp(int level)
		{
			return 0;
		}

		public int Assist_ATKTotal(int level)
		{
			return 0;
		}

		public int Assist_HPTotal(int level)
		{
			return 0;
		}

		public int AttrPercent_Assist(int level)
		{
			return 0;
		}

		public List<string> EffectMain_Assist(int level)
		{
			return null;
		}

		public List<string> EffectAssist_Assist(int level)
		{
			return null;
		}

		public List<string> Assist_Material(int level)
		{
			return null;
		}

		public int LevelCanMax_Assist(int star)
		{
			return 0;
		}

		public void syncAssistList(List<int> list)
		{
		}

		public int Assist_EmptyLocation()
		{
			return 0;
		}

		public int Assist_HeroLocation(int heroid)
		{
			return 0;
		}

		public int Assist_HeroCount()
		{
			return 0;
		}

		public void Assist_LocationToUp(int index, int heroid)
		{
		}

		public int GetStar()
		{
			return 0;
		}
	}

	[Serializable]
	public class EMData : LocalSaveBase
	{
		public List<EggData> eggList;

		public List<MonsterData> monsterList;

		public Dictionary<int, int> eggPreCountDict;

		public int battleHave;

		public int battleNeed;

		public bool needSyncBattle;

		public Dictionary<int, int> monsterKillDict;

		public Dictionary<int, int> GuildMonsterKillDict;

		public long LastTimeOpenEgg;

		public Dictionary<int, ulong> hatchPosDict;

		public Dictionary<int, int> battlePosDict;

		public int monsterNoramlNum;

		public int monsterBossNum;

		public int haveDoneHatch;

		public Dictionary<int, int> sdkTGAStar;

		public Dictionary<int, int> sdkTGAStory;

		public ulong LastVisitTimeStamp;

		protected override string filename => null;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void AddEggs(CMonsterEgg[] eggs)
		{
		}
	}

	[Serializable]
	public class GuildData : LocalSaveBase
	{
		public List<ulong> helpEggIds;

		public List<string> offlineList;

		public List<string> onlineList;

		public string twoRoomId;

		public long twoRoomTime;

		public List<ulong> complaintList;

		public List<ulong> appealList;

		protected override string filename => null;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class SailingData : LocalSaveBase
	{
		public LocalCampTalentData talentData;

		public CampTownSkinLocalData townSkinData;

		public List<SailingManager.SailingLogItemData> historyLogs;

		public ushort m_nUnlockBits;

		private ushort m_nRewardBits;

		public int crtBpStage;

		public List<int> oldSkinIDs;

		public int Tag;

		public ushort TreasureMapRewards
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override string filename => null;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		public bool TreasureMapEventHasShowed(int id)
		{
			return false;
		}

		public void SetTreasureMapEventHasShowed(int id)
		{
		}

		public void SetBPCrtStage(int stage)
		{
		}

		public int GetBPCrtStage()
		{
			return 0;
		}

		public void SetTag(int tag)
		{
		}

		public int GetTag()
		{
			return 0;
		}

		public void AddOldSkinId(int id)
		{
		}

		public List<int> GetOldskinIDs()
		{
			return null;
		}

		public void ClearOldSkinList()
		{
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}
	}

	public class MeadowBattleData : LocalSaveBase
	{
		public Dictionary<int, List<MonsterLocationData>> TeamDict;

		public int FinishedTutorialStep;

		[SerializeField]
		public MeadowBattleMatchResultVO MBResultVO;

		protected override string filename => null;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		protected override void OnRefresh()
		{
		}

		public void SetFinishedTutorialStep(int _step)
		{
		}

		public void SetMatchResultVO(MeadowBattleMatchResultVO _vo)
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Init()
		{
		}

		public void Clear()
		{
		}

		public void NotifyMeadowBattleGameOver()
		{
		}

		public void AddOrUpdateLocation(int _teamID, int _CharID, CustomVector2Int _Anchor, int _tempMonsterLevel)
		{
		}

		public void RemoveLocation(int _teamID, int _CharID)
		{
		}

		public uint[] getSelfTeamMonsterIds()
		{
			return null;
		}
	}

	[Serializable]
	public class PVEData : LocalSaveBase
	{
		public class PveSeasonConfigData
		{
			public int ID;

			public long StartTime;

			public long EndTime;

			public int abilityID;

			public long ShopEndTime;

			public int MinVer;

			public int ConvertReady;

			public int ConvertOpen;

			public int ConvertOpenTime;

			public int ConvertEnd;

			public PveSeasonConfigData Clone()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CParsePveConfig_003Ed__70 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PVEData _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CParsePveConfig_003Ed__70(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public Dictionary<int, int> talentDict;

		public int m_nPveSoulPoint;

		public int m_nPveSoulCrystal;

		public int m_nPveSuperSoulCrystal;

		public int m_nMaxStage;

		public int m_nPveLife;

		public int m_nTag;

		public int m_nSeasonTopic;

		public int m_nWeekTopic;

		public long m_nStartTime;

		public long m_nEndTime;

		public int m_nNextTag;

		public long m_nNextStartTime;

		public long m_nNextEndTime;

		public long m_nNextShopEndTime;

		public uint[] m_vecHeroIds;

		public Dictionary<uint, int> m_dicHeroProfessions;

		public int m_nBuyLifeCnt;

		public int m_nPveMaxLife;

		public int m_nPartitionId;

		public int m_nPartitionIdSub;

		public int m_nSelectedHeroId;

		public int m_nAssistHeroId;

		public int m_nRefreshProfessionTimes;

		public bool FirstIn;

		public bool HardFirstIn;

		public long m_nShopEndTimestamp;

		[NonSerialized]
		public long m_nPveBanTimestamp;

		public bool m_bIsIAPBattlepas;

		[NonSerialized]
		public long m_nUpdateWeekTopicTime;

		public bool isUsedQucikSoul;

		public int JoinSeasonCount;

		public long shop_clickTimeBottom;

		public long shop_clickTimeTab;

		public List<string> reportUserList;

		public int m_nHardMaxStage;

		public bool isHardGuide;

		public bool isHideHardTipsRed;

		[NonSerialized]
		private int? m_nCurChapter;

		[NonSerialized]
		private int? m_nCurHardChapter;

		public CPveStageRank[] m_arrayRank;

		[NonSerialized]
		public Dictionary<int, List<CPveStageRank>> m_dicRankInfos;

		[NonSerialized]
		public Dictionary<int, List<GuildMemberHeadInfo>> m_dicGuildMembers;

		public Dictionary<int, List<GuildMemberHeadInfo>> m_dicGuildHardMembers;

		[NonSerialized]
		public Dictionary<int, PVEStage_stagechapter> m_dicCurPVEStage_stagechapters;

		public int talentSocre;

		public bool haveTalentPopWindow;

		public int talentScoreGetLevel;

		private Coroutine m_Coroutine2;

		[NonSerialized]
		public PveSeasonConfigData[] m_aryPveSeasonConfig;

		[JsonIgnore]
		public int CurChapter => 0;

		[JsonIgnore]
		public int CurHardChapter => 0;

		[JsonIgnore]
		public bool IsCompleteAll => false;

		[JsonIgnore]
		public bool IsCompleteHardAll => false;

		public int talentScoreNew
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override string filename => null;

		[JsonIgnore]
		public PVEStage_stagechapter[] CurPVEStage_stagechapters => null;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		public void UpdateBP(bool value)
		{
		}

		public void UpdateHideHardTipsRed(bool isHide)
		{
		}

		public void UpdateHardGuidedStatus(bool isShow)
		{
		}

		public int GetChapterIdByStage(int stage)
		{
			return 0;
		}

		public (int, int) GetUnlockChapterAndStageByStage()
		{
			return default;
		}

		public void Init(CRespPveSeasonInfo info)
		{
		}

		private void UpdateWeekTopicUpdateTime()
		{
		}

		protected override void OnDeserialized(StreamingContext context)
		{
		}

		[IteratorStateMachine(typeof(_003CParsePveConfig_003Ed__70))]
		private IEnumerator ParsePveConfig()
		{
			return null;
		}

		public void Reset()
		{
		}

		public void InitSuspensionPeriod()
		{
		}

		public void OpenNextPveSeason()
		{
		}

		public void ReqGuildMembers()
		{
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void SetSelectedHero(int id)
		{
		}

		private void InitCurStageChapters()
		{
		}

		public PVEStage_stagechapter GetPVEStage_stagechapter(int nChapter)
		{
			return null;
		}

		public void ParsePveSeasonConfig()
		{
		}
	}

	[Serializable]
	public class LocalSaveMedal : LocalSaveBase
	{
		[JsonIgnore]
		public Dictionary<int, int> medalRateDict;

		[JsonIgnore]
		public int[] medalShowIndex;

		public List<int> oldMedals;

		public List<int> newMedals;

		protected override string filename => null;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class ManorLocalData : LocalSaveBase
	{
		public ManorData myData;

		public ManorData visitData;

		protected override string filename => null;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class LocalSavePet : LocalSaveBase
	{
		public List<PetOne> pets;

		protected override string filename => null;

		[JsonIgnore]
		public bool isOpen => false;

		[JsonIgnore]
		public bool isSystemOpen => false;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}

		public PetOne GetPetOne(int petId)
		{
			return null;
		}

		public void UnLockPet(int petId)
		{
		}

		public void UpGrade(int petId, int deltaLevel = 1)
		{
		}

		public void UpStar(int petId, int deltaStar = 1)
		{
		}

		public PetOne[] GetUpWarPet()
		{
			return null;
		}

		public PetOne[] GetHelpWarPet()
		{
			return null;
		}

		public List<PetOne> GetWarSSPets()
		{
			return null;
		}

		public PetOne[] GetNonWarPets()
		{
			return null;
		}

		public PetOne GetPetOneByWarIndex(int warindex)
		{
			return null;
		}

		public List<PetOne> GetHasPets()
		{
			return null;
		}

		public List<PetOne> GetNoHasPets()
		{
			return null;
		}

		public List<PetOne> GetPetShowList()
		{
			return null;
		}

		public void RefreshPet(STPetInfo petInfo)
		{
		}

		public int GetTotalATK()
		{
			return 0;
		}

		public int GetTotalHP()
		{
			return 0;
		}

		public bool IsUpWarSameTypePet(int PetType)
		{
			return false;
		}

		public bool HasCanUpOrHelpWar(int warIndex)
		{
			return false;
		}

		public bool PetEntanceHasRed()
		{
			return false;
		}

		public string GetReportUpWarPet()
		{
			return null;
		}

		public string GetReportHelpWarPet()
		{
			return null;
		}
	}

	[Serializable]
	public class LocalSaveWing : LocalSaveBase
	{
		public List<WingOne> wings;

		protected override string filename => null;

		[JsonIgnore]
		public bool isOpen => false;

		[JsonIgnore]
		public bool isSystemOpen => false;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}

		public void ClearUnLock()
		{
		}

		public void ClearWear()
		{
		}

		public WingOne GetWingOne(int wingId)
		{
			return null;
		}

		public WingOne GetNewWingOne(int wingId, int starId)
		{
			return null;
		}

		public WingOne GetWearWing(int wearindex = 1)
		{
			return null;
		}

		public WingOne GetTryPlayWearWing(int wearindex = 1)
		{
			return null;
		}

		public List<Goods_goods.GoodData> GetUnlockedWingAttrs()
		{
			return null;
		}

		public List<Goods_goods.GoodData> GetTryPlayUnlockedWingAttrs(List<WingOne> tWings)
		{
			return null;
		}

		public void RefreshWings(CWing[] infos)
		{
		}

		public void RefreshWing(CWing info)
		{
		}

		public Dictionary<int, int> GetEmptyWearWingPairs()
		{
			return null;
		}

		public Dictionary<int, int> GetWearWingPairs()
		{
			return null;
		}

		public List<WingOne> GetAllWings()
		{
			return null;
		}

		public List<WingOne> GetTryPlayAllWings(int wingID, int wingStar)
		{
			return null;
		}

		public List<WingOne> GetHasWings()
		{
			return null;
		}

		public Dictionary<string, Goods_goods.GoodData> GetAllCollectAttribute()
		{
			return null;
		}

		public WingOne GetWingOneByFragmentId(int fragmentId)
		{
			return null;
		}

		public void UnLockWing(int wingId)
		{
		}

		public void WearWing(int wingId, int wearindex = 1)
		{
		}

		public void UnWearWing(int wingId, int wearindex = 1)
		{
		}

		public void UpGrade(int wingId, int deltaLevel = 1)
		{
		}

		public void UpStar(int wingId, int deltaStar = 1)
		{
		}

		public bool IsEntanceRed()
		{
			return false;
		}

		public bool IsHasWingCanUnLock()
		{
			return false;
		}
	}

	[Serializable]
	public class EquipData : LocalSaveBase
	{
		[Serializable]
		public class GDEquips
		{
			public uint c;

			public List<uint> equips;

			public GDEquips()
			{
			}

			public GDEquips Clone()
			{
				return null;
			}

			public GDEquips(CReqItemPacket packet)
			{
			}

			public bool Compare(CReqItemPacket packet, out string _1, out string _2)
			{
				_1 = null;
				_2 = null;
				return false;
			}
		}

		public Dictionary<string, EquipOne> list;

		[JsonIgnore]
		private Dictionary<int, EquipOne> _equipIdIndex;

		[JsonIgnore]
		private bool _equipIdIndexDirty;

		public Dictionary<int, int> weaponSkinDict;

		public Dictionary<int, int> weaponSkinColorDict;

		public List<string> wears;

		public ulong[] EquippedDragonRowIds;

		[JsonIgnore]
		public List<string> invalids;

		[JsonIgnore]
		public bool bRefresh;

		[JsonIgnore]
		private bool bInitWear;

		[JsonIgnore]
		private int equipidd;

		[JsonIgnore]
		public List<int> mEquipExpCanDropList;

		public Dictionary<int, Dictionary<int, int>> GemsDict;

		public Dictionary<uint, GDEquips> GOEquips;

		public Dictionary<int, EquipOne> RelicsDict;

		private const string RelicRarityPrefix = "Relics_Rare";

		public static Dictionary<int, Color> RelicRarityColors;

		private const string ATLAS_RELICS = "Relics";

		private const string ATLAS_RELIC_FRAGMENTS = "RelicFragments";

		private const string ATLAS_RELIC_SET = "RelicSet";

		protected override string filename => null;

		[JsonIgnore]
		public bool wear_enable => false;

		public override void Clone(LocalSaveBase s)
		{
		}

		public override LocalSaveBase Clone()
		{
			return null;
		}

		public void ResetWeaponSkinDict(Dictionary<int, int> dict)
		{
		}

		public void ResetWeaponColorDic(Dictionary<int, int> dict)
		{
		}

		public void AddGameOverPacket(CReqItemPacket packet)
		{
		}

		public void ClearGameoverPackets()
		{
		}

		public void RemoveGameOverPacket(CReqItemPacket packet)
		{
		}

		public void CheckCachedGameOverPacket(CReqItemPacket packet)
		{
		}

		protected override void OnDeserialized(StreamingContext context)
		{
		}

		private string LogCache()
		{
			return null;
		}

		public int GetBabySkillId(string name)
		{
			return 0;
		}

		public bool CheckIfDragonIllegal()
		{
			return false;
		}

		public bool CheckIfWearEquipIllegal()
		{
			return false;
		}

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}

		public int GetMaxEquipLevel()
		{
			return 0;
		}

		public int get_equipnum(int id)
		{
			return 0;
		}

		public bool have_sameequip(int id)
		{
			return false;
		}

		public void Init(List<CEquipmentItem> equips)
		{
		}

		private void ReportAllEquipUserSet()
		{
		}

		private void ReportEquipWearLevel(EquipOne one, int value)
		{
		}

		private void ReportEquipChangeUserSet(EquipOne one, int value)
		{
		}

		private void check_position()
		{
		}

		public void init_equipone_uniqueid()
		{
		}

		public void SetWears(bool value)
		{
		}

		private void CheckWears()
		{
		}

		public void Init()
		{
		}

		public void CreateDefaultEquipOne()
		{
		}

		private void check_rowid_same()
		{
		}

		private void check_rowid_invalid(List<CEquipmentItem> equips)
		{
		}

		private bool have_rowid(ulong rowid, List<CEquipmentItem> equips)
		{
			return false;
		}

		public void check_local_invalid()
		{
		}

		private void check_local_invalid_internal(bool force = false)
		{
		}

		public bool IsEmpty()
		{
			return false;
		}

		public void AddEquipInternal(EquipOne data)
		{
		}

		public void AddEquips(List<EquipOne> list)
		{
		}

		private void refresh_data()
		{
		}

		private void add_equip_base(EquipOne data)
		{
		}

		public EquipOne get_by_rowid(ulong rowid)
		{
			return null;
		}

		private void Track_CustomEquip(EquipOne data)
		{
		}

		public EquipOne get_by_rowid(ulong rowid, int equipId)
		{
			return null;
		}

		public EquipOne get_by_uniqueid(string strUniqueId)
		{
			return null;
		}

		public EquipOne get_by_rowid_and_proptype(ulong rowid, int prop_type)
		{
			return null;
		}

		public void AddOnlyItem(CEquipmentItem[] data)
		{
		}

		public void AddEquips(CEquipmentItem[] data, bool addscroll)
		{
		}

		public void RemoveEquip(string uniqueid)
		{
		}

		public void RemoveEquip(ulong rowid)
		{
		}

		public void EquipWear(EquipOne data, int index)
		{
		}

		public void EquipUnwear(string uniqueid)
		{
		}

		private void equip_wear2unwear(string uniqueid)
		{
		}

		public void UpdateEquip(EquipOne data)
		{
		}

		public void UpdateMaterial(int matid, int count)
		{
		}

		public void UpdateMaterials(CEquipmentItem[] equips)
		{
		}

		public EquipOne GetEquipByUniqueID(string uniqueid)
		{
			return null;
		}

		public EquipOne GetPropByID(int equipid)
		{
			return null;
		}

		public void MarkEquipIdIndexDirty()
		{
		}

		private void RebuildEquipIdIndex()
		{
		}

		public int getEquipcountForGuildHelp(int equipid)
		{
			return 0;
		}

		public void EquipLevelUp(EquipOne equip)
		{
		}

		public void EquipBreakDown(EquipOne equip, List<Drop_DropModel.DropData> dropList)
		{
		}

		public void SetNew(string uniqueid)
		{
		}

		public int GetNewCount()
		{
			return 0;
		}

		public List<EquipOne> GetHaveEquips(bool havewear)
		{
			return null;
		}

		public List<EquipOne> GetAllDragonEquips()
		{
			return null;
		}

		public List<EquipOne> GetProps(EquipType type, bool havewear)
		{
			return null;
		}

		public int GetAdventureCoinCount()
		{
			return 0;
		}

		private void UpdateCallBack()
		{
		}

		public int GetCanWearCount()
		{
			return 0;
		}

		public int GetCanUpCount()
		{
			return 0;
		}

		public void Refresh_EquipExp_CanDrop(int equipexpid)
		{
		}

		public void Refresh_EquipExp_CanDrop(EquipOne one)
		{
		}

		public void Refresh_EquipExp_CanDrop()
		{
		}

		public bool Get_EquipExp_CanDrop(int equipexpid)
		{
			return false;
		}

		public bool Get_EquipExp_CanDrop(EquipOne one)
		{
			return false;
		}

		public string GetEquipWearsString()
		{
			return null;
		}

		public int[][] GetEquipWearsArray()
		{
			return null;
		}

		private void combine_refresh()
		{
		}

		public int combine_can_count()
		{
			return 0;
		}

		public bool combine_can(EquipOne one)
		{
			return false;
		}

		public bool can_be_swallow(string targetid, string foodid)
		{
			return false;
		}

		public void DebugLog()
		{
		}

		public void SyncRelicsDict(Dictionary<int, EquipOne> relicsDict)
		{
		}

		public string GetRelicRarityName(int rarity)
		{
			return null;
		}

		public List<EquipOne> GetRelicItemsBySpecialType(int type)
		{
			return null;
		}

		public List<EquipOne> GetRelicItemsByCountType()
		{
			return null;
		}

		public List<EquipOne> GetAllRelicFragments()
		{
			return null;
		}

		private List<EquipOne> getRelicItemsByPropType(EquipPropType propType)
		{
			return null;
		}

		public EquipOne GetRelicByRowId(ulong rowId)
		{
			return null;
		}

		public EquipOne GetRelicByEquipId(int equipId)
		{
			return null;
		}

		public EquipOne GetRelicBySpecialId(int specialId)
		{
			return null;
		}

		public Color GetRarityColor(int rarity)
		{
			return default;
		}

		public Relics_SetAttribues GetRelicsSetBySetId(int setId)
		{
			return null;
		}

		public Relics_SetAttribues GetRelicSetByEquipId(int equipId)
		{
			return null;
		}

		public List<int> GetOtherRelicIdsByEquipId(int equipId)
		{
			return null;
		}

		public List<int> GetCollectedRelicIdsBySetId(int setId)
		{
			return null;
		}

		public Relics_SpecialAttribues GetRelicSpecialAttributes(int specialId)
		{
			return null;
		}

		public static Sprite GetRelicIcon(int equipId)
		{
			return null;
		}

		public static Sprite GetRelicFragmentIcon(int equipId)
		{
			return null;
		}

		public static Sprite GetRelicSetIcon(int setId)
		{
			return null;
		}

		public List<int> GetBabySkillIds(string[] strs)
		{
			return null;
		}

		public List<int> GetSkillIds(string[] strs)
		{
			return null;
		}

		public List<Goods_goods.GoodData> GetAttributeList(string[] strs)
		{
			return null;
		}

		public Dictionary<string, Goods_goods.GoodData> GetAttributes(string[] strs)
		{
			return null;
		}

		public List<Goods_goods.GoodData> GetBabyAttributeList(string[] strs)
		{
			return null;
		}

		public Dictionary<string, Goods_goods.GoodData> GetBabyAttributes(string[] strs)
		{
			return null;
		}

		private void populateDict(ref Dictionary<string, Goods_goods.GoodData> dict, string str)
		{
		}

		public void CombineDict(ref Dictionary<string, Goods_goods.GoodData> dict, Dictionary<string, Goods_goods.GoodData> combinedDict)
		{
		}
	}

	[Serializable]
	public class Daily129BattleData : ICloneable<Daily129BattleData>
	{
		public uint m_nFinishedWave;

		public int m_nDaily129SuperSkillId;

		public void Reset()
		{
		}

		public void SetFinishedWave(uint wave)
		{
		}

		public void Clone(Daily129BattleData source)
		{
		}
	}

	[Serializable]
	public class Daily129CacheData : LocalSaveBase
	{
		public int tag;

		public int difficultIdChoosed;

		public List<int> heroChoosedList;

		public int difficultIdArrived;

		public int difficultIdArrived2;

		protected override void OnRefresh()
		{
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class WeekActivityData : DailyActivityData
	{
	}

	[Serializable]
	public class MonthActivityData : DailyActivityData
	{
	}

	[Serializable]
	public class DailyEndless : LocalSaveBase
	{
		public int m_nMaxLayerInEndlessMode;

		public void UpdateMaxLayerInEndlessMode(int layer)
		{
		}

		protected override void OnRefresh()
		{
		}

		public int GetMaxLayer()
		{
			return 0;
		}
	}

	[Serializable]
	public class DailyMaze : LocalSaveBase
	{
		public int m_nMaxMazeMode;

		protected override void OnRefresh()
		{
		}

		public bool UpdateMaxMode(int mode)
		{
			return false;
		}

		public int GetMaxMode()
		{
			return 0;
		}
	}

	[Serializable]
	public class DailyActivityData
	{
		public long dayend_timestamp;

		public ActivityBuyOne[] iapData;

		public ActivityBuyADData adData;

		public bool isGetADReward;

		public bool isInit;

		public void Init()
		{
		}

		public void Clear()
		{
		}

		public int GetDataCount()
		{
			return 0;
		}

		public List<ActivityBuyOne> get_iap_list()
		{
			return null;
		}

		public void OnGetADReward()
		{
		}

		public bool IsEmpty()
		{
			return false;
		}
	}

	[Serializable]
	public class ActivityBuyOne
	{
		public string product_id;

		public string[] reward;

		public bool isBuy;

		private string _productEnd;

		public string productEnd => null;

		public string productWeekEnd => null;

		public string productMonthEnd => null;

		public List<Drop_DropModel.DropData> GetList()
		{
			return null;
		}
	}

	[Serializable]
	public class ActivityBuyADData
	{
		public int id;

		public string[] reward;
	}

	public class DragonDropUp
	{
		public int Rate;

		public long OpenTime;

		public long EndTime;

		public string[] UPshow;
	}

	[Serializable]
	public class EmojiSetting
	{
		public const int maxCount = 4;

		public List<int> emojiList { get; private set; }

		private void InitByData(string strData)
		{
		}

		private void InitNormal()
		{
		}

		public bool IsInRange(int pIndex)
		{
			return false;
		}

		public void SetId(int pIndex, int pId)
		{
		}

		public void Add(int pId)
		{
		}

		public void RemoveAt(int pIndex)
		{
		}

		public void Remove(int pId)
		{
		}

		public void Save()
		{
		}
	}

	[Serializable]
	public class EquipOne
	{
		public int DragonSlotIndex;

		public int[] DragonSkillLevels;

		[JsonIgnore]
		public const int BoneId = 37004;

		[JsonIgnore]
		public const int HornId = 37005;

		[JsonIgnore]
		public string UniqueID;

		public ulong RowID;

		[JsonIgnore]
		private ObscuredInt _EquipId;

		[JsonIgnore]
		public ObscuredInt _Level;

		public int Count;

		public int WearIndex;

		[JsonIgnore]
		public int customFlag;

		public bool bNew;

		[JsonIgnore]
		private Equip_equip _data;

		[JsonIgnore]
		public int castMatId;

		public int RelicEvolutionLevel;

		public int RelicStar;

		[JsonIgnore]
		private Relics_Relics _relicData;

		[JsonIgnore]
		public string DragonSkillLevelsStr => null;

		public int EquipID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Level
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[JsonIgnore]
		public int CountShow => 0;

		[JsonIgnore]
		public int Position => 0;

		[JsonIgnore]
		public int Quality => 0;

		[JsonIgnore]
		public int Ratity => 0;

		[JsonIgnore]
		public int SubQuality => 0;

		[JsonIgnore]
		public bool QualityCanUp => false;

		[JsonIgnore]
		public Color qualityColor => default;

		[JsonIgnore]
		public Sprite QualityIcon => null;

		[JsonIgnore]
		public Sprite QualityRandomIcon => null;

		[JsonIgnore]
		public int IdBase => 0;

		[JsonIgnore]
		public int IconBase => 0;

		[JsonIgnore]
		public bool IsWeapon => false;

		[JsonIgnore]
		public bool IsWear => false;

		[JsonIgnore]
		public bool Is401Or402Type => false;

		[JsonIgnore]
		public bool IsBook => false;

		[JsonIgnore]
		public bool IsMagicBook => false;

		[JsonIgnore]
		public Equip_equip data => null;

		[JsonIgnore]
		public int WearIndex2Pos => 0;

		[JsonIgnore]
		public Dictionary<int, int> SwallowPositions => null;

		[JsonIgnore]
		public Dictionary<int, int> SwallowQualities => null;

		[JsonIgnore]
		public bool Is401Type => false;

		[JsonIgnore]
		public bool Is402Type => false;

		[JsonIgnore]
		public bool IsBaby => false;

		[JsonIgnore]
		public bool isEgg => false;

		[JsonIgnore]
		public bool isDragon => false;

		[JsonIgnore]
		public bool isRelicFrag => false;

		[JsonIgnore]
		public bool isHidden => false;

		[JsonIgnore]
		public bool IsStone => false;

		[JsonIgnore]
		public bool IsBloodStone => false;

		[JsonIgnore]
		public bool IsFetterBadge => false;

		[JsonIgnore]
		public bool IsCommonItem => false;

		[JsonIgnore]
		public bool IsSkillStone => false;

		[JsonIgnore]
		public bool IsAct4thItems => false;

		[JsonIgnore]
		public bool IsAct4thExchangeItems => false;

		[JsonIgnore]
		public bool IsPetLevelUpItems => false;

		[JsonIgnore]
		public bool IsPetExchangeItems => false;

		[JsonIgnore]
		public bool IsArtifactMat => false;

		[JsonIgnore]
		public bool IsTradingHouseMat => false;

		[JsonIgnore]
		public bool IsErosionMat => false;

		[JsonIgnore]
		public bool IsTotem => false;

		[JsonIgnore]
		public bool IsAct5Donate => false;

		[JsonIgnore]
		public bool IsNewPlay125BagCoin => false;

		[JsonIgnore]
		public bool IsWingLevelUpMat => false;

		[JsonIgnore]
		public bool IsImprintStone => false;

		[JsonIgnore]
		public bool IsImprintUpLevel => false;

		[JsonIgnore]
		public bool IsImprintExchange => false;

		[JsonIgnore]
		public bool IsScroll => false;

		[JsonIgnore]
		public bool IsMagicStone => false;

		[JsonIgnore]
		public bool IsDragonCoin => false;

		[JsonIgnore]
		public bool IsStarLightStone => false;

		[JsonIgnore]
		public bool IsWishCoin => false;

		[JsonIgnore]
		public bool IsRuneStone => false;

		[JsonIgnore]
		public bool IsActivityProp => false;

		[JsonIgnore]
		public bool IsCookie => false;

		[JsonIgnore]
		public bool IsModstone => false;

		[JsonIgnore]
		public bool IsManorMat => false;

		[JsonIgnore]
		public bool IsFountainUse => false;

		[JsonIgnore]
		public bool IsFountainUpgrade => false;

		[JsonIgnore]
		public bool IsEquip => false;

		[JsonIgnore]
		public bool IsShipUpgradeItem => false;

		[JsonIgnore]
		public bool isEquipS => false;

		[JsonIgnore]
		public bool isEquipSS => false;

		[JsonIgnore]
		public bool isEquipSGE => false;

		[JsonIgnore]
		public bool isEquipMatS => false;

		[JsonIgnore]
		public bool isEquipS_MatS => false;

		[JsonIgnore]
		public bool IsTimeCard => false;

		[JsonIgnore]
		public bool IsFragment => false;

		[JsonIgnore]
		public bool IsSoulStone => false;

		[JsonIgnore]
		public bool IsAdventureCoin => false;

		[JsonIgnore]
		public bool isManor => false;

		[JsonIgnore]
		public bool isFishing => false;

		[JsonIgnore]
		public bool isFishingProp => false;

		[JsonIgnore]
		public bool IsFishingFish => false;

		[JsonIgnore]
		public bool IsLoupe => false;

		[JsonIgnore]
		public bool IsDragonMaterial => false;

		[JsonIgnore]
		public bool IsSkinCoupon => false;

		[JsonIgnore]
		public bool IsHonorStone => false;

		[JsonIgnore]
		public bool IsBone => false;

		[JsonIgnore]
		public bool IsHorn => false;

		[JsonIgnore]
		public bool IsDaily129Integral => false;

		[JsonIgnore]
		public bool IsCarving => false;

		[JsonIgnore]
		public bool IsEquipCommonMat => false;

		[JsonIgnore]
		public bool IsEquipQuintessence => false;

		[JsonIgnore]
		public bool IsChineseKnot => false;

		[JsonIgnore]
		public bool IsFirecracker => false;

		[JsonIgnore]
		public bool isBpCardPermanent => false;

		[JsonIgnore]
		public bool isBadge => false;

		[JsonIgnore]
		public bool isBadgeCard => false;

		[JsonIgnore]
		public bool isBadgeBag => false;

		[JsonIgnore]
		public Sprite TypeIcon => null;

		[JsonIgnore]
		public bool ShowQualityGoldImage => false;

		[JsonIgnore]
		public int CurrentMaxLevel => 0;

		[JsonIgnore]
		public int CurrentLevel => 0;

		[JsonIgnore]
		public bool CanLevelUp => false;

		[JsonIgnore]
		public bool CanCombine => false;

		[JsonIgnore]
		public int NeedMatCount => 0;

		[JsonIgnore]
		public int NeedMatID => 0;

		[JsonIgnore]
		public string NeedMatUniqueID => null;

		[JsonIgnore]
		public int HaveMatCount => 0;

		[JsonIgnore]
		public string[] BreakNeed => null;

		[JsonIgnore]
		public string[] BreakNeed2 => null;

		[JsonIgnore]
		public int BreakType => 0;

		[JsonIgnore]
		public int[] BreakDown => null;

		[JsonIgnore]
		public int BreakDownScroll => 0;

		[JsonIgnore]
		public EquipType PropType => EquipType.eEquip;

		[JsonIgnore]
		public EquipPropType EquipPropType => EquipPropType.Equip;

		[JsonIgnore]
		public bool Overlying => false;

		[JsonIgnore]
		public int NeedGold => 0;

		[JsonIgnore]
		public bool GoldEnough => false;

		[JsonIgnore]
		public bool IsMax => false;

		[JsonIgnore]
		public bool CountEnough => false;

		[JsonIgnore]
		public string NameString => null;

		[JsonIgnore]
		public bool IsMonsterEgg => false;

		[JsonIgnore]
		public bool IsGem => false;

		[JsonIgnore]
		public int GemLevel => 0;

		[JsonIgnore]
		public string NameStringNotArabic => null;

		[JsonIgnore]
		public string QualityString => null;

		[JsonIgnore]
		public string NameOnlyString => null;

		[JsonIgnore]
		public string NameOnlyStringNotArabic => null;

		[JsonIgnore]
		public string InfoString => null;

		[JsonIgnore]
		public string SpecialInfoString => null;

		[JsonIgnore]
		public Sprite Icon => null;

		[JsonIgnore]
		public Relics_Relics RelicMeta => null;

		[JsonIgnore]
		public int RelicStarMax => 0;

		[JsonIgnore]
		public int RelicEvolutionLevelMax => 0;

		public EquipOne Clone()
		{
			return null;
		}

		public void SetDragonSlotIndex(int slotIndex)
		{
		}

		public int GetDragonSkillLevel(int skillSlotIndex)
		{
			return 0;
		}

		public DragonType GetDragonType()
		{
			return (DragonType)0;
		}

		public string GetEquipOneInfo()
		{
			return null;
		}

		public string GetDragonInfo()
		{
			return null;
		}

		public bool CanBeSwallow(string target, string food)
		{
			return false;
		}

		public void EquipWear(SelfAttributeData data)
		{
		}

		public void EquipWearAdditionSkills(SelfAttributeData data)
		{
		}

		public void EquipWearAttributes(SelfAttributeData data)
		{
		}

		public List<int> GetSkills()
		{
			return null;
		}

		public List<int> GetSkillsForCampBattle()
		{
			return null;
		}

		public List<int> GetSkillsForDaily124()
		{
			return null;
		}

		public string GetAttName(int index)
		{
			return null;
		}

		public string GetCurrentAttributeString(int index)
		{
			return null;
		}

		private int CheckAttrUpMaxLevel(int index)
		{
			return 0;
		}

		public float GetCurrentAttributeValue(int index, out string type)
		{
			type = null;
			return 0f;
		}

		public void CombineReturn(List<Drop_DropModel.DropData> list)
		{
		}

		public void BreakUpReturn(out List<Drop_DropModel.DropData> breakUpReturn)
		{
			breakUpReturn = null;
		}

		public List<Goods_goods.GoodData> GetBabyAttributes()
		{
			return null;
		}

		public List<int> GetBabySkills()
		{
			return null;
		}

		public List<int> GetBabyCarvingItemSkills()
		{
			return null;
		}

		public void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string PrintInfo()
		{
			return null;
		}

		public string ToRelicStr()
		{
			return null;
		}

		public bool IsMaxRelicStar()
		{
			return false;
		}

		public bool IsMaxRelicEvolutionLevel()
		{
			return false;
		}

		public string[] GetEvolutionAttr()
		{
			return null;
		}

		public float GetStar2AttrPercent()
		{
			return 0f;
		}

		public string[] GetStarAttr()
		{
			return null;
		}
	}

	public class EventTowerData
	{
	}

	[Serializable]
	public class LocalSaveExtra : LocalSaveBase
	{
		public int stage;

		public Dictionary<int, int> list;

		public int overopencount;

		public int battleSource;

		public int battleinmode;

		public int guideequipalllayer;

		public int guidebattleProcess;

		public long EquipDropRate;

		public uint mTransID;

		public int GemDropAddCount;

		public long Tga_Equip_Time;

		public int Tga_Equip_Cnt;

		public List<int> mining_PopWindow;

		public bool isShuffled;

		public int PyramidTag;

		public bool isMazeShuffled;

		public int MazeTag;

		public Dictionary<string, int> newChapterWavelist;

		public bool IsStorageOpenedFromStart;

		public int PlinkoTag;

		public List<Drop_DropModel.DropData> ballRewardList;

		public List<int> plinko_PopWindow;

		private bool plinko_isShowGuide;

		public List<ActivityShowCacheData> actShowCacheDataList;

		public bool Sail_HaveOpenUI;

		public bool Sail_CloudPlay1;

		public bool Sail_CloudPlay2;

		public bool Sail_CloudPlay3;

		public bool Sail_FirstClickIcon;

		public bool Sail_FirstClickGift;

		public bool Sail_FirstClickGiftTiming;

		public long act6thOpenTimeStemp;

		public long act7thOpenTimeStemp;

		public bool haveShowTimeEnvelopeAni;

		public Dictionary<int, long> totemWearDic;

		public Dictionary<int, bool> totemSlotUnlockDic;

		public bool haveOpenEquipCast;

		public int equipCastNewFlag;

		public bool ShopWorkerFlag;

		public long ShopWorkerLastTime;

		public bool isSkipOpenAni_seabox;

		public bool GodWish_ShowGuide;

		public int GodWish_LastTicketId;

		public ChatTab ChatOpenTab;

		public int BossPlayTag;

		public Dictionary<string, string> cacheDict;

		public void SetAct6thPopOpenTimeStemp(long timeStemp)
		{
		}

		public long GetAct6thPopOpenTimeStemp()
		{
			return 0L;
		}

		public void SetAct7thPopOpenTimeStemp(long timeStemp)
		{
		}

		public long GetAct7thPopOpenTimeStemp()
		{
			return 0L;
		}

		public void setShowTimeEnvelopeAni(bool show)
		{
		}

		public bool getShowTimeEvnelopeAni()
		{
			return false;
		}

		public void SetTotemWearInfo(int slotID, long rowID)
		{
		}

		public Dictionary<int, long> GetTotemWearInfo()
		{
			return null;
		}

		public void SetTotemSlotStatus(int slotID, bool isUnlock)
		{
		}

		public Dictionary<int, bool> GetTotemSlotUnlockMap()
		{
			return null;
		}

		public bool GetTotemSlotUnlockStatusBySlotID(int slotID)
		{
			return false;
		}

		protected override void OnRefresh()
		{
		}

		public void AddLayerCount(int stage, int layer)
		{
		}

		public int GetLayerCount(int stage, int layer)
		{
			return 0;
		}

		public void AddEquipAllLayer()
		{
		}

		public bool Get_Equip_Drop()
		{
			return false;
		}

		public bool Get_EquipExp_Drop()
		{
			return false;
		}

		public void SetGuideBattleProcess(int value)
		{
		}

		public void InitTransID(uint id)
		{
		}

		public uint GetTransID()
		{
			return 0u;
		}

		public void SetEquipDropRate(long value)
		{
		}

		public void setGemDropAddValue(int value)
		{
		}

		public int getGemDropAddValue()
		{
			return 0;
		}

		public void setShopWorkerFlag(bool value)
		{
		}

		public bool getShopWorkerFlag()
		{
			return false;
		}

		public void setShopWorkerLastTime(long time)
		{
		}

		public long getShopWorkerLastTime()
		{
			return 0L;
		}

		public bool isPopShopWorkerWindow()
		{
			return false;
		}

		public void SetPyramidIsShuffled(bool isShuffle)
		{
		}

		public bool GetPyramidIsShuffled()
		{
			return false;
		}

		public void SetPyramidTag(int tag)
		{
		}

		public int GetPyramidTag()
		{
			return 0;
		}

		public void SetMazeIsShuffled(bool isShuffle)
		{
		}

		public bool GetMazeIsShuffled()
		{
			return false;
		}

		public void SetMazeTag(int tag)
		{
		}

		public int GetMazeTag()
		{
			return 0;
		}

		public void UpdateNewChapterWaveCount(string waveId)
		{
		}

		public int GetNewChapterWaveCount(string waveId)
		{
			return 0;
		}

		public void SetChatTab(ChatTab tab)
		{
		}

		public ChatTab GetChatTab()
		{
			return (ChatTab)0;
		}

		public void SetActBossPlayTag(int tag)
		{
		}

		public int GetActBossPlayTag()
		{
			return 0;
		}

		public void RecordIsStorageOpened(bool status)
		{
		}

		public bool GetIsStorageOpened()
		{
			return false;
		}

		public bool IsShowPlinkoGuide()
		{
			return false;
		}

		public void SetPlinkoIsShowGuide(bool isShow)
		{
		}

		private void InitData(int stage, int layer)
		{
		}

		public void Init()
		{
		}

		public int GetTgaEquipCnt()
		{
			return 0;
		}

		public void Clear()
		{
		}
	}

	[Serializable]
	public class FakeStageDrop : LocalSaveBase
	{
		public int stage;

		public int count;

		public int fakerid;

		protected override void OnRefresh()
		{
		}

		public void UpdateStage(int stage, int fakerid)
		{
		}

		public List<Drop_DropModel.DropData> GetDropList(List<int> filters)
		{
			return null;
		}
	}

	[Serializable]
	public class FakeCardCost : LocalSaveBase
	{
		public int fakerid;

		public int count { get; private set; }

		protected override void OnRefresh()
		{
		}

		public void Init()
		{
		}

		public void InitCount(int count)
		{
		}

		private int get_all_max_count()
		{
			return 0;
		}

		public void AddCount()
		{
		}

		public int GetCost()
		{
			return 0;
		}

		public int GetNeedLevel()
		{
			return 0;
		}
	}

	public class GamBlingStone
	{
		public int useHeroId;

		public int usePrompt;

		public int showPrompt;

		public uint transId;

		public Dictionary<int, GamBlingIdentfyItem> itemMap;

		public IdentfyItemListData itemListData;

		public void Clear()
		{
		}

		public void SetData(IdentfyItemListData pData)
		{
		}

		public GamBlingIdentfyItem GetItem(int pIndex)
		{
			return null;
		}
	}

	public class GamBlingIdentfyItem
	{
		public int index;

		public List<int> identyedList;

		[JsonIgnore]
		public int Count => 0;

		public bool Contains(int pId)
		{
			return false;
		}

		public void Add(int pId)
		{
		}
	}

	public class GamePlayActvityData
	{
		public GamePlayActivityOneData[] activityArray;

		public long PvpBanTimestamp { get; private set; }

		public long CooperationBanTimestamp { get; private set; }

		public bool IsBanPvp => false;

		public bool IsBanCooperation => false;

		public int MaxDifficult { get; set; }

		public void Init()
		{
		}

		public bool SetData(GamePlayActivityOneData_Server[] serverData, ulong nPvpBanTimestamp = 0uL, ulong nCoopBanTimestamp = 0uL, ushort nMaxDifficult = 0)
		{
			return false;
		}

		public GamePlayActivityOneData[] CreateData(GamePlayActivityOneData_Server[] serverData)
		{
			return null;
		}

		public bool CheckDataSame(GamePlayActivityOneData clientData, GamePlayActivityOneData_Server serverData)
		{
			return false;
		}

		public GamePlayActivityOneData GetActivityDataById(int id)
		{
			return null;
		}

		public void UpdateEndlessLayer(int layer)
		{
		}

		public void Clear()
		{
		}
	}

	public class GamePlayActivityOneData : IComparable<GamePlayActivityOneData>
	{
		public int id;

		public int tag;

		public long start;

		public long end;

		public int lastTime;

		public int buyTime;

		public int costLife;

		public int level;

		public long config_battle_end_time;

		public long conf_end_time;

		public int buyLifeTotal;

		public int[] buyLifeCostArray;

		public int order;

		public string buyLifeCost { get; private set; }

		public int Key_RealNeed => 0;

		public void CostLastTime()
		{
		}

		public int GetCanBuyTime()
		{
			return 0;
		}

		int IComparable<GamePlayActivityOneData>.CompareTo(GamePlayActivityOneData other)
		{
			return 0;
		}

		public void SetBuyLifeCost(string costString)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public bool IsInConfigOpenTime()
		{
			return false;
		}
	}

	public class GemDropOneData
	{
		public int type;

		public int gemid;

		public int min;

		public int max;

		public int weight;

		public int Count => 0;

		public void Init(string value)
		{
		}
	}

	public class GemDropOne
	{
		public int dropId;

		public int dropType;

		public int Prob;

		public int totalWeight;

		public List<GemDropOneData> list;
	}

	public enum GuideMaskType
	{
		eNone = 0,
		eTop = 1,
		eBottom = 2
	}

	public class GuideTransfer
	{
		public ushort system;

		public int index;

		public RectTransform t;

		public Graphic graphic;

		public Func<bool> condition;

		public int order;

		public GuideMaskType masktype;
	}

	public class GuideMainDownTransfer
	{
		public int buttonIndex;

		public GuideTransfer guideTransfer;
	}

	public class GuideData : LocalSaveBase
	{
		private const bool debug_log = false;

		public int DailyTDTutorialStep;

		public const ushort GAME_SYSTEM_DIAMONDBOX = 1;

		public const ushort GAME_SYSTEM_HERO_MODE = 2;

		public const ushort GAME_SYSTEM_BATTLEPASS = 3;

		public const ushort GAME_SYSTEM_ACTIVITY = 4;

		public const ushort GAME_SYSTEM_CHARACTER_UPGRADE = 5;

		public const ushort GAME_SYSTEM_401OR402_EQUIP = 6;

		public const ushort GAME_SYSTEM_MAGICBOOK_EQUIP = 7;

		public const ushort GAME_SYSTEM_CHAPTER_GIFT = 8;

		public const ushort GAME_SYSTEM_TOWER = 9;

		public const ushort GAME_SYSTEM_DOUBLE_DIAMOND = 10;

		public const ushort Game_System_Hero_Train = 11;

		public const ushort Game_System_MonsterEgg = 12;

		public const ushort GAME_SYSTEM_TOWER_HERO_MODE = 13;

		public const ushort Game_System_EquipBox = 14;

		public const ushort Game_System_Gems = 15;

		public const ushort Game_System_MonthlyCard = 16;

		public const ushort Game_System_Altar = 17;

		public const ushort Game_System_AltarHero = 18;

		public const ushort Game_System_PveSeason = 19;

		public const ushort Game_System_AltarHeroEx = 20;

		public const ushort Game_System_HeroAssist = 22;

		public const ushort Game_System_HalloweenCrystal = 23;

		public const ushort SERVER_BOX_FIRST_OPEN = 50;

		public const ushort DELETE_ACCOUNT = 59;

		public const ushort SERVER_GUILD_OPEN = 60;

		public const ushort GAME_SYSTEM_ATT_NEED_REQUEST = 61;

		public const ushort GAME_SYSTEM_IN_REVIEW = 62;

		public const ushort DEBUG_TEST_SERVER_SHOW = 63;

		public const ushort GAME_SYSTEM_FIRST_EQUIP = 64;

		public const ushort GAME_SYSTEM_DRAGONBOX = 65;

		public const ushort GAME_SYSTEM_DRAGON_UI = 66;

		public const ushort GAME_SYSTEM_DRAGONBOX_MAINUI = 67;

		public const ushort GAME_SYSTEM_REFINE = 68;

		public const ushort GAME_SYSTEM_RELICS = 69;

		public const ushort GAME_SYSTEM_Medal = 70;

		public const ushort GAME_SYSTEM_MeadowBattle = 71;

		public const ushort GAME_SYSTEM_WeaponSkin = 72;

		public const ushort GAME_SYSTEM_Harvest = 73;

		public const ushort GAME_SYSTEM_CHARACTER = 74;

		public const ushort GAME_SYSTEM_MANOR = 76;

		public const ushort Game_System_Christmas2023 = 77;

		public const ushort Game_System_Pet = 78;

		public const ushort Game_System_PetBox = 79;

		public const ushort Game_System_Imprint = 80;

		public const ushort Game_System_ImprintBox = 81;

		public const ushort Game_System_Wing = 82;

		public const ushort Game_System_NewFirstCharge_LastPopDay = 83;

		public const ushort Game_System_NewFirstCharge_PopCounter = 84;

		public const ushort Game_System_BagCollect = 86;

		public const ushort GAME_SYSTEM_HELL_MODE = 87;

		public const ushort Game_System_Artifact = 88;

		public const ushort Game_System_ArtifactPlay = 89;

		public const ushort GAME_System_Totem = 90;

		public const ushort Game_System_129Play = 91;

		public const ushort Game_System_EquipCast = 92;

		public const ushort Game_System_AltarRelics = 93;

		public const ushort Game_System_Badge = 94;

		public int mDiamondBox;

		public Dictionary<int, int> mGuideIndexs;

		[JsonIgnore]
		private GuideNoMaskCtrl mCtrl;

		[JsonIgnore]
		private Dictionary<int, GuideNoMaskCtrl> mMasks;

		public long mGameSystemMask;

		public bool IsUpdateGuidFromServer;

		public bool isOldPlayer;

		protected override void OnRefresh()
		{
		}

		public void Init()
		{
		}

		public void SetIndex(int index)
		{
		}

		public bool IsGuildOpen()
		{
			return false;
		}

		public int GetGuideIndex(int system)
		{
			return 0;
		}

		public void SetIndex(int system, int index)
		{
		}

		public void ForceSetIndex(int system, int index)
		{
		}

		public bool set_index_internal(int system, int index, bool force = false)
		{
			return false;
		}

		public int get_index_internal(int system)
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void remove(int system)
		{
		}

		private bool have_mask(int system)
		{
			return false;
		}

		public bool HasAvailableMask()
		{
			return false;
		}

		public bool HasMask()
		{
			return false;
		}

		public bool CheckGuide(GuideTransfer data)
		{
			return false;
		}

		public void create_mask(GuideTransfer data)
		{
		}

		public void check_diamondbox_first_open()
		{
		}

		public void send_diamondbox_open(Action successCallBack)
		{
		}

		public bool send_hero_mode_open()
		{
			return false;
		}

		public bool send_battlepass_open()
		{
			return false;
		}

		public bool send_hell_mode_open()
		{
			return false;
		}

		public void SendChapterGiftUpgrade(ushort index, Action<bool> callback)
		{
		}

		public bool send_system_open(ushort index)
		{
			return false;
		}

		private void send_system_open(ushort index, Action<NetResponse> callback)
		{
		}

		public void SetGameSystemMask(ulong mask)
		{
		}

		public void system_open(int index)
		{
		}

		public bool is_system_open(int index)
		{
			return false;
		}

		private void debug(string value, params object[] args)
		{
		}

		public void IncreaseDailyTDTutorialStep()
		{
		}
	}

	public class GuidDataResponse
	{
		public int FinishedTutorialStep;

		public Dictionary<int, int> mGuideIndexs;
	}

	public class GuildRankItemUIData
	{
		public int skinid;

		public int rank;

		public string userid;

		public int head;

		public int headbox;

		public string name;

		public int grade;

		public int active;

		public int like;

		public int help;

		public int battle;

		public int pvp;

		public string userdesc;

		public int wingid;

		public int wingstar;

		public List<ArtifactOne> artiList;
	}

	public class GuildRankCustomData
	{
		public int head_frame;

		public int stage_level;

		public int stage_layer;

		public int hell_stage_level;

		public int hell_stage_layer;

		public int heroId;

		public int skinId;

		public int pvp_score;

		public int wingId;

		public int wingStar;

		public List<ArtiData> artifacts;
	}

	public class ArtiData
	{
		public int id;

		public int star;

		public int level;
	}

	public class GuildBasicData
	{
		public GuildListData.GuildListItem guildData;

		public int score;
	}

	[Serializable]
	public class HarvestData
	{
		public long beforeexcutetime;

		public long startservertime;

		public int gold;

		public int exp;

		public int mGotMinutes;

		private int energyid;

		private bool OpenRune;

		private int cardruneid;

		public Dictionary<int, Drop_DropModel.DropData> mItems;

		[JsonIgnore]
		private long mMaxTime;

		[JsonIgnore]
		private bool isShortHarvest;

		private int m_nTimeStep;

		public bool DataChangeFlag { get; set; }

		[JsonIgnore]
		public float GoldAdditionValue => 0f;

		[JsonIgnore]
		public float ExpAdditionValue => 0f;

		public double HarvestGoldPerMinute { get; private set; }

		public int HarvestExpPerMinute { get; private set; }

		public long ReqDataTime { get; set; }

		public int TimeStep => 0;

		public bool NeedRefresh => false;

		public void Init()
		{
		}

		public void InitShort()
		{
		}

		private bool is_available()
		{
			return false;
		}

		public void AddEquipExpItem(Drop_DropModel.DropData item)
		{
		}

		public void AddItem(Drop_DropModel.DropData item)
		{
		}

		public void init_last_time(long time)
		{
		}

		public void InitHarvestGoldPerMinute(double value)
		{
		}

		public void InitHarvestExpPerMinute(uint value)
		{
		}

		public int get_current_refresh_minutes()
		{
			return 0;
		}

		public bool get_can_reward()
		{
			return false;
		}

		public bool getTimeForReward(long pMaxSeconds)
		{
			return false;
		}

		public long get_harvest_time()
		{
			return 0L;
		}

		public void InitDrops(CRewardItem[] rewards)
		{
		}

		[Obsolete("废弃，3.10.0 巡逻奖励由服务器下发，客户端每一分钟刷一遍接口", true)]
		public void resetSpData()
		{
		}

		public List<Drop_DropModel.DropData> getRewardEquips(List<Drop_DropModel.DropData> list)
		{
			return null;
		}

		public string getRandomEquipsJson(List<Drop_DropModel.DropData> list)
		{
			return null;
		}

		[Obsolete("废弃，3.10.0 巡逻奖励由服务器下发，客户端每一分钟刷一遍接口", true)]
		private void ExpandAddItems(Drop_harvest data, int cumulativeTime)
		{
		}

		public void CanGetRefine()
		{
		}

		public void Get_to_pack()
		{
		}

		public void Get_to_pack_ad()
		{
		}

		protected static int AdditionToItemID(string additionName)
		{
			return 0;
		}

		protected Dictionary<int, int> GetItemMultiplier()
		{
			return null;
		}

		public List<Drop_DropModel.DropData> GetList()
		{
			return null;
		}

		private float GetAltarEffectValue(int id)
		{
			return 0f;
		}

		public List<Drop_DropModel.DropData> GetListAd()
		{
			return null;
		}

		public bool CheckGot()
		{
			return false;
		}

		public bool CheckGotAd()
		{
			return false;
		}

		private bool check(Drop_DropModel.DropData data)
		{
			return false;
		}

		private bool checklist(List<Drop_DropModel.DropData> list)
		{
			return false;
		}

		public void Unlock()
		{
		}

		public void Clear()
		{
		}
	}

	public enum HarvestType
	{
		HarvestType_Req_Normal = 0,
		HarvestType_Req_Short = 1,
		HarvestType_Get_Normal_Reward = 2,
		HarvestType_Get_Short_Reward = 3,
		HarvestType_Get_Short_Reward_Ad = 4
	}

	[Serializable]
	public class GameHarvestExtend
	{
		public double coin_coeff;

		public double exp_coeff;

		public double equipexp_coeff;

		public double stone_coeff;

		public double refine_coeff;

		public double cookie_coeff;

		public double bloodstone_coeff;

		public double gem1_coeff;

		public double gem2_coeff;

		public double equip1_coeff;

		public double equip2_coeff;

		public double relic_coeff;

		public double relicstone_coeff;

		public double dragonstone_coeff;

		public double epigraph_coeff;

		public double fetterbadge_coeff;

		public double fountain_use_exp_coeff;

		public double fountain_upgrade_exp_coeff;

		public double equip_quintessence_exp_coeff;

		public double pet_level_up_item_exp_coeff;
	}

	public class HarvestShortButtonData
	{
		public int type;

		public int count;

		public int cd;

		public int extra;
	}

	public class HeroSkinOne
	{
		public string m_nUniqueID;

		public ulong m_nRowID;

		public uint m_nSkinID;

		public uint m_nLevel;

		public ulong m_nExpireTime;

		public bool m_bExpried;

		public bool m_bActive;
	}

	public class HeroSkinData : LocalSaveBase
	{
		public Dictionary<int, HeroSkinOne> m_dicUnLockSkins;

		public Dictionary<int, int> m_dicHeroSkins;

		protected override void OnRefresh()
		{
		}

		public int GetCurCharacterSkinId()
		{
			return 0;
		}

		public int GetHeroSkin(int heroId)
		{
			return 0;
		}

		public int GetHeroCharacterId(int heroId)
		{
			return 0;
		}

		public void SetCharacterSkinId(int heroId, int skinId)
		{
		}

		public bool IsSelectedSkin(int heroId, int skinId)
		{
			return false;
		}

		public int GetSelectedSkinIndex(int heroId)
		{
			return 0;
		}

		public IList GetSkinAttribute()
		{
			return null;
		}

		public List<Goods_goods.GoodData> GetSkinSelfAttribute(int heroID)
		{
			return null;
		}

		public List<Goods_goods.GoodData> GetUseSkinAttribute(int heroID)
		{
			return null;
		}

		public List<int> GetCurSkinSkill()
		{
			return null;
		}

		public List<int> GetHeroSkinSkill(int id)
		{
			return null;
		}

		public List<int> GetSkinSkill(int id)
		{
			return null;
		}

		public void UnlockHeroSkin(CHeroSkin item, bool bRefresh = true)
		{
		}

		public void CheckHeroSkins()
		{
		}

		public int GetUnlockedSkinCount()
		{
			return 0;
		}

		public void Clear()
		{
		}

		public void ClearUnlockedSkins()
		{
		}

		public bool IsSkinUnlock(int id)
		{
			return false;
		}

		public bool IsExpired(int id)
		{
			return false;
		}

		public long GetExpiredTime(int id)
		{
			return 0L;
		}

		public int GetHeroNotOriginPerpetualSkinCount(int heroID)
		{
			return 0;
		}

		public int GetAllHeroNotOriginPerpetualSkinCount()
		{
			return 0;
		}

		public bool IsPerpetualSkin(int skinID)
		{
			return false;
		}

		public bool IsOriginSkin(int skinID)
		{
			return false;
		}

		public bool IsSkinAllowUnlockUpgrade(int skinID)
		{
			return false;
		}

		public uint GetSkinLevel(int skinID)
		{
			return 0u;
		}

		public void AddSkinLevel(int skinID, int upgrade)
		{
		}

		public void ResetSkinLevel(int skinID)
		{
		}
	}

	[Serializable]
	public class HomePageData : LocalSaveBase
	{
		public bool HasSync;

		protected override void OnRefresh()
		{
		}

		public void Init()
		{
		}

		public void EnableSync()
		{
		}

		internal void Clear()
		{
		}
	}

	[Serializable]
	public class LocalMail : LocalSaveBase
	{
		public uint mLastMailID;

		public List<CMailInfo> list;

		protected override void OnRefresh()
		{
		}

		public void AddMail(CMailInfo mail)
		{
		}

		public void SetMailID(uint id)
		{
		}

		public void MailReaded(CMailInfo mail)
		{
		}

		public void MailGot(CMailInfo mail)
		{
		}

		public void RemoveMail(CMailInfo mail)
		{
		}

		private void check_mail_outtime()
		{
		}

		private void remove_mail(CMailInfo mail)
		{
		}

		private void mailListUpdate()
		{
		}

		public void Clear()
		{
		}

		public int GetRedCount()
		{
			return 0;
		}

		public void Init()
		{
		}

		public bool CheckMainPop()
		{
			return false;
		}

		public void SendMail()
		{
		}

		private void SendMailInternal(Action callback)
		{
		}

		private void Update()
		{
		}
	}

	[Serializable]
	public class MainActivityDataOne
	{
		public int pack_id;

		public long[] begin_end_timestamp;

		public string product_id;

		public byte show_cond;

		public string[] reward;

		public ushort multiple;

		public string[] names;

		[JsonIgnore]
		public bool Valid;

		[JsonIgnore]
		private int _productid;

		private List<Drop_DropModel.DropData> _list;

		[JsonIgnore]
		public int productid => 0;

		public bool GetCanShow()
		{
			return false;
		}

		public List<Drop_DropModel.DropData> GetList()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class MainActivityData
	{
		public MainActivityDataOne[] data;

		[JsonIgnore]
		private long _starttime;

		[JsonIgnore]
		private long _endtime;

		[JsonIgnore]
		public List<MainActivityDataOne> list;

		[JsonIgnore]
		public long starttime => 0L;

		[JsonIgnore]
		public long endtime => 0L;

		[JsonIgnore]
		public bool IsValid => false;

		public void Init()
		{
		}

		public MainActivityDataOne Get(string product_id)
		{
			return null;
		}

		public MainActivityDataOne Get(int productid)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class LocalSave_MazeConfigItem
	{
		public long StartTime;

		public long EndTime;

		public int Line;
	}

	[Serializable]
	public class LocalSave_MazeConfig
	{
		public LocalSave_MazeConfigItem[] MazeConfig;
	}

	[Serializable]
	public class LocalSave_MazeLineItem
	{
		public int ID;

		public string Line;
	}

	[Serializable]
	public class LocalSave_MazeLine
	{
		public LocalSave_MazeLineItem[] MazeLine;
	}

	[Serializable]
	public class EggData
	{
		public ulong rowid;

		public ulong stime;

		[JsonIgnore]
		private ObscuredInt _eggid;

		[JsonIgnore]
		private ObscuredInt _have;

		public int eggid
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int have
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public EggData Clone()
		{
			return null;
		}
	}

	[Serializable]
	public class MonsterData
	{
		public string uniqueid;

		public ulong rowid;

		public int monsterid;

		public int state;

		public int kill;

		public int star;

		public int count;

		public MonsterData Clone()
		{
			return null;
		}
	}

	public class StarUPAttrData
	{
		public int mid;

		public string key;

		public int value;

		public int add;

		public int star;

		public bool unlock;
	}

	private class ChapterInfo
	{
		public class MustDropEquipInfo
		{
			public int itemId;

			public int itemNum;
		}

		public int chapId;

		public int playerId;

		public bool online;

		public int must_drop_type;

		public MustDropEquipInfo[] must_drops;

		public int reborn_type;

		public int reborn_count;
	}

	public class MonSkillData
	{
		public int type;

		public int skillid;

		public int tipsid;

		public bool unlock;

		public int index;
	}

	private enum RequestType
	{
		RequestInfo = 1,
		ReceiveReward = 2,
		ReceivePremiumReward = 3
	}

	private enum Platform
	{
		iOS = 0,
		Android = 1,
		OneStore = 2,
		Huawei = 3
	}

	public class MonthlyCardData : LocalSaveBase
	{
		public long expireTimestamp;

		public bool canReceive;

		public ushort renewCount;

		public ushort sweepCntAdd;

		public ushort totalRenewCount;

		public ushort receiveCount;

		public ushort farmVisitCount;

		public bool isValid => false;

		protected override void OnRefresh()
		{
		}
	}

	[Serializable]
	public class PrivilegeLocalData
	{
		public bool isPermanentActive;

		public bool isDiamondActive;

		public bool isDiamondDailyRewardGot;

		public int diamondRewardGotTimes;

		public void SynData(bool isPermanentActive)
		{
		}

		public void SynDiamondData(bool isDiamondActive, bool isDiamondDailyRewardGot)
		{
		}

		public void SynDiamondRewardGotTime(int times)
		{
		}

		public void Clear()
		{
		}
	}

	public enum NetCacheType
	{
		eBattleBegin = 0,
		eBattleEnd = 1
	}

	[Serializable]
	public class NetCache
	{
		public List<NetCacheBase> list;

		public void SendAllCache()
		{
		}

		public void SendOne(NetCacheBase data)
		{
		}
	}

	[Serializable]
	public class NetCacheBase
	{
		public NetCacheType type;
	}

	[Serializable]
	public class NetCacheBattleBegin : NetCacheBase
	{
	}

	[Serializable]
	public class NetCacheBattleEnd : NetCacheBase
	{
	}

	[Serializable]
	public class LocalSavePlayer : LocalSaveBase
	{
		public bool HasUnlockedNewChapter;

		public string Name;

		public int headId;

		public int headFrameId;

		public long headFrameTime;

		public Dictionary<int, long> headFrameDict;

		public List<int> headList;

		public List<int> emojiList;

		public List<int> clickHeadList;

		public List<int> clickHeadFrameList;

		public List<int> clickEmojiList;

		public int nameNeedDiamond;

		public int VIP_Lv;

		public int VIP_Score;

		public int cardChapterIndex;

		protected override void OnRefresh()
		{
		}

		public void SyncHasUnlockedNewChapter()
		{
		}

		public void Clear()
		{
		}
	}

	public class CashGiftItemData
	{
		public int id;

		public List<List<int>> reward_payment;

		public int show_cond;

		public int param;

		public bool isBig;
	}

	public class CashTaskItemData
	{
		public int id;

		public int count;

		public bool isDone;
	}

	public class CashGiftJsonData
	{
		public int Layer_Min;

		public int Layer_Max;

		public List<CashGiftItemData> Items;

		public List<CashGiftItemData> BIgItems;
	}

	[Serializable]
	public class PropData : LocalSaveBase
	{
		protected override string filename => null;

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}
	}

	public class PVEShopJsonData
	{
		public string product_id;

		public int row_iap_id;

		public string show_cond;

		public int amount;

		public float legal_tender;

		public int unit;

		public int[][] reward;

		public int iap_type;

		public int discount;
	}

	public class PVERankRewardData
	{
		public int ID;

		public int Rank;

		public int Season;

		public string Reward1;

		public string Reward2;

		public string Reward3;

		public string Reward4;

		public string Reward5;

		public string Reward6;

		public string Reward7;

		public string Reward8;

		public string Reward9;

		public string Reward10;

		public string Reward_img;
	}

	[Serializable]
	public class PVERankDivisionData
	{
		public int ID;

		public int[] standard;

		public int StartId;

		public int MaxStep1;

		public int MaxStep2;

		public int MaxStep3;

		public int MaxGroupNum;

		public int ConvertLimit;
	}

	public class ExcOutData
	{
		public int index;

		public EquipOne one;
	}

	public class ExcInData
	{
		public int exid;

		public int have;

		public string reward;

		public string cost;

		public int left;

		public int pos;
	}

	public class PointData
	{
		public int id;

		public int ActivityRatio;
	}

	public class ServerData
	{
		public GamePlayActvityData mGamePlayActivityData;

		public BattlePassData mBattlePassData;
	}

	[Serializable]
	public class ShopLocal : LocalSaveBase
	{
		[JsonIgnore]
		public object shopBoxActivityDate;

		[JsonIgnore]
		public bool bRefresh;

		[JsonIgnore]
		private int nFreeCoinCount;

		[JsonIgnore]
		private static int[] mTimes;

		public void SetFreeCoinCount(int cnt)
		{
		}

		public int GetFreeCoinCount()
		{
			return 0;
		}

		protected override void OnRefresh()
		{
		}

		public void Init()
		{
		}

		public int get_buy_golds(int index)
		{
			return 0;
		}

		public int get_gold_time(int index)
		{
			return 0;
		}
	}

	public class ShopIAPData
	{
		public string product_id;

		public int row_iap_id;

		public string show_cond;

		public int amount;

		public float legal_tender;

		public int unit;

		public int iap_type;

		public int privilege_num;

		public int star_diamond;
	}

	[Serializable]
	public class Stage : LocalSaveBase
	{
		public int CurrentStage;

		public bool FirstIn;

		[JsonIgnore]
		public bool bNewBestLevel;

		[JsonIgnore]
		public GameMode mode;

		public int NotClearedTimes { get; private set; }

		public int MaxLevel { get; private set; }

		public int BoxLayerID { get; private set; }

		protected override void OnRefresh()
		{
		}

		public void InitMaxLevel(int max)
		{
		}

		public int GetConfigMaxLevel()
		{
			return 0;
		}

		public void GetStageLayer(int currentlayer, out int stage, out int layer)
		{
			stage = default;
			layer = default;
		}

		public void GetStageLayerByMode(bool ifNormal, int currentlayer, out int stage, out int layer)
		{
			stage = default;
			layer = default;
		}

		public void GetUIStageLayer(int currentlayer, out int stage, out int layer)
		{
			stage = default;
			layer = default;
		}

		public void GetLayerBoxStageLayer(int currentlayer, out int stage, out int layer, int maxChapter = 0)
		{
			stage = default;
			layer = default;
		}

		public void GetLayerBoxStageLayerByMode(int currentlayer, out int stage, out int layer, int maxChapter, bool ifNormal)
		{
			stage = default;
			layer = default;
		}

		public void GetLayerBoxStageLayerByMode(int currentlayer, out int stage, out int layer, int maxChapter, GameMode mode)
		{
			stage = default;
			layer = default;
		}

		public void UpdateMaxLevel(int max)
		{
		}

		public void UpdateNotClearedTimes(int max)
		{
		}

		public void InitNotClearedTimes(int times)
		{
		}

		public int GetUICurrentMaxLevel()
		{
			return 0;
		}

		public int GetCurrentMaxLevel()
		{
			return 0;
		}

		public int GetCurrentMaxLevelByMode(bool ifNormal)
		{
			return 0;
		}

		public void InitNextID(int id)
		{
		}

		public int GetNextID()
		{
			return 0;
		}

		public void GetNextEnd()
		{
		}

		public void GetStageBoxEnd()
		{
		}

		public void SetFirstIn()
		{
		}

		public void UnlockNextStage()
		{
		}

		public void RollbackNextStage()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class StageDiscountBody
	{
		public StageDiscountInfo purchased_info;

		public StageDiscountCurrent current_purchase;

		public bool IsValid => false;

		public bool Is_Ad_Free => false;

		public List<Drop_DropModel.DropData> GetList()
		{
			return null;
		}

		public int Get_CurrentID()
		{
			return 0;
		}

		public int Get_LastID()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}
	}

	[Serializable]
	public class StageDiscountInfo
	{
		public string product_id;
	}

	[Serializable]
	public class StageDiscountCurrent
	{
		public string product_id;

		public string[] reward_info;
	}

	[Serializable]
	public new class SaveData : LocalSaveBase
	{
		public bool bInit;

		public UserInfo userInfo;

		public CardData mCardData;

		public ChallengeData mChallengeData;

		public TimeBoxData mTimeBoxData;

		public Stage mStage;

		public Shop_MysticShopModel.MysticShopData mMysticShopData;

		public LocalSaveExtra mExtra;

		public FakeStageDrop mFakeStage;

		public FakeCardCost mFakeCardCost;

		public ShopLocal mShopLocal;

		public ActiveData mActiveData;

		public LocalMail mMail;

		public DropCard mDropCard;

		public GuideData mGuideData;

		public ChallengeMode mChallengeMode;

		public Stage mStageHero;

		public CharacterData mCharacter;

		public DailyEndless mDailyEndless;

		public DailyMaze mDailyMaze;

		public TowerData mTowerData;

		public HeroSkinData mHeroSkinData;

		public LocalSavePlayer player;

		public HomePageData mHomePageData;

		public GamBlingStone gamBlingStone;

		public CargoShipInfo mCargoShip;

		public PrivilegeLocalData privilegeLocalData;

		public Act5thHuntingKillAnimalVO huntingKillAnimalVO;

		public Daily129CacheData daily129CacheData;

		public Stage mStageHell;

		protected override string filename => null;

		protected override void OnRefresh()
		{
		}

		protected override string serializeObject()
		{
			return null;
		}

		public void Clear()
		{
		}
	}

	public enum EThreadWriteType
	{
		eBattle = 0,
		eEquip = 1,
		eNet = 2,
		eLocal = 3,
		eMonster = 4,
		eGuild = 5,
		eMeadowBattle = 6,
		ePVE = 7,
		eCamp = 8,
		eManor = 9,
		eProp = 10,
		eSailing = 11,
		eArtifact = 12,
		eMedal = 13,
		eWing = 14,
		ePet = 15
	}

	public enum TimeBoxType
	{
		BoxChoose_DiamondLarge = 1023,
		BoxChoose_DiamondNormal = 1026,
		BoxChoose_Mix = 1027,
		BoxChoose_Dragon = 1028,
		Box_Relics = 1029,
		Box_EquipS = 1030,
		Box_Manor = 1031,
		Box_Pet = 1032,
		Box_Imprint = 1033
	}

	[Serializable]
	public class TimeBoxOne
	{
		public int maxcount;

		public int count;

		public long time;

		[JsonIgnore]
		public bool IsMax => false;

		public void UpdateCount(int value, bool over)
		{
		}

		public void SetCount(int value)
		{
		}
	}

	[Serializable]
	public class TimeBoxData : LocalSaveBase
	{
		public Dictionary<TimeBoxType, TimeBoxOne> list;

		public bool BoxTips_Switch;

		public int BoxTips_Count;

		protected override void OnRefresh()
		{
		}

		public void Init()
		{
		}

		public long GetTime(TimeBoxType type)
		{
			return 0L;
		}

		public void SetTime(TimeBoxType type, long time)
		{
		}

		public int GetCount(TimeBoxType type)
		{
			return 0;
		}

		public bool IsMaxCount(TimeBoxType type)
		{
			return false;
		}

		public void SetMaxCount(TimeBoxType type, int max)
		{
		}

		public void UpdateCount(TimeBoxType type, int value, bool over)
		{
		}

		public void SetCount(TimeBoxType type, int value)
		{
		}

		private void UpdateRedNode(TimeBoxType type)
		{
		}

		public void Clear()
		{
		}

		public bool CheckTimeBoxUpdateTime()
		{
			return false;
		}
	}

	public class TowerData
	{
		[JsonIgnore]
		public bool isInitByServer;

		[JsonIgnore]
		public ObscuredInt _currentTowerFloor;

		[JsonIgnore]
		public ObscuredInt _CurrentTowerHeroFloor;

		[JsonIgnore]
		public ObscuredInt _lastChance;

		public bool IsHeroMode { get; private set; }

		public int currentTowerFloor
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int CurrentTowerHeroFloor
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int lastChance
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public void OnTowerBattleEnd(bool isWin)
		{
		}

		public void InitByServer(CRespGameTowerInfo resp)
		{
		}

		public void SetLastChance(int count)
		{
		}

		public float GetHarvestRefineAdditon()
		{
			return 0f;
		}

		public void ChangeMode()
		{
		}

		public void DeInit()
		{
		}
	}

	[Serializable]
	public class UserBackInfo : LocalSaveBase
	{
		public enum RequestType
		{
			RequestInfo = 1,
			ReceiveReward = 2
		}

		public enum RewardType
		{
			LoginReward = 1,
			ActivityReward = 2
		}

		public ulong endTime;

		public ushort loginDays;

		public uint comeBackRewardLog;

		public ushort activity;

		public uint activityRewardLog;

		public string[] purchasedIapProductIds;

		public CUserBackRewardsData[] comeBackRewardData;

		public CUserBackRewardsData[] activeRewardData;

		public CUserBackIapRewardsData[] iapRewardsData;

		protected override void OnRefresh()
		{
		}
	}

	[Serializable]
	public class UserInfo : LocalSaveBase
	{
		public string UserID;

		public string NewUserID;

		[JsonIgnore]
		public string UserID_Temp;

		public string NewUserID_Temp;

		public string UserName;

		public string UserName_Temp;

		public ulong ServerUserID;

		public long RegisterTime;

		public string Email;

		public LoginType loginType;

		public long NetID;

		public bool IfExchangeSkill;

		public long TodayEndTimestamp;

		public int OfflineBattleCnt;

		private int starDiamond;

		private int showStarDiamond;

		public long Resource;

		public int StageDiscountID;

		public bool IdfaGemsGot;

		public int Score;

		public bool isInit;

		public long Show_Gold;

		public long Show_Diamond;

		public long Show_Exp;

		public short KeyTrustCount;

		private int _buyKeyCount;

		public bool guide_diamondbox;

		[JsonIgnore]
		public bool bLogined;

		[JsonIgnore]
		public bool bLoginedSDK;

		public ushort m_nLargeDiamondItemCount;

		public ushort m_nMixDiamondItemCount;

		public ushort m_nDragonItemCount;

		public ushort m_nDragonUpCount;

		public ushort m_nBoxRelicsCount;

		public ushort m_nBoxRelicsCount10;

		public ushort m_nBoxEquipSCount;

		public ushort m_nBoxEquipSCount10;

		public ushort m_nBoxManorCountLow;

		public ushort m_nBoxManorCountMid;

		public ushort m_nBoxManorCountHigh;

		public ushort m_nBoxPetCountLow;

		public ushort m_nBoxPetCountMid;

		public ushort m_nBoxPetCountHigh;

		public ushort m_nPetUpCount;

		public ushort m_nBoxImprintCountLow;

		public ushort m_nBoxImprintCountMid;

		public ushort m_nBoxImprintCountHigh;

		public List<string> DoubleDiamondList;

		[JsonIgnore]
		public ulong m_nChapterBanTimestamp;

		public ulong m_nMustDropMask;

		public long Gold { get; private set; }

		public long Diamond { get; private set; }

		public int Key { get; private set; }

		public int reborncount { get; private set; }

		public int Level { get; private set; }

		public int UpgradeLevel { get; set; }

		public long Exp { get; private set; }

		public int RuneUpCount { get; set; }

		public bool IfFacebookLogin { get; set; }

		public int AdKeyCount { get; private set; }

		public int BuyKeyCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int DiamondNormalExtraCount { get; private set; }

		public int DiamondLargeExtraCount { get; private set; }

		public int DiamondMixExtraCount { get; private set; }

		public int DragonKeyCount { get; private set; }

		public int RelicsKeyCount { get; private set; }

		public int EquipSKeyCount { get; private set; }

		public int ManorKeyCount { get; private set; }

		[JsonIgnore]
		public int PetKeyCount => 0;

		[JsonIgnore]
		public int ImprintKeyCount => 0;

		[JsonIgnore]
		public int BattleAdCount { get; private set; }

		[JsonIgnore]
		public int StrengthAdCount { get; private set; }

		public uint total_cash { get; private set; }

		[JsonIgnore]
		public float TotalCashInDollar => 0f;

		public float lastThreePurchaseAvg { get; private set; }

		public int two_week_cash { get; private set; }

		[JsonIgnore]
		public short shopfrag_avail { get; private set; }

		[JsonIgnore]
		public ushort shopfrag_total { get; private set; }

		[JsonIgnore]
		public ulong shopfrag_reset { get; private set; }

		protected override void OnRefresh()
		{
		}

		public void SetGold(long value)
		{
		}

		public void SetDiamond(long value)
		{
		}

		public int GetStarDiamondCount()
		{
			return 0;
		}

		public void SetStarDiamondCount(int count)
		{
		}

		public void ModifyStarDiamondCount(int count)
		{
		}

		public int GetShowStarDiamondCount()
		{
			return 0;
		}

		public void ModifyShowStarDiamondCount(int count)
		{
		}

		public void SetKey(int value)
		{
		}

		public void SetRebornCount(int value)
		{
		}

		public void SetLevel(int value)
		{
		}

		public void SetExp(long value)
		{
		}

		public void SetAdKeyCount(int value)
		{
		}

		public void SetDiamondNormalExtraCount(int value)
		{
		}

		public void SetDiamondLargeExtraCount(int value)
		{
		}

		public void SetDiamondMixExtraCount(int value)
		{
		}

		public void SetDragonKeyCount(int value)
		{
		}

		public void SetRelicsKeyCount(int value)
		{
		}

		public void SetEquipSKeyCount(int value)
		{
		}

		public void SetManorKeyCount(int value)
		{
		}

		public void SetPetKeyCount(int value)
		{
		}

		public void SetImprintKeyCount(int value)
		{
		}

		public void SetBattleAdCount(int value)
		{
		}

		public void SetStrengthAdCount(int value)
		{
		}

		public void SetTotal_Cash(uint value)
		{
		}

		public void SetLastThreePurchaseAvg(uint value)
		{
		}

		public void SetTwoWeekCash(uint value)
		{
		}

		public void SetShopFrag(short min, ushort max, ulong timestamp)
		{
		}

		private void ResetShopFrag()
		{
		}

		public bool GetShopFrag()
		{
			return false;
		}

		public void IncShopFrag()
		{
		}
	}

	public class iapinfo
	{
		public string[] sss;
	}

	public class WeaponSkinVO
	{
		public int skinId;

		public int WeaponHandId;

		public int BulletModelId;

		public int ColorID;

		public int WeaponSkinLv;

		public Equip_WeaponSkin Meta;

		public bool IsDefaultSkin()
		{
			return false;
		}
	}

	public class WeaponSkinData
	{
	}

	[Serializable]
	public class PetOne
	{
		public int ID;

		public int Level;

		public int Star;

		public bool isUnLock;

		public int WarIndex;

		public List<int> skiLv;

		public List<int> skiId;

		[JsonIgnore]
		public PetWarState WarState => PetWarState.Idle;

		[JsonIgnore]
		public Sprite WarStateIcon => null;

		[JsonIgnore]
		public PetOne GetAssistPetOne => null;

		[JsonIgnore]
		public Pet_Pet Config => null;

		[JsonIgnore]
		public int CharId => 0;

		[JsonIgnore]
		public int FragmentId => 0;

		[JsonIgnore]
		public int FragmentNum => 0;

		[JsonIgnore]
		public int Type => 0;

		[JsonIgnore]
		public string Name => null;

		[JsonIgnore]
		public string NameC => null;

		[JsonIgnore]
		public string NameCByRare => null;

		[JsonIgnore]
		public string NameColorKey => null;

		[JsonIgnore]
		public Sprite TypeImage => null;

		[JsonIgnore]
		public string TypeName => null;

		[JsonIgnore]
		public Sprite PropBgIcon => null;

		[JsonIgnore]
		public int RareQ => 0;

		[JsonIgnore]
		public Sprite PropIcon => null;

		[JsonIgnore]
		public Sprite FaceIcon => null;

		[JsonIgnore]
		public Sprite FaceIconBG => null;

		[JsonIgnore]
		public Sprite CardBg => null;

		[JsonIgnore]
		public Sprite CardIcon => null;

		[JsonIgnore]
		public int Rare => 0;

		[JsonIgnore]
		public Sprite RatingImage => null;

		[JsonIgnore]
		public bool canUpgrade => false;

		[JsonIgnore]
		public bool canUnLock => false;

		[JsonIgnore]
		public bool canUpStar => false;

		[JsonIgnore]
		public bool canSkillUp => false;

		[JsonIgnore]
		public PetUpNeedCond NeedLevelUp => null;

		[JsonIgnore]
		public PetUpNeedCond NeedStarUp => null;

		[JsonIgnore]
		public string ModelPath => null;

		[JsonIgnore]
		public GameObject Model => null;

		[JsonIgnore]
		public int NeedLevelUpId => 0;

		[JsonIgnore]
		public int LevelMax => 0;

		[JsonIgnore]
		public int StarMax => 0;

		[JsonIgnore]
		public float CostCoefficient => 0f;

		[JsonIgnore]
		public float AttrCoefficient_Level => 0f;

		[JsonIgnore]
		public float AttrCoefficient_Star => 0f;

		[JsonIgnore]
		public int StarNeedFragment => 0;

		[JsonIgnore]
		public string StarNeedMatExtra => null;

		[JsonIgnore]
		public string AttributeBasicStr => null;

		[JsonIgnore]
		public int ATKBasic => 0;

		[JsonIgnore]
		public int HPBasic => 0;

		[JsonIgnore]
		public int ATKLevel => 0;

		[JsonIgnore]
		public int HPLevel => 0;

		[JsonIgnore]
		public int ATKTotal => 0;

		[JsonIgnore]
		public int HPTotal => 0;

		[JsonIgnore]
		public List<PetAttrData> AttrList_Level => null;

		[JsonIgnore]
		public List<PetAttrData> AttrList_Star => null;

		public PetOne Clone()
		{
			return null;
		}

		public void UnLock()
		{
		}

		public void UpGrade(int deltaLevel = 1)
		{
		}

		public void UpStar(int deltaStar = 1)
		{
		}

		public int Pet_SkiIdFindSkiLvPos(int skiId)
		{
			return 0;
		}

		public int Pet_SkiIdFindInheritIndex(int skill)
		{
			return 0;
		}
	}

	public abstract class GuideDataBase
	{
		[CompilerGenerated]
		private Action<int> m_OnCompleteStep;

		protected int conductStep;

		protected abstract ushort guideId { get; }

		protected abstract int stepCount { get; }

		protected abstract List<Func<bool>> stepCondition { get; }

		public int Schedule
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool IsComplete => false;

		public bool IsConducting => false;

		public event Action<int> OnCompleteStep
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public bool StartGuideStep(int step)
		{
			return false;
		}

		public abstract void OnStartGuideStep();

		public void CompleteStep(int step)
		{
		}
	}

	public class PetBoxGuideData : GuideDataBase
	{
		protected override ushort guideId => 0;

		protected override int stepCount => 0;

		protected override List<Func<bool>> stepCondition => null;

		public override void OnStartGuideStep()
		{
		}
	}

	public class PetGuideData : GuideDataBase
	{
		protected override ushort guideId => 0;

		protected override int stepCount => 0;

		protected override List<Func<bool>> stepCondition => null;

		public override void OnStartGuideStep()
		{
		}
	}

	public class WingOne
	{
		public int ID;

		public ulong RowId;

		public bool isUnLock;

		public int WearIndex;

		public int Level;

		public int StarID;

		public int[] Assists;

		[JsonIgnore]
		public Action onUnLock;

		[JsonIgnore]
		public Action<bool> onWear;

		[JsonIgnore]
		public Action onUpGrade;

		[JsonIgnore]
		public Action onUpStar;

		[JsonIgnore]
		public Action onUpAssists;

		[JsonIgnore]
		public Action onDownAssists;

		[JsonIgnore]
		public bool isWear => false;

		[JsonIgnore]
		public bool isEquip => false;

		[JsonIgnore]
		public bool isDisplay => false;

		[JsonIgnore]
		public int Star => 0;

		[JsonIgnore]
		public Wings_Wings Config => null;

		[JsonIgnore]
		public Vector3 UIShowPos => default;

		[JsonIgnore]
		public float UIShowScale => 0f;

		[JsonIgnore]
		public float UIShowface => 0f;

		[JsonIgnore]
		public string[] SlotUnlockStar => null;

		[JsonIgnore]
		public int FragmentId => 0;

		[JsonIgnore]
		public int UpgradeMatId => 0;

		[JsonIgnore]
		public int MaxAssistCount => 0;

		[JsonIgnore]
		public int SpeedSkillId => 0;

		[JsonIgnore]
		public int AssistSkillBaseId => 0;

		[JsonIgnore]
		public int AssistSkillId => 0;

		[JsonIgnore]
		public List<int> SkillIds => null;

		[JsonIgnore]
		public int NeedFragment => 0;

		[JsonIgnore]
		public int NeedDiamond => 0;

		[JsonIgnore]
		public Sprite FragmentIcon => null;

		[JsonIgnore]
		public int Quality => 0;

		[JsonIgnore]
		public int Rarity => 0;

		[JsonIgnore]
		public string Name => null;

		[JsonIgnore]
		public string NameChinese => null;

		[JsonIgnore]
		public Sprite PropIcon => null;

		[JsonIgnore]
		public Sprite PropBgIcon => null;

		[JsonIgnore]
		public Sprite RarityIcon => null;

		[JsonIgnore]
		public Sprite BigIcon => null;

		[JsonIgnore]
		public string[] WingAttributes => null;

		[JsonIgnore]
		public int[] UnlockType => null;

		[JsonIgnore]
		public string[] UnlockTypeInfo => null;

		[JsonIgnore]
		public bool IsCanUnLock => false;

		[JsonIgnore]
		public List<Goods_goods.GoodData> Attributes => null;

		[JsonIgnore]
		public Dictionary<string, Goods_goods.GoodData> AttributesDic => null;

		[JsonIgnore]
		public Dictionary<string, Goods_goods.GoodData> NextLevelAddAttr => null;

		[JsonIgnore]
		public Dictionary<string, Goods_goods.GoodData> NextStarAddAttr => null;

		[JsonIgnore]
		public Dictionary<int, string> levelUnLockEntry => null;

		[JsonIgnore]
		public Dictionary<int, string> starUnLockEntry => null;

		[JsonIgnore]
		public int LevelMax => 0;

		[JsonIgnore]
		public int LevelInCurStar => 0;

		[JsonIgnore]
		public int StarIdMax => 0;

		[JsonIgnore]
		public int StarMax => 0;

		[JsonIgnore]
		public bool IsMaxLevel => false;

		[JsonIgnore]
		public bool IsMaxStar => false;

		[JsonIgnore]
		public bool IsCanUpLevel => false;

		[JsonIgnore]
		public bool IsCanUpLevelByStar => false;

		[JsonIgnore]
		public bool IsCanUpLevelByMats => false;

		[JsonIgnore]
		public bool IsCanUpStar => false;

		[JsonIgnore]
		public List<Drop_DropModel.DropData> NextUpLevelNeedMat => null;

		[JsonIgnore]
		public List<Drop_DropModel.DropData> NextUpStarNeedMat => null;

		[JsonIgnore]
		public int LevelForOneKey => 0;

		[JsonIgnore]
		public List<Goods_goods.GoodData> AttributesMax => null;

		[JsonIgnore]
		public Dictionary<string, Goods_goods.GoodData> AttributesDicMax => null;

		[JsonIgnore]
		public List<int> TryPlayShowStar => null;

		public WingOne Clone()
		{
			return null;
		}

		public void UnLock()
		{
		}

		public void Wear(int wearIndex)
		{
		}

		public void UnWear()
		{
		}

		public void UpGrade(int deltaLevel = 1)
		{
		}

		public void UpStar(int deltaStar = 1)
		{
		}

		public List<Drop_DropModel.DropData> GetUpLevelNeedMat(int toLevel)
		{
			return null;
		}

		public bool IsUnLockAssistIndex(int assistIndex)
		{
			return false;
		}

		public int GetWingIdByAssistIndex(int assistIndex)
		{
			return 0;
		}

		public List<WingOne> GetAssistWings()
		{
			return null;
		}

		public bool HasIndexToAssist()
		{
			return false;
		}

		public bool WingIsAssisting(int wingId)
		{
			return false;
		}

		public bool UpAssists(int wingId)
		{
			return false;
		}

		public void DownAssists(int wingId)
		{
		}

		public Dictionary<string, Goods_goods.GoodData> GetAttributesByStarAndLevel(int star, int level)
		{
			return null;
		}
	}

	public class WingGuideData : GuideDataBase
	{
		protected override ushort guideId => 0;

		protected override int stepCount => 0;

		protected override List<Func<bool>> stepCondition => null;

		public override void OnStartGuideStep()
		{
		}
	}

	[Serializable]
	public class LocalNewPlay125VO : ICloneable<LocalNewPlay125VO>
	{
		public string LOG_TAG;

		public LocalBackpackVO BackpackVO;

		public LocalWeaponVO WeaponVO;

		public LocalInGameVO InGameVO;

		public void Clear()
		{
		}

		public void Clone(LocalNewPlay125VO source)
		{
		}
	}

	[Serializable]
	public class LocalNewPlay126VO : ICloneable<LocalNewPlay126VO>
	{
		public NewPlay126MonsterEntityGroupData NewPlay126MonsterEntityGroupData;

		public NewPlay126MonsterRemouldStoneData NewPlay126MonsterRemouldStoneData;

		public NewPlay126SkillGroupData NewPlay126SkillGroupData;

		public void Clone(LocalNewPlay126VO source)
		{
		}

		public void SetCreateMonsterData(NewPlay126MonsterEntityGroupItemData monsterData)
		{
		}

		public void Init()
		{
		}

		public void Clear()
		{
		}
	}

	private LocalSaveBelief belief;

	private LocalSaveImprint imprint;

	private ImprintBoxGuideData imprintBoxGuide;

	private ImprintGuideData imprintGuide;

	private static LocalSave _instance;

	private UserInfo userInfo;

	private CardData mCardData;

	private ActiveData mActiveData;

	private ChallengeData mChallengeData;

	private ArtifactData artifactData;

	public const string BattleInString = "BattleInString";

	public const string BattleInModeString = "BattleInModeString";

	private int BattleIn_Mode;

	private BattleInBase mBattleIn;

	public BattlePassConfigAllData battlePassAllData;

	public BattlePassConfigData battlePassConfigData;

	private Dictionary<NewBpType, BattlePassNewItemConfig> newBpAllConfig;

	public Dictionary<NewBpType, BattlePassNewData> newBpAllData;

	private bool checkOK;

	private bool isSyncData;

	public int BPBuyDiscountValue;

	private DropCard mBoxDropCard;

	public static Action CardUpdateEvent;

	private const string ChallengeConst = "ChallengeConstLocal";

	private ChallengeMode _challengemode;

	public const int FirstCharacterID = 10000;

	public DailyActivityData mDailyActivity;

	public WeekActivityData mWeekActivity;

	private CGuildRedpacketData[] m_arrayRedpacketData;

	public MonthActivityData mMonthActivity;

	private const string Product_AD = "daily_ad";

	public DragonDropUp dragonDropUpInfo;

	public const int MAX_DRAGON_SLOTS = 3;

	public const int EquipCount = 9;

	public static Dictionary<int, Color> QualityColors;

	public static Dictionary<int, string> QualityColorsStr;

	public static Dictionary<int, int> EquipPositions;

	private const string REFINE_TAG = "[精炼技能]";

	private Dictionary<int, bool> equipCanCombineDict;

	private const string effect_color_front = "UI_EquipItem_Color_Front";

	private const string effect_color_back = "UI_EquipItem_Color_Back";

	private const string effect_red_front = "UI_EquipItem_Red_Front";

	private const string effect_red_back = "UI_EquipItem_Red_Back";

	public LocalSaveExtra _saveExtra;

	private FakeStageDrop _fakestagedrop;

	private FakeCardCost _fakecardcost;

	public int[] GemNeed;

	public const int GemMaxLevel = 13;

	public const int EndChapter6Layer = 240;

	public Dictionary<int, GemDropOne> gemDropDict;

	public int pushGemId;

	public const int MAX_GEM_LOCATIONS = 9;

	private GrowthFundData growthFundData;

	private GuideData _guidedata;

	[JsonIgnore]
	private bool isGetingGuidFromServer;

	[JsonIgnore]
	private bool startUpdateGuid;

	[CompilerGenerated]
	private Action m_getGuidEvent;

	[JsonIgnore]
	private static bool needUpLoadGuidData;

	public string guildId;

	public bool getQuestReward;

	private bool Trigger_inTimeQueue;

	private Queue<string> inTimeQueue;

	public const int Guild_Need_Level_Gift = 1;

	public const int Guild_Need_Level_Help = 3;

	public const int Guild_Need_Level_Hacth = 3;

	public const int Guild_Need_Level_Equip = 3;

	public const int Guild_Need_Level_Fragment = 5;

	public const int Guild_Need_Level_Gems = 7;

	public int Guild_Chat_LocalIndex;

	public Action onUpdateTableView;

	[CompilerGenerated]
	private Action<string, ActionData> m_OnEventHandlePush;

	public Dictionary<string, string> ChatTextTranslateDict;

	public bool isOpenTextChat;

	public int Guild_Gift_No_Get;

	public int Guild_HelpEgg_No_Get;

	public bool isNeedFreshItemsForGuild;

	public const float TimeOut_ChatHistory = 300f;

	public long LastTime_ChatHistory;

	public string TempGuildIdForChat;

	public GuildUICtrl.GuildTab currentGuildTab;

	public bool RedPoint_InHelpPlayer;

	public List<ChatMsgDataBase> chatDataList;

	public List<ChatMsgDataHelp> helpDataList;

	public List<ChatMsgDataGift> giftDataList;

	public Action onEventAddMessage;

	public Action<int> onEventUpdateMessage;

	private Dictionary<ulong, GuildMessageEntity> cacheUpdateMsg;

	public bool Trigger_combineQueue;

	public Queue<int> combineQueue;

	public bool isOpenGuildChatInput;

	public const int RankPageSize = 60;

	public Dictionary<int, List<GuildRankItemUIData>> rankGuildDataDict;

	public int GuildOpenNewCode;

	private long GuildOpenNewTime;

	public List<GuildBasicData> suggestGuildList;

	public bool haveClickADPanel;

	private HarvestData _harvest;

	private HarvestData _harvestShort;

	private List<HarvestShortButtonData> shortButtonList;

	public int Harvest_ShortHaveTimes;

	public long Harvest_ShortLastTime;

	public bool isRquestingHarvest;

	public int curHarvestLevel;

	private const int OutputTime = 4320;

	public const float rewardCreateWait = 0.1f;

	public const float rewardCreatePerWait = 0.03f;

	public bool haveHarvestLevelSyncData;

	private double coin_coeff;

	private double exp_coeff;

	private double equipexp_coeff;

	private double stone_coeff;

	private double refine_coeff;

	private double cookie_coeff;

	private double bloodstone_coeff;

	private double gem1_coeff;

	private double gem2_coeff;

	private double equip1_coeff;

	private double equip2_coeff;

	private double relic_coeff;

	private double relicstone_coeff;

	private double dragonstone_coeff;

	private double epigraph_coeff;

	private double fetterbadge_coeff;

	private double fountain_use_exp_coeff;

	private double fountain_upgrade_exp_coeff;

	private double equip_quintessence_exp_coeff;

	private double pet_level_up_item_exp_coeff;

	public const int HeroSkinCollectExpPropID = 31019;

	public const int HeroSkinNormalTicketPropID = 50001;

	public const int HeroSkinSpecialTicketPropID = 50002;

	public const int HeroSkinRedTicketPropID = 50003;

	private int _crtHeroSkinCollectLV;

	private MainActivityData _mainactivitydata;

	private bool bMainActivityValid;

	public LocalSave_MazeConfig MazeConfig;

	public LocalSave_MazeLine MazeLine;

	private int Line;

	private Dictionary<int, LocalSave_MazeLineItem> m_dicMazeLines;

	private LocalSaveMedal medal;

	private int receiveCount;

	public bool isReinstall;

	public Dictionary<string, GameObject> MedalAniDict;

	public bool haveGetServerData;

	public const string Special_HitAdd = "HitAdd%";

	public const string Special_HitReduce = "HitReduce%";

	public Dictionary<int, Dictionary<int, int>> eggPRDict;

	public Dictionary<int, Dictionary<int, int>> monsterKillChapterDict;

	public int currentGameMode;

	public int currentChapter;

	public int TempBattleMid;

	public int HatchTime_Rune_Add;

	public int HatchTime_Month_Add;

	public int HatchTime_BP_Add;

	public int HatchTime_Altar_Add;

	public int HatchTime_VIP_Add;

	public Dictionary<ulong, int> TempEggFlyDict;

	private string TCArchive_Equipment0;

	private int TCArchive_data2;

	private int TCArchive_data3;

	private int TCArchive_data4;

	private int TCArchive_data5;

	private int TCArchive_data6;

	private int TCArchive_data7;

	public MonthlyCardData monthlyCardData;

	public MonthlyCardData monthlyCardPremiumData;

	private LocalSavePlayer player;

	public static int Manor_VersionDefult;

	public static int HeadDefault;

	public static int HeadFrameDefault;

	public long cashBeginTime;

	public long cashEndTime;

	public long cashLastRewardTime;

	public int cashOpenLevel;

	public int cashPayScore;

	public int cashBoxMax;

	public int cashBoxProgress;

	public long cashGiftRewardFlag;

	public long cashGiftExtraRewardFlag;

	public int cashBoxGetIndex;

	public List<List<int>> cashTaskRewardDataList;

	public List<CashGiftItemData> cashGiftList;

	public List<CashGiftItemData> cashGiftExtraList;

	public List<CashTaskItemData> cashTaskList;

	public int Cash_StyleId;

	public bool VIP_HavePullInfo;

	public long VIP_BoxGetTime;

	public long VIP_BoxDailyGetTime;

	public ulong VIP_RewardFlag;

	public Dictionary<int, int> VIPBuyDict;

	public int VIP_BuyCount;

	private Dictionary<ulong, PlayerBasicInfo> PlayerBasicInfoDict;

	public Dictionary<CurrencyType, int> currencyDict;

	[CompilerGenerated]
	private Action<CurrencyType, int, int> m_OnCurrencyChanged;

	private long manorStealKeyBeginTime;

	public PVETab currentPVETab;

	private bool m_bIsRequestDataFlag;

	public const int PVE_MaxPartition = 7;

	public bool PVE_HavePullTalentData;

	public bool PVE_HavePullHarvestData;

	public long PVE_HarvestLastTime;

	public List<PVEShopDataNormal> pveShopList;

	public List<PVEShopDataNormal> pveShopScoreList;

	public List<PVEShopDataChapter> pveShopChapterList;

	public List<int> pveShopIAPHaveBuy;

	public List<PVERankItemData> pveRankLevelList;

	public List<PVERankItemData> pveRankSoulList;

	private PVERankItemData MyPVERankData;

	private PVERankItemData MyPVERankWeekData;

	public List<PVERankRewardData> pveRankRewardList;

	public List<PVERankRewardData> pveRankWeekRewardList;

	public List<PVERankDivisionData> pveRankDivisionList;

	public Dictionary<int, int> pointDataDict;

	public int PVE_Exc_Coin;

	public int PVE_Exc_TodayHave;

	public int PVE_Exc_TodayMax;

	public List<ExcInData> PVE_ExcInList;

	public RefineData mRefineData;

	private List<List<int>> carvingSlotUnlockLevel;

	private Dictionary<int, EquipOne> _relicsDict;

	public SailingData sailingData;

	private ShopLocal _shop;

	public List<ShopIAPData> Shop_IAPDataList;

	private Dictionary<string, int> Shop_VIPProdDict;

	public Action OnMaxLevelUpdate;

	private Stage _stagenormal;

	private Stage _stagehero;

	private Stage _stagehell;

	private StageDiscountBody mStageDiscount;

	public SaveData mSaveData;

	private object mThreadDoing;

	private List<FileSaveMgr.WriteData> mWriteList;

	private TimeBoxData mTimeBox;

	private UserBackInfo userBackInfo;

	private static bool bFirstLogin;

	private ulong m_ulTimeEndToday;

	private Coroutine m_UpdateTimeEndTodayCoroutine;

	private const string CurrencyConst = "Currency";

	public static Action<long, long> GoldUpdateEvent;

	private long mCurrencyKeyTime;

	private string m_BoundHabbyId;

	private long mCurrentBuyKeyTimestamp;

	private long mTodayEndTimestamp;

	private long mAdKeyTimeStamp;

	private long mLuckyItemTimeStamp;

	public const string ALL_WEAPON = "AllWeapon_";

	public const int DEFAULT_WEAPON_SKIN_ID = 0;

	public const int DEFAUL_WEAPON_ID = 1000;

	public const string WEAPON_SKIN_LOG_TAG = "[WeaponSkin]";

	private List<int> WeaponSkinIds;

	private List<int> UsingWeaponSkinIds;

	private List<int> WeaponSkinColorIds;

	private List<int> ActivateWeaponSkinIDs;

	public List<int> ActivateWeaponSkinColorIDs;

	public Dictionary<int, int> weaponSkinLv;

	private int _crtWeaponSkinCollectLV;

	public const int ExpPropID = 31017;

	public const int GoldStonePropID = 51002;

	public const int MoonStonePropID = 51003;

	public List<Drop_DropModel.DropData> exchangeSkinReward;

	private readonly Dictionary<int, int> BulletToEquipMapping;

	private LocalSavePet pet;

	private PetBoxGuideData petBoxGuide;

	private PetGuideData petGuide;

	public CPetExchangeData[] petShopItems;

	public long petShopEndTime;

	public long PetBoxEndTime;

	public PetDropUp petDropUpInfo;

	private LocalSaveWing wing;

	private WingGuideData wingGuide;

	public LocalSaveBelief Belief => null;

	public LocalSaveImprint Imprint => null;

	public ImprintBoxGuideData ImprintBoxGuide => null;

	public ImprintGuideData ImprintGuide => null;

	public static LocalSave Instance => null;

	public List<int> Activity_GetContractIds => null;

	public float MonsterToEliteRate => 0f;

	public (List<string> attrs, List<int> ids) Activity_MonsterAttributesAndIds => default;

	public (List<string> attrs, List<int> ids) Activity_NpcAttributesAndIds => default;

	public (List<string> attrs, List<int> ids) Activity_HeroAttributesAndIds => default;

	public float Activity_Reward_Gold_Rate => 0f;

	public float Activity_Reward_Exp_Rate => 0f;

	public float Activity_Reward_Equip_Rate => 0f;

	public float Activity_Reward_Loupe_Rate => 0f;

	public float Activity_Reward_Cookie_Rate => 0f;

	public float Activity_Reward_Gem_Rate => 0f;

	public int Activity_ContractLevel => 0;

	public ArtifactData Artifact => null;

	public bool BattleIn_In { get; private set; }

	public BattleInBase BattleIn => null;

	public float BattleIn_BoxingSuperSkillTime => 0f;

	public float BattleIn_FlashSuperSkillTime => 0f;

	public long BattleIn_Daily130AccumulatedDamage => 0L;

	public long BattleIn_Daily130SettlementDamage => 0L;

	public int BattleIn_Daily130BattleId => 0;

	public long BattleIn_DragonBoxItem => 0L;

	public bool BattleIn_DropEquipByServer => false;

	public float BattleIn_CritRateAddTotal => 0f;

	public int BattleIn_GetDungeonRefreshCnt => 0;

	public int BattleIn_GetDungeonBuffEffect => 0;

	public List<int> BattleIn_GetDungeonBuffIds => null;

	public Dictionary<int, int> KillMonstersDataInPveSeason => null;

	public int HpFoodTotal => 0;

	public int BattleIn_HpFoodTotal2 => 0;

	public float BattleIn_TotalAddByKillEnemy => 0f;

	public long BattleIn_SkillAlone1657TotalAdded => 0L;

	public int BattleIn_SkillAlone1664KillCnt => 0;

	public bool BattleIn_SkillAlone1655Flag => false;

	public long BattleIn_SkillAlone1671RecoverHpTotal => 0L;

	public int BattleIn_SkillAlone1675HpFoodCnt => 0;

	public int BattleIn_SkillAlone1675AngelCnt => 0;

	public float BattleIn_SuperSkillCDTime => 0f;

	public float BattleIn_ExtraSuperSkillCDTime => 0f;

	public float BattleIn_WuKongSuperSkillCDTime => 0f;

	public long BattleIn_PveSeasonStartTime => 0L;

	public long BattleIn_PveSeasonEndTime => 0L;

	public List<int> TreasuresSkills => null;

	public List<int> CullSkills => null;

	public int BattleIn_PveSeasonSelectedHero => 0;

	public int BattleIn_PveSeasonWeekTopic => 0;

	public int BattleIn_ChargeValue => 0;

	public int BattleIn_BulletCnt => 0;

	public bool UseBigMap => false;

	public long BattleIn_AssistanterHpMax => 0L;

	public int BattleIn_AssistanterIndex => 0;

	public (int, float, float, int[], int) BattleIn_AssistDatas => default;

	public long BattleIn_TotalVampire => 0L;

	public long BattleIn_TotalLoseHp => 0L;

	public int BattleIn_TotalAbsorbHp => 0;

	public int BattleIn_ShieldCount => 0;

	public int BattleIn_TotalIntegral => 0;

	public int MulanRotateSwordCnt => 0;

	public bool MulanDropHpUsed => false;

	public int BattleIn_Relics70001Cd => 0;

	public float BattleIn_TotalAddRatio => 0f;

	public float BattleIn_TotalAddedAttackSpeedPercent => 0f;

	public float BattleIn_TotalAddedMoveSpeedPercent => 0f;

	public int BattleIn_UsedFreshSkillCardCount => 0;

	public int BattleIn_SkillAlone2075HpFoodCnt => 0;

	public bool BattleIn_ShouldShowAngelOfJudgment => false;

	public bool BattleIn_AngelOfJudgment => false;

	public bool BattleIn_ShouldShowAngelOfLight => false;

	public bool BattleIn_AngelOfLight => false;

	public bool BattleIn_Skill2156Used => false;

	public long BattleIn_DemonKingShieldValue => 0L;

	public bool BattleIn_Skill2165Use => false;

	public bool BattleIn_SkillAlone2191UsedFlag => false;

	public int BattleIn_CurWuKongCoreEnergy => 0;

	public int BattleIn_CurWuKongMonsterKilledCount => 0;

	public int BattleIn_StarSkillIdForHammer => 0;

	public int BattleIn_StartSkillIdForKatana => 0;

	public int BattleIn_GuGuFoeverBuffTims => 0;

	public int BattleIn_GetFengRenBoxCnt => 0;

	public CampData campData { get; private set; }

	public ChallengeMode mChallengeMode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EmojiSetting emojiSetting { get; private set; }

	public EquipData mEquip { get; private set; }

	public LocalSaveExtra SaveExtra => null;

	public Dictionary<string, string> cacheDict => null;

	public FakeStageDrop mFakeStageDrop => null;

	public FakeCardCost mFakeCardCost => null;

	public GamBlingStone gamBlingStoneData => null;

	public int GemTotalQuality => 0;

	public int GemOpenSlotNum => 0;

	public GrowthFundData GrowthFundData => null;

	public GuideData mGuideData => null;

	public GuildData guildData { get; private set; }

	public int GuildIconHelpCount
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public long GuildOpenNewTimeLeft => 0L;

	public HarvestData mHarvest
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public HarvestData mHarvestShort
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int MinHarvestLevel => 0;

	public int MaxHarvestLevel => 0;

	public int MaxHarvestBtnCount => 0;

	public LocalMail Mail { get; private set; }

	public MainActivityData mMainActivityData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ManorLocalData manorLocalData { get; private set; }

	public MeadowBattleData mMeadowBattleData { get; set; }

	public LocalSaveMedal Medal => null;

	public EMData emData { get; private set; }

	public ulong monthlyCard_expireTimestamp => 0uL;

	public ulong monthlyCardPremium_expireTimestamp => 0uL;

	public bool monthlyCard_isValid => false;

	public bool monthlyCardPremium_isValid => false;

	public bool monthlyCard_newSubscriber => false;

	public bool monthlyCard_canReceive => false;

	public bool monthlyCardPremium_canReceive => false;

	public int monthlyCard_daysBeforeExpire => 0;

	public int monthlyCardPremium_daysBeforeExpire => 0;

	public bool monthlyCard_expireSoon => false;

	public bool monthlyCardPremium_expireSoon => false;

	public LocalSavePlayer Player => null;

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int headId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int headFrameId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public long headFrameTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public int VIP_Lv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int VIP_Score
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public PropData propData { get; private set; }

	public long ManorStealKeyBeginTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public PVEData pveData { get; private set; }

	public int BuyLifeCnt => 0;

	public int PveSeasonTag => 0;

	public int PveSeasonNextTag => 0;

	public int PveSeasonPartitionId => 0;

	public int SeasonCurChapter => 0;

	public int SeasonCurHardChapter => 0;

	public bool IsCompletePveSeasonAllChapter => false;

	public bool IsCompletePveSeasonAllHardChapter => false;

	public bool IsPveSeasonOver => false;

	public int PveSeasonBeanId => 0;

	public int PveSeasonHardBeanId => 0;

	public PVEStage_stagechapter[] CurPveSeasonStageChapters => null;

	public bool IsPveSeasonUnlock => false;

	public bool IsPveSeasonIAPBattlepass => false;

	public bool PveNewChapterFirstIn => false;

	public bool PveNewChapterHardFirstIn => false;

	public int PveLife => 0;

	public int PveSoulPoint => 0;

	public int PveSoulCrystal => 0;

	public int PveSuperSoulCrystal => 0;

	public int PveSeasonTopic => 0;

	public bool SeasonTopicIsGemTopic => false;

	public int PveSeasonWeekTopic => 0;

	public long SeasonStartTime => 0L;

	public long SeasonEndTime => 0L;

	public long PveSeasonNextStartTime => 0L;

	public long PveSeasonNextEndTime => 0L;

	public long PveSeasonNextShopEndTime => 0L;

	public long PveSeasonShopEndTimestamp => 0L;

	public long PveSeasonBanTimestamp => 0L;

	public int CurSeasonDay => 0;

	public float SeasonTopicGemRatio => 0f;

	public int SeasonPveLife => 0;

	public bool SeasonReSelectFlag => false;

	public int SeasonSelectedHero => 0;

	public int SeasonAssistHeroId => 0;

	public int SeasonSelectedHeroProfessionId => 0;

	public int RefreshProfessionTimes => 0;

	public int[] SeasonHeroIds => null;

	public int PVE_Exc_DayEnd => 0;

	public int PveHardModeUnlockStage => 0;

	public int PveHardModeUnlockChapter => 0;

	public bool IsPveHardModeUnlock => false;

	public List<List<int>> CarvingSlotUnlockLevel => null;

	public Dictionary<int, EquipOne> relicsDict
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SeasonBattlePassInfo seasonBP { get; private set; }

	public int PveBattlePassTag => 0;

	public ServerData mServerData { get; private set; }

	public bool IsPremiumActive => false;

	public ShopLocal mShop => null;

	public Stage mStage
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Stage mStageHero
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Stage mStageHell
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UserBackInfo UserBack_info => null;

	public bool UserBack_hasAvailableCheckInReward => false;

	public bool UserBack_hasAvailableActivityReward => false;

	public bool UserBack_hasAvailableGiftPack => false;

	public bool UserBack_hasAvailableItem => false;

	public bool CanDropType501Equip => false;

	public bool CanDropType401Or402Equip => false;

	public bool CanDropFirstEquip => false;

	public ulong timeEndToday => 0uL;

	public int OfflineBattleCnt => 0;

	public int GetNeedDiamond10_Manor => 0;

	private int maxLevel => 0;

	[JsonIgnore]
	public bool LogicOnce { get; private set; }

	public bool IsBindHabbyId => false;

	public bool IsWeaponSkinEnabled => false;

	public int MockWeaponSkinId => 0;

	public LocalSavePet Pet => null;

	public PetBoxGuideData PetBoxGuide => null;

	public PetGuideData PetGuide => null;

	public bool IsPetShopOpen => false;

	public bool PetBoxOpen => false;

	public LocalSaveWing Wing => null;

	public WingGuideData WingGuide => null;

	private event Action getGuidEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<string, ActionData> OnEventHandlePush
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<CurrencyType, int, int> OnCurrencyChanged
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private LocalSaveBelief initBeliefData()
	{
		return null;
	}

	public LocalSaveImprint initImprintData()
	{
		return null;
	}

	public ImprintOne GetNewImprintOne(int pid, int level)
	{
		return null;
	}

	public void RequestImprintBox()
	{
	}

	public void RequestImprint()
	{
	}

	public void RequestImprintLevelUp(long imprintRowID, Action callback)
	{
	}

	public void RequestImprintUnLock(int imprintID, Action<ulong> callback)
	{
	}

	public void RequestImprintAssembly(long imprintRowID, int warIndex, Action callback)
	{
	}

	public void RequestImprintUnAssembly(int warIndex, Action callback)
	{
	}

	public void RequestUnLockBelief(int talentId, Action callback = null)
	{
	}

	public void RequestGetUnLockBeliefRewards(int talentId, Action callback = null)
	{
	}

	public void InitData()
	{
	}

	public void syncEquips2Server()
	{
	}

	private void tryGetUserInfo()
	{
	}

	public void DeInit()
	{
	}

	private void Init()
	{
	}

	public int GetExpByLevel(int level)
	{
		return 0;
	}

	public void ExcuteModeChest(int dropid)
	{
	}

	public void AddPropByType(CEquipmentItem item)
	{
	}

	public void AddProp(CEquipmentItem item)
	{
	}

	public void AddProp(Drop_DropModel.DropData item)
	{
	}

	public void AddProp(string value)
	{
	}

	public void AddProps(CEquipmentItem[] list, CEquipmentAddType type)
	{
	}

	public void AddProp(Drop_DropModel.DropData one, CEquipmentAddType type)
	{
	}

	public void AddProps(List<Drop_DropModel.DropData> list, CEquipmentAddType type)
	{
	}

	public void CostVoucher(int id, int cost)
	{
	}

	protected override void OnRefresh()
	{
	}

	private void InitActive()
	{
	}

	public List<ActiveOne> GetActives()
	{
		return null;
	}

	public int GetActiveCount(int index)
	{
		return 0;
	}

	public void UseActiveCount(ActiveOne one)
	{
	}

	public void Activity_SetContractIds(List<int> ids)
	{
	}

	public string GetActivity_113_DiffIds()
	{
		return null;
	}

	public int GetActivity_113_DiffLv()
	{
		return 0;
	}

	private ArtifactData initLocalDataArtifact()
	{
		return null;
	}

	public void unInitDataArtifact()
	{
	}

	public void FreshDataArtifact()
	{
	}

	public void SetBattleInWatchRebornAD(bool pWatching)
	{
	}

	public void BeforeBattleIn_Check()
	{
	}

	public void BattleIn_Check()
	{
	}

	public uint BattleIn_GetTransID(bool newtransid)
	{
		return 0u;
	}

	public void BattleIn_SaveBattleTransId()
	{
	}

	public void BattleIn_ClearTransID()
	{
	}

	public bool IsBattle_CanRestore()
	{
		return false;
	}

	public void BattleIn_Restore()
	{
	}

	public void BattleIn_StartANewBattle()
	{
	}

	public int BattleIn_GetStage()
	{
		return 0;
	}

	public int BattleIn_GetSailingBagBattleId()
	{
		return 0;
	}

	public int BattleIn_GetSailingBagBattleType()
	{
		return 0;
	}

	public void BattleIn_CheckInit()
	{
	}

	public void BattleIn_Init(DeInitSourceType sourceType = DeInitSourceType.None)
	{
	}

	private void BattleIn_InitInternal()
	{
	}

	public void BattleIn_DeInit(DeInitSourceType sourceType = DeInitSourceType.None)
	{
	}

	public void BattleIn_SetHaveBattle(bool value)
	{
	}

	public void BattleIn_InGame(DeInitSourceType sourceType = DeInitSourceType.None)
	{
	}

	private bool BattleIn_GetDailyIdByTypeOld(GameMode mode, ref int dailyId)
	{
		return false;
	}

	public void BattleIn_UpdateLearnSkillByEnergy(int num)
	{
	}

	public void SavePlay128CurLevelId(int levelId)
	{
	}

	public int GetPlay128CurLevelId()
	{
		return 0;
	}

	public int BattleIn_GetLearnSkillNumByEnergy()
	{
		return 0;
	}

	public void BattleIn_UpdateUsedRandomSkill(bool used)
	{
	}

	public bool BattleIn_GetUsedRandomSkill()
	{
		return false;
	}

	public void BattleIn_UpdateGoldTurn()
	{
	}

	public void BattleIn_UpdateTowerSkillPoolUI()
	{
	}

	public void BattleIn_UpdateEventTowerSkillPoolUI()
	{
	}

	public void BattleIn_UpdateKillMonster(int count)
	{
	}

	public void BattleIn_UpdateHPDrop(int count)
	{
	}

	public void BattleIn_UpdateKillMonsterDict(Dictionary<int, int> dict)
	{
	}

	public void BattleIn_UpdateExp(float exp)
	{
	}

	public void BattleIn_UpdateUserExp(long exp)
	{
	}

	public void BattleIn_UpdateLevel(int level)
	{
	}

	public void BattleIn_UpdateGold(float gold)
	{
	}

	public void BattleIn_UpdateTotalAddedHpMax(float value)
	{
	}

	public void BattleIn_UpdateDiamond(long diamond)
	{
	}

	public void BattleIn_UpdateLargeDiamondItem(long value)
	{
	}

	public void BattleIn_UpdateNormalDiamondItem(long value)
	{
	}

	public void BattleIn_UpdateDragonBoxItem(long value)
	{
	}

	public void BattleIn_AddRebornSkill()
	{
	}

	public int BattleIn_GetRebornSkill()
	{
		return 0;
	}

	public void BattleIn_AddRebornUI()
	{
	}

	public int BattleIn_GetRebornUI()
	{
		return 0;
	}

	public void BattleIn_UpdateSkill(int skillid)
	{
	}

	public void BattleIn_Update()
	{
	}

	public void BattleIn_UpdateGood(int goodid)
	{
	}

	public void BattleIn_UpdateHP(long hp)
	{
	}

	public void BattleIn_UpdateEnergy(long energy)
	{
	}

	public void BattleIn_UpdateCharge(long charge)
	{
	}

	public void BattleIn_UpdateAnger(long anger)
	{
	}

	public void BattleIn_UpdateBoxingSuperSkillTime(float time)
	{
	}

	public void BattleIn_UpdateFlashSuperSkillTime(float time)
	{
	}

	public void BattleIn_UpdateMaxRoomID(int roomid)
	{
	}

	public void BattleIn_UpdateRoomID(int roomid)
	{
	}

	public void BattleIn_UpdateResourcesID(int id)
	{
	}

	public void BattleIn_UpdateTmxID(string tmxid)
	{
	}

	public void BattleIn_UpdateGameType(int _gameType)
	{
	}

	public int BattleIn_GetGameType()
	{
		return 0;
	}

	public void BattleIn_UpdateNextTmxID(string tmxid)
	{
	}

	public void BattleIn_ClearAllTmxCache()
	{
	}

	public void BattleIn_SetHeroDead(bool value)
	{
	}

	public bool BattleIn_IsHeroDead()
	{
		return false;
	}

	public void BattleIn_UpdateLevelUpSkills(int type, List<int> skills, int slotCnt = 3)
	{
	}

	public void BattleIn_SaveTowerId(int nTowerId)
	{
	}

	public int BattleIn_TowerId()
	{
		return 0;
	}

	public void BattleIn_UpdateTowerSkillPool(List<int> skills, int cnt)
	{
	}

	public void BattleIn_GetTowerSkillPool(out List<int> list, out int cnt)
	{
		list = null;
		cnt = default;
	}

	public void BattleIn_UpdateDailyGuildSkillPool(List<int> skills, int cnt)
	{
	}

	public void BattleIn_GetDalyGuildSkillPool(out List<int> list, out int cnt)
	{
		list = null;
		cnt = default;
	}

	public int BattleIn_GetLineInGuild()
	{
		return 0;
	}

	public void BattleIn_SaveLastLineInGuild()
	{
	}

	public void BattleIn_ChooseLineInGuild(int mode)
	{
	}

	public void BattleIn_RestoreLearnSkill(List<int> skillids)
	{
	}

	public void SaveTDLearnSkill(List<int> _list)
	{
	}

	public void BattleIn_UpdateLearnSkill(int skillid)
	{
	}

	public void BattleIn_UpdateFirstShop(List<bool> list)
	{
	}

	public void BattleIn_UpdatePotions(int id)
	{
	}

	public void BattleIn_UpdateDailyInfo(int dailyId, int dailyLevel, int dailyScore)
	{
	}

	public void BattleIn_AddDaily130Damage(long damageDelta)
	{
	}

	private static long AddDaily130DamageDeltaForTest(long currentDamage, long damageDelta)
	{
		return 0L;
	}

	public void BattleIn_UpdateEquip(EquipOne one)
	{
	}

	public void BattleIn_Update_Nohitted_setvalue(float value)
	{
	}

	public void BattleIn_Update_NohittedDict(string key, float value)
	{
	}

	public void BattleIn_Endless_skill_setvalue(float value)
	{
	}

	public float BattleIn_Endless_skill_getvalue()
	{
		return 0f;
	}

	public void BattleIn_Endless_hero_use(int heroid)
	{
	}

	public void BattleIn_UseFreshSkillCard()
	{
	}

	public bool BattleIn_IsUsedFreshSkillCard()
	{
		return false;
	}

	public void BattleIn_UseAFuReviveSkill()
	{
	}

	public bool BattleIn_IsUsedAFuReviveSkill()
	{
		return false;
	}

	public void BattleIn_KillMonster(bool isBoss)
	{
	}

	public (int, int) BattleIn_GetKilledMonsterCnt()
	{
		return default;
	}

	public List<int> BattleIn_Endless_hero_list_get()
	{
		return null;
	}

	public void BattleIn_Endless_magic_addcount()
	{
	}

	public int BattleIn_Endless_magic_getcount()
	{
		return 0;
	}

	public int BattleIn_GetCurrentUseHeroId()
	{
		return 0;
	}

	public void BattleIn_UpdateIn()
	{
	}

	public float BattleIn_Get_Nohitted_addvalue()
	{
		return 0f;
	}

	public float BattleIn_Get_Nohitted_addvalue(string key)
	{
		return 0f;
	}

	public bool BattleIn_GetGoldTurn()
	{
		return false;
	}

	public bool BattleIn_GetShowSkillPoolUI()
	{
		return false;
	}

	public bool BattleIn_GetEventTowerShowSkillPoolUI()
	{
		return false;
	}

	public long BattleIn_GetUserExp()
	{
		return 0L;
	}

	public float BattleIn_GetExp()
	{
		return 0f;
	}

	public void BattleIn_AddUsedTmx(string tmxid)
	{
	}

	public List<string> BattleIn_GetUsedTmx()
	{
		return null;
	}

	public void BattleIn_ClearUsedTmx()
	{
	}

	public int BattleIn_GetLevel()
	{
		return 0;
	}

	public float BattleIn_GetGold()
	{
		return 0f;
	}

	public int BattleIn_GetSoulPoint()
	{
		return 0;
	}

	public void BattleIn_UpdateSoulPoint(int value)
	{
	}

	public float BattleIn_GetTotalAddedHpMax()
	{
		return 0f;
	}

	public long BattleIn_GetDiamond()
	{
		return 0L;
	}

	public long BattleIn_GetLargeDiamondItem()
	{
		return 0L;
	}

	public long BattleIn_GetNormalDiamondItem()
	{
		return 0L;
	}

	public int BattleIn_GetKillMonster()
	{
		return 0;
	}

	public int BattleIn_GetHPDrop()
	{
		return 0;
	}

	public Dictionary<int, int> BattleIn_GetKillMonsterDict()
	{
		return null;
	}

	public long BattleIn_GetHP()
	{
		return 0L;
	}

	public long BattleIn_GetEnergy()
	{
		return 0L;
	}

	public long BattleIn_GetAnger()
	{
		return 0L;
	}

	public long BattleIn_GetCharge()
	{
		return 0L;
	}

	public int BattleIn_GetMaxRoomID()
	{
		return 0;
	}

	public int BattleIn_GetRoomID()
	{
		return 0;
	}

	public int BattleIn_GetResourcesID()
	{
		return 0;
	}

	public string BattleIn_GetTmxID()
	{
		return null;
	}

	public string BattleIn_GetNextTmxID()
	{
		return null;
	}

	public List<int> BattleIn_GetLevelUpSkills()
	{
		return null;
	}

	public int BattleIn_GetLevelUpType()
	{
		return 0;
	}

	public int BattleIn_GetSlotCnt()
	{
		return 0;
	}

	public List<bool> BattleIn_GetFirstShop()
	{
		return null;
	}

	public List<int> BattleIn_GetPotions()
	{
		return null;
	}

	public bool BattleIn_GetIn()
	{
		return false;
	}

	public void SetReviveSkill_Type401_UsedFlag()
	{
	}

	public bool GetReviveSkill_Type401_Used()
	{
		return false;
	}

	public void SetReviveSkill_PinkCat_UsedFlag()
	{
	}

	public bool GetReviveSkill_PinkCat_Used()
	{
		return false;
	}

	public void BattleIn_SetBabyAddAttackPercent(float value)
	{
	}

	public float BattleIn_GetBabyAddAttackPercent()
	{
		return 0f;
	}

	public int BattleIn_GetNoobSkillCount()
	{
		return 0;
	}

	public void BattleIn_SetNoobSkillCount(int count)
	{
	}

	public bool BattleIn_IsFirstPlay()
	{
		return false;
	}

	public void BattleIn_SetIsFirstPlay()
	{
	}

	public Dictionary<int, Dictionary<string, float>> BattleIn_GetSkillAddtions()
	{
		return null;
	}

	public void BattleIn_AddSkillAddtion(int effectId, string attrName, float value)
	{
	}

	public void BattleIn_AddMazeNpcTimes(int id)
	{
	}

	public Dictionary<int, int> BattleIn_GetAllMazeNpcTimes()
	{
		return null;
	}

	public void BattleIn_ChooseLineInMaze(int mode)
	{
	}

	public int BattleIn_GetLineInMaze()
	{
		return 0;
	}

	public void BattleIn_SaveLastLineInMaze()
	{
	}

	public int BattleIn_GetLastLineInMaze()
	{
		return 0;
	}

	public void BattleIn_AddEquipInMaze(EquipOne one)
	{
	}

	public BattleInBase.MazeEquip2[] BattleIn_GetEquipsInMaze()
	{
		return null;
	}

	public List<int> BattleIn_GetMazeEquipSkills()
	{
		return null;
	}

	public List<int> BattleIn_GetMazeEquipIds()
	{
		return null;
	}

	public void BattleIn_AddSkillRemoveSet(int skillId)
	{
	}

	public List<int> BattleIn_GetSkillReMoveSet()
	{
		return null;
	}

	public void BattleIn_UpdateMazeNpcId(int id)
	{
	}

	public void BattleIn_SetOperateType(int type)
	{
	}

	public int BattleIn_GetOperateType()
	{
		return 0;
	}

	public void BattleIn_UpdateValentineBabyId(int id)
	{
	}

	public int BattleIn_GetValentineBabyId()
	{
		return 0;
	}

	public void BattleIn_UpdateValentineBabyFlag()
	{
	}

	public bool BattleIn_GetValentineBabyFlag()
	{
		return false;
	}

	public void BattleIn_AddNpcSkill(int skillId)
	{
	}

	public List<int> BattleIn_GetNpcSkills()
	{
		return null;
	}

	public void BattleIn_UpdateValentineSkinId(int id)
	{
	}

	public int BattleIn_GetValentineSkinId()
	{
		return 0;
	}

	public uint[] BattleIn_GetMysticShopIds()
	{
		return null;
	}

	public void BattleIn_SaveMysticShopIds(uint[] ids)
	{
	}

	public bool BattleIn_CanShowMysticShop()
	{
		return false;
	}

	public void BattleIn_SetShowMysticShopFlag()
	{
	}

	public void BattleIn_SaveNpcs(List<int> ids)
	{
	}

	public void BattleIn_SetWingOfDemonSkill4Effect()
	{
	}

	public bool BattleIn_CanWingOfDemonSkill4Effect()
	{
		return false;
	}

	public int[] BattleIn_GetNpcs()
	{
		return null;
	}

	public List<string> BattleIn_GetNpcAttribute(int id)
	{
		return null;
	}

	public int BattleIn_GetNpcWeaponId(int id)
	{
		return 0;
	}

	public List<int> BattleIn_GetNpcSkills(int id)
	{
		return null;
	}

	public bool BattleIn_NpcCanLevelUp()
	{
		return false;
	}

	public void BattleIn_SaveNpcSlotSkills(int id, List<int> list)
	{
	}

	public List<int> BattleIn_GetNpcSlotSkills(int id)
	{
		return null;
	}

	public void BattleIn_SetNpcWeapon(int nNpcId, int nWeaponId)
	{
	}

	public void BattleIn_SetNpcSkill(int nNpcId, int nSkillId)
	{
	}

	public bool BattleIn_HasChooseNpc()
	{
		return false;
	}

	public void SaveBattleStatistic(int nMaxConsecutiveHits, int nKillMonsterNum, long lMaxHit, long lTotalHit, long lTotalRecoverLife, float fPassLevelTime)
	{
	}

	public void SaveTotalRecoverLife(long lTotalRecoverLife)
	{
	}

	public (int, int, long, long, long, float) GetBattleStatistic()
	{
		return default;
	}

	public float GetPassStageTime()
	{
		return 0f;
	}

	public void AddEndlessDrop(int roomId, int id, int cnt)
	{
	}

	public void ClearEndlessDropByRoomId(int roomId)
	{
	}

	public void ClearEndlessDrop()
	{
	}

	public List<BattleInBase.EndlessDrop> GetEndlessDropByRoomId(int roomId)
	{
		return null;
	}

	public void AddBabySkill(string key, int skillId)
	{
	}

	public List<int> GetBabySkill(string key)
	{
		return null;
	}

	public bool BattleIn_IsHasChooseRole()
	{
		return false;
	}

	public int BattleIn_GetRoleReversaId()
	{
		return 0;
	}

	public void BattleIn_SetRoleReversaId(int id)
	{
	}

	public void BattleIn_SetYuanzhijingSkillAddvalue(float value)
	{
	}

	public float BattleIn_GetYuanzhijingSkillAddvalue()
	{
		return 0f;
	}

	public float BattleIn_GetBloodLossTotal()
	{
		return 0f;
	}

	public int BattleIn_GetElkCount()
	{
		return 0;
	}

	public void BattleIn_SaveElkCount(int value)
	{
	}

	public (int, int) BattleIn_GetElkExchange()
	{
		return default;
	}

	public (int, int) BattleIn_GetElkExchange(int cnt)
	{
		return default;
	}

	public bool BattleIn_HasMeetSanta()
	{
		return false;
	}

	public void BattleIn_SetMeetSanta()
	{
	}

	public bool BattleIn_HasExchangeSantaGift()
	{
		return false;
	}

	public void BattleIn_SetExchangeSantaGift()
	{
	}

	public void SaveEquip1020508KillBossCnt(int value)
	{
	}

	public int GetEquip1020508KillBossCnt()
	{
		return 0;
	}

	public bool BattleIn_SetDropEquips(string json)
	{
		return false;
	}

	public List<int> BattleIn_GetAllDropEquipsByLayer(int layer)
	{
		return null;
	}

	public List<int> BattleIn_GetDropEquipIds(int levelId)
	{
		return null;
	}

	public bool BattleIn_CanDropEquip(int levelId)
	{
		return false;
	}

	public BattleInBase.ServerDropEquips BattleIn_DropEquipDataByTransId(uint transId)
	{
		return null;
	}

	public void BattleIn_SaveCritRateAddTotal(float value)
	{
	}

	public void BattleIn_AddDungeonRefreshCnt()
	{
	}

	public void BattleIn_AddDungeonBuffId(int id)
	{
	}

	public void KillMonsterInPveSeason(Dictionary<int, int> dic)
	{
	}

	public void UpdateHpFoodTotal(int value)
	{
	}

	public void UpdateRecordSkill(int skillIndex, int skillID)
	{
	}

	public void UpdateRecordSkillRecord(bool isRecord)
	{
	}

	public void BattleIn_UpdateHpFoodTotal2(int value)
	{
	}

	public void BattleIn_UpdateTotalAddByKillEnemy(float value)
	{
	}

	public void BattleIn_UpdateSkillAlone1657TotalAdded(long value)
	{
	}

	public void BattleIn_UpdateSkillAlone1664KillCnt(int value)
	{
	}

	public void BattleIn_UpdateSkillAlone1655Flag(bool value)
	{
	}

	public void BattleIn_UpdateSkillAlone1671RecoverHpTotal(long value)
	{
	}

	public void BattleIn_UpdateSkillAlone1675HpFoodCnt(int value)
	{
	}

	public void BattleIn_UpdateSkillAlone1675AngelCnt(int value)
	{
	}

	public void BattleIn_UpdateSuperSkillCDTime(float value)
	{
	}

	public void BattleIn_UpdateExtraSuperSkillCDTime(float value)
	{
	}

	public void BattleIn_UpdateWuKongSuperSkillCDTime(float value)
	{
	}

	public void UpdatePveSeasonTime()
	{
	}

	public void AddTreasuresSkill(int id)
	{
	}

	public void AddCullSkill(int id)
	{
	}

	public void BattleIn_UpdatePveSeasonSelectedHero(int id)
	{
	}

	public void BattleIn_UpdatePveSeasonWeekTopic(int id)
	{
	}

	public void BattleIn_UpdateChargeValue(int value)
	{
	}

	public void BattleIn_UpdateBulletCnt(int value)
	{
	}

	public void SetBigMapFlag(bool value)
	{
	}

	public void AddGain(int nGainId)
	{
	}

	public void GiveupPartner(int layer)
	{
	}

	public bool PartnerSelected(int id)
	{
		return false;
	}

	public List<int> GetGains()
	{
		return null;
	}

	public void AddPartner(int id, long hp, long energy)
	{
	}

	public void RemovePartner(int id)
	{
	}

	public bool PartnerIsDead(int id)
	{
		return false;
	}

	public void UpdatePartner(int id, long hp, long energy)
	{
	}

	public List<BattleInBase.PartnerSave> GetPartners()
	{
		return null;
	}

	public long GetPartnerHpById(int id)
	{
		return 0L;
	}

	public bool PartnerGoodsUsed(int layer)
	{
		return false;
	}

	public void BattleIn_UpdateAssistanterHpMax(long hp)
	{
	}

	public void Battle_UpdataAssistDatas(int nAssistanterId, float fAssistCdTime, float fAssistTime, int[] aryAssistanterSkills, int index)
	{
	}

	public void Battle_UpdateAssistCdTime(float time)
	{
	}

	public void Battle_UpdateAssistIndex(int index)
	{
	}

	public void BattleIn_UpdateTotalVampire(long value)
	{
	}

	public void BattleIn_UpdateTotalLoseHp(long value)
	{
	}

	public void BattleIn_UpdateTotalAbsorbHp(int value)
	{
	}

	public void BattleIn_UpdateShieldCount(int value)
	{
	}

	public void BattleIn_UpdateTotalIntegral(int nTotalIntegral)
	{
	}

	public void UpdateMulanRotateSwordCnt(int value)
	{
	}

	public void SetMulanDropHpUsed()
	{
	}

	public void BattleIn_UpdateRelics70001Cd(int time)
	{
	}

	public void BattleIn_UpdateTotalAddRatio(float value)
	{
	}

	public void BattleIn_UpdateTotalAddedAttackSpeedAndMoveSpeedPercent(float attackSpeedValue, float moveSpeedValue)
	{
	}

	public void BattleIn_UpdateUsedFreshSkillCardCount(int value)
	{
	}

	public void BattleIn_UpdateSkillAlone2075HpFoodCnt(int value)
	{
	}

	public void BattleIn_UpdateShouldShowAngelOfJudgment(bool value)
	{
	}

	public void BattleIn_UpdateAngelOfJudgment(bool value)
	{
	}

	public void BattleIn_UpdateShouldShowAngelOfLight(bool value)
	{
	}

	public void BattleIn_UpdateAngelOfLight(bool value)
	{
	}

	public void BattleIn_UpdateSkill2156UsedFlag(bool value)
	{
	}

	public void BattleIn_UpdateDemonKingShieldValue(long value)
	{
	}

	public void BattleIn_UpdateSkill2165Use(bool value)
	{
	}

	public void BattleIn_UpdateSkillAlone2191UsedFlag(bool value)
	{
	}

	public void BattleIn_UpdateWuKongDemonEnergy(int value)
	{
	}

	public void BattleIn_UpdateWuKongMonsterKilledCount(int value)
	{
	}

	public void BattleIn_UpdateStarSkillIdForHammer(int skillId)
	{
	}

	public void BattleIn_UpdateStartSkillIdForKatana(int skillId)
	{
	}

	public void BattleIn_UpdateGuGuFoeverBuffTims(int times)
	{
	}

	public int BattleIn_GetArtifactActivityArtifactStar(int id)
	{
		return 0;
	}

	public void BattleIn_AddArtifactActivitySkill(int id, int skillId)
	{
	}

	public List<int> BattleIn_GetArtifactActivitySkill(int id)
	{
		return null;
	}

	public Dictionary<int, List<int>> GetArtifactActivitySkills()
	{
		return null;
	}

	public int BattleIn_GetCalArtifactSkillUIShowTimes()
	{
		return 0;
	}

	public void BattleIn_AddCalArtifactSkillUIShowTimes()
	{
	}

	public void BattleIn_AddFengRenBoxCnt(int cnt)
	{
	}

	private void ParseAllNewBpConfig(Dictionary<ushort, string> mapStr)
	{
	}

	private void SetNewBpData(Dictionary<ushort, STActivityBattlePass> bpMap)
	{
	}

	public int GetTotalScoreByBpType(NewBpType bpType)
	{
		return 0;
	}

	public BattlePassNewData GetNewBpDataByType(NewBpType bpType)
	{
		return null;
	}

	public long GetLastTimeByBpType(NewBpType bpType)
	{
		return 0L;
	}

	public int GetExtraTotalCountByBpType(NewBpType bpType)
	{
		return 0;
	}

	public bool IsNewBpActiveByBpType(NewBpType bpType, int bpIndex)
	{
		return false;
	}

	public void RefreshBpDataByBpType(NewBpType bpType, STActivityBattlePass bpData)
	{
	}

	public string GetBpProductIDByBpType(NewBpType bpType, int bpIndex)
	{
		return null;
	}

	public int GetExtraCondByBpType(NewBpType bpType)
	{
		return 0;
	}

	public bool CheckNewBattlePassIsCanBuyByBpType(NewBpType bpType)
	{
		return false;
	}

	public bool IsOtherBattlePassSecondTipsByBpType(NewBpType bpType)
	{
		return false;
	}

	public List<Drop_DropModel.DropData> GetRewardListByBpTypeAndBpIndex(NewBpType bpType, int bpIndex)
	{
		return null;
	}

	public int GetBpHeroIDByBpType(NewBpType bpType)
	{
		return 0;
	}

	public string GetBpBoxIconByBpType(NewBpType bpType)
	{
		return null;
	}

	public void RefreshBpStatusByBpType(NewBpType bpType, int bpIndex)
	{
	}

	public bool IsHaveRedNodeByBpType(NewBpType bpType)
	{
		return false;
	}

	private bool IsExtraRewardAvailable(NewBpType bpType)
	{
		return false;
	}

	public bool IsOldMainBpHaveRed()
	{
		return false;
	}

	public bool IsAllHaveRed()
	{
		return false;
	}

	public int GetDiscountByBpType(NewBpType bpType)
	{
		return 0;
	}

	public bool IsAnyOtherBpOpen()
	{
		return false;
	}

	public List<NewBpPrivilegeItemData> GetPrivilegeDataByBpType(NewBpType bpType, int bpIndex)
	{
		return null;
	}

	public bool IsBpHavePrivilege(NewBpType bpType, int index)
	{
		return false;
	}

	public void ClearBattlePass()
	{
	}

	public void RequestBattlePassConfig()
	{
	}

	public void OnBattlePassConfigDataDownLoadOld()
	{
	}

	public void OnBattlePassReady(uint tag)
	{
	}

	public int GetBattlePassTag()
	{
		return 0;
	}

	public bool IsBattlePassSecondTips()
	{
		return false;
	}

	public bool CheckBattlePass()
	{
		return false;
	}

	public void ReqBattlePassInfo(Action callback = null)
	{
	}

	public List<BPBuyItemData> getBPBuyItemDataList()
	{
		return null;
	}

	public int GetBPBuyNeedTotal()
	{
		return 0;
	}

	public int GetBPBuyNeedDiscount()
	{
		return 0;
	}

	public void BPBuyAllSuccess()
	{
	}

	public void requestBPBuyAll(Action<CRespBattlepassReward, int> action = null)
	{
	}

	public bool canShowGuildGift(NewBpType type)
	{
		return false;
	}

	public bool IsHaveRewardCanGetAll()
	{
		return false;
	}

	private bool IsMainBpHaveRewardCanGet()
	{
		return false;
	}

	private bool IsOtherBpHaveRewardCanGet(NewBpType bpType)
	{
		return false;
	}

	public void requestBPRewardGetAll(Action<CRespBattlepassReward, int> action = null)
	{
	}

	private void sendGetAllAnalytics(CRespBattlepassReward data)
	{
	}

	private void showRewardWindow(STCommonData stcd)
	{
	}

	private void InitBoxDrop()
	{
	}

	public void DropCard_Init(int allcount)
	{
	}

	public Drop_DropModel.DropData GetDropCardRandom()
	{
		return null;
	}

	public void GetCardSucceed()
	{
	}

	private void initCampData()
	{
	}

	public void unInitCampData()
	{
	}

	public void FreshCampData()
	{
	}

	public void SetCampTalentData(CampTalent[] campTalent, int teamTalentPoint, int donateTeamPoint, int rewardID)
	{
	}

	public void SetCampPersonalTalentData(int id, int level)
	{
	}

	public void SetCampTeamTalentData(int teamTalentPoint)
	{
	}

	public bool Camp_IsOpen()
	{
		return false;
	}

	public void SetCampTownSkinData(int useSkinID, List<int> unlockSkinID)
	{
	}

	public void SetCampTownSkinUseData(int useSkinID)
	{
	}

	public void AddCampTownSkinUnlockData(int unlockSkinID)
	{
	}

	public void ClearCampTownSKinData()
	{
	}

	public void addCampTeamInviteTime(ulong usid)
	{
	}

	public bool isHaveCampTeamInvited(ulong usid)
	{
		return false;
	}

	public void checkCampTeamInviteTime()
	{
	}

	public void checkCampTeamLastDay()
	{
	}

	public bool isMaxCampTeamSendInvite()
	{
		return false;
	}

	public void addCampTeamInviteCount()
	{
	}

	private void InitCard()
	{
	}

	public void Card_Set(List<CEquipmentItem> cards)
	{
	}

	public void Card_Update(List<CEquipmentItem> cards)
	{
	}

	public CardOne AddCard(int cardid, int count)
	{
		return null;
	}

	public Dictionary<int, CardOne> GetCards()
	{
		return null;
	}

	public List<CardOne> GetCardsList()
	{
		return null;
	}

	public bool GetNoCard()
	{
		return false;
	}

	public bool GetCardMaxLevel(int id)
	{
		return false;
	}

	public int GetCardsCount()
	{
		return 0;
	}

	public List<CardOne> GetWearCards()
	{
		return null;
	}

	public CardOne GetCardByID(int id)
	{
		return null;
	}

	public bool Card_Have(int id)
	{
		return false;
	}

	public int Card_GetRandomGold()
	{
		return 0;
	}

	public int Card_GetNeedLevel()
	{
		return 0;
	}

	public int Card_GetLevel()
	{
		return 0;
	}

	public int Card_GetRandomCount()
	{
		return 0;
	}

	public bool Card_GetAllMax()
	{
		return false;
	}

	public CardOne Card_GetRandom()
	{
		return null;
	}

	public Drop_DropModel.DropData Card_GetRandomOnly()
	{
		return null;
	}

	public CardOne Card_ReceiveCard(Drop_DropModel.DropData drop)
	{
		return null;
	}

	public int Card_GetHarvestID()
	{
		return 0;
	}

	public int Card_GetHarvestLevel()
	{
		return 0;
	}

	public bool Card_GetHarvestAvailable()
	{
		return false;
	}

	public int Card_GetHarvestGold()
	{
		return 0;
	}

	public long Card_GetHarvestGold(int minutes, long cnt)
	{
		return 0L;
	}

	public int Card_GetHarvestExp()
	{
		return 0;
	}

	public AltarData GetAltarData()
	{
		return null;
	}

	private void InitChallenge()
	{
	}

	public int Challenge_GetID()
	{
		return 0;
	}

	public int Challenge_GetPassCount()
	{
		return 0;
	}

	public bool Challenge_IsFirstIn()
	{
		return false;
	}

	public void Challenge_SetFirstIn()
	{
	}

	public void ChallengeSucceed()
	{
	}

	public void InitCharacterData(List<CEquipmentItem> list, CHeroItem[] arryHeroStars)
	{
	}

	public void OnGetDailyIapReward(string product_id)
	{
	}

	public void OnGetWeekIapReward(string product_id)
	{
	}

	private void UpdateDailyActivity(CRespDailyIapReward info)
	{
	}

	private void UpdateWeekActivity(CRespWeekIapReward info)
	{
	}

	public void send_daily_activity()
	{
	}

	public void send_week_activity()
	{
	}

	public void send_month_activity()
	{
	}

	private void UpdateMonthActivity(CRespMonthIapReward info)
	{
	}

	public void OnGetMonthIapReward(string product_id)
	{
	}

	public (int, int, long, long)? GetRedEnvelopeId(string strProductId)
	{
		return null;
	}

	public (int, int, long, long)? GetAdRedEnvelopeId()
	{
		return null;
	}

	public long GetRedEnvelopeEndTime(uint id)
	{
		return 0L;
	}

	public bool IsDragonUnlocked()
	{
		return false;
	}

	public bool HaveDragon()
	{
		return false;
	}

	public bool HaveDragonGuide()
	{
		return false;
	}

	public bool HaveDragonBoxGuide()
	{
		return false;
	}

	public ulong[] getEquippedDragonRowIds()
	{
		return null;
	}

	public ulong[] CreateEmptyDragonRowIds()
	{
		return null;
	}

	private void ReqDragonDropRateUp()
	{
	}

	public bool DragonUpOpen()
	{
		return false;
	}

	private void OnDragonDropRateUpResponse(NetResponse response)
	{
	}

	private void InitEquips()
	{
	}

	public int Equip_GetCanWearCount()
	{
		return 0;
	}

	public int Equip_GetCanUpCount()
	{
		return 0;
	}

	public void Equip_Set(List<CEquipmentItem> equips)
	{
	}

	public void AddEquips(CEquipmentItem[] equips, bool addscroll)
	{
	}

	public EquipOne GetNewEquipByID(int equipid, int count)
	{
		return null;
	}

	public int Equip_GetNewCount()
	{
		return 0;
	}

	public bool GetHaveSameEquips(int id)
	{
		return false;
	}

	public EquipData GetEquips()
	{
		return null;
	}

	public EquipOne GetEquipByUniqueID(string uniqueid)
	{
		return null;
	}

	public EquipOne GetEquipByRowID(ulong rowid)
	{
		return null;
	}

	public EquipOne GetPropByID(int equipid)
	{
		return null;
	}

	public EquipOne GetPropShowByID(int equipid)
	{
		return null;
	}

	public EquipOne getNewEquipOne(int eid, int count, int custom = 0)
	{
		return null;
	}

	public EquipOne getNewEquipOne_Relics(int eid, int star, int level)
	{
		return null;
	}

	public void ReduceEquipCount(int eid, int count)
	{
	}

	public void EquipWear(EquipOne equip, int wearindex)
	{
	}

	public void EquipUnwear(string uniqueid)
	{
	}

	public void EquipLevelUp(EquipOne equip)
	{
	}

	public void EquipBreakDown(EquipOne equip, List<Drop_DropModel.DropData> dropData)
	{
	}

	public void UpdateEquip(int position, int uniqueid, EquipOne equip)
	{
	}

	public List<EquipOne> GetHaveEquips(bool havewear)
	{
		return null;
	}

	public List<EquipOne> GetWearEquips()
	{
		return null;
	}

	public List<EquipOne> GetProps(EquipType type, bool havewear = true)
	{
		return null;
	}

	public int GetAdventureCoinCnt()
	{
		return 0;
	}

	public bool IsHave401Or402Equip()
	{
		return false;
	}

	public uint Get401Or402EquipCnt()
	{
		return 0u;
	}

	public int Get401Or402EquipQualityMax()
	{
		return 0;
	}

	public bool IsHaveMagicBookEquip()
	{
		return false;
	}

	public uint GetMagicBookEquipCnt()
	{
		return 0u;
	}

	public int GetMagicBookQualityMax()
	{
		return 0;
	}

	public bool IsHave401Equip()
	{
		return false;
	}

	public bool IsHave402Equip()
	{
		return false;
	}

	public bool Get401Or402EquipGuide_mustdrop()
	{
		return false;
	}

	public bool GetMagicBookEquipGuide_mustdrop()
	{
		return false;
	}

	public bool GetEquipGuide_mustdrop()
	{
		return false;
	}

	private int Equip_GetPositionCount(int position)
	{
		return 0;
	}

	public void Equip_Remove(string uniqueid)
	{
	}

	public void Equip_Remove(ulong rowid)
	{
	}

	public bool Equip_GetCanWearIndex(EquipOne one, out int index)
	{
		index = default;
		return false;
	}

	public bool Equip_GetCanWear(EquipOne one, int index)
	{
		return false;
	}

	public bool Equip_GetIsEmpty(EquipOne one)
	{
		return false;
	}

	public bool Equip_is_same_wear(EquipOne one)
	{
		return false;
	}

	public List<int> Equip_GetCanWears(int position)
	{
		return null;
	}

	public int Equip_GetWeapon()
	{
		return 0;
	}

	public bool IsWeaponEquipped()
	{
		return false;
	}

	public int GetWeaponEquipId()
	{
		return 0;
	}

	public int GetBattleWeapon()
	{
		return 0;
	}

	public int Equip_GetCloth()
	{
		return 0;
	}

	public int Equip_GetClothEquipID()
	{
		return 0;
	}

	public int Equip_GetPet(int index)
	{
		return 0;
	}

	public List<EquipOne> GetWearEquip()
	{
		return null;
	}

	public void Equip_Attribute2(SelfAttributeData attribute)
	{
	}

	public void Equip_Attribute2_Internal(SelfAttributeData attribute, bool executeAdditionSkills)
	{
	}

	public List<EquipOne> GetAllDragonEquips(bool includeInstalled = true)
	{
		return null;
	}

	public List<EquipOne> GetDragonEquips()
	{
		return null;
	}

	public void Equip_Attribute2(SelfAttributeData attribute, int level)
	{
	}

	public void Equip_Attribute2_Internal(SelfAttributeData attribute, int level, bool executeAdditionSkills)
	{
	}

	public void Equip_Attribute2_Maze(SelfAttributeData attribute)
	{
	}

	public void Equip_GetUniqueidByEquipID(int equipid)
	{
	}

	public bool Equip_GetHaveEquips()
	{
		return false;
	}

	public List<int> Equip_GetSkills()
	{
		return null;
	}

	public List<int> Equip_GetSkillsForCampBattle()
	{
		return null;
	}

	public List<int> Equip_GetSkillsForDaily124()
	{
		return null;
	}

	public List<int> GetRefineSkills()
	{
		return null;
	}

	public List<int> GetRefineSkillsByEquipPos(int curPos)
	{
		return null;
	}

	public List<int> GetCarvingItemSkillsByEquipPos(int curPos)
	{
		return null;
	}

	public List<int> GetDragonEquipSkills()
	{
		return null;
	}

	public List<int> Equip_GetEquipIds()
	{
		return null;
	}

	public int Equip_GetEquipIdByPosition(int position)
	{
		return 0;
	}

	public List<int> Equip_GetSkillsWithoutBaby()
	{
		return null;
	}

	public List<int> Equip_GetSkillsWithoutBaby_Check()
	{
		return null;
	}

	public List<int> Equip_GetMazeSkills()
	{
		return null;
	}

	public bool Equip_GetRefresh()
	{
		return false;
	}

	public void Equip_SetRefresh()
	{
	}

	private void combine_cache_clear()
	{
	}

	public int Equip_can_combine_count()
	{
		return 0;
	}

	public bool Equip_can_combine(EquipOne one)
	{
		return false;
	}

	public bool CanBeSwallow(string target, string food)
	{
		return false;
	}

	public List<EquipOne> Equip_get_equip_babies()
	{
		return null;
	}

	public bool Equip_can_drop_equipexp(int id)
	{
		return false;
	}

	private void EquipAchieve_GetNewEquip(int pos, int quality)
	{
	}

	private string EquipAchieve_GetNewEquipString(int pos, int quality)
	{
		return null;
	}

	public int EquipAchieve_GetNewEquipLocal(int pos, int quality)
	{
		return 0;
	}

	public bool isNeedShowDesc(EquipOne eo)
	{
		return false;
	}

	public void showEquipDesc(EquipOne eo, int style = 1)
	{
	}

	public void QueryItems()
	{
	}

	public void hideEffectCast(Image BG)
	{
	}

	public void addEffectCast(int equipId, Image BG)
	{
	}

	public bool IsHaveWeapon(int weaponType)
	{
		return false;
	}

	public void ReqEventTowerInfo()
	{
	}

	public void SendEventTowerGameOver(bool isWin)
	{
	}

	public int GetTgaEquipCnt()
	{
		return 0;
	}

	public void requestCacheData()
	{
	}

	public void updateCacheData()
	{
	}

	public bool isShowEquipCastNewFlag()
	{
		return false;
	}

	public void setEquipCastNewFlag()
	{
	}

	public int getEquipCastEquipId()
	{
		return 0;
	}

	public int GetGamBlingCoin()
	{
		return 0;
	}

	public void AddGamBlingCoin(int pNum)
	{
	}

	public void checkGemsConfig()
	{
	}

	public void sendGemCombineSingle(int gemid, int location = -1, int pos = -1)
	{
	}

	public void sendGemCombineBatch(int[] gems)
	{
	}

	public int getGemWearTotalLevel(int location)
	{
		return 0;
	}

	public bool haveGems()
	{
		return false;
	}

	public List<EquipOne> GetGemsByType(int type, bool calcuteWear)
	{
		return null;
	}

	public void GetGemsByType(bool calcuteWear, ref List<EquipOne> a, ref List<EquipOne> b, ref List<EquipOne> c)
	{
	}

	public bool isShowGemEntrance(int location)
	{
		return false;
	}

	public bool IsShowGemSystem()
	{
		return false;
	}

	public bool isOpenGemSystem()
	{
		return false;
	}

	public bool isOpenGemBox()
	{
		return false;
	}

	public bool isGemUnlock(int location)
	{
		return false;
	}

	public int getGemCount(int location)
	{
		return 0;
	}

	public int GetGemCount()
	{
		return 0;
	}

	public int getGemEmptyLocation(int location)
	{
		return 0;
	}

	public void updateGemLocation(int location, int pos, int gemid)
	{
	}

	public string parseAttribute(string effect)
	{
		return null;
	}

	public int getGemWearCount(int eid)
	{
		return 0;
	}

	public Dictionary<int, int> getWearPosDict(int location)
	{
		return null;
	}

	public List<string> Gem_GetAddition_VIP(int equipid, SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public List<string> Gem_GetAddition_VIPByGemType(int equipid, SelfAttributeData selfAttributeData, EquipGemType eType)
	{
		return null;
	}

	public List<string> getGemBasicAttrList(int location, SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public List<string> getGemBasicAttrListByGemType(int location, SelfAttributeData selfAttributeData, EquipGemType eType)
	{
		return null;
	}

	public List<GemLevelAttr> getGemLevelAttrs(int location, SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public List<string> getGemAdditionAttrList(int location, SelfAttributeData selfAttributeData, float times = 1f, int deltaLevel = 0)
	{
		return null;
	}

	public int getGemTotalLevelToQuality(int level)
	{
		return 0;
	}

	public List<string> combineAttributeToString(List<string> preList)
	{
		return null;
	}

	public List<string> getGemForBattleAttr(SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public List<string> getGemForBattleAttrByGemType(SelfAttributeData selfAttributeData, EquipGemType eType)
	{
		return null;
	}

	public List<int> getGemForBattleSkill(SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public int isAttrType(string effect)
	{
		return 0;
	}

	public int getGemMaxLevel()
	{
		return 0;
	}

	public List<int> getGemCombineGemId(int gemid)
	{
		return null;
	}

	public Dictionary<int, int> getGemCombineGIdCount(int gemid)
	{
		return null;
	}

	public bool canGemPutLocation(int gemid, int location)
	{
		return false;
	}

	public bool isGemNeedGuider()
	{
		return false;
	}

	public void setPopGemUnlock()
	{
	}

	public bool getHavePopGemUnlock()
	{
		return false;
	}

	public int getGemQualityFromLevel(int level)
	{
		return 0;
	}

	public Drop_DropModel.DropData getGemOneDropData(int dropid)
	{
		return null;
	}

	public void clearGemDropActValue()
	{
	}

	public Dictionary<int, int> GetGemsLevelCount()
	{
		return null;
	}

	public int GetGemsTotalCount()
	{
		return 0;
	}

	public bool haveGemRedPointOrNot()
	{
		return false;
	}

	public bool canCombine(int gemid, GemClickSource source)
	{
		return false;
	}

	public bool haveCanCombineInBag()
	{
		return false;
	}

	public List<string> GetGemEffects_PVE(float times, SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public List<int> getGemSkills_PVE(float times, SelfAttributeData selfAttributeData)
	{
		return null;
	}

	public bool Gem_isJoinGemDrop(int gemid)
	{
		return false;
	}

	public List<int> GetGemEquipIdsByLocation(int location)
	{
		return null;
	}

	public List<int> GetGemEquipIdsByType(int gemType)
	{
		return null;
	}

	private void SendGuidDataToServer()
	{
	}

	private void GetGuidDataFromServer(Action callback)
	{
	}

	private void UpdateGuidFromJson(string pJson)
	{
	}

	public void OnLoginUpdateGuidData(Action callBack)
	{
	}

	public static bool CanUpLoadGuid()
	{
		return false;
	}

	public static void OnApplicationFocus(bool focusStatus)
	{
	}

	private void initGuildData()
	{
	}

	public void unInitGuildData()
	{
	}

	public void FreshGuildData()
	{
	}

	private void initChatDataList()
	{
	}

	public bool isUnlockGuildHelpEgg()
	{
		return false;
	}

	public bool isUnlockGuildReqProp()
	{
		return false;
	}

	public string getGuildGradeName(int grade)
	{
		return null;
	}

	public bool isGuildMe(string suid)
	{
		return false;
	}

	public string getGuildMsgTime(long time)
	{
		return null;
	}

	public bool isGuildActionValidTime(long time)
	{
		return false;
	}

	public bool getGuildMemberBasicInfo(string userid, ref string name, ref int headId, ref int headBoxId)
	{
		return false;
	}

	public GuildMemberInfo getGuildMemberInfoOne(string userid)
	{
		return null;
	}

	public List<GuildMemberInfo> GetGuildMemberInfoList()
	{
		return null;
	}

	public bool isInGuild(string userid)
	{
		return false;
	}

	public bool isHaveHelpEggInGuild(ulong rowid)
	{
		return false;
	}

	public int getGuildGiftID(int gift)
	{
		return 0;
	}

	public void saveGuildEggHelpInfo(ulong rowid)
	{
	}

	public int GetCanAddGuildScore(int add)
	{
		return 0;
	}

	public void addGuildScore(int add)
	{
	}

	public void addGuildGiveCount(int add)
	{
	}

	public int getGuildMaxWish()
	{
		return 0;
	}

	public int getGuildIconRedPoint()
	{
		return 0;
	}

	public void setGuildIconRedPoint()
	{
	}

	public void changeGuildGiftRed(int add)
	{
	}

	public void requestGuildGift()
	{
	}

	public void requestGuildHelpEgg()
	{
	}

	public void FreshAllItemForGuild(Action action = null)
	{
	}

	public int getGuildMemberHead(string heads)
	{
		return 0;
	}

	public int getGuildMemberHeadBox(string desc)
	{
		return 0;
	}

	public int getGuildMemberManorVersion(string desc)
	{
		return 0;
	}

	public int Guild_GetMemberVIPLevel(string desc)
	{
		return 0;
	}

	public GuildMemberHeadInfo Guild_GuildMemberInfo(string userid)
	{
		return null;
	}

	public GuildMemberHeadInfo Guild_GuildMemberInfo_String(string userdesc)
	{
		return null;
	}

	public void isRePullChatHistory()
	{
	}

	public void telnetGuildOK()
	{
	}

	public void CacheQuestInfo()
	{
	}

	public void CanulQuestCount()
	{
	}

	private void handleJoinGuild(ActionData action)
	{
	}

	private void handleKickGuild(ActionData action)
	{
	}

	private GuildMessageEntity GetUpdateMsgEntity(ulong seqId)
	{
		return null;
	}

	public void handleChatUpdateMsg(GuildMessageEntity pMsg)
	{
	}

	private void UpdateMsgEntity(int index, GuildMessageEntity pMsg)
	{
	}

	public void handleGuildAddMsg(GuildMessageEntity pMsg)
	{
	}

	public ChatMsgDataBase addChatMsgLocal(GuildMessageEntity pMsg, int chatid)
	{
		return null;
	}

	public void freshChatMsgLocal(int chatid)
	{
	}

	public void handleGuildPushEvent(List<UpdateActionItem> items)
	{
	}

	private void handleGuildPushEvent(string fromid, ActionData action)
	{
	}

	public void showGuildGiveEquips(List<string> list)
	{
	}

	public void requestGuildEquipOffline()
	{
	}

	private int getActionIndex(string actionid)
	{
		return 0;
	}

	public int getIndexByMsgId(string msgid)
	{
		return 0;
	}

	public int getChatMsgIndexByChatId(int chatid)
	{
		return 0;
	}

	public int getIndexByMsgSeq(ulong seq)
	{
		return 0;
	}

	private void showInTimeGiveEquips()
	{
	}

	public void sendGuildCombineMessage()
	{
	}

	public bool Guild_CanSendCombineInfo(int equipid)
	{
		return false;
	}

	public void setGuildTwoPlayerData(string roomid, long time)
	{
	}

	public int getGuildHelpNeedTimes(ChatMsgDataHelp data)
	{
		return 0;
	}

	public bool isGuildHelpHaveFinish(ChatMsgDataHelp data)
	{
		return false;
	}

	public Dictionary<string, ChatMsgDataHelp> getGuildHatchCanJoin()
	{
		return null;
	}

	public void finishGuildHatchOne(ChatMsgDataHelp data)
	{
	}

	public void deleteHatchWhenJoin()
	{
	}

	public void reSendChat(ChatMsgDataChat data)
	{
	}

	public void sendChat(string content)
	{
	}

	public int GetGuildRankValue(int type, GuildRankItemUIData data)
	{
		return 0;
	}

	public string GetGuildRankIcon(int type, GuildRankItemUIData data)
	{
		return null;
	}

	public void pullRankData(int type, Action action = null)
	{
	}

	public void openGuildRank()
	{
	}

	public void switchGuildRankTab(int type)
	{
	}

	public int Guild_GetMaxGiveCount()
	{
		return 0;
	}

	public int Guild_GetGuildLevel(long exp)
	{
		return 0;
	}

	public void Guild_GetGuildIcon(string jsons, ref int b, ref int t)
	{
	}

	public static void ConvertImChatMsgStatus(IMMessageStatus messageState, ChatMsgDataChat cmdc)
	{
	}

	public void setGuildOpenNewTime(long time)
	{
	}

	public bool Guild_isNeedShowGuildNote()
	{
		return false;
	}

	public void requestGuildSuggestList()
	{
	}

	public void getGuildScoreParams(out int min, out float ratio)
	{
		min = default;
		ratio = default;
	}

	public int getGuildItemScore(int score, int gid)
	{
		return 0;
	}

	public int getGuildPeopleScore(int p1, int p2)
	{
		return 0;
	}

	public int getGuildTotalScore(GuildListData.GuildListItem item)
	{
		return 0;
	}

	private void InitHarvest()
	{
	}

	public void ReqNormalHarvest(bool force = false)
	{
	}

	public void ReqShortHarvest(bool force = false, Action callback = null)
	{
	}

	public void RequestHarvest(HarvestType type, Action<CRespGameHarvest2> callback)
	{
	}

	public void RequestUpgrade(Action<int> success, Action failure)
	{
	}

	public bool CheckHarvest()
	{
		return false;
	}

	public bool IsNeedPullShortHarvest()
	{
		return false;
	}

	public bool CheckShortHarvest()
	{
		return false;
	}

	public void GetHarvestRewards(Action<int, int, int, List<Drop_DropModel.DropData>> callback, bool normal = true, bool ad = false)
	{
	}

	public List<HarvestShortButtonData> Harvest_GetShortButtonList()
	{
		return null;
	}

	public int Harvest_Key2DiamondIndex()
	{
		return 0;
	}

	public bool Harvest_ShortAdCanReward()
	{
		return false;
	}

	public bool Harvest_ShortKeyDiamondCanReward()
	{
		return false;
	}

	private void RefreshRate(GameHarvestExtend rate)
	{
	}

	public List<Drop_DropModel.DropData> GetHarvestRewardByLevel(int level)
	{
		return null;
	}

	public bool CanHarvestLevelUpgrade()
	{
		return false;
	}

	public bool CanHarvestLevelUpgrade(int curSelectLevel, bool isCurBtn)
	{
		return false;
	}

	public bool Harvest_ShortKeyDiamondCanReward_RedPoint()
	{
		return false;
	}

	public List<int> GetCurSkinSkill()
	{
		return null;
	}

	public List<int> GetHeroSkinSkill(int id)
	{
		return null;
	}

	public void SaveHeroSkins(CHeroSkin[] skins)
	{
	}

	public void UnlockHeroSkin(CHeroSkin[] skins)
	{
	}

	public void UnlockHeroSkin(CHeroSkin skin)
	{
	}

	public bool IsSkinUnlock(int id)
	{
		return false;
	}

	public void SendHeroSkinRequest()
	{
	}

	public int GetCurCharacterSkinId()
	{
		return 0;
	}

	public int GetCurCharacterId()
	{
		return 0;
	}

	public int GetCurCharacterIdBySkinId(int pSkinId)
	{
		return 0;
	}

	public void SetCharacterSkinId(int heroId, int skinId)
	{
	}

	public void SetCharacterSkinIdByServer(int heroId, int skinId)
	{
	}

	public bool IsSelectedSkin(int heroId, int skinId)
	{
		return false;
	}

	public int GetSelectedSkinIndex(int heroId)
	{
		return 0;
	}

	public int GetHeroSkin(int heroId)
	{
		return 0;
	}

	public List<Goods_goods.GoodData> GetSkinAttribute()
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetSkinSelfAttribute(int heroID)
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetUseSkinAttribute(int heroID)
	{
		return null;
	}

	public int GetHeroCharacterId(int heroId)
	{
		return 0;
	}

	public int getHeroSkinCollection()
	{
		return 0;
	}

	public bool IsExpired(int id)
	{
		return false;
	}

	public long GetExpiredTime(int id)
	{
		return 0L;
	}

	public List<int> GetSkinSkill(int id)
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetSkinAttributes(int skinId, int level)
	{
		return null;
	}

	public bool IsHeroSkinCollectPropFly(int propID)
	{
		return false;
	}

	public bool IsHeroSkinCollectRewardConfigured(int skinID)
	{
		return false;
	}

	public bool IsHeroSkinCollectRewardCanGet(int skinID)
	{
		return false;
	}

	public int GetHeroSkinCollectRewardCount(int heroID)
	{
		return 0;
	}

	public bool IsHeroSkinCollectLevelRewardCanGet()
	{
		return false;
	}

	public void ReqHeroSkinCollectReward(int skinID, Action<bool, List<Drop_DropModel.DropData>> callback)
	{
	}

	public void ReqAllHeroSkinCollectReward(int heroID, Action<bool, List<Drop_DropModel.DropData>> callback)
	{
	}

	public void ReqHeroSkinCollectLevelReward(Action<bool, List<Drop_DropModel.DropData>> callback)
	{
	}

	private void ReqHeroSkinCollectReward(ushort type, int targetID, Action<bool, List<Drop_DropModel.DropData>> callback)
	{
	}

	public List<HeroSkinCollectRewardData> GetHeroSkinCollectRewardData()
	{
		return null;
	}

	public int GetHeroSkinCollectLV()
	{
		return 0;
	}

	public bool IsMaxHeroSkinCollectLevel()
	{
		return false;
	}

	public (int, int) GetHeroSkinCollectExp()
	{
		return default;
	}

	public (int, int) GetAtkAndHpValueByHeroSkinCollect()
	{
		return default;
	}

	public List<Goods_goods.GoodData> GetHeroSkinCollectAttList()
	{
		return null;
	}

	public void InitHomePageData()
	{
	}

	public void InitCargoShip()
	{
	}

	public long GetPayShipExileTime()
	{
		return 0L;
	}

	public long GetPayShipExileStartTime()
	{
		return 0L;
	}

	private void InitMail()
	{
	}

	public bool IsMainActivityValid()
	{
		return false;
	}

	public void UpdateMainActivityData(MainActivityDataOne[] data)
	{
	}

	public void UpdateMainActivityData(string data)
	{
	}

	public void MainActivityBought(int productid)
	{
	}

	public int GetMainActivityProductId(string product)
	{
		return 0;
	}

	public List<MainActivityDataOne> GetMainActivityList()
	{
		return null;
	}

	private void initManorLocalData()
	{
	}

	public void unInitManorLocalData()
	{
	}

	public void FreshManorLocalData()
	{
	}

	public void OnMazeConfigDownload()
	{
	}

	public void OnMazeLineDownload()
	{
	}

	private void ParseMazeLine()
	{
	}

	private void ParseMazeConfig()
	{
	}

	public void InitMazeConfig()
	{
	}

	public string[] GetLines(int roomId)
	{
		return null;
	}

	public void InitMeadowBattle()
	{
	}

	private void DeInitMeadowBattle()
	{
	}

	private LocalSaveMedal initMedalData()
	{
		return null;
	}

	public void ReqMedalMessage()
	{
	}

	public void AddMedalAttributes(EntityHero hero)
	{
	}

	public List<string> GetMedalAttributes()
	{
		return null;
	}

	public void SetMedalRate(int medalId, int curRate)
	{
	}

	public void AddMedalRate(int medalId, int addRate)
	{
	}

	public int GetMedalMaxRate(int medalId)
	{
		return 0;
	}

	public bool MedalIsComplete(int medalId)
	{
		return false;
	}

	public int GetMedalCurRate(int medalId)
	{
		return 0;
	}

	public void SetMedal2ShowIndex(int medalId, int index, Action<bool> callBack)
	{
	}

	public int[] GetShowMedals()
	{
		return null;
	}

	public bool GetMedalIsNew(int medalId)
	{
		return false;
	}

	public void SetNewMedalToOld(int medalId)
	{
	}

	public bool GetHaveNewMedal()
	{
		return false;
	}

	public int GetHaveMedalCount()
	{
		return 0;
	}

	public string GetShowMedalByIndex(int index)
	{
		return null;
	}

	public string Medal_GetDesc(int mid)
	{
		return null;
	}

	public GameObject GetMedalAniItem(string key)
	{
		return null;
	}

	public int Monster_GetHatchTimeAddTotal()
	{
		return 0;
	}

	private void initEMData()
	{
	}

	public void unInitEMData()
	{
	}

	public void RefreshEMData()
	{
	}

	public void requestEggMonster(int operation, int type, ulong rowid, string battles, int location, bool showMask = true, Action action = null)
	{
	}

	public int getEggState(int eggid)
	{
		return 0;
	}

	public EggData getEggDataNoHatching(int eggid)
	{
		return null;
	}

	public EggData getEggData(ulong rowid)
	{
		return null;
	}

	public void RemoveEggData(ulong rowid)
	{
	}

	public MonsterData getMonsterData(int monsterid)
	{
		return null;
	}

	public MonsterData getMonsterDataByRowId(ulong rowid)
	{
		return null;
	}

	public int getEmptyHatchLocation()
	{
		return 0;
	}

	public int getEmptyBattleLocation()
	{
		return 0;
	}

	public MonsterData getBattleMonsterData(int pos)
	{
		return null;
	}

	public int isHacthIn(ulong rowid)
	{
		return 0;
	}

	public int isBattleIn(int mid)
	{
		return 0;
	}

	public string formatBattleStr(int pos, int monster)
	{
		return null;
	}

	private void parseBattleInfo(string bs)
	{
	}

	public Equip_Monster GetEquipMonster(int equipid)
	{
		return null;
	}

	public bool isEggHatching(int eggid)
	{
		return false;
	}

	public bool isMonsterInFarm(int monsterid)
	{
		return false;
	}

	public int getHatchingEggNum()
	{
		return 0;
	}

	public bool haveHatchFinish()
	{
		return false;
	}

	public int getEggTypeCount(int type)
	{
		return 0;
	}

	public int getMonsterTypeCount(int type)
	{
		return 0;
	}

	public bool showEntrance()
	{
		return false;
	}

	public int getStarNeedMonster(int mid, int star)
	{
		return 0;
	}

	public int getStarNeedCoin(int mid, int star)
	{
		return 0;
	}

	public List<string> getStarAttr(int mid, int star)
	{
		return null;
	}

	public List<string> getStarAssistForUI(int mid, int star)
	{
		return null;
	}

	public List<string> getStarAssistAttr(int mid)
	{
		return null;
	}

	public List<StarUPAttrData> getStarUPShowList(int mid, int currentStar)
	{
		return null;
	}

	public int getStarUPToStar(int mid, int index)
	{
		return 0;
	}

	public int getAttrSection(int monsterid)
	{
		return 0;
	}

	public int getEggCountNoHatching(int eggid)
	{
		return 0;
	}

	public int getHatchPositionPrice(int location)
	{
		return 0;
	}

	public int getBattlePositionPrice(int location)
	{
		return 0;
	}

	public Dictionary<int, List<string>> GetUnlockedEggAttrs()
	{
		return null;
	}

	private void putAttrToList(string attr, List<string> common, List<string> special, bool repeat)
	{
	}

	private void initEggDropPR()
	{
	}

	private void initMonsterKillChapter()
	{
	}

	public int isDropEgg(int charid)
	{
		return 0;
	}

	public void killMonsterOne(int charid)
	{
	}

	public void battleNewOrNext(bool newer)
	{
	}

	public void enterBattle()
	{
	}

	public string killMonsterToJson()
	{
		return null;
	}

	public string chapterToJson()
	{
		return null;
	}

	public GameObject LoadMonster3DForUI(int monsterid, GameObject parent, Vector3 v3)
	{
		return null;
	}

	public bool isNeedRequestAll()
	{
		return false;
	}

	public void AddEggs(CMonsterEgg[] eggs)
	{
	}

	public int GetEMTotalCount()
	{
		return 0;
	}

	public void killMonsterForGuild(int charid)
	{
	}

	public string killMonsterToJsonForGuild()
	{
		return null;
	}

	public string TCA_TimeCardBegin()
	{
		return null;
	}

	public void TCArchive_ResetData()
	{
	}

	public List<int> GetMonsterTimeCard()
	{
		return null;
	}

	public bool timeCardNeedOnlyOne(EggData data, EquipOne one)
	{
		return false;
	}

	public void calcuteTimeCardAdd(EggData data, EquipOne one, int count = 1)
	{
	}

	public void requestTimeCardUsed(ulong rowid, int equipid, int count)
	{
	}

	public int GetMonsterTotalStar(int mid)
	{
		return 0;
	}

	public int GetMonsterIndex(int mid, int star)
	{
		return 0;
	}

	public void GetMonsterIndex_Level(int mid, int star, ref int index, ref int level)
	{
	}

	public bool StarHaveArriveMax(int mid)
	{
		return false;
	}

	public bool canMonsterStarUp(int mid)
	{
		return false;
	}

	public List<MonSkillData> GetMonSkillList(int mid, int star)
	{
		return null;
	}

	public List<int> GetMonsterSkillForBattle()
	{
		return null;
	}

	public int GetFarmLevel()
	{
		return 0;
	}

	public int GetMonsterMaxHighQuality()
	{
		return 0;
	}

	public bool Farm_FiveIsOpen()
	{
		return false;
	}

	public int Farm_FiveNeedVIPLevel()
	{
		return 0;
	}

	public int Farm_FiveNeedDiamond()
	{
		return 0;
	}

	private ushort GetPlatform()
	{
		return 0;
	}

	public void ClearMonthlyCard()
	{
	}

	public void MonthlyCard_RequestConf(bool pop = false)
	{
	}

	public void MonthlyCard_ReceiveRewards(Action onSuccess = null, bool premium = false)
	{
	}

	private void MonthlyCard_OnResponse(NetResponse response, RequestType type, bool pop = false, Action onSuccess = null)
	{
	}

	public void MonthlyCard_SetExpireTime(long expireTime, bool premium = false)
	{
	}

	public void InitPlayer()
	{
	}

	public void requestNameAndHead(int type, string name, int head, int box)
	{
	}

	public int getHeadId(int headId)
	{
		return 0;
	}

	public int getHeadFrameId(int headFrameId, long time = 0L)
	{
		return 0;
	}

	public string Player_GetNickName(string name, string userid)
	{
		return null;
	}

	public string getNickName(string name, ulong uid)
	{
		return null;
	}

	public void NameLimitLength(ref int min, ref int max)
	{
	}

	public void addHead_HeadFrame(STHeadItem[] items)
	{
	}

	public void addHead(int headId)
	{
	}

	public void addHeadFrame(int headFrameId, long time)
	{
	}

	public long headFrameDefaultTime(int headFrameId)
	{
		return 0L;
	}

	public void checkMyHeadFrameOutdate()
	{
	}

	public bool haveUnlockHeadFrame(int hfid)
	{
		return false;
	}

	public bool isHaveHeadRedPoint()
	{
		return false;
	}

	public bool isHaveHeadFrameRedPoint()
	{
		return false;
	}

	public bool isNeedHeadRedPoint()
	{
		return false;
	}

	public bool isOpenHeadAndFrame()
	{
		return false;
	}

	public bool haveUnlockEmoji(int hfid)
	{
		return false;
	}

	public bool isOpenEmoji()
	{
		return false;
	}

	public bool isHaveEmojiRedPoint()
	{
		return false;
	}

	public List<string> GetAllHeadAtt()
	{
		return null;
	}

	public List<string> GetAllHeadFrameAtt()
	{
		return null;
	}

	public List<int> AddHeadSkillAtt()
	{
		return null;
	}

	public List<int> AddHeadFrameSkillAtt()
	{
		return null;
	}

	public void checkHeadFrameForCond2()
	{
	}

	public void checkPlayerBasicInfo(ref int head, ref int headBox, ref string name, ulong time, ulong uid)
	{
	}

	public void requestCashGift(int type, int gid, Action callback = null)
	{
	}

	public bool checkHaveGetReward_Cash(int id)
	{
		return false;
	}

	public bool checkHaveGetRewardExtra_Cash(int id)
	{
		return false;
	}

	public bool checkHaveGet_CashGift(long flag, int index)
	{
		return false;
	}

	public List<CashGiftItemData> GetCashGiftData()
	{
		return null;
	}

	public CashGiftItemData GetCashGiftDataExtra()
	{
		return null;
	}

	public List<CashTaskItemData> GetCashTaskData()
	{
		return null;
	}

	public bool isOpen_CashGift()
	{
		return false;
	}

	public bool isTaskEnd_CashGift()
	{
		return false;
	}

	public void GetUnitPrice_CashGift(ref string flag, ref float value, ref bool prefix)
	{
	}

	public int CashScoreToPrice(float param, float unit, bool up)
	{
		return 0;
	}

	public bool isHaveCanReward_CashGift()
	{
		return false;
	}

	public bool isHaveCanReward_CashTask()
	{
		return false;
	}

	public List<int> GetCurrentTaskReward_Cash()
	{
		return null;
	}

	public void requestGameVIP(int type, int gid, Action callback = null)
	{
	}

	public void VIP_OpenUI()
	{
	}

	public int VIP_GetFlagScore(string key)
	{
		return 0;
	}

	public bool VIP_CheckLevelReward(int index)
	{
		return false;
	}

	public bool VIP_IsShowRed()
	{
		return false;
	}

	public void VIP_SetPurchaseValue(CRespInAppPurchase data)
	{
	}

	public void VIP_SetNewValue(int lv, int score, bool ani = false)
	{
	}

	public void VIP_CheckLevelChanged(int pre, int next)
	{
	}

	public void VIP_PullData()
	{
	}

	public List<List<int>> VIP_GetBuyItems()
	{
		return null;
	}

	public int VIP_GetMaxRightLevel()
	{
		return 0;
	}

	public List<int> VIP_GetRightLv(int level)
	{
		return null;
	}

	public List<int> VIP_GetRights(int level)
	{
		return null;
	}

	public List<VIPItemData> VIP_GetVIPItemDatas(int level)
	{
		return null;
	}

	private void VIP_SortList(List<VIPItemData> list)
	{
	}

	public int VIP_GetLevelByGiftId(string giftId)
	{
		return 0;
	}

	public string VIP_GetEffect(int abid, int lv)
	{
		return null;
	}

	public List<string> VIP_GetEffectsForBattle()
	{
		return null;
	}

	public bool VIP_IsHaveRightOne(int lv, int abid)
	{
		return false;
	}

	public bool VIP_IsHaveRightOneCurrent(int abid)
	{
		return false;
	}

	public int VIP_AbilityValue(int abid, int lv)
	{
		return 0;
	}

	public int VIP_AbilityValueCurrent(int abid)
	{
		return 0;
	}

	public int VIP_GetGemAbilityID(int pos)
	{
		return 0;
	}

	public int VIP_GetRewardsID(int level, int position)
	{
		return 0;
	}

	public PlayerBasicInfo GetPlayerBasicInfo(ulong userid)
	{
		return null;
	}

	public void requestPlayerBasicInfo(HashSet<ulong> hset, Action<bool> action = null)
	{
	}

	public void requestStageMode(int mode, Action<CRespEquipWear, int> action = null)
	{
	}

	private void initPropData()
	{
	}

	public void unInitPropData()
	{
	}

	public void FreshPropData()
	{
	}

	public void setCurrencyCount(CurrencyType type, int count)
	{
	}

	public int getCurrencyCount(CurrencyType type)
	{
		return 0;
	}

	public void freshMyStealCount(int count)
	{
	}

	public void resetManorStealBeginTime(int preMax)
	{
	}

	public Sprite GetPropIcon(PropType type, int id)
	{
		return null;
	}

	public long GetPropCount(PropType type, int id)
	{
		return 0L;
	}

	private void initPVEData()
	{
	}

	public void unInitPVEData()
	{
	}

	public void FreshPVEData()
	{
	}

	public void RequestSeasonData()
	{
	}

	public void ForceRequestPveData(Action<bool, int> callback)
	{
	}

	public void OpenNextPveSeason()
	{
	}

	public PVEStage_stagechapter GetPveSeasonStageChapter(int id)
	{
		return null;
	}

	public bool isSeasonOver_PVE()
	{
		return false;
	}

	public bool isSeasonShopOver_PVE()
	{
		return false;
	}

	public void showNetStatus(int status)
	{
	}

	public int GetNeedMinVer_PVE(int season)
	{
		return 0;
	}

	public void ModifyLife(int value)
	{
	}

	public void ModifySoulPoint(int value)
	{
	}

	public void ModifySoulCrystal(int value)
	{
	}

	public void ModifySuperSoulCrystal(int value)
	{
	}

	public void UpdateMaxStage(int nNewStage)
	{
	}

	public void UpdateHardMaxStage(int nNewStage)
	{
	}

	public void UnlockPveSeasonNextChapter()
	{
	}

	public void UnlockPveSeasonNextHardChapter()
	{
	}

	public void ResetPveNewChapterFirstIn()
	{
	}

	public void ResetPveNewHardChapterFirstIn()
	{
	}

	public void SetBuyLifeCnt(int value)
	{
	}

	public int GetPveSeasonBestStage(int nChapterId, bool isHard = false)
	{
		return 0;
	}

	public int GetPveSeasonChapterLayers(int nChapterId)
	{
		return 0;
	}

	public bool SeasonChapterIsunlock(int id)
	{
		return false;
	}

	public bool IsSeasonHardChapterCanGo()
	{
		return false;
	}

	public List<GuildMemberHeadInfo> GetMemberHeadsByChapterId(int chapterId, GameMode mode = GameMode.eSeason)
	{
		return null;
	}

	public List<CPveStageRank> GetSeasonRankInfosByStage(int stage)
	{
		return null;
	}

	public void InitSeasonTopic(SelfAttributeData attribute)
	{
	}

	public List<int> GetSeasonSkill()
	{
		return null;
	}

	public void setPVELife(int value)
	{
	}

	public void modifyPVELife(int add)
	{
	}

	public void setPVESoulPoint(int value)
	{
	}

	public void modifyPVESoulPoint(int add)
	{
	}

	public void setPVESoulCrystal(int value)
	{
	}

	public void modifyPVESoulCrystal(int add)
	{
	}

	public void setPVESuperSoulCrystal(int value)
	{
	}

	public void modifyPVESuperSoulCrystal(int add)
	{
	}

	public void setPVETalentScore(int value)
	{
	}

	public void setPVETalentScore2(int value)
	{
	}

	public void modifyTalentScore(int add)
	{
	}

	public void modifyTalentScoreNew(int add)
	{
	}

	public int isTalentUnlock(int tid)
	{
		return 0;
	}

	public int GetTalentLevel(int tid)
	{
		return 0;
	}

	public int GetTalentTotalLevel()
	{
		return 0;
	}

	public void GetTalentUpgradeCount(int tid, ref int type, ref int count)
	{
	}

	public List<string> GetTalentAttribute_UI(int tid, int level)
	{
		return null;
	}

	public List<string> GetTalentAttributes(int type)
	{
		return null;
	}

	public List<string> GetSpecialTalentAttributes(string goodType)
	{
		return null;
	}

	public List<string> GetTalentEffects_PVE()
	{
		return null;
	}

	public List<int> GetTalentSkills_PVE()
	{
		return null;
	}

	public float GetPartitionValue_PVE(int tid)
	{
		return 0f;
	}

	public int SeasonHeroProfessionId(int id)
	{
		return 0;
	}

	public void ClearSeasonHeroProfession()
	{
	}

	public void AddRefreshProfessionTimes()
	{
	}

	public void UpdateSeasonHeroProfession(CRespPveSeasonInfo info)
	{
	}

	public void SetSeasonSelecteHero(int id)
	{
	}

	public void SetSeasonHeroAssistId(int id)
	{
	}

	public void SetSeasonHeroProfession(int id, int nProfessonId)
	{
	}

	public void SaveSeasonSelecteHero(int id)
	{
	}

	public void requestTalent(int type, int tid, Action<CRespPveTalent, int> action = null)
	{
	}

	public bool haveCanGetTalentReward_PVE()
	{
		return false;
	}

	public bool haveCanUpTalentLevel_PVE()
	{
		return false;
	}

	public void requestHarvest(int type, Action<CRespPveSeasonHarvest, int> action = null)
	{
	}

	public decimal GetCurrentHarvestDrop_PVE()
	{
		return 0m;
	}

	public int GetPVEHarvestId()
	{
		return 0;
	}

	public void LevelToChapter_PVE(int level, ref int c, ref int i)
	{
	}

	public bool canShowQuickRedPoint()
	{
		return false;
	}

	public void requestPVEShop(int type, int pid, Action callback = null)
	{
	}

	public int GetShopDataIndex(int pid)
	{
		return 0;
	}

	public int GetShopScoreDataIndex(int pid)
	{
		return 0;
	}

	public long GetNextWeekTime_PVE()
	{
		return 0L;
	}

	public bool isEndWeek_PVE()
	{
		return false;
	}

	public bool isOpenShopEx_PVE()
	{
		return false;
	}

	public void haveBuyChapterOne(int pid)
	{
	}

	public void requestPVERank(int type, Action<int> callback = null)
	{
	}

	public PVERankItemData GetMyRankData_PVE(int type)
	{
		return null;
	}

	public void parse_S3PVERankDivision()
	{
	}

	public void parse_S3PVERankReward()
	{
	}

	public void parse_S3PVERankWeekReward()
	{
	}

	public (int, int) GetRankCond(int area)
	{
		return default;
	}

	public List<string> GetRankRewards_PVE(int type, int area, int season, int rank)
	{
		return null;
	}

	public string GetRankRewardIcon_PVE(int type, int season, int rank)
	{
		return null;
	}

	public void openPVESeason()
	{
	}

	public void ParsePveSeasonConfig()
	{
	}

	public void UpdatePveSeasonBP(bool value)
	{
	}

	public bool CheckPveSeasonData()
	{
		return false;
	}

	public bool CheckPveSeasonWeekTopic()
	{
		return false;
	}

	public List<int> GetSelectedHeroProfessionSkillIds()
	{
		return null;
	}

	public List<int> GetHeroProfessionSkillIds(int nHeroId)
	{
		return null;
	}

	public PVEData.PveSeasonConfigData CurrentSeasonConfig()
	{
		return null;
	}

	public long PVE_ExcLeftTime()
	{
		return 0L;
	}

	public bool PVE_ExchangeIsOpen()
	{
		return false;
	}

	public void PVE_RequestExchange(int type, int _type, ulong eid, int num, int exid, Action action = null, int exchangeNum = 0)
	{
	}

	public ExcInData GetExcInData(int exid)
	{
		return null;
	}

	public int GetPointDataScore(int eid)
	{
		return 0;
	}

	public bool canShowSeasonNote()
	{
		return false;
	}

	public int GetSeasonChapterID(GameMode mode)
	{
		return 0;
	}

	public bool RefineSystemUnlocked()
	{
		return false;
	}

	public void AddCarvingItem(STCarvingItem item)
	{
	}

	public void UpdateCarvingList(STCarvingItem[] all)
	{
	}

	public void Refine_RequestInfo(Action<bool> callback = null)
	{
	}

	public void Refine_EquipCarvings(ushort posId, ushort index, uint id, Action<bool> callback = null)
	{
	}

	public void Refine_CombineCarvings(uint[] ids, int mainPos, int mainSlot, Action<bool> callback = null)
	{
	}

	public void Refine_ExtractCarving(ulong[] rowIds, Dictionary<int, int> scrolls, int gold, Action<bool> callback = null)
	{
	}

	public void Refine_Refine(ushort pos, ulong[] equipMaterials, int materialId, int materialCount, int gold, Action<bool, List<Drop_DropModel.DropData>> callback = null)
	{
	}

	public Dictionary<string, Goods_goods.GoodData> GetPropsSumRefine(int curPos, int curPosLevel)
	{
		return null;
	}

	public Dictionary<string, Goods_goods.GoodData> GetPropSumSlot(bool additional, int currentPos)
	{
		return null;
	}

	public static void GetRefinePropsAndSkillsSum(int pos, int level, out Dictionary<string, Goods_goods.GoodData> props, out HashSet<int> skills)
	{
		props = null;
		skills = null;
	}

	public static void GetCarvingPropsAndSkills(int carvingId, out Dictionary<string, Goods_goods.GoodData> props, out HashSet<int> skills, int mode = 0)
	{
		props = null;
		skills = null;
	}

	public static string[] GetRefinePropsByPosAndLevel(int curPos, int level)
	{
		return null;
	}

	private static void GetPropOrSkillFromString(string str, Dictionary<string, Goods_goods.GoodData> props, HashSet<int> skills)
	{
	}

	public static int PosToConfigPos(int pos)
	{
		return 0;
	}

	public List<int> GetRefineSkillsByEquipPosForUI(int curPos)
	{
		return null;
	}

	public List<int> GetCarvingItemSkillsByEquipPosForUI(int curPos)
	{
		return null;
	}

	public Dictionary<string, Goods_goods.GoodData> GetPropsSumRefineForUI(int curPos, int curPosLevel)
	{
		return null;
	}

	public Dictionary<string, Goods_goods.GoodData> GetPropSumSlotForUI(int mode, int currentPos)
	{
		return null;
	}

	public List<EquipOne> GetAllExistedRelicItems()
	{
		return null;
	}

	public List<EquipOne> GetExistedRelicItemsByRarity(int rarity)
	{
		return null;
	}

	public List<EquipOne> GetAllRelicItems()
	{
		return null;
	}

	private void Log(string msg)
	{
	}

	private void InitSailingData()
	{
	}

	public void UnInitSailingData()
	{
	}

	public void FreshSailingData()
	{
	}

	public void SetSailingTalentData(CampTalent[] campTalent)
	{
	}

	public void SetSailingPersonalTalentData(int id, int level)
	{
	}

	public void SetSailingLogHistory(List<SailingManager.SailingLogItemData> his)
	{
	}

	private void InitServerData()
	{
	}

	public void Shop_ParseJsonIAP()
	{
	}

	public int GetStarDiamondNeedCount(string pid)
	{
		return 0;
	}

	public int GetStarDiamondNeedCount(int rowid)
	{
		return 0;
	}

	public ShopIAPData GetShopIAPDataOne(int rowid)
	{
		return null;
	}

	private void InitStage()
	{
	}

	public int Stage_GetStage()
	{
		return 0;
	}

	public int Stage_GetStageInNormalMode()
	{
		return 0;
	}

	public int Stage_GetUIStage()
	{
		return 0;
	}

	public void Stage_UpdateMaxLevel(int maxlevel)
	{
	}

	public bool Stage_GetNewBest()
	{
		return false;
	}

	public void Stage_SetNewBest()
	{
	}

	public int Stage_GetBoxLayerID()
	{
		return 0;
	}

	public bool Stage_CheckUnlockNext(int roomID)
	{
		return false;
	}

	public void Stage_RollbackNext()
	{
	}

	public void StageDiscount_Init(string data)
	{
	}

	public void StageDiscount_DeInit()
	{
	}

	public string StageDiscount_GetProductID()
	{
		return null;
	}

	public int StageDiscount_GetCurrentID()
	{
		return 0;
	}

	public int StageDiscount_GetLastID()
	{
		return 0;
	}

	public bool StageDiscount_IsValid()
	{
		return false;
	}

	public bool IsAdFree()
	{
		return false;
	}

	public List<Drop_DropModel.DropData> StageDiscount_GetList()
	{
		return null;
	}

	public void StageDiscount_Send(bool force, Action<string, NetResponse> callback)
	{
	}

	public bool get_diamondbox_open(bool send = false, Action refresh = null)
	{
		return false;
	}

	public bool get_character_open()
	{
		return false;
	}

	public bool get_battlepass_open()
	{
		return false;
	}

	public bool get_dailyactivity_open()
	{
		return false;
	}

	public bool get_medalsystem_open()
	{
		return false;
	}

	public bool get_weaponskin_open()
	{
		return false;
	}

	public bool get_pet_open()
	{
		return false;
	}

	public bool get_templeactivity_open()
	{
		return false;
	}

	public bool get_weeklytask_open()
	{
		return false;
	}

	public bool get_character_discount_open()
	{
		return false;
	}

	public bool get_character_upgrade_open()
	{
		return false;
	}

	public bool get401or402EquipOpen()
	{
		return false;
	}

	public bool getMagicBookEquipOpen()
	{
		return false;
	}

	public void SaveDataRefresh()
	{
	}

	public void InitSaveData()
	{
	}

	public void WriteFile(FileSaveMgr.WriteData data)
	{
	}

	private void InitTimeBoxTime()
	{
	}

	public void SetTimeBoxMax(TimeBoxType type, int max)
	{
	}

	public long GetTimeBoxTime(TimeBoxType type)
	{
		return 0L;
	}

	public void SetTimeBoxTime(TimeBoxType type, long time = 0L)
	{
	}

	public bool CheckBoxUpdateTime()
	{
		return false;
	}

	public void ClearTimeBoxTime()
	{
	}

	public int GetTimeBoxCount(TimeBoxType type)
	{
		return 0;
	}

	public void UsserInfo_SetTimeBoxCount(TimeBoxType type, int count)
	{
	}

	public void Modify_TimeBoxCount(TimeBoxType type, int count, bool over = false)
	{
	}

	public bool IsTimeBoxMax(TimeBoxType type)
	{
		return false;
	}

	public List<Drop_DropModel.DropData> GetDropTimeBoxRandom()
	{
		return null;
	}

	public int GetTimeFreeBoxOne(TimeBoxType type)
	{
		return 0;
	}

	public int GetCfgShopBoxSwitchCount()
	{
		return 0;
	}

	public bool GetShopBoxTipsSwicth()
	{
		return false;
	}

	public void SetShopBoxTipsSwitch(bool swth)
	{
	}

	public int GetShopBoxTipsCount()
	{
		return 0;
	}

	public void SetShopBoxTipsCount(int count)
	{
	}

	public void ReqTowerInfo()
	{
	}

	public void SendTowerGameOver(bool isWin, Action<bool> result = null)
	{
	}

	public void UserBack_RequestInfo(Action onSuccess = null)
	{
	}

	private void ProcessData(CRespUserBack data)
	{
	}

	public void UserBack_ReceiveReward(RewardSetItemCtrl.ItemType type, int index, string select_index = null)
	{
	}

	public bool IsUserBackHaveRed()
	{
		return false;
	}

	public bool IsCheckInHaveRed()
	{
		return false;
	}

	public void SetTimeEndToday(ulong time)
	{
	}

	public void UserInfo_Set(long gold, int diamond, long exp, int level, int diamondnormal, int diamondlarge, int diamondMix, uint twoWeekCash, uint lastThreePurchaseAvg, int dragonBoxItem, int relics, int equips, int workers, int pets, ulong nMustDropMask, int starDiamond, int imprints, int upgradeLevel)
	{
	}

	public void UserInfo_SetGold(long gold, bool silent = false)
	{
	}

	public void UserInfo_SetDiamond(int diamond, bool silent = false)
	{
	}

	public void UserInfo_SetKey(int key)
	{
	}

	public bool GetUserInfoInit()
	{
		return false;
	}

	public void SetUserInfoInit()
	{
	}

	public void SetServerUserID(ulong id)
	{
	}

	public void SetOfflineBattleCnt(int value)
	{
	}

	public void AddOfflineBattleCnt()
	{
	}

	public void SetDoubleDiamondList(string[] str)
	{
	}

	public void AddDoubleDiamond(string str)
	{
	}

	public List<string> GetDoubleDiamondList()
	{
		return null;
	}

	public ulong GetServerUserID()
	{
		return 0uL;
	}

	public string GetServerUserIDSub()
	{
		return null;
	}

	public ulong GetServeUserIDSubLong()
	{
		return 0uL;
	}

	public string GetServerUserIDSub(ulong id)
	{
		return null;
	}

	public ulong GetServeUserIDSubLong(ulong id)
	{
		return 0uL;
	}

	public string GetServerUserIDTGA()
	{
		return null;
	}

	public void SetDiamondBoxGuide()
	{
	}

	public bool GetDiamondBoxGuide()
	{
		return false;
	}

	public void Modify_Gold(long gold)
	{
	}

	public void Modify_ShowGold(long gold)
	{
	}

	public void Modify_ShowDiamond(long diamond)
	{
	}

	public void UpdateCurrency()
	{
	}

	public void Modify_Diamond(long diamond)
	{
	}

	public void Modify_Resource(long resource, bool updateui = true)
	{
	}

	public void Modify_Exp(long exp, bool updateui = true)
	{
	}

	public void Modify_ShowExp(long exp)
	{
	}

	public void SetDiamondExtraCount(TimeBoxType type, int count)
	{
	}

	public void Modify_DiamondExtraCount(TimeBoxType type, int count)
	{
	}

	public void SetRegisterTime(long time)
	{
	}

	public long GetRegisterTime()
	{
		return 0L;
	}

	public int GetRegisterPassTime()
	{
		return 0;
	}

	public void FirstRegister()
	{
	}

	public int GetDiamondExtraCount(TimeBoxType type)
	{
		return 0;
	}

	public int GetDiamondBoxFreeCount(TimeBoxType type)
	{
		return 0;
	}

	public void SetLevel(int level)
	{
	}

	public void SetExp(long exp)
	{
	}

	public void SetLargeDiamondItemCount(ushort LargeDiamondItemCount)
	{
	}

	public ushort GetLargeDiamondItemCount()
	{
		return 0;
	}

	public void SetMixDiamondItemCountToNextGuaranteedReward(ushort count)
	{
	}

	public ushort GetMixDiamondItemCountToNextGuaranteedReward()
	{
		return 0;
	}

	public void SetDragonItemCountToNextGuaranteedReward(ushort count)
	{
	}

	public ushort GetDragonItemCountToNextGuaranteedReward()
	{
		return 0;
	}

	public void SetDragonUpCountToNextGuarantee(ushort count)
	{
	}

	public ushort GetDragonUpCountToNextGuarantee()
	{
		return 0;
	}

	public void SetBox_NextGuaranteedReward_Relics(ushort count)
	{
	}

	public ushort GetBox_NextGuaranteedReward_Relics()
	{
		return 0;
	}

	public void SetBox_NextGuaranteedReward_Relics10(ushort count)
	{
	}

	public ushort GetBox_NextGuaranteedReward_Relics10()
	{
		return 0;
	}

	public void SetBox_NextGuaranteedReward_EquipS(ushort count)
	{
	}

	public ushort GetBox_NextGuaranteedReward_EquipS()
	{
		return 0;
	}

	public void SetBox_NextGuaranteedReward_EquipS10(ushort count)
	{
	}

	public ushort GetBox_NextGuaranteedReward_EquipS10()
	{
		return 0;
	}

	public void SetBox_NextRewardLow_Manor(ushort count)
	{
	}

	public ushort GetBox_NextRewardLow_Manor()
	{
		return 0;
	}

	public void SetBox_NextRewardMid_Manor(ushort count)
	{
	}

	public ushort GetBox_NextRewardMid_Manor()
	{
		return 0;
	}

	public void SetBox_NextRewardHigh_Manor(ushort count)
	{
	}

	public ushort GetBox_NextRewardHigh_Manor()
	{
		return 0;
	}

	public void SetBox_NextRewardLow_Pet(ushort count)
	{
	}

	public ushort GetBox_NextRewardLow_Pet()
	{
		return 0;
	}

	public void SetBox_NextRewardMid_Pet(ushort count)
	{
	}

	public ushort GetBox_NextRewardMidPet()
	{
		return 0;
	}

	public void SetBox_NextRewardHigh_Pet(ushort count)
	{
	}

	public ushort GetBox_NextRewardHigh_Pet()
	{
		return 0;
	}

	public void SetBox_NextRewardLow_Imprint(ushort count)
	{
	}

	public ushort GetBox_NextRewardLow_Imprint()
	{
		return 0;
	}

	public void SetBox_NextRewardMid_Imprint(ushort count)
	{
	}

	public ushort GetBox_NextRewardMidImprint()
	{
		return 0;
	}

	public void SetBox_NextRewardHigh_Imprint(ushort count)
	{
	}

	public ushort GetBox_NextRewardHigh_Imprint()
	{
		return 0;
	}

	public void Modify_drop(string str)
	{
	}

	public void Modify_drop(string[] strs)
	{
	}

	public void BattleAd_Set(int count)
	{
	}

	public void BattleAd_Use()
	{
	}

	public int BattleAd_Get()
	{
		return 0;
	}

	public bool BattleAd_CanShow()
	{
		return false;
	}

	public void Set_Gold(long gold, bool updateui = true)
	{
	}

	public bool Use_Gold(long gold)
	{
		return false;
	}

	public void UserInfo_SetBestScore(int score)
	{
	}

	public void UserInfo_SetRebornCount(int count)
	{
	}

	public void UserInfo_SetAdKeyCount(int count)
	{
	}

	public int UserInfo_GetAdKeyCount()
	{
		return 0;
	}

	public bool UserInfo_UseAdKeyCount()
	{
		return false;
	}

	public int GetRebornCount()
	{
		return 0;
	}

	public void Modify_RebornCount(int value)
	{
	}

	public void TrustCount_Refresh(short count)
	{
	}

	public bool TrustCount_Use()
	{
		return false;
	}

	public int TrustCount_Get()
	{
		return 0;
	}

	public int GetScore()
	{
		return 0;
	}

	public UserInfo GetUserInfo()
	{
		return null;
	}

	public bool GetUserLoginSDK()
	{
		return false;
	}

	public void SetUserLoginSDK(bool value)
	{
	}

	public string GetUserName()
	{
		return null;
	}

	public void SetUserName_Temp(string name)
	{
	}

	public long GetGold()
	{
		return 0L;
	}

	public int GetKey()
	{
		return 0;
	}

	public long GetResource()
	{
		return 0L;
	}

	public long GetDiamond()
	{
		return 0L;
	}

	public long GetShowDiamond()
	{
		return 0L;
	}

	public long GetExp()
	{
		return 0L;
	}

	public long GetShowExp()
	{
		return 0L;
	}

	public int GetLevel()
	{
		return 0;
	}

	public int GetRuneUpCount()
	{
		return 0;
	}

	public void SetRuneUpCount(int total)
	{
	}

	public bool GetIfFacebookLogin()
	{
		return false;
	}

	public void SetIfFacebookLogin(bool ifLogin)
	{
	}

	public bool GetIdfaGemsGot()
	{
		return false;
	}

	public void SetIdfaGemsGot(bool idfaGemsGot)
	{
	}

	public bool GetCanLevelUp()
	{
		return false;
	}

	public void LevelUp()
	{
	}

	public string GetUserID()
	{
		return null;
	}

	public string GetNewUserID()
	{
		return null;
	}

	public void SetUserID(LoginType type, SdkManager.LoginData data)
	{
	}

	public void SetUserName(string name)
	{
	}

	public void RefreshUserIDFromTemp()
	{
	}

	public string GetUserIDTemp()
	{
		return null;
	}

	public string GetUserNameTemp()
	{
		return null;
	}

	public void SetUserIdName(string id, string name)
	{
	}

	public void SetUserTemp(string id, string gamePlayerID, string name)
	{
	}

	public LoginType GetLoginType()
	{
		return LoginType.eInvalid;
	}

	public long GetNetID()
	{
		return 0L;
	}

	private void UpdateNetID()
	{
	}

	private void SaveUserInfo(bool updateui = true)
	{
	}

	private void InitUserInfo()
	{
	}

	private void InitKeyTime()
	{
	}

	public void UserInfo_SetKeyTime(long time)
	{
	}

	public long GetKeyTime()
	{
		return 0L;
	}

	public void SetKeyTime(long time)
	{
	}

	public void UserInfo_SetShopFrag(short min, ushort max, ulong timestamp)
	{
	}

	public bool UserInfo_GetShopFrag()
	{
		return false;
	}

	public void UserInfo_IncShopFrag()
	{
	}

	public void Modify_Key(long key, bool over = true)
	{
	}

	public bool IsKeyMax()
	{
		return false;
	}

	public void DoLogin_Start(Action callback, SendType type = SendType.eLoop)
	{
	}

	public void DoLogin_Start_New(Action callback, SendType type = SendType.eLoop)
	{
	}

	public void DoLogin(SendType sendType, Action callback, bool checkChange = true)
	{
	}

	public void DoLoginCallBack(CRespUserLoginPacket data, Action callback)
	{
	}

	private void DoLoginCallBack2(CRespUserLoginPacket data, Action callback)
	{
	}

	public void TryLogin(Action<bool, CRespUserLoginPacket> callback)
	{
	}

	private void TryLoginServer(Action<bool, CRespUserLoginPacket> callback)
	{
	}

	public void send_time_sync(SendType sendtype = SendType.eUDP, Action callback = null)
	{
	}

	public void send_dailyActivity_info(Action successCallBack, Action failCallBack)
	{
	}

	public void UserInfo_SetBuyKeyTimestamp(long mI64Timestamp)
	{
	}

	public void UserInfo_SetAdKeyTimeStamp(long mI64Timestamp)
	{
	}

	public void UserInfo_SetLuckyItemTimeStamp(long mI64Timestamp)
	{
	}

	public long UserInfo_GetBuyKeyTimestamp()
	{
		return 0L;
	}

	public void UserInfo_SetBuyKeyTimes(short mNMin)
	{
	}

	public int UserInfo_GetBuyKeyTimes()
	{
		return 0;
	}

	public long UserInfo_GetTodayEndTimestamp()
	{
		return 0L;
	}

	public void SetChapterBanTime(ulong time)
	{
	}

	public long GetChapterBanTime()
	{
		return 0L;
	}

	public bool CanChapterBattle()
	{
		return false;
	}

	public void ClearWeaponSkin()
	{
	}

	public void ReqWeaponSkinMsg(Action callback)
	{
	}

	public void ReqGetWeaponSkinMsg(int Type, int skinid, Action callback)
	{
	}

	public void AddWeaponSkin(CWeaponSkin[] skins)
	{
	}

	public void AddWeaponSkin(int skinId)
	{
	}

	public List<int> GetWeaponSkinIds()
	{
		return null;
	}

	public bool HaveAnyWeaponSkin()
	{
		return false;
	}

	public int GetBestSkinByWeaponType(int weaponType)
	{
		return 0;
	}

	public int GetEntityWeaponSkinId(EntityBase entity)
	{
		return 0;
	}

	private bool IsDefaultWeaponSkin(EntityBase entity)
	{
		return false;
	}

	public WeaponSkinVO GetEntityWeaponSkinVO(int skinId)
	{
		return null;
	}

	public int GetWrapBulletModelId(int usingWeaponId)
	{
		return 0;
	}

	public WeaponSkinVO GetCurWeaponSkinVO()
	{
		return null;
	}

	public WeaponSkinVO GetWeaponSkinVOByBulletId(int nBulletId)
	{
		return null;
	}

	public bool GetWeaponSkinHaved(int skinid)
	{
		return false;
	}

	public bool IsHaveWeaponSkin(int weaponId)
	{
		return false;
	}

	public bool IsWearWeaponHaveSkin()
	{
		return false;
	}

	public bool CanUseWeaponSkinModel(EntityBase entity)
	{
		return false;
	}

	public List<int> GetExistedWeaponSkinIds()
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetAllWeaponSkinAttrs(SelfAttributeData selfAttribute)
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetUsingWeaponSkinAttrs()
	{
		return null;
	}

	public int GetCurUsingWeaponSkinId()
	{
		return 0;
	}

	public List<int> GetWeaponSkinSkillIds()
	{
		return null;
	}

	public List<int> GetWeaponSkinSkillIdsById(int weaponSkinId, int weaponSkinLv)
	{
		return null;
	}

	public Dictionary<int, int> GetWeaponSkinDict()
	{
		return null;
	}

	public Dictionary<int, int> CreateEmptyWeaponSkinDict()
	{
		return null;
	}

	public int GetUsingWeaponSkinIdByType(int type)
	{
		return 0;
	}

	public void UseWeaponSkinId(int type, int weaponSkinId)
	{
	}

	public void ReqWeaponSkinColorMsg(Action<bool> callback)
	{
	}

	public void ReqExchangeWeaponSkinColor(int colorID, Action<bool> callback)
	{
	}

	public void AddWeaponColor(CColorfulWeaponSkin[] colors)
	{
	}

	public void AddWeaponColor(int colorID)
	{
	}

	public bool IsHaveWeaponSkinColor(int colorID)
	{
		return false;
	}

	public bool IsHaveColor(int typeInfoID)
	{
		return false;
	}

	public int GetUsingWeaponSkinColor(int typeInfoID)
	{
		return 0;
	}

	public bool IsDefaultColor(int colorID)
	{
		return false;
	}

	public int GetDefaultColorID(int typeInfoID)
	{
		return 0;
	}

	private void AddWeaponSkinColorID(int colorID)
	{
	}

	public void UseWeaponSkinColorID(int typeInfoID, int colorID)
	{
	}

	public Dictionary<int, int> GetWeaponSkinColorDict()
	{
		return null;
	}

	public List<int> GetAllColorBySkinIDOrWeaponType(int typeInfoID)
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetAllColorAtt()
	{
		return null;
	}

	public void ReqActivateWeaponSkin(int skinid, bool isColor, Action<bool, List<Drop_DropModel.DropData>> callback)
	{
	}

	public void ReqWeaponCollectGetReward(Action<bool> callback)
	{
	}

	public int GetWeaponSkinCollectLV()
	{
		return 0;
	}

	public bool IsMaxLevel()
	{
		return false;
	}

	public (int, int) GetWeaponSkinCollectExp()
	{
		return default;
	}

	public (int, int) GetAtkAndHpValueByWeaponSkinCollect()
	{
		return default;
	}

	public List<Goods_goods.GoodData> GetWeaponSkinCollectAttList()
	{
		return null;
	}

	public List<WeaponSkinCollectRewardData> GetWeaponSkinCollectRewardData()
	{
		return null;
	}

	public List<Drop_DropModel.DropData> GetAllWeaponSkinAndColorByQuality(int quality, bool isColor)
	{
		return null;
	}

	public bool IsSkinOrColorActivated(bool isColor, int skinID)
	{
		return false;
	}

	public bool IsPropFly(int propID)
	{
		return false;
	}

	public int GetDefaultColorIDByTypeInfo(int typeInfo)
	{
		return 0;
	}

	public List<int> GetAllColorHadByTypeInfoID(int typeInfo)
	{
		return null;
	}

	public void ReqWeaponSkinEnhance(int skinID, Action<bool> callback)
	{
	}

	public List<WeaponSkinLevelUpRewardData> GetWeaponSkinLevelUpRewardDataBySkinID(int skinID)
	{
		return null;
	}

	public int GetWeaponSkinLvBySkinID(int skinID)
	{
		return 0;
	}

	public bool IsWeaponSkinCanEnhance(int skinID)
	{
		return false;
	}

	public void SetWeaponSkinLv(CWeaponSkin[] skin)
	{
	}

	public List<Goods_goods.GoodData> GetWeaponSkinLevelUpAllAtt()
	{
		return null;
	}

	public List<int> GetWeaponSkinExtraSkillID(int weaponSkinID, int weaponSkinLv)
	{
		return null;
	}

	private LocalSavePet initPetData()
	{
		return null;
	}

	public void FreshPetData()
	{
	}

	public PetAttrData Pet_GetStarAttrData(int pid, int star)
	{
		return null;
	}

	public List<PetAttrData> Pet_AttrList_Skill(int skiId)
	{
		return null;
	}

	public int Pet_SkiIdFindPetId_Current(int skiId)
	{
		return 0;
	}

	public int Pet_SkiIdFindPetId_Origin(int skiId)
	{
		return 0;
	}

	public int Pet_SkiIdToSkiLevel(int skiId)
	{
		return 0;
	}

	public List<int> Pet_GetAllSkillInherit()
	{
		return null;
	}

	public List<int> Pet_GetAllSkillInherit(int petId)
	{
		return null;
	}

	public PetOne GetNewPetOne(int pid, int star, int level)
	{
		return null;
	}

	public int Pet_SkillMaxLevel(int skid)
	{
		return 0;
	}

	public string Pet_SkillDescText(int skiId, int level, bool add)
	{
		return null;
	}

	public PetUpNeedCond Pet_SkiUpNeedMat(int skiId, int level)
	{
		return null;
	}

	public string Pet_StarNeedDesc(int star)
	{
		return null;
	}

	public string Pet_StarNeedDesc2(string name, int star)
	{
		return null;
	}

	public bool Pet_SkiCanLevelUp(int skiId)
	{
		return false;
	}

	public void InitPets(STPetInfo[] petInfos, bool isClearData = false)
	{
	}

	public void RequestPetShop(Action callBack = null)
	{
	}

	public List<CPetExchangeData> GetPetShopItems()
	{
		return null;
	}

	public bool PetUpOpen()
	{
		return false;
	}

	public void SetPetUpCountToNextGuarantee(ushort count)
	{
	}

	public ushort GetPetUpCountToNextGuarantee()
	{
		return 0;
	}

	public void ParsePetUpData(CRespOpenPetBox data)
	{
	}

	public void RequestPetBox()
	{
	}

	public void requestPet(int type, int pid, int skid, int status, int pos, int bpid, Action<CRespPetInfo, int> action = null)
	{
	}

	public WingOne GetWingNewOne(int wingId, int level = 1, int starId = 0)
	{
		return null;
	}

	public WingOne GetWingNewMaxOne(int wingId)
	{
		return null;
	}

	public int GetWingStarIdByStar(int star)
	{
		return 0;
	}

	public int GetWingStarByStarId(int starID)
	{
		return 0;
	}

	private LocalSaveWing initWingData()
	{
		return null;
	}

	public int GetCurWearWingConfigId()
	{
		return 0;
	}

	public WingOne GetWingOneByFragmentId(int fragmentId)
	{
		return null;
	}

	public List<Goods_goods.GoodData> GetWingAttributes(int wingId)
	{
		return null;
	}

	public void RequestWing()
	{
	}

	public void RequestUnLockWing(WingOne _wing, int type, Action callBack = null)
	{
	}

	public void RequestWearWing(int wingId, Action callBack = null)
	{
	}

	public void RequestUnWearWing(int wingId, Action callBack = null)
	{
	}

	public void RequestWingUpLevel(WingOne _wing, int level, Action callBack = null)
	{
	}

	public void RequestWingUpStar(WingOne _wing, Action callBack = null)
	{
	}

	public void RequestUpdateAssists(WingOne _wing, Action callBack = null)
	{
	}
}
