using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class ActionWanderBetweenAttack : ActionMultiMoveBase
{
	public float IntervalTime;

	private EntityBase attackTarget;

	private ConditionTime conditionTime;

	private Vector3 moveDir;

	private Vector3 targetPos;

	private bool hasArrived;

	private float maxAttackDistance => 0f;

	private float minAttackDistance => 0f;

	protected override Vector3 MoveVelocity { get; set; }

	public ActionWanderBetweenAttack(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnForceEnd()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnInitBase()
	{
	}

	private List<Farm_BattleMonster> getFilteredList()
	{
		return null;
	}

	protected override void OnUpdate()
	{
	}

	protected override bool checkIfForceEnd()
	{
		return false;
	}

	protected override void OnDeInit()
	{
	}
}
