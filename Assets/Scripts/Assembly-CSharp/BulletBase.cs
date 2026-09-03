using System;
using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using TableTool;
using UnityEngine;

[SelectionBase]
public class BulletBase : PauseObject
{
	public class BulletLine
	{
		private GameObject mBulletLine;

		private BulletLineCtrl mLineCtrl;

		private BulletBase mBullet;

		private BulletBase mLastBullet;

		public void Init(BulletBase bullet, BulletBase lastbullet)
		{
		}

		private void CreateBulletLine()
		{
		}

		public void DeInit()
		{
		}
	}

	public class ConsecutiveHitsData
	{
		public int maxcount;

		public float interval;

		public float addattackpercent;

		public EntityBase source;

		public float lasthittime;

		public int count;

		public float GetAttackPercent()
		{
			return 0f;
		}

		public void Hitted()
		{
		}
	}

	public class LaserData : ConsecutiveHitsData
	{
	}

	public class LightData : ConsecutiveHitsData
	{
	}

	protected class TrailCtrl
	{
		private struct TrailWidth
		{
			public float startWidth;

			public float endWidth;
		}

		public bool bShow;

		private GameObject trail;

		private List<TrailRenderer> mTrailRenderers;

		private List<float> mTrailTime;

		private List<MeshRenderer> mTrailMeshs;

		private List<ParticleSystem> mTrailParticles;

		private List<TrailWidth> mTrailsWidth;

		public TrailCtrl(Transform trail)
		{
		}

		private void InitTrailRenderer()
		{
		}

		private void TrailRendererShow(bool show)
		{
		}

		private void InitTrailMesh()
		{
		}

		private void TrailMeshShow(bool show)
		{
		}

		private void InitParticles()
		{
		}

		private void TrailParticlesShow(bool show)
		{
		}

		public void TrailShow(bool show)
		{
		}

		public float GetTrailTime()
		{
			return 0f;
		}

		public void SetTrailTime(float ratio)
		{
		}

		public void Clear()
		{
		}

		public void UpdateTrailWidthScale(float scale)
		{
		}
	}

	public class TriggerData
	{
		public EntityBase m_Entity;

		public Weapon_weapon bulletMeta;

		private const float delaytime = 1f;

		private float lastintime;

		public GameObject target;

		public Collider collider;

		private int lastinframe;

		public int currentframe;

		private float realDelayTime;

		private float DelayTime => 0f;

		public void Init()
		{
		}

		public bool GetCanHit()
		{
			return false;
		}
	}

	public Action<EntityBase> OnKillEntity;

	public Action OnBulletCache;

	public Action<BulletBase> OnBulletCache2;

	protected Transform mTransform;

	protected GameObject mGameObject;

	public const float g = 9.8f;

	protected string ClassName;

	protected bool bInit;

	protected bool bbMoveEnable;

	protected object param;

	protected bool bFlyRotate;

	public Weapon_weapon m_Data;

	public BulletTransmit mBulletTransmit;

	private bool bBoxEnable;

	protected BoxCollider[] boxList;

	protected int boxListCount;

	protected SphereCollider[] sphereList;

	protected int sphereListCount;

	protected CapsuleCollider[] capsuleList;

	protected int capsuleListCount;

	private int CurrentFrameCount;

	private GameObject AttackSoundObj;

	private GameObject trailattrobj;

	private GameObject headattrobj;

	protected Action OnHitSelf;

	protected Func<Collider, bool> HitWallAction;

	protected Action<Collider> HitWaterAction;

	private Sequence seq_flyhit;

	protected SequencePool mSeqPool;

	protected float moveX;

	protected float moveY;

	protected float bulletAngle;

	protected float OriginRotate;

	protected Vector3 moveDirection;

	protected Vector3 OriginMoveDirection;

	protected Vector3 raycastPoint;

	protected Vector3 StartPosition;

	protected float StartPositionY;

	protected float PosFromStart2Target;

	protected Transform shadow;

	protected GameObject shadowGameObject;

	protected Vector3 shadow_initpos;

	private float mDistance;

	protected float LifeTime;

	protected float CreateTime;

	protected float RemoveTime;

	private float mSpeed;

	protected Transform childMesh;

	protected MeshRenderer childMeshRender;

	private Transform rotateTran;

	protected Vector3 childMesh_initpos;

	private TrailRenderer[] trails;

	private GameObject lastwall;

	private ActionBasic action;

	protected List<GameObject> mHitList;

	protected GameObject mHitWall;

	protected Action<bool> OnTrailShowEvent;

	private bool bDelayCache;

	protected ConditionBase mCondition;

	protected BulletModelCtrl mBulletModelCtrl;

	private float originalCapsuleRadius;

	private float originalCapsuleHeight;

	private float originalSphereRadius;

	private Vector3 originalBoxSize;

	protected bool forceChangeBulletLayer;

	protected float[] mArgs;

	protected EntityBase Target;

	protected Vector3 TargetPosition;

	[NonSerialized]
	public BulletBase mLastBullet;

	private BulletLine mBulletLine;

	protected Transform mBulletModel;

	private Vector3 OriginalModelScale;

	private int mArrowEjectCount;

	private int mArrowEjectMaxCount;

	protected float currentHitRatio;

	private float catapult_x;

	private float catapult_z;

	private float catapult_alpha;

	private float catapult_scale;

	protected Action<float> meshAlphaAction;

	protected int mReboundWallCount;

	protected int mReboundWallMaxCount;

	private SphereCollider mReboundSphere;

	private BulletBase HitCreate2_Bullet;

	private float[] offsetAngles;

	private GameObject HitSputter_o;

	private List<EntityBase> HitSputter_list;

	private float HitSputter_hitratio;

	private int HitSputter_i;

	private int HitSputter_imax;

	protected bool bLight45;

	protected float mSpeedRatio;

	protected float mAcceleratedSpeedRatio;

	protected float mSpeedRatioFromBulletLogic;

	protected TrailCtrl mTrailCtrl;

	protected bool mTrailAdd;

	private Dictionary<GameObject, TriggerData> mTriggerList;

	private Dictionary<GameObject, TriggerData>.Enumerator mTriggerListIter;

	private int TriggerTest_Interval;

	private int TriggerTest_TriggerFrame;

	private int TriggerTest_Boxi;

	private int TriggerTest_Spherei;

	private int TriggerTest_Capsulei;

	protected RaycastHit[] TriggerTest_Hits;

	private RaycastHit TriggerTest_Hit;

	private float TriggerTest_Min;

	private float TriggerTest_MoveDis;

	protected Vector3 TriggerTest_CurrentPos;

	protected float TriggerTest_BeforeHit;

	public static Vector3 TriggerTest_vec;

	private Collider minCollider;

	private float tempdis;

	private float tempmin;

	private float mindis;

	private float tempheight;

	private float tempradius;

	private int mInitFrameCount;

	private List<Collider> mColliders;

	protected Vector3 triggerpoint;

	protected bool canhitted;

	protected HitStruct target_hs;

	protected int TriggerExtra_hit;

	protected bool TriggerExtra_bEject;

	protected bool TriggerExtra_bEject_Custom;

	protected bool TriggerExtra_bThroughEnemy;

	protected int CurCustomEjectCount;

	protected float CustomArrowEjectDistance;

	protected EntityBase nextentity;

	private RaycastHit HitWall_hit;

	private Vector3 HitWall_dir;

	private bool bShowBullet;

	protected bool externalControl;

	protected Action externalControlCallback;

	protected bool bGetTrackTarget;

	protected EntityBase mTrackTarget;

	protected bool bExcuteReboundWall;

	private float BulletRayCast_cudris;

	protected Vector3 Parabola_position;

	protected Vector3 OnMove_vec;

	protected float Parabola_MaxHeight;

	protected AnimationCurve Parabola_Curve;

	private Keyframe beforeframe;

	private Keyframe afterframe;

	private AnimationCurve Horizontal_Curve;

	private Vector3 Horizontal_vec;

	private float amplitude;

	private float frequency;

	private Vector3 snakeMove_vec;

	private float AngularVelocity;

	private float ArchimedesFrequency;

	private float totalAngular;

	private Vector3 startPos;

	private float bulletscale;

	protected float currentRotateAngleInTrack;

	protected float maxAngleInTrack;

	protected float perAngleInTrack;

	public int HitEnemyCount { get; set; }

	public int BulletID { get; private set; }

	public bool IsForward { get; set; }

	public int Guid { get; private set; }

	protected bool bMoveEnable
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected string Tag => null;

	protected virtual bool bFlyCantHit => false;

	public EntityBase m_Entity { get; private set; }

	public int TeamID { get; protected set; }

	public ulong entityIndex { get; protected set; }

	public Vector3 MoveDirection => default;

	public float CurrentDistance { get; protected set; }

	protected float Distance
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float Speed
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	protected float FrameDistance => 0f;

	public int bulletids { get; private set; }

	protected virtual int RotateSpeedSign => 0;

	public bool IsCommonBullet => false;

	public Transform BulletModel => null;

	public Transform ChildMesh => null;

	public float BulletModelScale => 0f;

	private float deltaBulletSize => 0f;

	private float BulletSizePercent => 0f;

	public int DivideLayer { get; set; }

	protected virtual bool bZScale => false;

	private void Awake()
	{
	}

	protected virtual void AwakeInit()
	{
	}

	private void OnEnable()
	{
	}

	protected virtual void StartInit()
	{
	}

	private void DeInitData()
	{
	}

	public void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	public virtual void OnBeforeInit()
	{
	}

	public void Init_Model2()
	{
	}

	private void initCustomArrowEjectDis()
	{
	}

	public void Init(EntityBase entity, int BulletID)
	{
	}

	public void SetParam(object o)
	{
	}

	public void MultiplySpeedByFactor(float factor)
	{
	}

	private void onMeadowBattle()
	{
	}

	public void Init(EntityBase entity, int BulletID, float speedRatio)
	{
	}

	protected virtual void OnInit()
	{
	}

	public bool GetInit()
	{
		return false;
	}

	public bool GetIsDead()
	{
		return false;
	}

	public EntityBase GetEntity()
	{
		return null;
	}

	public void SetEntity(EntityBase entity)
	{
	}

	public void ResetLifeTime(int millisecond)
	{
	}

	protected virtual void UpdateMoveDirection()
	{
	}

	public void ReverseMoveDirection()
	{
	}

	public void Rebound(Vector3 normal)
	{
	}

	protected Vector3 GetMoveDirection(float angle)
	{
		return default;
	}

	private void CreateBulletEffect()
	{
	}

	public void SetBulletAttribute(BulletTransmit bullet)
	{
	}

	public void SetReboundWallCount(int count)
	{
	}

	public void UpdateBulletAttribute()
	{
	}

	public void TryAddPartHit()
	{
	}

	protected virtual void OnSetBulletAttribute()
	{
	}

	public void SetArgs(params float[] args)
	{
	}

	protected virtual void OnSetArgs()
	{
	}

	public EntityBase GetTarget()
	{
		return null;
	}

	public virtual void SetTarget(EntityBase entity, int size = 1)
	{
	}

	public void SetTargetPosInParallel(Vector3 targetPos)
	{
	}

	public void SetDistance(float customDistance)
	{
	}

	public void SetPosFromTarget(float dis)
	{
	}

	protected void RotateDeal()
	{
	}

	protected void FlyOver()
	{
	}

	protected virtual void Cache()
	{
	}

	private void CacheLater()
	{
	}

	public void BulletCache()
	{
	}

	public void BulletDestroy()
	{
	}

	protected virtual void overDistance()
	{
	}

	protected virtual void OnOverDistance()
	{
	}

	protected virtual void ShowDeadEffect()
	{
	}

	protected virtual void OnLoadDeadEffect(GameObject deadEffect)
	{
	}

	protected virtual void HitHero(EntityBase entity, Collider o)
	{
	}

	protected void DeInitDelay(float deaddelay)
	{
	}

	protected virtual void OnHitHero(EntityBase entity)
	{
	}

	protected void ShadowDeal()
	{
	}

	protected void ShadowShow(bool show)
	{
	}

	protected void SetBoxEnableOnce(float starttime)
	{
	}

	private void KillSequence()
	{
	}

	public void SetBoxEnable(bool enable)
	{
	}

	public void ScaleCollider(float percent, bool add = false, float modelScale = 1f)
	{
	}

	private void ScaleBoxCollider(BoxCollider collider, float percent, bool add = false, float modelScale = 1f)
	{
	}

	private void ScaleSphereCollider(SphereCollider collider, float percent, bool add = false, float modelScale = 1f)
	{
	}

	private void ScaleCapsuleCollider(CapsuleCollider collider, float percent, bool add = false, float modelScale = 1f)
	{
	}

	protected virtual void BoxEnable(bool enable)
	{
	}

	public virtual void SetRadius(float radius)
	{
	}

	public static bool IsStarBullet(int weaponId)
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	public EntityBase GetNearestEnemy()
	{
		return null;
	}

	public void IncreaseHitEnemyCount()
	{
	}

	private void SetEffectWeakenStatus(bool isOpen, bool isForceLoad = false)
	{
	}

	private void CheckBulletTransmitData()
	{
	}

	private RaycastHit GetNearestHit(RaycastHit[] hits)
	{
		return default;
	}

	public BeamVO GetBeamVO(Vector3 dir, int layerMask, bool _follow = false, float textureLengthScale = 3f, float textureScrollSpeed = 8f)
	{
		return null;
	}

	public void RefreshBeamVO(BeamVO beamVO, Vector3 dir, int layerMask)
	{
	}

	public void SetLineRendererByBeamVO(LineRenderer line, BeamVO beamVO)
	{
	}

	public float[] GetBuffArgs()
	{
		return null;
	}

	protected virtual float[] OnGetBuffArg()
	{
		return null;
	}

	public GameObject PlayEffect(int fxId, Vector3 pos, Quaternion rota)
	{
		return null;
	}

	public GameObject PlayEffect(string path, Vector3 pos, Quaternion rota)
	{
		return null;
	}

	public void SetLastBullet(BulletBase o)
	{
	}

	private void CreateBulletLine()
	{
	}

	public static bool IsBoss6006FlashBullet(int bulletId)
	{
		return false;
	}

	public static bool IsDragonBullet(int element)
	{
		return false;
	}

	public static bool IsElementDragonBullet(int element)
	{
		return false;
	}

	public static bool IsPvpBullet(string element)
	{
		return false;
	}

	public static void PreLoadModel(int pBulletId, Action<GameObject> onLoaded)
	{
	}

	public virtual string GetModelColorPath(Weapon_weapon weapon)
	{
		return null;
	}

	public static bool IsWeaponType(int type)
	{
		return false;
	}

	public static int GetEquipIdInPvp(int weaponId)
	{
		return 0;
	}

	public bool CanBeReplacedByWeaponSkinBullet(int weaponId)
	{
		return false;
	}

	public static string GetMappingWeaponSkinBulletModelStr(int weaponId)
	{
		return null;
	}

	public static void PreLoadModelByModelId(string bulletModelId, Action<GameObject> onLoaded)
	{
	}

	protected virtual string GetModelId()
	{
		return null;
	}

	protected virtual void KillBulletModel()
	{
	}

	private void Init_Model()
	{
	}

	private void onSpecialCase(ref string path, string modelId)
	{
	}

	public void ClearInternalBulletResource()
	{
	}

	public void SetBulletModel(GameObject o, string modelId)
	{
	}

	public void UpdateModelScale(float deltaScale)
	{
	}

	public void SetModelScale(float newScale)
	{
	}

	protected void BulletModelShow(bool value)
	{
	}

	public void UpdateBulletScaleWrapper(float deltaPercent = 0f)
	{
	}

	protected void BulletModelCtrlShow(bool value)
	{
	}

	private void Init_ModelScale()
	{
	}

	public void UpdateCurrentHitRatio(float hitRatio)
	{
	}

	public bool ExcuteArrowEject(EntityBase entity)
	{
		return false;
	}

	protected virtual void OnArrowEject(EntityBase nextentity)
	{
	}

	protected void Catapult()
	{
	}

	private void OnCatapult(float delta)
	{
	}

	protected void ExcuteReboundWall(Collider o)
	{
	}

	protected virtual void OnReboundCountChanged(Collider o)
	{
	}

	protected virtual float ExcuteReboundWallSkill(Collider o)
	{
		return 0f;
	}

	protected virtual Vector3 ExcuteReboundWallSide(Collider o)
	{
		return default;
	}

	public void AddCantHit(EntityBase entity)
	{
	}

	protected void OnHitEvent(EntityBase entity, float hittedAngle)
	{
	}

	protected virtual void OnHitEventInternal(EntityBase entity, float hittedAngle)
	{
	}

	private void HitCreate2(EntityBase entity, float hittedAngle)
	{
	}

	private int GetMaxDividerLayer()
	{
		return 0;
	}

	private void HitCreateDivide(EntityBase entity, float hittedAngle)
	{
	}

	private void HitSputter(EntityBase entity, float hittedAngle)
	{
	}

	public bool GetLight45()
	{
		return false;
	}

	protected HitStruct execute_umbrella_shield(HitStruct data, EntityBase attack_target)
	{
		return null;
	}

	protected HitStruct excute_consecutive_hits_laser(HitStruct data, EntityBase source)
	{
		return null;
	}

	protected HitStruct excute_laser(HitStruct data, EntityBase source)
	{
		return null;
	}

	protected HitStruct excute_light(HitStruct data, EntityBase source)
	{
		return null;
	}

	protected HitStruct excute_aurora_continus(HitStruct data, EntityBase target)
	{
		return null;
	}

	private void UpdateSpeedRatio()
	{
	}

	protected void TrailShow(bool show)
	{
	}

	protected void ThroughTrailShow(bool show)
	{
	}

	protected virtual void OnThroughTrailShow(bool show)
	{
	}

	protected virtual Transform GetTrailAttParent()
	{
		return null;
	}

	protected void TrailAttrShow(bool show)
	{
	}

	protected virtual void GetWeaponType(ref int weapontype)
	{
	}

	protected void HeadAttrShow(bool show)
	{
	}

	private void TriggerUpdateList(Collider o)
	{
	}

	private void TriggerListCheck()
	{
	}

	protected void TriggerTest()
	{
	}

	protected virtual int GetLayer()
	{
		return 0;
	}

	protected virtual Vector3 getHalfExtents(Vector3 size)
	{
		return default;
	}

	protected virtual void OnBulletHitSelf()
	{
	}

	protected void TriggerTest_Base()
	{
	}

	protected virtual void CheckCapsuleHits()
	{
	}

	protected virtual Vector3 getRealSphereCenter()
	{
		return default;
	}

	private void partBody1842HittedCount(Collider o)
	{
	}

	private void TriggerEnter1(Collider o)
	{
	}

	public bool isRemoteMainWeaponId(int weaponId)
	{
		return false;
	}

	private List<int> getWeaponIds()
	{
		return null;
	}

	public virtual float modifyCurHitRatio(EntityBase target)
	{
		return 0f;
	}

	protected virtual bool IsCustomArrowEject()
	{
		return false;
	}

	protected virtual void UpdateCustomEjectCount(int delta)
	{
	}

	protected virtual bool ExcuteCustomEject(EntityBase entity)
	{
		return false;
	}

	protected virtual void TriggerExtra(Collider o)
	{
	}

	protected virtual void SendHitBullet(EntityBase target, EntityBase source, long beforehit, HitType hittype, HitBulletStruct bulletdata)
	{
	}

	protected virtual bool CanHitted(EntityBase entity)
	{
		return false;
	}

	protected void CalThroughHitRatio()
	{
	}

	protected virtual void HitWater(Collider o)
	{
	}

	private void HitWall(Collider o)
	{
	}

	private void PlayHitWallSound()
	{
	}

	protected virtual void OnHitWall()
	{
	}

	protected override void UpdateProcess()
	{
	}

	private void CheckFar()
	{
	}

	private void BulletParabolaInit()
	{
	}

	private void BulletSnakeMoveInit()
	{
	}

	private void BulletSwissRollInit()
	{
	}

	public void EnableExternalControlCallback(Action callback)
	{
	}

	protected virtual void OnUpdate()
	{
	}

	protected virtual void OnBulletTrack()
	{
	}

	protected virtual EntityBase GetTrackTarget()
	{
		return null;
	}

	private void BulletRayCast()
	{
	}

	public void BulletStraight()
	{
	}

	private void BulletParabola()
	{
	}

	protected virtual void ParabolaOver()
	{
	}

	protected virtual void OnMove()
	{
	}

	protected void OnMove(float dis)
	{
	}

	protected void UpdateParabolaArgs()
	{
	}

	private void BulletHorizontalInit()
	{
	}

	private void BulletHorizontal()
	{
	}

	private void BulletSnakeMove()
	{
	}

	private void ArchimedesSpiralMove()
	{
	}

	private void UpdateScale()
	{
	}

	protected virtual void InitAnglesInTrack()
	{
	}

	public void TrackTarget()
	{
	}
}
