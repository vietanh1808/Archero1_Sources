using UnityEngine;

public class AIMove1028_Net : AIMoveBase
{
	private bool bRotateOver;

	private int reboundcount;

	private const int ReboundMaxCount = 3;

	protected float Move_NextX;

	protected float Move_NextY;

	private GameObject lastwall;

	private float mEndStartTime;

	private float mEndTime;

	public AIMove1028_Net(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void OnMoveEvent(bool b)
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveToNext()
	{
	}

	protected override void OnEnd()
	{
	}
}
