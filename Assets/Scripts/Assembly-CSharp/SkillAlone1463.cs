public class SkillAlone1463 : SkillAloneBase
{
	private float m_fHpPercent;

	private int m_nBodyType;

	private float m_fHitRatio;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}
}
