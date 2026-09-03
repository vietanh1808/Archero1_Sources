public class SkillAlone1910 : SkillAlonePetBase
{
	private int buffID;

	private float triggerHPPercent;

	private bool needAddBuff;

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

	private void HitEnemy(EntityBase attackedTarget, HitStruct arg2, HittedData arg3)
	{
	}
}
