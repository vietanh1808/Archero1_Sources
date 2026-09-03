public class AI5092 : AIDizzyBase
{
	private const string ANIM_INSTANT_MOVE = "Instant_AttackPrev";

	private const string ANIM_INSTANT_MOVE_END = "Instant_AttackEnd";

	private float animInstanteMoveTime;

	private float animInstantMoveEndTime;

	private int bulletId;

	private const float slowDeltaPercent = 0.99999f;

	private float pauseAnimTime;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void PopulateActions()
	{
	}

	private ActionBase getRandomAction()
	{
		return null;
	}
}
