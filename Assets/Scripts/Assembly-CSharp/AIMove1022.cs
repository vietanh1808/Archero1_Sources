using System.Collections.Generic;
using UnityEngine;

public class AIMove1022 : AIMoveBase
{
	protected EntityBase target;

	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private float findTime;

	private float findDelay;

	private Vector3 mDirection;

	private float addspeed;

	private float maxspeed;

	private float movetime;

	private bool bNear;

	private float neardelaytime;

	protected float NearPos;

	protected Vector3 dir;

	public AIMove1022(EntityBase entity, float nearpos)
		: base(null)
	{
	}

	protected virtual void FindTarget()
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void MoveNormal()
	{
	}

	protected virtual bool IsNear()
	{
		return false;
	}

	private void AIMoveStart()
	{
	}

	protected virtual void OnAfterAIMoveStart()
	{
	}

	private void UpdateMoveSpeed()
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

	protected void AIMoveEnd()
	{
	}

	protected override void OnEnd()
	{
	}
}
