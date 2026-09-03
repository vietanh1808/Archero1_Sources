public class SkillAlone2242 : SkillAlone2241
{
	private float triggerAddHitReduceHp;

	private float perAddHitReduce;

	private bool canAddHitReduce;

	private long haveAddHitReduce;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void SkillTriggerEntityEnter(EntityBase triggerEntity)
	{
	}

	protected override void SkillTriggerEntityExit(EntityBase triggerEntity)
	{
	}

	private void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void TryAddProperty(float curHpPercent)
	{
	}

	private void RemoveProperty()
	{
	}
}
