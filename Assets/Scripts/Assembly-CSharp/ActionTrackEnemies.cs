using System;
using System.Collections.Generic;

public class ActionTrackEnemies
{
	private Dictionary<EntityBase, int> m_dicEnemies;

	public Func<EntityBase, HitStruct, float> OnEnemyHittedCallback;

	public Dictionary<EntityBase, int> EnemiesDict => null;

	public ActionTrackEnemies(Func<EntityBase, HitStruct, float> callback)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void UpdateEnemies(List<EntityBase> enemies)
	{
	}

	private void UpdateEnemy(EntityBase enemy)
	{
	}

	private float OnEnemyHitted(EntityBase t1, HitStruct t2)
	{
		return 0f;
	}

	private void OnRemoveEnemy(EntityBase enemy)
	{
	}
}
