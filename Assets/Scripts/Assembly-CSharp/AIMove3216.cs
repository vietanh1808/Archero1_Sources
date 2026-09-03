using UnityEngine;

public class AIMove3216 : AIMoveToTarget
{
	private bool changeRotateSpeed;

	private int deltaRotatePercentage;

	private int curFrameCount;

	private float curTime;

	private float timeInterval;

	private bool startMove;

	public AIMove3216(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	private void onCollision(Collision collision)
	{
	}

	private void updateRotateSpeed(int deltaPercentage)
	{
	}
}
