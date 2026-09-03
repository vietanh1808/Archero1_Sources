public class SkillAlone1136 : SkillAloneBase
{
	private float m_fHpPercent;

	private int m_nBuffId;

	private bool m_bUsed;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected virtual void SendBuff()
	{
	}

	protected virtual void OnReborn()
	{
	}
}
