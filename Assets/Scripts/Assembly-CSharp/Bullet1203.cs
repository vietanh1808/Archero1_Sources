using UnityEngine;

public class Bullet1203 : BulletDragonBase
{
	private const int BULLET_ID = 1203;

	private const float THUNDER_ATK_DURATION = 0.35f;

	private Vector3 posXZ;

	private float thunderDistance;

	private float customAliveTime;

	private float curBallTime;

	private float thunderAttackDuration;

	private EntityBase trackTarget;

	protected override void OnInit()
	{
	}

	protected override void OnSetBulletAttribute()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override int GetLayer()
	{
		return 0;
	}

	protected override void HitHero(EntityBase entity, Collider o)
	{
	}
}
