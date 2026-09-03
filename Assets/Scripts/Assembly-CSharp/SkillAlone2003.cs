using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2003 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2003WhirlwindVO : CustomJsonActionVO
	{
		public Vector3 Pos;

		public int TargetGuid;
	}

	[Serializable]
	private class SyncSkill2003FlashLayerVO : CustomJsonActionVO
	{
		public int Layer;
	}

	[Serializable]
	private class SyncSkill2003FlashEnergyVO : CustomJsonActionVO
	{
		public float Energy;

		public float EnergyMax;
	}

	private float closeRangeDistance;

	private float closeDmgBoostRatio;

	private float whirlwindRate;

	private int whirlwindBuffId;

	private float whirlwindCdTime;

	private float whirlwindDmgRatio;

	private float whirlwindRadius;

	private float whirlwindExplodeDmgRatio;

	private float explodeRadius;

	private int stunBuffId;

	private int moveSpeedBuffId;

	private float flashEnergyPerSec;

	private float flashEnergyMax;

	private int flashLayerMax;

	private int flashDodgeBuffId;

	private float whirlwindRadiusRise;

	private float whirlwindDamageRise;

	private readonly Dictionary<int, float> whirlwindCdMap;

	private float moveSpeedCheckTimer;

	private int currentMoveSpeedBuffCount;

	private const int MoveSpeedBuffMaxCount = 5;

	private float flashEnergyCurrent;

	private int flashLayerCurrent;

	private float flashEnergyRatio;

	private float flashEnergyTimer;

	private int whirlwindBulletId;

	private int selfExplodeBulletId;

	private int enemyExplodeBulletId;

	private const string SyncSkill2003_Whirlwind = "SyncSkill2003_Whirlwind";

	private const string SyncSkill2003_FlashLayer = "SyncSkill2003_FlashLayer";

	private const string SyncSkill2003_FlashEnergy = "SyncSkill2003_FlashEnergy";

	private float flashEnergySyncTimer;

	private const float FlashEnergySyncInterval = 0.1f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private float OnCalHitRaise(HitStruct ht, EntityBase entity)
	{
		return 0f;
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void OnRequestCreateWhirlwind(EntityBase enemy, bool ignoreCd)
	{
	}

	private void TrySpawnWhirlwind(EntityBase enemy, bool ignoreCd = false)
	{
	}

	private BulletBase CreateWhirlwindBullet(Vector3 bulletPos, EntityBase target = null)
	{
		return null;
	}

	private void OnWhirlwindEnd(BulletBase whirlwind)
	{
	}

	private void CheckMoveSpeed(float delta)
	{
	}

	private bool HasEnemyInRange(float range)
	{
		return false;
	}

	private void RemoveAllMoveSpeedBuff()
	{
	}

	private void UpdateFlashEnergy(float delta)
	{
	}

	private void AddFlashLayer()
	{
	}

	public int GetFlashLayerCurrent()
	{
		return 0;
	}

	private void OnRequestAddFlashLayer(int count)
	{
	}

	private void OnRequestAddFlashEnergy(float energy)
	{
	}

	private void OnSetFlashLayerMax(int newMax)
	{
	}

	private void OnSetFlashEnergyRatio(float ratio)
	{
	}

	private void SaveFlashData()
	{
	}

	private bool TryFlashResistDamage(EntityBase attacker, long damage, HitStruct hs)
	{
		return false;
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void ExternalSetExtraRadius(float radiusRise)
	{
	}

	private void ExternalSetExtraHitRise(float damageRise)
	{
	}

	private void SyncWhirlwind(Vector3 pos, int targetGuid)
	{
	}

	private void SyncFlashLayer(int layer)
	{
	}

	private void TrySyncFlashEnergy(float delta)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
