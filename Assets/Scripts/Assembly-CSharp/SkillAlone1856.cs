public class SkillAlone1856 : SkillAlone1855
{
	private int dropHPCount;

	private float dropHPCDTime;

	private float dropHPProb;

	private ConditionTime dropHPCD;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}
}
