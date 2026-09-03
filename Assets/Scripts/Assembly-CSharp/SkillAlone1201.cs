using Dxx.Util;

public class SkillAlone1201 : SkillAloneBase
{
	private float m_fHpPercent;

	private int m_nBuffId;

	private bool m_bFlag;

	private SequencePool mSeqPool;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}
}
