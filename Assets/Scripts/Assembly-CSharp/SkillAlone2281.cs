public class SkillAlone2281 : SkillAloneBase
{
	private float fullLifeRate;

	private float duration;

	private int buffId;

	private EntityHero hero;

	private bool isUsingDagger;

	private bool isSkillEff;

	private float preEffTime;

	protected override void OnInstall()
	{
	}

	protected virtual void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnTridentChangeState(bool isDagger)
	{
	}

	private bool OnCheckSuperSkill()
	{
		return false;
	}

	private bool CanSuperSkill()
	{
		return false;
	}

	private void OnSuperSkill(bool flag)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void SuperSkillEffect()
	{
	}

	private void SuperSkillExpire()
	{
	}
}
