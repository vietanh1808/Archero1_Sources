using UnityEngine;

public class Bullet5353 : BulletBaseMatchModelSize
{
	private const float OffsetAngle = 15f;

	private bool haveTriggerWall;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	private bool OnHitWallAction(Collider o)
	{
		return false;
	}

	protected override void OnReboundCountChanged(Collider o)
	{
	}

	private void TrySendMoreBullet(Collider o)
	{
	}

	protected override void OnSetBulletAttribute()
	{
	}
}
