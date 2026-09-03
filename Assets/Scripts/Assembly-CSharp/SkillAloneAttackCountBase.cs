public class SkillAloneAttackCountBase : SkillAloneBase
{
	protected int maxAtkCount;

	protected int curCount;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	protected virtual void OnMaxAttackCount()
	{
	}

	private void onAttackStart(JoyData obj)
	{
	}
}
