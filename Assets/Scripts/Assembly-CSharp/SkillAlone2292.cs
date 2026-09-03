using System.Collections.Generic;

public class SkillAlone2292 : SkillAloneBase
{
	private class SkillEffect2292_PoisonFogPathVO : CustomJsonActionVO
	{
		public int EnemyGuid;

		public bool IsCreate;
	}

	private float applyRate;

	private int corrosionBuffId;

	private int poisonFogBuffId;

	private float cooldownTime;

	private int poisonEffectId;

	private float lastTriggerTime;

	private Dictionary<EntityBase, ActionFirePath> poisonFogPaths;

	private const string updateTag = "SkillAlone2292Update";

	private const string SyncSkill2292_PoisonFogPath = "SyncSkill2292_PoisonFogPath";

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

	private void OnUpdate(float delta)
	{
	}

	private void CreatePoisonFogPath(EntityBase enemy)
	{
	}

	private void DoCreatePoisonFogPath(EntityBase enemy)
	{
	}

	private void RemovePoisonFogPath(EntityBase enemy)
	{
	}

	private void DoRemovePoisonFogPath(EntityBase enemy)
	{
	}

	private void ClearAllPoisonFogPaths()
	{
	}

	private void OnEnemyDead(EntityBase enemy)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncPoisonFogPath(int enemyGuid, bool isCreate)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
