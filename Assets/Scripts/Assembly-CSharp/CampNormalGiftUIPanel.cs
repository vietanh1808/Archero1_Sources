using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampNormalGiftUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampNormalGiftUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__35(int _003C_003E1__state)
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
	private DxxText dailyTab;

	[SerializeField]
	private DxxText battleTab;

	[SerializeField]
	private DxxText teamTab;

	[SerializeField]
	private DxxText unActiveDailyTab;

	[SerializeField]
	private DxxText unActiveBattleTab;

	[SerializeField]
	private DxxText unActiveTeamTab;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private Transform giftParent;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private CampNormalGiftItem giftItem;

	[SerializeField]
	private ScrollRect scrollRect;

	public StarDiamondItem starItem;

	private LocalUnityObjctPool pool;

	private CampNormalGiftData data;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private CampGiftType curSelectType;

	private long dayLeftTime;

	private static DelegateBridge __Hotfix0_get_CampGiftManager;

	private static DelegateBridge __Hotfix0_get_GiftData;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshContent;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_GetDefaultOpenTab;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge __Hotfix0_GetDayLeftTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampGiftManager CampGiftManager => null;

	private CampNormalGiftData GiftData => null;

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

	public void ClickTab(int index)
	{
	}

	public void Refresh()
	{
	}

	public void RefreshContent()
	{
	}

	public void RefreshText()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshCountDown()
	{
	}

	public void RefreshTime()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__35))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public int GetDefaultOpenTab()
	{
		return 0;
	}

	private void Esc()
	{
	}

	private long GetDayLeftTime()
	{
		return 0L;
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
