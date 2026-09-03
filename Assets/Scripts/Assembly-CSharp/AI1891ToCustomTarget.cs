public class AI1891ToCustomTarget : AIMoveToCustomTarget
{
	private float originalSpeed;

	protected JoyData nextMoveData;

	protected override string LogTag => null;

	public AI1891ToCustomTarget(EntityBase entity)
		: base(null)
	{
	}

	protected override void onAfterInit()
	{
	}

	protected virtual float GetDistance()
	{
		return 0f;
	}

	protected virtual bool CheckIfBehindMe()
	{
		return false;
	}

	protected override bool isCloseEnough()
	{
		return false;
	}

	protected override bool isEntityInvalid()
	{
		return false;
	}

	protected override void updateDir()
	{
	}

	protected override void OnEnd()
	{
	}
}
