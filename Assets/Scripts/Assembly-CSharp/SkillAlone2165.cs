public class SkillAlone2165 : SkillAlone2164
{
	private float CONFIG_HP_PERCENT;

	private int CONFIG_INVINCIBLE_BUFF_ID;

	private bool m_bUsed;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	private void OnReborn()
	{
	}

	private void OnParentChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}
}
