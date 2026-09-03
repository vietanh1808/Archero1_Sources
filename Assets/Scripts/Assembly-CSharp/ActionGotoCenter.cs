using UnityEngine;

public class ActionGotoCenter : ActionMultiMoveBase
{
	private Vector3 targetPos;

	private Vector3 moveDir;

	private float attackSpeed;

	private float sqrArriveRadius;

	protected override Vector3 MoveVelocity => default;

	private new bool IsArrived => false;

	public ActionGotoCenter(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override bool checkIfForceEnd()
	{
		return false;
	}
}
