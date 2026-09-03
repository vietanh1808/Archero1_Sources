using UnityEngine;

public class AIStarDragon : AIDragonBase
{
	private const int BULLET_ID = 1205;

	private const int WHIRL_POOL_ID = 3100088;

	private GameObject goWhirlPool;

	private float deltaAttackingSpeed;

	private float startTime;

	private float endTime;

	private float duration;

	private float curTime;

	private float dropRadius;

	public override void BeforeStartAttack()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected override void BeforeSkillContinuousAttack()
	{
	}

	protected override void AfterSkillContinuousAttack()
	{
	}

	private void attackMeteorBullets()
	{
	}

	private void OnBulletOverDistance(BulletSlopeBase bullet)
	{
	}

	private Vector3 getTargetPos(float dropRadius)
	{
		return default;
	}
}
