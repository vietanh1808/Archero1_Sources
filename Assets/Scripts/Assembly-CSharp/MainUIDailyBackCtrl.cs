using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MainUIDailyBackCtrl : MainUIButtonBase
{
	[CompilerGenerated]
	private sealed class _003CRefreshCountDown_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIDailyBackCtrl _003C_003E4__this;

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
		public _003CRefreshCountDown_003Ed__18(int _003C_003E1__state)
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
	private RedNodeCtrl redCtrl;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private ButtonCtrl click;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private DailyBackManager DailyBackManager => null;

	private DailyBackData DailyBackData => null;

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

	public override bool isRed()
	{
		return false;
	}

	protected override void OnClose()
	{
	}

	private void CloseTimer()
	{
	}

	private void Refresh()
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshCountDown_003Ed__18))]
	private IEnumerator RefreshCountDown()
	{
		return null;
	}

	private void RefreshRed()
	{
	}

	private void RefreshTime()
	{
	}
}
