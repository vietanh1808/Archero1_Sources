using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Emoji;
using TableTool;
using UnityEngine;

public class EntityHero : EntityBase
{
	public class AssistWeapon
	{
		private const string Tag = "AssistWeapon";

		protected const float INTERVAL = 2f;

		private float m_fTime;

		private float m_fInterval;

		protected EntityBase m_Entity;

		protected int[] m_aryBulletIds;

		protected float m_fTotalAngle;

		protected float m_fAttackRatio;

		private float m_fOffsetAngle;

		private float m_fOffsetDistance;

		protected EntityAttributeBase.ValueBase m_valueBase;

		protected virtual float Interval => 0f;

		public void Init(EntityBase entity, int[] aryBulletIds, float fTotalAngle, float fAttackRatio, float fOffsetAngle, float fOffsetDistance, EntityAttributeBase.ValueBase valueBase, float fInterval)
		{
		}

		public void UpdateInterval(float fInterval)
		{
		}

		protected virtual void OnInit()
		{
		}

		public void DeInit()
		{
		}

		protected virtual void OnDeInit()
		{
		}

		private void CalInterval()
		{
		}

		private void OnAttackSpeedChange(int value)
		{
		}

		protected virtual void OnUpdate(float delta)
		{
		}

		private bool Attack()
		{
			return false;
		}

		protected virtual int GetCnt()
		{
			return 0;
		}

		protected virtual BulletBase CreateBullet(int index, float angle, Vector3 dir)
		{
			return null;
		}

		protected virtual int GetBulletId()
		{
			return 0;
		}

		protected virtual void OnAttack()
		{
		}
	}

	public class SpearBouncyWeapon : AssistWeapon
	{
		protected EntityAttributeBase.ValueBase m_valueBase2;

		protected override float Interval => 0f;

		public SpearBouncyWeapon(EntityAttributeBase.ValueBase valueBase)
		{
		}

		protected override int GetBulletId()
		{
			return 0;
		}

		protected override BulletBase CreateBullet(int index, float angle, Vector3 dir)
		{
			return null;
		}
	}

	public class TornadoBouncyWeapon : AssistWeapon
	{
		protected EntityAttributeBase.ValueBase m_valueBase2;

		protected override float Interval => 0f;

		public TornadoBouncyWeapon(EntityAttributeBase.ValueBase valueBase)
		{
		}

		protected override int GetBulletId()
		{
			return 0;
		}

		protected override BulletBase CreateBullet(int index, float angle, Vector3 dir)
		{
			return null;
		}
	}

	public class ThunderWeapon : AssistWeapon
	{
		private float m_fRadius;

		private int m_nDebuffId;

		private List<EntityBase> m_listEntities;

		protected override float Interval => 0f;

		public ThunderWeapon(float radius, int debuff)
		{
		}

		protected override int GetCnt()
		{
			return 0;
		}

		protected override BulletBase CreateBullet(int index, float angle, Vector3 dir)
		{
			return null;
		}

		protected override void OnDeInit()
		{
		}
	}

	public class FloatingLaserCannon : AssistWeapon
	{
		private int m_nBabyId;

		protected override float Interval => 0f;

		public FloatingLaserCannon(int babyId)
		{
		}

		protected override BulletBase CreateBullet(int index, float angle, Vector3 dir)
		{
			return null;
		}

		private EntityBabyBase CreateBaby(int babyID)
		{
			return null;
		}
	}

	public class EventMoveStartData
	{
		public Action mEvent;

		public float delay;
	}

	public class EventMovingData
	{
		public Action<JoyData> mEvent;

		public float delay;
	}

	public class EventMoveEndData
	{
		public Action mEvent;

		public float delay;
	}

	private class LevelUpData
	{
		public string name;

		public long value;
	}

	private Dictionary<string, AssistWeapon> m_dicAssistWeapons;

	public const int DRAGON_GIRL_ID = 20020;

	public Transform Coin_Absorb;

	private int mAbsorb;

	protected List<int> equipskills;

	protected PlayerCharacter_Character mCharacterData;

	private int checkIndex;

	protected ActionBasic hitFireMeteorAction;

	protected ActionBasic hitFireAerolite;

	private bool hasTigerHatHitReducePercentDone;

	private bool hasTigerShoeMoveSpeedPercentDone;

	private List<int> dragonSkills;

	private GameObject goInkDragonBodyAround;

	private string m_strLastModelId;

	public Vector2Int AnchorXY;

	private static Dictionary<int, int> AbsorbDic;

	private Dictionary<int, float> mAbsorbTimes;

	private float mAbsorbInterval;

	private int InkDragonIceBuffId;

	private bool mAbsorbDrop;

	private int m_monkeyHairCount;

	private List<Vector3> m_listPartnerPoses;

	private bool m_bPartnerPosInitialFlag;

	public List<Sequence> mSequenceList;

	public List<EventMoveStartData> mMoveStartList;

	public List<EventMovingData> mMovingList;

	public List<EventMoveEndData> mMoveEndList;

	public Func<int, (int, int)> OnShootCatBulletBeforeAction;

	public Action<BulletBase> OnShootCatBulletAction;

	public Action<long> OnHeroDeadAction;

	public Action OnCreateBabyEvent;

	public Action<int, int> OnPartBodyLearnSkillAction;

	public Func<bool> OnCheckSuperSkillAction;

	public Action<bool> OnSuperSkillAction;

	public Action OnDailyRoleReversalSkillAction;

	public Action OnSuperSkillEndAction;

	public Action OnSuperWuKongSkillEndAction;

	public Func<bool> OnCheckWuKongSuperSkillAction;

	public Action<bool> OnWuKongSuperSkillAction;

	public Action OnWuKongSuperSkillEndAction;

	public Action OnRelicWuKongAIEndAction;

	[CompilerGenerated]
	private Func<bool> m_OnCanSuperSkillEvent;

	[CompilerGenerated]
	private Func<bool> m_OnCanSuperSkillCDEvent;

	[CompilerGenerated]
	private Func<bool> m_OnCanSaveSuperSkillCDEvent;

	public Action<bool> OnChangeWeaponAction;

	public Func<int, int> OnMeleeAttackStartPreAction;

	public Action<int> OnMeleeAttackStartAction;

	public Action<int> OnMeleeAttackEndAction;

	public EntityBaseFunc<Goods_goods.GoodData, EntityBase> OnAbsorbFoodFunc;

	public Func<long, long> OnHeroBodyHitAction;

	[CompilerGenerated]
	private Action m_OnAngerOverEvent;

	public Action<int> OnChangeBigSword;

	public Func<EntityBase, Vector3?, bool, EntityPartBodyBase> CallPartbodyExternal;

	public Action<EntityBase, Vector3> CallPartbodyPVPCoExternal;

	public Action<EntityBase> CallPartbodyPVPExternal;

	public Action OnOpheliaHitFlag;

	public Action OnOpheliaCallFlag;

	public Action<EntityBase> OpheliaCallFlagExternal;

	public Action<EntityBase> OnLinaCallPartbodyAction;

	public Func<EntityBase, Vector3?, EntityPartBodyBase> LinaCallPartbodyExternal;

	public Action<EntityBase, Vector3> LinaCallPartbodyPVPCoExternal;

	public Action<EntityBase> LinaCallPartbodyPVPExternal;

	public Action<int> LinaAddPartLimitExternal;

	public Action<float, float> SetTribleRateAndHit;

	public Action<EntityBase> TriggerRay;

	public Func<bool> OnWhirlWindCanReboundBulletAction;

	public Action<int> OnAngleHpRecoverAction;

	public Action OnFirstDeadRecover;

	public Action<int> OnBianshenTransformEvent;

	[CompilerGenerated]
	private Func<long, (long, float)> m_OnEntityHittedOnceEvent;

	[CompilerGenerated]
	private Func<(float, float)> m_OnSkillAlone1356SuperSkillTimeFunc;

	[CompilerGenerated]
	private Action<int> m_BoxingGloveIdChangeEvent;

	[CompilerGenerated]
	private Action m_UseRefreshCardEvent;

	[CompilerGenerated]
	private Func<bool> m_AdvancedAngleEvent;

	[CompilerGenerated]
	private Func<bool> m_AdvancedDemonEvent;

	private List<LevelUpData> mLevelUps;

	protected List<Skill_slotin_daily124> m_SkillList_Daily124;

	protected List<Skill_slotin_bagbattle> m_SkillList_Daily125;

	protected List<Skill_slotin_changemonster> m_SkillList_Daily126;

	public Dictionary<int, EntityDragonBase> DragonDict;

	private float mBubbleDistance;

	private const string BoxingEquipIdStr = "12101";

	private const string HammerEquipIdStr = "12102";

	private const string DemonGunEquipIdStr = "12103";

	private List<int> BulletHitAddList;

	private bool bFrontShield;

	protected List<Skill_slotin> mSkillList;

	private List<int> mLearnSkillList;

	private List<int> mExtraLearnSkillList;

	protected int WeightAll;

	protected int WeightMagicBookAll;

	protected int WeightFreshAll;

	protected List<int> skillidList;

	protected HashSet<int> removeSet;

	protected List<int> mMagicBookTmpSkills;

	protected int WeightAll_Daily;

	protected int WeightMagicBookAll_Daily;

	protected int WeightFreshAll_Daily;

	protected List<Skill_slotin> m_SkillList_Daily;

	private string m_strColumnName;

	protected int WeightAll_Daily130;

	protected List<Skill_slotin_daily130> m_SkillList_Daily130;

	protected int WeightAll_Dungeon;

	protected List<Skill_slotin_dungeon> m_SkillList_Dungeon;

	protected List<Skill_slotin_endless> m_SKillList_Endless;

	protected int WeightAll_Endless;

	protected int WeightMagicBookAll_Endless;

	protected int WeightFreshAll_Endless;

	protected int WeightAll_Maze;

	protected int WeightMagicBookAll_Maze;

	protected int WeightFreshAll_Maze;

	protected List<Skill_slotin> m_SkillList_Maze;

	protected List<Skill_slotin_boss> m_SkillList_RoleReversal;

	protected int WeightAll_RoleReversal;

	private MethodInfo _method;

	protected List<Skill_slotin_survivor> m_SKillList_Survival;

	protected int WeightAll_Survival;

	protected int WeightMagicBookAll_Survival;

	protected int WeightFreshAll_Survival;

	protected List<Skill_slotin_pvestage> m_SkillList_Season;

	protected List<Skill_slotin_slg> m_SkillList_SLG;

	protected List<Skill_slotin_TDHero> m_SkillList_TDHero;

	private int safeCount;

	private const int MAX_SAFE_COUNT = 1000;

	private int safe2Count;

	private SuperSkillBase mSuperSkill;

	public int KatanaMeleeId { get; set; }

	public GameObject FootDirection { get; private set; }

	public bool IsHeroClone { get; set; }

	public float HeroCloneAttackPercent { get; set; }

	public long HostHeroAttack { get; set; }

	public EmojiNormal emojiObject { get; protected set; }

	public PlayerCharacter_Character PlayerCharacterData => null;

	public bool IsDragonAvailable => false;

	public override EntityBase m_HatredTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int CurMonkeyHairCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool CalCanSuperSkill => false;

	public bool CalCanSuperSkillCD => false;

	public bool CalSaveCanSuperSkillCD => false;

	public bool CanAdvancedAngle => false;

	public bool CanAdvancedDemon => false;

	protected string ColumnName => null;

	private bool HasDailyColumn => false;

	private MethodInfo method => null;

	public event Func<bool> OnCanSuperSkillEvent
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

	public event Func<bool> OnCanSuperSkillCDEvent
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

	public event Func<bool> OnCanSaveSuperSkillCDEvent
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

	public event Action OnAngerOverEvent
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

	public event Func<long, (long, float)> OnEntityHittedOnceEvent
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

	public event Func<(float, float)> OnSkillAlone1356SuperSkillTimeFunc
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

	public event Action<int> BoxingGloveIdChangeEvent
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

	public event Action UseRefreshCardEvent
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

	public event Func<bool> AdvancedAngleEvent
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

	public event Func<bool> AdvancedDemonEvent
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

	private void InitAssistWeapons()
	{
	}

	protected virtual void OnInitAssistWeapons()
	{
	}

	private void DeInitAssistWeapons()
	{
	}

	protected virtual void OnDeInitAssistWeapons()
	{
	}

	public AssistWeapon AddAssistWeapon(int[] aryBulletIds, float fTotalAngle, float fAttackRatio, float fOffsetAngle, float fOffsetDistance, EntityAttributeBase.ValueBase valueBase, string name, float fInterval)
	{
		return null;
	}

	private void Add2BulletHitAddWrapper(int[] aryBulletIds)
	{
	}

	public SpearBouncyWeapon AddSpearBouncyWeapon(int[] aryBulletIds, float fTotalAngle, float fAttackRatio, float fOffsetAngle, float fOffsetDistance, EntityAttributeBase.ValueBase valueBase, string name, float fInterval)
	{
		return null;
	}

	public TornadoBouncyWeapon AddTornadoBouncyWeapon(int[] aryBulletIds, float fTotalAngle, float fAttackRatio, float fOffsetAngle, float fOffsetDistance, EntityAttributeBase.ValueBase valueBase, string name, float fInterval)
	{
		return null;
	}

	public ThunderWeapon AddThunderWeapon(int[] aryBulletIds, float fTotalAngle, float fAttackRatio, float fOffsetAngle, float fOffsetDistance, EntityAttributeBase.ValueBase valueBase, string name, float fRange, int nDebuffId, float fInterval)
	{
		return null;
	}

	public FloatingLaserCannon AddFloatingLaserCannon(int[] aryBulletIds, float fTotalAngle, float fAttackRatio, float fOffsetAngle, float fOffsetDistance, EntityAttributeBase.ValueBase valueBase, string name, int nBabyId, float fInterval)
	{
		return null;
	}

	public void AddAssistWeapon(string name, AssistWeapon weapon)
	{
	}

	protected override void OnInitBefore()
	{
	}

	protected virtual void InitEmoji()
	{
	}

	protected override void OnInit()
	{
	}

	private void OnAddEnemy(EntityBase entity)
	{
	}

	public float GetCampHpMaxPercent(int level)
	{
		return 0f;
	}

	protected virtual void InitPVPGrass()
	{
	}

	protected virtual void DeinitPVPGrass()
	{
	}

	public virtual void InitMoveAndAttackControl()
	{
	}

	public virtual void OnMoveAndAttackControlCreated()
	{
	}

	private void InitBattleInEquip()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onHitFireMeteor(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void onHitFireAerolite(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void onHitExplode(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void OnKill(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	protected override void OnInitAfter()
	{
	}

	private void RelicsPostProcess()
	{
	}

	private void tryAddTigerHatAtt()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	public void CreateAttackCtrl(int type)
	{
	}

	private void _CreateAttackCtrl(int type)
	{
	}

	public void SetCharacterData(PlayerCharacter_Character data)
	{
	}

	public int GetPlayerCharacterId()
	{
		return 0;
	}

	private void TrickoffSkinSkill(int id)
	{
	}

	private void TrickoffWeaponSkinSkill(int id)
	{
	}

	private void TrickOffDemonSkill()
	{
	}

	protected override void StartInit()
	{
	}

	protected override void InitAnimations()
	{
	}

	private void InitRuneAttributes()
	{
	}

	private void InitAltarAttrs()
	{
	}

	protected override void OnDeInitLogic()
	{
	}

	public virtual void InitDragonSkills()
	{
	}

	public List<int> GetDragonSkills()
	{
		return null;
	}

	public virtual void InitRelicSkills()
	{
	}

	public virtual void InitRefineSkills()
	{
	}

	public virtual void InitMedalSkills()
	{
	}

	public virtual void InitHeadAndFrameSkills()
	{
	}

	public virtual void InitEquipSkills()
	{
	}

	protected virtual void InitGemSkills()
	{
	}

	protected virtual void InitHeroAssistSkills()
	{
	}

	private void LearnHeroAssistSkills()
	{
	}

	protected virtual void InitMonsterBattleSkills()
	{
	}

	protected virtual void InitExtraSkills()
	{
	}

	protected virtual void InitSkinSkill()
	{
	}

	protected void InitStarSkill()
	{
	}

	protected void InitSLGSkill()
	{
	}

	protected void InitManorSkill()
	{
	}

	protected void InitImprintTalentSkill()
	{
	}

	public void InitWingSkill(LocalSave.WingOne mainWing, List<LocalSave.WingOne> assistWing)
	{
	}

	private void LearnWingSkills(LocalSave.WingOne mainWing, List<LocalSave.WingOne> assistWing)
	{
	}

	public void InitArtifactSkill(List<ArtifactItemData> allItemData)
	{
	}

	public void LearnArtifactSkills(List<ArtifactItemData> allItemData)
	{
	}

	private bool TryApplyBattleSystemSkillListDecision(int systemId, GameModeBase.SkillType skillType, Action<List<int>> learnSkills)
	{
		return false;
	}

	private bool TryApplyBattleSystemSkillsDecision(int systemId, Action learnSkills)
	{
		return false;
	}

	private bool TryApplyBattleSystemEquipSkillsDecision(Action<List<int>> learnSkills)
	{
		return false;
	}

	private List<int> GetConfiguredBattleSystemSkillIds(GameModeBase.SkillType skillType)
	{
		return null;
	}

	private List<int> GetConfiguredBabyEquipSkillIds()
	{
		return null;
	}

	private void AddConfiguredStarSkillIds(List<int> ids)
	{
	}

	private bool ShouldSkipConfiguredBattleSystemSkills(int systemId)
	{
		return false;
	}

	private void InitExtraAttributes()
	{
	}

	public void AddEquipSkills(List<int> list)
	{
	}

	public void AddRefineSkills(List<int> list)
	{
	}

	public void AddDragonSkills(List<int> list)
	{
	}

	protected override void OnCreateModel()
	{
	}

	public void ClearSpecialParts()
	{
	}

	private void initInkDragon()
	{
	}

	public void ChangeModel(int id, int skinId = 0, bool changeWeapon = true)
	{
	}

	public void ChangeModel(string clothid, float fScale = 1f)
	{
	}

	public void ChangeMesh(int id)
	{
	}

	public void ResetModelId(int id)
	{
	}

	protected virtual void OnChangeModel()
	{
	}

	public void WearEquipInGame(int id)
	{
	}

	public void WearEquipInGame(LocalSave.EquipOne one)
	{
	}

	private void WearEquipAttribute(LocalSave.EquipOne one)
	{
	}

	private void WearEquipSkill(LocalSave.EquipOne one)
	{
	}

	private void CreateFootDirection()
	{
	}

	protected override void InitCharacter()
	{
	}

	protected override void UpdateProcess(float delta)
	{
	}

	private void onAnchorChanged()
	{
	}

	protected override void OnTriggerEnterExtra(Collider o)
	{
	}

	protected virtual void TriggerDoor(GameObject o)
	{
	}

	private void TriggerPortal(GameObject o)
	{
	}

	public void AbsorbEquips(EquipBase good)
	{
	}

	private float GetAbsorbTime(int foodid)
	{
		return 0f;
	}

	private void UpdateAbsorbTime(int foodid)
	{
	}

	public void AbsorbFoods(FoodBase good)
	{
	}

	private void AbsorbHpFoodWrapper(FoodBase good)
	{
	}

	protected override void OnChangeHP(EntityBase entity, long HP)
	{
	}

	public void SaveHPInTD()
	{
	}

	public virtual void SaveHP()
	{
	}

	protected override void OnChangeEnergy(EntityBase entity, long change)
	{
	}

	protected override void OnInitEnergy_BattleIn(long value)
	{
	}

	protected override void OnInitCharge_BattleIn(long value)
	{
	}

	protected override void OnDeInit()
	{
	}

	private void onAfterChangeHP()
	{
	}

	private void onReborn(BattleModuleData.UseRebornType type)
	{
	}

	private void onHit(EntityBase hittedEntity, HitStruct hs, HittedData hd)
	{
	}

	private void FellGround()
	{
	}

	public override void DeadCallBack()
	{
	}

	private void rebornByRelics()
	{
	}

	private void CalNewHeroPos()
	{
	}

	public override void SetCollider(bool enable)
	{
	}

	public void SetAbsorbDrop(bool value)
	{
	}

	public bool GetAbsorbDrop()
	{
		return false;
	}

	public void SetAbsorb(bool enable)
	{
	}

	public bool GetAbsorbEnable()
	{
		return false;
	}

	public int GetAbsorbValue()
	{
		return 0;
	}

	public void SetAbsorbValue(int value)
	{
	}

	public void SetAbsorbRangeMax(bool value)
	{
	}

	protected override void OnSetFlying(bool fly)
	{
	}

	public void LevelUp()
	{
	}

	public void BodyHit(EntityBase e)
	{
	}

	public void UpdateBombBullet(int cnt)
	{
	}

	public void UpdateSakura(int count)
	{
	}

	public void UpdateMonkeyHair(int count)
	{
	}

	private void synMonkeyHairCount(int count)
	{
	}

	public Vector3 RandomPartnerPos()
	{
		return default;
	}

	public void ClearPartnerPoses()
	{
	}

	public void UpdateBoxingCharge(float percent)
	{
	}

	public void UpdateFlash(float percent)
	{
	}

	public bool IsWuKong()
	{
		return false;
	}

	public bool IsDragonGirl()
	{
		return false;
	}

	public bool IsArthur()
	{
		return false;
	}

	public bool IsAthena()
	{
		return false;
	}

	public bool IsSeniorGrade()
	{
		return false;
	}

	public void ShowHpAngelOfJudgment(bool show)
	{
	}

	public void UpdateHpAngelOfJudgment(float percent)
	{
	}

	public void AddMoveStart(EventMoveStartData data)
	{
	}

	public void RemoveMoveStart(Action callback)
	{
	}

	public void AddMoving(EventMovingData data)
	{
	}

	public void RemoveMoving(Action<JoyData> callback)
	{
	}

	public void AddMoveEnd(EventMoveEndData data)
	{
	}

	public void RemoveMoveEnd(Action callback)
	{
	}

	public void DoMoveStart()
	{
	}

	public void DoMoving(JoyData data)
	{
	}

	public void DoMoveEnd()
	{
	}

	private void Action_OngotoNextRoom()
	{
	}

	public void TriggerAngerOverEvent()
	{
	}

	public (long, float) InvokeOnEntityHittedOnceEvent(long value = 0L)
	{
		return default;
	}

	public (float, float) InvokeSkillAlone1356SuperSkillTimeFunc()
	{
		return default;
	}

	public void InvokeBoxingGloveIdChangeEvent(int id)
	{
	}

	public void InvokeUseRefreshCardEvent()
	{
	}

	protected void InitCards()
	{
	}

	private void InitCard(LocalSave.CardOne one)
	{
	}

	public void ExcuteLevelUpAttributes(string name, long value)
	{
	}

	public void OnLevelUpEvent(int level)
	{
	}

	public List<int> GetSkill_Daily124(int pickedSkillNum = 9)
	{
		return null;
	}

	private Dictionary<int, TowerLevelManager.SkillWeight> populateSkillWeightDictInDaily124(int pickedSkillNum)
	{
		return null;
	}

	public List<int> GetSkillNewPlay125(int pickedSkillNum = 9)
	{
		return null;
	}

	private List<Skill_slotin_bagbattle> CheckNewPlay125PreCondition(List<Skill_slotin_bagbattle> all)
	{
		return null;
	}

	private Dictionary<int, TowerLevelManager.SkillWeight> PopulateSkillWeightDictInNewPlay125(int pickedSkillNum, bool isAngel = false)
	{
		return null;
	}

	public List<int> GetSkillNewPlay126(int pickedSkillNum = 9)
	{
		return null;
	}

	private List<Skill_slotin_changemonster> CheckNewPlay126PreCondition(List<Skill_slotin_changemonster> all)
	{
		return null;
	}

	private Dictionary<int, TowerLevelManager.SkillWeight> PopulateSkillWeightDictInNewPlay126(int pickedSkillNum, bool isAngel = false)
	{
		return null;
	}

	public override void DeInit()
	{
	}

	public void DestroyAllDragons()
	{
	}

	public void CreateDragon(DragonVO vo)
	{
	}

	public int GetAllStoneManCount()
	{
		return 0;
	}

	protected override void OnSetPositionBy(Vector3 pos)
	{
	}

	public void DoRunBubble(float dis)
	{
	}

	private void showRunBubble()
	{
	}

	public int GetWeaponEquipId()
	{
		return 0;
	}

	public bool IsBoxingEquip()
	{
		return false;
	}

	public bool IsHammerEquip()
	{
		return false;
	}

	public bool IsDemonGunEquip()
	{
		return false;
	}

	public void Add2BulletHitAdd(int bulletId)
	{
	}

	public bool IsInBulletHitAdd(int bulletId)
	{
		return false;
	}

	protected override HittedData OnHittedData(HittedData data, bool bulletthrough, float bulletangle)
	{
		return null;
	}

	protected override void OnDeadBefore()
	{
	}

	public virtual void DoReborn(BattleModuleData.UseRebornType rebornType = BattleModuleData.UseRebornType.None)
	{
	}

	private void recoverMagicValue()
	{
	}

	public virtual void DoRebornInternal(int pHpPart = 100, bool bSkillReborn = false, bool bNoLogic = false, BattleModuleData.UseRebornType rebornType = BattleModuleData.UseRebornType.None)
	{
	}

	public void Reborn_Dead()
	{
	}

	public virtual void Reborn_DeadEnd()
	{
	}

	protected void Reborn_DeadEndInternal()
	{
	}

	public void OnGotoNextRoom()
	{
	}

	public List<int> GetLearnSkillList()
	{
		return null;
	}

	protected void RefreshRemoveSetByBattleInCache()
	{
	}

	public bool CanLearSkill(int skillId)
	{
		return false;
	}

	public void AddSkillToRemoveSet(int skillId)
	{
	}

	private void AddSkillToRemoveSetInternal(int skillId)
	{
	}

	public void LearnAllSlotinSkills()
	{
	}

	protected virtual void InitSkillList()
	{
	}

	private void resetWeight()
	{
	}

	private int ABTestWeight(Skill_slotin item)
	{
		return 0;
	}

	private void CaculateWeight(Skill_slotin item)
	{
	}

	private int GetSkillWeight(Skill_slotin t)
	{
		return 0;
	}

	public virtual List<int> GetSkill(int num = 9, List<int> blockList = null)
	{
		return null;
	}

	public virtual List<int> GetMagicBookSkill(int num = 9)
	{
		return null;
	}

	public virtual List<int> GetFreshSkill(List<int> list, int num = 9)
	{
		return null;
	}

	public (List<T>, int) CheckPreCondition<T>(List<T> inList, Func<T, int> PreCondition, Func<T, int> Weight)
	{
		return default;
	}

	private List<T> CheckTableRandom<T>(List<T> inList, Func<T, bool> TrickoffInTurntable, Func<T, bool> PreCondition)
	{
		return null;
	}

	public virtual int GetRandomSkill()
	{
		return 0;
	}

	public virtual int GetTableRandomSkill()
	{
		return 0;
	}

	public virtual void LearnSkill(int skillid)
	{
	}

	public virtual void LearnSkillWithoutCache(int skillid)
	{
	}

	public virtual void LearnMagicBookSkill(int skillid)
	{
	}

	public void ForceAdd2LearnSkillList(int skillId)
	{
	}

	public void LearnMagicBookTmpSkill(int skillid)
	{
	}

	public void RemoveMagicBookTmpSkill(int skillid)
	{
	}

	public void RestoreLearnSkill()
	{
	}

	public bool CanLearnExtraSkill()
	{
		return false;
	}

	public void learn_skill_internal(int skillid)
	{
	}

	public void LearnExtraSkill(int skillid)
	{
	}

	public void add_gameturn_playerskill(int skillid)
	{
	}

	private void OnLearnSkill(int skillid)
	{
	}

	protected virtual void remove_skill_weight(int skillid)
	{
	}

	protected virtual void remove_magicbook_skill_weight(int skillid)
	{
	}

	public int GetLearnSkillCount()
	{
		return 0;
	}

	public string GetLearnedSkills()
	{
		return null;
	}

	private List<int> GetFirstSkill9Internal()
	{
		return null;
	}

	public virtual List<int> GetFirstSkill9()
	{
		return null;
	}

	protected override void OnAddSkillInternal(int skillId)
	{
	}

	protected override void OnRemoveSkillInternal(int skillId)
	{
	}

	public new List<int> GetSkillList()
	{
		return null;
	}

	public override void RemoveSkill(int skillId)
	{
	}

	public void refresh_add_skillids(List<int> skills)
	{
	}

	public IList GetRemainingSkills()
	{
		return null;
	}

	private void AddSkillToRemoveSet_Daily(int skillId)
	{
	}

	private bool InitSkillList_Daily()
	{
		return false;
	}

	private void resetDailyWeight()
	{
	}

	private void caculateDailyWeight(Skill_slotin item, int weight)
	{
	}

	public virtual List<int> GetSkill_Daily(int num = 9)
	{
		return null;
	}

	protected virtual void remove_skill_weight_Daily(int skillid)
	{
	}

	protected virtual void remove_magicbook_skill_weight_daily(int skillid)
	{
	}

	public virtual List<int> GetFreshSkill_Daily(List<int> list, int num = 9)
	{
		return null;
	}

	public virtual List<int> GetMagicBookSkill_Daily(int num = 9)
	{
		return null;
	}

	private int GetRandomSkill_Daily()
	{
		return 0;
	}

	private int GetTableRandomSkill_Daily()
	{
		return 0;
	}

	protected virtual void InitSkillList_Daily130()
	{
	}

	private void AddSkillToRemoveSet_Daily130(int skillId)
	{
	}

	public virtual List<int> GetSkill_Daily130(int num = 9)
	{
		return null;
	}

	protected virtual void remove_skill_weight_Daily130(int skillid)
	{
	}

	public virtual List<int> GetFreshDaily130Skill(List<int> list, int num = 9)
	{
		return null;
	}

	protected virtual void InitSkillList_Dungeon()
	{
	}

	private void AddSkillToRemoveSet_Dungeon(int skillId)
	{
	}

	public virtual List<int> GetSkill_Dungeon(int num = 9)
	{
		return null;
	}

	protected virtual void remove_skill_weight_Dungeon(int skillid)
	{
	}

	public virtual List<int> GetFreshDungeonSkill(List<int> list, int num = 9)
	{
		return null;
	}

	protected virtual void InitSkillList_Endless()
	{
	}

	public virtual List<int> GetSkill_Endless(int num = 9)
	{
		return null;
	}

	public virtual List<int> GetMagicBookSkill_Endless(int num = 9)
	{
		return null;
	}

	public virtual List<int> GetFreshSkill_Endless(List<int> list, int num = 9)
	{
		return null;
	}

	protected virtual void remove_skill_weight_Endless(int skillid)
	{
	}

	protected virtual void remove_magicbook_skill_weight_Endless(int skillid)
	{
	}

	private void AddSkillToRemoveSet_Endless(int skillId)
	{
	}

	protected virtual void InitSkillList_Maze()
	{
	}

	private void resetMazeWeight()
	{
	}

	private void caculateMazeWeight(Skill_slotin item)
	{
	}

	private void AddSkillToRemoveSet_Maze(int skillId)
	{
	}

	public virtual List<int> GetSkill_Maze(int num = 9)
	{
		return null;
	}

	protected virtual void remove_skill_weight_Maze(int skillid)
	{
	}

	protected virtual void remove_magicbook_skill_weight_maze(int skillid)
	{
	}

	public virtual List<int> GetFreshSkill_Maze(List<int> list, int num = 9)
	{
		return null;
	}

	public virtual List<int> GetMagicBookSkill_Maze(int num = 9)
	{
		return null;
	}

	public void InitSkillList_RoleReversal()
	{
	}

	public virtual List<int> GetSkill_RoleReversal(int num = 9)
	{
		return null;
	}

	protected virtual void remove_skill_weight_RoleReversal(int skillid)
	{
	}

	private void AddSkillToRemoveSet_RoleReversal(int skillId)
	{
	}

	protected virtual void InitSkillList_Survival()
	{
	}

	public virtual List<int> GetSkill_Survival(int num = 9)
	{
		return null;
	}

	public virtual List<int> GetMagicBookSkill_Survival(int num = 9)
	{
		return null;
	}

	public virtual List<int> GetFreshSkill_Survival(List<int> list, int num = 9)
	{
		return null;
	}

	protected virtual void remove_skill_weight_Survival(int skillid)
	{
	}

	protected virtual void remove_magicbook_skill_weight_Survival(int skillid)
	{
	}

	private void AddSkillToRemoveSet_Survival(int skillId)
	{
	}

	public void InitSkill_Season()
	{
	}

	public List<int> GetSkill_Season(int pickedSkillNum = 9)
	{
		return null;
	}

	private Dictionary<int, TowerLevelManager.SkillWeight> populateSkillWeightDictInSeason(int pickedSkillNum)
	{
		return null;
	}

	public List<int> GetSkill_SLG(int pickedSkillNum = 9, bool isAngel = false)
	{
		return null;
	}

	private List<Skill_slotin_slg> CheckSLGPreCondition(List<Skill_slotin_slg> all)
	{
		return null;
	}

	private Dictionary<int, TowerLevelManager.SkillWeight> populateSkillWeightDictInSLG(int pickedSkillNum, bool isAngel = false)
	{
		return null;
	}

	public void InitSkill_TD()
	{
	}

	public virtual List<int> GetSkill_TD(int pickedSkillNum = 9)
	{
		return null;
	}

	private Dictionary<int, TowerLevelManager.SkillWeight> populateSkillWeightDict(int pickedSkillNum)
	{
		return null;
	}

	private int GetTotalWeight(Dictionary<int, TowerLevelManager.SkillWeight> skillWeightDict)
	{
		return 0;
	}

	private List<int> pickSkillsFromSkillWeightDict(Dictionary<int, TowerLevelManager.SkillWeight> skillWeightDict, int allWeight, int pickedSkillNum)
	{
		return null;
	}

	private void InitSuperSkill(int skillid)
	{
	}

	protected virtual void DeInitSuperSkill()
	{
	}

	private void RemoveOldSuperSkill()
	{
	}

	private void OnDoubleClick()
	{
	}
}
