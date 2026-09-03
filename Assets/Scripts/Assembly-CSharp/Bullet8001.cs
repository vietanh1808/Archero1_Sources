using UnityEngine;

public class Bullet8001 : BulletBase
{
	private TrailRenderer trail1;

	private float trail1time;

	protected int state;

	protected override void AwakeInit()
	{
	}

	protected override void OnInit()
	{
	}

	protected virtual bool OnThroughWalls(Collider o)
	{
		return false;
	}

	protected override void OnOverDistance()
	{
	}

	protected override void BoxEnable(bool enable)
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
