using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class PlinkoGiftUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public StarDiamondItem starDiamond;

	[SerializeField]
	private OfficialStoreBannerCtrl _goOfficialStoreBanner;

	public UITableView tableView;

	[HideInInspector]
	public List<PlinkoActGiftItemData> dataList;

	public PlinkoGiftItemCell cellItem;

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

	public void onButtonClose()
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

	public void showGiftList()
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
