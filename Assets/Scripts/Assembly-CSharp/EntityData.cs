using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Dxx.Util;
using TableTool;
using UnityEngine;

public class EntityData
{
	[Flags]
	public enum AttackValueEnum : long
	{
		None = 0L,
		WholePets = 1L,
		Pvp = 2L,
		Pet_33001 = 4L,
		Pet_32001 = 8L,
		Pet_32003 = 0x10L,
		Pet_32004 = 0x20L,
		Pet_31001 = 0x40L,
		Pet_31002 = 0x80L,
		Pet_31003 = 0x100L,
		Pet_33002 = 0x200L,
		Pet_33003 = 0x400L,
		Pet_33004 = 0x800L,
		Pet_34001 = 0x1000L
	}

	private class StaticAddData
	{
		public string goodType;

		public long value;

		public bool bAdded;

		public void Update(EntityBase entity, bool move, long value)
		{
		}
	}

	private class MoveAddData
	{
		public string goodType;

		public long value;

		public bool bAdded;

		public void Update(EntityBase entity, bool move, long value)
		{
		}
	}

	public class BuffAttrData
	{
		public int count;

		public float attack;

		public float resistance;
	}

	public int CharID;

	protected EntityBase m_Entity;

	public int mDeadRecover;

	private long mHP2AttackSpeed;

	private long mHP2Miss;

	private long mHP2MoveSpeed;

	private long mHP2MissRate;

	private long mHP2HitReduce;

	private long mHP2BulletReduce;

	private long mHP2BodyScale;

	private long mHP2BodyHitReduce;

	private HashSet<int> m_setTmpImmunityBuffs;

	private int mHitCreate2;

	public float mHitCreate2Percent;

	private int mHitCreate2ThroughEnemy;

	private float mHitCreate2ThroghRatio;

	private int mFlyStoneCount;

	private int mFlyWaterCount;

	private int mBulletThroughCount;

	private int DizzyCount;

	private float mDizzyTime;

	[NonSerialized]
	public int ExtraSkillCount;

	private ObscuredLong _CurrentHP;

	[Header("最大血量")]
	protected ObscuredLong _MaxHP;

	[Header("能量")]
	public Action EnergyChangeAction;

	private ObscuredLong m_lCurrentEnergy;

	private ObscuredLong m_lMaxEnergy;

	public Action<long> ChargeChangeAction;

	private long m_lCurrentCharge;

	private long m_lFullGridCnt;

	private float m_fIdleTime;

	private float m_fMoveTime;

	private const float HpToAngerPercent = 0.01f;

	private const float AddAngerInterval = 1f;

	private const float CostAngerInterval = 0.1f;

	private float m_fAngerTime;

	private bool m_bBreakOut;

	private ObscuredLong m_lCurrentAnger;

	private RoomGenerateBase mRoomGenerateBase;

	private MapCreator mMapCreator;

	private bool m_bIsWaveRoom;

	private bool m_bTriggerInWaveRoom;

	private HitStruct Attack;

	public int InvincibleCount;

	[NonSerialized]
	public float BulletSpeed;

	private int MissHP_Count;

	private long mHP2Att_Fire_AddPercent;

	private long mHP2CounterattackPercent;

	private long mHP2CritValue;

	private long mHP2CritRate;

	private long mHP2Att_Thunder_AddPercent;

	private long mHP2MeteorNum;

	private long mHP2SphereFlashTime;

	private long mHP2DizzyBuffTimeUpPercent;

	private long mHP2RotateSpeedUpPercent;

	private float m_fLastSlopeTime;

	private WeightRandom<AttackCallData> mAttackMeteorite;

	public EntityAttributeBase attribute;

	private float mHP2AttackRatio;

	private int mThroughEnemy;

	private float mThroughRatio;

	private int mBulletLine;

	public BulletBase mLastBullet;

	private int mBulletSputter;

	private int mBulletSpeedHittedCount;

	private float mBulletSpeedHitted;

	private float mBulletSpeedHittedTime;

	private float mBulletSpeed1Ratio;

	private float mBulletSpeed1Range;

	private float mBulletSpeed;

	private float mAcceleratedBulletSpeed;

	public float HittedInterval;

	public int TurnTableCount;

	private int mBulletScaleCount;

	private int mOnlyDemonCount;

	private int mBabyResistBulletCount;

	private int mFrontShieldCount;

	private int mLight45;

	private StaticAddData mStaticReducePercent;

	private StaticAddData mStaticReduce;

	private MoveAddData mMoveAdd;

	public Dictionary<EElementType, BuffAttrData> mBuffAttrList;

	public Dictionary<EElementType, ElementDataClass> ElementData;

	public EElementType ArrowTrailType;

	public EElementType ArrowHeadType;

	private List<EntityBabyBase> mBabies;

	private List<EntityBabyBase> aliveBabyList;

	public List<string> mBabyAttributes;

	public List<string> mSelfAttributes;

	public List<int> mBabySkillIds;

	public List<int> mSelfSkillIds;

	protected WeightRandom<DeadCallData> mCallWeight;

	private ObscuredLong maxRockDragonShieldValue;

	private ObscuredLong curRockDragonShieldValue;

	private ObscuredLong maxForestDragonShieldValue;

	private ObscuredLong curForestDragonShieldValue;

	private ObscuredLong maxLightingShieldValue;

	private ObscuredLong curLightingShieldValue;

	private ProgressAniManager exp_data;

	private Dictionary<int, float> explist;

	public Action<float, int> SetCurrentExpLevelEvent;

	private ObscuredInt _MaxLevel;

	private ObscuredInt _clev;

	private ObscuredFloat _PlayerExp;

	private int meadowBattleLevel;

	public EntityMonsterAttribute_MB attributeMB;

	private bool bInitHeadShot;

	private bool bHeadShot;

	private Dictionary<EntityType, bool> m_dicHeadShots;

	private const int MAX_UMBRELLA_SHIELD_RESIST_COUNT = 3;

	protected int UmbrellaShieldResistCount;

	private float UmbrellaShieldResistPercent;

	private long Shield_Count;

	private long Shield_Max;

	protected ObscuredLong _Shield_CurrentHitValue;

	protected ObscuredLong _MaxShieldCurrentHitValue;

	private GameObject mShieldObj;

	private ObscuredLong maxWeaponShieldValue;

	private ObscuredLong curWeaponShieldValue;

	private ObscuredLong maxSSEquipShieldValue;

	private ObscuredLong curSSEquipShieldValue;

	private ObscuredLong maxLolaShieldValue;

	private ObscuredLong curLolaShieldValue;

	private bool isArtifactShieldCountChangeFromClear;

	private int _ArtifactShieldCount;

	public ObscuredLong CurPhoenixShieldValue;

	private float hittedSoundTime;

	private float mRebornStartTime;

	private AnimationCurve mRebornCurve;

	private const float mRebornAllTime = 1.5f;

	private float mTrapHitTime;

	public int[] TmpImmunityBuffs => null;

	public HashSet<int> TmpImmunityBuffsSet => null;

	public ObscuredLong InitMaxHP { get; private set; }

	public long MaxDeltaHPMaxByFood1001 => 0L;

	public ObscuredFloat moveSpeed => default;

	public int HitCreate2 => 0;

	public int HitCreate2ThroughEnemy => 0;

	public float HitCreate2ThroghRatio => 0f;

	public int BulletThroughCount => 0;

	public bool AllowChangeHP => false;

	public ObscuredLong CurrentHP
	{
		get
		{
			return default;
		}
		private set
		{
		}
	}

	public ObscuredLong MaxHP
	{
		get
		{
			return default;
		}
		private set
		{
		}
	}

	public ObscuredLong CurrentEnergy
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public ObscuredLong MaxEnergy => default;

	public long CurrentCharge
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public long FullGridCnt
	{
		get
		{
			return 0L;
		}
		private set
		{
		}
	}

	public bool BreakOutState => false;

	private RoomGenerateBase RoomGenerateBase => null;

	private MapCreator MapCreator => null;

	private bool CanIncreaseAnger => false;

	public long CurrentAnger
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public float CurrentAngerPercent => 0f;

	public bool AngerCanBreakOut => false;

	public bool IsExistShield => false;

	public bool ShowShieldShild { get; set; }

	public float HP2AttackRatio => 0f;

	public int ThroughEnemy => 0;

	public float ThroughRatio => 0f;

	public int BulletLineCount => 0;

	public int BulletSputter => 0;

	public bool CanUseMeleeBabyAsShield => false;

	public ObscuredFloat TotalDragonAdd { get; private set; }

	public ObscuredLong MaxRockDragonShieldValue => default;

	public ObscuredLong CurRockDragonShieldValue => default;

	public ObscuredLong MaxForestDragonShieldValue => default;

	public ObscuredLong CurForestDragonShieldValue => default;

	public ObscuredLong MaxLightingShieldValue => default;

	public ObscuredLong CurLightingShieldValue => default;

	public ObscuredInt MaxLevel
	{
		get
		{
			return default;
		}
		private set
		{
		}
	}

	public ObscuredInt Level
	{
		get
		{
			return default;
		}
		private set
		{
		}
	}

	public ObscuredFloat Exp
	{
		get
		{
			return default;
		}
		private set
		{
		}
	}

	public float MeadowBattleBulletAttack => 0f;

	public int MeadowBattleLevel => 0;

	public float MeadowBattleBodyAttack => 0f;

	public int MeadowBattleMaxHp => 0;

	public long BaseAttack => 0L;

	public long BaseHp => 0L;

	public bool HasUmbrellaShield => false;

	public long Shield_CurrentCount { get; private set; }

	public long Shield_CurrentHitValue
	{
		get
		{
			return 0L;
		}
		private set
		{
		}
	}

	public ObscuredLong MaxShieldCurrentHitValue
	{
		get
		{
			return default;
		}
		private set
		{
		}
	}

	public ObscuredLong MaxWeaponShieldValue => default;

	public ObscuredLong CurWeaponShieldValue => default;

	public ObscuredLong MaxSSEquipShieldValue => default;

	public ObscuredLong CurSSEquipShieldValue => default;

	public ObscuredLong MaxLolaShieldValue => default;

	public ObscuredLong CurLolaShieldValue => default;

	public int ArtifactShieldCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public void AddTmpImmunityBuffs(int[] ids)
	{
	}

	public void AddTmpImmunityBuff(int id)
	{
	}

	public void RemoveTmpImmunityBuffs(int[] ids)
	{
	}

	public void RemoveTmpImmunityBuff(int id)
	{
	}

	public void Init(EntityBase entity, int CharID)
	{
	}

	private void tryReadLevelUpLimited()
	{
	}

	public void InitAfter()
	{
	}

	public void DeInit()
	{
	}

	public void UseDeadRecover()
	{
	}

	public long ChangeHP(EntityBase entity, long HP, HitStruct data = null)
	{
		return 0L;
	}

	private void TryUpdateDaily130Damage(EntityBase source, long originalDeltaHP)
	{
	}

	private long ClampDaily130BossLethalDamageForTest(long deltaHp, long currentHp, EntityBase entity)
	{
		return 0L;
	}

	public void HP2Other(ref long mHp2Other, float HP2OtherValue, string attrName, int factor = 10000)
	{
	}

	private void CheckIfMeleeBabyAsShield(EntityBase entity)
	{
	}

	public long SurvivalDie()
	{
		return 0L;
	}

	public float GetHPPercent()
	{
		return 0f;
	}

	private void OnResetHp()
	{
	}

	public void ExcuteAttributes(Goods_goods.GoodData data)
	{
	}

	public void ExcuteAttributes(Goods_goods.GoodData data, object obj)
	{
	}

	public void ExcuteAttributes(string str)
	{
	}

	public virtual void ExcuteAttributeCommand(string attname, long attvalue, EntityAttributeBase.ValueType valueType = EntityAttributeBase.ValueType.Normal)
	{
	}

	public virtual void ExcuteAttributeCommand(string str)
	{
	}

	public float GetAddedExp(long value)
	{
		return 0f;
	}

	public void AddExpWrapper(long value)
	{
	}

	public void ExcuteAttributes(string name, long value, EntityAttributeBase.ValueType valueType = EntityAttributeBase.ValueType.Normal, object data = null)
	{
	}

	private float getGold(long value)
	{
		return 0f;
	}

	public void Modify_AllSpeed(long value)
	{
	}

	public void Modify_BulletSpeed(float value)
	{
	}

	public void Modify_HitCreate2(int count, float percent, int throughEnemy = 0, float ratio = 1f)
	{
	}

	public void Modify_FlyStone(int count)
	{
	}

	public bool IsFlyStone()
	{
		return false;
	}

	public void Modify_FlyWater(int count)
	{
	}

	public bool IsFlyWater()
	{
		return false;
	}

	public void Modify_BulletThroughCount(int count)
	{
	}

	public bool GetCanDizzy()
	{
		return false;
	}

	public bool CheckCanDizzy()
	{
		return false;
	}

	public void SetDizzyCount(int _count)
	{
	}

	public void UpdateDizzy(int count)
	{
	}

	public void DizzyHandler(int count)
	{
	}

	public bool IsDizzy()
	{
		return false;
	}

	public void SetMaxHP(float _value)
	{
	}

	public void SetCurrentHP(float _value)
	{
	}

	private void updateHp()
	{
	}

	public void UpdateEnergyMax()
	{
	}

	public void InitEnergy_BattleIn(long energy)
	{
	}

	public void ChangeEnergy(long energy)
	{
	}

	public void ResetEnergy()
	{
	}

	public void UpdateFullGridCnt(long cnt)
	{
	}

	public void UpdateChargeTime(float delta)
	{
	}

	private void CheckTime(long value, ref float time_1, ref float time_2)
	{
	}

	public void InitChcarge_BattleIn(long charge)
	{
	}

	public void ChangeCharge(long charge)
	{
	}

	public float GetChargeSpeedPercent()
	{
		return 0f;
	}

	private float getCrossbowChargeSpeedPercent()
	{
		return 0f;
	}

	private void OnChargeGridNumChange()
	{
	}

	private void OnStormEnergyNumChange(int currentValue)
	{
	}

	private void OnWaveRoomPlayerMove(Vector3 pos)
	{
	}

	private void OnGoToNextRoom(RoomGenerateBase.Room room)
	{
	}

	public void UpdateAnger(float delta)
	{
	}

	private void OnHpChanged(long change)
	{
	}

	public bool AngerBreakOut()
	{
		return false;
	}

	public void SuperSkillCost()
	{
	}

	public void SaveAnger()
	{
	}

	public void InitAnger()
	{
	}

	public bool GetInvincible()
	{
		return false;
	}

	public void Modify_Invincible(bool value)
	{
	}

	public void UpdateBodyScale()
	{
	}

	public void UpdateMonsterBodyScale()
	{
	}

	public void UpdateBodyScale(float deltaScale)
	{
	}

	private float GetBuffBulletValue(EntityBase source, BulletBase bullet, float value)
	{
		return 0f;
	}

	private float GetBuffValueInternal(EntityBase source, string name, float value)
	{
		return 0f;
	}

	public void ExcuteBuffs(EntityBase source, int buffid, string name, float value)
	{
	}

	public void AddDeBuff(EElementType element)
	{
	}

	public bool GetMissHP()
	{
		return false;
	}

	public void Modify_MissHP(bool value)
	{
	}

	private void OnCritEvent(EntityBase entity, long value)
	{
	}

	private float GetDeltaAttackValuePercent(AttackValueEnum atkValueEnum)
	{
		return 0f;
	}

	public long GetAttackBase()
	{
		return 0L;
	}

	public long GetAttackBase(int attack, AttackValueEnum atkValueEnum = AttackValueEnum.None)
	{
		return 0L;
	}

	public long GetAttack(int attack, int bulletId = -1, AttackValueEnum atkValueEnum = AttackValueEnum.None)
	{
		return 0L;
	}

	private bool GetMiss(HitStruct otherhs)
	{
		return false;
	}

	private void debugHit(long realhit)
	{
	}

	private void debugHitPercent(float percent)
	{
	}

	public HitStruct GetHurt(HitStruct otherhs)
	{
		return null;
	}

	private void CalCrit(HitStruct otherhs, ref float temphit)
	{
	}

	private void CalHitTo(HitStruct otherhs, ref float temphit)
	{
	}

	private float GetHitToBossExtraScale(HitStruct otherhs)
	{
		return 0f;
	}

	private void CalHitReduceByBodyType(EntityBase enemy, ref float temphit)
	{
	}

	private void CalBulletOrBodyHitFromEnemy(HitStruct otherhs, ref float temphit)
	{
	}

	private void CalBulletOrBodyHitFromHero(ref float temphit)
	{
	}

	private void printIllegalInfo(float percent, string attrName, string attrValue)
	{
	}

	private void CalHitReduce(HitStruct otherhs, ref float temphit)
	{
	}

	private void OnAttackCreate()
	{
	}

	private void AttackMeteorite()
	{
	}

	public void CreateMeteorite(AttackCallData data)
	{
	}

	public (Vector3, BulletSlopeBase) CreateMeteorBullet(int id, float dropRadius, float innerRadius, float innerHitRatio, float outRaidus, float outHitRatio, bool ignoreHitAction = false)
	{
		return default;
	}

	public (Vector3, BulletSlopeBase) CreateMeteorBullet(EntityBase target, int id, float dropRadius, float innerRadius, float innerHitRatio, float outRaidus, float outHitRatio, bool ignoreHitAction = false)
	{
		return default;
	}

	public BulletSlopeBase CreateMeteorBullet(int id, Vector3 pos, Vector3 startPos, float dropRadius, float innerRadius, float innerHitRatio, float outRaidus, float outHitRatio, float extraRadius, bool ignoreHitAction = false, Action callback = null)
	{
		return null;
	}

	public BulletBase CreateStarBullet(int bulletId, float dropRadius, float hitRatio)
	{
		return null;
	}

	public BulletBase CreateStarBullet(EntityBase target, int bulletId, float dropRadius, float hitRatio)
	{
		return null;
	}

	public BulletBase CreateStarBullet(int bulletId, Vector3 startPos, Vector3 targetPos, float hitRatio)
	{
		return null;
	}

	public void AddAttackMeteorite(AttackCallData data)
	{
	}

	public virtual List<EntityBase> GetTargets()
	{
		return null;
	}

	protected virtual void OnAttackMeteorite(AttackCallData data, Vector3 pos, float time)
	{
	}

	public void OnMeteoriteOverDistance(BulletSlopeBase bullet, bool ignoreHitAction = false)
	{
	}

	public BulletBase CreateFlySword(int bulletid, Vector3 startpos, float angle, float hitratio)
	{
		return null;
	}

	public Bullet3071 Create3071FlySword(int bulletid, Vector3 startpos, float angle, float hitratio, EntityBase target, float time, float minRatio, float decreaseRatio, float deltaAngle)
	{
		return null;
	}

	public void InitAttribute()
	{
	}

	public void Sync2MaxHP()
	{
	}

	private void OnHPUpdate(long beforemaxhp)
	{
	}

	public long GetProcessedHP(long value)
	{
		return 0L;
	}

	public long GetPureProcessedHP(long value)
	{
		return 0L;
	}

	public void Attribute_HP(long value)
	{
	}

	public void Attribute_PureHP(long value)
	{
	}

	public void Attribute_HPPercent(long value)
	{
	}

	public void Attribute_PureHPPercent(long value)
	{
	}

	public void Attribute_HPBasePercent(long value)
	{
	}

	public void Attribute_PureHPBasePercent(long value)
	{
	}

	public void Modify_HP2Attack(float value)
	{
	}

	public void ExcuteKillAdd(EntityBase entity, HitStruct hs)
	{
	}

	public void ExcuteHitAdd()
	{
	}

	public void ExcuteHeadShotAdd()
	{
	}

	public void ExcuteHitValueVampire(long hitvalue)
	{
	}

	public void Modify_ThroughEnemy(int count, float ratio)
	{
	}

	public int GetBodyHit()
	{
		return 0;
	}

	public void Modify_BulletLineCount(int count)
	{
	}

	public bool GetBulletLine()
	{
		return false;
	}

	public void Modify_ButtetSputter(int count)
	{
	}

	public void Modify_BulletSpeedHitted(int value, float ratio, float time)
	{
	}

	public float GetAcceleratedBulletSpeedRatio(BulletBase bullet)
	{
		return 0f;
	}

	public void Modify_BulletSpeedRatio(float value, float range)
	{
	}

	public float GetBulletSpeedRatio(BulletBase bullet)
	{
		return 0f;
	}

	public void Modify_HittedInterval(float value)
	{
	}

	public void Modify_TurnTableCount(int value)
	{
	}

	public void Modify_BulletScale(int count)
	{
	}

	public bool GetBulletScale()
	{
		return false;
	}

	public void Modify_OnlyDemon(int count)
	{
	}

	public bool GetOnlyDemon()
	{
		return false;
	}

	public void Modify_BabyResistBullet(int count)
	{
	}

	public bool GetBabyResistBullet()
	{
		return false;
	}

	public void Modify_FrontShield(int count)
	{
	}

	public bool GetFrontShield()
	{
		return false;
	}

	public void Modify_Light45(int count)
	{
	}

	public bool GetLight45()
	{
		return false;
	}

	public float GetHP2HPAddPercent()
	{
		return 0f;
	}

	private void OnMoveEvent(bool value)
	{
	}

	public int GetElementCount()
	{
		return 0;
	}

	public void AddElement(EElementType type)
	{
	}

	public void RemoveElement(EElementType type)
	{
	}

	public List<EElementType> GetAllElementType()
	{
		return null;
	}

	public EElementType GetTrailType()
	{
		return EElementType.eNone;
	}

	public EElementType GetHeadType()
	{
		return EElementType.eNone;
	}

	public List<EntityBabyBase> GetAllBabyList()
	{
		return null;
	}

	public void AddBaby(EntityBabyBase entity)
	{
	}

	public void Add2AliveBabyList(EntityBabyBase entity)
	{
	}

	public EntityBabyBase GetCurWorstMeleeBaby()
	{
		return null;
	}

	public void RemoveBaby(EntityBabyBase entity)
	{
	}

	public bool HasMeleeBaby()
	{
		return false;
	}

	public bool AllAreMeleeBaby()
	{
		return false;
	}

	public void AddBabyAttribute(string value)
	{
	}

	public void RemoveBabyAttribute(string value)
	{
	}

	public void ExcuteBabyAttributes(string name, long value)
	{
	}

	public void BabyUpdateAttributes()
	{
	}

	public void AddBabyOnHitListener(Action<EntityBase, EntityBase> action)
	{
	}

	public void RemoveBabyOnHitListener(Action<EntityBase, EntityBase> action)
	{
	}

	public void AddBabyOnCritListener(Action<EntityBase, long> action)
	{
	}

	public void RemoveBabyOnCritListener(Action<EntityBase, long> action)
	{
	}

	public void AddOnBabyHitListener(Action<EntityBase, HitStruct, HittedData> action)
	{
	}

	public void RemoveOnBabyHitListener(Action<EntityBase, HitStruct, HittedData> action)
	{
	}

	public void AddOnBabyKillListener(Action<EntityBase, Vector3, HitStruct> action)
	{
	}

	public void RemoveOnBabyKillListener(Action<EntityBase, Vector3, HitStruct> action)
	{
	}

	public void AddBabyLearnSkillId(int skillid, bool showSkillName = false)
	{
	}

	public void RemoveBabyLearnSkillId(int skillid)
	{
	}

	public void BabyLearnSkill(int skillid)
	{
	}

	public void BabyUpdateSkillIds()
	{
	}

	public void BabyResistBullet(bool value)
	{
	}

	public void AddBabyElement(EElementType element)
	{
	}

	public void RemoveBabyElement(EElementType element)
	{
	}

	public void AddBabyDebuff(int id)
	{
	}

	public void RemoveBabyDebuff(int id)
	{
	}

	public List<EntityBabyBase> GetBabies()
	{
		return null;
	}

	public void PlayBabyEffect(int id)
	{
	}

	public void BattleIn_RestoreBabySkill()
	{
	}

	protected void DoDeadCommand(EntityBase entity, HitStruct hs = null)
	{
	}

	private void OnMonsterDead(EntityBase entity)
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	public void Reborn()
	{
	}

	protected virtual void OnMonsterDeadCall(EntityBase entity)
	{
	}

	public void AddDeadCall(DeadCallData data)
	{
	}

	public void InitTotalDragonAdd()
	{
	}

	public void UpdateTotalDragonAdd(float delta)
	{
	}

	public float GetNormalizedDragonAdd()
	{
		return 0f;
	}

	public void InitDragonShield(long value)
	{
	}

	public void ClearDragonShield()
	{
	}

	public long GetRockDragonShieldHitValue(long value)
	{
		return 0L;
	}

	public void UpdateCurRockDragonShieldValue(long deltaValue)
	{
	}

	private void updateDragonHp()
	{
	}

	public void InitForestDragonShield(long value)
	{
	}

	public void ClearForestDragonShield()
	{
	}

	public long GetForestDragonShieldHitValue(long value)
	{
		return 0L;
	}

	public void UpdateCurForestDragonShieldValue(long deltaValue)
	{
	}

	private void updateForestDragonHp()
	{
	}

	public void InitLightingShield(long value)
	{
	}

	public void ClearLightingShield()
	{
	}

	public long GetLightingShieldHitValue(long value)
	{
		return 0L;
	}

	public void UpdateCurLightingShieldValue(long deltaValue)
	{
	}

	private void UpdateLightingHp()
	{
	}

	public void InitExp()
	{
	}

	private void UpdateExp()
	{
	}

	public void SyncExp()
	{
	}

	public void SetExp(float value)
	{
	}

	public void AddExp(float exp)
	{
	}

	public float GetCurrentExp()
	{
		return 0f;
	}

	public bool IsMaxLevel()
	{
		return false;
	}

	public void SetCurrentExpLevel(float exp, int level)
	{
	}

	public void DeinitExp()
	{
	}

	public void SetMeadowBattleLevel(int level)
	{
	}

	public void InitMBAttribute()
	{
	}

	public bool GetHeadShot(EntityBase source, HitStruct data)
	{
		return false;
	}

	public bool GetSkinHeadShot(EntityBase source)
	{
		return false;
	}

	public void IncreaseUmbrellaShieldResistCount()
	{
	}

	public void ResetUmbrellaShieldResistCount()
	{
	}

	public void DeactivateUmbrellaShield()
	{
	}

	public void EnableUmbrellaShield(bool value, HitStruct hitStruct = null)
	{
	}

	public long GetUmbrellaShieldHitValue(long value)
	{
		return 0L;
	}

	public long GetOverallShieldHitValue(long real_hit)
	{
		return 0L;
	}

	public void UpdateShieldMax(long max)
	{
	}

	public void UpdateDeltaShieldMax(long addDelta)
	{
	}

	public void ResetShieldMaxOnly()
	{
	}

	public void AddShieldCount(long count, bool showCountUI = true)
	{
	}

	public void AddShieldCountAction(Action<long> action)
	{
	}

	public void RemoveShieldCountAction(Action<long> action)
	{
	}

	public void ResetShieldCount()
	{
	}

	public bool GetCanShieldCount()
	{
		return false;
	}

	private void UpdateShieldCount(bool showCountUI = true)
	{
	}

	private void DoUpdateShiedUI(bool showCountUI = true)
	{
	}

	public void UpdateShieldValueChange(long change)
	{
	}

	private void UpdateShieldValue()
	{
	}

	private void InitEnergy()
	{
	}

	public void ResetShieldHitValue()
	{
	}

	public long GetShieldHitValue(long value)
	{
		return 0L;
	}

	private void OnShieldObjUpdate()
	{
	}

	public void InitWeaponShield(long value)
	{
	}

	public void ClearWeaponShield()
	{
	}

	public long GetWeaponShieldHitValue(long value)
	{
		return 0L;
	}

	public void UpdateCurWeaponShieldValue(long deltaValue)
	{
	}

	private void UpdateWeaponHp()
	{
	}

	public void InitSSEquipShield(long value, long maxValue)
	{
	}

	public void ClearSSEquipShield()
	{
	}

	public long GetSSEquipShieldHitValue(long value)
	{
		return 0L;
	}

	public void UpdateCurSSEquipShieldValue(long deltaValue)
	{
	}

	private void UpdateSSEquipHp()
	{
	}

	public void InitLolaShield(long value)
	{
	}

	public void ClearLolaShield()
	{
	}

	public long GetLolaShieldHitValue(long value)
	{
		return 0L;
	}

	public void UpdateCurLolaShieldValue(long deltaValue)
	{
	}

	private void UpdateLolaHp()
	{
	}

	public void SetArtifactShieldCount(int count)
	{
	}

	public void AddArtifactShieldCount(int delta)
	{
	}

	public bool ArtifactShieldTryResistOnceDmg()
	{
		return false;
	}

	public void ClearArtifactShieldCount()
	{
	}

	private void UpdateClearArtifactShieldUI()
	{
	}

	public void InitPhoenixShield(long value)
	{
	}

	public void AddPhoenixShield(long value)
	{
	}

	public void ClearPhoenixShield()
	{
	}

	public long GetPhoenixShieldHitValue(long value)
	{
		return 0L;
	}

	private void UpdateCurPhoenixShieldValue(long deltaValue)
	{
	}

	private void UpdatePhoenixShieldHp()
	{
	}

	public bool GetPlayHittedSound()
	{
		return false;
	}

	private void RebornUpdate()
	{
	}

	private void OnRebornUpdate(float delta)
	{
	}

	public bool GetCanTrapHit()
	{
		return false;
	}
}
