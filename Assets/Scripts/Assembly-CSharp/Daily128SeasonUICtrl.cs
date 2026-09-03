using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using TableTool;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Daily128SeasonUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Daily128SeasonUICtrl _003C_003E4__this;

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
		public _003CCountDown_003Ed__31(int _003C_003E1__state)
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
	private DxxText seasonTitle;

	[SerializeField]
	private DxxText countDownTex;

	[SerializeField]
	private DxxText seasonScore;

	[SerializeField]
	private DxxText curRewardTex;

	[SerializeField]
	private DxxText rewardPreviewTex;

	[SerializeField]
	private DxxText nextRewardTip;

	[SerializeField]
	private DxxText clickBtnName;

	[SerializeField]
	private DxxText promotionRewardTip;

	[SerializeField]
	private DxxText rewardLeftTimeTip;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private Daily128SeasonItem seasonItem;

	[SerializeField]
	private NewPlay120SeasonRewardItem newPlay120RewardItem;

	[SerializeField]
	private GameObject curScoreRewardObj;

	[SerializeField]
	private Transform curScoreRewardParent;

	[SerializeField]
	private ButtonCtrl defeatPlayerTipBtn;

	[SerializeField]
	private GameObject tip;

	[SerializeField]
	private ButtonCtrl closeTipBtn;

	[SerializeField]
	private ScrollRect curScoreRewardScroll;

	[SerializeField]
	private ScrollRect rewardListScroll;

	[SerializeField]
	private UITableView tableView;

	private List<NewPlay120SeasonRewardItem> curScoreRewardItemList;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private List<Daily_TrialPoints_128> _datas;

	public STActivityArtifactPointRewardData[] PointRewardDatas;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void CreateCurScoreReward()
	{
	}

	private void ClickTip()
	{
	}

	private void RefreshCountDownText()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__31))]
	private IEnumerator CountDown()
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void InitTableView()
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
}
