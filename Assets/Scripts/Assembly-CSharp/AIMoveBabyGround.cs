using System.Collections.Generic;
using UnityEngine;

public class AIMoveBabyGround : AIMoveBase
{
	private EntityBase mParent;

	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private float findTime;

	private float findDelay;

	private bool bUpdateTime;

	private float updatetime;

	private float starttime;

	private float range;

	private float randomrange;

	private float movespeed;

	private int groundindex;

	public AIMoveBabyGround(EntityBase entity, int groundindex, float movespeed, float range)
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
