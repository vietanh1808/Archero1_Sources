using UnityEngine;

public class AIMove1009_TD : AIMoveBase
{
	public enum AIMoveState
	{
		Original = 0,
		Rotating = 1,
		Straight = 2
	}

	public const float MOVE_FACTOR = 40f;

	public AIMoveState currentMoveState;

	protected bool ChangeAnimSpeed;

	protected float starttime;

	protected float Move_NextDurationTime;

	protected float Move_BackTime;

	protected bool bBack;

	protected string runString;

	protected float runAniSpeed;

	protected float Move_NextX;

	protected float Move_NextY;

	private int curFrameCount;

	public float RadiusFactor;

	protected virtual float moveRatio => 0f;

	public AIMove1009_TD(EntityBase entity)
		: base(null)
	{
	}

	protected virtual bool CustomEnd()
	{
		return false;
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void SetHatred()
	{
	}

	protected void EndWrapper()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	protected void FaceTarget()
	{
	}

	private void MoveRotate()
	{
	}

	private void MoveStraight()
	{
	}

	private void AIMoveStart()
	{
	}

	private void AIMoving()
	{
	}

	private void AIMoveEnd()
	{
	}

	protected virtual void OnSprintUpdate()
	{
	}

	protected virtual void OnBackEvent()
	{
	}

	protected override void OnEnd()
	{
	}

	private bool CheckEnd()
	{
		return false;
	}

	private void CheckCollision()
	{
	}

	protected virtual void OnCollision(RaycastHit hitInfo)
	{
	}

	protected virtual void Move2Player()
	{
	}
}
