using UnityEngine;

public class BulletNewPlay125Boomerang : BulletBase
{
	private TrailRenderer trail1;

	private float trail1time;

	protected int state;

	private bool IsBoomerangChange => false;

	protected override void AwakeInit()
	{
	}

	protected override void OnInit()
	{
	}

	private bool OnThroughWalls(Collider o)
	{
		return false;
	}

	protected override void OnOverDistance()
	{
	}

	protected override void OnThroughTrailShow(bool show)
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void OnRotate()
	{
	}
}
