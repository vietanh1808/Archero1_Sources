public class AI3210 : AIBase
{
	private enum state
	{
		fire = 0,
		wait = 1
	}

	private const float FIRE_DURATION = 1f;

	private const float WAIT_DURATION = 2f;

	private const float TIME_INTERVAL = 0.06f;

	private const int ICEL_TAIL_BULLET_COUNT = 4;

	private const int BULLET_ID = 1193;

	private const int ICE_TAIL_BULLET_ID = 5148;

	private state curState;

	private float curTime;

	private ConditionTime fireTime;

	private ConditionTime waitTime;

	private int index;

	private float startangle;

	protected override void OnInitOnce()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void createBullet()
	{
	}

	private void createEliteBullets()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnAIDeInit()
	{
	}
}
