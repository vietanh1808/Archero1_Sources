using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingRankPersonalUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingRankPersonalUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__45(int _003C_003E1__state)
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
	private DxxText areaName;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl closeBgBtn;

	[SerializeField]
	private SailingRankPersonalItem item;

	[SerializeField]
	private SailingRankPersonalItem selfItem;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private DxxText noneText;

	[SerializeField]
	private ButtonCtrl rewardBtn;

	[SerializeField]
	private GameObject TabSeaMonster;

	[SerializeField]
	private GameObject TabActivity;

	[SerializeField]
	private DxxText TabText1;

	[SerializeField]
	private DxxText TabText2;

	[SerializeField]
	private DxxText TabText3;

	[SerializeField]
	private DxxText TabText4;

	[SerializeField]
	private DxxText RewardText;

	public GameObject[] Tab_BottomFocus;

	public List<SailRankCharItem> TopThreeList;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private int curSelectIndex;

	private SailingRankingData rankingData;

	private SailingRankingItemData self;

	private List<SailingRankingItemData> ranksData;

	private RankType curType;

	private int currentTabSub;

	private long endTime;

	private long endShowTime;

	private void InitTableView()
	{
	}

	private void SetRank()
	{
	}

	private void SetSelfData()
	{
	}

	public void OnButtonTabTop(int tab)
	{
	}

	private void InitActivityTabName()
	{
	}

	public void showTabBottom(int tab)
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

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__45))]
	private IEnumerator CountDown()
	{
		return null;
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

	private void OnClickReward()
	{
	}

	private void ClickInfo()
	{
	}

	private void Esc()
	{
	}

	public void onButtonTouchScreen()
	{
	}
}
