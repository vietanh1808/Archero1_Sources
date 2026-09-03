public class SkillAlone2154 : SkillAloneBase
{
	private string[] CONFIG_ATTR_NAMES;

	private float[] CONFIG_ATTR_BASES;

	private float[] CONFIG_ATTR_MAX_UPGRADES;

	private float[] CONFIG_ATTR_MAXS;

	private float[] _lastValues;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHpChanged(long currentHP, long maxHP, float percent, long change)
	{
	}
}
