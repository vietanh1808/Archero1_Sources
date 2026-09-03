using System;
using UnityEngine;

public class AIMove1080 : AIJumpMoveBase
{
	private EntityBase target;

	private float startTime;

	private float delaytime;

	private float jumptime;

	private float endtime;

	private bool bjumpend;

	private AnimationCurve curve;

	private Vector3 startpos;

	private Vector3 endpos;

	private float height;

	private float skillspeed;

	private GameObject obj;

	private Action JumpEndAction;

	public AIMove1080(EntityBase entity, Action jumpEndAction)
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

	protected virtual GameObject GetEffect()
	{
		return null;
	}

	protected override void OnEnd()
	{
	}
}
