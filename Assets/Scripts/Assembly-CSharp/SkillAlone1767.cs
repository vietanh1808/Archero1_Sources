public class SkillAlone1767 : SkillAloneBase
{
	private float CONFIG_TIME;

	private float CONFIG_HIT_RATIO;

	private int CONFIG_CHARGE_VALUE;

	private EntityHero m_hero;

	private float m_fSuperSkillTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private bool OnCheckSuperSkill()
	{
		return false;
	}

	private void OnSuperSkill(bool flag)
	{
	}

	private bool CanSuperSkill()
	{
		return false;
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}
}
