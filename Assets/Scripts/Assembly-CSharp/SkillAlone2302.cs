public class SkillAlone2302 : SkillAloneBase
{
	private class SkillEffect2302_WaterBallVO : CustomJsonActionVO
	{
		public int TargetGuid;
	}

	private class SkillEffect2302_ExplodeVO : CustomJsonActionVO
	{
		public int TargetGuid;
	}

	private float spawnInterval;

	private float waterDamageRatio;

	private float explodeDamageRatio;

	private float explodeRadius;

	private int slowBuffId;

	private const int waterBallFlySwordId = 5382;

	private const int waterBallExplodeId = 5383;

	private float lastSpawnTime;

	private float lastUpdateTime;

	private const float updateInterval = 0.3f;

	private const string SyncSkill2302_WaterBall = "SyncSkill2302_WaterBall";

	private const string SyncSkill2302_Explode = "SyncSkill2302_Explode";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void TrySpawnWaterBall(EntityBase target)
	{
	}

	private void DoSpawnWaterBall(EntityBase target)
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void DoExplode(EntityBase target)
	{
	}

	private void SyncWaterBall(int targetGuid)
	{
	}

	private void SyncExplode(int targetGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
