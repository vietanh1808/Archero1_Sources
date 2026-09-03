using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using TableTool;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactActivityUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003COnUpdate_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArtifactActivityUICtrl _003C_003E4__this;

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
		public _003COnUpdate_003Ed__51(int _003C_003E1__state)
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
	private HorizontalLayoutGroup _horizontalLayoutGroup;

	[SerializeField]
	private ButtonCtrl _btnClose;

	[SerializeField]
	private ButtonCtrl _btnTips;

	[SerializeField]
	private ButtonCtrl _btnRank;

	[SerializeField]
	private ButtonCtrl _btnBattle;

	[SerializeField]
	private ButtonCtrl _btnBuy;

	[SerializeField]
	private ButtonCtrl _btnSweep;

	[SerializeField]
	private ButtonCtrl _btnTalent;

	[SerializeField]
	private ButtonCtrl _btnBonusTips;

	[SerializeField]
	private ArtifactActivityRank _rank_1;

	[SerializeField]
	private ArtifactActivityRank _rank_2;

	[SerializeField]
	private ArtifactActivityRank _rank_3;

	[SerializeField]
	private ArtifactActivityRank _rank_self;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textRemainTime;

	[SerializeField]
	private DxxText _textTotalTalent;

	[SerializeField]
	private DxxText _textTotalTalent2;

	[SerializeField]
	private DxxText _textBattle;

	[SerializeField]
	private DxxText _textBuy;

	[SerializeField]
	private DxxText _textSweep;

	[SerializeField]
	private DxxText _textBlessTotal;

	[SerializeField]
	private DxxText _textKey;

	[SerializeField]
	private DxxText _textDiamond;

	[SerializeField]
	private DxxText _textSweepKey;

	[SerializeField]
	private DxxText _textTalent;

	[SerializeField]
	private DxxText _textRemainCnt;

	[SerializeField]
	private DxxText _textRemainBuyCnt;

	[SerializeField]
	private ArtifactActivityTipsUICtrl _artifactActivityTips;

	[Header("难度列表")]
	[SerializeField]
	private UITableView _tableView;

	[SerializeField]
	private ArtifactActivityItem _copyone;

	[Header("进度条")]
	[SerializeField]
	private ArtifactActivityProgressCtrl _activityProgress;

	[SerializeField]
	private RedNodeCtrl _talentRedNodeCtrl;

	private LocalUnityObjctPool _pool;

	private Coroutine _coroutine;

	private WaitForSeconds _wait;

	private IList<Daily_TrialDifficulty_128> _datas;

	private ArtifactActivityItem _selectItem;

	private const int maxWidth = 600;

	private ArtifactActivityManager _manager => null;

	private long CD => 0L;

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

	private void UpdateSweepBtnStatus()
	{
	}

	private void UpdateTalentBless()
	{
	}

	private void UpdateTotalTalentProgress()
	{
	}

	private void UpdateRanks()
	{
	}

	private void OnClickBuyBtn()
	{
	}

	private void OnClickBattleBtn()
	{
	}

	[IteratorStateMachine(typeof(_003COnUpdate_003Ed__51))]
	private IEnumerator OnUpdate()
	{
		return null;
	}

	private void UpdateCdText()
	{
	}

	private void CheckWait()
	{
	}

	private void OnSelectLevel(ArtifactActivityItem item)
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
