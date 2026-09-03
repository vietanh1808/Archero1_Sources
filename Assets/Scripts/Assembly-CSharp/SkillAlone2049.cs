public class SkillAlone2049 : SkillAloneBase
{
	protected CommonAuraCtrl shieldHitCtrl;

	protected EntityBase playerEntity;

	private int buffId;

	private float radius;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual CommonAuraCtrl AddShield()
	{
		return null;
	}

	private void onEnterCommonCollider(EntityBase entity)
	{
	}

	private void onExitCommonCollider(EntityBase entity)
	{
	}
}
