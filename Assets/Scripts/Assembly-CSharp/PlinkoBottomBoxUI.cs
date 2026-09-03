using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class PlinkoBottomBoxUI : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_DepthNum;

	public Image Image_Icon;

	public UITableView tableView;

	[HideInInspector]
	public List<PlinkoBoxItemData> dataList;

	public PlinkoBottomBoxItem cellItem;

	public void OnOpen()
	{
	}

	public void initUI()
	{
	}

	private void Scorll()
	{
	}

	public void OnLanguageChanged()
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
}
