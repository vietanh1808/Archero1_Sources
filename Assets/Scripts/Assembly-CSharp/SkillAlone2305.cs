using System.Collections.Generic;

public class SkillAlone2305 : SkillAloneBase
{
	private int slowBuffId;

	private int stunBuffId;

	private int elementDmgBuffId;

	private int slowCountThreshold;

	private Dictionary<int, int> enemySlowCount;

	private HashSet<int> trappedEnemies;

	private const int waterBallFlySwordId = 5382;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitAction(EntityBase target, HitStruct hs, HittedData data)
	{
	}

	private void TrapEnemy(EntityBase target)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
