using System.Collections.Generic;
using UnityEngine;

public class AIMove1044 : AIMoveBase
{
	private EntityBase target;

	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private float starttime;

	private const float MOVEADD = 3f;

	private const float MOVEADD_TIME = 1f;

	private float mMoveAdd;

	private Vector2Int mMoveDir;

	private bool bSameLine;

	public AIMove1044(EntityBase entity)
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

	private void UpdateSprint(Vector2Int dir)
	{
	}

	private void Find()
	{
	}

	private void AIMoving()
	{
	}

	protected override void OnEnd()
	{
	}
}
