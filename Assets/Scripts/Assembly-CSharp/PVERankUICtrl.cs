using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class PVERankUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_Area;

	public ButtonCtrl Button_Info;

	public ButtonCtrl Button_Back;

	public DxxText Text_Tips;

	public DxxText Text_Time;

	private int currentTab;

	public DxxText Text_Info;

	public PVERankItemMe cellItemMe;

	public GameObject PopReward;

	public RectTransform PopContainer;

	public GameObject cpProp;

	[SerializeField]
	private GameObject Focus_Season;

	[SerializeField]
	private DxxText Text_Season;

	[SerializeField]
	private GameObject Focus_Soul;

	[SerializeField]
	private DxxText Text_Soul;

	public UITableView tableView;

	public List<PVERankItemData> rankListTemp;

	public PVERankItemCell cellItem;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	private void android_escape()
	{
	}

	public void showPopReward(PVERankRewardData data)
	{
	}

	public void onButtonClickPopReward()
	{
	}

	public void initTableView()
	{
	}

	public void showRankList(int tab)
	{
	}

	public void hide()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void showButtonState()
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
