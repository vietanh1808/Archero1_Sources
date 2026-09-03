using UnityEngine;

public class ActionMoveInAttack : ActionMultiMoveBase
{
	private EntityBase attackTarget;

	private float attackSpeed;

	public float AttackDistance;

	protected override Vector3 MoveVelocity => default;

	public ActionMoveInAttack(EntityBase entity)
		: base(null)
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
