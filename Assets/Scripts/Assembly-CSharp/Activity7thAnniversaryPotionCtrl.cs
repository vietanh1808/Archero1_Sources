using System;
using UnityEngine;

public class Activity7thAnniversaryPotionCtrl : MonoBehaviour
{
	private enum PotionState
	{
		Dropping = 0,
		LandingDelay = 1,
		Idle = 2,
		Absorbing = 3
	}

	private const float DropDuration = 0.45f;

	private const float DropHeight = 1.6f;

	private const float DropStartY = -0.3f;

	private const float LandingDelayDuration = 0.35f;

	private const float BounceHeight = 0.35f;

	private const float SquashDuration = 0.12f;

	private const float IdleFloatAmplitude = 0.12f;

	private const float IdleFloatSpeed = 3.5f;

	private const float IdleRotateSpeed = 120f;

	private const float AbsorbRiseDuration = 0.17f;

	private const float AbsorbDelayDuration = 0.3f;

	private const float AbsorbMoveAccelerate = 2.5f;

	private const float AbsorbMaxSpeed = 1f;

	private const float AbsorbFinishDistance = 0.7f;

	private EntityBase owner;

	private Activity7thAnniversaryDaily130RuleHelper.PotionRuleEntry entry;

	private Action<Activity7thAnniversaryPotionCtrl, Activity7thAnniversaryDaily130RuleHelper.PotionRuleEntry> onPicked;

	private Action<Activity7thAnniversaryPotionCtrl> onExpired;

	private float pickupDistance;

	private float startTime;

	private float stateStartTime;

	private float idleStartTime;

	private Vector3 dropStartPosition;

	private Vector3 dropEndPosition;

	private Vector3 idleBasePosition;

	private GameObject visual;

	private Transform effectNode;

	private Transform bottleNode;

	private Vector3 bottleIdleLocalPosition;

	private bool recycled;

	private PotionState state;

	public int AbilityId => 0;

	public void Init(EntityBase owner, Activity7thAnniversaryDaily130RuleHelper.PotionRuleEntry entry, float pickupDistance, Action<Activity7thAnniversaryPotionCtrl, Activity7thAnniversaryDaily130RuleHelper.PotionRuleEntry> onPicked, Action<Activity7thAnniversaryPotionCtrl> onExpired)
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

	private void EnterDropping()
	{
	}

	private void UpdateDropping()
	{
	}

	private void EnterLandingDelay()
	{
	}

	private void UpdateLandingDelay()
	{
	}

	private void EnterIdle()
	{
	}

	private void UpdateIdle()
	{
	}

	private void EnterAbsorbing()
	{
	}

	private void UpdateAbsorbing()
	{
	}

	private Vector3 BuildDropStartPosition()
	{
		return default;
	}

	private float GetStatePercent(float duration)
	{
		return 0f;
	}

	private static float EaseOutBack(float t)
	{
		return 0f;
	}

	private void UpdateVisualScale(float uniformScale)
	{
	}

	private void UpdateVisualSquash(float scaleXZ, float scaleY)
	{
	}

	private void UpdateVisualPresentation(float visualScale, float rotateDelta)
	{
	}

	private void SetEffectNodeVisible(bool visible)
	{
	}

	private void UpdateBottleIdleFloat(float offsetY)
	{
	}

	private void ResetBottleLocalPosition()
	{
	}
}
