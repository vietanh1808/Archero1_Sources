using TableTool;
using UnityEngine;

public class GoodsBase : PauseObject
{
	protected string ClassName;

	protected int ClassID;

	private int GoodId;

	private TMXGoodsData GoodData;

	protected BoxCollider m_Box;

	protected Equip_equip m_Equip;

	protected GoodsDrop m_GoodsDrop;

	protected Vector3 EndPosition;

	protected bool bAbsorbImme;

	private Animator Ani_Rotate;

	public Goods_goods m_Data { get; protected set; }

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

	protected virtual void OnDeInit()
	{
	}

	public bool GetAbsorbImme()
	{
		return false;
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
}
