using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;

public class GuildRankUICtrl : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Info;

	public RankCharItem[] topItem;

	public ButtonCtrl Button_Back;

	public GameObject[] Button_Focus;

	public DxxText[] Text_Texs;

	public DxxText Text_Tips;

	private int currentTab;

	public GameObject PopWindow;

	public DxxText Text_Info;

	private RectTransform _scrollRect;

	public UITableView tableView;

	public List<LocalSave.GuildRankItemUIData> rankListTemp;

	public GuildRankItemCell cellItem;

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

	public void init()
	{
	}

	public void showRankList(int type)
	{
	}

	public void hide()
	{
	}

	public void onButtonTab(int tab)
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
