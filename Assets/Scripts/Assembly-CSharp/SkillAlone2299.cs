using UnityEngine;

public class SkillAlone2299 : SkillAloneBase
{
	private class SkillEffect2299_ButterflyVO : CustomJsonActionVO
	{
		public float PosX;

		public float PosZ;

		public float Angle;
	}

	private class SkillEffect2299_ExplodeVO : CustomJsonActionVO
	{
		public int TargetGuid;
	}

	private float enterStateRate;

	private int butterflyBuffId;

	private float attackTriggerRate;

	private float explodeDamageRatio;

	private float internalCooldown;

	private const int butterflyFlySwordId = 1608;

	private const int butterflyExplodeBulletId = 1607;

	private float lastButterflyTime;

	private const string SyncSkill2299_Butterfly = "SyncSkill2299_Butterfly";

	private const string SyncSkill2299_Explode = "SyncSkill2299_Explode";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnEnemyDead(EntityBase deadEntity)
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void TryLaunchButterfly(EntityBase target)
	{
	}

	private void DoLaunchButterfly(Vector3 startPos, float angle)
	{
	}

	private void TryExplodeAtTarget(EntityBase target)
	{
	}

	private void DoExplodeAtTarget(EntityBase target)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncButterfly(Vector3 startPos, float angle)
	{
	}

	private void SyncExplode(int targetGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
