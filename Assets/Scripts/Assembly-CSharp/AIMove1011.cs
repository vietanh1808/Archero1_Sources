using System;
using System.Collections.Generic;
using UnityEngine;

public class AIMove1011 : AIMoveBase
{
	protected EntityBase target;

	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private float findTime;

	private float findDelay;

	protected bool bUpdateTime;

	private float updatetime;

	private float starttime;

	public Func<EntityBase, EntityBase> FindTarget;

	public AIMove1011(EntityBase entity, int min = 0, int max = 0)
		: base(null)
	{
	}

	public AIMove1011(EntityBase entity, Func<EntityBase, EntityBase> findTarget, int min = 0, int max = 0)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void CheckTarget()
	{
	}

	protected virtual bool CustomStop()
	{
		return false;
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	private void AIMoveStart()
	{
	}

	private void UpdateMoveData()
	{
	}

	private void UpdateDirection()
	{
	}

	private void UpdateFindPath()
	{
	}

	private void Find()
	{
	}

	private void AIMoving()
	{
	}

	private void AIMoveEnd()
	{
	}

	protected override void OnEnd()
	{
	}
}
