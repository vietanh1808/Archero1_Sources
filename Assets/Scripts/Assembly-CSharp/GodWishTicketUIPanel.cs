using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class GodWishTicketUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public GameObject Tab_FocusLeft;

	public GameObject Tab_FocusRight;

	public DxxText Tab_TextLeft;

	public DxxText Tab_TextRight;

	public DxxText Text_Desc;

	private int currentTab;

	public UITableView tableView;

	[HideInInspector]
	public List<GodWishTicketData> dataList;

	public GodWishTicketTitleCell cellItem1;

	public GodWishRecordItemCell cellItem2;

	public GodWishTicketItemCell cellItem3;

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

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void showTab(int tab)
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
