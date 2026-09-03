using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2192 : SkillAloneBase
{
	private int CONFIG_FLYSWORD_BULLET_ID;

	private float CONFIG_HIT_RAISE_PERCENT;

	private float CONFIG_HIT_RAISE_MAX;

	private float CONFIG_FLY_SWORD_TIME;

	private float CONFIG_DECREASE_RATIO;

	private float CONFIG_MIN_RATIO;

	private float CONFIG_ANGULAR_VELOCITY;

	private float CONFIG_FLY_SWORD_HIT_RATIO;

	private bool m_bTriggered;

	private int m_nFlySwordCnt;

	private Dictionary<BulletBase, float> m_dicTotalHitRaise;

	private EntityBase CanCreateFlySword => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnPositionBy(Vector3 pos)
	{
	}

	private void CreateFlySword(EntityBase target)
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void OnGameType5WaveEnd(int value)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}
}
