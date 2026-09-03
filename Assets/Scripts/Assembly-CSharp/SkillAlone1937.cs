public class SkillAlone1937 : SkillAlonePetBase
{
	private float limitAddFlamingoDmg;

	private float perEnemyAddFlamingoDmg;

	private float haveAddDmg;

	private float checkTime;

	private ConditionTime conditionTime;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	protected virtual int CheckEnemy()
	{
		return 0;
	}

	private float GetExtraFlamingoDmg()
	{
		return 0f;
	}
}
