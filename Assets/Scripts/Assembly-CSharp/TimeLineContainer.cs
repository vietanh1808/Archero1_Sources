using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimeLineContainer
{
	[CompilerGenerated]
	private sealed class _003CRunInternal_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeLineContainer _003C_003E4__this;

		private int _003Ci_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRunInternal_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private List<TimeLineItem> events;

	private MonoBehaviour m_Ctrl;

	private Func<bool> Condition;

	private Action OnStop;

	private Coroutine runCor;

	private Coroutine runCorEvent;

	private TimeLineItem curTimeLine;

	private int loopTimes;

	public int CurLoopTimes;

	public bool isLoop => false;

	public TimeLineContainer(MonoBehaviour ctrl)
	{
	}

	public TimeLineContainer Add(TimeLineItem timeLineItem)
	{
		return null;
	}

	public TimeLineContainer Clear()
	{
		return null;
	}

	public TimeLineContainer Run()
	{
		return null;
	}

	public TimeLineContainer SetLoop(int times = -1)
	{
		return null;
	}

	public TimeLineContainer StopLoop()
	{
		return null;
	}

	public TimeLineContainer SetCondition(Func<bool> _Condition)
	{
		return null;
	}

	public TimeLineContainer SetOnStop(Action _OnStop)
	{
		return null;
	}

	public TimeLineContainer Stop()
	{
		return null;
	}

	public TimeLineContainer StopWhileCurComplete()
	{
		return null;
	}

	private void StopInternal()
	{
	}

	[IteratorStateMachine(typeof(_003CRunInternal_003Ed__22))]
	private IEnumerator RunInternal()
	{
		return null;
	}
}
