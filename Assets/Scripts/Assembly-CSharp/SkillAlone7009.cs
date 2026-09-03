public class SkillAlone7009 : SkillAloneBase
{
	private float m_fHpPercent;

	private int buffId;

	private int m_atkValue;

	private bool m_bAddFlag;

	private const int bulletId = 1920;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnGameRoomCompleted()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}
}
