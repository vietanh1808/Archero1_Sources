using System;
using System.Collections.Generic;
using UnityEngine;

public class AIMove1105 : AIMoveBase
{
	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private float timerInterval;

	private float starttime;

	public Func<EntityBase, EntityBase> FindTarget;

	private float minSeconds;

	private float maxSeconds;

	private Vector3 targetPos;

	public AIMove1105(EntityBase entity, int min = 0, int max = 0)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual Vector3 getTargetPos()
	{
		return default;
	}

	protected override void OnUpdate()
	{
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
}
