using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2045 : SkillAloneBase
{
	private long clockindex;

	private int bulletId;

	private int swordCount;

	private int attackEnemyCount;

	private float swordIntervalTime;

	private float hitratio;

	private float decreaseRatio;

	private float minRatio;

	private List<Vector3> angleList;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void UpdateTicker()
	{
	}

	private void OnAttack()
	{
	}

	private float RandomUnique()
	{
		return 0f;
	}

	protected bool CheckTarget(EntityBase target)
	{
		return false;
	}

	public virtual BulletBase CreateFlySword(Vector3 startpos, float angle, EntityBase target)
	{
		return null;
	}
}
