using System;
using UnityEngine;

public class AIMove1040 : AIJumpMoveBase
{
	public Action onDown;

	private const float Height = 6f;

	private EntityBase target;

	private Vector3 startpos;

	private Vector3 endpos;

	private int range;

	private float jumptime;

	private float alltime;

	private float starttime;

	private float percent;

	private AnimationCurve curve;

	private bool bJumpEnd;

	public AIMove1040(EntityBase entity, int range)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void Attack()
	{
	}

	protected override void OnEnd()
	{
	}
}
