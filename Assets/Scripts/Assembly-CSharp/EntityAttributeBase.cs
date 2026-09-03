using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TableTool;

public class EntityAttributeBase : GameDataBase
{
	public class ValueBase
	{
		private ObscuredLong mValueConstructor;

		private ObscuredLong mValuePercentConstructor;

		private ObscuredLong mValueCount;

		private ObscuredLong mValuePercent;

		private ObscuredLong mValueOutside;

		private ObscuredLong mValueOutsidePercent;

		protected ObscuredLong mValue;

		public long ValueLong => 0L;

		public long ValueCount => 0L;

		public long ValuePercent => 0L;

		public long Value => 0L;

		public bool Enable => false;

		public ValueBase()
		{
		}

		public ValueBase(long count)
		{
		}

		public ValueBase(long count, long percent)
		{
		}

		protected virtual long OnGetValue()
		{
			return 0L;
		}

		public void InitValueCount(long count)
		{
		}

		public void UpdateValueCount(long count)
		{
		}

		public void UpdateValueOutside(long count)
		{
		}

		public void UpdateValueOutsidePercent(long count)
		{
		}

		public void UpdateValuePercent(long percent)
		{
		}

		protected void UpdateValue()
		{
		}

		public void UpdateFinalResult(long deltaValue)
		{
		}

		protected virtual long OnGetValuePercent(ObscuredLong value)
		{
			return 0L;
		}

		protected virtual void OnUpdateValue()
		{
		}

		public virtual void Reset()
		{
		}
	}

	public class ValueFloatBase
	{
		public ObscuredString name;

		private ObscuredLong mValueConstructor;

		private ObscuredLong mValuePercentConstructor;

		private ObscuredLong mValueCountInit;

		private ObscuredLong mValueCount;

		private ObscuredLong mValuePercent;

		private ObscuredLong? mValueMin;

		private ObscuredLong? mValueMax;

		private ObscuredFloat _Value;

		public long ValueLong => 0L;

		public long ValueCount => 0L;

		public long ValuePercent => 0L;

		public float Value
		{
			get
			{
				return 0f;
			}
			private set
			{
			}
		}

		public ValueFloatBase(string name)
		{
		}

		public ValueFloatBase()
		{
		}

		public ValueFloatBase(long count)
		{
		}

		public ValueFloatBase(long count, long percent)
		{
		}

		public void InitValueCount(long count)
		{
		}

		public void InitValuePercent(long percent)
		{
		}

		public void InitValue(long count, long percent)
		{
		}

		public void UpdateValueCount(long count)
		{
		}

		public void UpdateValuePercent(long percent, ValueType type = ValueType.Normal)
		{
		}

		public void UpdateValueMax(long value)
		{
		}

		public void UpdateValueMin(long value)
		{
		}

		private void UpdateValue()
		{
		}

		protected virtual long OnGetValuePercent(ObscuredLong percent)
		{
			return 0L;
		}

		public virtual void Reset()
		{
		}
	}

	public class ValueMult
	{
		private ObscuredLong mValueConstructor;

		private ObscuredLong mValue;

		public float Value => 0f;

		public long ValueLong => 0L;

		public ValueMult()
		{
		}

		public ValueMult(long value)
		{
		}

		public void InitValue(long value)
		{
		}

		public void UpdateValue(long value)
		{
		}

		public void Reset()
		{
		}
	}

	public class ValueFloatReduce
	{
		public List<ObscuredLong> mList;

		private ObscuredLong mValueConstructor;

		public float Value { get; private set; }

		public ValueFloatReduce()
		{
		}

		public ValueFloatReduce(long value)
		{
		}

		public void InitValue(List<long> list)
		{
		}

		public void InitValue(List<ObscuredLong> list)
		{
		}

		public void UpdateValue(long value)
		{
		}

		private void UpdateValue()
		{
		}

		public virtual void Reset()
		{
		}
	}

	public class ValueTime : ValueBase
	{
		public new ObscuredFloat Value { get; private set; }

		public ValueTime()
		{
		}

		public ValueTime(long count)
		{
		}

		public ValueTime(long count, long percent)
		{
		}

		protected override void OnUpdateValue()
		{
		}

		public override void Reset()
		{
		}
	}

	public class ValueHeroBase
	{
		private EntityBase m_Entity;

		private Dictionary<int, ValueBase> m_dicValues;

		private int ID => 0;

		public long ValueLong => 0L;

		public long ValueCount => 0L;

		public long ValuePercent => 0L;

		public Dictionary<int, ValueBase> Values => null;

		public long Value => 0L;

		public bool Enable => false;

		public void SetEntity(EntityBase entity)
		{
		}

		public void InitValues(Dictionary<int, ValueBase> values)
		{
		}

		public virtual void Reset()
		{
		}

		public void InitValueCount(int charId, long count)
		{
		}

		public ValueBase GetValue(int charId)
		{
			return null;
		}

		public void UpdateValueCount(int charId, long count, string name)
		{
		}

		public void UpdateValuePercent(int charId, long percent, string name)
		{
		}
	}

	public class ValueHeroFloatBase
	{
		private EntityBase m_Entity;

		private Dictionary<int, ValueFloatBase> m_dicValues;

		private int ID => 0;

		public long ValueLong => 0L;

		public long ValueCount => 0L;

		public long ValuePercent => 0L;

		public Dictionary<int, ValueFloatBase> Values => null;

		public float Value => 0f;

		public void SetEntity(EntityBase entity)
		{
		}

		public virtual void Reset()
		{
		}

		public void InitValues(Dictionary<int, ValueFloatBase> values)
		{
		}

		public ValueFloatBase GetValue(int charId)
		{
			return null;
		}

		public void InitValueCount(int charId, long count)
		{
		}

		public void InitValuePercent(int charId, long percent)
		{
		}

		public void InitValue(int charId, long count, long percent)
		{
		}

		public void UpdateValueCount(int charId, long count, string name)
		{
		}

		public void UpdateValuePercent(int charId, long percent, string name)
		{
		}
	}

	public class ValueMonsterFloatBase : ValueHeroFloatBase
	{
	}

	public class HPValueBase : ValueBase
	{
		private ObscuredLong mValuePercentUpPercent;

		public long ValuePercentUpPercent => 0L;

		public void UpdateValuePercentUpPercent(long percent)
		{
		}

		protected override long OnGetValuePercent(ObscuredLong value)
		{
			return 0L;
		}

		public override void Reset()
		{
		}
	}

	public class AttackSpeedValueBase : ValueFloatBase
	{
		private ObscuredLong mValuePercentUpPercent;

		public float PercentUpPercentValue => 0f;

		public AttackSpeedValueBase()
			: base(null)
		{
		}

		public AttackSpeedValueBase(long count, long percent)
			: base(null)
		{
		}

		public override void Reset()
		{
		}

		public void UpdateValuePercentUpPercent(long percent)
		{
		}

		protected override long OnGetValuePercent(ObscuredLong percent)
		{
			return 0L;
		}
	}

	public class Attack_ValueBase : AttackSpeedValueBase
	{
		private ObscuredLong mValueLowerLimit;

		private ObscuredLong mValueConstructor;

		public float LowerLimit => 0f;

		public Attack_ValueBase(float lowerLimit)
		{
		}

		protected override long OnGetValuePercent(ObscuredLong percent)
		{
			return 0L;
		}

		public override void Reset()
		{
		}
	}

	public class BulletForward : ValueBase
	{
		public BulletForward(long count)
		{
		}

		protected override long OnGetValue()
		{
			return 0L;
		}
	}

	public enum ValueType
	{
		Normal = 0,
		Max = 1,
		Min = 2
	}

	public enum PetAttrType
	{
		EnergyChargeSpeedPercent = 0,
		CritRate = 1,
		CritValue = 2,
		PlayerHPPercent = 3,
		PlayerAttackPercent = 4,
		AttackValuePercent = 5
	}

	public enum PetID
	{
		None = 0,
		Frog = 31001,
		Cat = 31002,
		Beetle = 31003,
		Turtle = 31004,
		Butterfly = 31005,
		Bear = 32001,
		Capybara = 32002,
		Hawk = 32003,
		Flamingo = 32004,
		Unicorn = 33001,
		PenguinKing = 33002,
		Phoenix = 33003,
		StarFox = 33004
	}

	public class ValueRange
	{
		private ObscuredInt mCountConstructor;

		private ObscuredInt mMinConstructor;

		private ObscuredInt mMaxConstructor;

		private ObscuredInt mDelta;

		private ObscuredInt count;

		private ObscuredInt min;

		private ObscuredInt max;

		private ObscuredInt delta;

		public int Count => 0;

		public int Min => 0;

		public int Max => 0;

		public bool Enable => false;

		public int Value => 0;

		public void UpdateCount(int count)
		{
		}

		public void UpdateMin(int min)
		{
		}

		public void UpdateMax(int max)
		{
		}

		public void UpdateDelta(int delta)
		{
		}

		public void InitValue(ValueRange data)
		{
		}

		public virtual void Reset()
		{
		}
	}

	public class ValueFloatRange
	{
		private ObscuredLong mCountConstructor;

		private ObscuredLong mMinConstructor;

		private ObscuredLong mMaxConstructor;

		private ObscuredLong count;

		private ObscuredLong min;

		private ObscuredLong max;

		public long Count => 0L;

		public float Min => 0f;

		public float Max => 0f;

		public bool Enable => false;

		public float Value => 0f;

		public void UpdateCount(long count)
		{
		}

		public void UpdateMin(long min)
		{
		}

		public void UpdateMax(long max)
		{
		}

		public void InitValue(ValueFloatRange data)
		{
		}

		public virtual void Reset()
		{
		}
	}

	private const int times = 100;

	private int m_nCharId;

	private int m_nSkinId;

	private EntityBase m_Entity;

	public Action<long> OnShieldNumChanged;

	public Action<long> OnShieldWithRaserNumChanged;

	public Action<long> OnGoldShieldNumChanged;

	[CompilerGenerated]
	private Action<float> m_OnShieldHitPercentChangedAction;

	public Action<long> OnHPUpdate;

	public Action<long> OnHPUpdateInHellMode;

	public Action<long> OnMPMaxUpdate;

	public Action OnColdTimePercentUpdate;

	public Action OnMoveSpeedUpdate;

	public Action<long> Shield_ValueAction;

	public Action<long> OnAttackUpdate;

	public Action OnEnergyUpdate;

	public Action<float> OnAttackValueBeforeChangeEvent;

	public Action<int> OnAttackSpeedBeforeChangeEvent;

	public Action<int> OnAttackSpeedPercentEvent;

	public Action<int> OnRotateSwordSpeedPercentEvent;

	public Action OnRotateShieldSpeedPercentEvent;

	public Action<int> OnCritRateBeforeChangeEvent;

	public Action<float> OnCritRateChangeEvent;

	public Action<int> OnCritValueBeforeChangeEvent;

	public Action OnEnergyMaxChangeEvent;

	public Action OnChargeGridNumChangeEvent;

	public Action OnChargeMaxChangeEvent;

	public Action<float> OnAllBabyInheritAttackBaseEvent;

	public Action<float> OnGainBuffTimeValueChangedEvent;

	public Action<float> OnEnemyDebuffTimeValueChangedEvent;

	public Action<float> OnEnemyDebuffIntervalValueChangedEvent;

	public Action<float> OnBulletScaleChangeEvent;

	[CompilerGenerated]
	private Action<long> m_OnRotateSickleNumChanged;

	private ValueBase _DeltaShieldHammerAliveTime;

	private ValueFloatBase _CallShieldHammerRate;

	private ValueFloatBase _ZeusThunderSpearHit2BossPercent;

	private ValueFloatBase _Equip12101_AttackPercent;

	private ValueFloatBase _Equip12101_HPDropPercent;

	private ValueFloatBase _Equip12102_AttackPercent;

	private ValueFloatBase _Equip12103_CritRate;

	private ValueFloatBase _PetAttackPercent;

	private ValueFloatBase _PetHPMaxPercent;

	private ValueFloatBase _WingHPMaxPercent;

	private ValueFloatBase _WingAttackPercent;

	private ValueFloatBase _ThunderSpearDamagePercent;

	private ValueBase _KillAddThunderlight;

	private ValueBase _ThunderSpearCanLight;

	private ValueFloatBase _MeleeHammerScalePercent;

	private ValueFloatBase _ThrowWeaponHitPercent;

	private ValueFloatBase _ThunderSpearAddHammerRate;

	private ValueFloatBase _ThunderSpearAddLightingRate;

	private ValueFloatBase _ML_Hit2HeroReducePercent;

	private ValueFloatBase _ML_HitByHeroPercent;

	public ValueFloatBase InkDragonBulletSpeedPercent;

	public ValueFloatBase ImmunityTrapHitRate;

	public ValueFloatBase ImmunityFromNearRate;

	public ValueFloatBase ImmunityFromFarRate;

	public ValueFloatBase ImmunityFromFlyRate;

	public ValueFloatBase ImmunityFromGroundRate;

	public ValueFloatBase ImmunityFromSoldierRate;

	public ValueFloatBase ImmunityFromBossRate;

	public ValueFloatBase ImmunityAttr8Percent;

	private const float MAX_IMMUNITY_RATE = 0.5f;

	public ValueBase DeltaWeaponGridCount;

	public ValueFloatBase DeltaWeaponGridCountPercent;

	public ValueFloatBase HitExplodeRate;

	public ValueFloatBase HitFireMeteorRate;

	public ValueFloatBase HitFireAeroliteRate;

	public ValueBase ThroughEnemy;

	public ValueBase MaxDivideLayer;

	public ValueFloatBase TriggerRateUpPercent;

	public ValueBase GlobalDeltaCount;

	public ValueBase HitToGiant;

	public ValueFloatBase HitToGiantPercent;

	public ValueFloatBase HitFromHumanoid;

	public ValueFloatBase HitFromHumanoidPercent;

	public ValueBase HitFromNonhumanoid;

	public ValueFloatBase HitFromNonhumanoidPercent;

	public ValueBase HitFromAnimal;

	public ValueFloatBase HitFromAnimalPercent;

	public ValueBase HitFromUndead;

	public ValueFloatBase HitFromUndeadPercent;

	public ValueBase HitFromMechanic;

	public ValueFloatBase HitFromMechanicPercent;

	public ValueBase HitFromCount4;

	public ValueFloatBase HitFromCount4Percent;

	public ValueFloatBase WuKongStickThicknessPercent;

	public ValueFloatBase MonsterBackRatioPercent;

	public ValueBase WuKongTwirl;

	public ValueBase WuKongHeadStick;

	public ValueBase WuKongStickBuff;

	public ValueFloatBase WuKongTwirlSpeedPercent;

	public ValueFloatBase WuKongMaxTwirlSpeedPercent;

	public ValueFloatBase RotateSwordScalePercent;

	public ValueFloatBase RotateBallScalePercent;

	public ValueFloatBase FlySwordScalePercent;

	public ValueFloatBase SlotOut_104_UpPercent;

	public ValueFloatBase SlotOut_106_UpPercent;

	public ValueFloatBase BraceletTimeUpPercent;

	public ValueFloatBase PartBody1820AttackValuePercent;

	public ValueFloatBase BabyHitToMonsterPercent;

	public ValueFloatBase TD_AttackRangePercent;

	public ValueFloatBase TD_AttackSpeedPercent;

	public ValueFloatBase TD_AttackPercent;

	public ValueBase TD_Attack;

	public ValueBase ShieldNum;

	public ValueBase ShieldWithRaserNum;

	public ValueBase GoldShieldNum;

	public ValueFloatBase ShieldBodyScalePercent;

	public ValueFloatBase ShieldHitPercent;

	public ValueFloatBase ShieldLaserHitPercent;

	public BulletForward Bullet_Forward;

	public ValueBase Bullet_Forward_Extra;

	public ValueFloatBase Bullet_Forward_Extra_Rate;

	public ValueFloatBase Bullet_Forward_Extra_Ratio;

	public ValueBase Bullet_Backward;

	public ValueBase Bullet_Side;

	public ValueBase Bullet_ForSide;

	public ValueBase Bullet_Continue;

	public ValueFloatBase BulletContinueHitAddPercent;

	public HPValueBase HPValue;

	public ValueFloatBase HealOverflowMaxPercent;

	public ValueFloatBase StrengthWeakTimePercent;

	public ValueBase HPAdd;

	public ValueFloatBase RebornHPMaxPercent;

	public ValueFloatBase RebornHPMaxAddPercent;

	public AttackSpeedValueBase HPAddPercent;

	public ValueBase AttackValue;

	public ValueFloatBase ForSideAttackPercent;

	public ValueFloatBase ForwardAttackPercent;

	public ValueBase DefenceValue;

	public HPValueBase MoveSpeed;

	public Attack_ValueBase Attack_Value;

	public ValueFloatBase Damage_Resistance;

	public ValueFloatBase Damage_Resistance_Value;

	public ValueFloatBase HitRate;

	public ValueFloatReduce MissRate;

	public ValueFloatBase HeartToDrumstickRate;

	public ValueFloatReduce BulletMissRate;

	private ValueFloatBase AngleRecoverLearnSkillRate;

	public AttackSpeedValueBase CritRate;

	public AttackSpeedValueBase BabyCritRate;

	public ValueFloatBase CritRateResist;

	public ValueFloatBase CritDefRate;

	public ValueFloatBase BlockRate;

	public AttackSpeedValueBase CritValue;

	public AttackSpeedValueBase BabyCritValue;

	public ValueFloatBase CritValueResist;

	public const int OriginCritValue = 2;

	public const float OriginCritDualValue = 0.5f;

	private ValueFloatBase _RebornAddElementCritRate;

	public ValueFloatBase ElementCritRate;

	public ValueFloatBase ElementCritValue;

	public AttackSpeedValueBase AttackSpeed;

	public ValueFloatBase AttackPrevSpeedPercent;

	public ValueFloatBase AttackEndSpeedPercent;

	public ValueFloatBase ExplosiveArrowHitPercent;

	public ValueBase ExplosiveArrowNum;

	public ValueFloatBase ExplosiveArrowBlastHitPercent;

	public ValueFloatBase ExplosiveArrowBlastRangePercent;

	public ValueFloatBase SamuraiHitPercent;

	public ValueFloatBase SamuraiBulletRangePercent;

	public ValueFloatBase Att_Fire_VampirePercent;

	public ValueFloatBase Att_Poison_VampirePercent;

	public ValueFloatBase Att_Thunder_VampirePercent;

	public ValueFloatBase Att_Black_VampirePercent;

	public ValueFloatBase Att_Ice_VampirePercent;

	public ValueFloatBase Att_Element_VampirePercent;

	public ValueBase HitVampire;

	public ValueFloatBase HitVampirePercent;

	public ValueFloatBase HitVampireAddPercent;

	public long HitVampireResult;

	public ValueBase KillVampire;

	public ValueFloatBase KillVampirePercent;

	public ValueFloatBase KillVampireAddPercent;

	public ValueBase KillBossVampire;

	public ValueFloatBase KillBossVampirePercent;

	public ValueBase KillMonsterVampire;

	public ValueFloatBase KillMonsterVampirePercent;

	public ValueFloatBase MeetDemonReduceRate;

	public ValueFloatBase AllVampireAddPercent;

	public long KillVampireResult;

	public ValueBase TrapDefCount;

	public ValueBase TrapHitImmunity;

	public ValueFloatBase TrapDef;

	public ValueBase BulletDef;

	public ValueFloatBase BulletDefPercent;

	public ValueFloatBase BulletReduceInGamePercent;

	public ValueFloatBase BulletImmunityPercent;

	public ValueBase BulletImmunity;

	public ValueFloatBase BulletHitToAllPercent;

	public ValueFloatBase BulletHitAddPercent;

	private ValueFloatBase _IgnoreBulletReducePercent;

	private ValueFloatBase _WholeEnemyRecoverHPPercent;

	public ValueFloatBase GachaEggRecoverHPPercent;

	public ValueFloatBase TigerHatHitReducePercent;

	public ValueFloatBase TigerShoeMoveSpeedPercent;

	public ValueFloatBase InkDragonIceRate;

	public ValueBase HitToPVPHero;

	public ValueFloatBase HitToPVPHeroPercent;

	public ValueFloatBase PVPAttackPercent;

	public ValueFloatBase BulletMeteorHitAddPercent;

	public ValueFloatBase HittedAttackPercent;

	public ValueFloatBase KillAttackPercent;

	public ValueFloatBase KillAttackSpeedPercent;

	public ValueFloatBase CritAttackSpeedPercent;

	public ValueFloatBase GetHPDropAttackPercent;

	public ValueFloatBase EnemyBulletsSpeedRatioIn3GridsPercent;

	public ValueFloatBase SelfBulletsSpeedRatioIn3GridsPercent;

	public ValueFloatBase RelicRebornRatePercent;

	public ValueFloatBase _CommonRebornRatePercent;

	public ValueFloatBase BisicAttributesUpPercent;

	public ValueFloatBase ShieldUpPercent;

	public ValueFloatBase AltarUpPercent;

	public ValueFloatBase HitFromPVPHeroPercent;

	public ValueFloatBase SSS_RelicBasicAttrUpPercent;

	public ValueFloatBase SS_RelicBasicAttrUpPercent;

	public ValueFloatBase S_RelicBasicAttrUpPercent;

	public ValueFloatBase A_RelicBasicAttrUpPercent;

	public ValueBase HitFromFly;

	public ValueFloatBase HitFromFlyPercent;

	public ValueFloatBase HitToFlyPercent;

	public ValueBase HitToFly;

	public ValueBase HitFromGround;

	public ValueFloatBase HitFromGroundPercent;

	public ValueBase HitToGround;

	public ValueFloatBase HitToGroundPercent;

	public ValueBase HitFromNear;

	public ValueFloatBase HitFromNearPercent;

	public ValueBase HitToNear;

	public ValueFloatBase HitToNearPercent;

	public ValueBase HitFromFar;

	public ValueFloatBase HitFromFarPercent;

	public ValueBase HitToFar;

	public ValueFloatBase HitToFarPercent;

	public ValueFloatBase HitFromBoss;

	public ValueBase HitReduceFromElite;

	public ValueFloatBase HitReduceFromElitePercent;

	public ValueBase HitReduceFromNormal;

	public ValueFloatBase HitReduceFromNormalPercent;

	public ValueBase HitReduceFromLarge;

	public ValueFloatBase HitReduceFromLargePercent;

	public ValueFloatBase HitToBossPercent;

	public ValueBase HitToBoss;

	public ValueFloatBase HitToFullHpPercent;

	public ValueBase HitToElite;

	public ValueFloatBase HitToElitePercent;

	public ValueBase HitToCommon;

	public ValueFloatBase HitToCommonPercent;

	public ValueFloatBase HitToFullHPMonsterExtraDmgPercent;

	public ValueBase HitToHumanoid;

	public ValueFloatBase HitToHumanoidPercent;

	public ValueBase HitToNonhumanoid;

	public ValueFloatBase HitToNonhumanoidPercent;

	public ValueBase HitToAnimal;

	public ValueFloatBase HitToAnimalPercent;

	public ValueBase HitToUndead;

	public ValueFloatBase HitToUndeadPercent;

	public ValueBase HitToMechanic;

	public ValueFloatBase HitToMechanicPercent;

	public ValueBase BodyHittedCount;

	public ValueFloatBase BodyHitted;

	private ValueFloatBase _IgnoreBodyHittedReducePercent;

	private ValueFloatBase _FirstBeHurtReduceDmgPercent;

	private ValueFloatBase _MoistBuffAddDmgPercent;

	public ValueFloatBase BodyHittedInGame;

	public ValueFloatBase HeadShot;

	public ValueFloatBase HeadShotRecoverHpRate;

	public ValueBase HeadShotRecoverHp;

	public ValueFloatBase HeadShotRecoverHpPercent;

	public ValueFloatBase HeadShotAttackPercent;

	public ValueBase ReboundHit;

	public ValueFloatBase ReboundTargetPercent;

	public ValueFloatBase CounterattackPercent;

	public ValueMult AttackModify;

	public ValueBase ExtraSkill;

	public AttackSpeedValueBase ExpGet;

	public ValueFloatBase EnergyGet;

	public ValueFloatBase BossEnergyGetAddPercent;

	public ValueFloatBase SoldierEnergyGetAddPercent;

	public ValueBase RebornCount;

	public ValueBase RebornHP;

	public ValueFloatBase RebornHPPercent;

	public ValueBase BodyHit;

	public ValueFloatBase Body_HitPercent;

	public ValueFloatBase HitBack;

	public ValueFloatBase BodyScale;

	public ValueFloatBase MonsterBodyScale;

	public ValueBase RotateSpeed;

	public ValueBase InvincibleTime_Buff1406;

	public ValueBase FirePathLevel;

	public ValueBase Skill1482Level;

	public ValueBase Skill1483Level;

	public ValueBase Skill1484Level;

	public ValueBase Skill1484ThunderNum;

	public ValueBase Skill1484ThunderRange;

	public ValueRange ArrowEject;

	public ValueBase ArrowEjectAbsoluteMax;

	public ValueBase ArrowTrack;

	public ValueRange ReboundWall;

	public ValueFloatBase ReboundWallHitPercent;

	public ValueFloatBase CritAddHP;

	public ValueFloatBase CritSuperRate;

	public ValueFloatBase CritSuperValue;

	public ValueFloatBase CritDualRate;

	public ValueFloatBase CritDualValue;

	public ValueFloatBase CritDualValueForGodSweep;

	public ValueFloatBase AngelR2Rate;

	public ValueFloatBase AngelR3Rate;

	public ValueFloatBase AngelR4Rate;

	public ValueFloatBase AngelRecoverAddPercent;

	public ValueFloatBase MonsterHP2CritRate;

	public ValueFloatBase HP2AttackSpeed;

	public ValueFloatBase HP2HPAddPercent;

	public ValueFloatBase HP2Miss;

	public ValueFloatBase HP2MoveSpeed;

	public ValueFloatBase HP2MissRate;

	public ValueFloatBase HP2HitReduce;

	public ValueFloatBase HP2BulletReduce;

	public ValueFloatBase HP2BodyScale;

	public ValueFloatBase HP2BodyHitReduce;

	public ValueFloatBase HP2Att_Fire_AddPercent;

	public ValueFloatBase HP2CounterattackPercent;

	public ValueFloatBase HP2CritValue;

	public ValueFloatBase HP2CritRate;

	public ValueFloatBase HP2Att_Thunder_AddPercent;

	public ValueBase HP2MeteorNum;

	private ValueFloatBase _HP2SphereFlashTimePercent;

	private ValueFloatBase _HP2DizzyBuffTimeUpPercent;

	private ValueFloatBase _HP2RotateSpeedUpPercent;

	private ValueBase _SphereFlashTime;

	private ValueFloatBase _SphereFlashTimePercent;

	private ValueFloatBase _SphereFlashDeltaTime;

	private ValueFloatBase _SphereFlashHitPercent;

	private ValueFloatBase _SphereFlashRadiusPercent;

	public ValueFloatBase AttackValueByDistancePercent;

	public ValueFloatBase AttackValueByDistanceMax;

	public ValueFloatBase BabyCountAttack;

	public ValueFloatBase BabyCountAttackSpeed;

	public ValueFloatBase StaticReducePercent;

	public ValueBase StaticReduce;

	public ValueFloatBase HeroUpPercent;

	public ValueBase RuneUp;

	public ValueBase KillBossShield;

	public ValueFloatBase KillBossShieldPercent;

	public ValueFloatBase KillMonsterLessHP;

	public ValueFloatBase KillMonsterLessHPRatio;

	public ValueBase DistanceAttackValueDis;

	public ValueFloatBase DistanceAttackValuePercent;

	public ValueFloatBase WeaponRoundBackAttackPercent;

	public ValueFloatBase WeaponRoundBackSpeedPercent;

	public ValueFloatBase ConsecutiveHitsAttackPercent;

	public ValueBase ConsecutiveHitsCount;

	public ValueFloatBase ConsecutiveHitsInterval;

	public ValueFloatBase LaserAttackPercent;

	public ValueBase LaserCount;

	public ValueFloatBase LaserInterval;

	public ValueFloatBase ConsecutiveLightAttackPercent;

	public ValueBase ConsecutiveLightCount;

	public ValueFloatBase ConsecutiveLightInterval;

	public ValueBase LightBulletCnt;

	public ValueBase LightHit;

	public ValueFloatBase LightHitPercent;

	public ValueBase LightReboundWall;

	public ValueBase LightEject;

	public ValueBase DeadLightHit;

	public ValueFloatBase DeadLightHitPercent;

	public ValueBase DeadLightReboundWall;

	public ValueFloatBase RotateBallSpeedPercent;

	public ValueBase RotateBallHit;

	public ValueFloatBase RotateBallHitPercent;

	public ValueBase RotateBallCrit;

	public ValueFloatBase AllRotateBallHitPercent;

	public ValueFloatRange RotateBallBackRatio;

	public ValueFloatBase RotateSwordSpeedPercent;

	public ValueFloatBase RotateSpeedUpPercent;

	public ValueFloatBase RotateShieldSpeedPercent;

	public ValueBase RotateSwordHit;

	public ValueFloatBase RotateSwordHitPercent;

	public ValueBase RotateSwordCrit;

	public ValueFloatBase AllRotateSwordHitPercent;

	public ValueBase FlySwordHit;

	public ValueFloatBase FlySwordHitPercent;

	public ValueFloatBase Att_HitByFlySword_AddPercent;

	public ValueFloatReduce CallFlySwordIntervalReducePercent;

	public ValueFloatReduce ChargeFlySwordTimeReducePercent;

	public ValueFloatBase FlySwordSpeedAddPercent;

	public ValueBase AllFlySwordPenetrate;

	public ValueFloatBase AllFlySwordHitPercent;

	public ValueBase MulanFlySwordCrit;

	public ValueFloatBase FlySwordVampirePercent;

	public ValueBase MeteorHit;

	public ValueFloatBase MeteorHitPercent;

	public ValueFloatBase Att_HitByMeteor_AddPercent;

	public ValueFloatBase MeteorSpeedAddPercent;

	public ValueFloatBase CallMeteorRate;

	public ValueFloatBase MeteorHitRate;

	public ValueFloatBase AllMeteorHitPercent;

	public ValueFloatBase DeadFrozeRangePercent;

	public ValueBase DeadFrozeHit;

	public ValueFloatBase DeadFrozeHitPercent;

	public ValueFloatBase DeadExploseRangePercent;

	public ValueBase DeadExploseHit;

	public ValueFloatBase DeadExploseHitPercent;

	public ValueFloatBase AllPartAddTimePercent;

	public ValueFloatBase AllPartHitPercent;

	public ValueFloatBase AllPartBodyScalePercent;

	public ValueFloatBase AllPartAttackSpeedPercent;

	public ValueFloatBase AllPartFinalHitPercent;

	public ValueFloatBase AllPartFinalAttackSpeedPercent;

	private ValueFloatBase _NewPlay127_BeHitCallPartBodyPercent;

	private ValueFloatBase _NewPlay127_HitCallPartBodyPercent;

	private ValueFloatBase _NewPlay127_CallDoublePartBodyPercent;

	private ValueFloatBase _NewPlay127_PartBodyDisappearDropHpPercent;

	public ValueBase PartHit;

	public ValueFloatBase PartHitPercent;

	public ValueFloatBase PartAttackSpeedPercent;

	public ValueFloatBase PartCritRate;

	public ValueFloatBase PartCritValue;

	public ValueFloatBase PartTimeAddPercent;

	public ValueFloatBase CallPlusOneRate;

	public ValueBase BonnieCallTimeAdd;

	public ValueFloatBase BatPartAttackSpeedPercent;

	public ValueBase BatPartHit;

	public ValueFloatBase BatPartHitPercent;

	public ValueFloatBase BatPartCritRate;

	public ValueFloatBase BatPartCritValue;

	public ValueFloatBase BatPartTimeAddPercent;

	public ValueFloatBase BatCallPlusOneRate;

	public ValueBase WolfhoundPartHit;

	public ValueFloatBase WolfhoundPartHitPercent;

	public ValueFloatBase WolfhoundPartCritRate;

	public ValueFloatBase WolfhoundPartCritValue;

	public ValueFloatBase WolfhoundPartTimeAddPercent;

	public ValueFloatBase WolfhoundPartCallPlusOneRate;

	public ValueBase SkullPartHit;

	public ValueFloatBase SkullPartHitPercent;

	public ValueFloatBase SkullPartCritRate;

	public ValueFloatBase SkullPartCritValue;

	public ValueFloatBase SkullPartTimeAddPercent;

	public ValueFloatBase SkullPartCallPlusOneRate;

	public ValueBase StarHit;

	public ValueFloatBase StarHitPercent;

	public ValueFloatBase Att_HitByStar_AddPercent;

	public ValueFloatBase StarSpeedAddPecent;

	public ValueBase StarNumAdd;

	public ValueFloatBase StarCallRate;

	public ValueFloatBase AllStarHitPercent;

	public ValueFloatBase MagicHPCrit;

	public ValueFloatBase HitValueVampirePercent;

	public ValueFloatBase HitToMonsterPercent;

	public ValueBase HitToMonster;

	public ValueFloatBase HitReducePercent;

	public ValueFloatBase SeniorHeroHitReducePercent;

	public ValueFloatReduce FinalHitReducePercent;

	public ValueFloatBase EvolveHitReducePercent;

	public ValueFloatBase EvolveHitPercent;

	public ValueBase ThroughWall;

	public ValueBase AllHitReduce;

	public ValueFloatBase AllHitRaisePercent;

	public ValueBase MeleeHit;

	public ValueFloatBase MeleeHitPercent;

	public ValueBase RangeHit;

	public ValueFloatBase RangeHitPercent;

	public ValueFloatBase ExtraHitFromHpPercent;

	public ValueFloatBase ExtraHitMaxPercent;

	public ValueBase FrontBodyHitReduce;

	public ValueBase BackBodyHitReduce;

	public ValueFloatBase FrontBodyHitReducePercent;

	public ValueFloatBase BackBodyHitReducePercent;

	public ValueBase FrontHitReduce;

	public ValueFloatBase GemsAttackAddPercent;

	public ValueFloatBase GemsFrontHittedReduceAddPercent;

	public ValueFloatBase GemsBulletReduceAddPercent;

	public ValueFloatBase GemsBodyHittedReduceAddPercent;

	public ValueFloatBase GemsHitReduceAddPercent;

	public ValueFloatBase GemsAddPercent;

	public ValueFloatBase GemsHPMaxAddPercent;

	public ValueFloatBase UP_Equip_WeaponPercent;

	public ValueFloatBase UP_Equip_ArmorPercent;

	public ValueFloatBase UP_Equip_Ornament1Percent;

	public ValueFloatBase UP_Equip_Ornament2Percent;

	public ValueFloatBase UP_Equip_Pet1Percent;

	public ValueFloatBase UP_Equip_Pet2Percent;

	public ValueFloatBase UP_Equip_TalismanPercent;

	public ValueFloatBase UP_Equip_BraceletPercent;

	public ValueFloatBase UP_Equip_MagicBookPercent;

	public ValueBase UP_GemLevel_Weapon;

	public ValueBase UP_GemLevel_Armor;

	public ValueBase UP_GemLevel_Ornament1;

	public ValueBase UP_GemLevel_Ornament2;

	public ValueBase UP_GemLevel_Pet1;

	public ValueBase UP_GemLevel_Pet2;

	public ValueBase UP_GemLevel_Talisman;

	public ValueBase UP_GemLevel_Bracelet;

	public ValueBase UP_GemLevel_MagicBook;

	public ValueFloatBase UP_Equip_PetPercent;

	public ValueFloatBase UP_Equip_OrnamentPercent;

	public ValueBase BackHitAdd;

	public ValueFloatBase BackHitAddPercent;

	public ValueBase BackHitReduce;

	public ValueFloatBase FrontHitReducePercent;

	public ValueFloatBase BackHitReducePercent;

	public ValueFloatBase HitReduceFromSoliderPercent;

	public ValueBase EnergyValue;

	public ValueFloatBase EnergyInitialPercent;

	public ValueFloatBase EnergyPercent;

	public ValueFloatBase EnergyReturn;

	public ValueFloatBase EnergyReturnRate;

	public ValueFloatBase EnergyMaxAddPercent;

	public ValueFloatBase BulletScalePercent;

	private ValueFloatBase _BulletScalePercent;

	public ValueFloatBase BulletSizePercent;

	public ValueFloatBase BackRatio;

	public ValueFloatBase ZoomInMoveSpeedPercent;

	public ValueFloatBase ZoomInBackRatioPercent;

	public ValueFloatBase ZoomOutMissRate;

	public ValueFloatBase ZoomOutMoveSpeedPercent;

	public ValueBase BloodthirstKillVampire;

	public ValueFloatBase BloodthirstKillVampireAddPercent;

	public ValueFloatBase BloodthirstKillVampirePercent;

	public ValueFloatBase HPDropCritRate;

	public ValueFloatBase HPDropCritValue;

	public ValueFloatBase HPDropAddEnergyPercent;

	public ValueFloatBase CureRatePercent;

	public ValueFloatBase HpFromHitPercent;

	public ValueFloatBase HpFromHitAddPercent;

	public ValueFloatBase SlowDownPercent;

	public ValueFloatBase SlowDownTimePercent;

	public ValueBase SlowDownRadius;

	public ValueFloatBase GainBuffTimePercent;

	public ValueFloatBase EnemyDebuffTimePercent;

	public ValueFloatBase EnemyDebuffIntervalPercent;

	public ValueBase UniqueAttackValue;

	public ValueFloatBase UniqueAttackValuePercent;

	public ValueBase UniqueIceAttackValue;

	public ValueBase UniqueTime;

	public ValueFloatBase UniqueTimePercent;

	public ValueBase UniqueBulletSide;

	public ValueBase UniqueBulletForward;

	public ValueBase UniqueBulletBackward;

	public ValueFloatBase UniqueAttackSpeedPercent;

	public ValueBase Unique_SkillNum;

	public ValueBase UniqueCritValue;

	public ValueFloatBase UniqueCritValuePercent;

	public ValueFloatBase UniquePartAttackPercent;

	public ValueFloatBase Unique_SlowDownPercent;

	public ValueBase Unique_SlowDownTime;

	public ValueBase Unique_KillVampire;

	public ValueFloatBase Unique_KillVampirePercent;

	public ValueBase Unique_MoveSpeed;

	public ValueFloatBase Unique_MoveSpeedPercent;

	public ValueBase Unique_HitToMonster;

	public ValueFloatBase Unique_HitToMonsterPercent;

	public ValueBase Unique_HitToBoss;

	public ValueFloatBase Unique_HitToBossPercent;

	public ValueFloatBase Unique_MissRatePercent;

	public ValueBase Unique_IceDebuffIdOfBulletForwardInMagicBook;

	public ValueBase Unique_ExtraBulletForward;

	public ValueFloatBase Unique_ExtraBulletForwardRatePercent;

	public ValueFloatBase Unique_ExtraBulletForwardValuePercent;

	public ValueBase IceDebuffIdOfBulletForwardInMagicBook;

	public ValueBase ExtraBulletForward;

	public ValueFloatBase ExtraBulletForwardRatePercent;

	public ValueFloatBase ExtraBulletForwardValuePercent;

	public ValueBase Shield;

	public ValueFloatBase JewelDrop;

	public ValueFloatBase EquipDrop;

	public ValueFloatBase WeaponDropPercent;

	public ValueFloatBase ArmorDropPercent;

	public ValueFloatBase RingDropPercent;

	public ValueFloatBase PetDropPercent;

	public ValueFloatBase BraceletDropPercent;

	public ValueFloatBase LocketDropPercent;

	public ValueFloatBase MagicBookDropPercent;

	public ValueFloatBase LocketLowHPAddPercent;

	public ValueFloatBase HpToEnergyPercent;

	public ValueFloatBase HpToEnergyAddPercent;

	public ValueFloatBase EnergyRecoverAddPercent;

	public ValueFloatBase WingSpeedUpPercent;

	public ValueFloatBase WingEffectUpPercent;

	public ValueFloatBase Bullet_ResistPercent;

	public ValueBase Att_Fire_Add;

	public AttackSpeedValueBase Att_Fire_AddPercent;

	public ValueFloatBase Att_HitByFire_AddPercent;

	public ValueFloatBase Att_HitByElement_AddPercent;

	public ValueFloatBase Att_Fire_TimePercent;

	public ValueFloatBase Att_Ice_TimePercent;

	public ValueFloatBase Att_Thunder_TimePercent;

	public ValueFloatBase Att_Poison_TimePercent;

	private ValueFloatBase _BeIce_TimePercent;

	public ValueFloatBase Att_Fire_AddTimePercent;

	public ValueBase Att_Fire_Resist;

	public ValueFloatBase Att_Fire_ResistPercent;

	public ValueBase Att_Poison_Add;

	public AttackSpeedValueBase Att_Poison_AddPercent;

	public ValueFloatBase Att_HitByPoison_AddPercent;

	public ValueFloatReduce Att_Poison_TimeReducePercent;

	public ValueBase Att_Poison_Resist;

	public ValueFloatBase Att_Poison_ResistPercent;

	public ValueBase Att_Thunder_Add;

	public AttackSpeedValueBase Att_Thunder_AddPercent;

	private ValueFloatBase _Att_HitByThunder_AddPercent;

	public ValueFloatBase Att_Thunder_RangeAddPercent;

	public ValueBase Att_Thunder_Resist;

	public ValueFloatBase Att_Thunder_ResistPercent;

	public ValueBase Att_Ice_Add;

	public AttackSpeedValueBase Att_Ice_AddPercent;

	private ValueFloatBase _Att_HitByIce_AddPercent;

	public ValueBase Att_Ice_Resist;

	public ValueFloatBase Att_Ice_ResistPercent;

	public ValueFloatBase DizzyChanceImmunityPercent;

	public ValueFloatBase DizzyBuffTimeUpPercent;

	public ValueBase Att_Black_Add;

	public AttackSpeedValueBase Att_Black_AddPercent;

	private ValueFloatBase _Att_HitByBlack_AddPercent;

	public ValueFloatBase Att_Black_RangeAddPercent;

	public ValueFloatReduce Att_Black_TimeReducePercent;

	public ValueBase Att_Black_Resist;

	public ValueFloatBase Att_Black_ResistPercent;

	public AttackSpeedValueBase Att_Element_AddPercent;

	public ValueFloatBase Att_Element_ResistPercent;

	public ValueFloatBase Att_Element_DurationAddPercent;

	public ValueFloatBase AddHitInFireBuffPercent;

	public ValueFloatBase Att_Element_DurationReducePercent;

	public ValueBase PiercingMoreHit;

	public ValueFloatBase CritRateByDistance;

	public ValueFloatBase CritRateByDistanceMax;

	public ValueFloatBase CritRateByDistanceMin;

	public ValueFloatBase AuroraContinuousHitAddPercent;

	public ValueBase ChargeGridNum;

	public ValueBase ChargeSpeedMove;

	public ValueBase ChargeSpeedStill;

	public ValueFloatBase ChargeSpeedPercent;

	public ValueFloatBase StaffChargeReduceTimePercent;

	public ValueFloatBase CrossbowChargeSpeedPercent;

	public ValueBase ChargeMax;

	public ValueFloatBase ChargeReducePercent;

	public ValueFloatBase ChargeAttackPercent;

	public ValueFloatBase ChargeBulletSpeedPercent;

	public ValueFloatBase ChargeBackRatioPercent;

	public ValueBase ChargeThroughEnemy;

	public ValueFloatBase ChargeThroughRatio;

	public ValueFloatBase RefineCrossBowTroughRatio;

	public ValueFloatBase ThroughAttenuationReducePercent;

	public ValueBase AngerMax;

	public ValueFloatBase AngerEruptThresholdPercent;

	public ValueBase AngerAdd;

	public ValueFloatBase AngerAddPercent;

	public ValueFloatBase HpToAngerPercent;

	public ValueFloatBase AngerAddByHpPercent;

	public ValueBase AngerCost;

	public ValueFloatBase AngerCostRaisePercent;

	public ValueFloatBase AngerCostReducePercent;

	public ValueBase WhirlWindCost;

	public ValueFloatBase WhirlWindCostReducePercent;

	public ValueFloatBase WhirlWindBodyPercent;

	public ValueFloatBase WhirlWindHitPercent;

	public ValueFloatBase Monster_ExpPercent;

	public ValueTime Monster_DizzyDelay;

	public ValueFloatBase Monster_HPDrop;

	public ValueBase Monster_HPDrop_1;

	public ValueFloatBase Monster_GoldDrop;

	public ValueFloatBase NormalGoldDropPercent;

	public ValueFloatBase HeroGoldDropPercent;

	public ValueFloatBase MonsterDeadStrengthenOthersRate;

	public ValueHeroBase HeroHpMax;

	public ValueHeroFloatBase HeroHpMaxPercent;

	public ValueHeroBase HeroAttackValue;

	public ValueHeroFloatBase HeroAttackValuePercent;

	public ValueMonsterFloatBase HitMonsterAddPercent;

	public ValueMonsterFloatBase HitReduceFromMonsterPercent;

	public ValueFloatBase BabyAttackWingmanPercent;

	public ValueFloatBase BabyAttackSpeedWingmanPercent;

	public ValueFloatBase BabyCritWingmanPercent;

	public ValueFloatBase BabyWithParentAttackPercent;

	public ValueFloatBase BabyPlus1WithParentAttackPercent;

	public ValueFloatBase BabyAddHitInFireBuffPercent;

	public ValueFloatBase BabyLearnSkillRate;

	public ValueFloatBase AllBabyInheritAttackBasePercent;

	private Dictionary<int, ValueFloatBase> m_dicSlotSkillRates;

	private Dictionary<int, ValueBase> m_dicAngelEventWeightAdds;

	private Dictionary<int, ValueFloatBase> m_dicAngelEventWeightAddPercents;

	private Dictionary<string, object> m_dicUniqueValues;

	public ValueBase SkeletonKingAttackDistance;

	public ValueBase RotateSickleNum;

	public ValueBase FlySawBladeNum;

	public ValueBase FlyArrowNum;

	public ValueBase FlySwordNum;

	public ValueBase SpearLaserNum;

	public ValueBase SpearBouncy;

	public ValueBase BoomerangNum;

	public ValueBase TornadoBouncy;

	public ValueBase ThunderNum;

	public ValueBase FlyBatNum;

	public ValueFloatBase FightBackRate;

	public ValueBase FightBackHit;

	public ValueFloatBase FightBackHitPercent;

	public ValueFloatBase FightBackStrengthPercent;

	public ValueFloatBase FightBackHitMonsterPercent;

	public ValueFloatBase FightBackHitBossPercent;

	public ValueFloatBase LightningRelease;

	public ValueBase LightningEjectCount;

	public ValueFloatBase LightningDmgAdd;

	public ValueBase HammerHitAddThunderlight;

	public ValueBase HammerChangeCount;

	public ValueBase ThunderSpearCommonCost;

	public ValueBase ThunderSpearAttackCost;

	public ValueBase ThunderlightLimit;

	public ValueBase LightningChargeStorm;

	public ValueBase ThunderSpearChargeStorm;

	public ValueBase StormLimit;

	public ValueBase HammerMeleeCostStorm;

	public ValueBase HammerFarCostStorm;

	public ValueBase LightningChargeOneCooling;

	private ValueFloatBase Shield_Rate;

	private ValueFloatBase _MonsterKingKingFlySwordDmgPercent;

	private ValueFloatBase _MonsterKingFlySwordReduceIntervalPercent;

	private ValueFloatBase _MonsterKingRingImproveAttackSpeedPercent;

	public ValueFloatBase HitToHellPercent;

	public ValueBase AttackInterval;

	public ValueBase AttackRange;

	private ValueFloatBase _NightmarePercent;

	public bool isKeysMode;

	public ValueFloatBase Level_CoinPercentValue;

	public ValueFloatBase Level_ScrollPercentValue;

	public ValueFloatBase Level_EnergyPercentValue;

	public ValueFloatBase Level_ExpPercentValue;

	public ValueFloatBase Level_WingPercentValue;

	public ValueFloatBase Level_PetFoodPercentValue;

	public ValueFloatBase Level_ImprintPercentValue;

	public ValueFloatBase Level_BiscuitPercentValue;

	public ValueFloatBase Level_ArtifactPercentValue;

	public ValueFloatBase Level_MagicStonePercentValue;

	public ValueFloatBase HeroStarAttrPercent;

	public ValueFloatBase HeroSkinUpPercent;

	public ValueFloatBase HeroAssistAttrPercent;

	public ValueFloatBase UP_EquipPercent;

	public ValueFloatBase SP1GemsAddPercent;

	public ValueFloatBase SP2GemsAddPercent;

	public ValueFloatBase Relics_BasePercent;

	public ValueFloatBase Relics_Red_StarPercent;

	public ValueFloatBase Relics_Orange_StarPercent;

	public ValueFloatBase Dragon_CDPercent;

	public ValueFloatBase Pet_BasePercent;

	private ValueFloatBase _Artifact_SkillCondNumReducePercent;

	private ValueFloatBase _Artifact_SkillDmgAddPercent;

	private ValueFloatBase _Artifact_SkillCritAddPercent;

	private ValueFloatBase _Artifact_SkillCritValueAddPercent;

	private ValueFloatBase _Artifact_101_SkillCondNumReduce;

	private ValueFloatBase _Artifact_201_SkillCondNumReduce;

	private ValueFloatBase _Artifact_301_SkillCondNumReduce;

	private ValueFloatBase _Artifact_302_SkillCondNumReduce;

	private ValueFloatBase _Artifact_303_SkillCondNumReduce;

	private ValueFloatBase _Artifact_101_SkillCondNumReducePercent;

	private ValueFloatBase _Artifact_201_SkillCondNumReducePercent;

	private ValueFloatBase _Artifact_301_SkillCondNumReducePercent;

	private ValueFloatBase _Artifact_302_SkillCondNumReducePercent;

	private ValueFloatBase _Artifact_303_SkillCondNumReducePercent;

	private ValueFloatBase _Artifact_101_SkillDmgAddPercent;

	private ValueFloatBase _Artifact_201_SkillDmgAddPercent;

	private ValueFloatBase _Artifact_301_SkillDmgAddPercent;

	private ValueFloatBase _Artifact_302_SkillDmgAddPercent;

	private ValueFloatBase _Artifact_303_SkillDmgAddPercent;

	private ValueFloatBase _Artifact_101_SkillCritAddPercent;

	private ValueFloatBase _Artifact_201_SkillCritAddPercent;

	private ValueFloatBase _Artifact_301_SkillCritAddPercent;

	private ValueFloatBase _Artifact_302_SkillCritAddPercent;

	private ValueFloatBase _Artifact_303_SkillCritAddPercent;

	private ValueFloatBase _Artifact_101_SkillCritValueAddPercent;

	private ValueFloatBase _Artifact_201_SkillCritValueAddPercent;

	private ValueFloatBase _Artifact_301_SkillCritValueAddPercent;

	private ValueFloatBase _Artifact_302_SkillCritValueAddPercent;

	private ValueFloatBase _Artifact_303_SkillCritValueAddPercent;

	private ValueFloatBase _Artifact_101_SkillLastTimeAddPercent;

	private ValueFloatBase _Artifact_101_SkillIntervalTimeReducePercent;

	private ValueFloatBase _Artifact_301_DoubleCreateProb;

	private ValueFloatBase Bullet_Divide_Rate;

	private ValueFloatBase Bullet_Divide_Hit_Percent;

	private ValueBase Bullet_Divide_Count;

	private ValueBase Bullet_Divide_Inherit;

	private ValueFloatBase RotateBall_Trigger_Meteorite_Rate;

	private ValueFloatBase RotateSword_Trigger_Meteor_Star;

	private ValueFloatBase Camp_Battle_Crystal_Percent;

	private ValueFloatBase Camp_Battle_Coins_Percent;

	private ValueBase LightThroughEnemy;

	private ValueBase PartBulletForward;

	private ValueBase PartBulletThroughEnemy;

	private ValueBase PartBulletThroughWall;

	private ValueFloatBase SideAttackPercent;

	private ValueFloatBase MonsterSlowDownIn3SecondsPercent;

	private ValueFloatBase MonsterHittedRaiseIn3SecondsPercent;

	private ValueFloatBase MonsterBodyHitReduceIn3SecondsPercent;

	private ValueFloatBase MonsterAttackReduceIn3SecondsPercent;

	private ValueFloatBase Camp_Battle_MonsterLV1_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV2_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV3_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV4_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV5_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV6_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV7_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV8_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV9_HP_Percent;

	private ValueFloatBase Camp_Battle_MonsterLV10_HP_Percent;

	private ValueFloatBase Camp_Battle_BossGuard_Hit_Percent;

	public ValueBase MagicMax;

	public ValueFloatBase MagicMaxPercent;

	public ValueBase MagicCost;

	public ValueFloatBase MagicCostPercent;

	public ValueBase MagicAttack;

	public ValueFloatBase MagicAttackPercent;

	public ValueBase ColdTime;

	public ValueFloatBase ColdTimePercent;

	public ValueFloatBase PublicColdTimePercent;

	public ValueFloatBase MagicDropPercent;

	public ValueBase MagicDrop;

	public ValueFloatBase HpToMagicPercent;

	public ValueFloatBase HpToMagicAddPercent;

	public ValueFloatBase MagicFreePercent;

	public ValueFloatBase MagicReleaseSpeedPercent;

	public ValueFloatBase MagicCostThresholdPercent;

	public ValueFloatBase MagicCostDiscountPercent;

	public ValueFloatBase MPAddPercent;

	public ValueBase MPAdd;

	public ValueFloatBase MPRecoverDefaultPercent;

	public ValueBase MagicCostReduce;

	public ValueFloatBase MagicCostReducePercent;

	public ValueFloatBase ReleaseDragonPercent;

	public ValueFloatBase Ice_DamagePercent;

	public ValueBase Ice_HitBuff1;

	public ValueBase Ice_HitBuff2;

	public ValueBase Ice_HitBuff3;

	public ValueFloatBase Ice_MagicDamagePercent;

	public ValueBase Ice_ResistBullets;

	public ValueBase Ice_MagicCost;

	public ValueBase Ice_Start_Selfbuff1;

	public ValueBase Ice_End_Selfbuff1;

	public ValueBase Ice_Start_Selfbuff2;

	public ValueBase Ice_End_Selfbuff2;

	public ValueBase Ice_Start_Selfbuff3;

	public ValueBase Ice_End_Selfbuff3;

	public ValueBase Ice_BreathTime;

	public ValueBase Ice_ReleaseTime;

	public ValueFloatBase Ice_BreathTimePercent;

	public ValueFloatBase Ice_BreathRangePercent;

	public ValueBase Ice_ColdTime;

	public ValueFloatBase Ice_ColdTimePercent;

	public float Ice_OriginalBreathTime;

	public ValueFloatBase Ice_MagicCostThresholdPercent;

	public ValueFloatBase Ice_MagicCostDiscountPercent;

	public ValueFloatBase Fire_DamagePercent;

	public ValueBase Fire_HitBuff1;

	public ValueBase Fire_HitBuff2;

	public ValueBase Fire_HitBuff3;

	public ValueFloatBase Fire_MagicDamagePercent;

	public ValueBase Fire_ResistBullets;

	public ValueBase Fire_MagicCost;

	public ValueBase Fire_Start_Selfbuff1;

	public ValueBase Fire_End_Selfbuff1;

	public ValueBase Fire_Start_Selfbuff2;

	public ValueBase Fire_End_Selfbuff2;

	public ValueBase Fire_Start_Selfbuff3;

	public ValueBase Fire_End_Selfbuff3;

	public ValueBase Fire_BreathTime;

	public ValueBase Fire_ReleaseTime;

	public ValueFloatBase Fire_BreathTimePercent;

	public ValueFloatBase Fire_BreathRangePercent;

	public ValueBase Fire_ColdTime;

	public ValueFloatBase Fire_ColdTimePercent;

	public float Fire_OriginalBreathTime;

	public ValueFloatBase Fire_MagicCostThresholdPercent;

	public ValueFloatBase Fire_MagicCostDiscountPercent;

	public ValueFloatBase Fire_BackRatioPercent;

	public ValueBase Fire_Penetrate;

	public ValueFloatBase Fire_PenetrateDamagePercent;

	public ValueFloatBase Fire_HitBombPercent;

	public ValueBase Fire_HitBombRange;

	public ValueFloatBase Fire_HitBombDamagePercent;

	public ValueFloatBase Thunder_DamagePercent;

	public ValueBase Thunder_HitBuff1;

	public ValueBase Thunder_HitBuff2;

	public ValueBase Thunder_HitBuff3;

	public ValueFloatBase Thunder_MagicDamagePercent;

	public ValueBase Thunder_ResistBullets;

	public ValueBase Thunder_MagicCost;

	public ValueBase Thunder_Start_Selfbuff1;

	public ValueBase Thunder_End_Selfbuff1;

	public ValueBase Thunder_Start_Selfbuff2;

	public ValueBase Thunder_End_Selfbuff2;

	public ValueBase Thunder_Start_Selfbuff3;

	public ValueBase Thunder_End_Selfbuff3;

	public ValueBase Thunder_BreathTime;

	public ValueBase Thunder_ReleaseTime;

	public ValueFloatBase Thunder_BreathTimePercent;

	public ValueFloatBase Thunder_BreathRangePercent;

	public ValueBase Thunder_ColdTime;

	public ValueFloatBase Thunder_ColdTimePercent;

	public float Thunder_OriginalBreathTime;

	public ValueFloatBase Thunder_MagicCostThresholdPercent;

	public ValueFloatBase Thunder_MagicCostDiscountPercent;

	public ValueBase Thunder_Distance;

	public ValueFloatBase Thunder_MultishotPercent;

	public ValueBase Thunder_Armor;

	public ValueBase Thunder_Armorbuff;

	public ValueBase Thunder_ArmorTime;

	public ValueFloatBase Thunder_ArmorDamagePercent;

	public ValueBase Thunder_ArmorDamage;

	public ValueBase Thunder_BallTime;

	public ValueFloatBase Thunder_BallDamagePercent;

	public ValueBase Thunder_BallDamage;

	public ValueFloatBase Poison_DamagePercent;

	public ValueBase Poison_HitBuff1;

	public ValueBase Poison_HitBuff2;

	public ValueBase Poison_HitBuff3;

	public ValueFloatBase Poison_MagicDamagePercent;

	public ValueBase Poison_ResistBullets;

	public ValueBase Poison_MagicCost;

	public ValueBase Poison_Start_Selfbuff1;

	public ValueBase Poison_End_Selfbuff1;

	public ValueBase Poison_Start_Selfbuff2;

	public ValueBase Poison_End_Selfbuff2;

	public ValueBase Poison_Start_Selfbuff3;

	public ValueBase Poison_End_Selfbuff3;

	public ValueBase Poison_BreathTime;

	public ValueBase Poison_ReleaseTime;

	public ValueFloatBase Poison_BreathTimePercent;

	public ValueFloatBase Poison_BreathRangePercent;

	public ValueBase Poison_ColdTime;

	public ValueFloatBase Poison_ColdTimePercent;

	public float Poison_OriginalBreathTime;

	public ValueFloatBase Poison_MagicCostThresholdPercent;

	public ValueFloatBase Poison_MagicCostDiscountPercent;

	public ValueFloatBase Poison_HitAddBuff_RatePercent;

	public ValueBase Poison_HitEnemy_SelfBuff;

	public ValueFloatBase Rock_DamagePercent;

	public ValueBase Rock_HitBuff1;

	public ValueBase Rock_HitBuff2;

	public ValueBase Rock_HitBuff3;

	public ValueFloatBase Rock_MagicDamagePercent;

	public ValueBase Rock_ResistBullets;

	public ValueBase Rock_MagicCost;

	public ValueBase Rock_Start_Selfbuff1;

	public ValueBase Rock_End_Selfbuff1;

	public ValueBase Rock_Start_Selfbuff2;

	public ValueBase Rock_End_Selfbuff2;

	public ValueBase Rock_Start_Selfbuff3;

	public ValueBase Rock_End_Selfbuff3;

	public ValueBase Rock_BreathTime;

	public ValueBase Rock_ReleaseTime;

	public ValueFloatBase Rock_BreathTimePercent;

	public ValueFloatBase Rock_BreathRangePercent;

	public ValueBase Rock_ColdTime;

	public ValueFloatBase Rock_ColdTimePercent;

	public float Rock_OriginalBreathTime;

	public ValueFloatBase Rock_MagicCostThresholdPercent;

	public ValueFloatBase Rock_MagicCostDiscountPercent;

	public ValueFloatBase Rock_ShieldPercent;

	public ValueFloatBase Rock_MagicShieldPercent;

	public ValueBase Rock_ShieldTime;

	public ValueFloatBase Rock_ShieldTimePercent;

	public ValueBase Rock_BulletSlow_Range;

	public ValueFloatBase Rock_BulletSlow_PercentPercent;

	public ValueBase Rock_BreakBuff1;

	public ValueBase Rock_BreakBuff2;

	public ValueBase Rock_BreakBuff3;

	public ValueFloatBase Iron_DamagePercent;

	public ValueBase Iron_HitBuff1;

	public ValueBase Iron_HitBuff2;

	public ValueBase Iron_HitBuff3;

	public ValueFloatBase Iron_MagicDamagePercent;

	public ValueBase Iron_ResistBullets;

	public ValueBase Iron_MagicCost;

	public ValueBase Iron_Start_Selfbuff1;

	public ValueBase Iron_End_Selfbuff1;

	public ValueBase Iron_Start_Selfbuff2;

	public ValueBase Iron_End_Selfbuff2;

	public ValueBase Iron_Start_Selfbuff3;

	public ValueBase Iron_End_Selfbuff3;

	public ValueBase Iron_BreathTime;

	public ValueBase Iron_ReleaseTime;

	public ValueFloatBase Iron_BreathTimePercent;

	public ValueFloatBase Iron_BreathRangePercent;

	public ValueBase Iron_ColdTime;

	public ValueFloatBase Iron_ColdTimePercent;

	public float Iron_OriginalBreathTime;

	public ValueFloatBase Iron_MagicCostThresholdPercent;

	public ValueFloatBase Iron_MagicCostDiscountPercent;

	public ValueFloatBase Iron_BulletKillVampirePercent;

	public ValueFloatBase Iron_Magic_DoublePercent;

	public ValueFloatBase Iron_Magic_DoubleDamagePercent;

	public ValueFloatBase Meteor_DamagePercent;

	public ValueBase Meteor_HitBuff1;

	public ValueBase Meteor_HitBuff2;

	public ValueBase Meteor_HitBuff3;

	public ValueFloatBase Meteor_MagicDamagePercent;

	public ValueBase Meteor_ResistBullets;

	public ValueBase Meteor_MagicCost;

	public ValueBase Meteor_Start_Selfbuff1;

	public ValueBase Meteor_End_Selfbuff1;

	public ValueBase Meteor_Start_Selfbuff2;

	public ValueBase Meteor_End_Selfbuff2;

	public ValueBase Meteor_Start_Selfbuff3;

	public ValueBase Meteor_End_Selfbuff3;

	public ValueBase Meteor_BreathTime;

	public ValueBase Meteor_ReleaseTime;

	public ValueFloatBase Meteor_BreathTimePercent;

	public ValueFloatBase Meteor_BreathRangePercent;

	public ValueBase Meteor_ColdTime;

	public ValueFloatBase Meteor_ColdTimePercent;

	public float Meteor_OriginalBreathTime;

	public ValueFloatBase Meteor_MagicCostThresholdPercent;

	public ValueFloatBase Meteor_MagicCostDiscountPercent;

	public ValueFloatBase Meteor_HitInsidePercent;

	public ValueBase Meteor_InsideRange;

	public ValueBase Meteor_OutsideRange;

	public ValueBase Meteor_HitToSelfBuff1;

	public ValueFloatBase Meteor_HitToSelfBuff1RatePercent;

	public ValueBase Meteor_HitToSelfBuff2;

	public ValueFloatBase Meteor_HitToSelfBuff2RatePercent;

	public ValueBase Meteor_MeteorBuff;

	public ValueFloatBase Meteor_HitMakeLight1Percent;

	public ValueFloatBase Meteor_HitMakeLight2Percent;

	public ValueFloatBase Meteor_HitMakeLight3Percent;

	public ValueFloatBase Meteor_MeteorCritValuePercent;

	public ValueFloatBase Meteor_MeteorWeaponSpeedPercent;

	public ValueFloatBase Virtual_DamagePercent;

	public ValueBase Virtual_HitBuff1;

	public ValueBase Virtual_HitBuff2;

	public ValueBase Virtual_HitBuff3;

	public ValueFloatBase Virtual_MagicDamagePercent;

	public ValueBase Virtual_ResistBullets;

	public ValueBase Virtual_MagicCost;

	public ValueBase Virtual_Start_Selfbuff1;

	public ValueBase Virtual_End_Selfbuff1;

	public ValueBase Virtual_Start_Selfbuff2;

	public ValueBase Virtual_End_Selfbuff2;

	public ValueBase Virtual_Start_Selfbuff3;

	public ValueBase Virtual_End_Selfbuff3;

	public ValueBase Virtual_BreathTime;

	public ValueBase Virtual_ReleaseTime;

	public ValueFloatBase Virtual_BreathTimePercent;

	public ValueFloatBase Virtual_BreathRangePercent;

	public ValueBase Virtual_ColdTime;

	public ValueFloatBase Virtual_ColdTimePercent;

	public float Virtual_OriginalBreathTime;

	public ValueFloatBase Virtual_MagicCostThresholdPercent;

	public ValueFloatBase Virtual_MagicCostDiscountPercent;

	public ValueBase Space_UpTime;

	public ValueBase Space_PortalNumMin;

	public ValueBase Space_PortalNumMax;

	public ValueBase Space_PortalRange;

	public ValueBase Space_PortalDistance;

	public ValueBase Space_PortalBuff1;

	public ValueFloatBase Space_PortalBuff1RatePercent;

	public ValueBase Space_PortalBuff2;

	public ValueFloatBase Space_PortalBuff2RatePercent;

	public ValueBase Space_PortalBuff3;

	public ValueFloatBase Space_PortalBuff3RatePercent;

	public ValueBase Space_SendBuffDistance;

	public ValueBase Space_SendBuff;

	public ValueBase Space_SendDeBuffDistance;

	public ValueBase Space_SendDeBuff;

	public ValueFloatBase Space_AttributePercent;

	public ValueFloatBase Skull_DamagePercent;

	public ValueBase Skull_HitBuff1;

	public ValueBase Skull_HitBuff2;

	public ValueBase Skull_HitBuff3;

	public ValueFloatBase Skull_MagicDamagePercent;

	public ValueBase Skull_ResistBullets;

	public ValueBase Skull_MagicCost;

	public ValueBase Skull_Start_Selfbuff1;

	public ValueBase Skull_End_Selfbuff1;

	public ValueBase Skull_Start_Selfbuff2;

	public ValueBase Skull_End_Selfbuff2;

	public ValueBase Skull_Start_Selfbuff3;

	public ValueBase Skull_End_Selfbuff3;

	public ValueBase Skull_BreathTime;

	public ValueBase Skull_ReleaseTime;

	public ValueFloatBase Skull_BreathTimePercent;

	public ValueFloatBase Skull_BreathRangePercent;

	public ValueBase Skull_ColdTime;

	public ValueFloatBase Skull_ColdTimePercent;

	public float Skull_OriginalBreathTime;

	public ValueFloatBase Skull_MagicCostThresholdPercent;

	public ValueFloatBase Skull_MagicCostDiscountPercent;

	public ValueBase Undead_SodiersLifeTime;

	public ValueBase Undead_SodiersNumMin;

	public ValueBase Undead_SodiersNumMax;

	public ValueBase Undead_SodierAttackBuff;

	public ValueFloatBase Undead_SodierAttackBuffRatePercent;

	public ValueBase Undead_SodierCanCrit;

	public ValueFloatBase Undead_SodierElitePercent;

	public ValueBase Undead_SodierEliteBuff;

	public ValueBase Undead_SodierCrazyBuff;

	public ValueFloatBase Undead_SodierExtraRatePercent;

	public ValueBase Undead_SodierExtraNumMin;

	public ValueBase Undead_SodierExtraNumMax;

	public ValueFloatBase Sword_DamagePercent;

	public ValueBase Sword_HitBuff1;

	public ValueBase Sword_HitBuff2;

	public ValueBase Sword_HitBuff3;

	public ValueFloatBase Sword_MagicDamagePercent;

	public ValueBase Sword_ResistBullets;

	public ValueBase Sword_MagicCost;

	public ValueBase Sword_Start_Selfbuff1;

	public ValueBase Sword_End_Selfbuff1;

	public ValueBase Sword_Start_Selfbuff2;

	public ValueBase Sword_End_Selfbuff2;

	public ValueBase Sword_Start_Selfbuff3;

	public ValueBase Sword_End_Selfbuff3;

	public ValueBase Sword_BreathTime;

	public ValueBase Sword_ReleaseTime;

	public ValueFloatBase Sword_BreathTimePercent;

	public ValueFloatBase Sword_BreathRangePercent;

	public ValueBase Sword_ColdTime;

	public ValueFloatBase Sword_ColdTimePercent;

	public float Sword_OriginalBreathTime;

	public ValueFloatBase Sword_MagicCostThresholdPercent;

	public ValueFloatBase Sword_MagicCostDiscountPercent;

	public ValueBase Sword_Num;

	public ValueFloatBase Sword_SpeedUpPercent;

	public ValueBase Sword_CanPenetrate;

	public ValueBase Sword_CanCrit;

	public ValueBase Sword_CanInherit;

	public ValueFloatBase Shadow_DamagePercent;

	public ValueBase Shadow_HitBuff1;

	public ValueBase Shadow_HitBuff2;

	public ValueBase Shadow_HitBuff3;

	public ValueFloatBase Shadow_MagicDamagePercent;

	public ValueBase Shadow_ResistBullets;

	public ValueBase Shadow_MagicCost;

	public ValueBase Shadow_Start_Selfbuff1;

	public ValueBase Shadow_End_Selfbuff1;

	public ValueBase Shadow_Start_Selfbuff2;

	public ValueBase Shadow_End_Selfbuff2;

	public ValueBase Shadow_Start_Selfbuff3;

	public ValueBase Shadow_End_Selfbuff3;

	public ValueBase Shadow_BreathTime;

	public ValueBase Shadow_ReleaseTime;

	public ValueFloatBase Shadow_BreathTimePercent;

	public ValueFloatBase Shadow_BreathRangePercent;

	public ValueBase Shadow_ColdTime;

	public ValueFloatBase Shadow_ColdTimePercent;

	public float Shadow_OriginalBreathTime;

	public ValueFloatBase Shadow_MagicCostThresholdPercent;

	public ValueFloatBase Shadow_MagicCostDiscountPercent;

	public ValueBase Dark_BombBuff;

	public ValueBase Dark_BombRange;

	public ValueBase Dark_BombBodyArgs;

	public ValueBase Dark_BombKillSelfBuff;

	public ValueFloatBase Dark_SpeedUpPercent;

	public ValueBase Dark_ShadowTime;

	public ValueBase Dark_ShadowBuff1;

	public ValueBase Dark_ShadowBuff2;

	public ValueBase Dark_ShadowBuff3;

	public ValueFloatBase Emerald_DamagePercent;

	public ValueBase Emerald_HitBuff1;

	public ValueBase Emerald_HitBuff2;

	public ValueBase Emerald_HitBuff3;

	public ValueFloatBase Emerald_MagicDamagePercent;

	public ValueBase Emerald_ResistBullets;

	public ValueBase Emerald_MagicCost;

	public ValueBase Emerald_Start_Selfbuff1;

	public ValueBase Emerald_End_Selfbuff1;

	public ValueBase Emerald_Start_Selfbuff2;

	public ValueBase Emerald_End_Selfbuff2;

	public ValueBase Emerald_Start_Selfbuff3;

	public ValueBase Emerald_End_Selfbuff3;

	public ValueBase Emerald_BreathTime;

	public ValueBase Emerald_ReleaseTime;

	public ValueFloatBase Emerald_BreathTimePercent;

	public ValueFloatBase Emerald_BreathRangePercent;

	public ValueBase Emerald_ColdTime;

	public ValueFloatBase Emerald_ColdTimePercent;

	public float Emerald_OriginalBreathTime;

	public ValueFloatBase Emerald_MagicCostThresholdPercent;

	public ValueFloatBase Emerald_MagicCostDiscountPercent;

	public ValueFloatBase Emerald_MagicCost_AddByUsedTimes;

	public ValueFloatBase Emerald_RecoverPercent;

	public ValueFloatBase Emerald_MagicRecoverPercent;

	public ValueFloatBase Emerald_RecoverRatePercent;

	public ValueBase Emerald_RotateSpeed;

	public ValueFloatBase Emerald_RotateSpeedPercent;

	public ValueFloatBase Emerald_EmeraldScalePercent;

	public ValueBase Emerald_Num;

	public ValueBase Emerald_Coin;

	public ValueBase Emerald_InjuriedTime;

	public ValueBase Emerald_InjuriedIntervalsTime;

	public ValueFloatBase Emerald_HitPercent;

	public ValueFloatBase Tyrant_DamagePercent;

	public ValueBase Tyrant_HitBuff1;

	public ValueBase Tyrant_HitBuff2;

	public ValueBase Tyrant_HitBuff3;

	public ValueFloatBase Tyrant_MagicDamagePercent;

	public ValueBase Tyrant_ResistBullets;

	public ValueBase Tyrant_MagicCost;

	public ValueBase Tyrant_Start_Selfbuff1;

	public ValueBase Tyrant_End_Selfbuff1;

	public ValueBase Tyrant_Start_Selfbuff2;

	public ValueBase Tyrant_End_Selfbuff2;

	public ValueBase Tyrant_Start_Selfbuff3;

	public ValueBase Tyrant_End_Selfbuff3;

	public ValueBase Tyrant_BreathTime;

	public ValueBase Tyrant_ReleaseTime;

	public ValueFloatBase Tyrant_BreathTimePercent;

	public ValueFloatBase Tyrant_BreathRangePercent;

	public ValueBase Tyrant_ColdTime;

	public ValueFloatBase Tyrant_ColdTimePercent;

	public float Tyrant_OriginalBreathTime;

	public ValueFloatBase Tyrant_MagicCostThresholdPercent;

	public ValueFloatBase Tyrant_MagicCostDiscountPercent;

	public ValueBase Bully_BuffTime;

	public ValueFloatBase Bully_MagicBuffTimePercent;

	public ValueBase Bully_SelfBuff;

	public ValueBase Bully_Range;

	public ValueFloatBase Bully_RangePercent;

	public ValueBase Bully_EnemyBuff;

	public ValueFloatBase Lava_DamagePercent;

	public ValueBase Lava_HitBuff1;

	public ValueBase Lava_HitBuff2;

	public ValueBase Lava_HitBuff3;

	public ValueFloatBase Lava_MagicDamagePercent;

	public ValueBase Lava_ResistBullets;

	public ValueBase Lava_MagicCost;

	public ValueBase Lava_Start_Selfbuff1;

	public ValueBase Lava_End_Selfbuff1;

	public ValueBase Lava_Start_Selfbuff2;

	public ValueBase Lava_End_Selfbuff2;

	public ValueBase Lava_Start_Selfbuff3;

	public ValueBase Lava_End_Selfbuff3;

	public ValueBase Lava_BreathTime;

	public ValueBase Lava_ReleaseTime;

	public ValueFloatBase Lava_BreathTimePercent;

	public ValueFloatBase Lava_BreathRangePercent;

	public ValueBase Lava_ColdTime;

	public ValueFloatBase Lava_ColdTimePercent;

	public float Lava_OriginalBreathTime;

	public ValueFloatBase Lava_MagicCostThresholdPercent;

	public ValueFloatBase Lava_MagicCostDiscountPercent;

	public ValueBase Lava_AttackTime;

	public ValueBase Lava_Division;

	public ValueBase Lava_AbsorbBuff;

	public ValueFloatBase Lava_CallRatePercent;

	public ValueBase Lava_CallTime;

	public ValueBase Lava_DragonBabyCrit;

	public ValueFloatBase Lava_DragonBabyElitePercent;

	public ValueFloatBase Lava_DragonBabyDamagePercent;

	public ValueFloatBase Lava_DragonBabyEliteDamagePercent;

	public ValueFloatBase Lava_DragonBabyEliteAttackSpeedPercent;

	public ValueFloatBase Forest_DamagePercent;

	public ValueBase Forest_HitBuff1;

	public ValueBase Forest_HitBuff2;

	public ValueBase Forest_HitBuff3;

	public ValueFloatBase Forest_MagicDamagePercent;

	public ValueBase Forest_ResistBullets;

	public ValueBase Forest_MagicCost;

	public ValueBase Forest_Start_Selfbuff1;

	public ValueBase Forest_End_Selfbuff1;

	public ValueBase Forest_Start_Selfbuff2;

	public ValueBase Forest_End_Selfbuff2;

	public ValueBase Forest_Start_Selfbuff3;

	public ValueBase Forest_End_Selfbuff3;

	public ValueBase Forest_BreathTime;

	public ValueBase Forest_ReleaseTime;

	public ValueFloatBase Forest_BreathTimePercent;

	public ValueFloatBase Forest_BreathRangePercent;

	public ValueBase Forest_ColdTime;

	public ValueFloatBase Forest_ColdTimePercent;

	public float Forest_OriginalBreathTime;

	public ValueFloatBase Forest_MagicCostThresholdPercent;

	public ValueFloatBase Forest_MagicCostDiscountPercent;

	public ValueBase Forest_StoneNumMin;

	public ValueBase Forest_StoneNumMax;

	public ValueBase Forest_StoneTime;

	public ValueBase Forest_StoneDistance;

	public ValueBase Forest_StoneBuff1;

	public ValueBase Forest_StoneBuff2;

	public ValueFloatBase Forest_StoneAttackPercent;

	public ValueBase Forest_StoneFightBackNum;

	public ValueFloatBase Forest_StoneFightBackDamagePercent;

	public ValueFloatBase Forest_StoneFightBackMaxPercent;

	public ValueFloatBase Forest_StoneRotateShieldRatePercent;

	public ValueFloatBase Forest_StoneDisapearShieldPercent;

	public ValueBase Forest_StoneDisapearShieldTime;

	public ValueFloatBase Forest_StoneDisapearRedRatePercent;

	public ValueFloatBase Fireworks_DamagePercent;

	public ValueBase Fireworks_HitBuff1;

	public ValueBase Fireworks_HitBuff2;

	public ValueBase Fireworks_HitBuff3;

	public ValueFloatBase Fireworks_MagicDamagePercent;

	public ValueBase Fireworks_ResistBullets;

	public ValueBase Fireworks_MagicCost;

	public ValueBase Fireworks_Start_Selfbuff1;

	public ValueBase Fireworks_End_Selfbuff1;

	public ValueBase Fireworks_Start_Selfbuff2;

	public ValueBase Fireworks_End_Selfbuff2;

	public ValueBase Fireworks_Start_Selfbuff3;

	public ValueBase Fireworks_End_Selfbuff3;

	public ValueBase Fireworks_BreathTime;

	public ValueBase Fireworks_ReleaseTime;

	public ValueFloatBase Fireworks_BreathTimePercent;

	public ValueFloatBase Fireworks_BreathRangePercent;

	public ValueBase Fireworks_ColdTime;

	public ValueFloatBase Fireworks_ColdTimePercent;

	public float Fireworks_OriginalBreathTime;

	public ValueFloatBase Fireworks_MagicCostThresholdPercent;

	public ValueFloatBase Fireworks_MagicCostDiscountPercent;

	public ValueBase Fireworks_FirecrackerBuff;

	public ValueBase Fireworks_ArrowEjectEnabled;

	public ValueFloatBase Fireworks_RecoverHPRate;

	public ValueBase Fireworks_MeteorNum;

	public ValueFloatBase RandomRatePercent;

	public ValueBase Fireworks_MeteorAsShield;

	public ValueBase Fireworks_CallDragon;

	public ValueFloatBase Fireworks_HitBossRate;

	public ValueFloatBase IceThunder_DamagePercent;

	public ValueBase IceThunder_HitBuff1;

	public ValueBase IceThunder_HitBuff2;

	public ValueBase IceThunder_HitBuff3;

	public ValueFloatBase IceThunder_MagicDamagePercent;

	public ValueBase IceThunder_ResistBullets;

	public ValueBase IceThunder_MagicCost;

	public ValueBase IceThunder_Start_Selfbuff1;

	public ValueBase IceThunder_End_Selfbuff1;

	public ValueBase IceThunder_Start_Selfbuff2;

	public ValueBase IceThunder_End_Selfbuff2;

	public ValueBase IceThunder_Start_Selfbuff3;

	public ValueBase IceThunder_End_Selfbuff3;

	public ValueBase IceThunder_BreathTime;

	public ValueBase IceThunder_ReleaseTime;

	public ValueFloatBase IceThunder_BreathTimePercent;

	public ValueFloatBase IceThunder_BreathRangePercent;

	public ValueBase IceThunder_ColdTime;

	public ValueFloatBase IceThunder_ColdTimePercent;

	public float IceThunder_OriginalBreathTime;

	public ValueFloatBase IceThunder_MagicCostThresholdPercent;

	public ValueFloatBase IceThunder_MagicCostDiscountPercent;

	public ValueBase IceThunder_ReleaseBuff;

	public ValueBase IceThunder_AttackCD;

	public ValueFloatBase IceThunder_Att_Thunder_Add_Modify;

	public ValueFloatBase IceThunder_Att_Element_Add_Modify;

	public ValueFloatBase IceThunder_Att_Ice_Add_Modify;

	public ValueFloatBase IceThunder_CritRateModify;

	public ValueFloatBase IceThunder_DefaultCritValue;

	public ValueFloatBase IceThunder_CritValueModify;

	public ValueFloatBase IceThunder_MinCritValue;

	public ValueBase IceThunder_CanCrit;

	public ValueBase IceThunder_CritBuff;

	public ValueFloatBase IceThunder_AttackBuffRate;

	public ValueBase IceThunder_AttackBuff;

	public ValueBase IceThunder_MinHPDrop;

	public ValueBase IceThunder_MaxHPDrop;

	public ValueFloatBase IceThunder_HPDropRate;

	public ValueFloatBase IceThunder_ReleaseDragonRate;

	public ValueBase IceThunder_HPDropCD;

	private static Dictionary<string, (int, PetAttrType)> _petKeyToAttrMap;

	private ValueFloatBase _BulletForwardAddDmgPercent;

	private ValueFloatBase _BulletForwardAddCountProb;

	private ValueBase _BulletForwardAddCount;

	private ValueFloatBase _BulletBackwardAddDmgPercent;

	private ValueFloatBase _BulletBackwardAddCountProb;

	private ValueBase _BulletBackwardAddCount;

	private ValueFloatBase _BulletSideAddDmgPercent;

	private ValueFloatBase _BulletSlopeAddDmgPercent;

	private ValueFloatBase _BulletContinueAddDmgPercent;

	private ValueFloatBase _BulletAxeAddDmgPercent;

	private ValueFloatBase _UP_Imprint_BaseAddPercent;

	private ValueFloatBase _BulletLightBeHitAddDmgPercent;

	private ValueFloatBase _NewPlay125_1001_AttackValuePercent;

	private ValueFloatBase _NewPlay125_1002_AttackValuePercent;

	private ValueFloatBase _NewPlay125_1003_AttackValuePercent;

	private ValueFloatBase _NewPlay125_1004_AttackValuePercent;

	private ValueFloatBase _NewPlay125_1005_AttackValuePercent;

	private ValueFloatBase _NewPlay125_1007_AttackValuePercent;

	private ValueFloatBase _NewPlay125_1001_AttackSpeedPercent;

	private ValueFloatBase _NewPlay125_1002_AttackSpeedPercent;

	private ValueFloatBase _NewPlay125_1003_AttackSpeedPercent;

	private ValueFloatBase _NewPlay125_1004_AttackSpeedPercent;

	private ValueFloatBase _NewPlay125_1005_AttackSpeedPercent;

	private ValueFloatBase _NewPlay125_1007_AttackSpeedPercent;

	private ValueFloatBase _NewPlay125_1004_AttackFullHPMultCritPercent;

	private ValueFloatBase _NewPlay125_1005_EnemyReduceHPFullAddCritPercent;

	private ValueFloatBase _NewPlay125_1006_BagCoinGetMult;

	private ValueFloatBase _NewPlay125_CoinDropMoreOneProb;

	private ValueFloatBase _NewPlay126_SkillReduceCDPercent;

	private ValueBase _NewPlay126_ExtraSlotCount;

	private ValueBase _NewPlay126_SlotMaxCount;

	private ValueFloatBase _NewPlay126_FirePathExistTimeAddPercent;

	private ValueFloatBase _NewPlay126_FirePathRadiusAddPercent;

	private ValueFloatBase _NewPlay126_1260301_SkillCDReduce;

	private ValueFloatBase _NewPlay126_1260302_SkillCDReduce;

	private ValueFloatBase _NewPlay126_1260303_SkillCDReduce;

	private Dictionary<int, Dictionary<PetAttrType, ValueFloatBase>> _petAttrMatrix;

	private ValueFloatBase _WholePets_EnergyChargeSpeedPercent;

	private ValueFloatBase _WholePets_HPToPetEnergyPercent;

	private ValueFloatBase _Pet_Type3_AliveTimePercent;

	private ValueFloatBase _WholePets_CritRate;

	private ValueFloatBase _WholePets_CritValue;

	private ValueFloatBase _AllPet_AliveTimePercent;

	private ValueFloatBase _AllBlackRangePercent;

	private ValueFloatBase _PenguinKingIceFlySwordSendTimeImprovePercent;

	private ValueFloatBase _PetBallSpeedPercent;

	private ValueFloatBase _WholePets_AttackValuePercent;

	private ValueFloatBase _PetFlamingoMainBulletHitBossDmgPercent;

	private static readonly Dictionary<int, string> PetIdToStrPrefix;

	private static readonly Dictionary<PetAttrType, string> PetAttrTypeToKeySuffix;

	public ValueBase TD1831_Atk;

	public ValueFloatBase TD1831_AtkPercent;

	public ValueFloatBase TD1831_AtkSpeedPercent;

	public ValueFloatBase TD1831_AtkRangePercent;

	public ValueFloatBase TD1831_BuildCostPercent;

	public ValueFloatBase TD1831_UpgradeCostPercent;

	public ValueBase TD1833_Atk;

	public ValueFloatBase TD1833_AtkPercent;

	public ValueFloatBase TD1833_AtkSpeedPercent;

	public ValueFloatBase TD1833_AtkRangePercent;

	public ValueFloatBase TD1833_BuildCostPercent;

	public ValueFloatBase TD1833_UpgradeCostPercent;

	public ValueBase TD1834_Atk;

	public ValueFloatBase TD1834_AtkPercent;

	public ValueFloatBase TD1834_AtkSpeedPercent;

	public ValueFloatBase TD1834_AtkRangePercent;

	public ValueFloatBase TD1834_BuildCostPercent;

	public ValueFloatBase TD1834_UpgradeCostPercent;

	public ValueBase TD1835_Atk;

	public ValueFloatBase TD1835_AtkPercent;

	public ValueFloatBase TD1835_AtkSpeedPercent;

	public ValueFloatBase TD1835_AtkRangePercent;

	public ValueFloatBase TD1835_BuildCostPercent;

	public ValueFloatBase TD1835_UpgradeCostPercent;

	public ValueBase TD1836_Atk;

	public ValueFloatBase TD1836_AtkPercent;

	public ValueFloatBase TD1836_AtkSpeedPercent;

	public ValueFloatBase TD1836_AtkRangePercent;

	public ValueFloatBase TD1836_BuildCostPercent;

	public ValueFloatBase TD1836_UpgradeCostPercent;

	public ValueBase TD1837_Atk;

	public ValueFloatBase TD1837_AtkPercent;

	public ValueFloatBase TD1837_AtkSpeedPercent;

	public ValueFloatBase TD1837_AtkRangePercent;

	public ValueFloatBase TD1837_BuildCostPercent;

	public ValueFloatBase TD1837_UpgradeCostPercent;

	public ValueBase TD1856_Atk;

	public ValueFloatBase TD1856_AtkPercent;

	public ValueFloatBase TD1856_AtkRangePercent;

	public ValueFloatBase TD1856_AtkSpeedPercent;

	public ValueFloatBase TD1856_BuildCostPercent;

	public ValueFloatBase TD1856_UpgradeCostPercent;

	public ValueBase TD1856_StoneMaxDistance;

	public ValueFloatBase TD1856_RockExplodeRadiusPercent;

	public ValueFloatBase TD1856_RockExplodeRatioPercent;

	public ValueBase TD1856_FreezeBulletId;

	public ValueFloatBase TD1856_BackRatioPercent;

	public ValueBase TD1860_Atk;

	public ValueFloatBase TD1860_AtkPercent;

	public ValueFloatBase TD1860_AtkSpeedPercent;

	public ValueFloatBase TD1860_AtkRangePercent;

	public ValueFloatBase TD1860_BuildCostPercent;

	public ValueFloatBase TD1860_UpgradeCostPercent;

	public ValueFloatBase TD1860_FireRangePercent;

	public ValueFloatBase TD1860_FireTimePercent;

	public ValueFloatBase TD1860_FirePillarAtkPercent;

	public ValueFloatBase TD1860_FireAtkIntervalPercent;

	public ValueFloatBase Pet_TD_AttackPercent;

	public ValueFloatBase Pet_TD_AttackSpeedPercent;

	public ValueFloatBase TD_Pet_AttackPercent;

	public ValueFloatBase TD_Pet_PowerPercent;

	public ValueFloatBase TDBase_Pet_AttackPercent;

	public ValueBase TD1846_PerMineCount;

	public ValueFloatBase TD1846_MineAtkRadiusPercent;

	public ValueFloatBase TD1846_MineTimePercent;

	public ValueBase TD1846_Atk;

	public ValueFloatBase TD1846_AtkPercent;

	public ValueFloatBase TD1846_MaxMineRadius;

	public ValueFloatBase TD1846_BuildCostPercent;

	public ValueFloatBase TD1846_UpgradeCostPercent;

	public ValueBase TD1846_MaxMineCount;

	public ValueFloatBase TD1845_BuildCostPercent;

	public ValueFloatBase TD1845_UpgradeCostPercent;

	public ValueFloatBase TD1845_InterfereRadiusPercent;

	public ValueBase TD1845_InterfereMonsterCount;

	public ValueFloatBase TD1845_InterfereTimeReducePercent;

	public ValueFloatBase TD1845_MonsterAtkTimePercent;

	public ValueFloatBase TD1832_BuildCostPercent;

	public ValueFloatBase TD1838_BuildCostPercent;

	public ValueFloatBase TD1839_BuildCostPercent;

	public ValueFloatBase TD1847_BuildCostPercent;

	public ValueFloatBase TD1847_UpgradeCostPercent;

	public ValueFloatBase TD1847_TransportRadiusPercent;

	public ValueBase TD1847_TransportMonsterCount;

	public ValueFloatBase TD1847_TransportCDReducePercent;

	public ValueFloatBase TD_FLOOR_BuildCostPercent;

	public ValueBase TDBase_HPMax;

	public ValueFloatBase TDBase_HPMaxPercent;

	public ValueBase TDBase_HitReduce;

	public ValueFloatBase TDBase_HitReducePercent;

	public ValueFloatBase TDBase_WaveRecoverHPPercent;

	public ValueBase ExtraTDCoin;

	public ValueFloatBase TDAbsorbRangePercent;

	public ValueBase DeltaShieldHammerAliveTime => null;

	public ValueFloatBase CallShieldHammerRate => null;

	public ValueFloatBase ZeusThunderSpearHit2BossPercent => null;

	public ValueFloatBase Equip12101_AttackPercent => null;

	public ValueFloatBase Equip12101_HPDropPercent => null;

	public ValueFloatBase Equip12102_AttackPercent => null;

	public float Equip12103_CritRate_Value => 0f;

	public ValueFloatBase PetAttackPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase PetHPMaxPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase WingHPMaxPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase WingAttackPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase ThunderSpearDamagePercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueBase KillAddThunderlight
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueBase ThunderSpearCanLight
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase MeleeHammerScalePercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase ThrowWeaponHitPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase ThunderSpearAddHammerRate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase ThunderSpearAddLightingRate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase ML_Hit2HeroReducePercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase ML_HitByHeroPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float TrimmedImmunityTrapHitRate => 0f;

	public float TrimmedImmunityFromNearRate => 0f;

	public float TrimmedImmunityFromFarRate => 0f;

	public float TrimmedImmunityFromFlyRate => 0f;

	public float TrimmedImmunityFromGroundRate => 0f;

	public float TrimmedImmunityFromSoldierRate => 0f;

	public float TrimmedImmunityFromBossRate => 0f;

	public float BraceletTimeUpPercentValue => 0f;

	public float BulletContinueHitAddPercent_Value => 0f;

	public float TrimmedMissRate => 0f;

	public float TrimmedCritRate => 0f;

	public float TrimmedCritValue => 0f;

	public ValueFloatBase RebornAddElementCritRate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float AttackPrevSpeedValue => 0f;

	public float AttackEndSpeedValue => 0f;

	public ValueFloatBase IgnoreBulletReducePercent => null;

	public ValueFloatBase WholeRecoverHPPercent => null;

	public float TrimmedWholeEnemyRecoverHPPercent => 0f;

	public ValueFloatBase CommonRebornRatePercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float TrimmedCommonRebornRate => 0f;

	public float TrimmedRelicRebornRatePercent => 0f;

	public ValueFloatBase IgnoreBodyHittedReducePercent => null;

	public ValueFloatBase FirstBeHurtReduceDmgPercent => null;

	public ValueFloatBase MoistBuffAddDmgPercent => null;

	public int ArrowEjectValue => 0;

	public int ArrowEjectMin => 0;

	public int ArrowEjectMax => 0;

	public long ArrowEjectAbsoluteMaxCount => 0L;

	public int ReboundWallValue => 0;

	public int ReboundWallMin => 0;

	public int ReboundWallMax => 0;

	public ValueFloatBase HP2SphereFlashTimePercent => null;

	public ValueFloatBase HP2DizzyBuffTimeUpPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase HP2RotateSpeedUpPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueBase SphereFlashTime
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase SphereFlashTimePercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase SphereFlashDeltaTime
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase SphereFlashHitPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ValueFloatBase SphereFlashRadiusPercent
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float FlySwordVampirePercent_Value => 0f;

	public ValueFloatBase NewPlay127_BeHitCallPartBodyPercent => null;

	public ValueFloatBase NewPlay127_HitCallPartBodyPercent => null;

	public ValueFloatBase NewPlay127_CallDoublePartBodyPercent => null;

	public ValueFloatBase NewPlay127_PartBodyDisappearDropHpPercent => null;

	public float FinalHitReducePercent_Value => 0f;

	public float TrimmedHitReducePercent => 0f;

	public float TrimmedBulletHitReducePercent => 0f;

	public float TrimmedMeleeHitPercent => 0f;

	public ValueFloatBase BulletRadiusScalePercent => null;

	public float TrimmedBulletScalePercent => 0f;

	public float TrimmedBulletSizePercent => 0f;

	public float TrimmedHPDropAddEnergyPercent => 0f;

	public long TrimmedShield => 0L;

	public ValueFloatBase BeIce_TimePercent => null;

	public float Att_HitByThunder_AddPercent_Value => 0f;

	public float Att_HitByIce_AddPercent_Value => 0f;

	public float Att_HitByBlack_AddPercent_Value => 0f;

	public float Trimmed_Att_Element_DurationAddPercent => 0f;

	public float Trimmed_Att_Element_DurationReducePercent => 0f;

	public float TrimmedStaffChargeReduceTimePercent => 0f;

	public float TrimmedFightBackRate => 0f;

	public float Shield_Rate_Value => 0f;

	public ValueFloatBase MonsterKingKingFlySwordDmgPercent => null;

	public ValueFloatBase MonsterKingFlySwordReduceIntervalPercent => null;

	public ValueFloatBase MonsterKingRingImproveAttackSpeedPercent => null;

	public float AttackInterval_Value => 0f;

	public float AttackRange_Value => 0f;

	public float NightmarePercent_Value => 0f;

	public Dictionary<string, AddAttStringData> excuteAttList { get; private set; }

	public ValueFloatBase Artifact_SkillCondNumReducePercent => null;

	public ValueFloatBase Artifact_SkillDmgAddPercent => null;

	public ValueFloatBase Artifact_SkillCritAddPercent => null;

	public ValueFloatBase Artifact_SkillCritValueAddPercent => null;

	public ValueFloatBase Artifact_101_SkillCondNumReduce => null;

	public ValueFloatBase Artifact_201_SkillCondNumReduce => null;

	public ValueFloatBase Artifact_301_SkillCondNumReduce => null;

	public ValueFloatBase Artifact_302_SkillCondNumReduce => null;

	public ValueFloatBase Artifact_303_SkillCondNumReduce => null;

	public ValueFloatBase Artifact_101_SkillCondNumReducePercent => null;

	public ValueFloatBase Artifact_201_SkillCondNumReducePercent => null;

	public ValueFloatBase Artifact_301_SkillCondNumReducePercent => null;

	public ValueFloatBase Artifact_302_SkillCondNumReducePercent => null;

	public ValueFloatBase Artifact_303_SkillCondNumReducePercent => null;

	public ValueFloatBase Artifact_101_SkillDmgAddPercent => null;

	public ValueFloatBase Artifact_201_SkillDmgAddPercent => null;

	public ValueFloatBase Artifact_301_SkillDmgAddPercent => null;

	public ValueFloatBase Artifact_302_SkillDmgAddPercent => null;

	public ValueFloatBase Artifact_303_SkillDmgAddPercent => null;

	public ValueFloatBase Artifact_101_SkillCritAddPercent => null;

	public ValueFloatBase Artifact_201_SkillCritAddPercent => null;

	public ValueFloatBase Artifact_301_SkillCritAddPercent => null;

	public ValueFloatBase Artifact_302_SkillCritAddPercent => null;

	public ValueFloatBase Artifact_303_SkillCritAddPercent => null;

	public ValueFloatBase Artifact_101_SkillCritValueAddPercent => null;

	public ValueFloatBase Artifact_201_SkillCritValueAddPercent => null;

	public ValueFloatBase Artifact_301_SkillCritValueAddPercent => null;

	public ValueFloatBase Artifact_302_SkillCritValueAddPercent => null;

	public ValueFloatBase Artifact_303_SkillCritValueAddPercent => null;

	public ValueFloatBase Artifact_101_SkillLastTimeAddPercent => null;

	public ValueFloatBase Artifact_101_SkillIntervalTimeReducePercent => null;

	public ValueFloatBase Artifact_301_DoubleCreateProb => null;

	public float Bullet_Divide_Rate_Value => 0f;

	public float Bullet_Divide_Hit_Percent_Value => 0f;

	public long Bullet_Divide_Count_Value => 0L;

	public bool Bullet_Divide_Inherit_Value => false;

	public float RotateBall_Trigger_Meteorite_Rate_Value => 0f;

	public float RotateSword_Trigger_Meteor_Star_Value => 0f;

	public float Camp_Battle_Crystal_Percent_Value => 0f;

	public float Camp_Battle_Coins_Percent_Value => 0f;

	public bool CanLightThroughEnemy => false;

	public long PartBulletForward_Value => 0L;

	public bool CanPartBulletThroughEnemy => false;

	public bool CanPartBulletThroughWall => false;

	public float SideAttackPercent_Value => 0f;

	public float MonsterSlowDownIn3SecondsPercent_Value => 0f;

	public float MonsterHittedRaiseIn3SecondsPercent_Value => 0f;

	public float MonsterBodyHitReduceIn3SecondsPercent_Value => 0f;

	public float MonsterAttackReduceIn3SecondsPercent_Value => 0f;

	public float Camp_Battle_MonsterLV1_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV2_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV3_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV4_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV5_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV6_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV7_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV8_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV9_HP_Percent_Value => 0f;

	public float Camp_Battle_MonsterLV10_HP_Percent_Value => 0f;

	public float Camp_Battle_BossGuard_Hit_Percent_Value => 0f;

	public float TrimmedColdTimePercent => 0f;

	public float TrimmedMagicCostReducePercent => 0f;

	public float TrimmedFireworks_RandomRatePercent => 0f;

	private static Dictionary<string, (int, PetAttrType)> PetKeyToAttrMap => null;

	public ValueFloatBase BulletForwardAddDmgPercent => null;

	public ValueFloatBase BulletForwardAddCountProb => null;

	public ValueBase BulletForwardAddCount => null;

	public ValueFloatBase BulletBackwardAddDmgPercent => null;

	public ValueFloatBase BulletBackwardAddCountProb => null;

	public ValueBase BulletBackwardAddCount => null;

	public ValueFloatBase BulletSideAddDmgPercent => null;

	public ValueFloatBase BulletSlopeAddDmgPercent => null;

	public ValueFloatBase BulletContinueAddDmgPercent => null;

	public ValueFloatBase BulletAxeAddDmgPercent => null;

	public ValueFloatBase UP_Imprint_BaseAddPercent => null;

	public ValueFloatBase BulletLightBeHitAddDmgPercent => null;

	public ValueFloatBase NewPlay125_1001_AttackValuePercent => null;

	public ValueFloatBase NewPlay125_1002_AttackValuePercent => null;

	public ValueFloatBase NewPlay125_1003_AttackValuePercent => null;

	public ValueFloatBase NewPlay125_1004_AttackValuePercent => null;

	public ValueFloatBase NewPlay125_1005_AttackValuePercent => null;

	public ValueFloatBase NewPlay125_1007_AttackValuePercent => null;

	public ValueFloatBase NewPlay125_1001_AttackSpeedPercent => null;

	public ValueFloatBase NewPlay125_1002_AttackSpeedPercent => null;

	public ValueFloatBase NewPlay125_1003_AttackSpeedPercent => null;

	public ValueFloatBase NewPlay125_1004_AttackSpeedPercent => null;

	public ValueFloatBase NewPlay125_1005_AttackSpeedPercent => null;

	public ValueFloatBase NewPlay125_1007_AttackSpeedPercent => null;

	public ValueFloatBase NewPlay125_1004_AttackFullHPMultCritPercent => null;

	public ValueFloatBase NewPlay125_1005_EnemyReduceHPFullAddCritPercent => null;

	public ValueFloatBase NewPlay125_1006_BagCoinGetMult => null;

	public ValueFloatBase NewPlay125_CoinDropMoreOneProb => null;

	public ValueFloatBase NewPlay126_SkillReduceCDPercent => null;

	public ValueBase NewPlay126_ExtraSlotCount => null;

	public ValueBase NewPlay126_SlotMaxCount => null;

	public ValueFloatBase NewPlay126_FirePathExistTimeAddPercent => null;

	public ValueFloatBase NewPlay126_FirePathRadiusAddPercent => null;

	public ValueFloatBase NewPlay126_1260301_SkillCDReduce => null;

	public ValueFloatBase NewPlay126_1260302_SkillCDReduce => null;

	public ValueFloatBase NewPlay126_1260303_SkillCDReduce => null;

	private Dictionary<int, Dictionary<PetAttrType, ValueFloatBase>> PetAttrMatrix => null;

	public ValueFloatBase WholePets_EnergyChargeSpeedPercent => null;

	public ValueFloatBase WholePets_HPToPetEnergyPercent => null;

	public ValueFloatBase Pet_Type3_AliveTimePercent => null;

	public float Pet_Type3_AliveTimePercent_Value => 0f;

	public ValueFloatBase WholePets_CritRate => null;

	public ValueFloatBase WholePets_CritValue => null;

	public ValueFloatBase WholePets_AliveTimePercent => null;

	public ValueFloatBase AllBlackRangePercent => null;

	public ValueFloatBase PenguinKingIceFlySwordSendTimeImprovePercent => null;

	public ValueFloatBase PetBallSpeedPercent => null;

	public ValueFloatBase WholePets_AttackValuePercent => null;

	public ValueFloatBase PetFlamingoMainBulletHitBossDmgPercent => null;

	public ValueFloatBase Pet_31001_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_31002_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_31003_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_31004_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_31005_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_32001_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_32002_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_32003_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_32004_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_33001_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_33002_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_33003_EnergyChargeSpeedPercent => null;

	public ValueFloatBase Pet_31001_CritRate => null;

	public ValueFloatBase Pet_31002_CritRate => null;

	public ValueFloatBase Pet_31003_CritRate => null;

	public ValueFloatBase Pet_31004_CritRate => null;

	public ValueFloatBase Pet_31005_CritRate => null;

	public ValueFloatBase Pet_32001_CritRate => null;

	public ValueFloatBase Pet_32002_CritRate => null;

	public ValueFloatBase Pet_32003_CritRate => null;

	public ValueFloatBase Pet_32004_CritRate => null;

	public ValueFloatBase Pet_33001_CritRate => null;

	public ValueFloatBase Pet_33002_CritRate => null;

	public ValueFloatBase Pet_33003_CritRate => null;

	public ValueFloatBase Pet_31001_CritValue => null;

	public ValueFloatBase Pet_31002_CritValue => null;

	public ValueFloatBase Pet_31003_CritValue => null;

	public ValueFloatBase Pet_31004_CritValue => null;

	public ValueFloatBase Pet_31005_CritValue => null;

	public ValueFloatBase Pet_32001_CritValue => null;

	public ValueFloatBase Pet_32002_CritValue => null;

	public ValueFloatBase Pet_32003_CritValue => null;

	public ValueFloatBase Pet_32004_CritValue => null;

	public ValueFloatBase Pet_33001_CritValue => null;

	public ValueFloatBase Pet_33002_CritValue => null;

	public ValueFloatBase Pet_33003_CritValue => null;

	public ValueFloatBase Pet_31001_PlayerHPPercent => null;

	public ValueFloatBase Pet_31002_PlayerHPPercent => null;

	public ValueFloatBase Pet_31003_PlayerHPPercent => null;

	public ValueFloatBase Pet_31004_PlayerHPPercent => null;

	public ValueFloatBase Pet_31005_PlayerHPPercent => null;

	public ValueFloatBase Pet_32001_PlayerHPPercent => null;

	public ValueFloatBase Pet_32002_PlayerHPPercent => null;

	public ValueFloatBase Pet_32003_PlayerHPPercent => null;

	public ValueFloatBase Pet_32004_PlayerHPPercent => null;

	public ValueFloatBase Pet_33001_PlayerHPPercent => null;

	public ValueFloatBase Pet_33002_PlayerHPPercent => null;

	public ValueFloatBase Pet_33003_PlayerHPPercent => null;

	public ValueFloatBase Pet_31001_PlayerAttackPercent => null;

	public ValueFloatBase Pet_31002_PlayerAttackPercent => null;

	public ValueFloatBase Pet_31003_PlayerAttackPercent => null;

	public ValueFloatBase Pet_31004_PlayerAttackPercent => null;

	public ValueFloatBase Pet_31005_PlayerAttackPercent => null;

	public ValueFloatBase Pet_32001_PlayerAttackPercent => null;

	public ValueFloatBase Pet_32002_PlayerAttackPercent => null;

	public ValueFloatBase Pet_32003_PlayerAttackPercent => null;

	public ValueFloatBase Pet_32004_PlayerAttackPercent => null;

	public ValueFloatBase Pet_33001_PlayerAttackPercent => null;

	public ValueFloatBase Pet_33002_PlayerAttackPercent => null;

	public ValueFloatBase Pet_33003_PlayerAttackPercent => null;

	public ValueFloatBase Pet_31001_AttackValuePercent => null;

	public ValueFloatBase Pet_31002_AttackValuePercent => null;

	public ValueFloatBase Pet_31003_AttackValuePercent => null;

	public ValueFloatBase Pet_31004_AttackValuePercent => null;

	public ValueFloatBase Pet_31005_AttackValuePercent => null;

	public ValueFloatBase Pet_32001_AttackValuePercent => null;

	public ValueFloatBase Pet_32002_AttackValuePercent => null;

	public ValueFloatBase Pet_32003_AttackValuePercent => null;

	public ValueFloatBase Pet_32004_AttackValuePercent => null;

	public ValueFloatBase Pet_33001_AttackValuePercent => null;

	public ValueFloatBase Pet_33002_AttackValuePercent => null;

	public ValueFloatBase Pet_33003_AttackValuePercent => null;

	public ValueFloatBase Pet_33004_AttackValuePercent => null;

	public event Action<float> OnShieldHitPercentChangedAction
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

	public event Action<long> OnRotateSickleNumChanged
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

	public EntityAttributeBase()
	{
	}

	public EntityAttributeBase(int CharID, EntityBase entity = null)
	{
	}

	public void Init(int CharID, EntityBase entity = null)
	{
	}

	public void SetEntity(EntityBase entity)
	{
	}

	private void onAfterSetEntity(int CharID)
	{
	}

	public static int GetValuePercentByPercentage(int percentage)
	{
		return 0;
	}

	public static float GetValueByPercentage(int percentage)
	{
		return 0f;
	}

	public void InvokeShieldHitPercentChangedAction(float value)
	{
	}

	public Dictionary<string, object> GetUniqueValues()
	{
		return null;
	}

	public void UpdateKillVampireResult()
	{
	}

	public void UpdateHitVampireResult()
	{
	}

	public long GetHPBase()
	{
		return 0L;
	}

	public void CacheExcuteAttString(string type, long value)
	{
	}

	public bool Excute(string str)
	{
		return false;
	}

	public bool Excute(Goods_goods.GoodData data)
	{
		return false;
	}

	private bool ExcuteSlotSkillRate(string type, long value)
	{
		return false;
	}

	private bool ExcuteAngelEventRate(string type, long value)
	{
		return false;
	}

	private bool ParseHeroRuneAttr(string type, long value)
	{
		return false;
	}

	private bool ParseEggAttr(string type, long value)
	{
		return false;
	}

	public float getAddHPPercent(float value)
	{
		return 0f;
	}

	public string getAddHPPercentString(float value)
	{
		return null;
	}

	public float getAddAttackPercent(float value)
	{
		return 0f;
	}

	public string getAddAttackPercentString(float value)
	{
		return null;
	}

	public void DebugValue()
	{
	}

	public void AttributeToZeus(EntityAttributeBase zeusAttribute)
	{
	}

	public void AttributeToDemogorgon(EntityAttributeBase demoAttribute)
	{
	}

	public void AttributeTo(EntityAttributeBase attribute)
	{
	}

	public float GetSlotSkillRate(int id)
	{
		return 0f;
	}

	public long GetAngelEventWeightAdd(int id)
	{
		return 0L;
	}

	public float GetAngelEventWeightAddPercent(int id)
	{
		return 0f;
	}

	public List<ValueFloatBase> GetAllSlotSkillRates()
	{
		return null;
	}

	public float GetEquipDropAddRate(int id)
	{
		return 0f;
	}

	public override void Reset()
	{
	}

	public void DeInit()
	{
	}

	public void ArtifactAttributeTo(EntityAttributeBase attribute)
	{
	}

	public void UpdateArtifactSkillCondNumReduce(ArtifactType artifactType, float reduceCond)
	{
	}

	public float GetArtifactSkillCondNumReduce(ArtifactType artifactType)
	{
		return 0f;
	}

	public void UpdateArtifactSkillCondNumReducePercent(ArtifactType artifactType, float reduceCondPercent)
	{
	}

	public float GetArtifactSkillCondNumReducePercent(ArtifactType artifactType)
	{
		return 0f;
	}

	public void UpdateArtifactSkillDmgAddPercent(ArtifactType artifactType, float addPercent)
	{
	}

	public float GetArtifactSkillDmgAddPercent(ArtifactType artifactType)
	{
		return 0f;
	}

	public void UpdateArtifactSkillCritAddPercent(ArtifactType artifactType, float addPercent)
	{
	}

	public float GetArtifactSkillCritAddPercent(ArtifactType artifactType)
	{
		return 0f;
	}

	public void UpdateArtifactSkillCritValueAddPercent(ArtifactType artifactType, float addPercent)
	{
	}

	public float GetArtifactSkillCritValueAddPercent(ArtifactType artifactType)
	{
		return 0f;
	}

	private void TDAttributeTo(EntityAttributeBase attribute)
	{
	}

	private void TDReset()
	{
	}

	private void CampAttributeTo(EntityAttributeBase attribute)
	{
	}

	private bool ExcuteCamp(string type, long value)
	{
		return false;
	}

	public float GetCampBattleMonsterHPPercent(int level)
	{
		return 0f;
	}

	public void DragonAttributeTo(EntityAttributeBase attribute)
	{
	}

	public void LogDragonBasicInfo()
	{
	}

	public void LogDragonExtraInfo(DragonType dragonType)
	{
	}

	public float GetPublicCDTime()
	{
		return 0f;
	}

	public float GetDragonCDTime(DragonType dragonType)
	{
		return 0f;
	}

	public int GetMaxMagicValue()
	{
		return 0;
	}

	public int GetMagicCost(DragonType dragonType)
	{
		return 0;
	}

	public float GetOriginalBreathTime(DragonType dragonType)
	{
		return 0f;
	}

	public float UpdateOriginalBreathTime(DragonType dragonType, float value)
	{
		return 0f;
	}

	public float GetReleaseTime(DragonType dragonType)
	{
		return 0f;
	}

	public float GetBreathTime(DragonType dragonType)
	{
		return 0f;
	}

	public List<int> GetDragonDebuffs(DragonType dragonType)
	{
		return null;
	}

	public bool IsBulletsResist(DragonType dragonType)
	{
		return false;
	}

	public List<int> GetBeforeContinuousAttackBuff(DragonType dragonType)
	{
		return null;
	}

	public float GetColliderScalePercent(DragonType dragonType)
	{
		return 0f;
	}

	public List<int> GetAfterContinuousAttackBuff(DragonType dragonType)
	{
		return null;
	}

	public void UpdateBreathTime(DragonType dragonType, float value)
	{
	}

	public long GetAttackByBaseAttack(DragonType dragonType, long baseAttack)
	{
		return 0L;
	}

	public long GetAttackByDragon(DragonType dragonType)
	{
		return 0L;
	}

	public float GetMagicCostThresholdPercent(DragonType dragonType)
	{
		return 0f;
	}

	public float GetReleaseDragonPercent(DragonType dragonType)
	{
		return 0f;
	}

	public float GetMagicCostDiscountPercent(DragonType dragonType)
	{
		return 0f;
	}

	public bool Excute(string type, long value, ValueType valueType = ValueType.Normal)
	{
		return false;
	}

	public bool ExecuteArtifact(string type, long value)
	{
		return false;
	}

	public bool ExecuteDragon(string type, long value)
	{
		return false;
	}

	public bool ExecuteImprint(string type, long value)
	{
		return false;
	}

	public bool ExecuteNewPlay125(string type, long value)
	{
		return false;
	}

	public bool ExecuteNewPlay126(string type, long value)
	{
		return false;
	}

	public bool ExecutePet(string type, long value)
	{
		return false;
	}

	public bool ExecuteTD(string type, long value)
	{
		return false;
	}

	public void ImprintAttributeTo(EntityAttributeBase attribute)
	{
	}

	public void NewPlay125AttributeTo(EntityAttributeBase attribute)
	{
	}

	public void UpdateNewPlay125WeaponAttackValuePercent(NewPlay125WeaponType weaponType, float deltaPercent)
	{
	}

	public void UpdateNewPlay125WeaponAttackSpeedPercent(NewPlay125WeaponType weaponType, float deltaPercent)
	{
	}

	public float GetNewPlay125WeaponAttackValuePercent(NewPlay125WeaponType weaponType)
	{
		return 0f;
	}

	public float GetNewPlay125WeaponAttackSpeedPercent(NewPlay125WeaponType weaponType)
	{
		return 0f;
	}

	public void NewPlay126AttributeTo(EntityAttributeBase attribute)
	{
	}

	public void UpdateNewPlay126SkillCDReduce(NewPlay126SkillType skillType, float reduceTime)
	{
	}

	public float GetNewPlay126SkillCDReduce(NewPlay126SkillType skillType)
	{
		return 0f;
	}

	public ValueFloatBase GetPetAttrValue(int petId, PetAttrType attrType)
	{
		return null;
	}

	public void ResetPetAttributes()
	{
	}

	public void PetAttributeTo(EntityAttributeBase attribute)
	{
	}

	private static string GetPetConstKey(int petId, PetAttrType attrType)
	{
		return null;
	}

	private void UpdatePetAttribute(int petId, PetAttrType attrType, float deltaPercent, string callerName)
	{
	}

	private float GetPetAttributeValue(int petId, PetAttrType attrType, string callerName)
	{
		return 0f;
	}

	public void UpdatePetEnergyChargeSpeedPercent(int petId, float deltaPercent)
	{
	}

	public float GetPetEnergyChargeSpeedPercent(int petId)
	{
		return 0f;
	}

	public void UpdatePetCritRatePercent(int petId, float deltaPercent)
	{
	}

	public float GetPetCritRatePercent(int petId)
	{
		return 0f;
	}

	public void UpdatePetCritValuePercent(int petId, float deltaPercent)
	{
	}

	public float GetPetCritValuePercent(int petId)
	{
		return 0f;
	}

	public void UpdatePetPlayerHPPercent(int petId, float deltaPercent)
	{
	}

	public float GetPetPlayerHPPercent(int petId)
	{
		return 0f;
	}

	public void UpdatePetPlayerAttackPercent(int petId, float deltaPercent)
	{
	}

	public float GetPetPlayerAttackPercent(int petId)
	{
		return 0f;
	}

	public float GetPetAttackValuePercent(EntityData.AttackValueEnum petAtkValueEnum)
	{
		return 0f;
	}

	public bool GetCanReborn()
	{
		return false;
	}

	public void Reborn_Refresh_Count(int usecount)
	{
	}

	public long GetTDAtk(int towerId)
	{
		return 0L;
	}

	public float GetTDAtkPercent(int towerId)
	{
		return 0f;
	}

	public float GetTDSpeedPercent(int towerId)
	{
		return 0f;
	}

	public float GetTDRangePercent(int towerId)
	{
		return 0f;
	}

	public float GetTDBuildCostPercent(int towerId)
	{
		return 0f;
	}

	public float GetTDUpgradeCostPercent(int towerId)
	{
		return 0f;
	}
}
