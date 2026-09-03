using System.Collections.Generic;

public class SkillAlone1219 : SkillAloneBase
{
	private float m_fHitAddPercent;

	private float m_fHitAddMaxPercent;

	private Dictionary<BulletBase, float> m_dicBulletThroughRatios;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private float OnThroughEnemy(BulletBase bullet, EntityBase entity)
	{
		return 0f;
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}
}
