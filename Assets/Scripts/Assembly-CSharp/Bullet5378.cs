using UnityEngine;

public class Bullet5378 : BulletBaseMatchModelSize
{
	private bool isHitWallCreateNew;

	private bool haveTriggerWall;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	public void SetNeedHitWallCreateNewToSelf(bool isHitWallCreateNew)
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
}
