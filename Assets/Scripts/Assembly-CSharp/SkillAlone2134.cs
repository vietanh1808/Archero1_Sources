public class SkillAlone2134 : SkillAloneBase
{
	private float CONFIG_SHIELD_PERCENT_MAX;

	private float CONFIG_SHIELD_ADD_PERCENT_BASE;

	private float CONFIG_SHIELD_ADD_PERCENT_MAX;

	private long ShieldMax => 0L;

	protected override void OnInstall()
	{
	}

	private void OnAfterRunWuKongAI()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnRecoverEvent(long value)
	{
	}

	private long OnHpChange(EntityBase entity, long value)
	{
		return 0L;
	}

	private void OnHpUpdate(long before)
	{
	}

	protected virtual void UpdateHpShieldUI(long value, long max)
	{
	}

	private void AddHpShieldUIByPercent(float percent)
	{
	}
}
