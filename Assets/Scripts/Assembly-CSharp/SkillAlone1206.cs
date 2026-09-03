public class SkillAlone1206 : SkillAloneBase
{
	private float m_fBodyHitRatio;

	private EntityHero m_EntityHero;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private long OnBodyHit(long value)
	{
		return 0L;
	}
}
