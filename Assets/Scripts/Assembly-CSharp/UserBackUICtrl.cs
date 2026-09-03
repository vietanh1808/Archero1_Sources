using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;

public class UserBackUICtrl : MediatorCtrlBase
{
	private enum PageState
	{
		DailyCheckIn = 0,
		GiftPack = 1,
		ActivityPackage = 2
	}

	[CompilerGenerated]
	private sealed class _003CUpdateCountdown_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UserBackUICtrl _003C_003E4__this;

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
		public _003CUpdateCountdown_003Ed__27(int _003C_003E1__state)
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
	private RectTransform window;

	[SerializeField]
	private DxxText txtWelcome;

	[SerializeField]
	private DxxText txtTabTitle;

	[SerializeField]
	private DxxText txtRemainingTime;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl[] btns;

	[SerializeField]
	private DxxText[] txtBtns;

	[SerializeField]
	private UserBackPageBase[] pageBases;

	[SerializeField]
	private BattlePassOtherNewUICtrl battlePassCtrl;

	[SerializeField]
	private GameObject go_BottomLine;

	[SerializeField]
	private RedNodeCtrl bpRedNodeCtrl;

	[SerializeField]
	private RedNodeCtrl checkInRedNodeCtrl;

	[SerializeField]
	private DxxText count;

	[SerializeField]
	private GameObject go_Diamond;

	private PageState curPageState;

	private UserBackPageBase curPage;

	private string tabTitleKey;

	private UserBackPageBase _pageDailyCheckIn => null;

	private UserBackPageBase _pageActivityPackage => null;

	private UserBackPageBase _pageGiftPack => null;

	protected override void OnInit()
	{
	}

	private void OnBtnClose()
	{
	}

	protected override void OnOpen()
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateCountdown_003Ed__27))]
	private IEnumerator UpdateCountdown()
	{
		return null;
	}

	private void UpdateUI()
	{
	}

	private void RefreshRedNode()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void SwitchState(PageState state, bool force = false)
	{
	}

	private void RefreshDiamond()
	{
	}

	private void DOAnim(int index)
	{
	}
}
