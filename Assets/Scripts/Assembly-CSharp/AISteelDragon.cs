using UnityEngine;

public class AISteelDragon : AIDragonBase
{
	private const int BULLET_ID = 1206;

	private int bulletCount;

	private const int CLAW_ID = 3100090;

	private GameObject goClaw;

	private float attackingTime;

	protected override int AttackLoopCount => 0;

	public override void BeforeStartAttack()
	{
	}

	protected override void BeforeSkillContinuousAttack()
	{
	}

	protected override void AfterSkillContinuousAttack()
	{
	}

	protected override void AfterSkillAttackPre()
	{
	}

	public override void AfterAttackCompleted()
	{
	}
}
