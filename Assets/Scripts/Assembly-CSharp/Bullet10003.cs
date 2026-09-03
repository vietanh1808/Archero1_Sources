using UnityEngine;

public class Bullet10003 : BulletBase
{
	private Animator animator;

	private GameObject trail;

	private float waittime;

	private float currenttime;

	private float lastAngle;

	private float totalAngle;

	private ActionBasic action;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnHitHero(EntityBase entity)
	{
	}

	protected override void OnBulletTrack()
	{
	}

	protected override EntityBase GetTrackTarget()
	{
		return null;
	}

	protected override void HitWater(Collider o)
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Refresh()
	{
	}
}
