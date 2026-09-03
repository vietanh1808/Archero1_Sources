using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MainUIBallonAdCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIBallonAdCtrl _003C_003E4__this;

		public long time;

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
		public _003CCountdown_003Ed__7(int _003C_003E1__state)
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

	public ButtonCtrl BallonButton;

	public DxxText timeDownText;

	public Coroutine m_Coroutine;

	public BallonSeverData mData;

	private WaitForSeconds wait;

	private void Awake()
	{
	}

	public void Init(BallonSeverData data)
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__7))]
	private IEnumerator Countdown(long time)
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
