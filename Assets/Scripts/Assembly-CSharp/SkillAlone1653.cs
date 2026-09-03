using UnityEngine;

public class SkillAlone1653 : SkillAloneBase
{
	private int m_nBulletId;

	private int m_nCnt;

	private float m_fRate;

	private int m_nBuffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void OnMeteoriteMiss(BulletSlopeBase bullet)
	{
	}

	private void CreateLightBullet(Vector3 pos, int i, float offset, float step)
	{
	}
}
