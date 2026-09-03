using System;
using UnityEngine;

public class SkillAlone2340 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2340WaterBallVO : CustomJsonActionVO
	{
		public Vector3 StartPos;

		public Vector3 EndPos;

		public int TargetGuid;
	}

	private int hitCountToTrigger;

	private float waterBallHitRatio;

	private float healLostHpPercent;

	private float minCooldown;

	private float parabolaHeight;

	private float flySpeed;

	private int currentHitCount;

	private float lastTriggerTime;

	private bool attackActionPendingHit;

	private const string WaterBallEffPath = "Effect/Battle/eff_2340_waterball";

	private const float AngleOffset = 22.5f;

	private const string SyncSkill2340_WaterBall = "SyncSkill2340_WaterBall";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnAttackStart(JoyData data)
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void CountHitAndTryLaunch(EntityBase hitTarget)
	{
	}

	private void LaunchWaterBalls(EntityBase target)
	{
	}

	private void LaunchWaterBallsAt(Vector3 startPos, Vector3 endPos, EntityBase target)
	{
	}

	private void CreateWaterBall(Vector3 startPos, Vector3 endPos, float curveAngle, EntityBase target)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncWaterBalls(Vector3 startPos, Vector3 endPos, int targetGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
