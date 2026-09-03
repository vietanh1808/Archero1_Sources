using System.Collections.Generic;
using UIKit;
using UnityEngine;

public class BraveCampRewardUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_Title1;

	public DxxText Text_Title2;

	public DxxText noRewardText;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public BraveCampRewardItemCell selfItem;

	public UITableView tableView;

	[HideInInspector]
	public List<BraveCampMgr.BraveCampRewardConfig> dataList;

	public BraveCampRewardItemCell cellItem;

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

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void initUI()
	{
	}

	private void freshTime()
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

	public void onButtonTouchScreen()
	{
	}
}
