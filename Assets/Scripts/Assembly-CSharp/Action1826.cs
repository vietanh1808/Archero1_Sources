using System;

public class Action1826 : ActionBasic.ActionBase
{
	public Func<EntityBase> GetHatredTarget;

	private EntityBase m_HatredTarget;

	private AI1826 aiBase;

	private AIBase.ActionSequence seq;

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private bool canArrived()
	{
		return false;
	}

	private ActionBasic.ActionBase getActionPath1()
	{
		return null;
	}

	private ActionBasic.ActionBase getActionPath2()
	{
		return null;
	}

	private ActionBasic.ActionBase getAtkAction()
	{
		return null;
	}

	private ActionBasic.ActionBase getIdleAction()
	{
		return null;
	}
}
