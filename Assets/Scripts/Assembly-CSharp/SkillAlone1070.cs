using Dxx.Util;

public class SkillAlone1070 : SkillAloneBase
{
	private long clockindex;

	private int bulletid;

	private int createweight;

	private float dropRadius;

	private float outRadius;

	private float innerRadius;

	private float innerhitratio;

	private float outhitratio;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private bool OnBulletIsMeteorite(int nBulletId)
	{
		return false;
	}

	protected virtual AttackCallData OnCreateAttackCallData()
	{
		return null;
	}
}
