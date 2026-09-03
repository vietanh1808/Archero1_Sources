using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class FishingShopUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingShopUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__42(int _003C_003E1__state)
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
	private ToggleGroup toggleGroup;

	[SerializeField]
	private Transform fishingShopParent;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private FishingShopItem fishingShopItem;

	[SerializeField]
	private FishingShopCurrencyItem currencyItem;

	[SerializeField]
	private Transform currencyParent;

	[SerializeField]
	private DxxText scoreSelectName;

	[SerializeField]
	private DxxText scoreUnselectName;

	[SerializeField]
	private DxxText fishKingSelectName;

	[SerializeField]
	private DxxText fishKingUnSelectName;

	[SerializeField]
	private RedNodeCtrl shopARed;

	[SerializeField]
	private RedNodeCtrl shopBRed;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private ScrollRect scrollRect;

	private List<FishingShopItem> shopItemList;

	private int curSelectIndex;

	private LocalUnityObjctPool pool;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private long dayLeftTime;

	private static DelegateBridge __Hotfix0_get_FishingManager;

	private static DelegateBridge __Hotfix0_get_FishingData;

	private static DelegateBridge __Hotfix0_get_FishingShopData;

	private static DelegateBridge __Hotfix0_InitObjectPool;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshItem;

	private static DelegateBridge __Hotfix0_RefreshRed;

	private static DelegateBridge __Hotfix0_RefreshCurrency;

	private static DelegateBridge __Hotfix0_RefreshSameDay;

	private static DelegateBridge __Hotfix0_JumpDay;

	private static DelegateBridge __Hotfix0_IsSameDay;

	private static DelegateBridge __Hotfix0_RefreshCountDown;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_ClickClose;

	private static DelegateBridge __Hotfix0_Esc;

	private static DelegateBridge _c__Hotfix0_ctor;

	private FishingManager FishingManager => null;

	private FishingData FishingData => null;

	private FishingShopData FishingShopData => null;

	private void InitObjectPool()
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

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshRed()
	{
	}

	private void RefreshCurrency()
	{
	}

	private void RefreshSameDay()
	{
	}

	private void JumpDay()
	{
	}

	private bool IsSameDay()
	{
		return false;
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__42))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void ClickClose()
	{
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
