using Dxx.Util;

public class AI5101 : AIGroundBase
{
	public class ActionAttackMix : ActionSeqWrapper
	{
		protected override void OnInit()
		{
		}
	}

	public const int CHAR_ID = 5101;

	private int ran;

	private WeightRandomCount weight;

	private int callid;

	public bool useMixBullets;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	private ActionBase GetActionAttacks(int attackid, int attacktime, int attackmaxtime)
	{
		return null;
	}

	private bool Conditions()
	{
		return false;
	}

	private ActionBase GetCall()
	{
		return null;
	}
}
