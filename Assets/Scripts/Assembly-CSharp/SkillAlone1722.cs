using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1722 : SkillAloneBase
{
	private float chickenLegRemainTime;

	private float chickenLegCreateInterval;

	private int hitDropMaxCount;

	private int chickenLegHpAddPercent;

	private int chickenLegCritRateAdd;

	private int chickenLegBackRatioAdd;

	private int chickenLegCritRateMaxAdd;

	private int chickenLegBackRatioMaxAdd;

	private int killCreateProb;

	private int rotateBallHitCreateProb;

	private int rotateSwordHitCreateProb;

	private int flySwordHitCreateProb;

	private int meteoriteHitCreateProb;

	private int meteorHitCreateProb;

	private int buffID;

	private float triggerRadius;

	private float flySpeed;

	private SequencePool mSeqPool;

	private float chickenLegLastCreateTime;

	private long allAddCritRate;

	private long allAddBackRate;

	private List<Skill1722Data> recordData;

	private List<SkillAlone1722GoodCtrl> createList;

	private LocalSave.Skill1722VO Skill1722VO => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void HitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void HitEnemy(EntityBase entity, int prob)
	{
	}

	private void OnMonsterDead(EntityBase attackTarget)
	{
	}

	private void KillEnemy(EntityBase attackTarget, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void KillEnemyWrapper(EntityBase attackTarget)
	{
	}

	private void RandomCreateChickenLeg(EntityBase enemy, int prob)
	{
	}

	private bool SendCreateBulletMsg(Vector3 pos)
	{
		return false;
	}

	private void SyncChickenLeg(EntityBase entity, Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void CreateChickenLeg(EntityBase triggerEntity, Vector3 pos, bool onlyShow)
	{
	}

	private void EatChickenLeg()
	{
	}

	private void InitAttribute(int eatCount)
	{
	}

	private void OnRotateBallHit(EntityBase target, EElementType type)
	{
	}

	private void OnRotateSwordHit(EntityBase target, EElementType type)
	{
	}

	private void RecycleChickenLeg(RoomGenerateBase.Room room)
	{
	}
}
