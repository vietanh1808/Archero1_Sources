public class SkillAlone1972 : SkillAloneBase
{
	private int skillBuffID;

	private int hurtAddSkillBuffProb;

	private int attackAddSkillBuffProb;

	private int triggerHPPercent;

	private int triggerValue;

	private bool haveAddProperty;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void CheckAddProperty()
	{
	}

	private void CheckRemoveProperty()
	{
	}

	private void OnAttack()
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}

	private void CheckHurtAddBuff()
	{
	}

	private void CheckAttackAddBuff()
	{
	}

	private void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void OnCreatePlayer()
	{
	}

	protected virtual void CheckTriggerHPStatus(float percent)
	{
	}
}
