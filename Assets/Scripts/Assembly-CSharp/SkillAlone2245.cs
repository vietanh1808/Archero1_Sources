using System.Collections.Generic;

public class SkillAlone2245 : SkillAlone2244
{
	private float hitInterval;

	private float hitDmgScale;

	private Dictionary<int, float> hitEnemey;

	public const int SendBulletID = 1599;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}

	protected override void OnPhoenixShieldAppear()
	{
	}

	protected override void OnPhoenixShieldDisAppear()
	{
	}
}
