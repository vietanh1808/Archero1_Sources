using UnityEngine;

public class AIMove1009 : AIMoveBase
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

	public AIMove1009(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected virtual void SetHatred()
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

	private void Move2Player()
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
}
