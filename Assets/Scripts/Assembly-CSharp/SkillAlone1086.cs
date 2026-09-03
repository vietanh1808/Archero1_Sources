using UnityEngine;

public class SkillAlone1086 : SkillAloneBase
{
	private float percent;

	protected int debuffId;

	private float tribleRate;

	private float tribleDis;

	private EntityHero self;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hit, HittedData hitted)
	{
	}

	private void CreateBullet(float angle, Vector3 position, EntityBase entity = null)
	{
	}

	private void SetTribleRate(float rate, float ratio)
	{
	}
}
