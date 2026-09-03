using Dxx.Util;

public class SkillAlone2023 : SkillAlone1070
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
