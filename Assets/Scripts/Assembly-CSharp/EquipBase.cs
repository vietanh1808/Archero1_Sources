using TableTool;
using UnityEngine;

public class EquipBase : PauseObject
{
	protected string ClassName;

	protected int ClassID;

	private int GoodId;

	protected BoxCollider m_Box;

	protected Equip_equip m_Equip;

	protected GoodsDrop m_GoodsDrop;

	protected Vector3 EndPosition;

	protected bool bAbsorbImme;

	private Animator Ani_Rotate;

	private bool bStartAbsorb;

	[SerializeField]
	private float mAbsorbTime;

	private EntityHero AbsorbEntity;

	public Goods_food m_Data { get; protected set; }

	private void Awake()
	{
	}

	protected virtual void AwakeInit()
	{
	}

	private void Start()
	{
	}

	protected virtual void StartInit()
	{
	}

	protected virtual void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void OnDeInit()
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

	protected virtual void OnGetGoods()
	{
	}

	public virtual void SetEndPosition(Vector3 startpos, Vector3 endpos)
	{
	}

	public Vector3 GetEndPosition()
	{
		return default;
	}

	protected virtual void OnAbsorb()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	public virtual void ChildTriggerEnter(GameObject o)
	{
	}

	public virtual void ChildTriggetExit(GameObject o)
	{
	}

	public virtual void SetEquip(Equip_equip equip)
	{
	}

	private void BeAbsorb(EntityHero _entity)
	{
	}

	private void Absorbing()
	{
	}

	protected override void UpdateProcess()
	{
	}

	public bool GetAbsorbing()
	{
		return false;
	}

	public void AbsorbEnd()
	{
	}
}
