using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class CampShopUIPanel : MonoBehaviour, ICampUILifeCycle, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampShopUIPanel _003C_003E4__this;

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
	private ToggleGroup toggleGroup;

	[SerializeField]
	private DxxText shopAName;

	[SerializeField]
	private DxxText shopBName;

	[SerializeField]
	private DxxText shopAUnselectName;

	[SerializeField]
	private DxxText shopBUnselectName;

	[SerializeField]
	private ButtonCtrl info;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private DxxText currencyCount;

	[SerializeField]
	private Image currencyIcon;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private CampShopItem shopItem;

	[SerializeField]
	private CampShopBuyTip buyTip;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private ButtonCtrl mask;

	private List<CampShopItemData> itemData;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private CurrencyType curSelectType;

	private static DelegateBridge __Hotfix0_get_CampShopManager;

	private static DelegateBridge __Hotfix0_get_CampShopData;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_ClickTab;

	private static DelegateBridge __Hotfix0_ClickInfo;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshData;

	private static DelegateBridge __Hotfix0_RefreshStatus;

	private static DelegateBridge __Hotfix0_RefreshTable;

	private static DelegateBridge __Hotfix0_InitTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsAtRowOrColumnInGrid;

	private static DelegateBridge __Hotfix0_AlignmentOfCellsAtRowOrColumnInGrid;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_RefreshTime;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampShopManager CampShopManager => null;

	private CampShopData CampShopData => null;

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	public void RefreshText()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void ClickTab(int index)
	{
	}

	private void ClickInfo()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshData()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshTable()
	{
	}

	public void InitTableView()
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return 0;
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__42))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public void RefreshTime()
	{
	}
}
