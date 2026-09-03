public class SkillAlone1552 : SkillAloneBase
{
	private int m_nBuffId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual bool Condition(HitStruct hs)
	{
		return false;
	}

	private void OnHitted(HitStruct hs, EntityBase self)
	{
	}
}
