using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity.Anniversary;
using UnityEngine;

public class MainUIActivityYear : MainUIButtonBase
{
	public class ShowYearActivityEvent
	{
	}

	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIActivityYear _003C_003E4__this;

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
		public _003CCountDown_003Ed__31(int _003C_003E1__state)
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

	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Time;

	public GameObject effect;

	public GameObject effect2;

	[SerializeField]
	private GameObjectActivator activator;

	private bool isExecuting;

	private Coroutine m_Coroutine;

	public static bool waitAppLinkShow;

	public static ActivityYearUICtrl.OpenData dailyData;

	private DateTime lastDateTime;

	private WaitForSeconds m_wait;

	private bool AnniversaryOn => false;

	private bool CanShow => false;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnShowYearCall(object obj)
	{
	}

	private void OnClickBtn()
	{
	}

	private void ShowActivityUI()
	{
	}

	private void ShowActivityLayer()
	{
	}

	public void Open()
	{
	}

	private void Show(bool value)
	{
	}

	public new void UpdateUI()
	{
	}

	private void SetStyle()
	{
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override bool IsShow()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__31))]
	private IEnumerator CountDown()
	{
		return null;
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
