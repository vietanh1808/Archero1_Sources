public class SkillAloneBulletCountBase : SkillAloneBase
{
	protected int maxBulletCount;

	private bool addFlag;

	protected override void OnInstall()
	{
	}

	protected virtual void OnParseArgs()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackPre(WeaponBase weaponBase)
	{
	}

	private void OnAttackEnd(WeaponBase weaponBase)
	{
	}

	protected virtual void OnAttackPreCallback(WeaponBase weapon)
	{
	}

	protected virtual void OnAttackEndCallback(WeaponBase weapon)
	{
	}
}
