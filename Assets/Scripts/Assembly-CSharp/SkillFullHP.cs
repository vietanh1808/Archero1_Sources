public class SkillFullHP : SkillRefineBase
{
	public int BuffId;

	public string BuffKey;

	public SkillFullHP(EntityBase entity)
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

	private void checkIfReachMaxHP()
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void onFullHP()
	{
	}
}
