public class SkillAlone9043 : SkillAloneBase
{
	private float singleHitMaxRate;

	private float thresholdRate1;

	private float thresholdRate2;

	private float thresholdRate3;

	private int invincibleBuffId;

	private int atkSpeedBuffId;

	private bool isThreshold1Eff;

	private bool isThreshold2Eff;

	private bool isThreshold3Eff;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitted(EntityBase enemy, long realhit, HitStruct hs)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void OnBuffRemovedByTime(EntityBase entity, int buffId)
	{
	}
}
