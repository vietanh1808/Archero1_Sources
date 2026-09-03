using UnityEngine;

public class Bullet1194 : BulletBase
{
	private Vector3 posXZ;

	private float curTime;

	private float attackInterval;

	private float attackRadius;

	private int debuffId;

	public void SetExtraArgs(float _attackInterval, float _attackRadius, int _debuffId)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void HitHero(EntityBase entity, Collider o)
	{
	}
}
