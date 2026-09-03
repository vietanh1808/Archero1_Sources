public class SkillAlone1179 : SkillAloneBase
{
	private float m_fHpDropValue;

	private float m_fHpAddValue;

	private float m_fOldHpPercent;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}
}
