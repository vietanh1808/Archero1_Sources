using System.Collections.Generic;
using UnityEngine;

public class AIMove1090 : AIMoveBase
{
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

	private float NearPos;

	private Vector3 dir;

	private bool bPlayAttack;

	private AIBase m_ai;

	protected EntityBase target
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public AIMove1090(EntityBase entity, float nearpos, AIBase ai = null)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual bool Check()
	{
		return false;
	}

	protected virtual void FindTarget()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	private bool IsNear()
	{
		return false;
	}

	private void AIMoveStart()
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
}
