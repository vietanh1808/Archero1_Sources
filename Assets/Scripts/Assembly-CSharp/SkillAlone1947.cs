public class SkillAlone1947 : SkillAloneBase
{
	private float CONFIG_RATE;

	private float CONFIG_CD;

	private int CONFIG_BULLET_ID;

	private float CONFIG_HIT_RATIO_MAX;

	private float CONFIG_DISTANCE_MAX;

	private float CONFIG_BACKRATIO;

	private float m_fLastTime;

	protected virtual bool Condition => false;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackEnd()
	{
	}

	protected virtual void CreateBullet()
	{
	}

	private float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}
}
