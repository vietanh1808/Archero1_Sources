using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone1813 : SkillAloneBase
{
	private const int MAX_FLAGS = 4;

	private const float StickHeight = 6f;

	private const int COMMON_PART_ID = 1801;

	private float superWuKongCDTime;

	private int superWuKongBuffId;

	private int wuKongStickBuffId;

	private int minStickCount;

	private int maxStickCount;

	private float dropRate;

	private float enemyRadius;

	private float factor1;

	private float factor2;

	private float dropCDTime;

	private float hitCDTime;

	private WeightRandom stickRandom;

	private int curLightedFlags;

	private ConditionTime superWuKongCD;

	private List<GameObject> flagObjs;

	private List<GameObject> flagObjs2;

	private bool isSuperWuKong;

	private ConditionTime dropCD;

	private ConditionTime hitCD;

	private const int FLAG_COUNT = 4;

	private const string PLUS = "+";

	private const string MINUS = "-";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onCancelSphereFlash()
	{
	}

	private void parseSuperWuKongArgs(string[] args)
	{
	}

	private void parseStickWeightArgs(string[] args)
	{
	}

	private void parseStickArgs(string[] args)
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onCreatePartBody(EntityPartBodyBase part)
	{
	}

	private void onChangeHp(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void onAttack()
	{
	}

	private void onSuperWuKongStart()
	{
	}

	private void onSuperWukongEnd()
	{
	}

	private void onCreateSkillStickBullet(BulletBase bullet)
	{
	}

	private void onCreateStickBullet(BulletBase bullet)
	{
	}

	private void addBulletDebuff(BulletBase bullet)
	{
	}

	private void enterSuperWuKong()
	{
	}

	private void tryFallStickBullets()
	{
	}

	private void createFallBullet(Vector3 bulletPos)
	{
	}

	private void syncFallBullet(Vector3 bulletPos)
	{
	}

	private void initFlagObjs()
	{
	}

	private void clearFlagObjs()
	{
	}

	private void updateFlagObjs()
	{
	}

	private void initCurLightedFlags()
	{
	}

	private bool reachMaxFlags()
	{
		return false;
	}

	private void increaseCurLightedFlags()
	{
	}

	private void resetCurLightedFlags()
	{
	}

	private void onCreateWuKongPart(EntityPartBodyBase part)
	{
	}

	private void updatePartAttr(EntityPartBodyBase part)
	{
	}

	private float getDeltaValue(int flags)
	{
		return 0f;
	}

	private void tryUpdatePartsAttr()
	{
	}

	private void syncLightedFlags()
	{
	}

	private void syncSuperWuKongState()
	{
	}
}
