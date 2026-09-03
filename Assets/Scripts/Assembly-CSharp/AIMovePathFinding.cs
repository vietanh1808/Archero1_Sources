using System;
using System.Collections.Generic;
using UnityEngine;

public class AIMovePathFinding : AIMoveBase
{
	public float TwistFactor;

	private float BaseSpeed;

	private float deltaPercent;

	protected List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	protected Vector3? targetPos;

	private bool changeAnimSpeed;

	public Func<Vector3?> GetTargetPos;

	protected float currentTime;

	private const float MAX_TIME = 6f;

	public float SpeedTimes { get; set; }

	protected virtual float AnimSpeedTimes => 0f;

	public AIMovePathFinding(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void updateAnimSpeed()
	{
	}

	public virtual bool StopRunningOnInit()
	{
		return false;
	}

	protected virtual bool canInterrupt()
	{
		return false;
	}

	protected virtual bool isHitted()
	{
		return false;
	}

	protected virtual void onHitted()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void PathFinding()
	{
	}

	protected virtual void AIMoveStart()
	{
	}

	protected void findNewPath()
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

	private void onFindPathChanged()
	{
	}
}
