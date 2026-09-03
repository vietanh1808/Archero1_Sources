public class ActionCallSwords
{
	private const int BULLET_ID = 1207;

	private const string TIMER_NAME = "ActionCallSwords-Timer";

	private const string UPDATE_NAME = "ActionCallSwords-Update";

	public EntityBase m_Entity;

	public int SwordCount;

	public float TimeInterval;

	public bool CanThroughEnemy;

	public bool CanCrit;

	public bool CanWithElements;

	private float curCumulatedTime;

	private float curTime;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onUpdate(float deltaTime)
	{
	}

	public void CallSwords()
	{
	}
}
