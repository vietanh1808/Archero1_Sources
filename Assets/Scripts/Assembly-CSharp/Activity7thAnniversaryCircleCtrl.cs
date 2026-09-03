using System;
using System.Collections.Generic;
using UnityEngine;

public class Activity7thAnniversaryCircleCtrl : MonoBehaviour
{
	private const float DefaultRadius = 1.5f;

	private const float ArriveDistance = 0.1f;

	private const float RandomMoveRadius = 3f;

	private const int DebugCircleSegments = 64;

	private const float DebugCircleHeight = 0.08f;

	private readonly HashSet<int> insidePlayerGuids;

	private EntityBase owner;

	private Activity7thAnniversaryDaily130RuleHelper.CircleRuleEntry ruleEntry;

	private Action<Activity7thAnniversaryCircleCtrl> onRecycle;

	private GameObject visual;

	private float radius;

	private float waitStartTime;

	private Vector3 currentTargetPos;

	private bool hasTargetPos;

	private bool recycled;

	public int RuleId => 0;

	public void Init(EntityBase owner, Activity7thAnniversaryDaily130RuleHelper.CircleRuleEntry ruleEntry, Vector3 initPos, Action<Activity7thAnniversaryCircleCtrl> onRecycle, float radius)
	{
	}

	private void Update()
	{
	}

	public void Recycle()
	{
	}

	private void CreateVisual()
	{
	}

	private void UpdateMove()
	{
	}

	private void UpdatePlayerAction()
	{
	}

	private void ApplyPlayerSkill(EntityBase player)
	{
	}

	private void RemovePlayerSkill(EntityBase player)
	{
	}

	private void RemoveAllPlayerSkills()
	{
	}

	private void TryPickNextTarget()
	{
	}

	private Vector3 BuildRandomTargetPos()
	{
		return default;
	}

	private Vector3 BuildWorldPosFromGrid(Vector2Int gridPosition)
	{
		return default;
	}

	private void ClampSelfInsideMap()
	{
	}

	private Vector3 ClampPosInsideMap(Vector3 position)
	{
		return default;
	}

	private void DrawDebugRange()
	{
	}
}
