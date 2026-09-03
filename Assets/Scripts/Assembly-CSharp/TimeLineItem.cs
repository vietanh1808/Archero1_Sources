using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimeLineItem
{
	[CompilerGenerated]
	private sealed class _003CRun_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeLineItem _003C_003E4__this;

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
		public _003CRun_003Ed__8(int _003C_003E1__state)
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

	public Action StartDo;

	public Func<IEnumerator> UnitlDo;

	public Action EndDo;

	public Func<bool> Condition;

	public bool isBreak;

	public bool isTryAgain;

	public bool isComplete;

	public MonoBehaviour Ctrl;

	[IteratorStateMachine(typeof(_003CRun_003Ed__8))]
	public IEnumerator Run()
	{
		return null;
	}

	public void End()
	{
	}

	public bool PassCondition()
	{
		return false;
	}
}
