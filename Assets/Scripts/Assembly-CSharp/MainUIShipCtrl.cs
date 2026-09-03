using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class MainUIShipCtrl : MainUIButtonBase
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIShipCtrl _003C_003E4__this;

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
		public _003CCountdown_003Ed__15(int _003C_003E1__state)
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
	private GameObject child;

	[SerializeField]
	private RedNodeCtrl mRedCtrl;

	[SerializeField]
	private ButtonCtrl Button_Ship;

	[SerializeField]
	private GameObject time;

	[SerializeField]
	private DxxText timeText;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Animator m_animator;

	public ActShipRelicsGiftBoxItem RelicsBoxIcon;

	private Coroutine m_Coroutine;

	private WaitForSeconds wait;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
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

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__15))]
	private IEnumerator Countdown()
	{
		return null;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public new void UpdateUI()
	{
	}

	protected override void OnClose()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override bool isRed()
	{
		return false;
	}
}
