using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class AIMove1048 : AIMoveBase
{
	private EntityBase target;

	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private float startTime;

	private Sequence seq;

	private bool bStartMove;

	private float time;

	private float ratio;

	public AIMove1048(EntityBase entity, int time, float ratio)
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

	private void AIMoving()
	{
	}

	private void KillSequence()
	{
	}

	protected override void OnEnd()
	{
	}
}
