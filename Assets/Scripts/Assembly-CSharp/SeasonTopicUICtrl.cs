using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SeasonTopicUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SeasonTopicUICtrl _003C_003E4__this;

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
		public _003CCountDown_003Ed__19(int _003C_003E1__state)
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
	private DxxText mTextSeasonTitle;

	[SerializeField]
	private DxxText mTextWeekTitle;

	[SerializeField]
	private DxxText mTextCd;

	[SerializeField]
	private Image mImgSeasonTopic;

	[SerializeField]
	private Image mImgWeekTopic;

	[SerializeField]
	private DxxText mTextSeasonTopicContent;

	[SerializeField]
	private DxxText mTextWeekTopicContent;

	[SerializeField]
	private DxxText mText_Title;

	[SerializeField]
	private ButtonCtrl mBtnClose;

	private Coroutine m_Coroutine;

	private WaitForSeconds wait;

	private long CdTime => 0L;

	protected override void OnInit()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__19))]
	private IEnumerator CountDown()
	{
		return null;
	}
}
