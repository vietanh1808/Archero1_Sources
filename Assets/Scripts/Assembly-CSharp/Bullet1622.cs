using UnityEngine;

public class Bullet1622 : BulletBase
{
	private EntityBase groundWaveTarget;

	private Vector3 targetDeathPos;

	private bool isTargetDead;

	public EntityBase GroundWaveTarget => null;

	protected override void OnInit()
	{
	}

	public void SetGroundWaveTarget(EntityBase target)
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnHitEventInternal(EntityBase entity, float hittedAngle)
	{
	}
}
