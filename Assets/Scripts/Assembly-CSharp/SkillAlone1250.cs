using System.Collections.Generic;

public class SkillAlone1250 : SkillAloneBase
{
	private float m_fRate;

	private int m_nDebuffId;

	private float m_fInterval;

	private Dictionary<EntityBase, long> m_dicHitMeTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}

	private void OnEnemyDead(EntityBase entity)
	{
	}
}
