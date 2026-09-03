public class SkillLowerHP : SkillRefineBase
{
	private const string LOG_TAG = "[SkillLowerHP]";

	public float MinPercent;

	public int BuffId;

	public string BuffKey;

	public float[] args;

	public SkillLowerHP(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onCreatePlayer()
	{
	}

	private void recoverFromLocal()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}
}
