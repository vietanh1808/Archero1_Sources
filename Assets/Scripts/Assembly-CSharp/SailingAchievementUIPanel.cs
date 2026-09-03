using System.Collections.Generic;
using PureMVC.Interfaces;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingAchievementUIPanel : MediatorCtrlBase, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public DxxText Text_Level;

	public DxxText Text_Progress;

	public Slider slider;

	public ButtonCtrl Button_Box;

	public DxxText Text_Desc;

	public Animation Box_Ani;

	public GameObject LevelAniObj;

	private int LastLevel;

	private float LastSliderValue;

	public UITableView tableView;

	public SailingAchievementProgressItem item;

	private List<SailingAchievementItemData> dataList;

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

	public override void OnHandleNotification(INotification notification)
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

	private void freshTopInfo()
	{
	}

	private void freshBottomList()
	{
	}

	private void onButtonBox()
	{
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

	private void freshUI()
	{
	}

	private void PlayLevelUpAnimation()
	{
	}

	private void freshBoxItem()
	{
	}
}
