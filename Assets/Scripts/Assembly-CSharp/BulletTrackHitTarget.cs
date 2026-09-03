using UnityEngine;

public class BulletTrackHitTarget : BulletTrackBase
{
	protected override bool CanHitted(EntityBase entity)
	{
		return false;
	}

	protected override void HitHero(EntityBase entity, Collider o)
	{
	}
}
