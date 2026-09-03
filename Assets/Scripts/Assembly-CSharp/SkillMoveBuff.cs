using System;

public class SkillMoveBuff : SkillRefineBase
{
	public string TimerName;

	public int TimeInterval;

	public int BuffId;

	private int timerId;

	public Action UpdateCallback;

	public Action MoveStartCallback;

	public Action MoveEndCallback;

	public SkillMoveBuff(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	public void InitMoving(string timerName, int timeInterval, int buffId)
	{
	}

	public void InitMoveStartEnd(Action start, Action end)
	{
	}

	private void onMove(bool isMoving)
	{
	}

	private void onUpdate()
	{
	}
}
