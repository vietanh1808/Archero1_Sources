public class SkillAlone1498 : SkillAloneBase
{
	private float m_fRate;

	private int m_nInterval;

	private float m_fHpAddPercent;

	private int m_nHitTime;

	private EntityHero m_hero;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}
}
