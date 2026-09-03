using UnityEngine;

public class SkillAloneBulletHitWallBase : SkillAloneBase
{
	private SkillBulletHitWall skill;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	protected virtual void onHit(BulletBase bullet, Collider collider)
	{
	}
}
