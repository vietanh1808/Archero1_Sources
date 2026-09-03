using UnityEngine;

public class Action3207CircleMov : ActionBasic.ActionBase
{
	private const float deltaAngle = 8f;

	private const float radius = 4f;

	private const float maxCumulatedAngle = 1440f;

	public Vector3 CenterPos;

	private Vector3 startDir;

	private float deltaRadius;

	private float curRadius;

	private bool isArrived;

	private float curAngle;

	private float movTime;

	private bool isHitWall;

	private float oldTime;

	private ConditionTime deltaCondition;

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	private void onHitWall()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnDeInit()
	{
	}
}
