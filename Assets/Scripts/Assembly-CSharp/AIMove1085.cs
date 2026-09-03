using System;
using UnityEngine;

public class AIMove1085 : AIJumpMoveBase
{
	protected EntityBase target;

	private AnimationCurve curve;

	private int range;

	private float playerrange;

	private Vector3 startpos;

	protected Vector3 endpos;

	private float alltime;

	private float height;

	private float currenttime;

	private float speed;

	public Action OnJumpEnd;

	public Action OnEliteJumpEnd;

	private bool isElite;

	public AIMove1085(EntityBase entity, int range, float playerrange, float speed = 7f)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	private void UpdateDirection()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void CreateBullet()
	{
	}

	protected override void OnEnd()
	{
	}
}
