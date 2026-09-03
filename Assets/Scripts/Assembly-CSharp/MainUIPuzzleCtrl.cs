using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MainUIPuzzleCtrl : MainUIButtonBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPuzzleCtrl _003C_003E4__this;

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
		public _003CCountDown_003Ed__15(int _003C_003E1__state)
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

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private RedNodeCtrl redCtrl;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private PuzzleManager PuzzleManager => null;

	private PuzzleData PuzzleData => null;

	private void Awake()
	{
	}

	public override bool IsShow()
	{
		return false;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	private void Refresh()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__15))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void RefreshTime()
	{
	}

	protected override void OnClose()
	{
	}

	private void RefreshRed()
	{
	}
}
