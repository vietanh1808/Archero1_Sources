using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class Act6thDrillTreasureDeepBox : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public UITableView tableView;

	[HideInInspector]
	public List<Act6thDrillTreasureAchievementData> dataList;

	public Act6thDrillTreasureDeepItem cellItem;

	private int rIndex;

	private Act6thDrillTreasureMgr DMgr => null;

	public void Init()
	{
	}

	public void OnOpen()
	{
	}

	private void ScrollToTheUnReceivedBox()
	{
	}

	public void initTableView()
	{
	}

	public void ShowAchieveList()
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
