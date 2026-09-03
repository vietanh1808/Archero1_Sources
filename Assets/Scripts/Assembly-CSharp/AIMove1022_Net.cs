using System.Collections.Generic;
using UnityEngine;

public class AIMove1022_Net : AIMoveBase_Net
{
	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private float findTime;

	private float findDelay;

	private Vector3 mDirection;

	private bool bNear;

	private float neardelaytime;

	private float NearPos;

	private Vector3 dir;

	public AIMove1022_Net(EntityBase entity, float nearpos)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void OnMoveEvent(bool b)
	{
	}

	private bool IsNear()
	{
		return false;
	}

	private void FindAndMove()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}
}
