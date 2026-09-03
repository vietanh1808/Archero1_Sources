using System;
using System.Collections.Generic;
using UnityEngine;

public class Action1550ThunderAtk
{
	private const string UPDATE_NAME = "Action1550ThunderAtk-Update";

	public EntityBase m_Entity;

	public string Tag;

	public float atkRadius;

	public float hitRatio;

	public float decreaseHitRatio;

	public float minHitRatio;

	public int maxAtkCount;

	public float atkInterval;

	public float ThunderBallAliveTime;

	public float thunderAtkPercent;

	public Action<Action1550ThunderAtk> OnThunderBallRemoved;

	private ConditionTime aliveTime;

	private ConditionTime atkTime;

	private Transform thunderBall;

	public Transform ThunderBall => null;

	public Action1550ThunderAtk(EntityBase entity, Action<Action1550ThunderAtk> onThunderBallRemoved)
	{
	}

	public void Init()
	{
	}

	public void DeInit(bool runCallback = true)
	{
	}

	private void onUpdate(float deltaTime)
	{
	}

	public void CreateThunderBallWrapper()
	{
	}

	public void RunThunderAtkWrapper()
	{
	}

	private void runThunderAtk(List<EntityBase> list)
	{
	}

	private float getThunderHit(List<EntityBase> list)
	{
		return 0f;
	}

	private Transform getThunderBallParent()
	{
		return null;
	}

	private Transform getThunderBall()
	{
		return null;
	}

	private Transform createThunderBall()
	{
		return null;
	}

	public void SyncThunderLinesWrapper(List<EntityBase> list)
	{
	}

	private void syncThunderLines(List<int> guids)
	{
	}
}
