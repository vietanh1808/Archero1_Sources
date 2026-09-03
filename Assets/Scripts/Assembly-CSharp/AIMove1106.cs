using System;
using System.Collections.Generic;
using DG.Tweening;
using Dxx.Util;
using UnityEngine;

public class AIMove1106 : AIMoveBase
{
	private const int RADIUS_GRIDS = 4;

	private float twistFactor;

	private const float BASE_SPEED = 2.3f;

	private float deltaPercent;

	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private Vector3 targetPos;

	protected EntityBase mParent;

	private EntityBabyBase mBaby;

	public Func<bool> CanSearchEnemyCallback;

	private bool canSearchEnemy;

	private bool changeAnimSpeed;

	private GameObject effect;

	private SequencePool mPool;

	private Sequence seq;

	private Sequence seq1;

	private bool isPlayCalling;

	private float currentTime;

	private const float MAX_TIME = 6f;

	public float Speed { get; set; }

	public AIMove1106(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual List<Vector2Int> getTargetPosList()
	{
		return null;
	}

	protected virtual Vector3 getTargetPos()
	{
		return default;
	}

	private Vector2Int getLeftTargetColRow()
	{
		return default;
	}

	private Vector2Int getRightTargetColRow()
	{
		return default;
	}

	protected override void OnUpdate()
	{
	}

	protected bool checkIfHaveTargetEnemy()
	{
		return false;
	}

	private void PathFinding()
	{
	}

	private void AIMoveStart()
	{
	}

	private void findNewPath()
	{
	}

	private void checkPathCount()
	{
	}

	private void checkIfPathFinished()
	{
	}

	private void UpdateMovingData()
	{
	}

	private void AIMoving()
	{
	}

	protected override void OnEnd()
	{
	}

	private void logs()
	{
	}

	protected virtual void update_baby_parent()
	{
	}

	protected bool isFarEnough()
	{
		return false;
	}

	protected virtual bool CheckMove()
	{
		return false;
	}
}
