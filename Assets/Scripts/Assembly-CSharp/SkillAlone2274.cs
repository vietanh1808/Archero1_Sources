public class SkillAlone2274 : SkillAloneBase
{
	private float lifeThreshold;

	private int buffId;

	private float recoverRate;

	private float hitThreshold;

	private float cdTime;

	private float preHealTime;

	private bool isSpecailHit;

	private bool isPVPHit;

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
}
