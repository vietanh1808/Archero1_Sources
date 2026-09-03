using System;
using UnityEngine;

public class ActionPursueAndCircle : ActionBasic.ActionBase
{
	public Func<Vector3> GetTargetPos;

	private AIBase.ActionSequence seq;

	private Vector3 targetPos;

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	private void onHitWall()
	{
	}

	protected override void OnDeInit()
	{
	}
}
