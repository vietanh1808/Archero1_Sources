public class SkillAlone1232 : SkillAloneBase
{
	private float m_fDistanceAttackMinPercent;

	private float m_fDistanceAttackAgsPercent;

	private float m_fDistanceMin;

	private float m_fDistanceMax;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private float OnCalBulletFlyDis(HitStruct otherhs, EntityBase entity)
	{
		return 0f;
	}
}
