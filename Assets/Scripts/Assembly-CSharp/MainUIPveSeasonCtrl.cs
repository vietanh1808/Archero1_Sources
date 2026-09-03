using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MainUIPveSeasonCtrl : MonoBehaviour
{
	public class ShowCharEvent
	{
	}

	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MainUIPveSeasonCtrl _003C_003E4__this;

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
	private GameObject m_timeContainer;

	[SerializeField]
	private DxxText m_textCd;

	[SerializeField]
	private ButtonCtrl m_btnPveSeason;

	[SerializeField]
	private GameObject mEffect;

	[SerializeField]
	private DxxText m_textSeason;

	[SerializeField]
	private ControlPveAndCampTextS control;

	private Coroutine m_Coroutine;

	private long m_lCdTime;

	private string m_strLanKey;

	private WaitForSeconds wait;

	public void Init()
	{
	}

	public void UpdateUI()
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChanged()
	{
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__15))]
	private IEnumerator Countdown()
	{
		return null;
	}

	private void OnPVEBtnClick()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnShowTabEvent(object pObj)
	{
	}
}
