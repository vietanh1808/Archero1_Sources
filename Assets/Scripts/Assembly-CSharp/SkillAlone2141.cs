public class SkillAlone2141 : SkillAloneBase
{
	private float triggerBuffHPPercent;

	private int improveAttackSpeedPercent;

	private bool isAddProperty;

	private long haveAddPropertyValue;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void OnCreatePlayer()
	{
	}

	protected virtual void CheckBuffStatus(float percent)
	{
	}
}
