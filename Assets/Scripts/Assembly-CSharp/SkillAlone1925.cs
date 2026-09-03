using System.Collections.Generic;

public class SkillAlone1925 : SkillAloneBase
{
	private const string UPDATE_NAME = "SkillAlone1925-UPDATE";

	private int buffId;

	private int meteorCount;

	private int maxMeteorsPerEnemy;

	private float minMeteorRadius;

	private float maxMeteorRadius;

	private float atkPercent;

	private float cdTime;

	private List<MeteorAction> meteorActions;

	private FirstEnemyCheck firstEnemyCheck;

	private ConditionTime cd;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void onFirstEnemyCreated()
	{
	}

	private void onCreateMeteors()
	{
	}

	private void parseArgs()
	{
	}
}
