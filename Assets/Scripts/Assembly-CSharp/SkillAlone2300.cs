public class SkillAlone2300 : SkillAloneBase
{
	private float hpThresholdPercent;

	private float damageReducePercent;

	private int damageReduceBuffId;

	private float effectCooldown;

	private float lastTriggerTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitted(EntityBase attacker, long damage, HitStruct hs)
	{
	}
}
