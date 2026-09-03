using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class GuildHelpListWindow : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public UITableView tableView;

	public GuildHelpMeItem helpItem;

	public DxxText Text_Desc;

	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public List<HelpMeData> helpDataList;

	private float topPadding;

	private float bottomPadding;

	private bool isInit;

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

	public void init()
	{
	}

	public void showWindow(List<HelpMeData> list)
	{
	}

	public void hideWindow()
	{
	}

	public void onButtonHideWindow()
	{
	}
}
