using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1557 : SkillAloneBase
{
	private const int BULLET_ID = 7217;

	private float laserRate;

	private float atkPercent;

	private float laserInterval;

	private int maxLaserPerMonster;

	private int maxLaserPerBoss;

	private int maxLaserPerPlayer;

	private ConditionTime laserTime;

	private Dictionary<int, int> laserDict;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onRemoveEnemy(EntityBase entity)
	{
	}

	private void onAttack()
	{
	}

	private EntityBase getValidTarget()
	{
		return null;
	}

	private int getMaxCount(EntityType entityType)
	{
		return 0;
	}

	private void tryCreateBullet()
	{
	}

	private void createBulletInternal(Vector3 bulletPos, float rota)
	{
	}

	private void syncBullet(Vector3 bulletPos, float rota)
	{
	}

	private void parseMaxArgs(string str)
	{
	}
}
