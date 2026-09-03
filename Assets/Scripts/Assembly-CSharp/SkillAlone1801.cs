public class SkillAlone1801 : SkillAlone1769
{
	private int HammerFarBulletID;

	private float cumulativeTime;

	private bool isThunderSpear;

	private LocalSave.HammerPassiveV0 HammerPassiveV0 => null;

	private int FlashPoint => 0;

	private long HammerChangeNeedCount => 0L;

	private EntityAttributeBase Attribute => null;

	private long ThunderLightMaxLimit => 0L;

	private long FlashPointPerAttackAdd => 0L;

	private long ThunderLightPerSecondCost => 0L;

	private long ThunderLightAttackCost => 0L;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private new void OnAttack()
	{
	}

	private void HammerMeleeAttack()
	{
	}

	private void HammerFarAttack()
	{
	}

	private void ThunderSpearAttack()
	{
	}

	private void ThunderLightPerSecond()
	{
	}

	private void AfterAttack()
	{
	}

	private void OnHammerChangeState(bool isThunderSpear)
	{
	}

	private new void OnUpdate(float delta)
	{
	}

	private void CheckState()
	{
	}
}
