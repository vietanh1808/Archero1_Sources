public class SkillAlone1971 : SkillAloneBase
{
	private float triggerHPPercent;

	private int recoverHPBuffID;

	private int headShotTriggerBuffProb;

	private int headShotBuffID;

	private LocalSave.Skill1971VO Skill1971VO => null;

	private bool HaveRecover => false;

	protected override void OnInstall()
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

	protected virtual void CheckAddHPBuff(float percent)
	{
	}

	private void OnAttack()
	{
	}

	private void OnHeadShot(EntityBase entity, bool lessHpHeadShot)
	{
	}

	private void CheckAddBuff()
	{
	}
}
