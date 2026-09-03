using System.Collections.Generic;
using DG.Tweening;

public class Bullet5342 : Bullet5302
{
	private Tween delayCall;

	private List<BulletBase> allCreateBullet;

	protected override bool IsNormalCharID => false;

	protected override int FIRE_BULLET_ID => 0;

	protected override float TriggerInterval => 0f;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void OnDisable()
	{
	}

	private void ClearTween()
	{
	}

	protected override void CreateNormalCharFireBullet(BulletBase bulletBase)
	{
	}
}
