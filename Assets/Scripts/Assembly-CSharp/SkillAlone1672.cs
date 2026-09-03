public class SkillAlone1672 : SkillAloneBase
{
	private float m_fAttackSpeedPercentMax;

	private float m_fAttackRatio;

	private float m_fOffsetMax;

	protected float m_fOffset;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnAttackSpeedChanged(float oldValue, float newValue)
	{
	}

	protected virtual float OnCalValue(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}
}
