using UnityEngine;

public abstract class ActionMultiMoveBase : AIMoveBase
{
	private bool canMove;

	protected AIMeadowBattleBase aiBase;

	private int waitTime;

	private float stepDistance;

	private AIBase.ActionLoop loop;

	private float ARRIVE_DISTANCE;

	private float deltaPercent => 0f;

	protected virtual Vector3 MoveVelocity { get; set; }

	public ActionMultiMoveBase(EntityBase entity)
		: base(null)
	{
	}

	protected abstract bool checkIfForceEnd();

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void normalMove()
	{
	}

	private void initBezierCurve()
	{
	}

	private Vector3 getTargetPos()
	{
		return default;
	}

	protected bool IsArrived(Vector3 targetPos)
	{
		return false;
	}

	protected override void OnDeInit()
	{
	}
}
