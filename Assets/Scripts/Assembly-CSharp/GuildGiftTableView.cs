using System.Collections.Generic;
using Habby.Guild.Data;
using UIKit;
using UnityEngine;

public class GuildGiftTableView : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public GuildGiftUICtrl giftUI;

	public UITableView tableView;

	public List<ChatMsgDataGift> giftDataList;

	public MsgItemGift giftItem;

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

	private void onEventUpdateMessage(string fromid, ActionData action)
	{
	}

	private int getActionIndex(string actionid)
	{
		return 0;
	}

	public void Test_showGiftUI()
	{
	}
}
