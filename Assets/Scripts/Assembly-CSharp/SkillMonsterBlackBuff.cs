public class SkillMonsterBlackBuff : SkillRefineBase
{
	public int buffId;

	public float radius;

	public int maxBuffCount;

	public float timeInterval;

	private int timerId;

	private int curBuffCount;

	public SkillMonsterBlackBuff(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private string timerName()
	{
		return null;
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
