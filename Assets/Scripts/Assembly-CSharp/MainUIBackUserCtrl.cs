using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MainUIBackUserCtrl : MainUIButtonBase
{
	[CompilerGenerated]
	private sealed class _003CUpdateCountdown_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIBackUserCtrl _003C_003E4__this;

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
		public _003CUpdateCountdown_003Ed__13(int _003C_003E1__state)
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
	private ButtonCtrl button;

	[SerializeField]
	private DxxText txtCountdown;

	[SerializeField]
	private RedNodeCtrl redNodeCtrl;

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

	public override void OnLanguageChange()
	{
	}

	public new void UpdateUI()
	{
	}

	private void Awake()
	{
	}

	public override bool isRed()
	{
		return false;
	}

	private void OnBtnClick()
	{
	}

	public void OnOpen()
	{
	}

	public new void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCountdown_003Ed__13))]
	private IEnumerator UpdateCountdown()
	{
		return null;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
