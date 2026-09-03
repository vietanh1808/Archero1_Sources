using Dxx.Util;

public class SkillAlone1665 : SkillAloneBase
{
	private float m_fHpPercent;

	private float m_fRecoverHpMinPercent;

	private float m_fRecoverHpMaxPercent;

	private float m_fTime;

	private int m_nCnt;

	private bool m_bAddedFlag;

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

	private void OnReborn(BattleModuleData.UseRebornType type)
	{
	}
}
