using System.Collections.Generic;

public class SkillAlone2307 : SkillAloneBase
{
	private class SkillEffect2307_WaterBallsVO : CustomJsonActionVO
	{
		public List<int> TargetGuids;
	}

	private int initialWaterBallCount;

	private int damageReduceDebuffId;

	private float waterBallHitRatio;

	private const int waterBallFlySwordId = 5382;

	private bool isCastedFlySword;

	private float lastUpdateTime;

	private const float updateInterval = 0.3f;

	private const string SyncSkill2307_WaterBalls = "SyncSkill2307_WaterBalls";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void SpawnInitialWaterBalls()
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void DoSpawnWaterBall(EntityBase target, int index)
	{
	}

	private void SyncWaterBalls(List<int> targetGuids)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
