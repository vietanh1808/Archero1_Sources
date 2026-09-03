public class SkillAlone1872 : SkillAlonePetBase
{
	private float addPerPropertyNeed;

	private float addPerPropertyCount;

	private int curAddCount;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void OnCreatePlayer()
	{
	}

	private int NeedAddCount(long curHP, long maxHp)
	{
		return 0;
	}

	private void AddProperty(int count)
	{
	}
}
