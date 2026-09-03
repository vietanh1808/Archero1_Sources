using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class Exchange2023UIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CActivityCountDown_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Exchange2023UIPanel _003C_003E4__this;

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
		public _003CActivityCountDown_003Ed__46(int _003C_003E1__state)
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
	private ButtonCtrl close;

	[SerializeField]
	private Exchange2023Item item;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private Image needItemA;

	[SerializeField]
	private Image needItemB;

	[SerializeField]
	private DxxText needItemACount;

	[SerializeField]
	private DxxText needItemBCount;

	[SerializeField]
	private DxxText roundNameA;

	[SerializeField]
	private DxxText normalACountDown;

	[SerializeField]
	private DxxText normalExchangeCount;

	[SerializeField]
	private DxxText Text_RoundNameB;

	[SerializeField]
	private GameObject shopAStatus;

	[SerializeField]
	private GameObject shopBStatus;

	[SerializeField]
	private ButtonCtrl clickLeft;

	[SerializeField]
	private ButtonCtrl clickRight;

	[SerializeField]
	private DxxText selectTab1Name;

	[SerializeField]
	private DxxText unselectTab1Name;

	[SerializeField]
	private DxxText selectTab2Name;

	[SerializeField]
	private DxxText unselectTab2Name;

	[SerializeField]
	private ScrollRect scrollRect;

	private LocalUnityObjctPool pool;

	private Coroutine activityCountDown;

	private WaitForSeconds wait;

	private bool isSelectShopA;

	private int curSelectRound;

	private bool showFreshTips;

	private static DelegateBridge __Hotfix0_get_Christmas2023Manager;

	private static DelegateBridge __Hotfix0_get_Exchange2023Data;

	private static DelegateBridge __Hotfix0_InitPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_RefreshContent;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshCurrency;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_ActivityCountDown;

	private static DelegateBridge __Hotfix0_ClickLeft;

	private static DelegateBridge __Hotfix0_ClickRight;

	private static DelegateBridge __Hotfix0_RefreshGuideIndex;

	private static DelegateBridge __Hotfix0_CheckRefreshExchangeRound;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private Christmas2023Manager Christmas2023Manager => null;

	private Exchange2023Data Exchange2023Data => null;

	private void InitPool()
	{
	}

	protected override void OnInit()
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

	public void ClickTab(int index)
	{
	}

	private void RefreshContent(bool isShopA)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshCurrency()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshItem(bool isShopA)
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CActivityCountDown_003Ed__46))]
	private IEnumerator ActivityCountDown()
	{
		return null;
	}

	private void ClickLeft()
	{
	}

	private void ClickRight()
	{
	}

	private void RefreshGuideIndex()
	{
	}

	private bool CheckRefreshExchangeRound(bool tips)
	{
		return false;
	}

	private void Esc()
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
