public class AI1891RunBackToHero : AI1891ToCustomTarget
{
	protected override string LogTag => null;

	public AI1891RunBackToHero(EntityBase entity)
		: base(null)
	{
	}

	protected override float GetDistance()
	{
		return 0f;
	}

	protected override bool isEntityInvalid()
	{
		return false;
	}

	protected override bool CheckIfBehindMe()
	{
		return false;
	}
}
