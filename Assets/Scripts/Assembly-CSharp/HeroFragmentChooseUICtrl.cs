using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class HeroFragmentChooseUICtrl : MediatorCtrlBase, IUIGridViewDataSource, IUITableViewDataSource, IUITableViewDelegate
{
	public HeroFragChooseItem topItem;

	public DxxText Text_Title;

	public DxxText Text_TopInfo;

	public DxxText Text_BottomInfo;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Choose;

	public DxxText Text_Choose;

	public GameObject MaskPanel;

	public Image Image_HeroFly;

	public RectTransform Window;

	public int tempHeroId;

	public UITableView tableView;

	public HeroFragChooseItem cellItem;

	private List<HeroFragChooseData> heroList;

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

	private void init()
	{
	}

	private void chooseHero(int hid)
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonChoose()
	{
	}

	private void PlayMove(int hid, Vector3 begin, Action callback = null)
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

	public int NumberOfCellsAtRowOrColumnInGrid(UITableView tableView)
	{
		return 0;
	}

	public UITableViewCellAlignment AlignmentOfCellsAtRowOrColumnInGrid(UITableView grid)
	{
		return UITableViewCellAlignment.RightOrTop;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}
}
