using UnityEngine;

public class Bullet5270 : Bullet3DShadowBase
{
	private enum MoveState
	{
		none = 0,
		line = 1,
		bezier = 2
	}

	private const float SQUARED_TARGET_RADIUS = 0.01f;

	private const float FULL_PERCENT = 1f;

	private const float FULL_PERCENT_ELITE = 0.97f;

	private const float DELAY_SURVIVE_TIME = 4f;

	private float fullPercent;

	private MoveState curMoveState;

	private Vector3 moveDir;

	private Vector3 targetPos;

	private float speed;

	private BezierCurve bezierCurve;

	private float t;

	public float deltaT;

	private float originalYDegrees;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	public void PreparedForBezierMovement(Vector3[] points)
	{
	}

	public void SetTargetPos(Vector3 _targetPos)
	{
	}

	private void moveInLine()
	{
	}

	private void moveInBezier()
	{
	}

	private Vector3 ConstrainedForward(Transform focus)
	{
		return default;
	}
}
