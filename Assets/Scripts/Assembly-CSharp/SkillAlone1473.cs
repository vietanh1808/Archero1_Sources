public class SkillAlone1473 : SkillAloneBase
{
	private const string UPDATE_NAME = "UPDATE-SkillAlone1473";

	private const string TIMER_NAME = "Timer-SkillAlone1473";

	private int buffId;

	private float timeInterval;

	private int timerId;

	public object TimerRegister { get; private set; }

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void onUpdate(float deltaTime)
	{
	}

	private void onTimer()
	{
	}

	protected void CheckIfClearBuff()
	{
	}
}
