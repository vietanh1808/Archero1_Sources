using System.Collections.Generic;
using UnityEngine;

public class AIMove1014 : AIMoveBase
{
	protected EntityBase target;

	protected List<Grid.NodeItem> findpath;

	protected Vector3 nextpos;

	protected float startTime;

	private float time;

	public AIMove1014(EntityBase entity, int time)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	protected virtual void AIMoveStart()
	{
	}

	protected void UpdateMoveData()
	{
	}

	protected virtual void OnUpdateMoveData()
	{
	}

	protected void UpdateDirection()
	{
	}

	protected virtual void UpdateFindPath()
	{
	}

	protected virtual void Find()
	{
	}

	protected void AIMoving()
	{
	}

	protected override void OnEnd()
	{
	}
}
