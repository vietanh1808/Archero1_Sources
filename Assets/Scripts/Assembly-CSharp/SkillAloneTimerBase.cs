public class SkillAloneTimerBase : SkillAloneBase
{
	private string updateName;

	protected float cdTime;

	protected int persistenBuff;

	protected ConditionTime timer;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnAfterInstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void onUpdate(float delta)
	{
	}

	protected virtual void OnTimer()
	{
	}
}
