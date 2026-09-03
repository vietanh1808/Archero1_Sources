using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1945 : SkillAloneBase
{
	private int CONFIG_BULLET_ID;

	private float CONFIG_RATE;

	private float CONFIG_THUNDER_RANGE;

	private int CONFIG_EFFECT_ID;

	private float CONFIG_HIT_RATIO;

	private float CONFIG_HP_PERCENT;

	private int CONFIG_BUFFID;

	private float CONFIG_BULLET_HIT_RATIO;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttack()
	{
	}

	private void OnHitWall(BulletBase bullet, Collider c)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected virtual List<EntityBase> Enemies(Vector3 pos, float radius)
	{
		return null;
	}
}
