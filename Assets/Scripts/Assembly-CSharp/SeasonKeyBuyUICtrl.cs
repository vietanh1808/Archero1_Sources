using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SeasonKeyBuyUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SeasonKeyBuyUICtrl _003C_003E4__this;

		private LanguageManager _003Clanguage_003E5__2;

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
		public _003CCountDown_003Ed__21(int _003C_003E1__state)
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
	private DxxText mTextTitle;

	[SerializeField]
	private DxxText mTextContent;

	[SerializeField]
	private DxxText mTextRemainCnt;

	[SerializeField]
	private DxxText mTextCnt;

	[SerializeField]
	private DxxText mTextPrice;

	[SerializeField]
	private ButtonCtrl mBtnClose;

	[SerializeField]
	private ButtonCtrl mBtnBuy;

	private int m_nKeyCount;

	private WaitForSeconds m_wait;

	private Coroutine m_Coroutine;

	private long m_lTodayEndTime;

	private long m_lSeasonEndTime;

	private int Price => 0;

	protected override void OnInit()
	{
	}

	private void TgaTrack(string step, string result = "", string reason = "")
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateBtnState()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__21))]
	private IEnumerator CountDown()
	{
		return null;
	}
}
