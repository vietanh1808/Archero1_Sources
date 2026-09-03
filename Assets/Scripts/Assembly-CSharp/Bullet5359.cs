using DG.Tweening;
using UnityEngine;

public class Bullet5359 : Bullet5149
{
	private const int HitWallCreateBulletCount = 5;

	private const float PerBulletAngle = 30f;

	private const float SecondBulletDelay = 0.5f;

	private Tween delayCall;

	private bool haveTriggerWall;

	protected override bool AllowMoreTriggerBullet => false;

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
