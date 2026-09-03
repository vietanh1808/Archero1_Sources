using UnityEngine;

public class AIMove1095 : AIMoveBase
{
	private const float INITIAL_SPEED = 10f;

	private const float MAX_SPEED = 25f;

	private Vector2 DELTA_VALUE;

	private const int MAX_HIT_COUNT = 3;

	private const float SQUARED_MAX_DISTANCE = 49f;

	private const float MAX_DISTANCE = 7f;

	private float maxDistance;

	private const float offsetAngle = 30f;

	private const float factor = 0.5f;

	private const float deceleratedSpeed = 1.5f;

	private const float decayPercent = 0.85f;

	private const float minSpeed = 0.1f;

	private bool isStart;

	private Vector3 moveDir;

	private float movementTime;

	private float currentSpeed;

	private bool hitWall;

	private int curHitCount;

	private float finalMoveDistance;

	private Vector3 lastPos;

	private bool isFinalMovement;

	private float originalSpeed;

	private int layerMask;

	private Ray ray;

	private Ray leftRay;

	private Ray rightRay;

	private float radius;

	private Vector3 CustomizedMoveDirection;

	public AIMove1095(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd1()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void ClampPositionToMap()
	{
	}

	private void onRayHitWallHandler(RaycastHit hitInfo, Vector3 curMoveDir)
	{
	}

	protected override void OnEnd()
	{
	}

	private void onHitWall()
	{
	}

	private void onHitObstacles(RaycastHit hitInfo)
	{
	}

	private void onFinalMovementFinished()
	{
	}

	private void setMoveDir()
	{
	}

	private void setJoyData(Vector3 _dir)
	{
	}
}
