using System;
using System.Collections.Generic;
using DG.Tweening;

public class ActionBasic
{
	public abstract class ActionBase
	{
		public string name;

		public EntityBase m_Entity;

		public Func<bool> CanJumpAction;

		public Func<bool> ConditionBase;

		public object ConditionBase1Data;

		public Func<object, bool> ConditionBase1;

		public Func<bool> ConditionUpdate;

		public Func<bool> ConditionContinue;

		private int mEndFrame;

		private bool mIsEnd;

		private bool isInit;

		protected string Tag => null;

		public bool IsEnd
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public bool IsInit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string ActionDesc => null;

		public void Init()
		{
		}

		protected abstract void OnInit();

		public void Update()
		{
		}

		protected virtual void OnUpdate()
		{
		}

		protected virtual void End()
		{
		}

		public void ForceEnd()
		{
		}

		protected abstract void OnForceEnd();

		public virtual void Reset()
		{
		}

		protected virtual void OnEnd()
		{
		}

		protected virtual void OnEnd1()
		{
		}

		protected void CheckIfPauseSeq(Sequence seq)
		{
		}

		public void DeInit()
		{
		}

		protected abstract void OnDeInit();
	}

	public class ActionUIBase : ActionBase
	{
		protected override void OnForceEnd()
		{
		}

		protected override void OnInit()
		{
		}

		protected override void OnDeInit()
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

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionWaitIgnoreTime : ActionBase
	{
		private float startTime;

		public float waitTime;

		protected override void OnInit()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionParallelCache : ActionParallel
	{
		private void resetChildActions()
		{
		}

		public override void OnAfterActionParallelEnd()
		{
		}
	}

	public class ActionParallelIf : ActionParallelCache
	{
		protected override void OnUpdate()
		{
		}
	}

	public class ActionParallel : ActionBase
	{
		public List<ActionBase> list;

		private int endCount;

		protected override void OnInit()
		{
		}

		public void Add(ActionBase a)
		{
		}

		public virtual void OnAfterActionParallelEnd()
		{
		}

		protected override void OnUpdate()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionShowMaskUI : ActionBase
	{
		public bool show;

		protected override void OnInit()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	public class ActionDelegate : ActionBase
	{
		public Action action;

		public Action<bool> actionbool;

		public bool resultbool;

		public Action<int> actionint;

		public int resultint;

		public Action<string> actionstring;

		public string resultstring;

		protected override void OnInit()
		{
		}

		protected override void OnForceEnd()
		{
		}

		protected override void OnDeInit()
		{
		}
	}

	protected List<ActionBase> actionList;

	protected int actionCount;

	protected int actionIndex;

	private bool mIgnoreTimeScale;

	public string Name;

	private ActionBase update_action;

	public List<ActionBase> ActionList => null;

	public void Init(bool IgnoreTimeScale = false)
	{
	}

	protected virtual void OnInit1()
	{
	}

	public virtual void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	public void AddAction(ActionBase action)
	{
	}

	public void AddActionWait(float waitTime)
	{
	}

	public void AddActionIgnoreWait(float waitTime)
	{
	}

	public void AddActionDelegate(Action a)
	{
	}

	public void AddActionWaitDelegate(float waitTime, Action a)
	{
	}

	public void AddActionIgnoreWaitDelegate(float waitTime, Action a)
	{
	}

	public void ActionClear()
	{
	}

	public void ActionEndThenClear()
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
