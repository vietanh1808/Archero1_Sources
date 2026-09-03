using System;
using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class MissionQueueUI : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_TitleQueue;

	public DxxText Text_QueueCount;

	public DxxText Text_TitleEmploy;

	public DxxText Text_Fresh;

	public ButtonCtrl Button_Fresh;

	public GameObject Icon_Diamond;

	public DxxText Text_Diamond;

	public AdsController ads;

	public ButtonCtrl Button_Ad;

	public DxxText Ad_Fresh;

	public MissionQueueItem[] queueItems;

	private int FreshNeedDiamond;

	public GameObject Fly_MaskPanel;

	public Image Fly_MonBG;

	public Image Fly_Mon;

	public UITableView tableView;

	public MissionQueueItemCell cellItem;

	private List<MissionEmployItemData> employList;

	protected void Awake()
	{
	}

	public void init()
	{
	}

	public void onButtonFresh()
	{
	}

	private void onButtonAd()
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

	public void FlyMonster(MissionEmployFlyData data)
	{
	}

	private void PlayMove(int mid, Vector3 spos, Vector3 epos, Action callback = null)
	{
	}
}
