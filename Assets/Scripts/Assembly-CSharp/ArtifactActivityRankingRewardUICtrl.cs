using System.Collections.Generic;
using TableTool;
using UIKit;
using UnityEngine;

public class ArtifactActivityRankingRewardUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private ButtonCtrl _btnClose;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private ArtifactActivityRankingRewardItem _copyOne;

	[SerializeField]
	private RectTransform _content;

	[SerializeField]
	private UITableView _tableView;

	private IList<Daily_TrialRank_128> _datas;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
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
