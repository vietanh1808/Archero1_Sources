using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class FishingRankingRewardUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText rewardDesc;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ToggleGroup toggleGroup;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private FishingRankingRewardItem item;

	[SerializeField]
	private FishingRankingRewardBtn tabBtn;

	[SerializeField]
	private Transform tabBtnParent;

	private int selectRank;

	private LocalUnityObjctPool pool;

	private int curSelectIndex;

	private FishingManager FishingManager => null;

	private FishingRankingRewardData FishingRankingRewardData => null;

	private int CurSelectGroup => 0;

	private void InitTableView()
	{
	}

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

	private void Refresh()
	{
	}

	private void RefreshBtn()
	{
	}

	private void RefreshText()
	{
	}

	public void ClickTab(int index)
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

	private void Esc()
	{
	}
}
