using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1756 : SkillAloneBase
{
	private const int HERO_MODEL_ID = 1098001;

	public const int BULLET_ID = 1539;

	private const float TRIGGER_RADIUS = 4.5f;

	private const float FLY_SPEED = 10f;

	private float callInkDragonRate;

	private int maxInkDragonCount;

	private float throughEnemyRatio;

	private float timeInterval;

	private float atkRatio;

	private int debuffId;

	private float minHitRatio;

	private float critRatePercent;

	private float maxCritRate;

	private float critValue;

	protected float dropSoulRate;

	private float soulAliveTime;

	private float soulInterval;

	private float pickCallInkDragonRate;

	private int buffId;

	private List<SkillAlone1756GoodCtrl> createList;

	private ConditionTime inkDragonTime;

	private ConditionTime soulTimeCondition;

	protected virtual bool CanEatDragonSoul => false;

	protected override void OnInstall()
	{
	}

	protected virtual void addCallbacks()
	{
	}

	protected virtual void removeCallbacks()
	{
	}

	private void parseArgs()
	{
	}

	private void OnHeroDrop2Floor()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void parseArgs0(string[] args)
	{
	}

	private void parseArgs1(string[] args)
	{
	}

	private void parseArgs2(string[] args)
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	protected void onEatDragonSoul()
	{
	}

	protected virtual void onCrit(EntityBase entity, long realhit, HitStruct hs)
	{
	}

	private void onAttack()
	{
	}

	private void createInkDragonWrapper(Vector3 bulletPosXZ)
	{
	}

	private void createInkDragon(Vector3 bulletPosXZ)
	{
	}

	private void syncInkDragon(Vector3 bulletPosXZ)
	{
	}

	protected void createSoulWrapper(EntityBase triggerEntity, Vector3 pos, bool onlyShow)
	{
	}

	private void createSoul(EntityBase triggerEntity, Vector3 pos, bool onlyShow)
	{
	}

	private void syncSoul(Vector3 pos)
	{
	}

	protected void gotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void recycleSouls(RoomGenerateBase.Room room)
	{
	}

	private void ChangeCallDragonRate(float delta)
	{
	}

	private void ChangeInkDragonCritValue(float delta)
	{
	}
}
