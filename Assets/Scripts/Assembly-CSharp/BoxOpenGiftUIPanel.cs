using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;

public class BoxOpenGiftUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_TimeEnd;

	public ButtonCtrl Button_Close;

	public StarDiamondItem sItem;

	private long showTimex;

	public UITableView tableView;

	public BoxOpenGiftItemCell cellItem;

	private List<BoxOpenGiftData> dataList;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void initUI()
	{
	}

	public void onButtonClose()
	{
	}

	private void UpdateTime()
	{
	}

	private void initTableView()
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
