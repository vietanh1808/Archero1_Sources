using UnityEngine;

public class SkillAlone2048 : SkillAlone2047
{
	private float critValue;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	public override BulletBase CreateFlySword(Vector3 startpos, float angle, EntityBase target)
	{
		return null;
	}
}
