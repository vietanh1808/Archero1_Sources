using System;
using UnityEngine;

public class SkillAlone2341 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2341SteamSmashVO : CustomJsonActionVO
	{
		public Vector3 DeathPos;

		public float BaseAngle;

		public float Offset0;

		public float Offset1;

		public float Offset2;

		public float Offset3;
	}

	private float triggerRate;

	private int furnaceBuffId;

	private float cooldown;

	private float explodeRadius;

	private float explodeHitRatio;

	private float fireballRadius;

	private float fireballHitRatio;

	private float fireballAngleOffset;

	private float lastTriggerTime;

	private const int ExplodeBulletId = 1625;

	private const int FireballBulletId = 1624;

	private const int ExplodeBulletPVPId = 1627;

	private const int FireballBulletPVPId = 1626;

	private const string SyncSkill2341_SteamSmash = "SyncSkill2341_SteamSmash";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ParseParams()
	{
	}

	private void OnKill(EntityBase killed, Vector3 hitDir, HitStruct hs)
	{
	}

	private void OnMonsterDead(EntityBase killed)
	{
	}

	private void TryTriggerSteamSmash(EntityBase killed)
	{
	}

	private void OnHit(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void ExecuteSteamSmash(Vector3 deathPos, float baseAngle, float[] offsets)
	{
	}

	private void CreateExplodeBullet(Vector3 pos)
	{
	}

	private void CreateFireball(Vector3 pos, float angle)
	{
	}

	private void SyncSteamSmash(Vector3 deathPos, float baseAngle, float[] offsets)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
