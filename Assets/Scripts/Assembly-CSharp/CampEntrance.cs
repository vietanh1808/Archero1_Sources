using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Addressable;
using UnityEngine;
using UnityEngine.UI;

public class CampEntrance : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampEntrance _003C_003E4__this;

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
		public _003CCountdown_003Ed__20(int _003C_003E1__state)
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

	public GameObject effect;

	public GameObject effect_Battle;

	public GameObject effect_Battle2;

	private bool canclick;

	public GameObject TimeBG;

	public DxxText Text_Time;

	public Image img_Entrance;

	public ControlPveAndCampTextS control;

	public DxxText Text_Tag;

	private long showTime;

	private int m_nResDownloadState;

	private Coroutine m_Coroutine;

	private WaitForSeconds wait;

	public void Init()
	{
	}

	private void OnClickBtn()
	{
	}

	private void ShowDownloadWindow(FunctionalModule module, Sprite icon, long cd, Func<FunctionalModule, float> process, Action endCb = null)
	{
	}

	private void Show(bool value)
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__20))]
	private IEnumerator Countdown()
	{
		return null;
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
}
