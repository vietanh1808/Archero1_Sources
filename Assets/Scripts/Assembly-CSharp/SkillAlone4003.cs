using System;
using UnityEngine;

public class SkillAlone4003 : SkillAloneBase
{
	private float percent;

	protected int debuffId;

	private float triblePercent;

	private float tribleRate;

	private float tribleDis;

	private EntityHero self;

	private System.Random random;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hit, HittedData hitted)
	{
	}

	private void OnHitWall(BulletBase bullet, Collider c)
	{
	}

	private void CreateBullet(float angle, Vector3 position, EntityBase entity = null)
	{
	}

	private void SetTribleRate(float rate, float ratio)
	{
	}
}
