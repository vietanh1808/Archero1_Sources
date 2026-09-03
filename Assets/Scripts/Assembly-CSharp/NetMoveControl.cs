public class NetMoveControl : MoveControl
{
	protected float moveTotalTime_Y;

	protected float moveYLastTime;

	protected int curMoveIndex;

	protected bool isMoving;

	protected float nextNodeDistance;

	private MoveCommand command;

	protected override void OnInit()
	{
	}

	public override float GetMoveSpeed()
	{
		return 0f;
	}

	protected override void OnMoveSpeedUpdate()
	{
	}

	private void OnMoveFinish()
	{
	}

	public override bool GetMoving()
	{
		return false;
	}

	public override void UpdateProgress()
	{
	}

	public override void ResetRigidBody()
	{
	}

	public void Move(MoveCommand cmd)
	{
	}

	private bool CalNextNodeDisSpeed(MoveCommand cmd)
	{
		return false;
	}

	private void UpdateMoveCmd()
	{
	}

	public void StopMove()
	{
	}

	private void UpdateMove()
	{
	}

	private void MoveToNextPathPoint(float moveDistance)
	{
	}

	private void UpdateNextNode()
	{
	}

	public override void OnMoveStart(JoyData data)
	{
	}

	public override void OnMoving(JoyData data)
	{
	}

	private void SetMoveCommand(ref JoyData data, bool nmove)
	{
	}

	protected override void OnMoveEnd(JoyData data)
	{
	}

	public override void SetMoving(bool moving)
	{
	}

	protected override bool CanRegisterJoyTouch()
	{
		return false;
	}
}
