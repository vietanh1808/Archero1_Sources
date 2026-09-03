public class SkillAlone1939 : SkillAlonePetBase
{
	private float triggerHP;

	private float improvePetCritRate;

	private bool haveAddProperty;

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

	protected virtual void CheckProperty(float percent)
	{
	}

	protected virtual void AddProperty()
	{
	}

	protected virtual void RemoveProperty()
	{
	}
}
