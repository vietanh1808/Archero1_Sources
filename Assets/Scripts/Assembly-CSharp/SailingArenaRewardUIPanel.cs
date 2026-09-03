using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class SailingArenaRewardUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public GameObject[] Tab_Focus;

	public DxxText[] Tab_Text;

	private int currentTab;

	public UITableView tableView;

	[HideInInspector]
	public List<SailingArenaRewardItemData> dataList;

	public SailingArenaRewardItem cellItem;

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

	private void showList()
	{
	}

	private void freshTime()
	{
	}

	public void onButtonClose()
	{
	}

	private void Esc()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void showTab(int tab)
	{
	}
}
