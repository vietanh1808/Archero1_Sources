using System;

public class ActionInstantAttackWrapper : ActionSeqWrapper
{
	public string InstantPreAnim;

	public string InstantEndAnim;

	public string InstantFinalAnim;

	public Func<ActionBasic.ActionBase> GetInstantAction;

	public float InstantPreAnimSpeed;

	public float InstantEndAnimSpeed;

	public float NonPausePercent;

	public float PauseTime;

	private float instantPreAnimTime;

	private float instantEndAnimTime;

	private float instantFinalAnimTime;

	private bool changeAnimSpeed;

	private void initAnimTime()
	{
	}

	protected override void OnEnd()
	{
	}

	private void resetAnimSpeed()
	{
	}

	protected override void OnInit()
	{
	}

	private ActionBasic.ActionBase getInstantFinalAction()
	{
		return null;
	}

	private ActionBasic.ActionBase getPauseAction()
	{
		return null;
	}

	private ActionBasic.ActionBase getWaitAndRotateAction()
	{
		return null;
	}
}
