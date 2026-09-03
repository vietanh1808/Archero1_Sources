using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class SailingArenaVSUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Fresh;

	public DxxText Text_Fresh;

	public ButtonCtrl Button_TicketBuy;

	public DxxText Text_Ticket;

	public DxxText Text_Power;

	public DxxText Text_Tips;

	private long openUITime;

	public UITableView tableView;

	[HideInInspector]
	public List<SailingArenaItemData> dataList;

	public SailingArenaVSItem cellItem;

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

	private void initUI()
	{
	}

	private void freshTopInfo()
	{
	}

	private void showList()
	{
	}

	public void onButtonClose()
	{
	}

	private void onButtonFresh()
	{
	}

	private void onButtonTicketBuy()
	{
	}

	private void Esc()
	{
	}
}
