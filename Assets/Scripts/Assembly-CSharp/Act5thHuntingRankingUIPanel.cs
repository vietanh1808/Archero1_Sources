using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act5thHuntingRankingUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Act5thHuntingRankingUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__40(int _003C_003E1__state)
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
	private ButtonCtrl closeBtn;

	[SerializeField]
	private Act5thHuntingRankingItem item;

	[SerializeField]
	private Act5thHuntingRankingSeasonItem seasonItem;

	[SerializeField]
	private Act5thHuntingRankingItem selfItem;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private DxxText dailySelectName;

	[SerializeField]
	private DxxText dailyUnselectName;

	[SerializeField]
	private DxxText seasonSelectName;

	[SerializeField]
	private DxxText seasonUnselectName;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private GameObject rewardInfoObj;

	[SerializeField]
	private Image rewardIcon;

	[SerializeField]
	private Image rewardSubIcon;

	[SerializeField]
	private DxxText rewardIconName;

	[SerializeField]
	private RectTransform contentRect;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private int curSelectIndex;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingRankingData HuntingRankingData => null;

	private Act5thHuntingRankingRewardData HuntingRankingRewardData => null;

	private void InitTableView()
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

	public void ClickTab(int index)
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__40))]
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

	private void ClickInfo()
	{
	}

	private void Esc()
	{
	}
}
