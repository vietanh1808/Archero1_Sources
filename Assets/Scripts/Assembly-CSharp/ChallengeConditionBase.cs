public abstract class ChallengeConditionBase
{
	private int _id;

	protected int result;

	protected string mArg;

	protected ChallengeModeBase mChallenge;

	public int ID => 0;

	public int Result => 0;

	public void Init(int id, string arg, ChallengeModeBase challengedata)
	{
	}

	protected abstract void OnInit();

	public void Start()
	{
	}

	protected virtual void OnStart()
	{
	}

	protected void OnFailure()
	{
	}

	protected void OnSuccess()
	{
	}

	public string GetConditionString()
	{
		return null;
	}

	public void DeInit()
	{
	}

	protected abstract void OnDeInit();
}
