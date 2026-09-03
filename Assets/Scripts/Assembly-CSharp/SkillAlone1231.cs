using System.Collections.Generic;

public class SkillAlone1231 : SkillAloneBase
{
	private float m_fRate;

	private int m_bBuffId;

	private Dictionary<BulletBase, int> m_dicBullets;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}
}
