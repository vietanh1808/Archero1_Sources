using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1549 : SkillAloneBase
{
	private const int BULLET_ID = 1510;

	private const int PVP_BULLET_ID = 1511;

	private float delayTime;

	private int buffId;

	private int atkBuffId;

	private float atkCD;

	private float inheritAtkPercent;

	private float throughRatio;

	private float zeroRate;

	private WeightRandom random;

	private ActionBasic actionBasic;

	private ConditionTime atkTime;

	protected override void OnInstall()
	{
	}

	private bool hasAtkBuff()
	{
		return false;
	}

	protected override void OnUninstall()
	{
	}

	private void parseArg2(string str)
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void parseStarBulletParams(string rateStr)
	{
	}

	private void parseBuffStr(string buffStr)
	{
	}

	private void onHit(EntityBase arg1, HitStruct arg2, HittedData arg3)
	{
	}

	private void onAttack()
	{
	}

	private List<Vector3> getBulletPosList(EntityBase entity, int bulletCount)
	{
		return null;
	}

	private void createBullet(EntityBase entity, Vector3 bulletPos)
	{
	}

	private void createBulletInternal(EntityBase entity, Vector3 bulletPos, Quaternion bulletRotation)
	{
	}

	private void syncBulletInternal(EntityBase entity, Vector3 bulletPos, Quaternion bulletRotation)
	{
	}
}
