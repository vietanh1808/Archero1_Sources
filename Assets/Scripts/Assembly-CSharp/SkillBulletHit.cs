using System;

public class SkillBulletHit : SkillRefineBase
{
	public int BuffId;

	public float BuffRate;

	public Action Callback;

	public SkillBulletHit(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onHitByBullet()
	{
	}
}
