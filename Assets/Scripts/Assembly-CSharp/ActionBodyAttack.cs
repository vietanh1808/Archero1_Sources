using UnityEngine;

public class ActionBodyAttack : ActionBasic.ActionBase
{
	private enum MoveState
	{
		normal = 0,
		wander = 1,
		stop = 2
	}

	private float curAttackTime;

	private float attackInterval;

	private bool isAttackStarted;

	private Vector3 attackDir;

	private Vector3 targetPos;

	private EntityBase attackTarget;

	private float offset;

	private float attackSpeed;

	private MoveState curMoveState;

	private ActionWanderBetweenAttack wander;

	private float ARRIVE_DISTANCE;

	private bool hasBodyHit;

	public string BodyAttackAnimName => null;

	public ActionBodyAttack(EntityBase entity)
	{
	}

	protected override void OnInit()
	{
	}

	private void playBodyAttackAnim()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnForceEnd()
	{
	}

	private void initForAttack()
	{
	}

	private void attacking()
	{
	}

	private Vector3 correctTargetPos(Vector3 dir, Vector3 targetPos)
	{
		return default;
	}

	protected virtual void AttackEnd()
	{
	}

	private void OnBodyHit(EntityBase entity)
	{
	}

	protected override void OnDeInit()
	{
	}
}
