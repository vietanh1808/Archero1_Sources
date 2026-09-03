public class SkillAlone1548 : SkillAloneBase
{
	private float hitEntityPercent;

	private float timeInterval;

	private float maxPercent;

	private float cumulatedPercent;

	private SkillHitEnemy skill;

	private ConditionTime timeCondition;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onHitEnemy(EntityBase attackTarget, HitStruct data, HittedData hitteddata)
	{
	}

	private void onBefore(WeaponBase weapon)
	{
	}

	private void syncCumulatedPercent()
	{
	}
}
