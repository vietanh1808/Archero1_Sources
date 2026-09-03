using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using XLua;

public class CampRankUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public class RankEnterData
	{
		public int type;

		public int tab;

		public CampTileResourceData holyData;

		public RankEnterData(int type, int tab, CampTileResourceData holyData = null)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CshowBottomList_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CampRankUIPanel _003C_003E4__this;

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
		public _003CshowBottomList_003Ed__38(int _003C_003E1__state)
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

	public RectTransform Window;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Info;

	public GameObject TabObj1;

	public DxxText[] Tab_BottomText;

	public GameObject[] Tab_BottomFocus;

	public DxxText[] Tab_TopText;

	public GameObject[] Tab_TopFocus;

	public CampRankCharItem[] charItem;

	private int currentTab;

	private int currentTabSub;

	public CampRankItemCell cellItemMe;

	public DxxText Text_Time;

	public GameObject PopReward;

	public RectTransform PopContainer;

	public GameObject cpProp;

	public GameObject go_TopTabs;

	public GameObject go_BottomTabs;

	public DxxText txt_None;

	[SerializeField]
	private DxxText playerRegion;

	private CampTileResourceData holyData;

	public UITableView tableView;

	public List<CampRankItemData> dataListTemp;

	public CampRankItemCell cellItem;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onButtonTabTop;

	private static DelegateBridge __Hotfix0_showTabTop;

	private static DelegateBridge __Hotfix0_onButtonTabBottom;

	private static DelegateBridge __Hotfix0_showTabBottom;

	private static DelegateBridge __Hotfix0_showPopReward;

	private static DelegateBridge __Hotfix0_onButtonClickPopReward;

	private static DelegateBridge __Hotfix0_onButtonInfo;

	private static DelegateBridge __Hotfix0_showRankList;

	private static DelegateBridge __Hotfix0_showBottomList;

	private static DelegateBridge __Hotfix0_freshTime;

	private static DelegateBridge __Hotfix0_initTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableView;

	private static DelegateBridge __Hotfix0_NumberOfCellsInTableView;

	private static DelegateBridge __Hotfix0_ScalarForCellInTableView;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewWillAppear;

	private static DelegateBridge __Hotfix0_CellAtIndexInTableViewDidDisappear;

	private static DelegateBridge __Hotfix0_ScalarForUpperMarginInTableView;

	private static DelegateBridge __Hotfix0_ScalarForLowerMarginInTableView;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	public void onButtonTabTop(int tab)
	{
	}

	private void showTabTop(int tab)
	{
	}

	public void onButtonTabBottom(int tab)
	{
	}

	private void showTabBottom(int tab)
	{
	}

	public void showPopReward(CampRankRewardPos crrp)
	{
	}

	public void onButtonClickPopReward()
	{
	}

	private void onButtonInfo()
	{
	}

	public void showRankList()
	{
	}

	[IteratorStateMachine(typeof(_003CshowBottomList_003Ed__38))]
	private IEnumerator showBottomList()
	{
		return null;
	}

	private void freshTime()
	{
	}

	public void initTableView()
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

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private object _003C_003ExLuaBaseProxy_OnGetEvent(string P0)
	{
		return null;
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
