using UnityEngine;

public class Goods1003 : GoodsBase
{
	protected bool bStartTrap;

	protected float trapTime;

	private float delaytime;

	private float firetime;

	private float currenttime;

	private bool bStartFire;

	private float firecurrenttime;

	private int state;

	private BoxCollider box;

	protected override void Init()
	{
	}

	public override void ChildTriggerEnter(GameObject o)
	{
	}

	protected override void UpdateProcess()
	{
	}

	private void CreateEffect()
	{
	}

	private void BoxShow(bool show)
	{
	}
}
