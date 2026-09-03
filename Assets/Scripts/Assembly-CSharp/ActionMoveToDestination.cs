using UnityEngine;

public class ActionMoveToDestination : AIMoveBase
{
	public enum MeadowBattleMoveType
	{
		Straight = 1,
		LeftDiagonal = 2,
		RightDiagonal = 3,
		Static = 4,
		LeftHorizontal = 5,
		RightHorizontal = 6,
		Left_L_Shape = 7,
		Right_L_Shape = 8
	}

	public MeadowBattleMoveType MoveType;

	protected AIMeadowBattleBase aiBase;

	protected float biasFactor;

	private float initAngleY;

	private float deltaAngleY;

	protected float currentAngleY;

	protected float leftAngleY;

	protected float rightAngleY;

	protected bool isLeftRotating;

	private const float ANGLE_SPEED = 1f;

	private const float LEFT_ANGLE = -75f;

	private const float FRONT_ANGLE = 90f;

	private const float REVERSE_ANGLE = 180f;

	private float initLeftAngleY;

	private float initRightAngleY;

	private float angleSpeedFactor;

	private bool canMove => false;

	protected Vector3 MoveVelocity => default;

	protected Vector3 AttackMoveVelocity => default;

	public Vector3 MoveDir => default;

	private AIBase selfAI => null;

	protected bool IsInLeftPart => false;

	public virtual bool IsDefaultBossWay => false;

	public ActionMoveToDestination(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd1()
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void checkIfForceEnd()
	{
	}

	public virtual void MoveForward()
	{
	}

	public void DebugUpdateAnchorGrid()
	{
	}

	protected void rotateByDir(Vector3 dir)
	{
	}

	protected bool isLShape()
	{
		return false;
	}

	protected bool isSelfTeam()
	{
		return false;
	}

	protected bool canStop(Collider collider)
	{
		return false;
	}

	public void enableSearch(bool enabled)
	{
	}

	protected override void OnDeInit()
	{
	}

	private void initForBoss()
	{
	}

	private void resetAngleSpeedFactor()
	{
	}

	protected void refineLeftOrRightAngleY()
	{
	}

	protected void RunForBoss()
	{
	}

	protected void LShapeHandler(RaycastHit hitInfo)
	{
	}

	protected virtual void TurnOrEvolve(RaycastHit hitInfo)
	{
	}

	protected float normalizeAngleY(float angleY)
	{
		return 0f;
	}

	private EntityBase checkIfHaveEnemies()
	{
		return null;
	}

	private void init()
	{
	}

	private void OnCollideWithObstacles(Collision o)
	{
	}
}
