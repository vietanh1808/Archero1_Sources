public class SkillAlone9011 : SkillAloneBase
{
	private float m_hp1;

	private int m_crit1;

	private int m_crit2;

	private float m_hp2;

	private int m_hpCover;

	private int buffid;

	private float needTime;

	private bool m_bAddFlag;

	private int lastTime;

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
