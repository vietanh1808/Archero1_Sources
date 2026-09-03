using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1715 : SkillAloneBase
{
	public const int PART_ID = 1890;

	private const int configId = 3285;

	private float minSkillRadius;

	private float maxSkillRadius;

	private float SkillRadius;

	private float SkillDuration;

	private float offsetPercent;

	private float rotateAngle;

	private int SkillCount;

	private float stickHeight;

	private const int skillBulletId = 8907;

	private float stickBulletRate;

	private float stickBulletRateAdd;

	private float stickBulletInterval;

	private float stickBulletAttackPercent;

	private float stickBulletAttackRiseRate;

	private float stickThroughRatio;

	private int stickBuffId;

	private float maxDis;

	private int minCount;

	private int maxCount;

	private int stickRebounceCount;

	private int extraStickBulletCount;

	private float partRate;

	private int minPartCount;

	private int maxPartCount;

	private int minRadius;

	private int maxRadius;

	private float aliveTime;

	private string attrStr;

	private float extraBulletInterval;

	private float partInterval;

	private float partRate2;

	private int minPartCount2;

	private int maxPartCount2;

	private int minRadius2;

	private int maxRadius2;

	private float aliveTime2;

	private string attrStr2;

	private ConditionTime extraBulletIntervalCondition;

	private ConditionTime partIntervalCondition;

	private float lastStickTimestamp;

	private string updateName;

	private Vector3 oldPos;

	private Vector3 originalPos;

	private float curDistance;

	private float validDistance;

	private bool IsMoving;

	private bool isStar6Activated;

	public int StickBulletID => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void readConfig()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onBeforeBulletDestroyed(BulletBase bullet)
	{
	}

	private void createSkillStickBullet(Vector3 dir, float rotateAngle, Vector3 center, Vector3 enemyPos)
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void parseArgs1(string[] args)
	{
	}

	private void parseArgs2(string[] args)
	{
	}

	private void parseArgs3(string[] args)
	{
	}

	private void parseArgs4(string[] args)
	{
	}

	private void parseArgs5(string[] args)
	{
	}

	private void onRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void OnAttack()
	{
	}

	private void createStickBullet(EntityBase entity, Vector3 startDir, Vector3 startPos)
	{
	}

	private Vector3 GetStartPosByEntity(EntityBase entity)
	{
		return default;
	}

	private void syncStickBullet(EntityBase entity, Vector3 dir, Vector3 start)
	{
	}

	private void syncSkillStickBullet(EntityBase entity, Vector3 dir, float rotateAngle, Vector3 center, Vector3 enemyPos)
	{
	}

	private void onMove(bool isMoving)
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void CreateWuKongPartExternal(int count)
	{
	}

	private void onHit(EntityBase attackTarget, HitStruct hit, HittedData hitteddata)
	{
	}

	private void CaskStick(EntityBase source, Vector3 dir, Vector3 startPos)
	{
	}

	private void ChangeStickHitRiseRate(float rate)
	{
	}

	private void ChangeStickRateAdd(float rate)
	{
	}

	private void createExtraStickBullets()
	{
	}

	private void createWuKongPartWrapper(Vector3 center, int _minCount, int _maxCount, int _minRadius, int _maxRadius, float _aliveTime, List<string> attrs)
	{
	}
}
