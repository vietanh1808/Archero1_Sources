using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UIKit;
using UnityEngine;

public class FarmRankUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_Stage;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Last;

	public DxxText Text_Last;

	public GameObject Window_Info;

	private int Area;

	private int SubArea;

	private int Season;

	public RectTransform window;

	public FarmRankItemCell bottomCell;

	private bool currentSeason;

	public GameObject PopReward;

	public RectTransform PopContainer;

	public GameObject cpProp;

	public UITableView tableView;

	public List<FarmRankData> farmRankDataList;

	public FarmRankItemCell cellItem;

	private float top;

	private float bottom;

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

	public void onButtonInfo()
	{
	}

	public void onButtonLast()
	{
	}

	private void boxItemClick(Vector3 pos, List<Drop_DropModel.DropData> list)
	{
	}

	public void showPopReward(FarmRankRewardData data)
	{
	}

	public void onButtonClickPopReward()
	{
	}

	public void init()
	{
	}

	public void show(bool current)
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
}
