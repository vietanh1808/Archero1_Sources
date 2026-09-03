using UnityEngine;

public class SkillAlone2323 : SkillAloneBase
{
	private class SyncVO : CustomJsonActionVO
	{
		public Vector3 StartPos;

		public Vector3 Dir;
	}

	private float shootRate;

	private float damageRatio;

	private int reboundCount;

	private float cooldownTime;

	private float cooldownReduce;

	private const int footballBulletId = 1615;

	private const float pickupDistance = 1f;

	private const float pickupGraceTime = 0.3f;

	private float lastShootTime;

	private float footballCreateTime;

	private BulletBase currentFootball;

	private string updateTag;

	private const string SyncAction = "SyncSkill2323_Shoot";

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

	private void ShootFootball(EntityBase target)
	{
	}

	private void DoShootFootball(Vector3 startPos, Vector3 dir)
	{
	}

	private void OnDistanceCheck(float delta)
	{
	}

	private void OnFootballCache(BulletBase bullet)
	{
	}

	private void ClearFootball()
	{
	}

	private void SyncShoot(Vector3 startPos, Vector3 dir)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
