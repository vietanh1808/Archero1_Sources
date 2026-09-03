using UnityEngine;

public class SkillAlone1744GoodCtrl : SkillAloneAttrGoodBase
{
	[SerializeField]
	private GameObject obj;

	[SerializeField]
	private Transform posTarget;

	[SerializeField]
	private Transform rotateTarget;

	private EntityBase selfEntity;

	private float selfRotateSpeed;

	private float dmgCoeff;

	private float flySpeed;

	private float checkInterval;

	private float trggierDis;

	private float cumulativeFlyTime;

	private bool isMarkMove;

	public void InitData(EntityBase selfEntity, float selfRotateSpeed, float dmgCoeff, float scale)
	{
	}

	private void StartRotate()
	{
	}

	protected override void TriggerEnter(EntityBase entity)
	{
	}

	public void Move()
	{
	}

	public void Clear()
	{
	}

	private void Complete()
	{
	}

	protected override void OnInit()
	{
	}
}
