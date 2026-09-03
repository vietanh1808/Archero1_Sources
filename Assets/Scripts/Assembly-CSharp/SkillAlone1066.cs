public class SkillAlone1066 : SkillAloneBase
{
	private int debuffid;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase source, long hit)
	{
	}

	protected virtual bool CanSendBuff(EntityBase source)
	{
		return false;
	}
}
