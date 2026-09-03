using System;
using UnityEngine;

public class AIMoveToTargetPos : AIMoveBase
{
	public float MinTime;

	public float MaxTime;

	private float interval;

	private bool isStart;

	private float movementTime;

	private int curFrameCount;

	protected bool RotateInPlaceEnabled;

	public Func<Vector3> GetTargetPos;

	public Vector3 TargetPos;

	public Action OnEndCallback;

	public string ExternalLogTag;

	public float SpeedTimesFactor;

	public float SpeedTimes;

	public float TwistFactor;

	public float AnimSpeedTimesFactor;

	public float AnimSpeedTimes;

	public bool ForceRun;

	public bool IsTimeUpEnd;

	public bool IsArriveEnd;

	public bool IsRealTimeTargetPos;

	public float ArriveRadius;

	public bool IsHitToStatic;

	public float RadiusFactor;

	private float deltaPercent;

	private bool changeAnimSpeed;

	protected virtual string LogTag => null;

	protected virtual Vector3 moveDir => default;

	public AIMoveToTargetPos(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void onBeforeInit()
	{
	}

	protected virtual void onAfterInit()
	{
	}

	protected virtual void onCloseEnough()
	{
	}

	protected virtual bool isEntityInvalid()
	{
		return false;
	}

	protected virtual bool canUpdateDir()
	{
		return false;
	}

	protected virtual bool isCloseEnough()
	{
		return false;
	}

	protected virtual void updateDir()
	{
	}

	private void rotateToTarget()
	{
	}

	protected virtual bool checkIfTimeUp()
	{
		return false;
	}

	protected override void OnUpdate()
	{
	}

	protected virtual void OnAfterMoveDirectionAssigned()
	{
	}

	protected virtual void correctMoveDir()
	{
	}

	protected void StopMove()
	{
	}

	protected virtual void RotateInPlace()
	{
	}

	protected void Move()
	{
	}

	private void CheckCollision()
	{
	}

	protected virtual void OnCollision(RaycastHit hitInfo)
	{
	}

	protected override void OnEnd()
	{
	}

	protected void initAnimSpeed()
	{
	}

	private void reset()
	{
	}

	protected float getSpeedFactor()
	{
		return 0f;
	}

	protected float getAnimSpeedFactor()
	{
		return 0f;
	}

	protected void UpdateRotateSpeed(int deltaPercentage)
	{
	}
}
