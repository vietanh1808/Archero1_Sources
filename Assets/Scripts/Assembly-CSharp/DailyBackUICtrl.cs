using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class DailyBackUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DailyBackUICtrl _003C_003E4__this;

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
		public _003CCountDown_003Ed__26(int _003C_003E1__state)
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
	private DxxText title;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private ButtonCtrl tipBtn;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private Transform rewardParent;

	[SerializeField]
	private DailyBackRewardItem dailyBackRewardItem;

	[SerializeField]
	private Transform tabParent;

	[SerializeField]
	private DailyBackTabItem dailyBackTabItem;

	[SerializeField]
	private DailyBackTipInfoPanel dailyBackInfoPanel;

	[SerializeField]
	private DailyBackClickInfoPanel dailyBackClickInfoPanel;

	[SerializeField]
	private ToggleGroup toggleGroup;

	private List<DailyBackRewardItem> createRewardItemList;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private static DelegateBridge __Hotfix0_get_DailyBackManager;

	private static DelegateBridge __Hotfix0_get_DailyBackData;

	private static DelegateBridge __Hotfix0_get_DailyBackRewardData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_RefreshNewReward;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_GetDefaultTabIndex;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge _c__Hotfix0_ctor;

	private DailyBackManager DailyBackManager => null;

	private DailyBackData DailyBackData => null;

	private DailyBackRewardData DailyBackRewardData => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void RefreshNewReward()
	{
	}

	private void RefreshTime()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__26))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private int GetDefaultTabIndex()
	{
		return 0;
	}

	private void android_escape()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
