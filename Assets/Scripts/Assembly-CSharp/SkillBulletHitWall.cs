using System;
using UnityEngine;

public class SkillBulletHitWall : SkillRefineBase
{
	public Action<BulletBase, Collider> HitCallback;

	public SkillBulletHitWall(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onHit(BulletBase arg1, Collider arg2)
	{
	}
}
