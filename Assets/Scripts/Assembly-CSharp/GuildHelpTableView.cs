using System.Collections.Generic;
using Habby.Guild.Data;
using UIKit;
using UnityEngine;

public class GuildHelpTableView : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public GuildHelpUICtrl helpUI;

	public UITableView tableView;

	public List<ChatMsgDataHelp> helpTotalDataList;

	public List<ChatMsgDataHelp> helpDataList;

	public MsgItemHelp helpItem;

	private float topPadding;

	private float bottomPadding;

	public void init()
	{
	}

	public void show()
	{
	}

	public void hide()
	{
	}

	public void updateTableCells()
	{
	}

	public void showHelpCategory(int tab, bool scroll = true)
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

	public void updatePushMessage(string fromid, ActionData action)
	{
	}

	private int getActionIndex(string actionid)
	{
		return 0;
	}

	private int getActionIndexForShow(string actionid)
	{
		return 0;
	}

	public void Test_showHelpUI()
	{
	}
}
