using TableTool;
using UnityEngine;

public abstract class FoodBase : PauseObject
{
	public int FoodID;

	protected string ClassName;

	protected int ClassID;

	private int GoodId;

	protected object data;

	protected BoxCollider m_Box;

	protected Equip_equip m_Equip;

	protected GoodsDrop m_GoodsDrop;

	protected Vector3 EndPosition;

	protected bool bAbsorbImme;

	protected Animator Ani_Rotate;

	private GameObject trail;

	private bool bTrailShow;

	protected MeshRenderer[] meshes;

	private float flyStartDelayTime;

	protected float flyTime;

	protected float flyDelayTime;

	protected float flySpeed;

	private Vector3 mflyspeed;

	private Vector3 mflydir;

	private bool bAbsorbEnable;

	private static AnimationCurve _curve;

	private bool bStartAbsorb;

	private float mAbsorbStartTime;

	private float mAbsoryUpdateTime;

	private float flypercent;

	private float lastDis;

	private float tempdis;

	private const float maxspeed = 1f;

	private const float maxdis = 0.7f;

	private float foodAngle;

	protected bool bFlyRotate;

	private float startscalez;

	private const float SQR_TD_ABSORB_RADIUS = 25f;

	public Goods_food m_Data { get; protected set; }

	public bool AbsorbEnable => false;

	private static AnimationCurve curve => null;

	protected float PropClearnessValue => 0f;

	protected virtual EntityHero AbsorbEntity => null;

	private void Awake()
	{
	}

	protected virtual void OnAwakeInit()
	{
	}

	private void Start()
	{
	}

	protected virtual void StartInit()
	{
	}

	public void Init(object data)
	{
	}

	protected virtual void ForceCastData()
	{
	}

	protected virtual void OnInit()
	{
	}

	protected virtual void OnEnables()
	{
	}

	public virtual void SetCanShow(bool canShow = true)
	{
	}

	public virtual bool GetCanShow()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public object GetData()
	{
		return null;
	}

	private void InitTrail()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	protected void RotateEnable(bool value)
	{
	}

	private void TrailShow(bool show)
	{
	}

	private void DropEnd()
	{
	}

	protected virtual void OnDropEnd()
	{
	}

	public bool GetAbsorbImme()
	{
		return false;
	}

	public void GetGoods(EntityBase entity)
	{
	}

	protected virtual void OnGetGoods(EntityBase entity)
	{
	}

	protected virtual void OnGetGoodsEnd()
	{
	}

	public virtual void SetEndPosition(Vector3 startpos, Vector3 endpos)
	{
	}

	public Vector3 GetEndPosition()
	{
		return default;
	}

	public void SetCanAbsorb(bool value)
	{
	}

	protected virtual void OnAbsorb()
	{
	}

	public virtual void SetEquip(Equip_equip equip)
	{
	}

	private void BeAbsorb()
	{
	}

	protected virtual void OnAbsorbStart()
	{
	}

	private void SetTrailScaleZ(float scalez)
	{
	}

	private void Absorbing()
	{
	}

	protected virtual void AbsorbFoods()
	{
	}

	protected override void UpdateProcess()
	{
	}

	private void beAbsorbWrapper()
	{
	}

	public bool GetAbsorbing()
	{
		return false;
	}

	public void AbsorbEnd()
	{
	}

	protected virtual void OnAbsorbEnd()
	{
	}

	protected abstract void SetPropClearness(BattlePropClearness clearness);

	private BattlePropClearness GetPropClearness()
	{
		return BattlePropClearness.None;
	}
}
