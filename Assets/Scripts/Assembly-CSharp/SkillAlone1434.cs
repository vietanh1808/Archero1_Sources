public class SkillAlone1434 : SkillAloneBase
{
	private const string TIMER_NAME = "SkillAlone1434-Timer";

	private int timerId;

	private int buffId;

	private float radius;

	private int maxBuffCount;

	private float timeInterval;

	private int curBuffCount;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onTimer()
	{
	}

	private bool hasBlackDebuff(EntityBase enemy)
	{
		return false;
	}

	private void addBuff()
	{
	}

	private void removeBuff()
	{
	}
}
