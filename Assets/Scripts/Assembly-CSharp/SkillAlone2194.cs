using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2194 : SkillAloneBase
{
	private int CONFIG_FLYSWORD_BULLET_ID;

	protected int CONFIG_FLY_SWORD_MAX;

	private float CONFIG_FLY_SWORD_TIME;

	private float CONFIG_DECREASE_RATIO;

	private float CONFIG_MIN_RATIO;

	private float CONFIG_ANGULAR_VELOCITY;

	protected float CONFIG_RATE;

	private float CONFIG_FLY_SWORD_HIT_RATIO;

	protected List<BulletBase> _bullets;

	protected virtual EntityBase Target => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnHit(EntityBase entityBase, HitStruct hs, HittedData hd)
	{
	}

	protected void CreateFlySword()
	{
	}

	protected void DoCreateFlySword(Vector3 startPos, float angle, EntityBase target)
	{
	}

	protected virtual void SyncFlySword(Vector3 startPos, float angle, int uid)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}
}
