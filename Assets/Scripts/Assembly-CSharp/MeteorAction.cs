using System;
using System.Collections.Generic;
using UnityEngine;

public class MeteorAction
{
	private class MeteorVO
	{
		public Dictionary<EntityBase, int> fallDict;

		public bool IsEnemyAvailable(EntityBase enemy, int maxCount)
		{
			return false;
		}

		public void AddEnemy(EntityBase entity)
		{
		}

		public void Clear()
		{
		}
	}

	private const int BULLET_ID = 3028;

	public string TAG;

	public EntityBase m_Entity;

	public int MeteorCount;

	public int MaxMeteorsPerEnemy;

	public float MinMeteorRadius;

	public float MaxMeteorRadius;

	public float AtkPercent;

	public Action<MeteorAction> OnFinished;

	private MeteorVO meteorVO;

	private ActionBasic fallAction;

	public bool IsFinished { get; set; }

	public void Init()
	{
	}

	public void Deinit()
	{
	}

	public void TryCreateMeteor()
	{
	}

	private EntityBase getAvailableEnemy(List<EntityBase> enemies, MeteorVO meteorVO)
	{
		return null;
	}

	public Vector3 getBulletTargetPos(EntityBase enemy, float minRadius, float maxRadius)
	{
		return default;
	}

	public Vector3 getBulletStartPos(Vector3 targetPos)
	{
		return default;
	}
}
