using Dxx.Util;

public class SkillAlone2024 : SkillAlone4012
{
	private float cirtScale;

	private float critValue;

	private AttackCallData curData;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override AttackCallData OnCreateAttackCallData()
	{
		return null;
	}

	private void OnCreateBullet(BulletBase bulletBase)
	{
	}
}
