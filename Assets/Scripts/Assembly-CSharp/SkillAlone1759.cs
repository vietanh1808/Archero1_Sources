public class SkillAlone1759 : SkillAloneBase
{
	private float CONFIG_HP_PERCENT;

	private int CONFIG_DEBUFF_ID;

	private float CONFIG_HIT_RATIO;

	private bool m_bAddDebuffFlag;

	private bool m_bAddAttrFlag;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected virtual void ExcuteAttribute(string name, float value)
	{
	}
}
