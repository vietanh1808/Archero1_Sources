using System.Collections.Generic;
using UnityEngine;

public class Action5091ACESkill : ActionBasic.ActionBase
{
	private bool isElite;

	private int startCount;

	private float deltaTime;

	private List<Vector3> list;

	private int len;

	private int BULLET_ID;

	private List<SelfRunAttackAction> atkActionList;

	private AIBase.ActionSequence seq;

	private const float TotalRange = 120f;

	private float deltaAngle;

	private bool startFiring;

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnForceEnd()
	{
	}

	private void populateList(int factor)
	{
	}

	protected override void OnDeInit()
	{
	}
}
