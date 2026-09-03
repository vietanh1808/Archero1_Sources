public class SkillAloneMoveBuffBase : SkillAloneBase
{
	protected int TimeInterval;

	protected int BuffId;

	protected SkillMoveBuff skill;

	protected string TimerName => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	protected virtual void OnAfterSkillInit()
	{
	}
}
