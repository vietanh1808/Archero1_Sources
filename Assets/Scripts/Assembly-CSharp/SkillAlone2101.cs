public class SkillAlone2101 : SkillAloneBase
{
	private int buffId;

	private int debuffId;

	private int attackTimes;

	private float CDTime;

	private float attackInterval;

	private int curHitCount;

	private float preEffestTime;

	private float preAttackTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitEnemy(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}
}
