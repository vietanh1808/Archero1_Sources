using System.Collections.Generic;
using UnityEngine;

public class AIIceDragon : AIDragonBase
{
	private const int BULLET_ID = 1201;

	private float deltaAttackingSpeed;

	public Dictionary<string, int[]> dict;

	private GameObject goBreathEffect;

	protected override int AttackLoopCount => 0;

	private GameObject createBreathEffect()
	{
		return null;
	}

	private void setBreathEffectTime(float breathTime)
	{
	}

	protected override void AfterSkillAttackPre()
	{
	}

	protected override void BeforeSkillContinuousAttack()
	{
	}

	protected override void AfterSkillContinuousAttack()
	{
	}
}
