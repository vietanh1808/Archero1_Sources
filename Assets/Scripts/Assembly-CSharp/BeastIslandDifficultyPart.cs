using System;
using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class BeastIslandDifficultyPart : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public UITableView tableView;

	public BeastIslandDifficutyItem item;

	private List<BeastIslandDifficultyItemData> dataList;

	public Action<BeastIslandDifficultyItemData> selectDo;

	public void InitTableView()
	{
	}

	public void Open()
	{
	}

	public void Refresh()
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
