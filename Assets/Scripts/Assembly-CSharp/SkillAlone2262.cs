using UnityEngine;

public class SkillAlone2262 : SkillAloneBase
{
	private enum CoreTriggerType
	{
		None = 0,
		ByTime = 1,
		ByHp = 2
	}

	public class Skill2262_CoreExplode : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float notInjuredTime;

	private int coreBuffId;

	private float coreBuffReducePS;

	private float coreBuffCDTime;

	private int dizzyBuffId;

	private float dizzyRadius;

	private float triggerCoreHPRate;

	private int invincibleBuffId;

	private int triggerCoreByHpTimesMax;

	private float coreBuffCDTimeHp;

	private float preHittedTime;

	private int triggerCoreByHpTimes;

	private float preCoreEndTime;

	private float preCoreEndHpTime;

	private long hpReduceInCore;

	private int buffSecondsReduce;

	private const string explodeEffPath = "Effect/Battle/eff_heavensun_frozen_wave";

	private GameObject CoreEff;

	private CoreTriggerType effType;

	private const string SyncSkill2262_CoreExplode = "SyncSkill2262_CoreExplode";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitted(HitStruct hs, EntityBase self)
	{
	}

	private int CalculateBuffReduceTime(long hpReduce)
	{
		return 0;
	}

	private void OnUpdate(float delta)
	{
	}

	private void TriggerCoreEff()
	{
	}

	private void CoreExplodeEff(Vector3 pos)
	{
	}

	private void OnBuffRemovedByTime(EntityBase entity, int buffId)
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void ClearCoreState()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncShockExplode(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
