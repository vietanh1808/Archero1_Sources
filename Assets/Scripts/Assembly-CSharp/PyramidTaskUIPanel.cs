using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class PyramidTaskUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private ButtonCtrl btn_Close;

	private ActPyramidTreasureMgr ptMgr;

	public UITableView tableView;

	[HideInInspector]
	public List<PyramidTaskData> dataList;

	public PyramidTaskItem cellItem;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Esc()
	{
	}

	public void OnBtnCloseClick()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void initTableView()
	{
	}

	public void showTaskList()
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
