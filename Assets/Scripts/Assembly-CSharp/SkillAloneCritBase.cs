public class SkillAloneCritBase : SkillAloneBase
{
	protected float BuffRate;

	protected int BuffId;

	protected SkillCrit skill;

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

	protected virtual float GetBuffRate()
	{
		return 0f;
	}

	protected virtual int GetBuffId()
	{
		return 0;
	}
}
