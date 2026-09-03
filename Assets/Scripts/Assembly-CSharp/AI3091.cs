public class AI3091 : AIBase
{
	protected virtual int WeaponID => 0;

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private bool Conditions()
	{
		return false;
	}

	private ActionBase GetActionMoveOne(int movetime, int waittime)
	{
		return null;
	}

	private ActionBase GetActionMoveTwo(int bulletid, int waitmin, int waitmax)
	{
		return null;
	}
}
