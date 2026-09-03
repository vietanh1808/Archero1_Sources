using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SailingMainIcon : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingMainIcon _003C_003E4__this;

		private long _003ClBanEndTime_003E5__2;

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
		public _003CCountdown_003Ed__19(int _003C_003E1__state)
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

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	private bool canclick;

	public GameObject TimeBG;

	public DxxText Text_Time;

	public GameObject GuideArrow;

	public ControlPveAndCampTextS control;

	private Coroutine m_Coroutine;

	private WaitForSeconds wait;

	public void Init()
	{
	}

	private void onButtonIcon()
	{
	}

	private void Show(bool value)
	{
	}

	public void UpdateUI()
	{
	}

	public bool IsShow()
	{
		return false;
	}

	private void UpdateTime()
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChanged()
	{
	}

	private bool isShowRed()
	{
		return false;
	}

	public void ShipGoIn()
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__19))]
	private IEnumerator Countdown()
	{
		return null;
	}
}
