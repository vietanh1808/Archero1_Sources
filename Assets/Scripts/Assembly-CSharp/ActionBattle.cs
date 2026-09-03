using System;
using System.Collections.Generic;

public class ActionBattle
{
	public class ActionBase : ActionBasic.ActionUIBase
	{
		protected override void OnInit()
		{
		}
	}

	public class ActionWait : ActionBase
	{
		private float startTime;

		public float waitTime;

		public bool ignoreTime;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}
	}

	protected List<ActionBasic.ActionBase> actionList;

	protected int actionCount;

	protected int actionIndex;

	private EntityBase m_Entity;

	private ActionBasic.ActionBase update_action;

	public void Init(EntityBase entity)
	{
	}

	protected virtual void OnInits()
	{
	}

	public void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	public void AddAction(ActionBasic.ActionBase action)
	{
	}

	public void AddActionWait(float waitTime)
	{
	}

	public void AddActionDelegate(Action a)
	{
	}

	public void AddActionWaitDelegate(float waitTime, Action a)
	{
	}

	public void ActionClear()
	{
	}

	protected virtual void OnActionClear()
	{
	}

	public int GetActionCount()
	{
		return 0;
	}
}
