using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2291 : SkillAloneBase
{
	private class SkillEffect2291_DollBoxVO : CustomJsonActionVO
	{
		public Vector3 Position;

		public bool IsCreate;
	}

	private float cancelDamageRate;

	private int invincibleBuffId;

	private int dollBoxHitCount;

	private float dollBoxDuration;

	private float explosionRadius;

	private float explosionDamageRatio;

	private float triggerInterval;

	private int maxTriggerCount;

	private const int dollBoxExplodeId = 8932;

	private int currentTriggerCount;

	private float lastTriggerTime;

	private EntityPartBodyBase currentDollBox;

	private int dollBoxCurrentHitCount;

	private string dollBoxUpdateTag;

	private List<EntityBase> attractedEnemies;

	private float dollBoxCreateTime;

	private int dollBoxPartId;

	private const string SyncSkill2291_DollBox = "SyncSkill2291_DollBox";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitted(EntityBase attacker, long damage, HitStruct hs)
	{
	}

	private void TriggerMagicTrick()
	{
	}

	private void CreateDollBox()
	{
	}

	private void DoCreateDollBox(Vector3 createPos)
	{
	}

	private void AttractNearbyMonsters()
	{
	}

	private BulletBase CreateExplode(int bulletId, Vector3 bulletPos, float rotate, float atkPercent, float radius)
	{
		return null;
	}

	private void OnDollBoxHitted(EntityBase attacker, long damage)
	{
	}

	private void OnDollBoxUpdate(float delta)
	{
	}

	private void ExplodeDollBox()
	{
	}

	private void DoExplodeDollBox(Vector3 explosionPos)
	{
	}

	private void DestroyDollBox()
	{
	}

	private void RestoreMonsterTargets()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncDollBox(Vector3 position, bool isCreate)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
