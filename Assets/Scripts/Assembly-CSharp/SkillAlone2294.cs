using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2294 : SkillAloneBase
{
	private class SkillEffect2294_ShockwaveVO : CustomJsonActionVO
	{
		public Vector3 Position;

		public int CenterEnemyGuid;
	}

	private float applyNoteRate;

	private int noteBuffId;

	private float triggerShockwaveRate;

	private int maxActiveShockwaveCount;

	private float shockwaveDamageRatio;

	private int shockwaveSlowBuffId;

	private int maxNoteEnemyCount;

	private const int shockwaveBulletId = 8933;

	private const float shockwaveRadius = 3f;

	private List<EntityBase> noteEnemies;

	private Dictionary<int, int> enemyShockwaveCount;

	private HashSet<int> currentChainProcessed;

	private const string SyncSkill2294_Shockwave = "SyncSkill2294_Shockwave";

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

	private void TryApplyNote(EntityBase enemy)
	{
	}

	private void TryTriggerShockwave(EntityBase enemy, bool isActive)
	{
	}

	private void TriggerShockwave(EntityBase centerEnemy)
	{
	}

	private void DoTriggerShockwave(Vector3 shockwavePos, EntityBase centerEnemy)
	{
	}

	private void CreateShockwaveBullet(Vector3 position)
	{
	}

	private void OnNoteEnemyDead(EntityBase enemy)
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncShockwave(Vector3 position, int centerEnemyGuid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
