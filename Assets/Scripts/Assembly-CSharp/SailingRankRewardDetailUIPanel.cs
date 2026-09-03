using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class SailingRankRewardDetailUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private DxxText areaName;

	[SerializeField]
	private DxxText cond;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private ButtonCtrl clickLeft;

	[SerializeField]
	private ButtonCtrl clickRight;

	[SerializeField]
	private SailingRankRewardDetailItem detailItem;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private RectTransform content;

	public const float DetailItemHeight = 260f;

	public const float DetailItemInterval = 8f;

	public const float ScrollAniDuration = 0.4f;

	public const float ContentNormalHeight = 658f;

	public const float ContentBigHeight = 790f;

	public const int MaxPartitionCount = 6;

	private LocalUnityObjctPool pool;

	private int curSelectAreaIndex;

	private int aniTargetRanking;

	private RankType curType;

	private List<ASSSDataParser.SailingRankRewardData> netConfigList;

	protected override void OnInit()
	{
	}

	private void InitObjectPool()
	{
	}

	private void InitTableView()
	{
	}

	protected override void OnOpen()
	{
	}

	private void FormatList(List<ASSSDataParser.SailingRankRewardData> list)
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

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshArrow()
	{
	}

	private void RefreshAni()
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

	private void ClickClose()
	{
	}

	private void ClickLeft()
	{
	}

	private void ClickRight()
	{
	}
}
