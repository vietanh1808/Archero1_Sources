using System.Collections.Generic;
using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class CashGiftTaskUI : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	public DxxText Text_Info;

	public Slider slider;

	public DxxText Text_Count;

	public DxxText Text_Time;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public GameObject Red;

	public GameObject Role;

	public DxxText Text_Role;

	public PropOneEquip oneEquip;

	public UITableView tableView;

	public CashGiftTaskItem cellItem;

	private List<LocalSave.CashTaskItemData> taskList;

	protected void Awake()
	{
	}

	public void init()
	{
	}

	public void onButtonGet()
	{
	}

	public void FreshBoxUI()
	{
	}

	public void FreshTaskItems()
	{
	}

	public void onButtonBox()
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
}
