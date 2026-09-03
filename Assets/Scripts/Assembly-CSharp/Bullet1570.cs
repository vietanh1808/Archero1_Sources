using System;
using UnityEngine;

public class Bullet1570 : BulletBase
{
	public long damage;

	public float damageRate;

	public float damageRange;

	private const int PUMPKIN_BULLET_EXPLODE_ID = 1571;

	private bool isDealDamage;

	public Action<int> OnBulletDestry;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	public override void SetTarget(EntityBase entity, int size = 1)
	{
	}

	protected override void UpdateProcess()
	{
	}

	protected override void TriggerExtra(Collider o)
	{
	}

	private void DealDamage()
	{
	}

	private void CreatBullet(EntityBase target)
	{
	}
}
