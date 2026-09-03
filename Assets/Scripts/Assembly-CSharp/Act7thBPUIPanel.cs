using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class Act7thBPUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public DxxText Text_Level;

	public DxxText Text_Progress;

	public Slider slider;

	public ButtonCtrl Button_Normal;

	public ButtonCtrl Button_Premium;

	public DxxText Text_Free;

	public DxxText Text_Normal;

	public DxxText Text_Premium;

	[SerializeField]
	private GameObject ArrowObj;

	[SerializeField]
	private GameObject LevelObj;

	private int currentLevel;

	private long showTimex;

	public UITableView tableView;

	[HideInInspector]
	public List<Act7thBPItemData> dataList;

	public Act7thBPItem cellItem;

	public Act7thBPBoxItem boxItem;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void Esc()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onButtonOpenNormal()
	{
	}

	private void onButtonOpenPremium()
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

	public int checkScorllTo()
	{
		return 0;
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

	public void onButtonTouchScreen()
	{
	}
}
