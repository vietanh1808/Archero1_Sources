using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2295 : SkillAloneBase
{
	private class SkillEffect2295_SprayPaintVO : CustomJsonActionVO
	{
		public Vector3 Position;

		public int BulletId;

		public int TargetGuid;
	}

	private float sprayRate;

	private float paintRadius;

	private int poisonDebuffId;

	private int stunHitCount;

	private int stunBuffId;

	private float internalCooldown;

	private static readonly int[] PaintBulletIds;

	private float lastSprayTime;

	private Dictionary<int, int> enemyPaintHitCount;

	private const string SyncSkill2295_SprayPaint = "SyncSkill2295_SprayPaint";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void SprayPaint(EntityBase target)
	{
	}

	private void DoSprayPaint(Vector3 pos, int bulletId, int targetGuid)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncSprayPaint(Vector3 pos, int bulletId, int targetGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
