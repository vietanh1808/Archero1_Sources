using System;
using UnityEngine;

public class SkillAlone1384 : SkillAloneBulletHitWallBase
{
	[Serializable]
	private class SyncSkill1384ExplodeVO : CustomJsonActionVO
	{
		public Vector3 Pos;

		public int[] TargetGuids;
	}

	private float radius;

	private float explodeRate;

	private float attackPercent;

	private const string SyncSkill1384_Explode = "SyncSkill1384_Explode";

	protected override void ParseArgs()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onBulletDeInit(BulletBase bullet)
	{
	}

	protected override void onHit(BulletBase bullet, Collider collider)
	{
	}

	private void DoExplode(Vector3 centerPos, int[] targetGuids = null)
	{
	}

	private void SyncExplode(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
