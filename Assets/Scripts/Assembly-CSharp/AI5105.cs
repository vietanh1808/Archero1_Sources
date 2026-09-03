using Dxx.Util;

public class AI5105 : AIBase
{
	public const int CHAR_ID = 5105;

	private const int BULLET_ID = 5130;

	private const int CALL_ID = 3085;

	private const int MAX_COUNT_PER_CALL = 1;

	private const int MAX_COUNT_IN_STAGE = 12;

	private const int MAX_ACCUMULATED_COUNT = 12;

	private const int MIN_RADIUS = 3;

	private const int MAX_RADIUS = 5;

	private int randomCallId;

	private ActionBasic callActionBase;

	private WeightRandomCount mWeightRandom;

	private int ran;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	private void addfrontrun()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void onHit(EntityBase target, HitStruct hs, HittedData hd)
	{
	}

	public void TryCall()
	{
	}

	private ActionBase GetActionMoveOne(int waittime, int waitmaxtime)
	{
		return null;
	}
}
