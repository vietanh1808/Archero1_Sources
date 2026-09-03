using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.Tweening;
using Dxx.Util;
using HeroCapybara;
using Newtonsoft.Json;
using TableTool;
using UnityEngine;

[SelectionBase]
public class EntityBase : MonoBehaviour
{
	public enum ATTACKTYPE
	{
		AttackType_None = 0,
		AttackType_Near = 1,
		AttackType_Far = 2,
		AttackType_Near_Far = 3,
		AttackType_Ground = 4,
		AttackType_Ground_Near = 5,
		AttackType_Ground_Far = 6,
		AttackType_Ground_Near_Far = 7,
		AttackType_Fly = 8,
		AttackType_Fly_Near = 9,
		AttackType_Fly_Far = 10,
		AttackType_Fly_Near_Far = 11,
		AttackType_Fly_Ground = 12,
		AttackType_Fly_Ground_Near = 13,
		AttackType_Fly_Ground_Far = 14,
		AttackType_Fly_Ground_Near_Far = 15
	}

	public class EntityBaseFunc<T1, T2>
	{
		public delegate float GetResult(T1 t1, T2 t2);

		private GetResult _getResult;

		public void Add(GetResult func)
		{
		}

		public void Remove(GetResult func)
		{
		}

		public float Invoke(T1 t1, T2 t2)
		{
			return 0f;
		}
	}

	public class OwlElf
	{
		public enum SkinType
		{
			Red = 0,
			Blue = 1,
			Green = 2,
			Yellow = 3
		}

		private GameObject resource;

		private SkinType skinType;

		private Goods_goods.GoodData goodData;

		public Sequence appearSeq;

		public Sequence disappearSeq;

		private EntityBase parentEntity;

		private ActionBasic action;

		public GameObject Resource => null;

		public SkinType OwlElfSkinType => SkinType.Red;

		public Goods_goods.GoodData GoodData => null;

		public OwlElf(GameObject _resource, SkinType _skinType, string _attribute)
		{
		}

		public void Destroy()
		{
		}

		private void setTex()
		{
		}

		private string getTexPathBySkinType(SkinType skinType)
		{
			return null;
		}

		public void KillAppearSeq()
		{
		}

		public void SetEntity(EntityBase _entity)
		{
		}

		private void removeSelf()
		{
		}

		private void killDisappearSeq()
		{
		}

		public void PlayAppearAnim()
		{
		}

		public void PlayDisAppearAnim(Action callback)
		{
		}

		private Transform getTargetTrans()
		{
			return null;
		}
	}

	public class PartBodyData
	{
		public int ID;

		public int alivecount;

		public int maxcount;

		public void Add()
		{
		}

		public void Remove()
		{
		}

		public bool CanAdd()
		{
			return false;
		}
	}

	public class GetHPDropFakeBuff : FakeBuff
	{
		public GetHPDropFakeBuff(EntityBase entity)
			: base(null)
		{
		}

		protected override void AddListener()
		{
		}

		protected override void RemoveListener()
		{
		}

		private void onHPDrop()
		{
		}

		protected override void OnAddAttr()
		{
		}

		protected override void OnRemoveAttr()
		{
		}
	}

	public class CritFakeBuff : FakeBuff
	{
		public CritFakeBuff(EntityBase entity)
			: base(null)
		{
		}

		protected override void AddListener()
		{
		}

		protected override void RemoveListener()
		{
		}

		private void onCrit(EntityBase arg1, long arg2)
		{
		}

		protected override void OnAddAttr()
		{
		}

		protected override void OnRemoveAttr()
		{
		}
	}

	public class KillFakeBuff : FakeBuff
	{
		public KillFakeBuff(EntityBase entity)
			: base(null)
		{
		}

		protected override void AddListener()
		{
		}

		protected override void RemoveListener()
		{
		}

		private void onKill(EntityBase arg1, Vector3 arg2, HitStruct arg3)
		{
		}

		protected override void OnAddAttr()
		{
		}

		protected override void OnRemoveAttr()
		{
		}
	}

	public class KillFake2Buff : FakeBuff
	{
		public KillFake2Buff(EntityBase entity)
			: base(null)
		{
		}

		protected override void AddListener()
		{
		}

		protected override void RemoveListener()
		{
		}

		private void onKill(EntityBase arg1, Vector3 arg2, HitStruct arg3)
		{
		}

		protected override void OnAddAttr()
		{
		}

		protected override void OnRemoveAttr()
		{
		}
	}

	public class HittedFakeBuff : FakeBuff
	{
		public HittedFakeBuff(EntityBase entity)
			: base(null)
		{
		}

		protected override void AddListener()
		{
		}

		protected override void RemoveListener()
		{
		}

		private void onHitted(EntityBase arg1, long arg2)
		{
		}

		protected override void OnAddAttr()
		{
		}

		protected override void OnRemoveAttr()
		{
		}
	}

	public class FakeBuff
	{
		public string AttrName;

		public Func<long> GetAttrValue;

		private const string UPDATE_NAME = "FakeBuff-Update";

		public float CD;

		public float ValidTime;

		public EntityBase m_Entity;

		private float curTime;

		private bool canAddAttr;

		private bool canRemoveAttr;

		protected string Tag => null;

		public FakeBuff(EntityBase entity)
		{
		}

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		private void onUpdate(float obj)
		{
		}

		public void AddAttr()
		{
		}

		protected virtual void OnAddAttr()
		{
		}

		protected virtual void OnRemoveAttr()
		{
		}

		protected virtual void AddListener()
		{
		}

		protected virtual void RemoveListener()
		{
		}
	}

	public class RotateFollowData
	{
		private int name;

		public EntityBase parent;

		public float rotate;

		private float rotatePerSecond;

		private float currentrotate;

		private float range;

		private List<EntityBase> mList;

		private GameObject test;

		public RotateFollowData(int name)
		{
		}

		public void Init(EntityBase parent, float rotate, float range)
		{
		}

		public void DeInit()
		{
		}

		public void Add(EntityBase entity)
		{
		}

		public void Remove(EntityBase entity)
		{
		}

		private void UpdateEntities()
		{
		}

		public Vector3 GetPosition(EntityBase entity)
		{
			return default;
		}

		private void OnUpdate(float delta)
		{
		}
	}

	public enum RotateClassType
	{
		none = 0,
		shield = 1,
		sword = 2,
		ball = 3,
		emerald = 4
	}

	public class RotateClass
	{
		public EntityBase parent;

		public string name;

		public float rotate;

		public float oldRotate;

		public float rotatePerSecond;

		private float mInitialRotate;

		public float allangle;

		protected float time;

		public Transform RotateAttribute;

		protected List<Transform> mRotateAttrList;

		private Dictionary<Transform, List<Transform>> mList;

		private float radius;

		private RotateClassType rotateType;

		private const int CONFIG_ID = 3130;

		public float BallPower => 0f;

		public float SwordPower => 0f;

		public float ShieldPower => 0f;

		public float Radius => 0f;

		public RotateClass()
		{
		}

		public RotateClass(RotateClassType _rotateType)
		{
		}

		public void Init(EntityBase parent, string name, float rotate, float allangle, bool canUpdate = true)
		{
		}

		public void SetRotate(float rotate)
		{
		}

		public void StartUpdate()
		{
		}

		public void StopUpdate()
		{
		}

		protected virtual void OnInit()
		{
		}

		public void UpdateRotateSpeed(float rotate)
		{
		}

		public float GetRotateSpeed()
		{
			return 0f;
		}

		public void DeInit()
		{
		}

		protected virtual void OnDeInit()
		{
		}

		public void AddNewRotateAttribute(GameObject o)
		{
		}

		public void AddToRotateAttrList(GameObject o)
		{
		}

		public int GetSkillCount()
		{
			return 0;
		}

		protected virtual void OnAddNewRotateAttribute(GameObject o)
		{
		}

		public GameObject GetContainer()
		{
			return null;
		}

		public void Remove(GameObject o)
		{
		}

		protected virtual void OnRemove(GameObject o)
		{
		}

		public void RemoveAll()
		{
		}

		public int Count()
		{
			return 0;
		}

		private void RotateAttributeUpdatePosition()
		{
		}

		protected virtual void OnAddorMove()
		{
		}

		protected virtual void OnRotateAttributeUpdate(float delta)
		{
		}

		public void SetRadius(float radius)
		{
		}

		private Transform GetOne(Transform t, int index)
		{
			return null;
		}
	}

	protected class RotateBallClass : RotateClass
	{
	}

	protected class RotateSickleClass : RotateBallClass
	{
		private const float DURATION = 12f;

		private const float INTERVAL = 2f;

		private float m_fDuration;

		private float m_fTime;

		private float m_fInterval;

		private bool m_bShow;

		public void Init(EntityBase parent, string name, float rotate, float allangle, float duration, float interval)
		{
		}

		protected override void OnInit()
		{
		}

		private void CalInterval()
		{
		}

		private void OnAttackSpeedChange(int value)
		{
		}

		private void OnBulletScale(float value)
		{
		}

		protected override void OnRotateAttributeUpdate(float delta)
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class OpheliaSkin320006
	{
		private const int PART_ID = 1827;

		private const int bodyBulletId = 1503;

		public float PartAliveTime;

		public float DropHeartRate;

		public float PartAtkPercent;

		public float PartExplodeAtkPercent;

		public float MaxPartAtkCount;

		public float PartExplodeRadius;

		public float m_fHpAddPercent;

		public float pvpSpeedPercent;

		public string ExternalTag;

		public EntityBase m_Entity;

		public OpheliaSkin320006(EntityBase entity)
		{
		}

		public void CallMonster(Vector3 birthPos)
		{
		}
	}

	public class ElaineSkin320015
	{
		public WeightRandom BuffRandom;

		public float ReleaseBuffRate;

		public float Factor_1;

		public float Factor_2;

		public float Factor_3;

		public float GetWrapperReleaseBuffRate(int bulletCount)
		{
			return 0f;
		}

		public string GetInfo()
		{
			return null;
		}
	}

	public class Unicorn
	{
		private GameObject resource;

		public Sequence appearSeq;

		public Sequence disappearSeq;

		private EntityBase parentEntity;

		private ActionBasic action;

		public GameObject Resource => null;

		public Unicorn(GameObject _resource)
		{
		}

		public void Disabled()
		{
		}

		private void enableCollider(bool _enabled)
		{
		}

		public void Destroy()
		{
		}

		public void KillAppearSeq()
		{
		}

		public void SetEntity(EntityBase _entity)
		{
		}

		private void removeSelf()
		{
		}

		private void killDisappearSeq()
		{
		}

		public void PlayAppearAnim()
		{
		}

		public void PlayDisAppearAnim(Action callback)
		{
		}

		private Transform getTargetTrans()
		{
			return null;
		}
	}

	[CompilerGenerated]
	private sealed class _003CDelaySetRendderOrder_003Ed__1635 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform transform;

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
		public _003CDelaySetRendderOrder_003Ed__1635(int _003C_003E1__state)
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

	public Daily_Monster m_DailyMonsterMeta;

	public PVEStage_Monster m_PveStageMonsterMeta;

	public bool ShowMaxHPChangeTip;

	public bool EnablePlayEliteEffect;

	public bool EnablePlayIdle;

	public string DefaultAnimName;

	public const int DEFAULT_CHAR_ID = 1001;

	public const int DEFAULT_PLAYER_CHAR_ID = 10000;

	protected static ulong sEntityIndex;

	public bool isPreInit;

	public int Guid;

	public Action<EntityBase> Event_DeInit;

	public Action Event_OnAttack;

	[CompilerGenerated]
	private Action m_Event_OnAttackPrePre;

	public Action Event_OnAttackPre;

	public Action Event_OnAttackEnd;

	public Action Event_OnAttackEndEnd;

	private long m_nInitialAttack;

	[HideInInspector]
	public bool isStartDeadClearBuff;

	[NonSerialized]
	public string ClassName;

	[NonSerialized]
	public int ClassID;

	protected int HPSliderID;

	protected int CDTextID;

	[NonSerialized]
	public Character_Char m_Data;

	public EntityData m_EntityData;

	public float HPOffsetY;

	protected GameObject child;

	[NonSerialized]
	public AnimatorBase m_AniCtrl;

	[NonSerialized]
	public MoveControl m_MoveCtrl;

	[NonSerialized]
	public AttackControl m_AttackCtrl;

	public WeaponBase m_Weapon;

	public AnimationCtrlBase mAniCtrlBase;

	public BodyMask m_Body;

	public HitEdit m_HitEdit;

	protected SphereCollider m_SphereCollider;

	protected CapsuleCollider m_CapsuleCollider;

	protected BoxCollider m_BoxCollider;

	protected Dictionary<string, BoxCollider> m_ChildsBoxCollider;

	protected Dictionary<string, SphereCollider> m_ChildsSphereCollider;

	protected Dictionary<string, CapsuleCollider> m_ChildsCapsuleCollider;

	protected const string Entity2MapOutWall = "Entity2MapOutWall";

	protected const string Entity2Stone = "Entity2Stone";

	protected const string Entity2Water = "Entity2Water";

	protected const string Entity2DragonStone = "Entity2DragonStone";

	public HpSlider m_HPSlider;

	public float AliveTime;

	private bool bDeInit;

	public SelfAttributeData mSelfAttributeData;

	private string _TextureID;

	[NonSerialized]
	private bool m_bElite;

	private MapCreator.HeroModeData.SOLIDER_TYPE _soliderType;

	public EntityShaderType isWithSpecialShader;

	[NonSerialized]
	public WingCtrl m_WingCtrl;

	protected float HittedX;

	protected float HittedY;

	public Vector3 HittedDirection;

	public float HittedAngle;

	public ObscuredFloat HittedV;

	public Vector3 hittedoffset;

	[SerializeField]
	protected EntityState m_State;

	[SerializeField]
	[Tooltip("当前生命值")]
	private string HPPercent;

	private int showhpcount;

	private int showmeshcount;

	private Transform[] childs;

	private bool showchallenge;

	protected EntityBase m_HatredTargetP;

	private BattleModuleData _battleModuleData;

	protected bool bInitLogic;

	public GameObject LowResolutionShadow;

	public EntityShadowCtrl LowResolutionShadowCtrl;

	private string[] m_strDieEffects;

	protected string _modelid;

	private bool Dead_bPlay;

	private int Dead_PlayCount;

	private int Dead_CurrentCount;

	private float Dead_StartAngle;

	private float Dead_PerAngle;

	private bool bFlyWater;

	private bool bFlyStone;

	private const float DELTA_ANGLE = 45f;

	private long m_lDemonShieldShieldValue;

	private long m_lDemonShieldShieldMax;

	[CompilerGenerated]
	private Func<float> m_OnCalCritRateEvent;

	[CompilerGenerated]
	private Func<float> m_OnCalBlackEnergyEvent;

	[CompilerGenerated]
	private Func<float> m_OnCalBlackHitEvent;

	[CompilerGenerated]
	private Func<float> m_OnCalBlackCritRateEvent;

	[CompilerGenerated]
	private Func<float> m_OnCalBlackCritValueEvent;

	public Action OnPetCapybaraAddShield;

	public Action OnCapybaraMeteorStateExit;

	public Action<long> OnDragonShieldValueUpdated;

	public Action OnCreateMeteors;

	public Action OnPVPGrassStateChanged;

	public Action<BulletResist, BulletBase> OnBulletResistHitted;

	public Action<CommonHitCtrl> OnPetShieldDestroyed;

	public Action<CommonHitCtrl> OnEnterCommonCollider;

	public Action<CommonHitCtrl> OnStayCommonCollider;

	public Action<CommonHitCtrl> OnExitCommonCollider;

	public Action<LocalSave.PetOne> OnPetStartAppear;

	public Action<LocalSave.PetOne> OnPetStartDisappear;

	public Action<BattlePetVO> OnPetAppear;

	public Action<BattlePetVO> OnPetDisappear;

	public Action<Unicorn> OnUnicornHitted;

	public Action OnTortoiseShieldHitted;

	public Action OnPhoenixDestroy;

	public Action<float> SetTridentPartDuration;

	public Action<float> SetTridentDualHitRise;

	public Action<float> CallTridentPartExternal;

	public Action TridentStatueDisapear;

	public Action OnTridentSweep;

	public Action<EntityBase> OnTridentDivinePunishTrigger;

	public Action<Vector3, EntityBase, Vector3> TriggerTridentSweepExternal;

	public Action<EntityBase, EntityBase, bool> CastTridentDivinePunishExternal;

	public Action<int> OnNewPlay126CastSkill;

	public Func<int> OnNewPlay126CallSkillNewBuffID;

	public Action<EntityBase> OnNewPlay126CreateMonster;

	public Action<EntityBase> OnNewPlay126CreateMonsterPart;

	public Action CastSwiftWave;

	public Action OnCastSwiftWave;

	public Action<int, float, float[], float[]> SetSwiftWaveParams;

	public Action<ArtifactType, Transform, float, float, Vector3, float> OnArtifactSkill2201BulletFlyOut;

	public Action OnArtifactSkill2201SkillEnd;

	public Action OnArtifactSkillPropertyChange;

	public Action OnShieldResistOnceDmg;

	public Func<EntityBase, long, HitStruct, bool> OnBoxingGloveResistDmg;

	public Func<EntityBase, long, HitStruct, bool> OnAthenaFlashResistDmg;

	public Func<EntityBase, long, HitStruct, bool> OnAthenaWarGodResistDmg;

	public Func<int[]> OnArtifactSkill2208GetExtraBulletID;

	public Func<EntityBase, int, float, BulletBase> OnArtifactSkill2208CreateExtraBullet;

	public Func<int, int, float> OnArtifact201BulletHit;

	public Action<BulletBase, bool> OnArtifactSkill2214CreateBullet;

	public Action<EntityBase, float, Vector3, bool> OnArtifactSkill2214SendBulletToTarget;

	public Action<bool> OnArtifactSkill2214Trigger;

	public Func<bool> OnArtifactSkill2214BulletSendBySelf;

	public Action OnArtifactSkill2214EffectRecycle;

	public Action<EntityBase> OnArtifact303BulletHitEnemy;

	public Func<int> OnArtifact303ExtraRandomCount;

	public Action<EntityBase, float, Vector3> OnArtifactSkill2214EntitySendBullet;

	public Func<float> OnArtifactSkill2214ExtraRadius;

	public Action<int, bool> OnArtifact302ShieldCountChange;

	public Func<ArtifactType> OnArtifactSkill2230Type;

	public Action<bool> OnArtifact302SkillStatusChange;

	public Func<bool> OnArtifact302SkillStatus;

	public Func<bool> OnWukongChangeStatus;

	public Action<bool> OnSkill2230Event;

	public Action<int> OnAthenaFlashLayerChanged;

	public Action<int> OnAthenaRequestAddFlashLayer;

	public Action<float> OnAthenaRequestAddFlashEnergy;

	public Action<int> OnAthenaSetFlashLayerMax;

	public Action<float> ExternalSetRadiusRise;

	public Action<float> ExternalSetExtraHitRise;

	public Action<EntityBase, HitStruct> OnAthenaCloseRangeHit;

	public Action<EntityBase, HitStruct> OnAthenaFlashConsumed;

	public Action<EntityBase, bool> OnAthenaRequestCreateWhirlwind;

	public Action<BulletBase, EntityBase> OnAthenaWhirlwindCreated;

	public Action<float> OnAthenaSetFlashEnergyRatio;

	public Action OnAthenaFlashLayerGained;

	public Action<AnimationCtrlBase.AniClass> OnSendEvent;

	public Action<EntityPartBodyBase> OnCreatePartBody;

	public Action<BulletBase> OnCreateSkillStickBullet;

	public Action<BulletBase> OnCreateStickBullet;

	public Action OnSuperWuKongStart;

	public Action OnSuperWuKongEnd;

	public Action<float, float> OnThunderAddPercentChanged;

	public Action<float, float> OnThunderAddChanged;

	public Action<float, float> OnBulletSpeedChanged;

	public Action<EntityBase> OnAfterTD1847Transport;

	public Action OnFirstMonsterCreatedPerWave;

	public Action<EntityBase> OnZeusFireRingHitEnermy;

	public Action<float> ChangeCallOwlElfRate;

	public Action OnOwlElfResistHit;

	public Action<float> ChangeCallDragonRate;

	public Action OnCallInkDragon;

	public Action<float> ChangeInkDragonCritValue;

	public Action<int> AddMaxDizzyTimes;

	public Action<EntityBase> CastMegaStormExternal;

	public Action OnGodStateStart;

	public Action OnGodStateEnd;

	public Func<float> ZeusThunderFallHitRise;

	public Action OnBeforeRunWuKongStretchAI;

	public Action OnAfterRunWuKongStretchAI;

	public Action RunWuKongStretchAI;

	public Action OnBeforeRunWuKongHitGroundAI;

	public Action OnAfterRunWuKongHitGroundAI;

	public Action RunWuKongHitGroundAI;

	public Action OnBeforeRunWuKongAI;

	public Action OnAfterRunWuKongAI;

	public Action RunWuKongAI;

	public Action ClearRunWuKongAI;

	public Action RunWukongTwirlSkill;

	public Action OnCancelDisguisedManually;

	public Action OnWuKongCloudStart;

	public Action OnWuKongCloudEnd;

	public Action<EntityPartBodyBase> OnCreateWuKongPart;

	public Action<EntityBase, Vector3, Vector3> OnWuKongCastStick;

	public Action<float> WuKongStickBulletAttackRise;

	public Action<int> SetWuKongStickIdExternal;

	public Action<int> SetWuKongTCPPartNum;

	public Action<int> CreateWuKongPartExternal;

	public Action<float, float> SetTCPCDReduceExternal;

	public Action<EntityBase> CallTCPExternal;

	public Action<float> WuKongStickRateAdd;

	public Action<bool> OnEnterKnightKing;

	public Action<float> OnAddKnightKingDuration;

	public Action<float, float, int> OnImpulseEnhanced;

	public Action<float> ImpulseDurationAdd;

	public Action<float> ImpulseCDTimeAdd;

	public Action<float> OnEnableHorizontalImpulse;

	public Action<float> OnReduceEnterKnightKingCdTime;

	public Action<float> OnSetIntoKnightKingTime;

	public Action OnNextImpulseMustHit;

	public Action<float> OnSetSliderPauseTime;

	public Action<bool> OnEnterKnightKingPause;

	public Action CastImpulseExternal;

	public Action OnCastImpulse;

	public Action OnImpulseSequenceEnd;

	public Action<string[]> SetImpulseEffPath;

	public Action OnAfterChangeHPAction;

	public Action OnWillStartSphereFlash;

	public Action OnReleaseFlashChainBullet;

	public Action OnCancelSphereFlash;

	public Action OnFireworksDragonRelease;

	public Action<BulletBase> OnBeforeBulletDestroyed;

	public Action OnTDCoinChanged;

	public Action OnCreateTower;

	public Action OnDebuffListChanged;

	public Action OnPartBody1820AttackValuePercentChanged;

	public Action<bool, EntityPartBodyBase> OnPartBodyCountChanged;

	public Action<HitStruct, EntityBase> OnCommonConsecutiveHitAction;

	public Action<bool> InsidePVPGrass;

	public Action<bool> InsideEnemyRadar;

	public Action<long> OnHPChangedInPVP;

	public Action OnPvpRadarChanged;

	public Action OnPvpAnchorChanged;

	public Action<EntityBase> OnFirstHittedByLavaDragonBullet;

	public Action<EntityPartBodyBase> OnPartBodyDisappear;

	public Action<BulletBase> OnMelinda420014SkillBulletCreated;

	public Action<int> OnAfterMelindaSkillBullet;

	public Action<EntityBase> MakeBarrageExternal;

	public Action<bool> SetBarrageDouble;

	public Action CreateSlopeBulletExternal;

	public Action OnCreateSlopeBulletTiger;

	public Action<float> TigerMeteoriteHitRise;

	public Action<int> TigerMeteoriteCertainlyTimes;

	public Action OnOpheliaPartHitMax;

	public Action OnEntity3125MoveEnd;

	public Action<bool> OnElaineInvincibleAction;

	public Action<EntityEmerald> OnEmeraldHitted;

	public Action OnShadowDragonRelease;

	public Action<GameObject> OnEnterCollider;

	public Action<GameObject> OnExitCollider;

	public Action<BulletBase> OnBulletDeInit;

	public Action<long> OnRecoverByVampire;

	public Action<long> OnRecoverByKillVampire;

	public Action<EntityBase, long> OnRecoverByKillVampireOverflow;

	public Action OnRecoverByHPDrop;

	public Action OnBullet1194Destroyed;

	public Action<Equip_equip, Action<EntityBase>> OnBraceletSkillTriggered;

	public Action<WeaponBase> OnBeforeBulletContinue;

	public Action<WeaponBase> OnAfterBulletContinue;

	public Action<float, BulletBase> OnTrackBulletAngle;

	public Action<WeaponBase> OnBeforeDoAttack;

	public Action<WeaponBase> OnAfterDoAttack;

	public Action<float, float> OnMissRateChanged;

	[CompilerGenerated]
	private Func<EntityBase, HitStruct, HitType> m_OnChangeHitTypeEvent;

	[CompilerGenerated]
	private Action<EntityBase, bool> m_OnHeadShot;

	public Action<float, float> OnAttackSpeedChanged;

	public Action<float, float> OnAttackValuePercentChanged;

	public Action OnAllBabiesInstalled;

	public Action<float, float> OnCritRateChanged;

	public Action<EntityBase, BulletBase.ConsecutiveHitsData> OnConsecutiveHit;

	public Action OnSpaceDragonPortal;

	public Action OnCustomDefaultAnim;

	public Action<JoyData> OnAttackStart;

	public Action<float> OnRotateAngleChanged;

	public Action<bool> OnPlayHittedAction;

	public Action<bool, HitStruct> OnUmbrellaEnabledAction;

	[CompilerGenerated]
	private Action<int> m_OnInvincibleAction;

	public Action<bool> OnHammerChangeState;

	public Action<int> OnHammerValue;

	public Action<int> OnThunderValue;

	public Action<bool> OnHammerBtnEnable;

	public Action OnWeaponCreatedAllBullets;

	public Action<BulletBase> OnAfterSetBulletAttribute;

	public Action<bool> OnTridentChangeState;

	public Action<float, float> OnDivinityValueChanged;

	public Action<bool> OnTridentBtnEnable;

	public Action<bool> OnLanceChangeState;

	public Action<float, float> OnDarkEnergyValueChanged;

	public Action<bool> OnLanceBtnEnable;

	public Action<long, long> OnUpdateDemonShieldShildPercent;

	public Action<float> OnAddDemonShieldShildPercent;

	[CompilerGenerated]
	private Action<BulletBase> m_OnBigShieldResistEvent;

	public Action<BulletBase> OnCreateMeteor;

	public Action<EntityBase> OnNewPlay125WandHitEnemy;

	public Action<EntityBase, Vector3, HitStruct> OnKillAction;

	public Action<EntityBase, HitStruct, HittedData> OnPreHitAction;

	public Action<EntityBase, HitStruct, HittedData> OnHitAction;

	public Action<HitStruct> OnPVPHitFinalCaculate;

	public Action<HitStruct> OnPVPHitFinal;

	public Func<EntityBase, HitStruct, HittedData, AllHitActionVO> OnAllHitAction;

	public Action OnEatChickenLeg;

	public Action OnEatDragonSoul;

	public Action OnAbsorbStar;

	public Action OnHitByBullet;

	public Action<HitStruct> OnHitByBullet2;

	public Action OnHitByBulletInvincible;

	public Action<BulletBase, Collider> OnHitWallAction;

	public EntityBaseFunc<EntityBase, HitStruct> OnHittedDelegate;

	public Action OnSkillActionEnd;

	public Action OnWillDead;

	public Action<EntityBase> OnWillDeadWithEntity;

	public Action<long, long, float, long> OnChangeHPAction;

	public Action<long, long> OnMaxHpUpdate;

	public Action<EntityBase> OnMonsterDeadAction;

	public Action<EntityBase, HitStruct> OnMonsterDeadActionWithHitStruct;

	public Action OnLevelUpBefore;

	public Action<int> OnLevelUp;

	public Action<long> Shield_CountAction;

	public Action<long, long> Shield_ValueAction;

	public Action<bool> OnMoveEvent;

	public Action OnMovePathNodeEnd;

	public Action OnMissAngel;

	public Action OnMissDemon;

	public Action OnMissShop;

	public Action OnInBossRoom;

	public Action<EntityBase, long> OnHitted;

	public Action<EntityBase, long, HitStruct> OnHittedWithHitStruct;

	public Action<bool> OnFlyWaterChange;

	public Action<HitStruct, EntityBase> OnHitted2;

	public Action<EntityBase, long> OnCrit;

	public Action<EntityBase, long, HitStruct> OnCritWithHitStruct;

	public Action OnFullHP;

	public Action<bool> OnDizzy;

	public Action<bool, BuffAloneBase> OnDizzyByBuff;

	public Action OnMiss;

	public Action<HitStruct> OnMissWithHitStruct;

	[CompilerGenerated]
	private Action<Vector3> m_Event_PositionBy;

	public Action CreateFireEffect;

	public Action<EntityBase> OnLight45;

	public Action<int> LearnNewSkillAction;

	public Action<int> PartBodyRemove;

	public Action<EntityBase> OnPoisionDeadAction;

	public Action<EntityBase, HitStruct, HittedData> OnElementHitAction;

	public Action<Vector3, Vector3> OnPortalCrossAction;

	public Action<int, Vector3, Vector3> OnAyanaPortalCrossAction;

	public Action<int> ChangeAyanaCallPortalRate;

	public Action<string> OnResetYunnaCDTimes;

	public Action<bool> OnBodyAlphaSwitch;

	public Action<bool> OnAquaChangeState;

	public Action OnAyanaCallPortal;

	public Action<int> ChangeBonniePartLimit;

	public Action<EntityBase> CallBonniePart;

	public Action<bool> BlazoDecisionChange;

	public Action OnRebornEvent;

	public Action<BattleModuleData.UseRebornType> OnRebornAction;

	public Action OnRebornTimeScale;

	public Action OnAfterIncreaseRebornCount;

	public Action<long> OnChargeGridEvent;

	public Action<EntityBase, HitType, long, int> OnPiercingMoreHitEvent;

	public Action<EntityBase, EntityBase, long, HitType, HitBulletStruct> OnRemoteMoreHitEvent;

	public Action<FoodBase> OnAbsorbHpFood;

	public Action OnAbsorbMpFood;

	public Action OnOpheliaAbsorbSoul;

	[CompilerGenerated]
	private Action<long> m_OnRecoverEvent;

	[CompilerGenerated]
	private Func<EntityBase, long, long> m_OnHitChangeEvent;

	public Action OnAFuUseReviveSkillEvent;

	public Action<EntityBase> OnBodyHitEvent;

	public Action<HitStruct> OnBodyHitByArgs;

	public Action OnCollisionWallEvent;

	public Action OnCollisionWallExitEvent;

	public Action OnArrowEjectChangeEvent;

	public Action OnReboundWallChangeEvent;

	public Action<BulletBase, float> OnCreateFlySwordEvent;

	public Action<Collision> OnCollideWithObstaclesEvent;

	public Action<Collision> OnCollideWithObstaclesExitEvent;

	public Action OnThroughDoor;

	public EntityBaseFunc<HitStruct, EntityBase> OnCalHitRaiseFunc;

	public EntityBaseFunc<HitStruct, EntityBase> OnCalCritRateFunc;

	public EntityBaseFunc<HitStruct, EntityBase> OnCalCritValueFunc;

	public EntityBaseFunc<BulletBase, EntityBase> OnThroughEnemyFunc;

	public Action<float> OnBodyScaleEvent;

	public Action<float, float> OnBodyScaleChanged;

	public Action<BodyMask> OnHeroMeshChanged;

	public Action<BulletSlopeBase> OnMeteoriteMissEvent;

	public Action OnBabiesIntalledAction;

	public EntityBaseFunc<HitStruct, EntityBase> OnCalBulletFlyDisFunc;

	public Action<bool, BulletBase> OnBulletEnterSpeedReduceField;

	[CompilerGenerated]
	private Func<EntityBase, IEnumerable<(int id, int cnt, bool inherit, bool drop)>> m_OnDeadDivideFunc;

	public Action<EntityBase, EntityBase, int> OnBuffAddEvent;

	public Action<EntityBase, int> OnBuffRemoveEvent;

	public Action<EntityBase, int> OnBuffRemoveByTime;

	public Action<GameObject, BulletBase> OnHitShieldAction;

	public Func<GameObject, BulletBase, bool> OnHitShieldAction2;

	public Action<float> OnAllSpeedChangeAction;

	public Action OnAfterDragonSkillAttackEnd;

	public Action OnAfterDragonSkillAttackingEnd;

	public Action<EntityBase, EElementType> OnRotateBallHitAction;

	public Action<EntityBase> OnRotateBallKillAction;

	public Action<EntityBase, EElementType> OnRotateSwordHitAction;

	[CompilerGenerated]
	private Func<int, bool> m_OnBulletIsFlySwordAction;

	[CompilerGenerated]
	private Func<int, bool> m_OnBulletIsMeteoriteAction;

	[CompilerGenerated]
	private Func<int, bool> m_OnBulletIsMeteorAction;

	[CompilerGenerated]
	private Func<int, float> m_OnCreateFlySwordAction;

	[CompilerGenerated]
	private Func<float> m_OnCalExcuteKillAddEvent;

	[CompilerGenerated]
	private Func<long, float> m_OnCalRecoverAddEvent;

	[CompilerGenerated]
	private Func<bool> m_OnCanMoveEvent;

	[CompilerGenerated]
	private Func<bool> m_OnCanTriggerChargeGridFullEvent;

	[CompilerGenerated]
	private Func<int, float> m_OnCalReboundWallHitRatioEvent;

	public Action<BulletBase> BulletReboundWallEvent;

	public Action<BulletBase> OnCreateForwardBulletAction;

	public Action<BulletBase> OnCreateForwardBulletOnlyAction;

	public Action<BulletBase> OnCreateForSideBulletAction;

	public Action<BulletBase> OnCreateBulletAction;

	public Action<bool> OnCanMoveWithAttackAndRotateToTarget;

	private bool canMoveWithAttackAndRotateToTarget;

	[CompilerGenerated]
	private Action<long> m_OnPartBulletThroughEnemyChangedEvent;

	public Action OnResetHpAction;

	public Action<int> LightingAttackTarget;

	public Action AngelRoomSelectAction;

	public Func<float> LightingAttackCritProb;

	public Func<float> LightingAttackCritDmg;

	public Action LightingShieldDestroyed;

	public Action<bool> ExistShield;

	public Func<float> FlamingoAddDmg;

	public Func<float, float> RotateSword1ExtraDmg;

	public Func<float, float> RotateSword2ExtraDmg;

	public Func<float, float> RotateSword3ExtraDmg;

	public Func<float, float> RotateSword4ExtraDmg;

	public Func<float, float> RotateBall1ExtraDmg;

	public Func<float, float> RotateBall2ExtraDmg;

	public Func<float, float> RotateBall3ExtraDmg;

	public Func<float, float> RotateBall4ExtraDmg;

	public Func<float, float> RotateBall5ExtraDmg;

	public Func<bool> RotateBallChangeSpecial;

	public Action OnRotateNeedChange;

	[CompilerGenerated]
	private Action<string> m_AddAnimationClipEvent;

	public Func<bool> IsDemonStatus;

	public Action<Vector3> OnBlackHoleSkillEnd;

	public Action<EntityBase, Vector3> OnTryReSendBlackHole;

	public Action<EntityBase, Vector3> NeedSendBlackHoleOnly;

	public Action OnEnterDemonStatus;

	[CompilerGenerated]
	private Func<int, float> m_OnBulletScaleEvent;

	[CompilerGenerated]
	private Func<bool> m_OnCanRotateEvent;

	[CompilerGenerated]
	private Func<int> m_FlySwordCntFunc;

	public Dictionary<ArtifactType, float> AllArtifactSkillData;

	private List<int> mBabySkillIds;

	private List<long> mBabyArgs;

	private List<Vector3> mBabyGroundPos;

	private int mBabyGroundIndex;

	private const float SQR_RADIUS = 1f;

	private float enemyRadius;

	private float selfRadius;

	private List<int> DebuffList;

	public bool isExcuteBuff_5295;

	public bool AutoUpdateTouch;

	private int mCallID;

	private Vector3 mCallEndPos;

	private Func<object, bool> m_callCondition;

	public bool UseCustomLayerMask;

	public EntityHitCtrl mHitCtrl;

	public int collidercount;

	private List<EntityCtrlBase> ctrlsList;

	public const string ROTATE_EMERALD_NAME = "RotateEmerald";

	private const float ROTATE_PER_FRAME_OF_EMERALD = 0.5f;

	private RotateClass mRotateEmerald;

	public ActionShadowDragon ShadowAction;

	public ActionCallSkullSlaves CallSalves;

	public ActionCallSwords CallSwords;

	public float fireDragonHitRatioByLavaDragon;

	public float shieldRatioByLavaDragon;

	public bool HitByLavaDragon;

	public HashSet<int> AllEffectWeakenElementBullet;

	private Dictionary<EntityBase, BulletBase.LightData> mLightList;

	private Dictionary<EntityBase, BulletBase.LaserData> mLaserList;

	private Dictionary<EntityBase, BulletBase.LaserData> mConsecutiveHitsList;

	public float HittedLastTime;

	private float hittedForceInterval;

	private float lastHittedForceTime;

	private bool bCanHit;

	private GameObject CantHitTarget;

	private GameObject HitTarget;

	private EntityBase triggerentity;

	private float triggertime;

	private bool isinTrigger;

	private long hittedvalue_currentroom;

	protected Sequence mDeadSeq;

	public const int MaxEnergizedHPDropCount = 100;

	public bool SufferZeusThunderCircleDebuff;

	public bool CanExecuteAIInHide;

	public bool bCall;

	protected ActionBasic mAction;

	private int divide_frame;

	private int divide_maxframe;

	private Vector3 dividemove;

	public List<int> ImmunityBulletIds;

	private Vector3 _position;

	private Vector3 _eulerAngles;

	private Rigidbody _rigid;

	private int move_layermask;

	private const float move_offset = 0.05f;

	private float check_mindis;

	private RaycastHit[] move_hits;

	private RaycastHit move_hit;

	private float move_dis;

	private Vector3 move_vec;

	private List<Transform> hits;

	private int mSuperArmor;

	private float rotateSpeedPerSecond;

	private float radius;

	private float offset;

	private bool owlElfScaleEnabled;

	private float scale;

	private float appearDuration;

	private float disappearDuration;

	private RotateAroundAxis rotateOwlElfContainer;

	private List<OwlElf> owlElfList;

	public float _DoubleRate;

	public List<int> AvailableElementDebuffsForPartBody;

	protected Dictionary<int, PartBodyData> mPartBodyList;

	private int PartBody_AliveCount;

	private int PartBody_MaxCount;

	public const string PVP_GRASS_LOG_TAG = "[PVP_GRASS]";

	public float LightAttackPercent;

	public int SpearBulletContinueCount;

	public bool IsExtraBulletForwardOfMagicBookEnabled;

	public CritFakeBuff critFakeBuff;

	public KillFakeBuff killFakeBuff;

	public KillFake2Buff killFake2Buff;

	public HittedFakeBuff hittedFakeBuff;

	public GetHPDropFakeBuff getHPDropFakeBuff;

	private Dictionary<int, RotateFollowData> mRotateFollowList;

	private Dictionary<int, int> mRotateIndexList;

	private RotateBallClass mRotateAttribute;

	private RotateBallClass mRotateSword;

	private RotateClass mRotateShield;

	private RotateClass mRotateArcheroShield;

	private RotateSickleClass mRotateSickle;

	private RotateClass mRotateMulanSword;

	private RotateClass mRotateMeowStar;

	private RotateClass mRotateSummerAction;

	private RotateClass mRotateGhostFire;

	private RotateClass mRotateWuKongFirecracker;

	private float mInitialRotateAttributeValue;

	private float mInitialRotateSwordValue;

	private float mInitialRotateShieldValue;

	private float m_fBallExponent;

	private float m_fBallAddtionMax;

	private float m_fSwordExponent;

	private float m_fSwordAddtionMax;

	private float m_fSickleExponent;

	private float m_fSickleAddtionMax;

	public const float MAX_ROTATE_SPEED_UP = 2f;

	public const string RotateShield = "RotateShield";

	protected Dictionary<int, SkillBase> skillsList;

	protected Dictionary<int, SkillBase> skillsAutoList;

	protected List<SkillBase> skillsAttributeList;

	private List<SkillBase> skillsOverlyingList;

	public List<int> add_skill_list;

	public List<int> add_magicbook_skill_list;

	public List<int> SkillIdsForPartBody;

	public List<int> AvailableSkillIdsForPartBody;

	public List<int> DirectSkillIdsForPartBody;

	public List<int> HitCreate2BulletIdList;

	[JsonIgnore]
	public Dictionary<int, (bool, float)> HitCreate2BulletAttackRatio;

	protected float SkinHeadShotRate;

	private Dictionary<int, bool> m_PhorenHeadShots;

	protected Dictionary<string, float> CumulatedElementHitDict;

	public Dictionary<int, float> ElaineEnemyDict;

	public OpheliaSkin320006 opheliaSkin320006;

	public ElaineSkin320015 elaineSkin320015;

	public const int Melinda420014_BulletId = 7214;

	public const int Melinda420014_BulletId_PVP = 7215;

	private float deltaHPMaxFactor;

	public float EventDemonReduceHPRate;

	public int HPDrop3InSkillAlone1644;

	public bool ForceDeadRecover;

	public int WillDeadBuffId;

	private bool _IsWuKongCloudWorking;

	public const int WuKongRotatingStickBulletId = 8906;

	public const int AssistWuKongRotatingStickBulletId = 8909;

	public const int FallWuKongBulletId = 8911;

	public const int SuperWuKongFallBulletId = 8912;

	public ActionBasic WuKongAI;

	public const int InkDragonBulletId = 1539;

	public Dictionary<string, int> InkDragonBulletDebuffDict;

	private bool isInKnightKing;

	private bool isInKnightKingPausing;

	public string EFF_ARTHUR_KING;

	public string EFF_ARTHUR_KING_CHANGE;

	public string EFF_ARTHUR_KING_TRAIL;

	public string EFF_ARTHUR_KING_QUIT;

	public int flashConsumeBuffId;

	public const int FlashChainBulletId = 9039;

	private int _CurSphereFlashGrids;

	public ActionGodState GodState;

	public ConditionTime ImmunityHammerHitCD;

	public ConditionTime ImmunityFlashChainHitCD;

	public const string REBORN_TAG = "[RebornOnChangeHP]";

	public ConditionTime ReleaseFlashChainCD;

	public float Play114MovSpeed;

	public float Play114AccelerateSpeed;

	public float Play114MaxSpeed;

	public const string DefaultZeusShieldHammerModelId = "1210202";

	private float _UnrealZeusBackwardDis;

	private float _DemogorgonBackwardDis;

	public int HitCountByCapybaraSword;

	public HeroCapybaraSkillVO HeroCapybaraSkillVO;

	public bool LocalTowersCreated;

	public List<int> SkillIdsForTower;

	public Dictionary<int, List<int>> InheritSkillIdForTDDict;

	private const string sortingLayerName = "Player";

	[SerializeField]
	protected EntityType m_Type;

	private string _namep;

	public bool bDivide;

	private string mDivideID;

	private float unicornRotateSpeedPerSecond;

	private float unicornRadius;

	private float unicornY;

	private bool unicornScaleEnabled;

	private float unicornScale;

	private float unicornAppearDuration;

	private float unicornDisappearDuration;

	private RotateAroundAxis rotateUnicornContainer;

	private List<Unicorn> unicornList;

	public Dictionary<int, float> EnhanceWeaponDict;

	public GameObject m_WeaponHand;

	public GameObject leftWeapon;

	public GameObject rightWeapon;

	public int visibleCount;

	public int inVisibleCount;

	public string Tag => null;

	public ulong entityIndex { get; protected set; }

	public long InitialAttack => 0L;

	public int HitCountByBullet { get; set; }

	protected virtual string ModelPath => null;

	public GameObject Child => null;

	public float CreateTime { get; private set; }

	public virtual string TextureID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsNormal => false;

	public bool IsElite => false;

	public bool IsHell => false;

	public MapCreator.HeroModeData.SOLIDER_TYPE SoliderType
	{
		get
		{
			return MapCreator.HeroModeData.SOLIDER_TYPE.SOLIDER_TYPE_Normal;
		}
		set
		{
		}
	}

	public ATTACKTYPE AttackType => ATTACKTYPE.AttackType_None;

	public bool IsFlyType => false;

	public bool IsGroundType => false;

	public bool IsNearType => false;

	public bool IsFarType => false;

	public bool isRevert { get; protected set; }

	public EntityState State => EntityState.Normal;

	public EntityBase MeleeBabyTargetEnemy { get; set; }

	public virtual EntityBase m_HatredTarget
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int MeleeBabyPosIndex { get; private set; }

	public string[] DieEffects
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual string modelid
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3 PlayerOrientation => default;

	public float LastElementRecoverTimestamp { get; set; }

	public long DemonShieldShieldValue => 0L;

	public long DemonShieldShieldMax => 0L;

	public float OnCalCritRateRatio => 0f;

	public float OnCalBlackEnergyRatio => 0f;

	public float OnCalBlackHitRatio => 0f;

	public float OnCalBlackCritRateRatio => 0f;

	public float OnCalBlackCritValueRatio => 0f;

	public float OnCalExcuteKillAddRatio => 0f;

	public bool OnCalCanMove => false;

	public bool OnCanTriggerChargeGridFull => false;

	public bool CanMoveWithAttacking { get; set; }

	public bool CanMoveWithAttackAndRotateToTarget
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsRemoteBulletResist { get; set; }

	public bool CanRotate => false;

	public bool IsMeleeTargetEnemyAvailable => false;

	public bool CanBeSearchedByMeleeBaby => false;

	public bool CanBeAttackedByPartBody => false;

	public bool CanBeAttackedByPartBody1891 => false;

	public bool CanBeLockedByLavaDragon => false;

	public bool CanBeAttackedInCommon => false;

	public int CallID => 0;

	public Vector3 CallEndPos => default;

	public bool CanCall => false;

	public EntityHitCtrl HitCtrl => null;

	public bool IsPlayerColliderEnable => false;

	public float Radius => 0f;

	private Vector3 centerPos => default;

	public ActionRotateEmerald EmeraldAction { get; set; }

	public bool CanMeteorAsShield => false;

	public EntityBase CustomTarget { get; set; }

	public bool HasSetCustomTarget { get; set; }

	public bool IsAIStopped { get; set; }

	public bool IsSelf => false;

	private float intervalTime => 0f;

	public bool CheckPvpColliderCheat { get; set; }

	public bool ExtraAngelRecoverEnabled { get; set; }

	public bool AllowPartBodyLearnSkill { get; set; }

	public bool EnableFoodHPUpdateHPMax { get; set; }

	public TempMonsterMetaVO MeadowBattleMetaVO { get; set; }

	public float CurMeadowBattleSpeed => 0f;

	public float CurMeadowBattleAttackSpeed => 0f;

	public int MonsterPoints => 0;

	public int GameType5GroupID { get; set; }

	public Vector3 position => default;

	public Vector3 BodyForwardXZ => default;

	public Vector3 positionXZ => default;

	public Vector3 eulerAngles => default;

	protected Rigidbody rigid => null;

	public float LastCallOwlElfTime { get; set; }

	public float OwlElfLifeTime { get; set; }

	public int CurOwlElfCount => 0;

	public bool IsTDBase { get; set; }

	public bool IsInterfereTower { get; set; }

	public bool IsArtifact { get; set; }

	public bool IsTransporting { get; set; }

	public float DoubleRate
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool EnablePartBodyLearnElementDebuffs { get; set; }

	public int WeaponReboundCount { get; private set; }

	public float WeaponReboundRate { get; private set; }

	public float WeaponContinueRate { get; private set; }

	public int WeaponContinueCount { get; private set; }

	public float WeaponContinueRatio { get; private set; }

	public float RefineCrossBowRate { get; private set; }

	public int DebuffIdOfBulletForwardInMagicBook => 0;

	public float BraceletSkillTriggerRate { get; private set; }

	public float BraceletSkillTriggerDelay { get; private set; }

	public float BabyAttackRatio { get; private set; }

	public int RebornCount { get; set; }

	public bool IsReborn { get; set; }

	public float BallExponent
	{
		set
		{
		}
	}

	public float BallAddtionMax
	{
		set
		{
		}
	}

	public float SwordExponent
	{
		set
		{
		}
	}

	public float SwordAddtionMax
	{
		set
		{
		}
	}

	public float SickleExponent
	{
		set
		{
		}
	}

	public float SickleAddtionMax
	{
		set
		{
		}
	}

	public float BallPower => 0f;

	public int RotateSickleCount => 0;

	public bool LimitHpFromHitPercent { get; private set; }

	public bool IsMelinda420014 { get; set; }

	public bool CanCatBulletLearnElements { get; set; }

	public bool CanMelindaExtraArrowLearnCrit { get; set; }

	public bool TrapHitImmunityInAlpha { get; set; }

	public bool IsTransparentBody { get; set; }

	public float DeltaHPMaxFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public int WuKongCloudBuffId { get; set; }

	public bool HasWuKongCloudBuff { get; set; }

	public int CurLightedFlags { get; set; }

	public bool IsWuKongCloudWorking
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsDisguised { get; set; }

	public bool IsGodState { get; set; }

	public bool IsSphereFlash { get; set; }

	public bool IsTwirling { get; set; }

	public bool IsWuKongAIWorking { get; set; }

	public float TwirlingCDTime { get; set; }

	public bool IsHammerInMidRanged { get; set; }

	public int MaxWuKongPartCount { get; set; }

	public int CurWuKongPartCount { get; set; }

	public bool IsWuKongStickEffOn { get; set; }

	public int MaxInkDragonHitCount { get; set; }

	public float InkDragonMinHitRatio { get; set; }

	public bool IsInKnightKing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsInKnightKingPausing
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int CurSphereFlashGrids
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int MaxSphereFlashGrids { get; set; }

	public bool ReachMaxSphereFlashGrids => false;

	public float MeleeHammerDistance { get; set; }

	public float RangedHammerDistance { get; set; }

	public float MeleeLanceDistance { get; set; }

	public bool RebornOnChangeHP { get; set; }

	public bool IsPlay114SuperSkillEnabled { get; set; }

	public string ZeusShieldHammerModelStr { get; set; }

	public float UnrealZeusBackwardDis
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float DemogorgonBackwardDis
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool IsBowBulletEnhanced { get; set; }

	public int TeamID { get; protected set; }

	private string _name => null;

	public string DivideID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public EntityType Type => EntityType.Invalid;

	public float LastCallUnicornTime { get; set; }

	public float UnicornLifeTime { get; set; }

	public int CurUnicornCount => 0;

	public int Bullet5302Count { get; set; }

	public event Action Event_OnAttackPrePre
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

	public event Func<float> OnCalCritRateEvent
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

	public event Func<float> OnCalBlackEnergyEvent
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

	public event Func<float> OnCalBlackHitEvent
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

	public event Func<float> OnCalBlackCritRateEvent
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

	public event Func<float> OnCalBlackCritValueEvent
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

	public event Func<EntityBase, HitStruct, HitType> OnChangeHitTypeEvent
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

	public event Action<EntityBase, bool> OnHeadShot
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

	public event Action<int> OnInvincibleAction
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

	public event Action<BulletBase> OnBigShieldResistEvent
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

	public event Action<Vector3> Event_PositionBy
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

	public event Action<long> OnRecoverEvent
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

	public event Func<EntityBase, long, long> OnHitChangeEvent
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

	public event Func<EntityBase, IEnumerable<(int id, int cnt, bool inherit, bool drop)>> OnDeadDivideFunc
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

	public event Func<int, bool> OnBulletIsFlySwordAction
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

	public event Func<int, bool> OnBulletIsMeteoriteAction
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

	public event Func<int, bool> OnBulletIsMeteorAction
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

	public event Func<int, float> OnCreateFlySwordAction
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

	public event Func<float> OnCalExcuteKillAddEvent
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

	public event Func<long, float> OnCalRecoverAddEvent
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

	public event Func<bool> OnCanMoveEvent
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

	public event Func<bool> OnCanTriggerChargeGridFullEvent
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

	public event Func<int, float> OnCalReboundWallHitRatioEvent
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

	public event Action<long> OnPartBulletThroughEnemyChangedEvent
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

	public event Action<string> AddAnimationClipEvent
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

	public event Func<int, float> OnBulletScaleEvent
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

	public event Func<bool> OnCanRotateEvent
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

	public event Func<int> FlySwordCntFunc
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

	public void TriggerEvent_OnAttackPrePre()
	{
	}

	public void SetElite(bool value)
	{
	}

	public virtual void updateWithSpecialShader()
	{
	}

	public virtual void updateWithNormalShader()
	{
	}

	protected void InitWing(int nSkinId, int nWingId = 0, int star = 0, bool isSelf = true)
	{
	}

	public void DeInitWing()
	{
	}

	public void SetSelfAttributeData(SelfAttributeData data)
	{
	}

	public void SetRevert(bool pRev)
	{
	}

	public void ShowHP(bool show)
	{
	}

	public void ShowMesh(bool show)
	{
	}

	public bool GetMeshShow()
	{
		return false;
	}

	public void ShowEntity(bool show)
	{
	}

	private void ShowChallengeEntity(bool show)
	{
	}

	private EntityBase checkIfDisguised(EntityBase m_HatredTargetP)
	{
		return null;
	}

	private EntityBase checkIfValidInPVPGrass(EntityBase m_HatredTargetP)
	{
		return null;
	}

	protected virtual void OnInitAfter()
	{
	}

	private void OnRotateShieldSpeed()
	{
	}

	protected virtual void SetShadowSetting()
	{
	}

	public void KilledByBulletHandler(HitStruct data)
	{
	}

	protected virtual void InitAnimations()
	{
	}

	public bool isInitLogic()
	{
		return false;
	}

	public void CurrentHPUpdate()
	{
	}

	protected virtual void StartInit()
	{
	}

	public void Init(int id, string modelId)
	{
	}

	public void InitMeleeBabyLocation(int posIndex)
	{
	}

	public virtual void Init(int id)
	{
	}

	private GameObject createSingleShieldPrefab()
	{
		return null;
	}

	private GameObject createSingleShieldWithRaserPrefab()
	{
		return null;
	}

	private GameObject createSingleGoldShieldPrefab()
	{
		return null;
	}

	private GameObject createSingleGoldShieldWithRaserPrefab()
	{
		return null;
	}

	protected void OnGoldShieldNumChanged(long goldShieldCount)
	{
	}

	protected void OnShieldNumChanged(long shieldCount)
	{
	}

	private void DestroyContainterChildren(GameObject goShieldContainter)
	{
	}

	private void CreateRotateSingleObj(GameObject goShield, Transform parent, float scaleRatio, float deltaDegree, float radius, int i, Action<GameObject> OnCreateRotateSingleObj = null)
	{
	}

	protected virtual void OnInitBefore()
	{
	}

	protected virtual void OnInit()
	{
	}

	public virtual void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	protected void DeInitLogic()
	{
	}

	protected virtual void OnDeInitLogic()
	{
	}

	protected virtual void DeInitMesh(bool showeffect)
	{
	}

	public virtual void RemoveMove()
	{
	}

	public void DeadBefore()
	{
	}

	protected virtual void OnDeadBefore()
	{
	}

	protected string GetBodyString(string value)
	{
		return null;
	}

	protected virtual GameObject GetModel(string bodystring)
	{
		return null;
	}

	protected virtual void CreateModel()
	{
	}

	public virtual void OnAfterAnimCtrlInitialized()
	{
	}

	protected void GetClothId(ref int clothid)
	{
	}

	protected virtual void OnCreateModel()
	{
	}

	protected void InitEffects()
	{
	}

	protected virtual void OnInitEffects()
	{
	}

	protected virtual void InitCharacter()
	{
	}

	public virtual void InitWeapon(int WeaponID, bool isInitAnim = true)
	{
	}

	public void ChangeWeapon(int WeaponID, bool IsInitAnim = true)
	{
	}

	protected virtual void InitWeaponAnimations(int WeaponID)
	{
	}

	public virtual void PlayAttack()
	{
	}

	private void Update()
	{
	}

	protected virtual void UpdateProcess(float delta)
	{
	}

	protected virtual void UpdateFixed()
	{
	}

	public void AddHatredTarget(EntityBase entity)
	{
	}

	protected void StartDeadOffSet()
	{
	}

	private void UpdateDead()
	{
	}

	public bool GetIsInCamera()
	{
		return false;
	}

	public void SetFlying(bool fly)
	{
	}

	public bool GetFlying()
	{
		return false;
	}

	public bool GetFlyWater()
	{
		return false;
	}

	public void SetFlyStone(bool fly)
	{
	}

	public void SetFlyWater(bool fly)
	{
	}

	private void SetFlyOne(string layer, bool fly)
	{
	}

	public void SetFlyDragonStone(bool fly)
	{
	}

	protected virtual void OnSetFlying(bool fly)
	{
	}

	public void SetBodyScale(float value)
	{
	}

	public virtual float GetBodyScale()
	{
		return 0f;
	}

	public void GetGoods(int goodid)
	{
	}

	public void BattleInGetGoods(int goodid)
	{
	}

	private void GetGoodsInternal(int goodid)
	{
	}

	public void PlaySound(int soundid)
	{
	}

	public EntityBase GetTarget()
	{
		return null;
	}

	public void SetTarget(EntityBase target)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void GotoNextRoomAfter(RoomGenerateBase.Room room)
	{
	}

	protected virtual void OnGotoNextRoomAfter(RoomGenerateBase.Room room)
	{
	}

	protected virtual void OnRoomDoorOpenChange(bool isDoorOpen)
	{
	}

	protected virtual void CheckOpenCurSceneDoor(bool isOpenDoor)
	{
	}

	public void ChangeEnergy(EntityBase entity, long change)
	{
	}

	protected virtual void OnChangeEnergy(EntityBase entity, long change)
	{
	}

	public void InitEnergy_BattleIn(long value)
	{
	}

	protected virtual void OnInitEnergy_BattleIn(long value)
	{
	}

	public void InitCharge_BattleIn(long value)
	{
	}

	protected virtual void OnInitCharge_BattleIn(long value)
	{
	}

	protected virtual void OnDestroy()
	{
	}

	public void PlayAnim(string animName)
	{
	}

	public virtual bool CanBeDizzy()
	{
		return false;
	}

	public EntityOrientationEnum GetEntityOrientationEnum()
	{
		return EntityOrientationEnum.Forward;
	}

	public bool CanElementRecover()
	{
		return false;
	}

	public bool IsBodyType(Character_Char.BODYTYPE bodyType)
	{
		return false;
	}

	public void UpdateDemonShieldShildPercent(long current, long max)
	{
	}

	public HitType InvokeChangeHitTypeEvent(EntityBase entity, HitStruct hs)
	{
		return HitType.Normal;
	}

	public void HeadShot(EntityBase entity, bool lessHpHeadShot = false)
	{
	}

	public void InvokeInvincibleAction(int value)
	{
	}

	public void InvokeBigShieldResistEvent(BulletBase bullet)
	{
	}

	public void TriggerRecoverEvent(long hp)
	{
	}

	public long TriggerHitChangeEvent(EntityBase entity, long change)
	{
		return 0L;
	}

	public IEnumerable<(int, int, bool, bool)> OnDeadDivideEvent(EntityBase entity)
	{
		return null;
	}

	public bool OnHitShield(GameObject go, BulletBase bullet)
	{
		return false;
	}

	public bool OnBulletIsFlySword(int id)
	{
		return false;
	}

	public bool OnBulletIsMeteorite(int id)
	{
		return false;
	}

	public bool OnBulletIsMeteor(int id)
	{
		return false;
	}

	public float OnCreateFlySword(int nBulletId)
	{
		return 0f;
	}

	public float OnCalRecoverAddRatio(long hp)
	{
		return 0f;
	}

	public float CalReboundWallHitRatio(int cnt)
	{
		return 0f;
	}

	protected TResult InvokeFunc<T, TResult>(T t, Func<T, TResult> func, Func<TResult, TResult, TResult> resultFunc)
	{
		return default;
	}

	protected TResult InvokeFunc<T1, T2, TResult>(T1 t1, T2 t2, Func<T1, T2, TResult> func, Func<TResult, TResult, TResult> resultFunc, TResult defaultResult)
	{
		return default;
	}

	protected TResult InvokeFunc<TResult>(Func<TResult> func, Func<TResult, TResult, TResult> resultFunc)
	{
		return default;
	}

	protected TResult InvokeFunc<TResult>(Func<TResult> func, Func<TResult, TResult, TResult> resultFunc, TResult defaultResult)
	{
		return default;
	}

	public void OnRebornEventWrapper(BattleModuleData.UseRebornType rebornType)
	{
	}

	public void HammerChangeState(bool isThunderSpear)
	{
	}

	public void LanceChangeState(bool isLance)
	{
	}

	public void TridentChangeState(bool isLance)
	{
	}

	public void InvokePartBulletThroughEnemyChangedEvent(long value)
	{
	}

	public void InvokeAddAnimationClipEvent(string clipName)
	{
	}

	public float InvokeBulletScale(int id)
	{
		return 0f;
	}

	public int OnFlySwordCntFunc()
	{
		return 0;
	}

	public void InitArtifact()
	{
	}

	public void DeInitArtifact()
	{
	}

	public void SetArtifactItemActive(ArtifactItemData itemData, ArtifactItemStatus artifactItemStatus, bool needUpdateRotate)
	{
	}

	public ArtifactShowItem ChangeArtifactItemModel(int artifactID, string modelID)
	{
		return null;
	}

	public void UpdateArtifactSkillCDReduce(ArtifactType artifactType, float reduceCond)
	{
	}

	public float GetArtifactSkillCondNumReduce(ArtifactType artifactType)
	{
		return 0f;
	}

	public void UpdateArtifactSkillCDReducePercent(ArtifactType artifactType, float reduceCondPercent)
	{
	}

	public float GetArtifactSkillCondNumReducePercent(ArtifactType artifactType)
	{
		return 0f;
	}

	public void UpdateArtifactSkillDmgAddPercent(ArtifactType artifactType, float reduceCondPercent)
	{
	}

	public float GetArtifactSkillDmgAddPercent(ArtifactType artifactType)
	{
		return 0f;
	}

	public void UpdateArtifactSkillCritAddPercent(ArtifactType artifactType, float reduceCondPercent)
	{
	}

	public float GetArtifactSkillCritAddPercent(ArtifactType artifactType)
	{
		return 0f;
	}

	public void UpdateArtifactSkillCritValueAddPercent(ArtifactType artifactType, float reduceCondPercent)
	{
	}

	public float GetArtifactSkillCritValueAddPercent(ArtifactType artifactType)
	{
		return 0f;
	}

	public float GetArtifactSkillCondNum(ArtifactType artifactType, float originNum)
	{
		return 0f;
	}

	public float GetArtifactSkillDmg(ArtifactType artifactType)
	{
		return 0f;
	}

	public float GetArtifactSkillCrit(ArtifactType artifactType)
	{
		return 0f;
	}

	public float GetArtifactSkillSuperCrit()
	{
		return 0f;
	}

	public float GetArtifactSkillCritValue(ArtifactType artifactType)
	{
		return 0f;
	}

	public float GetAttrValueByAttrName(string attrName)
	{
		return 0f;
	}

	public void AddBabySkillID(int id)
	{
	}

	public void RemoveBabySkillID(int id)
	{
	}

	public void BabiesClone()
	{
	}

	public void SetBabyArgs(long value)
	{
	}

	public long GetBabyArgs(int index)
	{
		return 0L;
	}

	public int GetBabyGroundIndex()
	{
		return 0;
	}

	public Vector3 GetBabyGroundPos(int index)
	{
		return default;
	}

	private bool isQualifiedTargetEnemy2MeleeBaby(EntityBase entity)
	{
		return false;
	}

	private bool hasAroundEmptyGrids(EntityBase entity)
	{
		return false;
	}

	public bool HasAroundEmptyGrids(int radiusGrid = 1)
	{
		return false;
	}

	public bool CanAttackMeleeTargetEnemy()
	{
		return false;
	}

	public float GetSqrCheckRadius()
	{
		return 0f;
	}

	public int[] GetRandomElementDebuffs()
	{
		return null;
	}

	public int[] GetAvailableSkillIdsForPartBody()
	{
		return null;
	}

	public float GetAttackSpeedForPartBody(bool isMelee)
	{
		return 0f;
	}

	public float GetAttackSpeedForPartBodyByPercent(float percent)
	{
		return 0f;
	}

	public float GetDeltaBodyScaleForPartBody()
	{
		return 0f;
	}

	public void AddDebuff(int debuffid)
	{
	}

	public void RemoveDebuff(int debuffid)
	{
	}

	public List<int> GetDebuffList()
	{
		return null;
	}

	public bool ContainDebuff(int debuffId)
	{
		return false;
	}

	public void SetCallID(int callid, Vector3 endpos, Func<object, bool> condition = null)
	{
	}

	public float GetProcessedPartTime(int partid, float time)
	{
		return 0f;
	}

	public virtual void SetCollider(bool enable)
	{
	}

	public void SetFlyAll(bool enable = true)
	{
	}

	public float GetColliderHeight()
	{
		return 0f;
	}

	public void SetObstacleCollider(bool value)
	{
	}

	public void SetTrigger(bool value)
	{
	}

	public bool GetTrigger()
	{
		return false;
	}

	public void RemoveColliders()
	{
	}

	public float GetCollidersSize()
	{
		return 0f;
	}

	public void SetCollidersScale(float scale)
	{
	}

	public bool GetColliderEnable()
	{
		return false;
	}

	protected bool GetColliderTrigger()
	{
		return false;
	}

	public void AddColliderListener(Action<Collision> listener)
	{
	}

	public void RemoveColliderListener(Action<Collision> listener)
	{
	}

	public virtual bool CheckIfHitObstacles(float maxDistance, out RaycastHit hitInfo)
	{
		hitInfo = default;
		return false;
	}

	public virtual bool CheckIfHitObstacles(float maxDistance, Vector3 dir, out RaycastHit hitInfo)
	{
		hitInfo = default;
		return false;
	}

	private bool rayCast(Vector3 dir, float maxDistance, out RaycastHit hitInfo)
	{
		hitInfo = default;
		return false;
	}

	public virtual void PushCommand(BaseCommand cmd)
	{
	}

	public virtual void PushJsonCommand(string jsonData)
	{
	}

	public bool CanExecuteAndSyncAction()
	{
		return false;
	}

	public void SyncMapGoods(int id, int x, int y, float[] args = null)
	{
	}

	public void GetEffect(int fxId)
	{
	}

	public void PlayEffect(int fxId)
	{
	}

	public void PlayEffect(int fxId, Vector3 pos)
	{
	}

	public GameObject PlayEffect(int fxId, Action<GameObject> onComplete, Action<int, GameObject> onComplete2 = null)
	{
		return null;
	}

	public GameObject PlayEffect(int fxId, Vector3 pos, Action<GameObject> onComplete, Action<int, GameObject> onComplete2 = null)
	{
		return null;
	}

	public GameObject PlayEffect(int fxId, Vector3 pos, Quaternion rota, Action<GameObject> onComplete = null, Action<int, GameObject> onComplete2 = null)
	{
		return null;
	}

	public Transform GetKetNode(int index)
	{
		return null;
	}

	public Transform GetBulletCreateNode(Weapon_weapon data)
	{
		return null;
	}

	public void AddController<T>() where T : EntityCtrlBase, new()
	{
	}

	public T GetController<T>() where T : EntityCtrlBase
	{
		return null;
	}

	public void RemoveController<T>() where T : EntityCtrlBase
	{
	}

	public void RemoveControllers()
	{
	}

	public void ExcuteCommend(EBattleAction action, object data)
	{
	}

	public void ExecCommand(BaseCommand cmd)
	{
	}

	public void ExecStandaloneBuff(BuffCommand cmd)
	{
	}

	public void CreateRotateEmerald(int emeraldCount)
	{
	}

	public void CreateEmeraldContainer(float _radius)
	{
	}

	public void StartRotateEmeraldContainer()
	{
	}

	public void StopRotateEmerald()
	{
	}

	public Transform GetEmeraldContainer()
	{
		return null;
	}

	public RotateClass GetRotateEmerald()
	{
		return null;
	}

	public GameObject setSingleEmerald(GameObject emeraldPrefabInstance, Transform EmeraldContainer, float curDegree)
	{
		return null;
	}

	public void RelocateRemainEmeralds()
	{
	}

	public void ClearRotateEmerald()
	{
	}

	public GameObject createSingleEmeraldPrefabIntance()
	{
		return null;
	}

	public void SetCustomTarget(EntityBase entity)
	{
	}

	public void InitEffectWeakenElementBullet()
	{
	}

	public void ClearEffectWeakenElementBullet()
	{
	}

	public bool NeedEffectWeakenElementBullet(int hashCode)
	{
		return false;
	}

	public void SetEffectWeakenElementBullet(int hashCode)
	{
	}

	public BulletBase.LightData GetLightData(EntityBase source)
	{
		return null;
	}

	public BulletBase.LaserData GetLaserData(EntityBase source)
	{
		return null;
	}

	public BulletBase.LaserData GetConsecutiveHitsData(EntityBase source)
	{
		return null;
	}

	public HittedData GetHittedData(bool bulletthrough, float bulletangle)
	{
		return null;
	}

	public HittedData GetHittedData(BulletBase bullet)
	{
		return null;
	}

	protected virtual HittedData OnHittedData(HittedData data, bool bulletthrough, float bulletangle)
	{
		return null;
	}

	private bool GetCanHitted()
	{
		return false;
	}

	public virtual void UpdateHittedTime()
	{
	}

	public virtual bool SetHitted(HittedData data)
	{
		return false;
	}

	private bool IsHittedForceCDOver()
	{
		return false;
	}

	private bool canAddHitForce()
	{
		return false;
	}

	private bool canPlayHitted()
	{
		return false;
	}

	public Vector3 GetHittedDirection()
	{
		return default;
	}

	public void SetCanHit(bool value)
	{
	}

	private void CantTitTargetShow(bool show)
	{
	}

	public virtual Transform GetHittedMask()
	{
		return null;
	}

	public void PlayHittedSound()
	{
	}

	private void OnTriggerEnter(Collider o)
	{
	}

	protected virtual void OnTriggerEnterExtra(Collider o)
	{
	}

	private void OnTriggerExit(Collider o)
	{
	}

	protected virtual void OnTriggerExitExtra(Collider o)
	{
	}

	private void OnCollisionEnter(Collision o)
	{
	}

	private void OnCollisionExit(Collision o)
	{
	}

	protected virtual void CollisionEnterExtra(Collision o)
	{
	}

	protected virtual void CollisionExitExtra(Collision o)
	{
	}

	protected void TriggerEnd()
	{
	}

	private void TriggerStart()
	{
	}

	protected void TriggerEnter(GameObject o, Collision collision = null)
	{
	}

	protected void TriggerExit(GameObject o)
	{
	}

	private void OnTriggerUpdate()
	{
	}

	protected virtual bool HitEntity(EntityBase e)
	{
		return false;
	}

	public void AddHittedValueCurrentRoom(long value)
	{
	}

	private void ClearHittedValueCurrentRoom()
	{
	}

	public long GetHittedValueCurrentRoom()
	{
		return 0L;
	}

	public void ResetHP(int _hpSliderID)
	{
	}

	protected virtual void CreateHP()
	{
	}

	protected virtual void OnChangeHP(EntityBase entity, long HP)
	{
	}

	public void RefreshHpSlider()
	{
	}

	public void ChangeColliderRaidus(float radius)
	{
	}

	public virtual void ChangeHPNoLogic(EntityBase entity, long HP)
	{
	}

	public virtual void ChangeHP(EntityBase entity, long HP, HitStruct data = null)
	{
	}

	public virtual void ChangeHPMust(EntityBase entity, long HP, HitStruct data = null)
	{
	}

	public void ForcePlayDeadAnim()
	{
	}

	public void ForceDead(float timeScale = 0.8f)
	{
	}

	public void SurvivalDie()
	{
	}

	public void WaveClear()
	{
	}

	public void RoundClear()
	{
	}

	protected virtual void OnSurvivalDie()
	{
	}

	protected virtual void OnWaveClear()
	{
	}

	public virtual void DeadCallBack()
	{
	}

	public void DeadWithoutPlayAnim(bool showEffect = true)
	{
	}

	public void DeadWithoutPlayAnim(float timeScale, bool showEffect = true)
	{
	}

	private void DoDeadWithoutPlayAnim(float timeScale, bool showEffect)
	{
	}

	public void StartDeadPet()
	{
	}

	public void DeadPet()
	{
	}

	public void DeadPetWithPos()
	{
	}

	public void DeadInMeadowBattle()
	{
	}

	protected virtual void OnEntityDead()
	{
	}

	public virtual void SurvivalDeadCallBack()
	{
	}

	public virtual void WaveClearDeadCallBack()
	{
	}

	public virtual bool GetIsDead()
	{
		return false;
	}

	public bool CanCheckPvpColliderCheat()
	{
		return false;
	}

	public void MoveInMeadowBattle(Vector3 velocity)
	{
	}

	public void SwitchMeshLayer(int _layer)
	{
	}

	public void SetHpVisible(bool visible)
	{
	}

	public void OnPositionChangedEvent(Vector3 deltaPos)
	{
	}

	public bool IsSelfTeamInMeadowBattle()
	{
		return false;
	}

	protected virtual List<BattleDropData> OnGetGoodList()
	{
		return null;
	}

	public void DivideAction(float x, float z)
	{
	}

	private void RemoveDivideUpdate()
	{
	}

	private void OnDivideUpdate(float delta)
	{
	}

	public void AddImmunityBulletId(int bulletId)
	{
	}

	public void RemoveImmunityBulletId(int bulletId)
	{
	}

	public bool IsInBulletImmnity(int bulletId)
	{
		return false;
	}

	public List<EntityBase> PickAroundEnemy(float radius, int min, int max)
	{
		return null;
	}

	public void SetEulerAngles(Vector3 e)
	{
	}

	public void SelfMoveBy(Vector3 pos)
	{
	}

	public virtual void SetPosition(Vector3 pos)
	{
	}

	public void SetPositionBy(Vector3 pos)
	{
	}

	protected void SetPositionByInternal(Vector3 pos)
	{
	}

	protected virtual bool GetCanPositionBy()
	{
		return false;
	}

	protected virtual void OnSetPositionBy(Vector3 pos)
	{
	}

	private Vector3 GetMoveDistance(Vector3 pos)
	{
		return default;
	}

	public float GetBodyRadius()
	{
		return 0f;
	}

	private Vector3 check_pos(Vector3 pos)
	{
		return default;
	}

	public void SetSuperArmor(bool value)
	{
	}

	public virtual bool GetSuperArmor()
	{
		return false;
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

	public void UpdateNewPlay126SkillCDReduce(NewPlay126SkillType skillType, float reduceTime)
	{
	}

	public float GetNewPlay126SkillCDReduce(NewPlay126SkillType skillType)
	{
		return 0f;
	}

	public void InitParameters()
	{
	}

	public void InitOwlElfList()
	{
	}

	public bool HasOwlElf()
	{
		return false;
	}

	public void AddOwlElfCommand(OwlElf.SkinType skinType, string attribute)
	{
	}

	public OwlElf AddOwlElf(OwlElf.SkinType skinType, string attribute)
	{
		return null;
	}

	public void RemoveOwlElfCommand()
	{
	}

	public void RemoveOwlElfCommand(OwlElf targetOwlElf)
	{
	}

	private bool canSyncOwlElfInfo()
	{
		return false;
	}

	public void RemoveOwlElf()
	{
	}

	public int RemoveOwlElf(OwlElf targetOwlElf)
	{
		return 0;
	}

	public void RemoveOwlElfByIndex(int removedIndex)
	{
	}

	private void locateOwlElfBeforeAdded(GameObject go)
	{
	}

	private void relocateExistingOwlElfs()
	{
	}

	private void relocateOwlElfsByCount(int _count)
	{
	}

	private GameObject createOwlElfResource()
	{
		return null;
	}

	public void DestroyRotateOwlElfContainer()
	{
	}

	public void RemoveAllOwlElfs()
	{
	}

	public void AddElementDebuffForPartBody(int buffID)
	{
	}

	public EntityPartBodyBase CreatePartBody(int partbodyid, Vector3 pos, float time, bool isElite = false)
	{
		return null;
	}

	public EntityTD2023Base CreateTD2023(int tdId, Vector3 pos, float time, bool isElite = false)
	{
		return null;
	}

	public EntityArtifactBase CreateArtifact(int charId, Vector3 pos)
	{
		return null;
	}

	public EntityTrapBase CreateTrap(int trapID, Transform parent)
	{
		return null;
	}

	public EntityPartBodyBase CreatePartBody(int partbodyid, Vector3 pos, float time, string modelId, string textureId)
	{
		return null;
	}

	public void CreatePartBodyAsync(int partbodyid, Vector3 pos, float time, Action<EntityPartBodyBase> onLoaded)
	{
	}

	protected virtual void OnPartBodyRemove(EntityPartBodyBase entity, int partbodyid)
	{
	}

	protected virtual EntityPartBodyBase CreatePartBody(int partBodyID, Vector3 pos)
	{
		return null;
	}

	protected virtual EntityTD2023Base CreateTD2023(int tdId, Vector3 pos)
	{
		return null;
	}

	protected virtual EntityArtifactBase CreateArtifactInternal(int artifactCharId, Vector3 pos)
	{
		return null;
	}

	protected virtual EntityTrapBase CreateTrapNode(int trapID, Transform parent)
	{
		return null;
	}

	public virtual EntityPetBase CreatePet(int petId, Vector3 pos)
	{
		return null;
	}

	protected virtual EntityPartBodyBase CreatePartBodyByRes(GameObject resObj, int partBodyID, Vector3 pos)
	{
		return null;
	}

	protected virtual EntityTD2023Base CreateTD2023ByRes(GameObject resObj, int tdId, Vector3 pos)
	{
		return null;
	}

	protected virtual EntityTrapBase CreateTrapByRes(GameObject resObj, Transform parent)
	{
		return null;
	}

	protected virtual EntityArtifactBase CreateArtifactByRes(GameObject resObj, int tdId, Vector3 pos)
	{
		return null;
	}

	protected virtual EntityPetBase CreatePetByRes(GameObject resObj, Vector3 pos)
	{
		return null;
	}

	public List<EntityPartBodyBase> GetSelfPartBodyList()
	{
		return null;
	}

	public virtual float GetPartBodyBrightness()
	{
		return 0f;
	}

	public virtual bool IsDefaultIdleAnim()
	{
		return false;
	}

	public void HidePartBodySeparateBodies(EntityPartBodyBase partbody, int partbodyid)
	{
	}

	public void createCommonPartWrapper(int partId, Vector3 center, int _minCount, int _maxCount, int _minRadius, int _maxRadius, float _aliveTime, List<string> attrs)
	{
	}

	public void CreateCommonPart(int partId, Vector3 wPos, float aliveTime, List<string> attrs)
	{
	}

	public void CreateCommonPart(SyncCommonPartBodyVO vo)
	{
	}

	public void SyncCommonPart(int partId, Vector3 wPos, float aliveTime, List<string> attrs)
	{
	}

	public void UpdatePetEnergyChargeSpeedPercent(LocalSave.PetOne petOne, float deltaPercent)
	{
	}

	public float GetPetEnergyChargeSpeedPercent(LocalSave.PetOne petOne)
	{
		return 0f;
	}

	public void UpdatePetCritRatePercent(LocalSave.PetOne petOne, float deltaPercent)
	{
	}

	public float GetPetCritRatePercent(LocalSave.PetOne petOne)
	{
		return 0f;
	}

	public float GetPetCritValuePercent(LocalSave.PetOne petOne)
	{
		return 0f;
	}

	public void UpdatePetCritValuePercent(LocalSave.PetOne petOne, float deltaPercent)
	{
	}

	public void UpdatePetPlayerHPPercent(LocalSave.PetOne petOne, float deltaPercent)
	{
	}

	public float GetPetPlayerHPPercent(LocalSave.PetOne petOne)
	{
		return 0f;
	}

	public void UpdatePetPlayerAttackPercent(LocalSave.PetOne petOne, float deltaPercent)
	{
	}

	public float GetPetPlayerAttackPercent(LocalSave.PetOne petOne)
	{
		return 0f;
	}

	public bool CanNotBeAttacked()
	{
		return false;
	}

	public bool CanNotAttack()
	{
		return false;
	}

	public void SetWeaponReboundCount(int value)
	{
	}

	public void SetWeaponReboundRate(float value)
	{
	}

	public void SetWeaponContinueRate(float value)
	{
	}

	public void SetWeaponContinueCount(int value)
	{
	}

	public void SetWeaponContinueRatio(float value)
	{
	}

	public void ClearContinueSkills()
	{
	}

	public void SetRefineCrossBowRate(float value)
	{
	}

	public void SetBraceletSkillTriggerRate(float value)
	{
	}

	public void SetBraceletSkillTriggerDelay(float value)
	{
	}

	public void SetBabyAttackRatio(float value)
	{
	}

	public void IncreaseLightAttackPercent(float deltaValue)
	{
	}

	public void ClearLightAttackPercent()
	{
	}

	public void SetSpearBulletContinueCount(int value)
	{
	}

	public void ClearSpearBulletContinueCount()
	{
	}

	public int GetWeaponTypeByWeaponId(int weaponId)
	{
		return 0;
	}

	public bool IsWeapenTrident(int weaponId)
	{
		return false;
	}

	public EntityBase GetNearestEnemy()
	{
		return null;
	}

	public float GetEnergyGetPercent(EntityBase entity)
	{
		return 0f;
	}

	public void InitFakeBuffs()
	{
	}

	public void DeInitFakeBuffs()
	{
	}

	public void AddRotateFollow(EntityBase entity)
	{
	}

	public void RemoveRotateFollow(EntityBase entity)
	{
	}

	public Vector3 GetRotateFollowPosition(EntityBase entity)
	{
		return default;
	}

	public void SetRotateFollowIndex(int key, int index)
	{
	}

	public int GetRotateFollowIndex(int key)
	{
		return 0;
	}

	public void AddNewRotateAttribute(GameObject o, float fInitialSpeed, float radius)
	{
	}

	public int GetRotateAttributeCnt()
	{
		return 0;
	}

	private void OnAttackSpeedUpdate(int value)
	{
	}

	private void UpdateRotateBallSpeed(RotateBallClass rotate, int value, ref float initialValue)
	{
	}

	private void UpdateSwordRoateSpeed(RotateBallClass rotate, int value, ref float initialValue)
	{
	}

	private void UpdateShieldRotateSpeed(RotateClass rotate, int value, ref float initialValue)
	{
	}

	public float GetDeltaRotateSpeedPercent()
	{
		return 0f;
	}

	private void UpdateBallRotateSpeed(RotateClass rotate, int attackSpeedPercent, ref float initialValue, float rotateElementSpeedPercent)
	{
	}

	private void UpdateShieldRotateSpeed(RotateClass rotate, int attackSpeedPercent, ref float initialValue, float rotateElementSpeedPercent)
	{
	}

	private void UpdateSwordRotateSpeed(RotateClass rotate, int attackSpeedPercent, ref float initialValue, float rotateElementSpeedPercent)
	{
	}

	private void UpdateSickleRotateSpeed(RotateClass rotate, int attackSpeedPercent, ref float initialValue)
	{
	}

	public void UpdateShieldRotateSpeed(float rotate)
	{
	}

	public void RemoveRotateAttribute(GameObject o)
	{
	}

	public void AddNewRotateShield(GameObject o, float radius)
	{
	}

	public void AddNewRotateShield(GameObject o, float radius, float rotate)
	{
	}

	public void RemoveRotateShield(GameObject o)
	{
	}

	public void AddNewRotateArcheroShield(GameObject o, float radius, float rotate)
	{
	}

	public void RemoveRotateArcheroShield(GameObject o)
	{
	}

	public void AddNewRotateSword(GameObject o, float fInitialSpeed, float fRadius)
	{
	}

	public float GetAttackSpeedWrapper()
	{
		return 0f;
	}

	public float GetCritRateWrapper()
	{
		return 0f;
	}

	public float GetCritValueWrapper()
	{
		return 0f;
	}

	public int GetRotateSwordCnt()
	{
		return 0;
	}

	public void RemoveRotateSword(GameObject o)
	{
	}

	public void AddNewRotateSickle(GameObject o, float fInitialSpeed, float fRadius, float fDuration, float fInterval)
	{
	}

	public void RemoveRotateSickle(GameObject o)
	{
	}

	public void RemoveAllRotateSickle()
	{
	}

	public void AddRotateMulanSword(float fInitialSpeed, float fRadius, int cnt, Func<Transform, GameObject> createMulanSword)
	{
	}

	public void AddRotateSummerAction(float fInitialSpeed, float fRadius, int cnt, Func<Transform, GameObject> createSummer)
	{
	}

	public void AddRotateGhostFireAction(float fInitialSpeed, float fRadius, int cnt, Func<Transform, GameObject> createSummer)
	{
	}

	public void AddRotateWuKongFirecracker(float fInitialSpeed, float fRadius, int cnt, Func<Transform, GameObject> createFirecracker)
	{
	}

	public void AddNewRotateMeowStar(GameObject o, float radius, float rotate)
	{
	}

	public void RemoveRotateMeowStar(GameObject o)
	{
	}

	public void Add2DirectSkillIdsForPartBody(List<int> skillIds)
	{
	}

	public void Add2AvailableSkillIdsForPartBody(List<int> skillIds)
	{
	}

	public Dictionary<int, SkillBase> GetSkillsList()
	{
		return null;
	}

	public List<ObscuredInt> GetAllSKillIds()
	{
		return null;
	}

	public void AddSkillIdForPartBody(int skillId)
	{
	}

	public bool ContainsSkill(int id)
	{
		return false;
	}

	public void AddMagicBookSkill(int skillId)
	{
	}

	public void SaveMagicBookSkill()
	{
	}

	public virtual void AddSkill(int skillId)
	{
	}

	public virtual void AddSkill(int skillId, params object[] args)
	{
	}

	public virtual void RemoveSkill(int skillId)
	{
	}

	public void AddTmpSkill(int skillId, params object[] args)
	{
	}

	public virtual bool AddSkillInternal(int skillId, params object[] args)
	{
		return false;
	}

	private int checkIfDragonEquip(int skillId)
	{
		return 0;
	}

	public int GetFlySwordSkillCnt()
	{
		return 0;
	}

	public int GetMeteorSkillCnt()
	{
		return 0;
	}

	public int GetStarSkillCnt()
	{
		return 0;
	}

	protected virtual void OnAddSkillInternal(int skillId)
	{
	}

	protected virtual void OnRemoveSkillInternal(int skillId)
	{
	}

	public void AddSkillAuto(int skillId, params object[] args)
	{
	}

	public void AddSkillAttribute(int skillId, params object[] args)
	{
	}

	public void AddSkillBaby(int skillId, params object[] args)
	{
	}

	public void AddSkillDragon(int skillId, params object[] args)
	{
	}

	public void AddSkillOverLying(int skillId, params object[] args)
	{
	}

	public void AddSkillTest(int skillId)
	{
	}

	private void tryAntiCheat()
	{
	}

	private void UnInstallAllSkills()
	{
	}

	protected virtual void AddInitSkills()
	{
	}

	protected virtual void OnAfterAddInitSkills()
	{
	}

	public void BattleInInitSkill(int skillId)
	{
	}

	public void AddCharacterSkill(int skillId)
	{
	}

	public void AddSkinSkill(List<int> skillIds)
	{
	}

	public void AddWeaponSkinSkill(int weaponSkinId, int weaponSkinLv)
	{
	}

	private void AddSkillsInternal(List<int> skillIds)
	{
	}

	public void AddEffectSkill(int skillId, params object[] args)
	{
	}

	public bool IsAlreadyLearnOverlyingSkill(int skillid)
	{
		return false;
	}

	public bool IsAlreadyLearnSkill(int skillid)
	{
		return false;
	}

	public void AddTowerSkill(int skillId, params object[] args)
	{
	}

	public Dictionary<int, SkillBase> GetSkillList()
	{
		return null;
	}

	public SkillBase GetSkillBaseBySkillId(int skillId)
	{
		return null;
	}

	public bool CanHitCreate2(int bulletId)
	{
		return false;
	}

	public void Add2HitCreate2BulletIdList(List<int> list)
	{
	}

	public void RemoveFromHitCreate2BulletIdList(List<int> list)
	{
	}

	public float GetHitCreate2AttackRatio(int bulletId)
	{
		return 0f;
	}

	public void Add2HitCreate2BulletRatio(int bulletId, float attackRatio, bool isMainBullet)
	{
	}

	public void RemoveFromHitCreate2BulletRatio(int bulletId)
	{
	}

	public bool CanHeadShotByPhoren(int instanceId)
	{
		return false;
	}

	public float GetSkinHeadShotRate()
	{
		return 0f;
	}

	public void SetSkinHeadShotRate(float value)
	{
	}

	public void IncreaseElementHit(string elementType, float deltaElementHit)
	{
	}

	public void ClearElementHit(string elementType)
	{
	}

	public float GetElementHit(string elementType)
	{
		return 0f;
	}

	public bool IsMaxElementHit(string elementType, float maxElementHit)
	{
		return false;
	}

	public void ShowExplodeEffect(float explosionRadius)
	{
	}

	public void SetLimitHpFromHitPercent(bool value)
	{
	}

	public void EscapeFromObstacles()
	{
	}

	public void UpdateElaineEnemyDict(int enemyId, float reducePercent)
	{
	}

	public void ClearElaineEnemyDict()
	{
	}

	public float GetElaineEnemyPercent(int enemyId)
	{
		return 0f;
	}

	public void SetAlphaEffect(float alphaValue, bool shadowVisible)
	{
	}

	public void SetWeaponAlpha(float alphaValue)
	{
	}

	public void createWuKongPartWrapper(int partId, Vector3 center, int _minCount, int _maxCount, int _minRadius, int _maxRadius, float _aliveTime, List<string> attrs)
	{
	}

	public void CreateWuKongPart(int partId, Vector3 wPos, float aliveTime, List<string> attrs)
	{
	}

	public void CreateWuKongPart(Sync1890PartBodyVO vo)
	{
	}

	public void SyncWuKongPart(int partId, Vector3 wPos, float aliveTime, List<string> attrs)
	{
	}

	public bool IsWuKongRotatingStickBullet(int bulletId)
	{
		return false;
	}

	public bool IsFallWuKongStickBullet(int bulletId)
	{
		return false;
	}

	public bool IsSuperWuKongFallBulletId(int bulletId)
	{
		return false;
	}

	public bool IsInkDragonBullet(int bulletId)
	{
		return false;
	}

	public bool IsGearTowerBullet(int bulletId)
	{
		return false;
	}

	public void UpdateInkDragonBulletDebuffDict(string modelId, int debuffId)
	{
	}

	public int GetInkDragonBulletDebuffId(string modelId)
	{
		return 0;
	}

	public int GetTotalBulletCount()
	{
		return 0;
	}

	public void IncreaseSphereFlashGrids()
	{
	}

	public void ResetSphereFlashGrids()
	{
	}

	public float GetConfigGodShieldValue()
	{
		return 0f;
	}

	public Vector3 GetDefaultFlashChainDir()
	{
		return default;
	}

	public void SetHeroVisible(bool visible, float alpha)
	{
	}

	public void SetBodyOnlyVisible(bool visible)
	{
	}

	public Vector3 GetUnrealZeusTargetPos()
	{
		return default;
	}

	public Vector3 GetDemogorgonTargetPos()
	{
		return default;
	}

	public BulletBase CreateZeusFallThunderWrapper(int bulletId, Vector3 bulletPos, float atkPercent)
	{
		return null;
	}

	public BulletBase CreateZeusFallThunder(int bulletId, Vector3 bulletPos, float atkPercent)
	{
		return null;
	}

	public BulletBase CreateThunderFallBullet(int bulletId, Vector3 bulletPos, float atkPercent)
	{
		return null;
	}

	private void syncFallThunder(int bulletId, Vector3 bulletPos, float atkPercent)
	{
	}

	public BulletBase CreateMoonFallWithSync(int bulletId, Vector3 bulletPos, float atkPercent)
	{
		return null;
	}

	public BulletBase CreateMoonFall(int bulletId, Vector3 bulletPos, float atkPercent)
	{
		return null;
	}

	public string GetShieldHammerModelStr()
	{
		return null;
	}

	private int getAvailableHammerEquipId()
	{
		return 0;
	}

	public void IncreaseHitCountByCapybaraSword()
	{
	}

	public void SyncCapybaraMeteorAttack(int atkIndex, float atkPercent)
	{
	}

	public TryReleaseSwordVO CapybaraMeteorAttack(int atkIndex, float atkPercent, Func<float, float> getDeltaPercent = null)
	{
		return null;
	}

	private void createCapybaraMeteorBullet(Vector3 bulletPos, float atkPercent, float curHPPercent, float deltaPercent, int atkIndex)
	{
	}

	private void createHeroCapybaraMeteorAtkEffect(Vector3 pos, int atkIndex)
	{
	}

	public void Add2SkilldIdsForTower(int skillId)
	{
	}

	public void RemoveFromSkillIdsForTower(int skillId)
	{
	}

	public void ClearSkillIdsForTower()
	{
	}

	public List<int> GetInheritedSkillIdsForTD(int tdId)
	{
		return null;
	}

	public void Add2InheritSkillIdForTD(int tdId, int inheritSkillId)
	{
	}

	public void RemoveFromInheritSkillIdForTD(int tdId, int inheritSkillId)
	{
	}

	public void ClearInheritSkillIdForTD()
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetRendderOrder_003Ed__1635))]
	public IEnumerator DelaySetRendderOrder(Transform transform)
	{
		return null;
	}

	public void ResetPSOrder(Transform transform)
	{
	}

	public void MakePsOrderTop(Transform transform)
	{
	}

	public void SetTeam(int pId)
	{
	}

	public void SetEntityType(EntityType type)
	{
	}

	protected void UpdateName()
	{
	}

	private void InitBossHP()
	{
	}

	protected void MissBossHP()
	{
	}

	public void SetRoomType(RoomGenerateBase.RoomType type)
	{
	}

	public void SetEntityDivide(RoomGenerateBase.RoomType type)
	{
	}

	protected virtual long GetBossHP()
	{
		return 0L;
	}

	public void InitUnicornParameters()
	{
	}

	public void InitUnicornList()
	{
	}

	public bool HasUnicorn()
	{
		return false;
	}

	public Unicorn AddUnicorn()
	{
		return null;
	}

	public void RemoveUnicorn()
	{
	}

	public Unicorn GetUnicorn(int index)
	{
		return null;
	}

	public int RemoveUnicorn(Unicorn targetUnicorn, bool relocate = true)
	{
		return 0;
	}

	public void RemoveUnicornByIndex(int removedIndex, bool relocate = true)
	{
	}

	private void locateUnicornBeforeAdded(GameObject go)
	{
	}

	private void relocateExistingUnicorns()
	{
	}

	private void relocateUnicornsByCount(int _count)
	{
	}

	private GameObject createUnicornResource()
	{
		return null;
	}

	public void DestroyRotateUnicornContainer()
	{
	}

	public void RemoveAllUnicorns()
	{
	}

	public virtual string GetWeaponHandId()
	{
		return null;
	}

	public void WeaponHandUpdate()
	{
	}

	public void WeaponHandShow(bool show)
	{
	}

	public bool IsWeapon(WeaponType weaponType, int customWeaponId = -1)
	{
		return false;
	}

	public bool IsRightWeapon()
	{
		return false;
	}

	public int GetDiverseDirBulletCount()
	{
		return 0;
	}

	public void SetWeaponHandAlpha(float alpha)
	{
	}

	public void SetWeaponHandVisible(bool visible)
	{
	}

	public void DestroyCurrentWeapon()
	{
	}

	public void SetWuKongStickVisible(bool visible)
	{
	}
}
