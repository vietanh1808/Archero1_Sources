using System;

public class SkillAloneBodyHitBase : SkillAloneBase
{
	public int BuffId;

	public float BuffRate;

	public Action<EntityBase> Callback;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onBodyHit(EntityBase obj)
	{
	}

	protected virtual void ParseArgs()
	{
	}

	protected virtual void OnAfterSkillInit()
	{
	}
}
