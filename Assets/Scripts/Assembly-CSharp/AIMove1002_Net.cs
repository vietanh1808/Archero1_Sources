using UnityEngine;

public class AIMove1002_Net : AIMoveBase_Net
{
	protected float Move_NextTime;

	protected float Move_NextDurationTime;

	protected Vector3 dir;

	private float Move_NextDurationTimeMin;

	private float Move_NextDurationTimeMax;

	private int min;

	private int max;

	public AIMove1002_Net(EntityBase entity, int min, int max = -1)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void RandomNextMove()
	{
	}

	protected override void OnEnd()
	{
	}
}
